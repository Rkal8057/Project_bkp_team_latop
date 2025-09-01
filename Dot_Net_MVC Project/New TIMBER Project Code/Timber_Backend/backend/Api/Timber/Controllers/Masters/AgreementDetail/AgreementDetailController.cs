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
    public class AgreementDetailController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public AgreementDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }



        [HttpPost("create")]
        [Produces("application/json", Type = typeof(AggrementMasterResp))]
        public IActionResult CreateAggrementMaster(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data ,
            [FromBody] AggrementMasterReq samp)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
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

                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateAggrementMaster", data);
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
        public IActionResult UpdateAggrementMaster([FromBody] AggrementMasterReq samp ,
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
        )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateAggrementMaster(samp);
                    objAction = CreatedAtAction("UpdateAggrementMaster", Res);
                    return objAction;
                }

                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateAggrementMaster", data);
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
        public IActionResult GetAggrementMasterByPartyMasterId(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data ,
            [FromQuery] long partyMasterId)
        {
            try
            {
                if (partyMasterId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "partyMasterId is required", Data = false });
                }

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.GetAggrementMasterById(partyMasterId);
                    objAction = CreatedAtAction("GetAggrementMasterByPartyMasterId", Res);
                    return objAction;
                }

                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAggrementMasterByPartyMasterId", data);
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
        public IActionResult DeleteAggrementMaster(long aggrementId ,
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data )
        {
            try
            {
                
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                AggrementMasterBLL sample = new AggrementMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteAggrementMaster(aggrementId);
                    objAction = CreatedAtAction("DeleteAggrementMaster", Res);
                    return objAction;
                }

                AggrementMasterResp data = new AggrementMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteAggrementMaster", data);
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
