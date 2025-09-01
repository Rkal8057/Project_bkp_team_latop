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
    public class PartyItemRateMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public PartyItemRateMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }



        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PartyItemRateMasterResp))]
        public IActionResult CreatePartyItemRateMaster([FromBody] PartyItemRateMasterReq samp)
        {
            try
            {
                PartyItemRateMasterBLL sample = new PartyItemRateMasterBLL(DBConnStr);

                var checkItem = sample.CheckPartyItemRateMasterItem(samp.party_master_id, samp.item_code);
                if (checkItem.PartyItemRateTransById != null)
                {
                    objAction = CreatedAtAction("CreatePartyItemRateMaster", checkItem);
                    return objAction;
                }

                var Res = sample.InsertPartyItemRateMaster(samp);
                objAction = CreatedAtAction("CreatePartyItemRateMaster", Res);


                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyItemRateMasterResp data = new PartyItemRateMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreatePartyItemRateMaster", data);
                return objAction;
            }
        }


        [HttpPost("update")]
        [Produces("application/json", Type = typeof(PartyItemRateMasterResp))]
        public IActionResult UpdatePartyItemRateMaster([FromBody] PartyItemRateMasterReq samp)
        {
            try
            {
                PartyItemRateMasterBLL sample = new PartyItemRateMasterBLL(DBConnStr);
                var Res = sample.UpdatePartyItemRateMaster(samp);
                objAction = CreatedAtAction("UpdatePartyItemRateMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyItemRateMasterResp data = new PartyItemRateMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdatePartyItemRateMaster", data);
                return objAction;
            }
        }


        [HttpGet("itemRateByPartyMasterId")]
        [Produces("application/json", Type = typeof(PartyItemRateMasterResp))]
        public IActionResult GetPartyItemRateMasterByPartyMasterId([FromQuery] long partyMasterId)
        {
            try
            {
                if (partyMasterId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "partyMasterId is required", Data = false });
                }

                PartyItemRateMasterBLL sample = new PartyItemRateMasterBLL(DBConnStr);
                var Res = sample.GetPartyItemRateMasterById(partyMasterId);
                objAction = CreatedAtAction("GetPartyItemRateMasterByPartyMasterId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyItemRateMasterResp data = new PartyItemRateMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPartyItemRateMasterByPartyMasterId", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(PartyItemRateMasterResp))]
        public IActionResult DeletePartyItemRateMaster(long aggrementId)
        {
            try
            {
                PartyItemRateMasterBLL sample = new PartyItemRateMasterBLL(DBConnStr);
                var Res = sample.DeletePartyItemRateMaster(aggrementId);
                objAction = CreatedAtAction("DeletePartyItemRateMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PartyItemRateMasterResp data = new PartyItemRateMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeletePartyItemRateMaster", data);
                return objAction;
            }
        }

    }
}

