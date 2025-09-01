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

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public PartyMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        //DELETE ALL RECORDS
        [HttpGet("allparty")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetPartyMasterRecords(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);

                    var Res = sample.GetPartyMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetPartyMasterRecords", Res);
                    return objAction;

                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetPartyMasterRecords", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPartyMasterRecords", data);
                return objAction;
            }
        }

        [HttpGet("allpartyList")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetAllPartyMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                    var Res = sample.GetAllPartyMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetAllPartyMaster", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllPartyMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllPartyMaster", data);
                return objAction;
            }
        }

        [HttpGet("allpartyfilter")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetAllPartyMasterFilterData(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            string? filter, string? search)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                    var Res = sample.GetAllPartyMasterFilterData(filter, search);
                    objAction = CreatedAtAction("GetAllPartyMaster", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllPartyMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllPartyMaster", data);
                return objAction;
            }
        }

        [HttpGet("getdetailbyid")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetPartyMasterByID(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int id)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                    var Res = sample.GetPartyMasterByID(id);
                    objAction = CreatedAtAction("GetPartyMasterByID", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetPartyMasterByID", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPartyMasterByID", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult CreatePartyMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] PartyMasterReq samp)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                    var isCheckPartyName = sample.PartyNameExistsInDatabase(samp);
                    if (isCheckPartyName.PartyMasterDetailByID != null)
                    {
                        return CreatedAtAction("CreatePartyMaster", isCheckPartyName);
                    }

                    var Res = sample.InsertPartyMaster(samp);
                    objAction = CreatedAtAction("CreatePartyMaster", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreatePartyMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreatePartyMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult UpdatePartyMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long partyId,
            [FromBody] PartyMasterReq samp)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                    var Res = sample.UpdatePartyMaster(partyId, samp);
                    objAction = CreatedAtAction("UpdatePartyMaster", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdatePartyMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdatePartyMaster", data);
                return objAction;
            }
        }

        [HttpDelete("checkDeletePartyData")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult CheckDeletePartyMasterIfExistsInMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long partyId)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                    var Res = inwaard.CheckDeletePartyMasterIfExistsInMaster(partyId);
                    objAction = CreatedAtAction("CheckDeletePartyMasterIfExistsInMaster", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CheckDeletePartyMasterIfExistsInMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CheckDeletePartyMasterIfExistsInMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult DeletePartyMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long partyId)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                    var Res = inwaard.DeletePartyMaster(partyId);
                    objAction = CreatedAtAction("DeletePartyMaster", Res);
                    return objAction;
                }

                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeletePartyMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyMasterResp data = new PartyMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeletePartyMaster", data);
                return objAction;
            }
        }

        [HttpGet("detailByMobileNo")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetPartyMasterDataByMobileNo(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? mobileNo = null)
        {
            {
                try
                {

                    ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                    if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                    {
                        PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                        var Res = inwaard.GetPartyMasterDataByMobileNo(mobileNo);
                        objAction = CreatedAtAction("GetPartyMasterDataByMobileNo", Res);
                        return objAction;
                    }

                    PartyMasterResp data = new PartyMasterResp()
                    {
                        status = false,
                        Message = modelAuth.message
                    };
                    objAction = CreatedAtAction("GetPartyMasterDataByMobileNo", data);
                    return objAction;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    PartyMasterResp data = new PartyMasterResp()
                    {
                        status = false,
                        Message = ex.Message
                    };
                    objAction = CreatedAtAction("GetPartyMasterDataByMobileNo", data);
                    return objAction;
                }
            }

        }




















        [HttpGet("partyId")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetLastPartyMasterMasterId(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            {
                try
                {

                    ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                    if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                    {
                        PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                        var Res = inwaard.GetLastPartyMasterMasterId();
                        objAction = CreatedAtAction("GetLastPartyMasterMasterId", Res);
                        return objAction;
                    }

                    PartyMasterResp data = new PartyMasterResp()
                    {
                        status = false,
                        Message = modelAuth.message
                    };
                    objAction = CreatedAtAction("GetLastPartyMasterMasterId", data);
                    return objAction;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    PartyMasterResp data = new PartyMasterResp()
                    {
                        status = false,
                        Message = ex.Message
                    };
                    objAction = CreatedAtAction("GetLastPartyMasterMasterId", data);
                    return objAction;
                }
            }

        }

    }
}
