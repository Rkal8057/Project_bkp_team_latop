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
    public class PortfolioMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public PortfolioMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(PortfolioMasterResp))]
        public IActionResult CreatePortfolioMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] PortfolioMasterReq samp)
        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    PortfolioMasterBLL sample = new PortfolioMasterBLL(DBConnStr);
                    var Res = sample.InsertPortfolioMaster(samp);
                    objAction = CreatedAtAction("CreatePortfolioMaster", Res);
                    return objAction;
                }
             
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreatePortfolioMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreatePortfolioMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(PortfolioMasterResp))]
        public IActionResult UpdatePortfolioMaster([FromHeader] long Token_ID,
                                             [FromHeader] string Token_Data,
                                             [FromBody] PortfolioMasterReq samp,
                                             [FromQuery] long portfolioId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Use "DELETE" for this action
                {
                    PortfolioMasterBLL sample = new PortfolioMasterBLL(DBConnStr);
                    var Res = sample.UpdatePortfolioMaster(portfolioId, samp);
                    objAction = CreatedAtAction("UpdatePortfolioMaster", Res);
                    return objAction;
                }

                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdatePortfolioMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdatePortfolioMaster", data);
                return objAction;
            }
        }

        [HttpGet("allportfolio")]
        [Produces("application/json", Type = typeof(PortfolioMasterResp))]
        public IActionResult GetAllPortfolioMaster(
                                                    int pageNo = 1, int limit = 10, string? searchKey = null)
        {
            try
            {
                /*ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Use "DELETE" for this action
                {*/
                    PortfolioMasterBLL sample = new PortfolioMasterBLL(DBConnStr);
                    var Res = sample.GetAllPortfolioMaster(pageNo, limit, searchKey);
                    objAction = CreatedAtAction("GetAllPortfolioMaster", Res);
                    return objAction;
                /*}

                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllPortfolioMaster", data);
                return objAction;
*/            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllPortfolioMaster", data);
                return objAction;
            }
        }

        [HttpGet("portfoliobyid")]
        [Produces("application/json", Type = typeof(PortfolioMasterResp))]
        public IActionResult GetPortfolioMasterById([FromHeader] long Token_ID,
                                                     [FromHeader] string Token_Data,
                                                     [FromQuery] long portfolioId)
        {
            try
            {
                if (portfolioId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "portfolioId is required", Data = false });
                }

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Use "DELETE" for this action
                {
                    PortfolioMasterBLL sample = new PortfolioMasterBLL(DBConnStr);
                    var Res = sample.GetPortfolioMasterById(portfolioId);
                    objAction = CreatedAtAction("GetPortfolioMasterById", Res);
                    return objAction;
                }

                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetPortfolioMasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetPortfolioMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(PortfolioMasterResp))]
        public IActionResult DeletePortfolioMaster([FromHeader] long Token_ID,
                                                    [FromHeader] string Token_Data,
                                                    [FromQuery] long portfolioId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Use "DELETE" for this action
                {
                    PortfolioMasterBLL sample = new PortfolioMasterBLL(DBConnStr);
                    var Res = sample.DeletePortfolioMaster(portfolioId);
                    objAction = CreatedAtAction("DeletePortfolioMaster", Res);
                    return objAction;
                }

                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeletePortfolioMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeletePortfolioMaster", data);
                return objAction;
            }
        }

        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(PortfolioMasterResp))]
        public IActionResult UploadPortfolioMasterFile([FromHeader] long Token_ID,
                                                       [FromHeader] string Token_Data,
                                                       IFormFile? signature)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Use "DELETE" for this action
                {
                    if (signature == null)
                    {
                        return BadRequest(new { status = 404, message = "File is required", data = false });
                    }

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Portfolio_Image");
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
                    var base_url = $"/Portfolio_Image/{newFileName}";

                    objAction = CreatedAtAction("UploadPortfolioMasterFile", new
                    {
                        status = true,
                        Message = "File upload successfully",
                        Data = base_url
                    });
                    return objAction;
                }

                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadPortfolioMasterFile", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                PortfolioMasterResp data = new PortfolioMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadPortfolioMasterFile", data);
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
