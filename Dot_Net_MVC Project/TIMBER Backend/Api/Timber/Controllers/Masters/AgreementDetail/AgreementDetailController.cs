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
    public class AgreementDetailController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public AgreementDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }



        [HttpPost("create")]
        [Produces("application/json", Type = typeof(AggrementMasterResp))]
        public IActionResult CreateAggrementMaster([FromBody] AggrementMasterReq samp)
        {
            try
            {
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);

                var checkItem = sample.CheckAggrementMasterItem(samp.party_master_id, samp.item_code);
                if (checkItem.AggrementMasterDetailByID != null)
                {
                    objAction = CreatedAtAction("CreateAggrementMaster", checkItem);
                    return objAction;
                }

                var Res = sample.InsertAggrementMaster(samp);
                objAction = CreatedAtAction("CreateAggrementMaster", Res);


                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateAggrementMaster", data);
                return objAction;
            }
        }


        [HttpPost("update")]
        [Produces("application/json", Type = typeof(AggrementMasterResp))]
        public IActionResult UpdateAggrementMaster([FromBody] AggrementMasterReq samp)
        {
            try
            {
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                var Res = sample.UpdateAggrementMaster(samp);
                objAction = CreatedAtAction("UpdateAggrementMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateAggrementMaster", data);
                return objAction;
            }
        }


        [HttpGet("aggrementByPartyMasterId")]
        [Produces("application/json", Type = typeof(AggrementMasterResp))]
        public IActionResult GetAggrementMasterByPartyMasterId([FromQuery] long partyMasterId)
        {
            try
            {
                if (partyMasterId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "partyMasterId is required", Data = false });
                }

                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                var Res = sample.GetAggrementMasterById(partyMasterId);
                objAction = CreatedAtAction("GetAggrementMasterByPartyMasterId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAggrementMasterByPartyMasterId", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(AggrementMasterResp))]
        public IActionResult DeleteAggrementMaster(long aggrementId)
        {
            try
            {
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                var Res = sample.DeleteAggrementMaster(aggrementId);
                objAction = CreatedAtAction("DeleteAggrementMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteAggrementMaster", data);
                return objAction;
            }
        }

    }
}
