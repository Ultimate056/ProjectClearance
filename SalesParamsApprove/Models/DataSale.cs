using SalesParamsApprove.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SalesParamsApprove.Models
{
    public class DataSale : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DataSale()
        {

        }
        public DataSale(int idtov)
        {
            this.idtov = idtov;
        }

        public DataSale(bool _isInit)
        {
            this.isInit = _isInit;
        }

        public bool isInit = true;

        private double CommonGetDouble(string val)
        {
            return val.isDouble() ? double.Parse(val) : 0;
        }
        private int CommonGetInt(string val)
        {
            return val.isCelka() ? int.Parse(val) : 0;
        }


        #region ФИКС поля
        public int idtov { get; set; } = 0;


        // МЦ рынка, руб
        private string _MCMarket = "";

        public double MCMarketValue { get { return CommonGetDouble(_MCMarket); } }
        public string MCMarket
        {
            get { return _MCMarket; }
            set {
                _MCMarket = value;
                OnPropertyChanged();
            }
        }

        // УЦ 41 , руб
        private string _Sebest = "";
        public double SebestValue { get { return CommonGetDouble(_Sebest); } }
        public string Sebest
        {
            get { return _Sebest; }
            set
            {
                _Sebest = value;
                OnPropertyChanged();
            }
        }



        // Текущий остаток, count
        private string _CurrentRest = "";
        public int CurrentRestValue { get { return CommonGetInt(_CurrentRest); } }
        public string CurrentRest
        {
            get { return _CurrentRest; }
            set
            {
                _CurrentRest = value;
                OnPropertyChanged();
            }
        }

        // Текущий остаток, дней

        private string _CurrentRestDays = "";
        public int CurrentRestDaysValue { get { return CommonGetInt(_CurrentRestDays); } }
        public string CurrentRestDays
        {
            get { return _CurrentRestDays; }
            set
            {
                _CurrentRestDays = value;
                OnPropertyChanged();
            }
        }


        // Текущий объём продаж
        private string _CurrentRateSales = "";
        public double CurrentRateSalesValue { get { return CommonGetDouble(_CurrentRateSales); } }
        public string CurrentRateSales
        {
            get { return _CurrentRateSales; }
            set
            {
                _CurrentRateSales = value;
                OnPropertyChanged();
            }
        }


        // Нормативная оборачиваемость
        private string _NO = "";
        public int NOValue { get { return CommonGetInt(_NO); } }
        public string NO
        {
            get { return _NO; }
            set
            {
                _NO = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Редактируемые поля


        // Целевой остаток, шт
        private string _TargetRestDays = "";
        public int TargetRestDaysValue { get { return CommonGetInt(_TargetRestDays); } }
        public string TargetRestDays
        {
            get { return _TargetRestDays; }
            set
            {
                _TargetRestDays = value;
                if(!isInit) CalcRequireTempSale();
                OnPropertyChanged();
            }
        }

        // Срок распродажи, дн
        private string _SaleDays = "";
        public int SaleDaysValue { get { return CommonGetInt(_SaleDays); } }
        public string SaleDays
        {
            get { return _SaleDays; }
            set
            {
                _SaleDays = value;
                if (!isInit)
                {
                    CalcRequireTempSale();
                    CalcStepSale();
                }
                OnPropertyChanged();
            }
        }


        // МЦ распродажи, %
        private string _MCSales = "";
        public double MCSalesValue { get { return CommonGetDouble(_MCSales); } }
        public string MCSales
        {
            get { return _MCSales; }
            set
            {
                _MCSales = value;
                if (!isInit) CalcStepSale();
                OnPropertyChanged();
            }
        }


        // скидка от МЦ, %
        private string _MCDiscount = "";
        public double MCDiscountValue { get { return CommonGetDouble(_MCDiscount); } }
        public string MCDiscount
        {
            get { return _MCDiscount; }
            set
            {
                _MCDiscount = value;
                if (!isInit) CalcStepSale();
                OnPropertyChanged();
            }
        }


        // Период оповещения РТК, дн
        private string _PeriodAlertRTK = "";
        public int PeriodAlertRTKValue { get { return CommonGetInt(_PeriodAlertRTK); } }
        public string PeriodAlertRTK
        {
            get { return _PeriodAlertRTK; }
            set
            {
                _PeriodAlertRTK = value;
                OnPropertyChanged();
            }
        }


        // Период анализа
        private string _PeriodAnalize = "";
        public int PeriodAnalizeValue { get { return CommonGetInt(_PeriodAnalize); } }
        public string PeriodAnalize
        {
            get { return _PeriodAnalize; }
            set
            {
                _PeriodAnalize = value;
                if (!isInit) CalcStepSale();
                OnPropertyChanged();
            }
        }


        #region Зависимые поля от расчётных (нередактируемые)

        // Шаг распродажи
        private string _StepSale = "";
        public double StepSaleValue { get { return CommonGetDouble(_StepSale); } }
        public string StepSale
        {
            get { return _StepSale; }
            set
            {
                _StepSale = value;
                OnPropertyChanged();
            }
        }

        // Требуемый объём продаж
        private string _TargetRateSales = "";
        public double TargetRateSalesValues { get { return CommonGetDouble(_TargetRateSales); } }
        public string TargetRateSales
        {
            get { return _TargetRateSales; }
            set
            {
                _TargetRateSales = value;
                OnPropertyChanged();
            }
        }

        // Каналы сбыта


        private byte _fAP = 0;

        public byte fAP
        {
            get { return _fAP; }
            set { _fAP = value;  OnPropertyChanged(); }
        }

        private byte _fIP = 0;
        public byte fIP
        {
            get { return _fIP; }
            set { _fIP = value; OnPropertyChanged(); }
        }

        private byte _fOpt = 0;
        public byte fOpt
        {
            get { return _fOpt; }
            set { _fOpt = value; OnPropertyChanged(); }
        }

        private byte _fExist = 0;
        public byte fExist
        {
            get { return _fExist; }
            set { _fExist = value; OnPropertyChanged(); }
        }

        private byte _fA1 = 0;
        public byte fA1
        {
            get { return _fA1; }
            set { _fA1 = value; OnPropertyChanged(); }
        }

        private byte _fKP = 0;
        public byte fKP
        {
            get { return _fKP; }
            set { _fKP = value; OnPropertyChanged(); }
        }


        #endregion

        #endregion

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public void Clear()
        {
            fAP = 0;
            fIP = 0;
            fOpt = 0;
            fExist = 0;
            fA1 = 0;
            fKP = 0;
            TargetRateSales = "";
            StepSale = "";
            PeriodAnalize = "";
            PeriodAlertRTK = "";
            MCDiscount = "";
            MCSales = "";
            TargetRestDays = "";
            SaleDays = "";
        }

        public void CalcRequireTempSale()
        {
            if (SaleDaysValue > 1)
            {
                int raznost = Math.Abs(CurrentRestValue - TargetRestDaysValue);
                //int raznost = TargetRestDaysValue > CurrentRestValue ? 0 : CurrentRestValue - TargetRestDaysValue;
                TargetRateSales = Math.Round((raznost / (SaleDaysValue*1.0)), 2).ToString();
            }
            else
                TargetRateSales = "0";
        }

        public void CalcStepSale() //Расчет Шага распродажи
        {
            double MCMarket = MCMarketValue; // руб
            double sebest = SebestValue; // УЦ41
            double DiscountMC = MCDiscountValue; // %
            double MCSales = MCSalesValue; // %
            double SaleDays = SaleDaysValue; // дн (срок распродажи)
            int PeriodA = PeriodAnalizeValue; // дн

            if ((PeriodA > 0) && (SaleDays > 0) && (SaleDays / PeriodA) > 0)
            {
                StepSale = Convert.ToString(Math.Round(
                    ((MCMarket - MCMarket * (DiscountMC / 100)) - sebest * (MCSales / 100)) / (SaleDays / PeriodA)
                ,2));
            }
            else
                StepSale = "0";

        }

    }
}
