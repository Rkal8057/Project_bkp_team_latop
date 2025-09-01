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
    public class SystemFilterMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public SystemFilterMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpGet("allfilter")]
        [Produces("application/json", Type = typeof(SystemFilterMasterResp))]
        public IActionResult GetSystemFilterMaster(string? searchKey)
        {
            try
            {
                RTA.Masters.SystemFilterMasterBLL sample = new SystemFilterMasterBLL(DBConnStr);
                var Res = sample.GetSystemFilterMaster(searchKey);
                objAction = CreatedAtAction("GetSystemFilterMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSystemFilterMaster", data);
                return objAction;
            }
        }

        [HttpGet("filterById")]
        [Produces("application/json", Type = typeof(SystemFilterMasterResp))]
        public IActionResult GetSystemFilterMasterById(long filterId)
        {
            try
            {
                RTA.Masters.SystemFilterMasterBLL sample = new SystemFilterMasterBLL(DBConnStr);
                var Res = sample.GetSystemFilterMasterById(filterId);
                objAction = CreatedAtAction("GetSystemFilterMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSystemFilterMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SystemFilterMasterResp))]
        public IActionResult AddSystemFilterMaster([FromBody] SystemFilterMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SystemFilterMasterBLL sample = new SystemFilterMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertSystemFilterMaster(samp);
                    objAction = CreatedAtAction("AddSystemFilterMaster", Res);
                    return objAction;
                }
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSystemFilterMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSystemFilterMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SystemFilterMasterResp))]
        public IActionResult UpdateSystemFilterMaster(long filterId, [FromBody] SystemFilterMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
               

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SystemFilterMasterBLL sample = new SystemFilterMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateSystemFilterMaster(filterId, samp);
                    objAction = CreatedAtAction("UpdateSystemFilterMaster", Res);
                    return objAction;

                }
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateSystemFilterMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSystemFilterMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SystemFilterMasterResp))]
        public IActionResult DeleteSystemFilterMaster(long filterId,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SystemFilterMasterBLL sample = new SystemFilterMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.DeleteSystemFilterMaster(filterId);
                    objAction = CreatedAtAction("DeleteSystemFilterMaster", Res);
                    return objAction;

                }
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteSystemFilterMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemFilterMasterResp data = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSystemFilterMaster", data);
                return objAction;
            }
        }
    }
}
