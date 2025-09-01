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
using MimeKit;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mini_Slider_MasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public Mini_Slider_MasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }

        [HttpGet("allminiSlider")]
        [Produces("application/json", Type = typeof(Mini_Slider_MasterResp))]
        public IActionResult GetSliderMaster()
        {
            try
            {
                RTA.Masters.Mini_Slider_MasterBLL sample = new Mini_Slider_MasterBLL(DBConnStr);
                var Res = sample.GetMini_Slider_Master();
                objAction = CreatedAtAction("GetSliderMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSliderMaster", data);
                return objAction;
            }
        }


        [HttpGet("miniSliderDetail")]
        [Produces("application/json", Type = typeof(Mini_Slider_MasterResp))]
        public IActionResult GetSliderMasterById(long mini_sliderId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.Mini_Slider_MasterBLL sample = new Mini_Slider_MasterBLL(DBConnStr);
                var Res = sample.GetMini_Slider_MasterById(mini_sliderId);
                objAction = CreatedAtAction("GetSliderMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSliderMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(Mini_Slider_MasterResp))]
        public IActionResult AddSliderMaster([FromBody] Mini_Slider_MasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {


                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.Mini_Slider_MasterBLL sample = new Mini_Slider_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertMini_Slider_Master(samp);
                    objAction = CreatedAtAction("AddSliderMaster", Res);
                    return objAction;

                }

                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSliderMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSliderMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(Mini_Slider_MasterResp))]
        public IActionResult UpdateSliderMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long mini_sliderId, [FromBody] Mini_Slider_MasterReq samp)
        {
            try
            {
               


                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.Mini_Slider_MasterBLL sample = new Mini_Slider_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.UpdateMini_Slider_Master(mini_sliderId, samp);
                    objAction = CreatedAtAction("UpdateSliderMaster", Res);
                    return objAction;

                }

                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateSliderMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSliderMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(Mini_Slider_MasterResp))]
        public IActionResult DeleteSliderMaster(long mini_sliderId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
   
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.Mini_Slider_MasterBLL sample = new Mini_Slider_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.DeleteMini_Slider_Master(mini_sliderId);
                    objAction = CreatedAtAction("DeleteSliderMaster", Res);
                    return objAction;

                }

                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteSliderMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Mini_Slider_MasterResp data = new Mini_Slider_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSliderMaster", data);
                return objAction;
            }
        }
    }
}
