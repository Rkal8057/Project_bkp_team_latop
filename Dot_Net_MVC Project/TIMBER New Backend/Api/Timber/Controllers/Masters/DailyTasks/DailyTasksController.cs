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
using System.Security.AccessControl;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyTasksController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public DailyTasksController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpGet("allDailyTask")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult GetDailyTask([FromHeader] long Token_ID, [FromHeader] string Token_Data, string? searchKey = null)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.GetDailyTask(searchKey);
                    objAction = CreatedAtAction("GetDailyTask", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetDailyTask", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDailyTask", data);
                return objAction;
            }
        }

        [HttpGet("allDailyTaskByUserId")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult GetDailyTaskByUserId([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long? userId, string? searchKey = null)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.GetDailyTaskByUserId(userId, searchKey);
                    objAction = CreatedAtAction("GetDailyTaskByUserId", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetDailyTaskByUserId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDailyTaskByUserId", data);
                return objAction;
            }
        }

        [HttpGet("allDailyTaskWithCurrentDateByUserId")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult GetDailyTaskWithCurrentDateByUserId([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long? userId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.GetDailyTaskWithCurrentDateByUserId(userId);
                    objAction = CreatedAtAction("GetDailyTaskWithCurrentDateByUserId", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetDailyTaskWithCurrentDateByUserId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDailyTaskWithCurrentDateByUserId", data);
                return objAction;
            }
        }

        [HttpGet("DailyTaskDetailByUserId")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult GetDailyTaskByUserId([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long dailyTaskId, long userId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.GetDailyTaskByUserId(dailyTaskId, userId);
                    objAction = CreatedAtAction("GetDailyTaskByUserId", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetDailyTaskByUserId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDailyTaskByUserId", data);
                return objAction;
            }
        }

        [HttpGet("DailyTaskDetail")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult GetDailyTaskById([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long dailyTaskId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.GetDailyTaskById(dailyTaskId);
                    objAction = CreatedAtAction("GetDailyTaskById", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetDailyTaskById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDailyTaskById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult AddDailyTask([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] DailyTaskReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "ADD"))
                {
                    RTA.Masters.CommonMasterBLL commonBLL = new CommonMasterBLL(DBConnStr);
                    var duplicateCheck = commonBLL.CheckDuplicateEntry("dailytask", samp.task_title);
                    if (duplicateCheck.duplicate)
                    {
                        objAction = CreatedAtAction("AddDailyTask", duplicateCheck);
                        return objAction;
                    }

                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.InsertDailyTask(samp);
                    objAction = CreatedAtAction("AddDailyTask", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddDailyTask", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddDailyTask", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult UpdateDailyTask([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long dailyTaskId, [FromBody] DailyTaskReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "UPDATE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.UpdateDailyTask(dailyTaskId, samp);
                    objAction = CreatedAtAction("UpdateDailyTask", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateDailyTask", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateDailyTask", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(DailyTaskResp))]
        public IActionResult DeleteDailyTask(long dailyTaskId , [FromHeader] long Token_ID,
         [FromHeader] string Token_Data )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.DailyTasksBLL sample = new DailyTasksBLL(DBConnStr);
                    var Res = sample.DeleteDailyTask(dailyTaskId);
                    objAction = CreatedAtAction("DeleteDailyTask", Res);
                    return objAction;
                }

                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteDailyTask", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DailyTaskResp data = new DailyTaskResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteDailyTask", data);
                return objAction;
            }
        }

    }
}
