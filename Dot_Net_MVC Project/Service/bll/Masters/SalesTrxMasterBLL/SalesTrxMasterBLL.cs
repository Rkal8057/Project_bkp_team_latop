using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SalesTrxMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public SalesTrxMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public SalesTrxMasterResp GetSalesTrxMaster()
        {
            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SalesTrxMasterDetailData = DB.SalesTrxMaster.ToList()
            };
            return data;
        }

        public SalesTrxMasterResp GetSalesTrxMasterByID(int id)
        {

            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SalesTrxMasterDetailByID = DB.SalesTrxMaster.Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public SalesTrxMasterResp InsertSalesTrxMaster(List<SalesTrxMasterReq> Data)
        {
            foreach (var item in Data)
            {
                SalesTrxMaster sampData = new SalesTrxMaster()
                {
                    item_name = item.item_name,
                    item_qty = item.item_qty,
                    item_rate = item.item_rate,
                    item_type = item.item_type,
                    amount = item.amount,
                };
                DB.SalesTrxMaster.Add(sampData);
            }

            DB.SaveChanges();
            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public SalesTrxMasterResp UpdateSalesTrxMaster(int ID, SalesTrxMasterReq samp)
        {

            SalesTrxMaster SampData = new SalesTrxMaster()
            {
                id = ID,
                item_name = samp.item_name,
                item_qty = samp.item_qty,
                item_rate = samp.item_rate,
                item_type = samp.item_type,
                amount = samp.amount,
            };

            DB.SalesTrxMaster.Update(SampData);
            DB.SaveChanges();
            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public SalesTrxMasterResp DeleteSalesTrxMaster(int ID)
        {
            SalesTrxMaster del = DB.SalesTrxMaster.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.SalesTrxMaster.Remove(del);
            DB.SaveChanges();
            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    }
}