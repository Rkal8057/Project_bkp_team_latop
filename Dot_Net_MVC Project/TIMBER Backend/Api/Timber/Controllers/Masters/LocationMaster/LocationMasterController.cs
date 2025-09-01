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
    public class LocationMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public LocationMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }



        [HttpPost("create")]
        [Produces("application/json", Type = typeof(LocationMasterResp))]
        public IActionResult CreateLocationMaster([FromBody] LocationMasterReq samp)
        {
            try
            {
                Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);

                var checkItem = sample.CheckLocationMasterNameExits(samp.location_name);
                if (checkItem.LocationMasterDetailByID != null)
                {
                    objAction = CreatedAtAction("CreateLocationMaster", checkItem);
                    return objAction;
                }

                var Res = sample.InsertLocationMaster(samp);
                objAction = CreatedAtAction("CreateLocationMaster", Res);


                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateLocationMaster", data);
                return objAction;
            }
        }


        [HttpPost("update")]
        [Produces("application/json", Type = typeof(LocationMasterResp))]
        public IActionResult UpdateLocationMaster([FromBody] LocationMasterReq samp)
        {
            try
            {
                Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);
                var Res = sample.UpdateLocationMaster(samp);
                objAction = CreatedAtAction("UpdateLocationMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateLocationMaster", data);
                return objAction;
            }
        }

        [HttpGet("allLocation")]
        [Produces("application/json", Type = typeof(LocationMasterResp))]
        public IActionResult GetLocationMaster()
        {
            try
            {
                Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);
                var Res = sample.GetLocationMaster();
                objAction = CreatedAtAction("GetLocationMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetLocationMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(LocationMasterResp))]
        public IActionResult DeleteLocationMaster(long aggrementId)
        {
            try
            {
                Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);
                var Res = sample.DeleteLocationMaster(aggrementId);
                objAction = CreatedAtAction("DeleteLocationMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteLocationMaster", data);
                return objAction;
            }
        }

    }
}
