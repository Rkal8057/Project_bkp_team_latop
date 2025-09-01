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
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Rta.Services.EmailService;
using MimeKit;
using RTA.Common.Models;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ItemMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult CreateItemMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] ItemMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);

                    var isCheckItemName = sample.ItemNameExistsInDatabase(samp);
                    if (isCheckItemName.ItemMasterDetailByID != null)
                    {
                        return CreatedAtAction("CreateItemMaster", isCheckItemName);
                    }


                    var Res = sample.InsertItemMaster(samp);
                    objAction = CreatedAtAction("CreateItemMaster", Res);
                    return objAction;
                }

                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateItemMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateItemMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult UpdateItemMaster(
             [FromBody] ItemMasterReq samp,
             [FromQuery] long itemId,
             [FromHeader] long Token_ID,
             [FromHeader] string Token_Data)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                    var Res = sample.UpdateItemMaster(itemId, samp);
                    objAction = CreatedAtAction("UpdateItemMaster", Res);
                    return objAction;
                }

                // If user does not have rights
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateItemMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateItemMaster", data);
                return objAction;
            }
        }

        [HttpGet("allitem")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult GetAllItemMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int pageNo = 1,
            int limit = 10,
            string? searchKey = null,
            long? partyId = null)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                    var Res = sample.GetAllItemMaster(pageNo, limit, searchKey, partyId);
                    objAction = CreatedAtAction("GetAllItemMaster", Res);
                    return objAction;
                }

                // If user does not have rights
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllItemMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllItemMaster", data);
                return objAction;
            }
        }

        [HttpGet("itemDetailById")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult GetItemMasterByItemId(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long itemId)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                    var Res = sample.GetItemMasterByItemId(itemId);
                    objAction = CreatedAtAction("GetItemMasterByItemId", Res);
                    return objAction;
                }

                // If user does not have rights
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetItemMasterByItemId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetItemMasterByItemId", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult CheckDeleteItemMasterIfExitInMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromQuery] long itemId,
            string Masterflag)
        {
            try
            {
                // Authenticate user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                // Check user rights
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);

                    System_RecordsBLL system = new System_RecordsBLL(DBConnStr);
                    var SystemData = system.GetSystem_RecordsById();
                    string otp = "";
                    if (SystemData.System_RecordsDataById != null && SystemData.System_RecordsDataById.otp_req_deletion_yn == "yes")
                    {
                        // Generate OTP
                        otp = GenerateOTP();
                        string email = SystemData.System_RecordsDataById.email_sender;
                        string subject = "Otp Verification";
                        string body = otp;
                        bool emailSent = EmailService.SendSingleEmail(email, subject, body);
                        if (!emailSent)
                        {
                            Console.WriteLine("Failed to send email.");
                        }
                    }

                    var Res = sample.CheckDeleteItemMasterIfExitInMaster(itemId, Masterflag);
                    var response = new
                    {
                        Result = Res,
                        OTP = otp
                    };

                    objAction = CreatedAtAction("CheckDeleteItemMasterIfExitInMaster", response);
                    return objAction;
                }

                // If user does not have rights
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CheckDeleteItemMasterIfExitInMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CheckDeleteItemMasterIfExitInMaster", data);
                return objAction;
            }
        }


        private string GenerateOTP()
        {
            Random random = new Random();
            int otp = (int)(random.NextDouble() * 1000000);
            return otp.ToString("D6"); // Ensure 6 digits
        }


        [HttpDelete("deleteAllItemRelatedData")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult DeleteItemMasterRelatedData(string Masterflag, long Id, long? otp = null)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.DeleteItemMaster(Masterflag, Id, otp);
                objAction = CreatedAtAction("DeleteItemMasterRelatedData", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteItemMasterRelatedData", data);
                return objAction;
            }
        }
    }
}
