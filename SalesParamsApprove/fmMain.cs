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
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace SalesParamsApprove
{
    public partial class fmMain : Form
    {

        private DataSale FocusedSale = new DataSale();
        private System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("ru-RU");
        private MainRepo repo = new MainRepo();
        private string ListAccessTovGroup = "";
        public fmMain()
        {
            InitializeComponent();

            teCurRemain.DataBindings.Add(new Binding("Text", FocusedSale, "CurrentRest", true, DataSourceUpdateMode.OnPropertyChanged));
            teCurDays.DataBindings.Add(new Binding("Text", FocusedSale, "CurrentRestDays", true, DataSourceUpdateMode.OnPropertyChanged));
            teTargetRemain.DataBindings.Add(new Binding("Text", FocusedSale, "TargetRestDays", true, DataSourceUpdateMode.OnPropertyChanged));
            teCurTemp.DataBindings.Add(new Binding("Text", FocusedSale, "CurrentRateSales", true, DataSourceUpdateMode.OnPropertyChanged));
            teHO.DataBindings.Add(new Binding("Text", FocusedSale, "NO", true, DataSourceUpdateMode.OnPropertyChanged));
            teSaleDays.DataBindings.Add(new Binding("Text", FocusedSale, "SaleDays", true, DataSourceUpdateMode.OnPropertyChanged));
            teRequireTemp.DataBindings.Add(new Binding("Text", FocusedSale, "TargetRateSales", true, DataSourceUpdateMode.OnPropertyChanged));
            teMCSales.DataBindings.Add(new Binding("Text", FocusedSale, "MCSales", true, DataSourceUpdateMode.OnPropertyChanged));
            teMCMarket.DataBindings.Add(new Binding("Text", FocusedSale, "MCMarket", true, DataSourceUpdateMode.OnPropertyChanged));
            teDiscountMC.DataBindings.Add(new Binding("Text", FocusedSale, "MCDiscount", true, DataSourceUpdateMode.OnPropertyChanged));
            tePeriodAlertRTK.DataBindings.Add(new Binding("Text", FocusedSale, "PeriodAlertRTK", true, DataSourceUpdateMode.OnPropertyChanged));
            tePeriodAnal.DataBindings.Add(new Binding("Text", FocusedSale, "PeriodAnalize", true, DataSourceUpdateMode.OnPropertyChanged));
            teStepSale.DataBindings.Add(new Binding("Text", FocusedSale, "StepSale", true, DataSourceUpdateMode.OnPropertyChanged));
            teCurPriceSale.DataBindings.Add(new Binding("Text", FocusedSale, "PriceSale", true, DataSourceUpdateMode.OnPropertyChanged));
            teDate.DataBindings.Add(new Binding("Text", FocusedSale, "DateSaleString", true, DataSourceUpdateMode.OnPropertyChanged));
            //textBoxSebest.DataBindings.Add(new Binding("Text", FocusedSale, "Sebest", false, DataSourceUpdateMode.OnPropertyChanged));

            checkBoxA1.DataBindings.Add(new Binding("Checked", FocusedSale, "fA1", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxAR.DataBindings.Add(new Binding("Checked", FocusedSale, "fAP", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxIP.DataBindings.Add(new Binding("Checked", FocusedSale, "fIP", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxOPT.DataBindings.Add(new Binding("Checked", FocusedSale, "fOpt", false, DataSourceUpdateMode.OnPropertyChanged));
            checkBoxSpec.DataBindings.Add(new Binding("Checked", FocusedSale, "fExist", false, DataSourceUpdateMode.OnPropertyChanged));

            teTargetRemain.EditValueChanged += teIntField_EditValueChanged;
            tePeriodAnal.EditValueChanged += teIntField_EditValueChanged;
            teSaleDays.EditValueChanged += teIntField_EditValueChanged;
            tePeriodAlertRTK.EditValueChanged += teIntField_EditValueChanged;
            teMCSales.EditValueChanged += teDoubleField_EditValueChanged;
            teDiscountMC.EditValueChanged += teDoubleField_EditValueChanged;

            teMCSales.CustomDisplayText += teProcentField_CustomDisplayText;
            teMCMarket.CustomDisplayText += teRubField_CustomDisplayText;
            teDiscountMC.CustomDisplayText  += teProcentField_CustomDisplayText;
            teStepSale.CustomDisplayText += teRubField_CustomDisplayText;
            teCurPriceSale.CustomDisplayText += teRubField_CustomDisplayText;
        }

        #region fills
        private void fmMain_Load(object sender, EventArgs e)
        {
            ListAccessTovGroup = repo.GetListAccessTovGroup(User.CurrentUserId).ToString();
            gcSKU.DataSource = repo.GetTableTovs(ListAccessTovGroup);
        }
        // Обновление полей
        private void RefreshData()
        {
            Cursor.Current = Cursors.WaitCursor;
            // isInit нужен, чтобы данные зависимых полей не обновлялись на первый раз
            FocusedSale.isInit = true;
            fillRightData();
            FocusedSale.isInit = false;
            Cursor.Current = Cursors.Default;
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
                int idsale = Convert.ToInt32(focusrow["idSale"]);
                DistributeRoles(sale);

                var temp = repo.GetConstFields(idtov);
                FocusedSale.Status = sale;
                FocusedSale.idtov = idtov;
                FocusedSale.idSale = idsale;
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

                MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
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
                    FocusedSale.fExist = temp.fExist;
                    FocusedSale.fA1 = temp.fA1;

                    if(FocusedSale.Status != StatusSale.SuggestToSale)
                    {
                        // Рассчитываем новые данные: цену распродажи и стартовую дату распродажи
                        FocusedSale.PriceSale = temp.PriceSale;
                        FocusedSale.DateSale = temp.DateSale;
                        FocusedSale.DateSaleString = FocusedSale.DateSale.ToString("HH:mm dd.MM.yy");


                        if(FocusedSale.Status == StatusSale.NeddChangeParamsOff ||
                            FocusedSale.Status == StatusSale.EndSale)
                        {
                            LabelOptOne.Visible = true;
                            string sql = $"SELECT restEnd, restDaysEnd, rateSalesEnd, minPriceEnd FROM rClearanceValue WHERE idClearanceValue = {FocusedSale.idSale}";
                            DataRow row = DBExecute.SelectRow(sql);


                        }
                        else
                        {
                            // Рассчитываем новые данные: текущий объём продаж в течение срока распродажи
                            decimal newRateSales = repo.GetCurrentRateSales(FocusedSale.idtov);
                            FocusedSale.CurrentRateSales = newRateSales.ToString();
                        }
                    }



                    teTargetRemain.Enabled = FocusedSale.TargetRestDaysValue > 0;
                    teTargetRemain.ReadOnly = FocusedSale.TargetRestDaysValue == 0;
                }
                else
                    FocusedSale.Clear();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при заполнении полей: " + ex.Message);
            }
        }
        #endregion

        #region Buttons
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (FocusedSale.idtov < 1)
                return;
            string resVal = isFinalValidate(FocusedSale);
            if (resVal != "ok")
            {
                MessageBox.Show(resVal, "Есть невалидные поля", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show($"Утвердить параметры распродажи товара {GetFocusedTovName()}?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    repo.ApproveSale(FocusedSale);
                    checkHistorySales_CheckedChanged(null, null);
                    RefreshData();
                    MessageBox.Show("Параметры успешно утверждены", "Утверждение параметров",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка утверждения. " + ex.Message);
                }
            }

        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (FocusedSale.idtov > 0)
            {
                string resVal = isFinalValidate(FocusedSale);
                if (resVal != "ok")
                {
                    MessageBox.Show(resVal, "Есть невалидные поля", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
                if (FocusedSale.Status == StatusSale.NeedChangeParams)
                {
                    // Сохраняем и меняем статус на "Параметры изменены"
                    repo.SaveSale(FocusedSale, 17);
                    checkHistorySales_CheckedChanged(null, null);
                }
                else
                    repo.SaveSale(FocusedSale);
                MessageBox.Show("Параметры успешно сохранены", "Сохранение параметров",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnRefreshData_Click(object sender, EventArgs e)
        {
            checkHistorySales_CheckedChanged(null, null);
        }

        #endregion

        #region Events
        private void gvSKU_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            RefreshData();
        }


        // Валидационные методы
        private void teIntField_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TextEdit te = sender as TextEdit;
                string send = te.EditValue.ToString();
                if (send.isCelka())
                {
                    int value = FocusedSale.CommonGetInt(send);

                    bool check1 = false;
                    switch (te.Name)
                    {
                        case "tePeriodAnal":
                            check1 = value > FocusedSale.SaleDaysValue || value == 0;
                            break;
                        case "tePeriodAlertRTK":
                            check1 = value > FocusedSale.SaleDaysValue || value == 0;
                            break;
                        case "teTargetRemain":
                            check1 = value > FocusedSale.CurrentRestValue;
                            break;
                    }
                    bool check2 = value < 0;

                    te.Properties.Appearance.BorderColor = check1 || check2 ? Color.Red
                        : FocusedSale.isInit ? DXColor.FromArgb(64, 64, 64) : Color.Blue;
                }
                else
                    te.Properties.Appearance.BorderColor = Color.Red;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при валидации. " + ex.Message);
            }

        }
        private void teDoubleField_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TextEdit te = sender as TextEdit;
                string send = te.EditValue.ToString();
                if (send.isDouble())
                {
                    double value = FocusedSale.CommonGetDouble(send);
                    te.Properties.Appearance.BorderColor = value < 0 ? Color.Red
                        : FocusedSale.isInit ? DXColor.FromArgb(64, 64, 64) : Color.Blue;
                }
                else
                    te.Properties.Appearance.BorderColor = Color.Red;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ошибка при валидации. " + ex.Message);
            }
           

        }

        #endregion



        #region Logic Methods

        // Получает имя выбранного товара: Бренд + Артикул
        private string GetFocusedTovName()
        {
            DataRow focusrow = gvSKU.GetFocusedDataRow();
            if (focusrow == null)
                return "";
            string tovname = focusrow["Brand"].ToString() + " " + focusrow["Art"].ToString();
            return tovname;
        }


        // Распределение ролей по статусу товара
        //(отображение, включение компонентов в зависимости от статуса распродажи и роли пользователя)
        private void DistributeRoles(StatusSale status)
        {
            // Главное не запуптатся
            // На старт
            btnSaveData.Visible = true;
            btnSaveData.Enabled = false;

            btnApprove.Visible = true;
            btnApprove.Enabled = false;

            btnWithdraw.Enabled = false;
            btnWithdraw.Visible = false;

            labelCurPriceSale.Visible = false;
            teCurPriceSale.Visible = false;
            labelDateSale.Visible = false;
            teDate.Visible = false;

            LabelOptOne.Visible = false;
            // Внимание
            switch (status)
            {
                // Марш
                case StatusSale.SuggestToSale:
                    btnSaveData.Enabled = true;
                    if (User.InRole(User.Current.IdUser, "OptChiefBuyDepartment")
                        || User.InRole(User.Current.IdUser, "Developers"))
                        btnApprove.Enabled = true;
                    break;
                case StatusSale.InSales:
                    btnSaveData.Visible = false;
                    btnApprove.Visible = false;
                    labelCurPriceSale.Visible = true;
                    teCurPriceSale.Visible = true;
                    labelDateSale.Visible = true;
                    teDate.Visible = true;
                    if (User.InRole(User.Current.IdUser, "OptChiefBuyDepartment")
                        || User.InRole(User.Current.IdUser, "Developers"))
                    {
                        btnWithdraw.Enabled = true;
                        btnWithdraw.Visible = true;
                    }
                    break;
                case StatusSale.NeedChangeParams:
                    btnSaveData.Enabled = true;
                    labelCurPriceSale.Visible = true;
                    teCurPriceSale.Visible = true;
                    labelDateSale.Visible = true;
                    teDate.Visible = true;
                    break;
                case StatusSale.ParamsChanged:
                    btnSaveData.Enabled = true;
                    labelCurPriceSale.Visible = true;
                    teCurPriceSale.Visible = true;
                    labelDateSale.Visible = true;
                    teDate.Visible = true;
                    if (User.InRole(User.Current.IdUser, "OptChiefBuyDepartment")
                        || User.InRole(User.Current.IdUser, "Developers"))
                        btnApprove.Enabled = true;
                    break;
                case StatusSale.NeddChangeParamsOff:
                    btnSaveData.Enabled = true;
                    labelCurPriceSale.Visible = true;
                    teCurPriceSale.Visible = true;
                    labelDateSale.Visible = true;
                    teDate.Visible = true;
                    if (User.InRole(User.Current.IdUser, "OptChiefBuyDepartment")
                        || User.InRole(User.Current.IdUser, "Developers"))
                        btnApprove.Enabled = true;
                    break;
                case StatusSale.EndSale:
                    btnSaveData.Visible = false;
                    btnApprove.Visible = false;
                    labelCurPriceSale.Visible = true;
                    teCurPriceSale.Visible = true;
                    labelDateSale.Visible = true;
                    teDate.Visible = true;
                    break;
            }
        }


        // Финальная валидация полей перед тем, как утвердить или сохранить
        public string isFinalValidate(DataSale sale)
        {
            // Топорный метод
            string resValidate = "ok";
            if(!(sale.MCDiscount.isDouble() &&
                    sale.MCSales.isDouble() &&
                    sale.PeriodAlertRTK.isCelka() &&
                    sale.PeriodAnalize.isCelka() &&
                    sale.SaleDays.isCelka() && 
                    sale.TargetRestDays.isCelka()))
            {
                resValidate = "Поля заданы в неверном формате или пустые. Скорректируйте значение параметров";
                return resValidate;
            }
            if (sale.PeriodAlertRTKValue == 0)
            {
                resValidate = "Должен быть задан период оповещения РТК! Скорректируйте значение параметра";
                return resValidate;
            }

            if (sale.PeriodAlertRTKValue > sale.SaleDaysValue)
            {
                resValidate = "Период оповещения РТК должен быть меньше срока распродажи! Скорректируйте значение параметра";
                return resValidate;
            }


            if(sale.PeriodAnalizeValue == 0)
            {
                resValidate = "Должен быть задан период анализа! Скорректируйте значение параметра";
                return resValidate;
            }

            if (sale.PeriodAnalizeValue > sale.SaleDaysValue)
            {
                resValidate = "Период анализа должен быть меньше срока распродажи! Скорректируйте значение параметра";
                return resValidate;
            }
   

            if (sale.TargetRestDaysValue > sale.CurrentRestValue)
            {
                resValidate = "Целевой остаток должен быть меньше текущего остатка! Скорректируйте значение параметра";
                return resValidate;
            }


            if (sale.StepSaleValue < 0)
            {
                resValidate = "Шаг распродажи должен быть больше 0! Скорректируйте значение параметров";
                return resValidate;
            }

            // Откомментировать в Production
            //if (sale.TargetRateSalesValues <= 0)
            //{
            //    resValidate = "Требуемый темп распродажи должен быть больше 0! Скорректируйте значение параметров";
            //    return resValidate;
            //}

            if (sale.fA1 == 0 && sale.fAP == 0 && sale.fExist == 0 && sale.fIP == 0
                && sale.fOpt == 0)
                resValidate = "Необходимо указать каналы сбыта для распродажи";

            return resValidate;
        }


        #endregion






        #region Styles


        private void teProcentField_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            decimal val = 0;
            try
            {
                if (e.Value == null)
                    return;
                if (e.Value.ToString().Trim() == "")
                    return;
                if (decimal.TryParse(e.Value.ToString(), out val))
                {
                    val = val / 100;
                    e.DisplayText = string.Format("{0:P2}", val);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void teRubField_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            decimal val = 0;
            try
            {
                if (e.Value == null)
                    return;
                if (e.Value.ToString().Trim() == "")
                    return;
                if (decimal.TryParse(e.Value.ToString(), out val))
                {
                    string disp = string.Format("{0:C2}", val);
                    StringBuilder newDisp = new StringBuilder();
                    for (int i = 0; i < disp.Length; i++)
                    {
                        if (disp[i] == 'Ю')
                            newDisp.Append(".");
                        else
                            newDisp.Append(disp[i]);
                    }
                    e.DisplayText = newDisp.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }



        #endregion

        private void checkHistorySales_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHistorySales.Checked)
                gcSKU.DataSource = repo.GetTableTovsWithHistory(ListAccessTovGroup);
            else
                gcSKU.DataSource = repo.GetTableTovs(ListAccessTovGroup);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                int id_tov = FocusedSale.idtov;
                int curOst = FocusedSale.CurrentRestValue;
                int tarOst = FocusedSale.TargetRestDaysValue;
                string sql = $"exec up_ClearanceFullExit {id_tov}, {curOst}, {tarOst}, 1";
                DBExecute.ExecuteQuery(sql);

                checkHistorySales_CheckedChanged(null, null);
            }
            catch(Exception ex) {
                MessageBox.Show("Ошибка при выводе. " + ex.Message);
            }
        }

        private void gvSKU_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                DataRow row = gvSKU.GetDataRow(e.RowHandle);
                if (row == null)
                    return;
                int flagIsFinal = Convert.ToInt32(row["isFinal"]);
                if (flagIsFinal == 1)
                    e.Appearance.BackColor = DXColor.FromArgb(207, 174, 178);
                else
                    e.Appearance.BackColor = Color.Transparent;
            }
            catch(Exception ex)
            {
                MessageBox.Show("error. " + ex.Message);
            }
        }
    }
}
