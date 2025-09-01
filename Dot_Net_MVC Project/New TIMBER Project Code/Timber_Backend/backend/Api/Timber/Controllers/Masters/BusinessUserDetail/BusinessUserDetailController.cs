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
    public class BusinessUserDetailController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public BusinessUserDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpGet("allBusinessUserDetail")]
        [Produces("application/json", Type = typeof(BusinessUserDetailResp))]
        public IActionResult GetBusinessUserDetail(string? searchKey = null)
        {
            try
            {
                RTA.Masters.BusinessUserDetailBLL sample = new BusinessUserDetailBLL(DBConnStr);
                var Res = sample.GetBusinessUserDetail(searchKey);
                objAction = CreatedAtAction("GetBusinessUserDetail", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessUserDetail", data);
                return objAction;
            }
        }


        [HttpGet("BusinessUserDetail")]
        [Produces("application/json", Type = typeof(BusinessUserDetailResp))]
        public IActionResult GetBusinessUserDetailById(long bUserId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.BusinessUserDetailBLL sample = new BusinessUserDetailBLL(DBConnStr);
                var Res = sample.GetBusinessUserDetailById(bUserId);
                objAction = CreatedAtAction("GetBusinessUserDetailById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessUserDetailById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(BusinessUserDetailResp))]
        public IActionResult AddBusinessUserDetail([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] BusinessUserDetailReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessUserDetailBLL sample = new BusinessUserDetailBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.InsertBusinessUserDetail(samp);
                    objAction = CreatedAtAction("AddBusinessUserDetail", Res);
                    return objAction;
                }

                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddBusinessUserDetail", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddBusinessUserDetail", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(BusinessUserDetailResp))]
        public IActionResult UpdateBusinessUserDetail([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long bUserId, [FromBody] BusinessUserDetailReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessUserDetailBLL sample = new BusinessUserDetailBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateBusinessUserDetail(bUserId, samp);
                    objAction = CreatedAtAction("UpdateBusinessUserDetail", Res);
                    return objAction;
                }

                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateBusinessUserDetail", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateBusinessUserDetail", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(BusinessUserDetailResp))]
        public IActionResult DeleteBusinessUserDetail([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long bUserId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BusinessUserDetailBLL sample = new BusinessUserDetailBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteBusinessUserDetail(bUserId);
                    objAction = CreatedAtAction("DeleteBusinessUserDetail", Res);
                    return objAction;
                }

                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteBusinessUserDetail", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BusinessUserDetailResp data = new BusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteBusinessUserDetail", data);
                return objAction;
            }
        }

        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(BusinessContentResp))]
        public IActionResult UploadBusinessUserDetail(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Business_User_Image");
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }

                var randomKey = GenerateRandomString(10);
                var newFileName = randomKey + "_" + signature.FileName.Replace(" ", "_");

                var filePath = Path.Combine(uploadDirectory, newFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    signature.CopyTo(stream);
                }
                var base_url = $"/Business_User_Image/{newFileName}";

                objAction = CreatedAtAction("UploadBusinessUserDetail", new
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
                objAction = CreatedAtAction("UploadBusinessUserDetail", data);
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


        

    }
}
