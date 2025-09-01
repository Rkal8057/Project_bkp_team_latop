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
using Microsoft.AspNetCore.WebUtilities;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessSectionController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public BusinessSectionController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpGet("allsection")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult GetBusinessSection(string? searchKey = null)
        {
            try
            {
                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);
                var Res = sample.GetBusinessSection(searchKey);
                objAction = CreatedAtAction("GetBusinessSection", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessSection", data);
                return objAction;
            }
        }


        [HttpGet("sectionDetail")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult GetBusinessSectionById(long sectionId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);
                var Res = sample.GetBusinessSectionById(sectionId);
                objAction = CreatedAtAction("GetBusinessSectionById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessSectionById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult AddBusinessSection([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] BusinessSectionReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.InsertBusinessSection(samp);
                    objAction = CreatedAtAction("AddBusinessSection", Res);
                    return objAction;
                }

                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddBusinessSection", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddBusinessSection", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult UpdateBusinessSection([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long sectionId, [FromBody] BusinessSectionReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateBusinessSection(sectionId, samp);
                    objAction = CreatedAtAction("UpdateBusinessSection", Res);
                    return objAction;
                }

                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateBusinessSection", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateBusinessSection", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult DeleteBusinessSection([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long sectionId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteBusinessSection(sectionId);
                    objAction = CreatedAtAction("DeleteBusinessSection", Res);
                    return objAction;
                }

                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteBusinessSection", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteBusinessSection", data);
                return objAction;
            }
        }


        [HttpDelete("disable")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult DisableBusinessSection([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long sectionId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DisableBusinessSection(sectionId);
                    objAction = CreatedAtAction("DeleteBusinessSection", Res);
                    return objAction;
                }

                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteBusinessSection", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteBusinessSection", data);
                return objAction;
            }
        }

        [HttpGet("allSectionWithContent")]
        [Produces("application/json", Type = typeof(BusinessSectionResp))]
        public IActionResult GetBusinessSectionWithContent(string flag)
        {
            try
            {

                RTA.Masters.BusinessSectionBLL sample = new BusinessSectionBLL(DBConnStr);
                var Res = sample.GetBusinessSectionWithContent(flag);
                objAction = CreatedAtAction("GetBusinessSectionWithContent", Res);
                return objAction;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessSectionResp data = new BusinessSectionResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessSectionWithContent", data);
                return objAction;
            }
        }


    }
}
