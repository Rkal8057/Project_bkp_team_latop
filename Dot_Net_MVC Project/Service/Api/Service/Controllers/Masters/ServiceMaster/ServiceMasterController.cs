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
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ServiceMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult CreateServiceMaster([FromBody] ServiceMasterReq samp)
        {
            try
            {
                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.InsertServiceMaster(samp);
                objAction = CreatedAtAction("CreateServiceMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateServiceMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult DeleteServiceMaster([FromQuery] long id)
        {
            try
            {

                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.DeleteServiceMaster(id);
                objAction = CreatedAtAction("DeleteServiceMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteServiceMaster", data);
                return objAction;
            }
        }

        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult GetServiceMaster()
        {
            try
            {

                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.GetServiceMaster();
                objAction = CreatedAtAction("GetServiceMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetServiceMaster", data);
                return objAction;
            }
        }


        [HttpGet("Alldetail")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult GetAllServiceMaster(int page = 1, int limit = 20 )
        {
            try
            {

                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.GetAllServiceMaster(page, limit );
                objAction = CreatedAtAction("GetAllServiceMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllServiceMaster", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult UpdateServiceMaster(long id, [FromBody] UpdateServiceMasterReq samp)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }

                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.UpdateServiceMaster(id, samp);
                objAction = CreatedAtAction("UpdateServiceMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateServiceMaster", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult GetServiceMasterById([FromQuery] long id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }


                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.GetServiceMasterById(id);
                objAction = CreatedAtAction("GetServiceMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetServiceMasterById", data);
                return objAction;
            }
        }

    }
}
