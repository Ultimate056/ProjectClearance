using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesParamsApprove.Database;
using System.Threading;

namespace SalesParamsApprove
{
    public partial class fmMain : Form
    {
        public void fillgcSKU()
        {
            try
            {
                string sql = @"select  spr_tm.tm_name as Brand, spr_tov.id_tov as idSKU, spr_tov.id_tov_oem as Art, spr_tov.n_tov as Ntov, sAdvancement.nAdvancement as SaleStatus
                                from spr_tov 
                                inner join spr_tm on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement on spr_tov.idAdvancement = sAdvancement.idAdvancement
                                where sAdvancement.idAdvancement > 2
                                order by sAdvancement.idAdvancement ";

                gcSKU.DataSource = DBExecute.SelectTable(sql);
                //DataTable ds = DBExecute.SelectTable(sql);
                //gcSKU.DataSource = ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка заполнения SKU " + ex.Message);
            }
        }


        public void fillRightGreyData()
        {
            try
            {

                DataRow focusrow = gvSKU.GetFocusedDataRow();
                int idtov = Convert.ToInt32(focusrow["idSKU"]);
                string sql = $@"select * from [dbo].[uf_getValuesForClearance] ({idtov})";
                DataTable res = DBExecute.SelectTable(sql);
                textBoxCurRemain.Text = res.Rows[0]["rest"].ToString(); //Текущий остаток, шт
                textBoxCurDays.Text = res.Rows[0]["restdays"].ToString(); //Текущий остаток, дн:
                textBoxCurTemp.Text = res.Rows[0]["rateSales"].ToString(); //Текущий темп продаж
                textBoxHO.Text = res.Rows[0]["DaysTurnoverNorm"].ToString(); //Норм.оборачиваемость, дней:
                textBoxMCMarket.Text = res.Rows[0]["priceMarket"].ToString(); //МЦ рынка


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
            }
        }


