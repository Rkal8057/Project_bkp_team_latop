using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SliderMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public SliderMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public SliderMasterResp GetSliderMaster()
        {
            SliderMasterResp data = new SliderMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Slider_MasterData = DB.Slider_Master.Where(e => e.slider_status == 0).ToList()
            };
            return data;
        }


        public SliderMasterResp GetSliderMasterById(long sliderId)
        {
            SliderMasterResp data = new SliderMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Slider_MasterDataByID = DB.Slider_Master.Where(e => e.slider_status == 0 && e.id == sliderId).FirstOrDefault()
            };
            return data;
        }

        public SliderMasterResp InsertSliderMaster(SliderMasterReq samp)
        {
            Slider_Master SampData = new Slider_Master()
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
                deleted = samp.deleted,
                img_url = samp.img_url,
                username = samp.username,
                created_on = DateTime.Now,
                updated_on = DateTime.Now
            };

            DB.Slider_Master.Add(SampData);
            DB.SaveChanges();
            SliderMasterResp data = new SliderMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public SliderMasterResp UpdateSliderMaster(long sliderId, SliderMasterReq samp)
        {
            var existingCategory = DB.Slider_Master.Find(sliderId);

            if (existingCategory == null)
            {
                SliderMasterResp data1 = new SliderMasterResp()
                {
                    status = false,
                    Message = "Slider not found"
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
            existingCategory.deleted = samp.deleted;
            existingCategory.img_url = samp.img_url;
            existingCategory.username = samp.username;
            existingCategory.updated_on = DateTime.Now;

            DB.SaveChanges();

            SliderMasterResp data = new SliderMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }

        public SliderMasterResp DeleteSliderMaster(long sliderId)
        {

            Slider_Master del = DB.Slider_Master.SingleOrDefault(parent => parent.id == sliderId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.slider_status = 1;
            DB.SaveChanges();

            SliderMasterResp data = new SliderMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }


    }
}