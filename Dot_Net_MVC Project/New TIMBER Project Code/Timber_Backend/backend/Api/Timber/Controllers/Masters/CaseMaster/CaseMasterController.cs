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
using DocumentFormat.OpenXml.Math;
using RTA.Common.Models;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CaseMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult CreateCaseMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] CaseMasterReq samp)
        {
            try
            {               
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var checkCaseNo = sample.CheckCaseNo(samp.Case_Case_No);
                    if (checkCaseNo.CaseMasterByID != null)
                    {
                        objAction = CreatedAtAction("CreateCaseMaster", checkCaseNo);
                        return objAction;
                    }

                    var Res = sample.InsertCaseMaster(samp);
                    objAction = CreatedAtAction("CreateCaseMaster", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateCaseMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateCaseMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult UpdateCaseMaster(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromBody] CaseMasterReq samp,
     [FromQuery] long id)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                    var Res = sample.UpdateCaseMaster(id, samp);
                    objAction = CreatedAtAction("UpdateCaseMaster", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateCaseMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateCaseMaster", data);
                return objAction;
            }
        }


        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult GetAllCaseMaster(
    [FromHeader] long Token_ID,
    [FromHeader] string Token_Data,
    int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                    var Res = sample.GetAllCaseMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetAllCaseMaster", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllCaseMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllCaseMaster", data);
                return objAction;
            }
        }




        [HttpGet("detailbyid")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult GetCaseMasterById(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromQuery] long id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "categoryId is required", Data = false });
                }

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                    var Res = sample.GetCaseMasterById(id);
                    objAction = CreatedAtAction("GetCaseMasterById", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetCaseMasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCaseMasterById", data);
                return objAction;
            }
        }



        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult DeleteCaseMaster(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromQuery] long id)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                    var Res = sample.DeleteCaseMaster(id);
                    objAction = CreatedAtAction("DeleteCaseMaster", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteCaseMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCaseMaster", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult UploadCaseMasterFile(
    [FromHeader] long Token_ID,
    [FromHeader] string Token_Data,
    IFormFile? signature)
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

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CaseMaster_Document");
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
                    var base_url = $"{Configurations["BaseUrl"]}/CaseMaster_Document/{newFileName}";

                    objAction = CreatedAtAction("UploadCaseMasterFile", new
                    {
                        status = true,
                        Message = "File upload successfully",
                        Data = base_url
                    });
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadCaseMasterFile", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadCaseMasterFile", data);
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



        [HttpGet("caseno")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult GetCaseMasterLastCaseNo(
      [FromHeader] long Token_ID,
      [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                    var Res = sample.GetCaseMasterLastCaseNo();
                    objAction = CreatedAtAction("GetCaseMasterLastCaseNo", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetCaseMasterLastCaseNo", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCaseMasterLastCaseNo", data);
                return objAction;
            }
        }


        [HttpGet("caseno/detail")]
        [Produces("application/json", Type = typeof(CaseMasterResp))]
        public IActionResult GetFinanceByCaseNo(
      [FromHeader] long Token_ID,
      [FromHeader] string Token_Data,
      [FromQuery] string? caseNo)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CaseMasterBLL sample = new CaseMasterBLL(DBConnStr);
                    var Res = sample.GetFinanceByCaseNo(caseNo);
                    objAction = CreatedAtAction("GetFinanceByCaseNo", Res);
                    return objAction;
                }

                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetFinanceByCaseNo", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CaseMasterResp data = new CaseMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetFinanceByCaseNo", data);
                return objAction;
            }
        }


    }
}
