using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTA.Masters
{
    public class OrderMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public OrderMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public OrderMasterResp GetOrderMaster()
        {

            //List<OrderMaster> orderDetail;

            //if (searchKey != null)
            //{
            //    orderDetail = DB.OrderMaster.Where(e => e.order_status == 0 && EF.Functions.Like(e., "%" + searchKey + "%")).ToList();
            //}
            //else
            //{
            //    orderDetail = DB.CategoryMaster.Where(e => e.category_status == 0).Take(20).ToList();
            //}

            OrderMasterResp data = new OrderMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                OrderMasterData = DB.OrderMaster
                    .Include(order => order.OrderItemMasters)
                        .ThenInclude(orderItem => orderItem.ReturnMaster)
                    .Where(order => order.deleted == 0)
                    .OrderByDescending(e => e.id)
                    .ToList()
        };
            return data;
        }


        public OrderMasterResp GetOrderMasterByUserId(long userId)
        {
            OrderMasterResp data = new OrderMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                OrderMasterData = DB.OrderMaster
                .Include(e => e.OrderItemMasters )
                 .ThenInclude(orderItem => orderItem.ReturnMaster)
                .Where(e => e.customer_id == userId)
                .OrderByDescending(e => e.id)
                .ToList(),
                OrderMasterPendingData = DB.OrderMaster
                .Include(e => e.OrderItemMasters)
                .Where(e => e.customer_id == userId && e.order_status != OrderStatus.Delivered)
                .ToList(),

            };
            return data;
        }

        public OrderMasterResp GetOrderMasterByOrderId(long orderId)
        {
            OrderMasterResp data = new OrderMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                OrderMasterDataByID = DB.OrderMaster
                .Include(e => e.OrderItemMasters)
                .ThenInclude(orderItem => orderItem.ReturnMaster)
                .Where(e => e.id == orderId).FirstOrDefault() 
        };
            return data;
        }

        public OrderMasterResp InsertOrderMaster(OrderMasterReq samp)
        {
            string orderNumber = GenerateOrderNumber();

            OrderMaster SampData = new OrderMaster()
            {
                order_number = orderNumber,
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                customer_id = samp.customer_id,
                grand_total = samp.grand_total,
                order_status = samp.order_status,
                img_url = samp.img_url,
                username = samp.username,
                created_on = DateTime.Now,
                updated_on =  DateTime.Now,
                order_user_name = samp.order_user_name,
                order_user_address = samp.order_user_address,
                order_user_pincode = samp.order_user_pincode,
                order_user_address_type = samp.order_user_address_type,
                order_user_city = samp.order_user_city,
                order_user_country = samp.order_user_country,
            };

            DB.OrderMaster.Add(SampData);
            DB.SaveChanges();

            if(samp.OrderItemMasterKey != null)
            {
                foreach ( var orderItemDetail in samp.OrderItemMasterKey ) 
                {
                    OrderItemMaster orderItem = new OrderItemMaster()
                    {
                        unique_trn_id = orderItemDetail.unique_trn_id,
                        client_purchaser_code = orderItemDetail.client_purchaser_code,
                        client_purchaser_name = orderItemDetail.client_purchaser_name,
                        agent_code = orderItemDetail.agent_code,
                        agent_name = orderItemDetail.agent_name,
                        vender_code = orderItemDetail.vender_code,
                        vender_name = orderItemDetail.vender_name,
                        order_id = SampData.id,
                        product_id = orderItemDetail.id,
                        quantity = orderItemDetail.quantity,
                        sub_total = orderItemDetail.sub_total,
                        status = orderItemDetail.status,
                        deleted = orderItemDetail.deleted,
                        img_url = orderItemDetail.img_url,
                        username = orderItemDetail.username,
                        product_title = orderItemDetail.product_title,
                        product_price = orderItemDetail.product_price,
                        product_returnable = orderItemDetail.product_returnable,
                        product_to_be_returned_by = orderItemDetail.product_to_be_returned_by
                    };


                    DB.OrderItemMaster.Add(orderItem);
                }
                DB.SaveChanges();

            }

            OrderMasterResp data = new OrderMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        public OrderMasterResp UpdateOrderTrackingStatus(long orderId , OrderMasterReq samp )
        {

            if (!Enum.IsDefined(typeof(OrderStatus), samp.order_status))
            {
                OrderMasterResp data1 = new OrderMasterResp()
                {
                    status = false,
                    Message = "Invalid order status. Please provide a valid order status value.",
                };
                return data1;
            }

            OrderMaster checkexisting =  DB.OrderMaster.Find(orderId);
            if (checkexisting != null)
            {

                if (samp.order_status == OrderStatus.Processing) // Assuming Pending is an enum value
                {
                    checkexisting.order_status = OrderStatus.Processing;
                    checkexisting.order_processing_done = "Done";
                    checkexisting.order_processing_time = DateTime.Now;
                }
                else if(samp.order_status == OrderStatus.Shipping)
                {
                    checkexisting.order_status = OrderStatus.Shipping;
                    checkexisting.order_shipping_done = "Done";
                    checkexisting.order_shipping_time = DateTime.Now;
                }
                else if (samp.order_status == OrderStatus.Delivered)
                {
                    checkexisting.order_status = OrderStatus.Delivered;
                    checkexisting.order_delivery_done = "Done";
                    checkexisting.order_delivery_time = DateTime.Now;
                }
                else if (samp.order_status == OrderStatus.Cancelled)
                {
                    checkexisting.order_status = OrderStatus.Cancelled;
                    checkexisting.order_cancel_done = "Done";
                    checkexisting.order_cancel_time = DateTime.Now;
                    checkexisting.order_cancel_reason = samp.order_cancel_reason;
                    checkexisting.order_cancel_option = samp.order_cancel_option;
                    checkexisting.order_cancel_by = samp.order_cancel_by;
                }
            }
            DB.SaveChanges();
            
            OrderMasterResp data = new OrderMasterResp()
            {
                status = true,
                Message = "updated successfully",
            };
            return data;
        }



       /* public OrderMasterResp UpdateOrderTrackingStatus(long orderId, long status)
        {

            OrderMaster checkexisting = DB.OrderMaster.Find(orderId);
            if (checkexisting != null)
            {
                checkexisting.order_processing_time = DateTime.Now;
                checkexisting.order_shipping_time = DateTime.Now;
                checkexisting.order_delivery_time = DateTime.Now;
            }
            DB.SaveChanges();

            OrderMasterResp data = new OrderMasterResp()
            {
                status = true,
                Message = "updated successfully",
            };
            return data;
        }*/

        public static string GenerateOrderNumber()
        {
            // Get current year and month
            string year = DateTime.Now.Year.ToString();
            string month = DateTime.Now.Month.ToString("00"); // Ensure month is always two digits

            // Generate a random 4-digit number
            Random rnd = new Random();
            int randomNumber = rnd.Next(1000, 9999);

            // Concatenate year, month, and random number to create order number
            string orderNumber = year + month + randomNumber.ToString();

            return orderNumber;
        }

    }
}