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
    public class SystemMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public SystemMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpGet("allcompany")]
        [Produces("application/json", Type = typeof(SystemMasterResp))]
        public IActionResult GetSystemMaster(string? searchKey = null)
        {
            try
            {
                RTA.Masters.SystemMasterBLL sample = new SystemMasterBLL(DBConnStr);
                var Res = sample.GetSystemMaster(searchKey);
                objAction = CreatedAtAction("GetSystemMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSystemMaster", data);
                return objAction;
            }
        }


        [HttpGet("companyDetail")]
        [Produces("application/json", Type = typeof(SystemMasterResp))]
        public IActionResult GetSystemMasterById()
        {
            try
            {
                RTA.Masters.SystemMasterBLL sample = new SystemMasterBLL(DBConnStr);
                var Res = sample.GetSystemMasterById();
                objAction = CreatedAtAction("GetSystemMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSystemMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SystemMasterResp))]
        public IActionResult AddSystemMaster([FromBody] SystemMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SystemMasterBLL sample = new SystemMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertSystemMaster(samp);
                    objAction = CreatedAtAction("AddSystemMaster", Res);
                    return objAction;


                }
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSystemMaster", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSystemMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SystemMasterResp))]
        public IActionResult UpdateSystemMaster(long companyId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] SystemMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SystemMasterBLL sample = new SystemMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.UpdateSystemMaster(companyId, samp);
                    objAction = CreatedAtAction("UpdateSystemMaster", Res);
                    return objAction;
                }
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateSystemMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSystemMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SystemMasterResp))]
        public IActionResult DeleteSystemMaster(long companyId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SystemMasterBLL sample = new SystemMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteSystemMaster(companyId);
                    objAction = CreatedAtAction("DeleteSystemMaster", Res);
                    return objAction;
                }
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteSystemMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSystemMaster", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(SystemMasterResp))]
        public IActionResult UploadSystemMasterFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Company_Image");
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
                var base_url = $"{Configurations["BaseUrl"]}/Company_Image/{newFileName}";

                objAction = CreatedAtAction("UploadSystemMasterFile", new
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
                SystemMasterResp data = new SystemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadSystemMasterFile", data);
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
