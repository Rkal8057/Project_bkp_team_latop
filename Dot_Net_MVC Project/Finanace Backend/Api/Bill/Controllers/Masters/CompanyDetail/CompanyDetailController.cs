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

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyDetailController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CompanyDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult CreateCompanyDetail([FromBody] CompanyDetailReq samp)
        {
            try
            {

                CompanyDetailBLL sample = new CompanyDetailBLL(DBConnStr);
                var Res = sample.InsertCompanyDetail(samp);
                objAction = CreatedAtAction("CreateCompanyDetail", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateCompanyDetail", data);
                return objAction;
            }
        }

        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult GetCompanyDetail()
        {
            try
            {
            
                CompanyDetailBLL sample = new CompanyDetailBLL(DBConnStr);
                var Res = sample.GetAllCompanyDetail();
                objAction = CreatedAtAction("GetCompanyDetail", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCompanyDetail", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult GetCompanyDetailByID(long id)
        {
            try
            {
                RTA.Masters.CompanyDetailBLL sample = new CompanyDetailBLL(DBConnStr);
                var Res = sample.GetCompanyDetailById(id);
                objAction = CreatedAtAction("GetCompanyDetailByID", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCompanyDetailByID", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult UpdateCompanyDetail(long id, [FromBody] CompanyDetailReq samp )
        {
            try
            {

                RTA.Masters.CompanyDetailBLL sample = new CompanyDetailBLL(DBConnStr);
                var Res = sample.UpdateCompanyDetail(id, samp);
                objAction = CreatedAtAction("UpdateCompanyDetail", Res);
                return objAction;
             

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateCompanyDetail", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult DeleteCompanyDetail(long id )
        {
            try
            {
            
                RTA.Masters.CompanyDetailBLL sample = new CompanyDetailBLL(DBConnStr);
                var Res = sample.DeleteCompanyDetail(id);
                objAction = CreatedAtAction("DeleteCompanyDetail", Res);
                return objAction;
             

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCompanyDetail", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult UploadCompanyDetailFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CompanyDetail_Document");
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
                var base_url = $"{Configurations["BaseUrl"]}/CompanyDetail_Document/{newFileName}";

                objAction = CreatedAtAction("UploadCompanyDetailFile", new
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
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadCompanyDetailFile", data);
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

        [HttpGet("lastCompany")]
        [Produces("application/json", Type = typeof(CompanyDetailResp))]
        public IActionResult getLastCompanyDetail()
        {
            try
            {
                RTA.Masters.CompanyDetailBLL sample = new CompanyDetailBLL(DBConnStr);
                var Res = sample.getLastCompanyDetail();
                objAction = CreatedAtAction("getLastCompanyDetail", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CompanyDetailResp data = new CompanyDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("getLastCompanyDetail", data);
                return objAction;
            }
        }

    }
}





