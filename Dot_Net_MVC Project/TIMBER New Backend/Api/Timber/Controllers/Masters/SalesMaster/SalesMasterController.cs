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
using Microsoft.AspNetCore.Mvc.RazorPages;
using RTA.Common.Models;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public SalesMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        //DELETE ALL RECORDS
        [HttpGet("allsale")]
        [Produces("application/json", Type = typeof(SalesMasterResp))]
        public IActionResult GetSalesMasterRecords(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, 
            int pageNo=1, int limit=10, string? searchKey=null)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    SalesMasterDLL sample = new SalesMasterDLL(DBConnStr);
                    var Res = sample.GetSalesMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetSalesMasterRecords", Res);
                    return objAction;
                }

                SalesMasterResp data = new SalesMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetSalesMasterRecords", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesMasterResp data = new SalesMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSalesMasterRecords", data);
                return objAction;
            }
        }


        [HttpGet("getdetailbyid")]
        [Produces("application/json", Type = typeof(SalesMasterResp))]
        public IActionResult GetSalesMasterByID(
    [FromHeader] long Token_ID,
    [FromHeader] string Token_Data,
    int id)
        {
            try
            {
                // Authenticate and authorize the request
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (!commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    return Unauthorized(new SalesMasterResp()
                    {
                        status = false,
                        Message = modelAuth.message
                    });
                }

                SalesMasterDLL sample = new SalesMasterDLL(DBConnStr);
                var Res = sample.GetSalesMasterByID(id);
                objAction = CreatedAtAction("GetSalesMasterByID", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesMasterResp data = new SalesMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSalesMasterByID", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SalesMasterResp))]
        public IActionResult CreateSalesMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] SalesMasterReq samp)
        {
            try
            {
                // Authenticate and authorize the request
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (!commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    return Unauthorized(new SalesMasterResp()
                    {
                        status = false,
                        Message = modelAuth.message
                    });
                }

                SalesMasterDLL sample = new SalesMasterDLL(DBConnStr);
                var Res = sample.InsertSalesMaster(samp);
                objAction = CreatedAtAction("CreateSalesMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesMasterResp data = new SalesMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateSalesMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SalesMasterResp))]
        public IActionResult UpdateSalesMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int saleId,
            [FromBody] SalesMasterReq samp)
        {
            try
            {
                if (saleId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "saleId is required", Data = false });
                }

                // Authenticate and authorize the request
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (!commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    return Unauthorized(new SalesMasterResp()
                    {
                        status = false,
                        Message = modelAuth.message
                    });
                }

                SalesMasterDLL sample = new SalesMasterDLL(DBConnStr);
                var Res = sample.UpdateSalesMaster(saleId, samp);
                objAction = CreatedAtAction("UpdateSalesMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesMasterResp data = new SalesMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSalesMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SalesMasterResp))]
        public IActionResult DeleteSalesMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int id)
        {
            try
            {
                // Authenticate and authorize the request
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (!commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    return Unauthorized(new SalesMasterResp()
                    {
                        status = false,
                        Message = modelAuth.message
                    });
                }

                SalesMasterDLL sample = new SalesMasterDLL(DBConnStr);
                var Res = sample.DeleteSalesMaster(id);
                objAction = CreatedAtAction("DeleteSalesMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SalesMasterResp data = new SalesMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSalesMaster", data);
                return objAction;
            }
        }

    }
}