        public void fillRightWhiteData()
        {
            try
            {
                DataRow focusrow = gvSKU.GetFocusedDataRow();
                int idtov = Convert.ToInt32(focusrow["idSKU"]);
                string sql = $@"select * FROM rClearanceValue where idtov = {idtov}";
                
                DataTable res = DBExecute.SelectTable(sql);
                if (res.Rows.Count > 0)
                {
                    textBoxTargetDays.Text = res.Rows[0]["restTarget"].ToString(); //Текущий остаток, шт
                    textBoxSaleDays.Text = res.Rows[0]["rateSalesTarget"].ToString(); //Текущий остаток, дн:
                    textBoxMCSales.Text = res.Rows[0]["minPriceClearance"].ToString(); //Текущий темп продаж
                    textBoxDiscountMC.Text = res.Rows[0]["priceMarketDiscount"].ToString(); //Норм.оборачиваемость, дней:
                    textBoxPeriod.Text = res.Rows[0]["periodAnalize"].ToString(); //МЦ рынка
                    textBoxPeriodA.Text = res.Rows[0]["periodAlertRTK"].ToString(); //МЦ рынка
                    checkBoxAR.Checked = Convert.ToInt32(res.Rows[0]["fAP"]) == 1 ? true : false; //МЦ рынка
                    checkBoxIP.Checked = Convert.ToInt32(res.Rows[0]["fIP"]) == 1 ? true : false; //МЦ рынка
                    checkBoxOPT.Checked = Convert.ToInt32(res.Rows[0]["fOpt"]) == 1 ? true : false; //МЦ рынка
                    checkBoxA1.Checked = Convert.ToInt32(res.Rows[0]["fA1"]) == 1 ? true : false; //МЦ рынка
                    checkBoxSpec.Checked = Convert.ToInt32(res.Rows[0]["fExist"]) == 1 ? true : false;  //МЦ рынка
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
            }
        }

        public bool CheckDataForStepSale(string val)
        {
            double Val;
            return double.TryParse(val, out Val);
        }


        public void CalcStepSale() //Расчет Шага распродажи
        {
            try
            {
                if (CheckDataForStepSale(textBoxMCMarket.Text) && CheckDataForStepSale(textBoxDiscountMC.Text) && CheckDataForStepSale(textBoxMCSales.Text) && CheckDataForStepSale(textBoxSaleDays.Text) && CheckDataForStepSale(textBoxPeriodA.Text))
                {
                    double MCMarket, DiscountMC, MCSales, SaleDays, PeriodA;
                    MCMarket = Convert.ToDouble(textBoxMCMarket.Text);
                    DiscountMC = Convert.ToDouble(textBoxDiscountMC.Text);
                    MCSales = Convert.ToDouble(textBoxMCSales.Text);
                    SaleDays = Convert.ToDouble(textBoxSaleDays.Text);
                    PeriodA = Convert.ToDouble(textBoxPeriodA.Text);
                    if ((PeriodA > 0) && (SaleDays > 0) && (SaleDays / PeriodA) > 0 && (MCMarket > 0))
                    {
                        textBoxStepSale.Text = Convert.ToString(
                            Math.Round((
                            ((MCMarket - MCMarket * (DiscountMC / 100)) - MCMarket * (MCSales / 100)) / (SaleDays / PeriodA)
                            ),2)
                            );
                    }
                    else
                    {
                        textBoxStepSale.Text = "0";
                        //MessageBox.Show("Проверьте заполнение полей 'Срок распродажи' и 'Период анализа'", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    textBoxStepSale.Text = "0";
                    //MessageBox.Show("Проверьте заполнение полей", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void CalcRequireTempSale()
        {
            if (CheckDataForStepSale(textBoxTargetDays.Text) && CheckDataForStepSale(textBoxSaleDays.Text))
            {
                double TargetDays = Convert.ToDouble(textBoxTargetDays.Text);
                double SaleDays = Convert.ToDouble(textBoxSaleDays.Text);
                textBoxRequireTemp.Text = Math.Round((TargetDays / SaleDays),2).ToString();
            }
            else
            {
                textBoxRequireTemp.Text = "0";
            }

        }

        public void SendApprove()
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int AR = checkBoxAR.Checked ? 1 : 0;
                    int IP = checkBoxIP.Checked ? 1 : 0;
                    int OPT = checkBoxOPT.Checked ? 1 : 0;
                    int A1 = checkBoxA1.Checked ? 1 : 0;
                    int Exist = checkBoxSpec.Checked ? 1 : 0;

                    string sql = $@"Update rClearanceValue set 
                                restTarget = {Convert.ToInt32(textBoxTargetDays.Text)},
                                rateSalesTarget  = {Convert.ToInt32(textBoxSaleDays.Text)},
                                minPriceClearance = {Convert.ToDouble(textBoxMCSales.Text)},
                                priceMarketDiscount = {Convert.ToDouble(textBoxDiscountMC.Text)},
                                periodAnalize = {Convert.ToInt32(textBoxPeriodA.Text)},
                                periodAlertRTK = {Convert.ToInt32(textBoxPeriod.Text)},
                                fAP = {AR},
                                fIP = {IP},
                                fOpt = {OPT},
                                fA1 = {A1}, 
                                fExist = {Exist}
                                WHERE idtov = {gvSKU.GetFocusedDataRow()["idSKU"]}";

                    DBExecute.ExecuteQuery(sql);
                    fillRightGreyData();
                    fillRightWhiteData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public async Task NewsAsync()
        {
            await Task.Run(() => News());
        }

        public void News()
        {

                    List<string> list = new List<string>();
                    list.Add("Согласуй!");
                    list.Add("Ну согласуй уже!");
                    list.Add("Капитализуруй! Властвуй! Продавай!");
                    list.Add("Продай подороже, заработай побольше.");
                    list.Add("Мне нужны твои согласования!");
                    list.Add("50 оттенков КП");
                    list.Add("Клиент всегда прав, но по нашей цене!");
             

                    string temp;

                    int fontWidth = newslbl.Font.Height / 2;
                    int countCharInFixedLabel = newslbl.Width / fontWidth;
                    while (Form.ActiveForm == fmMain.ActiveForm)
                    {
                                foreach(string h in list)
                                {
                                    temp = h;
                                            for (int i = 0; i < 350; i++)
                                            {

                                                        try
                                                        {
                                                            Thread.Sleep(80);
                                                            BeginInvoke((MethodInvoker)delegate
                                                            {
                                                                temp = " " + temp;
                                                                newslbl.Text = temp;
                                                            });
                                                        }
                                                        catch (Exception ex)
                                                        {

                                                            break;
                                                        }
                                            }
                                }
                    }
        }




    }
}
