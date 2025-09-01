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


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyCategoryMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public PartyCategoryMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PartyCategoryMasterResp))]
        public IActionResult CreatePartyCategoryMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, 
            [FromBody] PartyCategoryMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.CommonMasterBLL commonBLL = new CommonMasterBLL(DBConnStr);
                    PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);


                    // Check for duplicate entry (if required, depending on your logic)
                    var duplicateCheck = commonBLL.CheckDuplicateEntry("partyCategory", samp.category_name);
                    if (duplicateCheck.duplicate)
                    {
                        objAction = CreatedAtAction("CreatePartyCategoryMaster", duplicateCheck);
                        return objAction;
                    }

                    var Res = sample.InsertPartyCategoryMaster(samp);
                    objAction = CreatedAtAction("CreatePartyCategoryMaster", Res);
                    return objAction;
                }

                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreatePartyCategoryMaster", data);
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
        public IActionResult UpdatePartyCategoryMaster(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromBody] PartyCategoryMasterReq samp,
     [FromQuery] long partyCategoryId)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                    var Res = sample.UpdatePartyCategoryMaster(partyCategoryId, samp);
                    objAction = CreatedAtAction("UpdatePartyCategoryMaster", Res);
                    return objAction;
                }

                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdatePartyCategoryMaster", data);
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
        public IActionResult GetAllPartyCategoryMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int pageNo, int limit, string? searchKey = null, string? categoryName = null)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                    var Res = sample.GetAllPartyCategoryMaster(pageNo, limit, searchKey, categoryName);
                    objAction = CreatedAtAction("GetAllPartyCategoryMaster", Res);
                    return objAction;
                }

                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllPartyCategoryMaster", data);
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
        public IActionResult GetPartyCategoryMasterById(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromQuery] long partyCategoryId)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
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

                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetPartyCategoryMasterById", data);
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
        public IActionResult CheckDeletePartyCategoryIfExistsInMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromQuery] long partyCategoryId)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                    var Res = sample.CheckDeletePartyCategoryIfExistsInMaster(partyCategoryId);
                    objAction = CreatedAtAction("CheckDeletePartyCategoryIfExistsInMaster", Res);
                    return objAction;
                }

                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CheckDeletePartyCategoryIfExistsInMaster", data);
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
        public IActionResult DeletePartyCategory(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromQuery] long partyCategoryId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    PartyCategoryMasterBLL sample = new PartyCategoryMasterBLL(DBConnStr);
                    var Res = sample.DeletePartyCategory(partyCategoryId);
                    objAction = CreatedAtAction("DeletePartyCategory", Res);
                    return objAction;
                }

                PartyCategoryMasterResp data = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeletePartyCategory", data);
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
