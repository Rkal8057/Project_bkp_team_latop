using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SystemMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public SystemMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public SystemMasterResp GetSystemMaster(string searchKey = null)
        {

            List<SystemMaster> systemDetail;

            if (searchKey != null)
            {
                 systemDetail = DB.SystemMaster.ToList();
            }
            else
            {
                systemDetail = DB.SystemMaster.Where(e => e.company_status == 0).Take(20).ToList();
            }
            SystemMasterResp data = new SystemMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SystemMasterData = systemDetail
            };
            return data;
        }

        public SystemMasterResp GetSystemMasterById()
        {

            SystemMasterResp data = new SystemMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SystemMasterDataByID = DB.SystemMaster.
                Where(e => e.id == 3).FirstOrDefault()
            };
            return data;
        }

        public SystemMasterResp InsertSystemMaster(SystemMasterReq samp)
        {
            SystemMaster SampData = new SystemMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                company_name = samp.company_name,
                company_address = samp.company_address,
                company_pincode = samp.company_pincode,
                company_phoneNumber = samp.company_phoneNumber,
                company_img_url = samp.company_img_url,
                company_email = samp.company_email,
                company_linkedin_link = samp.company_linkedin_link,
                company_fb_link = samp.company_fb_link,
                company_intragram_link = samp.company_intragram_link,
                company_twitter_link = samp.company_twitter_link,
                company_about_detail = samp.company_about_detail,
                company_terms =  samp.company_terms,
                company_policy = samp.company_policy,
                company_return = samp.company_return,
                company_order_otp_active = samp.company_order_otp_active
            };

            DB.SystemMaster.Add(SampData);
            DB.SaveChanges();
            SystemMasterResp data = new SystemMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public SystemMasterResp UpdateSystemMaster(long companyId, SystemMasterReq samp)
        {
            var existingProduct = DB.SystemMaster
                .Where(e => e.id == companyId).FirstOrDefault();

            if (existingProduct == null)
            {

                SystemMasterResp data1 = new SystemMasterResp()
                {
                    status = false,
                    Message = "company not found"
                };

                return data1;
            }


            existingProduct.unique_trn_id = samp.unique_trn_id;
            existingProduct.client_purchaser_code = samp.client_purchaser_code;
            existingProduct.client_purchaser_name = samp.client_purchaser_name;
            existingProduct.agent_code = samp.agent_code;
            existingProduct.agent_name = samp.agent_name;
            existingProduct.vender_code = samp.vender_code;
            existingProduct.vender_name = samp.vender_name;
            existingProduct.company_name = samp.company_name;
            existingProduct.company_address = samp.company_address;
            existingProduct.company_pincode = samp.company_pincode;
            existingProduct.company_phoneNumber = samp.company_phoneNumber;
            existingProduct.company_img_url = samp.company_img_url;
            existingProduct.company_email = samp.company_email;
            existingProduct.company_linkedin_link = samp.company_linkedin_link;
            existingProduct.company_fb_link = samp.company_fb_link;
            existingProduct.company_intragram_link = samp.company_intragram_link;
            existingProduct.company_twitter_link = samp.company_twitter_link;
            existingProduct.company_about_detail = samp.company_about_detail;
            existingProduct.company_terms = samp.company_terms;
            existingProduct.company_policy = samp.company_policy;
            existingProduct.company_return = samp.company_return;
            existingProduct.company_order_otp_active = samp.company_order_otp_active;


            DB.SaveChanges();
            SystemMasterResp data = new SystemMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;
        }

        public SystemMasterResp DeleteSystemMaster(long companyId)
        {
            var del = DB.SystemMaster.Where(e => e.id == companyId).FirstOrDefault();

            if (del == null)
            {

                SystemMasterResp data1 = new SystemMasterResp()
                {
                    status = false,
                    Message = "Product not found"
                };

                return data1;
            }

            del.company_status = 1;

            DB.SaveChanges();
            SystemMasterResp data = new SystemMasterResp()
            {
                status = true,
                Message = "delete successfully"
            };
            return data;
        }

    }
}