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
using DocumentFormat.OpenXml.Office2010.Excel;
using RTA.Common.Models;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelperFlagMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public HelperFlagMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(HelperFlagMasterResp))]
        public IActionResult CreateHelperFlagMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] HelperFlagMasterReq samp)
        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);

                    var isCheckCategoryName = sample.HelperFlagNameExistsInDatabase(samp);
                    if (isCheckCategoryName.HelperFlagMasterByID != null)
                    {
                        return CreatedAtAction("CreateHelperFlagMaster", isCheckCategoryName);
                    }

                    var Res = sample.InsertHelperFlagMaster(samp);
                    objAction = CreatedAtAction("CreateHelperFlagMaster", Res);

                    return objAction;
                }

                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateHelperFlagMaster", data);
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
        public IActionResult UpdateHelperFlagMaster( [FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromBody] HelperFlagMasterReq samp, [FromQuery] long helperFlagId)
        {
            try
            {
                // Authenticate the token
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights for updating
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                    var Res = sample.UpdateHelperFlagMaster(helperFlagId, samp);
                    objAction = CreatedAtAction("UpdateHelperFlagMaster", Res);
                    return objAction;
                }

                // Return error message if user lacks rights
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateHelperFlagMaster", data);
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
        public IActionResult GetAllHelperFlagMaster([FromHeader] long Token_ID, [FromHeader] string Token_Data, int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                // Authenticate the token
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights for retrieving all helper flags
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                    var Res = sample.GetAllHelperFlagMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetAllHelperFlagMaster", Res);
                    return objAction;
                }

                // Return error message if user lacks rights
                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllHelperFlagMaster", data);
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
        public IActionResult GetHelperFlagMasterById([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] long helperFlagId)
        {
            try
            {
                // Authenticate the token
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
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

                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetHelperFlagMasterById", data);
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
        public IActionResult DeleteHelperFlagMaster([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] long helperFlagId)
        {
            try
            {
                // Authenticate the token
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    HelperFlagMasterBLL sample = new HelperFlagMasterBLL(DBConnStr);
                    var Res = sample.DeleteHelperFlagMaster(helperFlagId);
                    objAction = CreatedAtAction("DeleteHelperFlagMaster", Res);
                    return objAction;
                }

                HelperFlagMasterResp data = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteHelperFlagMaster", data);
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
