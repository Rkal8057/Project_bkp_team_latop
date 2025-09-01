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


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseHireMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CaseHireMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CaseHireMasterResp))]
        public IActionResult CreateCaseHireMaster([FromBody] CaseHireMasterReq samp)
        {
            try
            {
                CaseHireMasterBLL sample = new CaseHireMasterBLL(DBConnStr);
                var Res = sample.InsertCaseHireMaster(samp);
                objAction = CreatedAtAction("CreateCaseHireMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseHireMasterResp data = new CaseHireMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateCaseHireMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CaseHireMasterResp))]
        public IActionResult UpdateCaseHireMaster([FromBody] CaseHireMasterReq samp, [FromQuery] long id)
        {
            try
            {
                CaseHireMasterBLL sample = new CaseHireMasterBLL(DBConnStr);
                var Res = sample.UpdateCaseHireMaster(id, samp);
                objAction = CreatedAtAction("UpdateCaseHireMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseHireMasterResp data = new CaseHireMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateCaseHireMaster", data);
                return objAction;
            }
        }


        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(CaseHireMasterResp))]
        public IActionResult GetAllCaseHireMaster()
        {
            try
            {
                CaseHireMasterBLL sample = new CaseHireMasterBLL(DBConnStr);
                var Res = sample.GetAllCaseHireMaster();
                objAction = CreatedAtAction("GetAllCaseHireMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseHireMasterResp data = new CaseHireMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllCaseHireMaster", data);
                return objAction;
            }
        }

        [HttpGet("detailbyid")]
        [Produces("application/json", Type = typeof(CaseHireMasterResp))]
        public IActionResult GetCaseHireMasterById([FromQuery] long id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "categoryId is required", Data = false });
                }

                CaseHireMasterBLL sample = new CaseHireMasterBLL(DBConnStr);
                var Res = sample.GetCaseHireMasterById(id);
                objAction = CreatedAtAction("GetCaseHireMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseHireMasterResp data = new CaseHireMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCaseHireMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CaseHireMasterResp))]
        public IActionResult DeleteCaseHireMaster([FromQuery] long id)
        {
            try
            {
                CaseHireMasterBLL sample = new CaseHireMasterBLL(DBConnStr);
                var Res = sample.DeleteCaseHireMaster(id);
                objAction = CreatedAtAction("DeleteCaseHireMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseHireMasterResp data = new CaseHireMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCaseHireMaster", data);
                return objAction;
            }
        }
    }
}
