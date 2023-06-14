using Dapper;
using SalesParamsApprove.Database;
using SalesParamsApprove.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesParamsApprove.Repositories
{
    public class MainRepo
    {
        
       
        public DataTable GetTableTovs()
        {
            try
            {
                string sql = @"select  spr_tm.tm_name as Brand, 
                                spr_tov.id_tov as idSKU, 
                                spr_tov.id_tov_oem as Art, 
                                spr_tov.n_tov as Ntov, 
                                sAdvancement.nAdvancement as SaleStatus,
                                spr_tov.idAdvancement as idStatus
                                from spr_tov 
                                inner join spr_tm on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement on spr_tov.idAdvancement = sAdvancement.idAdvancement
                                where sAdvancement.idAdvancement > 3
                                order by sAdvancement.idAdvancement";

                return DBExecute.SelectTable(sql);
            }
            catch (Exception ex)
            {
                return null;
            }
        } 

        public void ApproveSale(DataSale sale)
        {
            SqlParameter p_date = new SqlParameter("date", DateTime.Now);
            string sql = $@"Update rClearanceValue set 
                            restTarget = {sale.TargetRestDaysValue},
                            rateSalesTarget  = {sale.TargetRateSalesValues},
                            minPriceClearance = {sale.MCSalesValue},
                            priceMarketDiscount = {sale.MCDiscountValue},
                            periodAnalize = {sale.PeriodAnalizeValue},
                            periodAlertRTK = {sale.PeriodAlertRTKValue},
                            daysClearance = {sale.SaleDaysValue},
                            stepClearance = {sale.StepSaleValue},
                            fKP = {sale.fKP},
                            fAP = {sale.fAP},
                            fIP = {sale.fIP},
                            fOpt = {sale.fOpt},
                            fA1 = {sale.fA1}, 
                            fExist = {sale.fExist},
                            dateClearance = @date,
                            idUser = {User.CurrentUserId},
                            nUser = '{User.GetUserDomainName()}'
                            WHERE idtov = {sale.idtov}";
            DBExecute.ExecuteQuery(sql, p_date);

            // Установка статуса "В распродаже из АМ"

            sql = $"UPDATE spr_tov SET idAdvancement = 20 WHERE id_tov = {sale.idtov}";
            DBExecute.ExecuteQuery(sql);

        }

        public void SaveSale(DataSale sale)
        {
            SqlParameter p_date = new SqlParameter("date", DateTime.Now);
            string sql = $@"Update rClearanceValue set 
                            restTarget = {sale.TargetRestDaysValue},
                            rateSalesTarget  = {sale.TargetRateSalesValues},
                            minPriceClearance = {sale.MCSalesValue},
                            priceMarketDiscount = {sale.MCDiscountValue},
                            periodAnalize = {sale.PeriodAnalizeValue},
                            periodAlertRTK = {sale.PeriodAlertRTKValue},
                            daysClearance = {sale.SaleDaysValue},
                            stepClearance = {sale.StepSaleValue},
                            fKP = {sale.fKP},
                            fAP = {sale.fAP},
                            fIP = {sale.fIP},
                            fOpt = {sale.fOpt},
                            fA1 = {sale.fA1}, 
                            fExist = {sale.fExist}
                            WHERE idtov = {sale.idtov}";
            DBExecute.ExecuteQuery(sql, p_date);
        }

        public DataSale GetConstFields(int idtov)
        {
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
                return temp;
            }
        }

        public DataSale GetEditableFields(int idtov)
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
                            from rClearanceValue WHERE idtov = {idtov}")
                        .FirstOrDefault();
                return temp;
            }
        }

    }
}
