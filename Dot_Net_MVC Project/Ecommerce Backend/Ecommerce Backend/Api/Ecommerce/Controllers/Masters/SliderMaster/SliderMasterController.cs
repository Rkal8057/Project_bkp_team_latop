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

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public SliderMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }

        [HttpGet("allslider")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult GetSliderMaster()
        {
            try
            {
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                var Res = sample.GetSliderMaster();
                objAction = CreatedAtAction("GetSliderMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSliderMaster", data);
                return objAction;
            }
        }


        [HttpGet("sliderDetail")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult GetSliderMasterById(long sliderId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                var Res = sample.GetSliderMasterById(sliderId);
                objAction = CreatedAtAction("GetSliderMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSliderMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult AddSliderMaster([FromBody] SliderMasterReq samp
             , [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertSliderMaster(samp);
                    objAction = CreatedAtAction("AddSliderMaster", Res);
                    return objAction;

                }

                SliderMasterResp data = new SliderMasterResp()
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
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSliderMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult UpdateSliderMaster(long sliderId, [FromBody] SliderMasterReq samp
             , [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateSliderMaster(sliderId, samp);
                    objAction = CreatedAtAction("UpdateSliderMaster", Res);
                    return objAction;
                }

                SliderMasterResp data = new SliderMasterResp()
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
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSliderMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult DeleteSliderMaster(long sliderId,  [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                




                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteSliderMaster(sliderId);
                    objAction = CreatedAtAction("DeleteSliderMaster", Res);
                    return objAction;
                }

                SliderMasterResp data = new SliderMasterResp()
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
                SliderMasterResp data = new SliderMasterResp()
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
