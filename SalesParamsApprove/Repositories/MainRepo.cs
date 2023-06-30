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
       
        /// <summary>
        /// Получение списка SKU со статусами по роли пользователя
        /// </summary>
        /// <param name="ListAccessTovGroup"></param>
        /// <returns></returns>
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
                            spr_tov.idAdvancement as idStatus,
                            rClearanceValue.dateClearance as dateStart,
                            dateadd(day, rClearanceValue.daysClearance, rClearanceValue.dateClearance) as dateEnd,
                            rClearanceValue.isFinal,
                            rClearanceValue.idClearanceValue as idSale
                            from spr_tov (nolock)
                            inner join rClearanceValue (nolock) on rClearanceValue.idtov = spr_tov.id_tov
                            inner join spr_tm (nolock) on spr_tov.id_tm = spr_tm.tm_id
                            inner join sAdvancement (nolock) on spr_tov.idAdvancement = sAdvancement.idAdvancement
                            where sAdvancement.idAdvancement > 3 and (isFinal = 0 or sAdvancement.idAdvancement = 19)
                            order by sAdvancement.idAdvancement";
                }
                else
                {
                    // Запрос учитывает разрешенные ТГ для РТК
                    sql = $@"select  spr_tm.tm_name as Brand, 
                                spr_tov.id_tov as idSKU, 
                                spr_tov.id_tov_oem as Art, 
                                spr_tov.n_tov as Ntov, 
                                sAdvancement.nAdvancement as SaleStatus,
                                spr_tov.idAdvancement as idStatus,
                                rClearanceValue.dateClearance as dateStart,
                                dateadd(day, rClearanceValue.daysClearance, rClearanceValue.dateClearance) as dateEnd,
                                rClearanceValue.isFinal,
                                rClearanceValue.idClearanceValue as idSale
                                from spr_tov (nolock)
                                inner join rClearanceValue (nolock) on rClearanceValue.idtov = spr_tov.id_tov
                                inner join spr_tm (nolock) on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement (nolock) on spr_tov.idAdvancement = sAdvancement.idAdvancement
								inner join spr_tov_level4 stl4 (nolock) on stl4.tov_id = spr_tov.id_tov4
                                where sAdvancement.idAdvancement > 3 and (isFinal = 0 or sAdvancement.idAdvancement = 19)
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

        /// <summary>
        /// Получение списка SKU со статусами по роли пользователя
        /// </summary>
        /// <param name="ListAccessTovGroup"></param>
        /// <returns></returns>
        public DataTable GetTableTovsWithHistory(string ListAccessTovGroup = "")
        {
            try
            {
                string sql = null;
                if (User.InRole(User.Current.IdUser, "Developers") ||
                    User.InRole(User.Current.IdUser, "OptChiefBuyDepartment"))
                {
                    // Запрос не учитывает РТК , показывает все SKU по всем ТГ
                    sql = @"select  spr_tm.tm_name as Brand, 
                            spr_tov.id_tov as idSKU, 
                            spr_tov.id_tov_oem as Art, 
                            spr_tov.n_tov as Ntov, 
                            sAdvancement.nAdvancement as SaleStatus,
                            spr_tov.idAdvancement as idStatus,
                            rClearanceValue.dateClearance as dateStart,
                            dateadd(day, rClearanceValue.daysClearance, rClearanceValue.dateClearance) as dateEnd,
                            rClearanceValue.isFinal,
                            rClearanceValue.idClearanceValue as idSale
                            from spr_tov (nolock)
                            inner join rClearanceValue (nolock) on rClearanceValue.idtov = spr_tov.id_tov
                            inner join spr_tm (nolock) on spr_tov.id_tm = spr_tm.tm_id
                            inner join sAdvancement (nolock) on spr_tov.idAdvancement = sAdvancement.idAdvancement
                            --where sAdvancement.idAdvancement > 3
                            order by isFinal, 6";
                }
                else
                {
                    // Запрос учитывает разрешенные ТГ для РТК
                    sql = $@"select  spr_tm.tm_name as Brand, 
                                spr_tov.id_tov as idSKU, 
                                spr_tov.id_tov_oem as Art, 
                                spr_tov.n_tov as Ntov, 
                                sAdvancement.nAdvancement as SaleStatus,
                                spr_tov.idAdvancement as idStatus,
                                rClearanceValue.dateClearance as dateStart,
                                dateadd(day, rClearanceValue.daysClearance - 1, rClearanceValue.dateClearance) as dateEnd,
                                rClearanceValue.isFinal,
                                rClearanceValue.idClearanceValue as idSale
                                from spr_tov (nolock)
                                inner join rClearanceValue (nolock) on rClearanceValue.idtov = spr_tov.id_tov
                                inner join spr_tm (nolock) on spr_tov.id_tm = spr_tm.tm_id
                                inner join sAdvancement (nolock) on spr_tov.idAdvancement = sAdvancement.idAdvancement
								inner join spr_tov_level4 stl4 (nolock) on stl4.tov_id = spr_tov.id_tov4
                                where stl4.tov_id_top_level IN ({ListAccessTovGroup})
                                order by isFinal, 6";
                }

                return sql == null ? null : DBExecute.SelectTable(sql);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Утверждение распродажи
        /// </summary>
        /// <param name="sale"></param>
        public void ApproveSale(DataSale sale)
        {
            UpdateDataSale(sale, true);

            // В случае статусов "Предложено к распродаже" и "Параметры изменены" считаем стартовую цену распродажи
            // Обновляем ее , ставим новый статус и устанавливаем новые цены в указанных каналах сбыта
            if (sale.Status == StatusSale.SuggestToSale 
                || sale.Status == StatusSale.ParamsChanged || sale.Status == StatusSale.NeddChangeParamsOff)
            {
                double StartPriceClearance = sale.MCMarketValue - (sale.MCMarketValue * (sale.MCDiscountValue / 100));
                string sql = $@"Update rClearanceValue set 
                            PriceClearance = {StartPriceClearance}
                            WHERE idtov = {sale.idtov}";
                DBExecute.ExecuteQuery(sql);

                // Установка статуса "В распродаже из АМ"

                UpdateStatus(sale.idtov, 20);

                // Установка цен в spr price
                sql = $"exec up_CalcPriceClearance {sale.idtov}";
                DBExecute.ExecuteQuery(sql);
            }
        }

        public void SaveSale(DataSale sale, int idNewStatus = -1)
        {
            UpdateDataSale(sale, false, idNewStatus);
        }


        /// <summary>
        /// Обновление данных в таблице связей распродажи с товаром
        /// </summary>
        /// <param name="sale"></param>
        /// <param name="idNewStatus"></param>
        public void UpdateDataSale(DataSale sale, bool isApprove, int idNewStatus = -1)
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
                            fAP = {sale.fAP},
                            fIP = {sale.fIP},
                            fOpt = {sale.fOpt},
                            fA1 = {sale.fA1}, 
                            fExist = {sale.fExist},
                            isFinal = 0
                            WHERE idtov = {sale.idtov}";
            DBExecute.ExecuteQuery(sql);

            if (isApprove)
            {
                sql = $@"Update rClearanceValue set 
                         dateClearance = @date,
                         idUser = {User.CurrentUserId},
                         nUser = '{User.GetUserDomainName()}'
                         WHERE idtov = {sale.idtov}";
                DBExecute.ExecuteQuery(sql, p_date);
            }

            // Если нужно кроме обновления параметров еще присвоить новый статус
            if(idNewStatus != -1)
            {
                UpdateStatus(sale.idtov, idNewStatus);
            }

        }

        /// <summary>
        /// Обновление статуса распродажи у товара
        /// </summary>
        /// <param name="idtov"></param>
        /// <param name="idNewStatus"></param>
        public void UpdateStatus(int idtov, int idNewStatus)
        {
            string sql = $"UPDATE spr_tov SET idAdvancement = {idNewStatus} WHERE id_tov = {idtov}";
            DBExecute.ExecuteQuery(sql);
        }

        /// <summary>
        /// Получение нередактируемых параметров распродажи
        /// </summary>
        /// <param name="idtov"></param>
        /// <returns></returns>
        public DataSale GetConstFields(int idtov)
        {
            using (IDbConnection db = new SqlConnection(Connection.ConnectionString))
            {
                // ЗДЕСЬ может использоваться СКЛАД
                var temp = db.Query<DataSale>
                    ($@"select      rest as CurrentRest, 
                                    cast(round(restDays,2) as numeric(18,2)) as CurrentRestDays,
                                    DaysTurnoverNorm as NO,
                                    cast(round(rateSales,2) as numeric(18,2)) as CurrentRateSales,
                                    cast(priceMarket as numeric(18,2)) as MCMarket,
                                    cast(sebest as numeric(18,2)) as Sebest
                            from [dbo].[uf_getValuesForClearance] ({idtov}, 19)")
                    .FirstOrDefault();
                return temp;
            }
        }

        /// <summary>
        /// Получение редактируемых настроек распродажи
        /// </summary>
        /// <param name="idtov"></param>
        /// <returns></returns>
        public DataSale GetEditableFields(int idtov)
        {
            using (IDbConnection db = new SqlConnection(Connection.ConnectionString))
            {
                var temp = db.Query<DataSale>
                        ($@"select restTarget as TargetRestDays,
                                    cast(round(rateSalesTarget,2) as numeric(18,2)) as TargetRateSales,
                                    daysClearance as SaleDays,
                                    cast(round(minPriceClearance,2)*100 as numeric(18,2)) as MCSales,
                                    cast(round(priceMarketDiscount,2)*100 as numeric(18,2)) as MCDiscount,
                                    cast(round(stepClearance, 2) as numeric(18,2)) as StepSale,
                                    periodAnalize as PeriodAnalize,
                                    periodAlertRTK as PeriodAlertRTK,
                                    fAP, fIP, fOpt, fA1, fExist,
                                    PriceClearance as PriceSale,
                                    dateClearance as DateSale
                            from rClearanceValue (nolock) WHERE idtov = {idtov}")
                        .FirstOrDefault();
                return temp;
            }
        }

        /// <summary>
        /// Получает текущий объём продаж отсчитываемого от начала срока распродажи
        /// </summary>
        /// <param name="idtov"></param>
        /// <returns></returns>
        public decimal GetCurrentRateSales(int idtov)
        {
            string sql = $@"select cast(round(isnull(sum(v_sales.kol_tov) / datediff(day, cley.dateClearance, getdate()),0),2) as numeric(18,2)) as curTempoSales 
							from rClearanceValue cley (nolock)
							LEFT JOIN v_sales (nolock) ON v_sales.id_tov = cley.idtov and v_sales.date_doc >= cley.dateClearance and v_sales.kol_tov > 0
							WHERE cley.idtov = {idtov} and datediff(day,cley.dateClearance, getdate()) >= 1
							GROUP BY cley.dateClearance";
            object obj = DBExecute.SelectScalar(sql);

            return obj == null ? 0 : Convert.ToDecimal(obj);
        }

    }
}
