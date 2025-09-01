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
using Microsoft.AspNetCore.Authorization;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public DashboardController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }


        [HttpGet("all")]
        [Produces("application/json", Type = typeof(DashboardMasterResp))]
        public IActionResult GetDashboardMaster()
        {
            try
            {
                RTA.Masters.DashboardMasterBLL sample = new DashboardMasterBLL(DBConnStr);
                var Res = sample.GetDashboardMaster();
                objAction = CreatedAtAction("GetDashboardMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DashboardMasterResp data = new DashboardMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDashboardMaster", data);
                return objAction;
            }
        }



        [HttpGet("allRevenue")]
        [Produces("application/json", Type = typeof(DashboardMasterResp))]
        public IActionResult GetDashboardMasterRevenue()
        {
            try
            {
                RTA.Masters.DashboardMasterBLL sample = new DashboardMasterBLL(DBConnStr);
                var Res = sample.GetDashboardMasterRevenue();
                objAction = CreatedAtAction("GetDashboardMasterRevenue", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DashboardMasterResp data = new DashboardMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetDashboardMasterRevenue", data);
                return objAction;
            }
        }
    }
}
