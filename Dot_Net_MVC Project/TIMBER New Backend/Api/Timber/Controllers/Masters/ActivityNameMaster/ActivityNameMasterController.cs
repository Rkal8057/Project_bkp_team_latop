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


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityNameMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ActivityNameMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ActivityNameMasterResp))]
        public IActionResult CreateActivityNameMaster([FromBody] ActivityNameMasterReq samp,
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityNameMasterBLL sample = new ActivityNameMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var isCheckActivityName = sample.ActivityNameExistsInDatabase(samp);
                    if (isCheckActivityName.ActivityNameMasterByID != null)
                    {
                        return CreatedAtAction("CreateActivityNameMaster", isCheckActivityName);
                    }

                    var Res = sample.InsertActivityNameMaster(samp);
                    objAction = CreatedAtAction("CreateActivityNameMaster", Res);
                    return objAction;
                }

                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateActivityNameMaster", data);
                return objAction;
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateActivityNameMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ActivityNameMasterResp))]
        public IActionResult UpdateActivityNameMaster(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data ,
            [FromBody] ActivityNameMasterReq samp, [FromQuery] long activityId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityNameMasterBLL sample = new ActivityNameMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateActivityNameMaster(activityId, samp);
                    objAction = CreatedAtAction("UpdateActivityNameMaster", Res);
                    return objAction;
                }

                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateActivityNameMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateActivityNameMaster", data);
                return objAction;
            }
        }


        [HttpGet("allActivityName")]
        [Produces("application/json", Type = typeof(ActivityNameMasterResp))]
        public IActionResult GetAllActivityNameMaster(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int pageNo = 1, int limit = 10, string? searchKey = null,
            string active_flag = null
        ){
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityNameMasterBLL sample = new ActivityNameMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.GetAllActivityNameMaster(pageNo, limit, searchKey, active_flag);
                    objAction = CreatedAtAction("GetAllActivityNameMaster", Res);
                    return objAction;
                }

                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllActivityNameMaster", data);
                return objAction;


              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllActivityNameMaster", data);
                return objAction;
            }
        }



        [HttpGet("activityNameById")]
        [Produces("application/json", Type = typeof(ActivityNameMasterResp))]
        public IActionResult GetActivityNameMasterById(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data ,[FromQuery] long activityId)
        {
            try
            {
                if (activityId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "ActivityId is required", Data = false });
                }


                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityNameMasterBLL sample = new ActivityNameMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {

                    var Res = sample.GetActivityNameMasterById(activityId);
                    objAction = CreatedAtAction("GetActivityNameMasterById", Res);
                    return objAction;
                }

                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetActivityNameMasterById", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetActivityNameMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ActivityNameMasterResp))]
        public IActionResult DeleteActivityNameMaster(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, 
            [FromQuery] long activityId)
        {
            try
            {
              


                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityNameMasterBLL sample = new ActivityNameMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteActivityNameMaster(activityId);
                    objAction = CreatedAtAction("DeleteActivityNameMaster", Res);
                    return objAction;
                }

                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteActivityNameMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityNameMasterResp data = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteActivityNameMaster", data);
                return objAction;
            }
        }
    }
}
