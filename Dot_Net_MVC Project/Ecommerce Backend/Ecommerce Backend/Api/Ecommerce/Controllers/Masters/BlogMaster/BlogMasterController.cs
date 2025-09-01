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
    public class BlogMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public BlogMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpGet("allblog")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult GetBlogMaster()
        {
            try
            {
                RTA.Masters.BlogMasterBLL sample = new BlogMasterBLL(DBConnStr);
                var Res = sample.GetBlogMaster();
                objAction = CreatedAtAction("GetBlogMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBlogMaster", data);
                return objAction;
            }
        }


        [HttpGet("blogDetail")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult GetBlogMasterById(long blogId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.BlogMasterBLL sample = new BlogMasterBLL(DBConnStr);
                var Res = sample.GetBlogMasterById(blogId);
                objAction = CreatedAtAction("GetBlogMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBlogMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult AddBlogMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] BlogMasterReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BlogMasterBLL sample = new BlogMasterBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertBlogMaster(samp);
                    objAction = CreatedAtAction("AddBlogMaster", Res);
                    return objAction;
                }

                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddBlogMaster", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddBlogMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult UpdateBlogMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long blogId, [FromBody] BlogMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BlogMasterBLL sample = new BlogMasterBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateBlogMaster(blogId, samp);
                    objAction = CreatedAtAction("UpdateBlogMaster", Res);
                    return objAction;
                }

                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateBlogMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateBlogMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult DeleteBlogMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long blogId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.BlogMasterBLL sample = new BlogMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteBlogMaster(blogId);
                    objAction = CreatedAtAction("DeleteBlogMaster", Res);
                    return objAction;
                }

                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteBlogMaster", data);
                return objAction;

               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteBlogMaster", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult UploadBlogMasterFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Blog_Image");
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
                var base_url = $"{Configurations["BaseUrl"]}/Blog_Image/{newFileName}";

                objAction = CreatedAtAction("UploadBlogMasterFile", new
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
                BlogMasterResp data = new BlogMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadBlogMasterFile", data);
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
