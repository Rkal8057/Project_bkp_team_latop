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

        public SalesTrxMasterResp InsertSalesTrxMaster(List<SalesTrxMasterReq> Data, 
            long grand_total, long sale_master_id, decimal discount_percentage,
            decimal discount_amount,
            decimal grand_total_after_discount)
        {

            foreach (var item in Data)
            {
                SalesTrxMaster sampData = new SalesTrxMaster()
                {
                    sales_master_id = item.sales_master_id,
                    item_name = item.item_name,
                    item_qty = item.item_qty,
                    item_rate = item.item_rate,
                    item_type = item.item_type,
                    item_amount = item.item_amount,
                };
                DB.SalesTrxMaster.Add(sampData);
            }
            DB.SaveChanges();


            SalesMaster Samp =  DB.SalesMaster.FirstOrDefault(e=>e.id == sale_master_id);
            Samp.grand_total = grand_total;
            Samp.completion_flag = "Closed";
            Samp.discount_percentage = discount_percentage;
            Samp.discount_amount = discount_amount;
            Samp.grand_total_after_discount = grand_total_after_discount;
            DB.SaveChanges();


            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public SalesTrxMasterResp UpdateSalesTrxMaster(long sale_master_id, List<SalesTrxMasterReq> samp,
         long grand_total, decimal discount_percentage, decimal discount_amount,
         decimal grand_total_after_discount)
        {

            foreach (var updatedSaleTrxMaster in samp)
            {
                // Retrieve the entity from the database
                SalesTrxMaster existingSaleTrxMaster = DB.SalesTrxMaster.FirstOrDefault(e => 
                e.item_name == updatedSaleTrxMaster.item_name &&
                e.sales_master_id == updatedSaleTrxMaster.sales_master_id
                );

                if (existingSaleTrxMaster != null)
                {
                    // Update existing entity
                    existingSaleTrxMaster.item_qty = updatedSaleTrxMaster.item_qty;
                    existingSaleTrxMaster.item_amount = updatedSaleTrxMaster.item_amount;
                }
                else
                {
                    // Create a new entry in the database
                    var newSaleTrxMaster = new SalesTrxMaster
                    {
                        sales_master_id = updatedSaleTrxMaster.sales_master_id,
                        item_name = updatedSaleTrxMaster.item_name,
                        item_qty = updatedSaleTrxMaster.item_qty,
                        item_rate = updatedSaleTrxMaster.item_rate,
                        item_type = updatedSaleTrxMaster.item_type,
                        item_amount = updatedSaleTrxMaster.item_amount
                    };

                    DB.SalesTrxMaster.Add(newSaleTrxMaster);
                }
            }
            if (sale_master_id != null)
            {
                SalesMaster Samp = DB.SalesMaster.FirstOrDefault(e => e.id == sale_master_id);
                Samp.grand_total = grand_total;
                Samp.discount_percentage = discount_percentage;
                Samp.discount_amount = discount_amount;
                Samp.grand_total_after_discount = grand_total_after_discount;
                DB.SaveChanges();

            }

            DB.SaveChanges();
            SalesTrxMasterResp data = new SalesTrxMasterResp()
            {
                status = true,
                Message = "Updated successfully"
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