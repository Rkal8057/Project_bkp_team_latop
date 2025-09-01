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
    public class BusinessContentController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public BusinessContentController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpGet("allcontent")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult GetBusinessContent(string? business_section_name = null)
        {
            try
            {
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);
                var Res = sample.GetBusinessContent(business_section_name);
                objAction = CreatedAtAction("GetBusinessContent", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessContent", data);
                return objAction;
            }
        }


        [HttpGet("contentDetail")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult GetBusinessContentById(long contentId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);
                var Res = sample.GetBusinessContentById(contentId);
                objAction = CreatedAtAction("GetBusinessContentById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessContentById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult AddBusinessContent([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] BusinessContentReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.InsertBusinessContent(samp);
                    objAction = CreatedAtAction("AddBusinessContent", Res);
                    return objAction;
                }

                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddBusinessContent", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddBusinessContent", data);
                return objAction;
            }
        }


        

        [HttpPost("createMultiple")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult UpsertMultipleBusinessContent([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] List<BusinessContentReq> samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpsertMultipleBusinessContent(samp);
                    objAction = CreatedAtAction("UpsertMultipleBusinessContent", Res);
                    return objAction;
                }

                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpsertMultipleBusinessContent", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpsertMultipleBusinessContent", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult UpdateBusinessContent([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long contentId, [FromBody] BusinessContentReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateBusinessContent(contentId, samp);
                    objAction = CreatedAtAction("UpdateBusinessContent", Res);
                    return objAction;
                }

                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateBusinessContent", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateBusinessContent", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult DeleteBusinessContent([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long contentId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteBusinessContent(contentId);
                    objAction = CreatedAtAction("DeleteBusinessContent", Res);
                    return objAction;
                }

                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteBusinessContent", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteBusinessContent", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult UploadBusinessContentFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Business_Content_Image");
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }

                var randomKey = GenerateRandomString(10);
                var newFileName = randomKey + "_" + signature.FileName;

                var filePath = Path.Combine(uploadDirectory, newFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    signature.CopyTo(stream);
                }
                var base_url = $"/Business_Content_Image/{newFileName}";

                objAction = CreatedAtAction("UploadBusinessContentFile", new
                {
                    status = true,
                    Message = "File upload successfully",
                    Data = base_url
                });
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadBusinessContentFile", data);
                return objAction;
            }


        }

        string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        [HttpDelete("disable")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult DisableBusinessContent([FromHeader] long Token_ID,
           [FromHeader] string Token_Data, long contentId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessContentBLL sample = new BusinessContentBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DisableBusinessContent(contentId);
                    objAction = CreatedAtAction("DisableBusinessContent", Res);
                    return objAction;
                }

                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DisableBusinessContent", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessContentResp data = new BusinessContentResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DisableBusinessContent", data);
                return objAction;
            }
        }


    }
}
