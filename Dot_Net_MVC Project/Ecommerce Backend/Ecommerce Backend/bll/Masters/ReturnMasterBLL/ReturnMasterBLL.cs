using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class ReturnMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public ReturnMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public ReturnMasterResp GetReturnMaster()
        {
            ReturnMasterResp data = new ReturnMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ReturnMasterData = DB.ReturnMaster.ToList()
            };
            return data;
        }


        public ReturnMasterResp GetReturnMasterByOrderItemId(long orderItemId)
        {
            ReturnMasterResp data = new ReturnMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ReturnMasterByID = DB.ReturnMaster.Where(e=> e.order_item_id == orderItemId).FirstOrDefault()
            };
            return data;
        }

        public ReturnMasterResp InsertReturnMaster(ReturnMasterReq samp)
        {

            ReturnMaster SampData = new ReturnMaster()
            {
                order_item_id = samp.order_item_id,
                order_returnable = "Done",
                order_returnable_time = DateTime.Now,                
                created_on = DateTime.Now,
                updated_on = DateTime.Now,
                order_courier_name = samp.order_courier_name,
                order_courier_pod_no= samp.order_courier_pod_no,
                product_to_be_returned_by= samp.product_to_be_returned_by,
                order_courier_receipt_image= samp.order_courier_receipt_image,
                order_cancel_reason= samp.order_cancel_reason,
                order_cancel_option= samp.order_cancel_option
            };

            DB.ReturnMaster.Add(SampData);
            DB.SaveChanges();

            ReturnMasterResp data = new ReturnMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        public ReturnMasterResp UpdateOrderReturnTrackingStatus(long orderItemId, ReturnMasterReq samp)
        {

            ReturnMaster checkexisting = DB.ReturnMaster.Where(e => e.order_item_id == orderItemId).FirstOrDefault();
            if (checkexisting != null)
            {

                //if (samp.order_return_status == OrderReturnStatus.OrderReturnable) 
                //{
                //    checkexisting.order_return_status = OrderReturnStatus.OrderReturnable;
                //    checkexisting.order_returnable = "Done";
                //    checkexisting.order_returnable_time = DateTime.Now;
                //}
                //else
                if (samp.order_return_status == OrderReturnStatus.OrderReturnableReceived)
                {
                    checkexisting.order_return_status = OrderReturnStatus.OrderReturnableReceived;
                    checkexisting.order_returnable_received = "Done";
                    checkexisting.order_returnable_received_time = DateTime.Now;
                    checkexisting.updated_on = DateTime.Now;

                }
                else if (samp.order_return_status == OrderReturnStatus.OrderRefundable)
                {
                    checkexisting.order_return_status = OrderReturnStatus.OrderReturnable;
                    checkexisting.order_refund = "Done";
                    checkexisting.order_refund_time = DateTime.Now;
                    checkexisting.updated_on = DateTime.Now;

                }

            }
            DB.SaveChanges();

            ReturnMasterResp data = new ReturnMasterResp()
            {
                status = true,
                Message = "updated successfully",
            };
            return data;
        }

    }
}