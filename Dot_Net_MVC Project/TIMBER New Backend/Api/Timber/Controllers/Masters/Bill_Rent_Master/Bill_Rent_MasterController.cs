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
    public class Bill_Rent_MasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public Bill_Rent_MasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult CreateBill_Rent_Master(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] Bill_Rent_MasterReq samp)
        {
            try
            {
                
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.InsertBill_Rent_Master(samp);
                    objAction = CreatedAtAction("CreateBill_Rent_Master", Res);
                    return objAction;

                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateBill_Rent_Master", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateBill_Rent_Master", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult UpdateBill_Rent_Master(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data, [FromBody] Bill_Rent_MasterReq samp, [FromQuery] long billId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateBill_Rent_Master(billId, samp);
                    objAction = CreatedAtAction("UpdateBill_Rent_Master", Res);
                    return objAction;
                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateBill_Rent_Master", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateBill_Rent_Master", data);
                return objAction;
            }
        }

        [HttpGet("allbill")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult GetAllBill_Rent_Master(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.GetAllBill_Rent_Master(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetAllBill_Rent_Master", Res);
                    return objAction;
                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllBill_Rent_Master", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllBill_Rent_Master", data);
                return objAction;
            }
        }

        [HttpGet("billbyid")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult GetBill_Rent_MasterById(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] long billId)
        {
            try
            {
                if (billId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "BillId is required", Data = false });
                }

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.GetBill_Rent_MasterById(billId);
                    objAction = CreatedAtAction("GetBill_Rent_MasterById", Res);
                    return objAction;
                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetBill_Rent_MasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBill_Rent_MasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult DeleteBill_Rent_Master(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] long billId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteBill_Rent_Master(billId);
                    objAction = CreatedAtAction("DeleteBill_Rent_Master", Res);
                    return objAction;
                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteBill_Rent_Master", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteBill_Rent_Master", data);
                return objAction;
            }
        }

        [HttpGet("billId")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult GetLastBillMasterId(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? irFlag)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.GetLastBillMasterId(irFlag);
                    objAction = CreatedAtAction("GetLastBillMasterId", Res);
                    return objAction;
                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetLastBillMasterId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetLastBillMasterId", data);
                return objAction;
            }
        }

        [HttpGet("filterData")]
        [Produces("application/json", Type = typeof(Bill_Rent_MasterResp))]
        public IActionResult GetChallanMasterByFilter(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, DateTime? fromDate, DateTime? toDate, string? partyName)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                Bill_Rent_MasterBLL sample = new Bill_Rent_MasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.GetChallanMasterByFilter(fromDate, toDate, partyName);
                    objAction = CreatedAtAction("GetChallanMasterByFilter", Res);
                    return objAction;
                }

                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetChallanMasterByFilter", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetChallanMasterByFilter", data);
                return objAction;
            }
        }

    }
}
