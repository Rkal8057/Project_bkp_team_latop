using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB.Login;
using DB.Login.Tables;
using RTA.Masters;
using RTAAPI;
using RTA.Masters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RTA.Common.Models;
using MailKit.Search;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public OrderMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }

        [HttpGet("allorder")]
        [Produces("application/json", Type = typeof(OrderMasterResp))]
        public IActionResult GetOrderMaster()
        {
            try
            {
                RTA.Masters.OrderMasterBLL sample = new OrderMasterBLL(DBConnStr);
                var Res = sample.GetOrderMaster();
                objAction = CreatedAtAction("GetOrderMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetOrderMaster", data);
                return objAction;
            }
        }


        [HttpGet("orderDetailByUserId")]
        [Produces("application/json", Type = typeof(OrderMasterResp))]
        public IActionResult GetOrderMasterByUserId(long userId)
        {
            try
            {
                RTA.Masters.OrderMasterBLL sample = new OrderMasterBLL(DBConnStr);
                var Res = sample.GetOrderMasterByUserId(userId);
                objAction = CreatedAtAction("GetOrderMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetOrderMaster", data);
                return objAction;
            }
        }

        
        [HttpGet("orderDetailByOrderId")]
        [Produces("application/json", Type = typeof(OrderMasterResp))]
        public IActionResult GetOrderMasterByOrderId(long orderId)
        {
            try
            {
                RTA.Masters.OrderMasterBLL sample = new OrderMasterBLL(DBConnStr);
                var Res = sample.GetOrderMasterByOrderId(orderId);
                objAction = CreatedAtAction("GetOrderMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetOrderMaster", data);
                return objAction;
            }
        }




        [HttpPut("updateOrderStatus")]
        [Produces("application/json", Type = typeof(OrderMasterResp))]
        public IActionResult UpdateOrderTrackingStatus(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long orderId, [FromBody] OrderMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.OrderMasterBLL sample = new OrderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateOrderTrackingStatus(orderId, samp);
                    objAction = CreatedAtAction("UpdateOrderTrackingStatus", Res);
                    return objAction;
                }

                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateOrderTrackingStatus", data);
                return objAction;


               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateOrderTrackingStatus", data);
                return objAction;
            }
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(OrderMasterResp))]
        public IActionResult AddOrderMaster([FromBody] OrderMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.OrderMasterBLL sample = new OrderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertOrderMaster(samp);
                    objAction = CreatedAtAction("AddOrderMaster", Res);
                    return objAction;
                }

                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddOrderMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                OrderMasterResp data = new OrderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddOrderMaster", data);
                return objAction;
            }
        }

    }
}
