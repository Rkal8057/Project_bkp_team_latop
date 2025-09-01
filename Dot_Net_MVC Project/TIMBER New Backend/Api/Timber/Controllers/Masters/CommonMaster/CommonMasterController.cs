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
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using DocumentFormat.OpenXml.InkML;
using System.Text;
using RTA.Common.Models;

namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CommonMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("uploadfile")]
        [Produces("application/json")]
        public IActionResult UploadImageFile([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, IFormFile? signature
          )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (signature == null)
                    {
                        return BadRequest(new { status = 404, message = "File is required", data = false });
                    }

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Common_Image");
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
                    var base_url = $"/Common_Image/{newFileName}";

                    objAction = CreatedAtAction("UploadImageFile", new
                    {
                        status = true,
                        Message = "File upload successfully",
                        Data = base_url
                    });
                    return objAction;

                }

                var data = new 
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadImageFile", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                var data = new
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadImageFile", data);
                return objAction;
            }
        }



        [HttpPost("uploadExcelfile")]
        [Produces("application/json")]
        public IActionResult UploadExcelFile(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, IFormFile? file, string? flagName)
        {
            try
            {
                // Check user authentication and form rights using the middleware
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (file == null || file.Length == 0)
                    {
                        return BadRequest(new { status = false, Message = "Invalid file" });
                    }

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Common_Csv");
                    if (!Directory.Exists(uploadDirectory))
                    {
                        Directory.CreateDirectory(uploadDirectory);
                    }

                    var randomKey = GenerateRandomString(10);
                    var newFileName = randomKey + "_" + file.FileName;
                    var filePath = Path.Combine(uploadDirectory, newFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    // Read the content of the Excel file
                    // string csvData = System.IO.File.ReadAllText(filePath);

                    CommonMasterBLL sample = new CommonMasterBLL(DBConnStr);
                    using (var reader = new StreamReader(filePath, Encoding.UTF8))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true,
                    }))
                    {
                        var records = csv.GetRecords<dynamic>().ToList();
                        var Res = sample.InsertCsvFileDataCommonMaster(records, flagName);
                        objAction = CreatedAtAction("UploadExcelFile", Res);
                    }

                    return objAction;
                }

                // Return unauthorized access message if user rights are not verified
                var data = new
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadExcelFile", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                var data = new
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadExcelFile", data);
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


        [HttpDelete("alldelete")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult AllDeleteDataCommonMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? flagName)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CommonMasterBLL sample = new CommonMasterBLL(DBConnStr);
                    var Res = sample.AllDeleteDataCommonMaster(flagName);
                    objAction = CreatedAtAction("AllDeleteDataCommonMaster", Res);
                    return objAction;
                }

                var data = new
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AllDeleteDataCommonMaster", data);
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
                objAction = CreatedAtAction("AllDeleteDataCommonMaster", data);
                return objAction;
            }
        }

        [HttpGet("allBalanceSheetData")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult GetAllBalanceSheetData([FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CommonMasterBLL sample = new CommonMasterBLL(DBConnStr);
                    var Res = sample.GetAllBalanceSheetData();
                    objAction = CreatedAtAction("GetAllBalanceSheetData", Res);
                    return objAction;
                }

                var data = new
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllBalanceSheetData", data);
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
                objAction = CreatedAtAction("GetAllBalanceSheetData", data);
                return objAction;
            }
        }
    }
}
