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
using MimeKit;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public LocationMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(LocationMasterResp))]
        public IActionResult CreateLocationMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, 
            [FromBody] LocationMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
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

                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateLocationMaster", data);
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
        public IActionResult UpdateLocationMaster(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromBody] LocationMasterReq samp)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);
                    var Res = sample.UpdateLocationMaster(samp);
                    objAction = CreatedAtAction("UpdateLocationMaster", Res);
                    return objAction;
                }

                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateLocationMaster", data);
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
        public IActionResult GetLocationMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);
                    var Res = sample.GetLocationMaster();
                    objAction = CreatedAtAction("GetLocationMaster", Res);
                    return objAction;
                }

                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetLocationMaster", data);
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
        public IActionResult DeleteLocationMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long aggrementId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    Location_MasterBLL sample = new Location_MasterBLL(DBConnStr);
                    var Res = sample.DeleteLocationMaster(aggrementId);
                    objAction = CreatedAtAction("DeleteLocationMaster", Res);
                    return objAction;
                }

                LocationMasterResp data = new LocationMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteLocationMaster", data);
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
