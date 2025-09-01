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
    public class ActivityMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ActivityMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }



        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ActivityMasterResp))]
        public IActionResult CreateActivityMaster([FromBody] ActivityMasterReq samp ,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data 
        ){
            try
            {
             
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityMasterBLL sample = new ActivityMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Category name doesn't exist, proceed with insertion
                    var Res = sample.InsertActivityMaster(samp);
                    objAction = CreatedAtAction("CreateActivityMaster", Res);
                    return objAction;
                }

                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateActivityMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateActivityMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ActivityMasterResp))]
        public IActionResult UpdateActivityMaster([FromBody] ActivityMasterReq samp, 
            [FromQuery] long activityId ,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
            )
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityMasterBLL sample = new ActivityMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Category name doesn't exist, proceed with insertion
                    var Res = sample.UpdateActivityMaster(activityId, samp);
                    objAction = CreatedAtAction("UpdateActivityMaster", Res);
                    return objAction;
                }

                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateActivityMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateActivityMaster", data);
                return objAction;
            }
        }


        [HttpGet("allActivity")]
        [Produces("application/json", Type = typeof(ActivityMasterResp))]
        public IActionResult GetAllActivityMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data ,
            int pageNo = 1, int limit = 10, string? searchKey = null
            )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityMasterBLL sample = new ActivityMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Category name doesn't exist, proceed with insertion
                    var Res = sample.GetAllActivityMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetAllActivityMaster", Res);
                    return objAction;
                }

                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllActivityMaster", data);
                return objAction;

              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllActivityMaster", data);
                return objAction;
            }
        }



        [HttpGet("activitybyid")]
        [Produces("application/json", Type = typeof(ActivityMasterResp))]
        public IActionResult GetActivityMasterById(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data ,
            [FromQuery] long activityId)
        {
            try
            {
                if (activityId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "ActivityId is required", Data = false });
                }

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityMasterBLL sample = new ActivityMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Category name doesn't exist, proceed with insertion
                    var Res = sample.GetActivityMasterById(activityId);
                    objAction = CreatedAtAction("GetActivityMasterById", Res);
                    return objAction;
                }

                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetActivityMasterById", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetActivityMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ActivityMasterResp))]
        public IActionResult DeleteActivityMaster([FromQuery] long activityId ,
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ActivityMasterBLL sample = new ActivityMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Category name doesn't exist, proceed with insertion
                    var Res = sample.DeleteActivityMaster(activityId);
                    objAction = CreatedAtAction("DeleteActivityMaster", Res);
                    return objAction;
                }

                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteActivityMaster", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ActivityMasterResp data = new ActivityMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteActivityMaster", data);
                return objAction;
            }
        }


    }
}
