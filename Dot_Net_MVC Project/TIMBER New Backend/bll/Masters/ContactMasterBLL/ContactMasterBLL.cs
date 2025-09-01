using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class ContactMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ContactMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;

            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public ContactMasterResp GetContactMaster()
        {
            ContactMasterResp data = new ContactMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ContactMasterData = DB.ContactMaster.ToList()
            };
            return data;
        }


        public ContactMasterResp GetContactMasterById(long contactId)
        {
            ContactMasterResp data = new ContactMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ContactMasterDataByID = DB.ContactMaster.Where(e =>e.id == contactId).FirstOrDefault()
            };
            return data;
        }

        public ContactMasterResp InsertContactMaster(ContactMasterReq samp)
        {
            ContactMaster SampData = new ContactMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                firstname = samp.firstname,
                lastname = samp.lastname,
                email = samp.email,
                phn_no = samp.phn_no,
                subject = samp.subject,
                message = samp.message,
                seen_status = "0",
                sent_on = DateTime.Now
            };


            DB.ContactMaster.Add(SampData);
            DB.SaveChanges();
            ContactMasterResp data = new ContactMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ContactMasterResp UpdateContactMaster(long contactId, ContactMasterReq samp, User_Detail user_detail)
        {
            var existingClient = DB.ContactMaster.Find(contactId);

            if (existingClient == null)
            {
                ContactMasterResp data1 = new ContactMasterResp()
                {
                    status = false,
                    Message = "contact not found"
                };

                return data1;
            }

            existingClient.seen_by = user_detail.user_name;
            existingClient.seen_by_id = user_detail.id;
            existingClient.remark = samp.remark;
            existingClient.seen_status = samp.seen_status;
            existingClient.sent_on = DateTime.Now;
            DB.SaveChanges();

            ContactMasterResp data = new ContactMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public ContactMasterResp DeleteContactMaster(long contactId)
        {

            ContactMaster del = DB.ContactMaster.SingleOrDefault(parent => parent.id == contactId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.Remove(del);
            DB.SaveChanges();

            ContactMasterResp data = new ContactMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }
    }
}