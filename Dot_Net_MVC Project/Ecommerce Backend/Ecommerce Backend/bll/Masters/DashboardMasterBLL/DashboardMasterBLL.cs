using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class DashboardMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public DashboardMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public DashboardMasterResp GetDashboardMaster()
        {

            long? totalOrder = DB.OrderMaster.Count();
            long? totalUser = DB.User_Detail.Count();
            long? totalProduct =  DB.ProductMaster.Count();
            decimal? totalRevenue = DB.PaymentMaster.Select(o => o.amount).Sum();


            DashboardMasterResp data = new DashboardMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                tot_REVENUE = totalRevenue,
                tot_ORDER = totalOrder,
                tot_PRODUCT = totalProduct,
                tot_CUSTOMER = totalUser

            };
            return data;
        }



        public DashboardMasterResp GetDashboardMasterRevenue()
        {

            List<PaymentMaster> payment =  
                DB.PaymentMaster
                 .Where(e => e.created_date.Value.Year == 2024)
                .ToList();


            var paymentAmountByMonth = DB.PaymentMaster
            .Where(e => e.created_date.HasValue && e.created_date.Value.Year == 2024) 
            .GroupBy(e => e.created_date.Value.Month)
            .Select(g => new
            {
                Month = g.Key,
                TotalAmount = g.Sum(e => e.amount)??0
            })
            .ToList();

            List<PaymentByMonthResponse> paymentData = new List<PaymentByMonthResponse>();

            foreach (var row in paymentAmountByMonth)
            {
                var paymentByMonth = new PaymentByMonthResponse
                {
                    Month = row.Month,
                    TotalAmount = row.TotalAmount
                };
                paymentData.Add(paymentByMonth);
            }



            DashboardMasterResp data = new DashboardMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PaymentAmountByMonth = paymentData
            };
            return data;
        }
    }
}