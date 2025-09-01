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
    public class HelperFlagMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public HelperFlagMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

         [HttpPost("create")]
        [Produces("application/json", Type = typeof(HelperFlagMasterResp))]
        public IActionResult CreateHelperFlagMaster([FromBody] HelperFlagMasterReq samp)
        {
            try
            {
                HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);

                var isCheckCategoryName = sample.HelperFlagNameExistsInDatabase(samp);
                if (isCheckCategoryName.HelperFlagMasterByID != null)
                {
                    return CreatedAtAction("CreateHelperFlagMaster", isCheckCategoryName);

                }

                // Category name doesn't exist, proceed with insertion
                var Res = sample.InsertHelperFlagMaster(samp);
                objAction = CreatedAtAction("CreateHelperFlagMaster", Res);
                

                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateHelperFlagMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(HelperFlagMasterResp))]
        public IActionResult UpdateHelperFlagMaster([FromBody] HelperFlagMasterReq samp,[FromQuery] long helperFlagId)
        {
            try
            {
                HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                var Res = sample.UpdateHelperFlagMaster(helperFlagId, samp);
                objAction = CreatedAtAction("UpdateHelperFlagMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateHelperFlagMaster", data);
                return objAction;
            }
        }


        [HttpGet("allHelperFlag")]
        [Produces("application/json", Type = typeof(HelperFlagMasterResp))]
        public IActionResult GetAllHelperFlagMaster(int pageNo =1, int limit =10, string? searchKey = null)
        {
            try
            {
                HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                var Res = sample.GetAllHelperFlagMaster(pageNo, limit, searchKey);
                objAction = CreatedAtAction("GetAllHelperFlagMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllHelperFlagMaster", data);
                return objAction;
            }
        }



        [HttpGet("helperFlagById")]
        [Produces("application/json", Type = typeof(HelperFlagMasterResp))]
        public IActionResult GetHelperFlagMasterById([FromQuery] long helperFlagId)
        {
            try
            {
                if (helperFlagId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "helperFlagId is required", Data = false });
                }

                HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                var Res = sample.GetHelperFlagMasterById(helperFlagId);
                objAction = CreatedAtAction("GetHelperFlagMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetHelperFlagMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(HelperFlagMasterResp))]
        public IActionResult DeleteHelperFlagMaster([FromQuery] long helperFlagId)
        {
            try
            {
                HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                var Res = sample.DeleteHelperFlagMaster(helperFlagId);
                objAction = CreatedAtAction("DeleteHelperFlagMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteHelperFlagMaster", data);
                return objAction;
            }
        }
    }
}
