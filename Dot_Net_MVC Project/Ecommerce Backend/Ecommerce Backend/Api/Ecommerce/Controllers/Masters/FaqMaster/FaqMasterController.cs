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
    public class FaqMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public FaqMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpGet("allfaq")]
        [Produces("application/json", Type = typeof(FaqMasterResp))]
        public IActionResult GetFaqMaster()
        {
            try
            {
                RTA.Masters.FaqMasterBLL sample = new FaqMasterBLL(DBConnStr);
                var Res = sample.GetFaqMaster();
                objAction = CreatedAtAction("GetFaqMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetFaqMaster", data);
                return objAction;
            }
        }


        [HttpGet("faqDetail")]
        [Produces("application/json", Type = typeof(FaqMasterResp))]
        public IActionResult GetFaqMasterById(long faqId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.FaqMasterBLL sample = new FaqMasterBLL(DBConnStr);
                var Res = sample.GetFaqMasterById(faqId);
                objAction = CreatedAtAction("GetFaqMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetFaqMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(FaqMasterResp))]
        public IActionResult AddFaqMaster([FromBody] FaqMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.FaqMasterBLL sample = new FaqMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertFaqMaster(samp);
                    objAction = CreatedAtAction("AddFaqMaster", Res);
                    return objAction;
                }

                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddFaqMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddFaqMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(FaqMasterResp))]
        public IActionResult UpdateFaqMaster(long faqId, [FromBody] FaqMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
            
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.FaqMasterBLL sample = new FaqMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.UpdateFaqMaster(faqId, samp);
                    objAction = CreatedAtAction("UpdateFaqMaster", Res);
                    return objAction;
                }

                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateFaqMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateFaqMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(FaqMasterResp))]
        public IActionResult DeleteFaqMaster(long faqId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {


                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.FaqMasterBLL sample = new FaqMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteFaqMaster(faqId);
                    objAction = CreatedAtAction("DeleteFaqMaster", Res);
                    return objAction;
                }
                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteFaqMaster", data);
                return objAction;
               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FaqMasterResp data = new FaqMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteFaqMaster", data);
                return objAction;
            }
        }

    }
}
