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
using SalesParamsApprove.Repositories;

namespace SalesParamsApprove
{
    public partial class fmMain : Form
    {

        private DataSale FocusedSale = new DataSale();
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-RU");
        private MainRepo repo = new MainRepo();

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
            //textBoxSebest.DataBindings.Add(new Binding("Text", FocusedSale, "Sebest", false, DataSourceUpdateMode.OnPropertyChanged));

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
           gcSKU.DataSource = repo.GetTableTovs();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (FocusedSale.idtov < 1)
                return;
            DialogResult result = MessageBox.Show($"Утвердить параметры распродажи товара {GetFocusedTovName()}?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    repo.ApproveSale(FocusedSale);
                    fillgcSKU();

                    MessageBox.Show("Параметры успешно утверждены", "Утверждение параметров", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка утверждения. " + ex.Message);
                }
            }

        }

        private void gvSKU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshData();
        }

        // Обновление полей
        private void RefreshData()
        {
            // isInit нужен, чтобы данные зависимых полей не обновлялись на 1 раз
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

        // Заполнение константных полей (readonly)
        public void fillRightData()
        {
            try
            {
                DataRow focusrow = gvSKU.GetFocusedDataRow();

                if (focusrow == null)
                    return;

                int idtov = Convert.ToInt32(focusrow["idSKU"]);
                StatusSale sale = (StatusSale)Convert.ToInt32(focusrow["idStatus"]);

                btnSaveData.Enabled = !(sale == StatusSale.InSales);
                btnApprove.Enabled = !(sale == StatusSale.InSales || sale == StatusSale.NeedChangeParams);

                var temp = repo.GetConstFields(idtov);
                FocusedSale.Status = sale;
                FocusedSale.idtov = idtov;
                FocusedSale.CurrentRest = temp.CurrentRest;
                FocusedSale.CurrentRestDays = temp.CurrentRestDays;
                FocusedSale.NO = temp.NO;
                FocusedSale.CurrentRateSales = temp.CurrentRateSales;
                FocusedSale.MCMarket = temp.MCMarket;
                FocusedSale.Sebest = temp.Sebest;

                fillRightWhiteData();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " +  ex.Message);
            }
        }

        // Заполнение рассчитываемых или вручную задаваемых полей
        public void fillRightWhiteData()
        {
            try
            {
                DataSale temp = repo.GetEditableFields(FocusedSale.idtov);
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
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if(FocusedSale.idtov > 0)
            {
                repo.SaveSale(FocusedSale);
                MessageBox.Show("Параметры успешно сохранены", "Сохранение параметров",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnRefreshData_Click(object sender, EventArgs e)
        {
            fillgcSKU();
        }

    }
}
