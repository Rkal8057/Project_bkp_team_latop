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
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public PartyMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        //GET ALL RECORDS
        [HttpGet("allparty")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetPartyMasterRecords(int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);

                var Res = sample.GetPartyMaster(pageNo, limit,searchKey);
                objAction = CreatedAtAction("GetPartyMasterRecords", Res);
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


        [HttpGet("getdetailbyid")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetPartyMasterByID(int id)
        {
            try
            {

                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                var Res = sample.GetPartyMasterByID(id);
                objAction = CreatedAtAction("GetPartyMasterByID", Res);
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
        public IActionResult CreatePartyMaster([FromBody] PartyMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
            )
        { 
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
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
        public IActionResult UpdatePartyMaster(long partyId,
        [FromBody] PartyMasterReq samp,
        [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
        )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
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

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult DeletePartyMaster(long partyId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {           
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
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



    }
}
