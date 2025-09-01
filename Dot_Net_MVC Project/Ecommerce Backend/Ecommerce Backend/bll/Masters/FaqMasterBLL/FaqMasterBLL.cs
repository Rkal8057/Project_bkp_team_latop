using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class FaqMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public FaqMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public FaqMasterResp GetFaqMaster()
        {

            
            FaqMasterResp data = new FaqMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                FaqMasterData = DB.FaqMaster.Where(e => e.faq_status == 0)
                .ToList()
            };
            return data;
        }

        public FaqMasterResp GetFaqMasterById(long faqId)
        {

            FaqMasterResp data = new FaqMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                FaqMasterDataByID = DB.FaqMaster.
                Where(e => e.id == faqId && e.faq_status == 0).FirstOrDefault()
            };
            return data;
        }

        public FaqMasterResp InsertFaqMaster(FaqMasterReq samp)
        {
            FaqMaster SampData = new FaqMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                vender_name = samp.vender_name,
                vender_code = samp.vender_code,
                agent_name = samp.agent_name,
                agent_code = samp.agent_code,
                question = samp.question, 
                answer = samp.answer, 
                username = samp.username,
                created_on = DateTime.Now,
                updated_on = DateTime.Now
            };

            DB.FaqMaster.Add(SampData);
            DB.SaveChanges();

            FaqMasterResp data = new FaqMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public FaqMasterResp UpdateFaqMaster(long faqId, FaqMasterReq samp)
        {

            var existingProduct = DB.FaqMaster
                .Where(e => e.id == faqId && e.faq_status == 0).FirstOrDefault();

            if (existingProduct == null)
            {

                FaqMasterResp data1 = new FaqMasterResp()
                {
                    status = false,
                    Message = "Faq not found"
                };

                return data1;
            }

            existingProduct.client_purchaser_code = samp.client_purchaser_code;
            existingProduct.client_purchaser_name = samp.client_purchaser_name;
            existingProduct.vender_name = samp.vender_name;
            existingProduct.vender_code = samp.vender_code;
            existingProduct.agent_name = samp.agent_name;
            existingProduct.agent_code = samp.agent_code;
            existingProduct.question = samp.question;
            existingProduct.answer = samp.answer;
            existingProduct.username = samp.username;
            existingProduct.updated_on = DateTime.Now;


            DB.SaveChanges();

            FaqMasterResp data = new FaqMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;
        }

        public FaqMasterResp DeleteFaqMaster(long faqId)
        {
            var del = DB.FaqMaster.Where(e => e.id == faqId).FirstOrDefault();

            if (del == null)
            {

                FaqMasterResp data1 = new FaqMasterResp()
                {
                    status = false,
                    Message = "Product not found"
                };

                return data1;
            }

            del.faq_status = 1;

            DB.SaveChanges();
            FaqMasterResp data = new FaqMasterResp()
            {
                status = true,
                Message = "delete successfully"
            };
            return data;
        }


    }
}