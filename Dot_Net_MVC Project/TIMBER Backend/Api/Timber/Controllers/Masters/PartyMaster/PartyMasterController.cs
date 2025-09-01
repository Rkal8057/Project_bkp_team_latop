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
    public class PartyMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public PartyMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
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


        [HttpGet("allpartyList")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetAllPartyMaster(int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);

                var Res = sample.GetAllPartyMaster(pageNo, limit, searchKey);
                objAction = CreatedAtAction("GetAllPartyMaster", Res);
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



        [HttpGet("partyId")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult GetLastPartyMasterId()
        {
            try
            {
                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                var Res = sample.GetLastPartyMasterMasterId();
                objAction = CreatedAtAction("GetLastPartyMasterId", Res);
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
                objAction = CreatedAtAction("GetLastPartyMasterId", data);
                return objAction;
            }
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PartyMasterResp))]
        public IActionResult CreatePartyMaster([FromBody] PartyMasterReq samp)
        { 
            try
            {
              
                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                var isCheckPartyName = sample.PartyNameExistsInDatabase(samp);
                if (isCheckPartyName.PartyMasterDetailByID != null)
                {
              
                    return  CreatedAtAction("CreatePartyMaster", isCheckPartyName);
                }

                var Res = sample.InsertPartyMaster(samp);
                objAction = CreatedAtAction("CreatePartyMaster", Res);
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
        [FromBody] PartyMasterReq samp
        )
        {
            try
            {

                PartyMasterDLL sample = new PartyMasterDLL(DBConnStr);
                var Res = sample.UpdatePartyMaster(partyId, samp);
                objAction = CreatedAtAction("UpdatePartyMaster", Res);
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
        public IActionResult CheckDeletePartyMasterIfExistsInMaster(long partyId)
        {
            try
            {
           
                PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                var Res = inwaard.CheckDeletePartyMasterIfExistsInMaster(partyId);
                objAction = CreatedAtAction("CheckDeletePartyMasterIfExistsInMaster", Res);
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
        public IActionResult DeletePartyMaster(long partyId)
        {
            try
            {

                PartyMasterDLL inwaard = new PartyMasterDLL(DBConnStr);
                var Res = inwaard.DeletePartyMaster(partyId);
                objAction = CreatedAtAction("DeletePartyMaster", Res);
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
