using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class AddToCartMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public AddToCartMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public AddToCartMasterResp GetAddToCartMasterById(long? userId)
        {
            AddToCartMasterResp data = new AddToCartMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                AddToCartMasterData = DB.AddToCartMaster.Where( e => e.user_id == userId).ToList(),
            };
            return data;
        }

        public AddToCartMasterResp InsertAddToCartMaster( List<AddToCartMasterReq> samp, long userId)
        {

            foreach (var item in samp)
            {
                var existingData = DB.AddToCartMaster.FirstOrDefault(x => x.id == item.id && x.user_id == userId);

                if (existingData == null)
                {
                    AddToCartMaster SampData = new AddToCartMaster()
                    {
                        id = item.id,
                        comp_id = item.comp_id,
                        comp_name = item.comp_name,
                        product_category_id = item.product_category_id,
                        product_category = item.product_category,
                        product_sub_category_id = item.product_sub_category_id,
                        product_sub_category = item.product_sub_category,
                        product_title = item.product_title,
                        product_description = item.product_description,
                        product_price = item.product_price,
                        product_del_price = item.product_del_price,
                        product_status = item.product_status,
                        product_store_qty = item.product_store_qty,
                        quantity = item.quantity,
                        deleted = item.deleted,
                        user_id = userId,
                        unique_trn_id = item.unique_trn_id,
                        img_url = item.img_url,
                        username = item.username,
                        created_on = DateTime.Now,
                        updated_on = DateTime.Now,                        
                        product_to_be_returned_by = item.product_to_be_returned_by,
                        product_returnable = item.product_returnable,
                        product_purchasing_price = item.product_purchasing_price,
                        product_commission_received_in = item.product_commission_received_in,
                        product_commission_percentage = item.product_commission_percentage,
                        product_commission_amt = item.product_commission_amt,
                        product_points_earned = item.product_points_earned
                    };

                    DB.AddToCartMaster.Add(SampData);
                }
            }
                DB.SaveChanges();

            AddToCartMasterResp data = new AddToCartMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }
        public AddToCartMasterResp DeleteAddToCartMaster(List<AddToCartMasterReq> samp, long userId)
        {
            foreach (var item in samp)
            {
                var existingData = DB.AddToCartMaster.FirstOrDefault(x => x.id == item.id && x.user_id == userId);
                if (existingData != null)
                {
                    DB.Remove(existingData);
                }
            }

            DB.SaveChanges();

            AddToCartMasterResp data = new AddToCartMasterResp()
            {
                status = true,
                Message = "Deleted successfully"
            };
            return data;
        }


    }
}