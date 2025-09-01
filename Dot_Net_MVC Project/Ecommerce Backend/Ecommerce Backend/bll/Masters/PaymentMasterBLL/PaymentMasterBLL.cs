using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Net;
using System.Xml.Linq;

namespace RTA.Masters
{
    public class PaymentMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public PaymentMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public PaymentMasterResp GetPaymentMaster()
        {
            PaymentMasterResp data = new PaymentMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PaymentMasterData = DB.PaymentMaster.ToList()
            };
            return data;
        }


        public PaymentMasterResp GetPaymentMasterById(long paymentId)
        {
            PaymentMasterResp data = new PaymentMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PaymentMasterDataByID = DB.PaymentMaster.Where(e=> e.id == paymentId).FirstOrDefault()
            };
            return data;
        }

        public PaymentMasterResp InsertPaymentMaster(PaymentMasterReq samp)
        {
            PaymentMaster SampData = new PaymentMaster()
            {
                name = samp.name,
                mobile_no = samp.mobile_no,
                address = samp.address,
                email = samp.email,
                amount = samp.amount,
                payment_status = samp.payment_status,
                transaction_id = samp.transaction_id,
                unique_ref_no = samp.unique_ref_no,
                response_url   = samp.response_url,
                push_url = samp.push_url,   
                created_by = samp.created_by,
                modify_by = samp.modify_by,
                modified_date = DateTime.Now, 
                created_date = DateTime.Now ,
                payment_mode= samp.payment_mode,
                user_id = samp.user_id,
                order_id = samp.order_id,
            };

            DB.PaymentMaster.Add(SampData);
            DB.SaveChanges();
            PaymentMasterResp data = new PaymentMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public PaymentMasterResp UpdatePaymentMaster(long blogId, PaymentMasterReq samp)
        {
            var existingPayment = DB.PaymentMaster.Find(blogId);

            if (existingPayment == null)
            {
                PaymentMasterResp data1 = new PaymentMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            existingPayment.name = samp.name;
            existingPayment.mobile_no = samp.mobile_no;
            existingPayment.address = samp.address;
            existingPayment.email = samp.email;
            existingPayment.amount = samp.amount;
            existingPayment.payment_status = samp.payment_status;
            existingPayment.transaction_id = samp.transaction_id;
            existingPayment.unique_ref_no = samp.unique_ref_no;
            existingPayment.response_url = samp.response_url; 
            existingPayment.push_url = samp.push_url;
            existingPayment.created_by = samp.created_by;
            existingPayment.modify_by = samp.modify_by;
            existingPayment.modified_date = DateTime.Now;
            existingPayment.created_date = DateTime.Now;
            existingPayment.payment_mode = samp.payment_mode;
            existingPayment.user_id = samp.user_id;
            existingPayment.order_id = samp.order_id;

            DB.SaveChanges();

            PaymentMasterResp data = new PaymentMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



      

    }
}