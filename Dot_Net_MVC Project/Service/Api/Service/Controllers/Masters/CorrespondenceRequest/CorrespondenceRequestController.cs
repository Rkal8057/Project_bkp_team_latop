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
    public class CorrespondenceRequestController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CorrespondenceRequestController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CorrespondenceRequestResp))]
        public IActionResult AddCorrespondenceRequest([FromBody] CorrespondenceRequestReq samp)
        {
            try
            {
                CorrespondenceRequestBLL sample = new CorrespondenceRequestBLL(DBConnStr);
                var Res = sample.InsertCorrespondenceRequest(samp);
                objAction = CreatedAtAction("AddCorrespondenceRequest", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CorrespondenceRequestResp data = new CorrespondenceRequestResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddCorrespondenceRequest", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(CorrespondenceRequestResp))]
        public IActionResult GetCorrespondenceRequestById([FromQuery] long id)
        {
            try
            {

                if (id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }

                CorrespondenceRequestBLL sample = new CorrespondenceRequestBLL(DBConnStr);
                var Res = sample.GetCorrespondenceRequestById(id);
                objAction = CreatedAtAction("GetCorrespondenceRequestById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CorrespondenceRequestResp data = new CorrespondenceRequestResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCorrespondenceRequestById", data);
                return objAction;
            }
        }


        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(CorrespondenceRequestResp))]
        public IActionResult GetAllGeneralRequested([FromQuery] int page = 1, int limit = 20, string? status = null)
        {
            try
            {
                CorrespondenceRequestBLL sample = new CorrespondenceRequestBLL(DBConnStr);
                var Res = sample.GetCorrespondenceRequest(page, limit, status);
                objAction = CreatedAtAction("GetAllGeneralRequested", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllGeneralRequested", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CorrespondenceRequestResp))]
        public IActionResult UpdateCorrespondenceRequest([FromQuery] int id, [FromBody] CorrespondenceRequestReq samp)
        {
            try
            {
                CorrespondenceRequestBLL sample = new CorrespondenceRequestBLL(DBConnStr);
                var Res = sample.UpdateCorrespondenceRequest(id, samp);
                objAction = CreatedAtAction("UpdateCorrespondenceRequest", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CorrespondenceRequestResp data = new CorrespondenceRequestResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateCorrespondenceRequest", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CorrespondenceRequestResp))]
        public IActionResult DeleteCorrespondenceRequest([FromQuery] long id)
        {
            try
            {
                CorrespondenceRequestBLL sample = new CorrespondenceRequestBLL(DBConnStr);
                var Res = sample.DeleteCorrespondenceRequest(id);
                objAction = CreatedAtAction("DeleteCorrespondenceRequest", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CorrespondenceRequestResp data = new CorrespondenceRequestResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCorrespondenceRequest", data);
                return objAction;
            }
        }




    }
}
