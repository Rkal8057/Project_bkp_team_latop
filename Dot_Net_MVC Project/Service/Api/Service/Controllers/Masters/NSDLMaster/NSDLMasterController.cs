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

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class NSDLMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public NSDLMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }

        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(NSDLMasterResp))]
        public IActionResult GetNSDLMaster()
        {
            try
            {

                NSDLMasterBLL sample = new NSDLMasterBLL(DBConnStr);
                var Res = sample.GetNSDLMaster();
                objAction = CreatedAtAction("GetNSDLMaster", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NSDLMasterResp data = new NSDLMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetNSDLMaster", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(NSDLMasterResp))]
        public IActionResult GetNSDLMasterByID(long id)
        {
            try
            {

                RTA.Masters.NSDLMasterBLL sample = new NSDLMasterBLL(DBConnStr);
                var Res = sample.GetNSDLMasterByID(id);
                objAction = CreatedAtAction("GetNSDLMasterByID", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NSDLMasterResp data = new NSDLMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetNSDLMasterByID", data);
                return objAction;
            }
        }


    }
}
