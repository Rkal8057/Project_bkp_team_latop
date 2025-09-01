using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class Mini_Slider_MasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public Mini_Slider_MasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public Mini_Slider_MasterResp GetMini_Slider_Master()
        {
            Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Mini_Slider_MasterData = DB.Mini_Slider_Master.Where(e => e.slider_status == 0).ToList()
            };
            return data;
        }


        public Mini_Slider_MasterResp GetMini_Slider_MasterById(long mini_sliderId)
        {
            Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Mini_Slider_MasterDataByID = DB.Mini_Slider_Master.Where(e => e.slider_status == 0 && e.id == mini_sliderId).FirstOrDefault()
            };
            return data;
        }

        public Mini_Slider_MasterResp InsertMini_Slider_Master(Mini_Slider_MasterReq samp)
        {
            Mini_Slider_Master SampData = new Mini_Slider_Master()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                slider_title = samp.slider_title,
                slider_description = samp.slider_description,
                discount_percentage = samp.discount_percentage,
                slider_category = samp.slider_category,
                slider_category_id = samp.slider_category_id,
                img_url = samp.img_url,
                username = samp.username,
                created_on = DateTime.Now,
                updated_on = DateTime.Now
            };

            DB.Mini_Slider_Master.Add(SampData);
            DB.SaveChanges();
            Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public Mini_Slider_MasterResp UpdateMini_Slider_Master(long mini_sliderId, Mini_Slider_MasterReq samp)
        {
            var existingCategory = DB.Mini_Slider_Master.Find(mini_sliderId);

            if (existingCategory == null)
            {
                Mini_Slider_MasterResp data1 = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = "mini_sliderId not found"
                };

                return data1;
            }

            existingCategory.client_purchaser_code = samp.client_purchaser_code;
            existingCategory.client_purchaser_name = samp.client_purchaser_name;
            existingCategory.agent_code = samp.agent_code;
            existingCategory.agent_name = samp.agent_name;
            existingCategory.vender_code = samp.vender_code;
            existingCategory.vender_name = samp.vender_name;
            existingCategory.slider_title = samp.slider_title;
            existingCategory.slider_description = samp.slider_description;


            existingCategory.discount_percentage = samp.discount_percentage;
            existingCategory.slider_category = samp.slider_category;
            existingCategory.slider_category_id = samp.slider_category_id;
            existingCategory.img_url = samp.img_url;
            existingCategory.username = samp.username;
            existingCategory.updated_on = DateTime.Now;

            DB.SaveChanges();

            Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public Mini_Slider_MasterResp DeleteMini_Slider_Master(long mini_sliderId)
        {

            Mini_Slider_Master del = DB.Mini_Slider_Master.SingleOrDefault(parent => parent.id == mini_sliderId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.slider_status = 1;
            DB.SaveChanges();

            Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}