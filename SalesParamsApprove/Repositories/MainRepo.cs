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

        public StringBuilder GetListAccessTovGroup(int idkontr)
        {
            string sql = $"SELECT idtovgr FROM rLinkRTKTovGroup rtk (nolock) where idkontr = {User.CurrentUserId}";
            DataTable tempDt = DBExecute.SelectTable(sql);
            if (tempDt == null || tempDt.Rows.Count == 0) return new StringBuilder("");
            List<int> tgList = tempDt.AsEnumerable()
                .Select(x => Convert.ToInt32(x[0])).ToList();

            StringBuilder sbTgList = new StringBuilder();
            for (int i = 0; i < tgList.Count; i++)
            {
                sbTgList.Append(i == tgList.Count - 1 ? tgList[i].ToString() : tgList[i] + ",");
            }
            return sbTgList;
        }
       
        public DataTable GetTableTovs(string ListAccessTovGroup = "")
        {
            try
            {
                string sql = null;
                if(User.InRole(User.Current.IdUser, "Developers") || 
                    User.InRole(User.Current.IdUser, "OptChiefBuyDepartment"))
                {
                    // Запрос не учитывает РТК , показывает все SKU по всем ТГ
                    sql = @"select  spr_tm.tm_name as Brand, 
                                    spr_tov.id_tov as idSKU, 
                                    spr_tov.id_tov_oem as Art, 
                                    spr_tov.n_tov as Ntov, 
                                    sAdvancement.nAdvancement as SaleStatus,
                                    spr_tov.idAdvancement as idStatus
                                    from spr_tov (nolock)
                                    inner join spr_tm (nolock) on spr_tov.id_tm = spr_tm.tm_id
                                    inner join sAdvancement (nolock) on spr_tov.idAdvancement = sAdvancement.idAdvancement
                                    where sAdvancement.idAdvancement > 3
                                    order by sAdvancement.idAdvancement";
                }
                else
                {
                    sql = $@"select  spr_tm.tm_name as Brand, 
                                spr_tov.id_tov as idSKU, 
                                spr_tov.id_tov_oem as Art, 
                                spr_tov.n_tov as Ntov, 
                                sAdvancement.nAdvancement as SaleStatus,
                                spr_tov.idAdvancement as idStatus
                                from spr_tov (nolock)
                                inner join spr_tm (nolock) on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement (nolock) on spr_tov.idAdvancement = sAdvancement.idAdvancement
								inner join spr_tov_level4 stl4 (nolock) on stl4.tov_id = spr_tov.id_tov4
                                where sAdvancement.idAdvancement > 3 
                                and stl4.tov_id_top_level IN ({ListAccessTovGroup})
                                order by sAdvancement.idAdvancement";
                }

                return sql == null ? null : DBExecute.SelectTable(sql);
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
                            minPriceClearance = {sale.MCSalesValue / 100},
                            priceMarketDiscount = {sale.MCDiscountValue / 100},
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

            if (sale.Status == StatusSale.SuggestToSale)
            {
                double StartPriceClearance = sale.MCMarketValue - (sale.MCMarketValue * (sale.MCDiscountValue / 100));
                sql = $@"Update rClearanceValue set 
                            PriceClearance = {StartPriceClearance}
                            WHERE idtov = {sale.idtov}";
                DBExecute.ExecuteQuery(sql);

                // Установка статуса "В распродаже из АМ"

                sql = $"UPDATE spr_tov SET idAdvancement = 20 WHERE id_tov = {sale.idtov}";
                DBExecute.ExecuteQuery(sql);

                sql = $"exec up_CalcPriceClearance {sale.idtov}";
                DBExecute.ExecuteQuery(sql);
            }
            if(sale.Status == StatusSale.ParamsChanged)
            {
                // TODO: Запускается процедура автоматич.изменения цен
            }



        }

        public void SaveSale(DataSale sale)
        {
            SqlParameter p_date = new SqlParameter("date", DateTime.Now);
            string sql = $@"Update rClearanceValue set 
                            restTarget = {sale.TargetRestDaysValue},
                            rateSalesTarget  = {sale.TargetRateSalesValues},
                            minPriceClearance = {sale.MCSalesValue / 100},
                            priceMarketDiscount = {sale.MCDiscountValue / 100},
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
                                    cast(minPriceClearance as numeric(18,2))*100 as MCSales,
                                    cast(priceMarketDiscount as numeric(18,2))*100 as MCDiscount,
                                    cast(stepClearance as numeric(18,2)) as StepSale,
                                    periodAnalize as PeriodAnalize,
                                    periodAlertRTK as PeriodAlertRTK,
                                    fAP, fIP, fOpt, fA1, fExist, fKP
                            from rClearanceValue (nolock) WHERE idtov = {idtov}")
                        .FirstOrDefault();
                return temp;
            }
        }

    }
}
