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
    public class ContactMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public ContactMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }

        [HttpGet("allcontact")]
        [Produces("application/json", Type = typeof(ContactMasterResp))]
        public IActionResult GetContactMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.ContactMasterBLL sample = new ContactMasterBLL(DBConnStr);
                    var Res = sample.GetContactMaster();
                    objAction = CreatedAtAction("GetContactMaster", Res);
                    return objAction;
                }

                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetContactMasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetContactMaster", data);
                return objAction;
            }
        }


        [HttpGet("contactDetail")]
        [Produces("application/json", Type = typeof(ContactMasterResp))]
        public IActionResult GetContactMasterById(long contactId , [FromHeader] long Token_ID,
            [FromHeader] string Token_Data )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.ContactMasterBLL sample = new ContactMasterBLL(DBConnStr);
                    var Res = sample.GetContactMasterById(contactId);
                    objAction = CreatedAtAction("GetContactMasterById", Res);
                    return objAction;
                }

                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetContactMasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetContactMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ContactMasterResp))]
        public IActionResult AddContactMaster([FromBody] ContactMasterReq samp
            )
        {
            try
            {

                    RTA.Masters.ContactMasterBLL sample = new ContactMasterBLL(DBConnStr);
                    var Res = sample.InsertContactMaster(samp);
                    objAction = CreatedAtAction("AddContactMaster", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddContactMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ContactMasterResp))]
        public IActionResult UpdateContactMaster(long contactId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data , ContactMasterReq samp)
        {
            try
            {
                
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                User_Detail user = modelAuth.User;

                RTA.Masters.ContactMasterBLL sample = new ContactMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                   
                    var Res = sample.UpdateContactMaster(contactId, samp, user);
                    objAction = CreatedAtAction("UpdateContactMaster", Res);
                    return objAction;
                }

                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateContactMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateContactMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ContactMasterResp))]
        public IActionResult DeleteContactMaster(long contactId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ContactMasterBLL sample = new ContactMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {

                    var Res = sample.DeleteContactMaster(contactId);
                    objAction = CreatedAtAction("DeleteContactMaster", Res);
                    return objAction;
                }

                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteContactMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ContactMasterResp data = new ContactMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteContactMaster", data);
                return objAction;
            }
        }
    }
}
