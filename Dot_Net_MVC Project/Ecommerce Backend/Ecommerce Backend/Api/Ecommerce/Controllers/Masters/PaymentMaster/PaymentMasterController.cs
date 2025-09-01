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
using Microsoft.AspNetCore.WebUtilities;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public PaymentMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpGet("allpayment")]
        [Produces("application/json", Type = typeof(PaymentMasterResp))]
        public IActionResult GetPaymentMaster()
        {
            try
            {
                RTA.Masters.PaymentMasterBLL sample = new PaymentMasterBLL(DBConnStr);
                var Res = sample.GetPaymentMaster();
                objAction = CreatedAtAction("GetPaymentMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PaymentMasterResp data = new PaymentMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPaymentMaster", data);
                return objAction;
            }
        }


        [HttpGet("paymentDetailById")]
        [Produces("application/json", Type = typeof(PaymentMasterResp))]
        public IActionResult GetPaymentMasterById(long paymentId)
        {
            try
            {
                RTA.Masters.PaymentMasterBLL sample = new PaymentMasterBLL(DBConnStr);
                var Res = sample.GetPaymentMasterById(paymentId);
                objAction = CreatedAtAction("GetPaymentMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PaymentMasterResp data = new PaymentMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPaymentMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PaymentMasterResp))]
        public IActionResult AddPaymentMaster([FromBody] PaymentMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.PaymentMasterBLL sample = new PaymentMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertPaymentMaster(samp);
                    objAction = CreatedAtAction("AddPaymentMaster", Res);
                    return objAction;
                }

                PaymentMasterResp data = new PaymentMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddPaymentMaster", data);
                return objAction;

               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PaymentMasterResp data = new PaymentMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddPaymentMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(PaymentMasterResp))]
        public IActionResult UpdatePaymentMaster(long paymentId, [FromBody] PaymentMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.PaymentMasterBLL sample = new PaymentMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdatePaymentMaster(paymentId, samp);
                    objAction = CreatedAtAction("UpdatePaymentMaster", Res);
                    return objAction;
                }

                PaymentMasterResp data = new PaymentMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdatePaymentMaster", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PaymentMasterResp data = new PaymentMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdatePaymentMaster", data);
                return objAction;
            }
        }

    }
}
