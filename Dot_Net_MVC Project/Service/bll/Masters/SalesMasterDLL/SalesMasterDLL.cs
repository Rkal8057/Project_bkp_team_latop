using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SalesMasterDLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public SalesMasterDLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public SalesMasterResp GetSalesMaster()
        {
            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SalesMasterDetailData = DB.SalesMaster
                .Include(e => e.SalesTrxMaster).ToList()
            };
            return data;
        }

        public SalesMasterResp GetSalesMasterByID(int id)
        {

            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SalesMasterDetailByID = DB.SalesMaster
                .Include(e => e.SalesTrxMaster) // Include the SalesTrxMaster navigation property
                .SingleOrDefault(e => e.id == id) // Filter by the specified ID
            };

            return data;
        }

        public SalesMasterResp InsertSalesMaster(SalesMasterReq samp)
        {
            SalesMaster SampData = new SalesMaster()
            {
                sales_date = samp.sales_date,
                party_id = samp.party_id,
                completion_flag = samp.completion_flag,
                grand_total = samp.grand_total,
            };

            DB.SalesMaster.Add(SampData);
            DB.SaveChanges();


           /* List<SalesTrxMaster> sampData1 = samp.SalesTrxMaster.Select(item => new SalesTrxMaster
            {
                item_name = item.item_name,
                item_qty = item.item_qty,
                item_rate = item.item_rate,
                item_type = item.item_type,
                amount = item.amount,
                sales_master_id = SampData.id

            }).ToList();

            DB.SalesTrxMaster.AddRange(sampData1);
            DB.SaveChanges();
*/
            /*
            SalesTrxMaster SampData1 = new SalesTrxMaster()
            {

                item_name = samp.item_name,
                item_qty = samp.item_qty,
                item_rate = samp.item_rate,
                item_type = samp.item_type,
                amount = samp.amount,
                sales_master_id = SampData.id
            };
            DB.SalesTrxMaster.Add(SampData1);
            DB.SaveChanges();*/

            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        public SalesMasterResp UpdateSalesMaster(int ID, SalesMasterReq samp)
        {

            SalesMaster SampData = new SalesMaster()
            {
                id = ID,
                sales_date = samp.sales_date,
                party_id = samp.party_id,
                completion_flag = samp.completion_flag,
                grand_total = samp.grand_total,
            };

            DB.SalesMaster.Update(SampData);
            DB.SaveChanges();
            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public SalesMasterResp DeleteSalesMaster(int ID)
        {
            SalesMaster del = DB.SalesMaster.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.SalesMaster.Remove(del);
            DB.SaveChanges();
            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

    }
}