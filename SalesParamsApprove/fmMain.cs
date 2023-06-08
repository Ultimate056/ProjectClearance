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
using SalesParamsApprove.Extensions;
using System.Data.SqlClient;
using SalesParamsApprove.Models;
using Dapper;

namespace SalesParamsApprove
{
    public partial class fmMain : Form
    {

        private DataSale FocusedSale = new DataSale();
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-RU");

        public fmMain()
        {
            InitializeComponent();

            textBoxCurRemain.DataBindings.Add(new Binding("Text", FocusedSale, "CurrentRest", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxCurDays.DataBindings.Add(new Binding("Text", FocusedSale, "CurrentRestDays", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxTargetDays.DataBindings.Add(new Binding("Text", FocusedSale, "TargetRestDays", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxCurTemp.DataBindings.Add(new Binding("Text", FocusedSale, "CurrentRateSales", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxHO.DataBindings.Add(new Binding("Text", FocusedSale, "NO", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxSaleDays.DataBindings.Add(new Binding("Text", FocusedSale, "SaleDays", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxRequireTemp.DataBindings.Add(new Binding("Text", FocusedSale, "TargetRateSales", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxMCSales.DataBindings.Add(new Binding("Text", FocusedSale, "MCSales", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxMCMarket.DataBindings.Add(new Binding("Text", FocusedSale, "MCMarket", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxDiscountMC.DataBindings.Add(new Binding("Text", FocusedSale, "MCDiscount", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxPeriodAlertRTK.DataBindings.Add(new Binding("Text", FocusedSale, "PeriodAlertRTK", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxPeriodAnal.DataBindings.Add(new Binding("Text", FocusedSale, "PeriodAnalize", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxStepSale.DataBindings.Add(new Binding("Text", FocusedSale, "StepSale", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxSebest.DataBindings.Add(new Binding("Text", FocusedSale, "Sebest", false, DataSourceUpdateMode.OnPropertyChanged));

            checkBoxA1.DataBindings.Add(new Binding("Checked", FocusedSale, "fA1", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxAR.DataBindings.Add(new Binding("Checked", FocusedSale, "fAP", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxIP.DataBindings.Add(new Binding("Checked", FocusedSale, "fIP", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxKP.DataBindings.Add(new Binding("Checked", FocusedSale, "fKP", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxOPT.DataBindings.Add(new Binding("Checked", FocusedSale, "fOpt", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxSpec.DataBindings.Add(new Binding("Checked", FocusedSale, "fExist", false, DataSourceUpdateMode.OnPropertyChanged));
        }


        private void fmMain_Load(object sender, EventArgs e)
        {
            fillgcSKU();
        }

        private void fillgcSKU()
        {
            try
            {
                string sql = @"select  spr_tm.tm_name as Brand, spr_tov.id_tov as idSKU, spr_tov.id_tov_oem as Art, spr_tov.n_tov as Ntov, sAdvancement.nAdvancement as SaleStatus
                                from spr_tov 
                                inner join spr_tm on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement on spr_tov.idAdvancement = sAdvancement.idAdvancement
                                where sAdvancement.idAdvancement > 2
                                order by sAdvancement.idAdvancement";

                gcSKU.DataSource = DBExecute.SelectTable(sql);
                //DataTable ds = DBExecute.SelectTable(sql);
                //gcSKU.DataSource = ds;
                //fillRightData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка заполнения SKU " + ex.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Утвердить данные о распродаже товара {GetFocusedTovName()}?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string sql = $@"Update rClearanceValue set 
                                restTarget = {FocusedSale.TargetRestDaysValue},
                                rateSalesTarget  = {FocusedSale.TargetRateSalesValues},
                                minPriceClearance = {FocusedSale.MCSalesValue},
                                priceMarketDiscount = {FocusedSale.MCDiscountValue},
                                periodAnalize = {FocusedSale.PeriodAnalizeValue},
                                periodAlertRTK = {FocusedSale.PeriodAlertRTKValue},
                                daysClearance = {FocusedSale.SaleDaysValue},
                                stepClearance = {FocusedSale.StepSaleValue},
                                fKP = {FocusedSale.fKP},
                                fAP = {FocusedSale.fAP},
                                fIP = {FocusedSale.fIP},
                                fOpt = {FocusedSale.fOpt},
                                fA1 = {FocusedSale.fA1}, 
                                fExist = {FocusedSale.fExist}
                                WHERE idtov = {FocusedSale.idtov}";

                DBExecute.ExecuteQuery(sql);
                RefreshData();
            }

        }

        private void gvSKU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            FocusedSale.isInit = true;
            fillRightData();
            FocusedSale.isInit = false;
        }

        private string GetFocusedTovName()
        {
            DataRow focusrow = gvSKU.GetFocusedDataRow();
            if (focusrow == null)
                return "";
            string tovname = focusrow["Brand"].ToString() + " " + focusrow["Art"].ToString();
            return tovname;
        }

        public void fillRightData()
        {
            try
            {
                DataRow focusrow = gvSKU.GetFocusedDataRow();

                if (focusrow == null)
                    return;

                int idtov = Convert.ToInt32(focusrow["idSKU"]);

                using (IDbConnection db = new SqlConnection(Connection.ConnectionString))
                {
                    var temp = db.Query<DataSale>
                        ($@"select rest as CurrentRest, 
                                    restDays as CurrentRestDays,
                                    DaysTurnoverNorm as NO,
                                    cast(rateSales as numeric(18,2)) as CurrentRateSales,
                                    cast(priceMarket as numeric(18,2)) as MCMarket,
                                    cast(sebest as numeric(18,2)) as Sebest
                            from [dbo].[uf_getValuesForClearance] ({idtov})")
                        .FirstOrDefault();
                    FocusedSale.idtov = idtov;
                    FocusedSale.CurrentRest = temp.CurrentRest;
                    FocusedSale.CurrentRestDays = temp.CurrentRestDays;
                    FocusedSale.NO = temp.NO;
                    FocusedSale.CurrentRateSales = temp.CurrentRateSales;
                    FocusedSale.MCMarket = temp.MCMarket;
                    FocusedSale.Sebest = temp.Sebest;
                }

                fillRightWhiteData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " +  ex.Message);
            }
        }

        public void fillRightWhiteData()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(Connection.ConnectionString))
                {
                    var temp = db.Query<DataSale>
                        ($@"select restTarget as TargetRestDays,
                                    cast(rateSalesTarget as numeric(18,2)) as TargetRateSales,
                                    daysClearance as SaleDays,
                                    cast(minPriceClearance as numeric(18,2)) as MCSales,
                                    cast(priceMarketDiscount as numeric(18,2)) as MCDiscount,
                                    cast(stepClearance as numeric(18,2)) as StepSale,
                                    periodAnalize as PeriodAnalize,
                                    periodAlertRTK as PeriodAlertRTK,
                                    fAP, fIP, fOpt, fA1, fExist, fKP
                            from rClearanceValue WHERE idtov = {FocusedSale.idtov}")
                        .FirstOrDefault();

                    if (temp != null)
                    {
                        FocusedSale.TargetRestDays = temp.TargetRestDays;
                        FocusedSale.TargetRateSales = temp.TargetRateSales;
                        FocusedSale.SaleDays = temp.SaleDays;
                        FocusedSale.MCSales = temp.MCSales;
                        FocusedSale.MCDiscount = temp.MCDiscount;
                        FocusedSale.StepSale = temp.StepSale;
                        FocusedSale.PeriodAnalize = temp.PeriodAnalize;
                        FocusedSale.PeriodAlertRTK = temp.PeriodAlertRTK;
                        FocusedSale.fAP = temp.fAP;
                        FocusedSale.fIP = temp.fIP;
                        FocusedSale.fOpt = temp.fOpt;
                        FocusedSale.fKP = temp.fKP;
                        FocusedSale.fExist = temp.fExist;
                        FocusedSale.fA1 = temp.fA1;

                        textBoxTargetDays.Enabled = FocusedSale.TargetRestDaysValue > 0;
                        textBoxTargetDays.ReadOnly = FocusedSale.TargetRestDaysValue == 0;
                    }
                    else
                        FocusedSale.Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
            }
        }
    }
}
