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
using MimeKit;
using RTA.Common.Models;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueReceiptController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public IssueReceiptController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult CreateChallanMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] IssueReceiptReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);

                    var checkChallanNumber = sample.CheckChallanNumber(samp.billno_automatic, samp.irflag);
                    if (checkChallanNumber.IssueReceiptMasterDetailByID != null)
                    {
                        objAction = CreatedAtAction("CreateChallanMaster", checkChallanNumber);
                        return objAction;
                    }

                    var Res = sample.InsertIssueReceiptMaster(samp);
                    objAction = CreatedAtAction("CreateChallanMaster", Res);


                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateChallanMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateChallanMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult UpdateChallanMaster([FromHeader] long Token_ID,
       [FromHeader] string Token_Data, [FromBody] IssueReceiptReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.UpdateIssueReceiptMaster(samp);
                    objAction = CreatedAtAction("UpdateChallanMaster", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateChallanMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateChallanMaster", data);
                return objAction;
            }
        }

        [HttpGet("allchallan")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetAllChallanMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? flag, DateTime? startDate = null, DateTime? endDate = null, string? searchKey = null)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.GetIssueReceiptMaster(flag, startDate, endDate, searchKey);
                    objAction = CreatedAtAction("GetAllChallanMaster", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllChallanMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllChallanMaster", data);
                return objAction;
            }
        }

        [HttpGet("challanById")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetChallanMasterById([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] long challanId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (challanId <= 0)
                    {
                        return BadRequest(new { Status = false, Message = "challanId is required", Data = false });
                    }

                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.GetIssueReceiptMasterById(challanId);
                    objAction = CreatedAtAction("GetChallanMasterById", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetChallanMasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetChallanMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult DeleteChallanMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] long challanId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.DeleteIssueReceiptMaster(challanId);
                    objAction = CreatedAtAction("DeleteChallanMaster", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteChallanMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteChallanMaster", data);
                return objAction;
            }
        }

        [HttpGet("challanId")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetLastChallanMasterId([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? irFlag = "")
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.GetLastChallanMasterId(irFlag);
                    objAction = CreatedAtAction("GetLastChallanMasterId", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetLastChallanMasterId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetLastChallanMasterId", data);
                return objAction;
            }
        }


        // ==========================  Challan Brokage Master Api ============================

        [HttpPost("createChallanBrokage")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult InsertIssueReceiptBreakageMaster([FromHeader] long Token_ID,
      [FromHeader] string Token_Data, [FromBody] IssueReceiptReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.InsertIssueReceiptBreakageMaster(samp);
                    objAction = CreatedAtAction("CreateChallanBrokageMaster", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateChallanBrokageMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateChallanBrokageMaster", data);
                return objAction;
            }
        }



        [HttpPut("updateChallanBrokage")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult UpdateIssueReceiptBreakageMaster([FromHeader] long Token_ID,
     [FromHeader] string Token_Data, [FromBody] IssueReceiptReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.UpdateIssueReceiptBreakageMaster(samp);
                    objAction = CreatedAtAction("UpdateIssueReceiptBreakageMaster", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateIssueReceiptBreakageMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateIssueReceiptBreakageMaster", data);
                return objAction;
            }
        }



        [HttpDelete("deleteChallanBrokage")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult DeleteIssueReceiptBreakageMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] long challanBrokageId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.DeleteIssueReceiptBreakageMaster(challanBrokageId);
                    objAction = CreatedAtAction("DeleteIssueReceiptBreakageMaster", Res);
                    return objAction;
                }

                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteIssueReceiptBreakageMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteIssueReceiptBreakageMaster", data);
                return objAction;
            }
        }

        [HttpGet("allChallanBrokageByChallanTransId")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetIssueReceiptBreakageByIssueTransMaster(
         [FromHeader] long Token_ID,
         [FromHeader] string Token_Data,
         long challan_trans_id,
         long challan_master_id)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Process the request
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.GetIssueReceiptBreakageByIssueTransMaster(challan_trans_id, challan_master_id);
                    objAction = CreatedAtAction("GetIssueReceiptBreakageByIssueTransMaster", Res);
                    return objAction;
                }

                // If user does not have rights
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetIssueReceiptBreakageByIssueTransMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetIssueReceiptBreakageByIssueTransMaster", data);
                return objAction;
            }
        }

        [HttpGet("lastFiveRecords")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetIssueReceiptMasterByLastRecords(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long? challanId,
            string? flag)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    // Process the request
                    IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                    var Res = sample.GetIssueReceiptMasterByLastRecords(challanId, flag);
                    objAction = CreatedAtAction("GetIssueReceiptMasterByLastRecords", Res);
                    return objAction;
                }

                // If user does not have rights
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetIssueReceiptMasterByLastRecords", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetIssueReceiptMasterByLastRecords", data);
                return objAction;
            }
        }

    }
}

