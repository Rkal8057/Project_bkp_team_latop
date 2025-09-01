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
    public class PartyCategoryMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public PartyCategoryMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult CreatePartyCategoryMaster([FromBody] PartyCategoryMasterReq samp)
        {
            try
            {
                PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                 var Res = sample.InsertPartyCategoryMaster(samp);
                objAction = CreatedAtAction("CreatePartyCategoryMaster", Res);


                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreatePartyCategoryMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult UpdatePartyCategoryMaster([FromBody] PartyCategoryMasterReq samp, [FromQuery] long partyCategoryId)
        {
            try
            {
                PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                var Res = sample.UpdatePartyCategoryMaster(partyCategoryId, samp);
                objAction = CreatedAtAction("UpdatePartyCategoryMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdatePartyCategoryMaster", data);
                return objAction;
            }
        }


        [HttpGet("allpartycategory")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult GetAllPartyCategoryMaster()
        {
            try
            {
                PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                var Res = sample.GetAllPartyCategoryMaster();
                objAction = CreatedAtAction("GetAllPartyCategoryMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllPartyCategoryMaster", data);
                return objAction;
            }
        }



        [HttpGet("partycategorybyid")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult GetPartyCategoryMasterById([FromQuery] long partyCategoryId)
        {
            try
            {
                if (partyCategoryId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "partyCategoryId is required", Data = false });
                }

                PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                var Res = sample.GetPartyCategoryMasterById(partyCategoryId);
                objAction = CreatedAtAction("GetPartyCategoryMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPartyCategoryMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("checkDeletePartyCategoryData")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult CheckDeletePartyCategoryIfExistsInMaster([FromQuery] long partyCategoryId)
        {
            try
            {
                PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                var Res = sample.CheckDeletePartyCategoryIfExistsInMaster(partyCategoryId);
                objAction = CreatedAtAction("CheckDeletePartyCategoryIfExistsInMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CheckDeletePartyCategoryIfExistsInMaster", data);
                return objAction;
            }
        }



        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult DeletePartyCategory([FromQuery] long partyCategoryId)
        {
            try
            {
                PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                var Res = sample.DeletePartyCategory(partyCategoryId);
                objAction = CreatedAtAction("DeletePartyCategory", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeletePartyCategory", data);
                return objAction;
            }
        }
    }
}
