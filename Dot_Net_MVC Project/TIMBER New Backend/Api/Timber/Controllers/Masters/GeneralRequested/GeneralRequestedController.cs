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
using DocumentFormat.OpenXml.Spreadsheet;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralRequestedController : Controller
    {
        
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public GeneralRequestedController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult CreateGeneralRequested([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] GeneralRequestedReq samp)
        {
            try
            {
                  
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.InsertGeneralRequested(samp);
                    objAction = CreatedAtAction("CreateGeneralRequested", Res);
                    return objAction;

                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateGeneralRequested", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateGeneralRequested", data);
                return objAction;
            }
        }



        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult DeleteGeneralRequested([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] long id)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (id <= 0)
                    {
                        return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                    }

                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.DeleteGeneralRequested(id);
                    objAction = CreatedAtAction("DeleteGeneralRequested", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteGeneralRequested", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteGeneralRequested", data);
                return objAction;
            }
        }

        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult GetAllGeneralRequested([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] long? id, int page = 1, int limit = 20, string? filter = null, string? searchKey = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.GetGeneralRequested(id, page, limit, filter, searchKey, startDate, endDate);
                    objAction = CreatedAtAction("GetAllGeneralRequested", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllGeneralRequested", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllGeneralRequested", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult UpdateGeneralRequested([FromHeader] long Token_ID, [FromHeader] string Token_Data, int id, [FromBody] GeneralRequestedReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.UpdateGeneralRequested(id, samp);
                    objAction = CreatedAtAction("UpdateGeneralRequested", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateGeneralRequested", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateGeneralRequested", data);
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



        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult UploadGeneralRequestedFile([FromHeader] long Token_ID, [FromHeader] string Token_Data, IFormFile? signature)
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

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "GeneralRequested_image");
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
                    var base_url = $"/GeneralRequested_image/{newFileName}";

                    objAction = CreatedAtAction("UploadGeneralRequestedFile", new
                    {
                        status = true,
                        Message = "File upload successfully",
                        Data = base_url
                    });
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadGeneralRequestedFile", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadGeneralRequestedFile", data);
                return objAction;
            }
        }

        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult GetGeneralRequestedById([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] long id)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (id <= 0)
                    {
                        return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                    }

                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.GetGeneralRequestedById(id);
                    objAction = CreatedAtAction("GetGeneralRequestedById", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetGeneralRequestedById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetGeneralRequestedById", data);
                return objAction;
            }
        }

        [HttpPut("status")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult UpdateGeneralRequestedStatus([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] long id, string status)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (id <= 0)
                    {
                        return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                    }

                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.UpdateGeneralRequestedStatus(id, status);
                    objAction = CreatedAtAction("UpdateGeneralRequestedStatus", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateGeneralRequestedStatus", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateGeneralRequestedStatus", data);
                return objAction;
            }
        }

        [HttpGet("generalRequestedLastId")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult GetLastGeneralRequestedMasterId([FromHeader] long Token_ID, [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.GetLastGeneralRequestedMasterMasterId();
                    objAction = CreatedAtAction("GetLastGeneralRequestedMasterId", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetLastGeneralRequestedMasterId", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetLastGeneralRequestedMasterId", data);
                return objAction;
            }
        }

        // ===============================  GENERAL REQUEST COMMUNICATION API  =================
        [HttpPost("createCommunication")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult CreateGeneralRequestCommunicationMaster([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromBody] GeneralRequestCommunicationDetailReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.CreateGeneralRequestCommunicationMaster(samp);
                    objAction = CreatedAtAction("CreateGeneralRequested", Res);
                    return objAction;
                }

                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateGeneralRequested", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateGeneralRequested", data);
                return objAction;
            }
        }

        [HttpGet("getCommunication")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult GetGeneralRequestCommunicationMaster([FromHeader] long Token_ID, [FromHeader] string Token_Data, long generalReqId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (generalReqId <= 0)
                    {
                        throw new Exception("General Requested id is required");
                    }

                    GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                    var Res = sample.GetGeneralRequestCommunicationMaster(generalReqId);
                    objAction = CreatedAtAction("GetGeneralRequestCommunicationMaster", Res);
                    return objAction;
                }

                // Return error message if user lacks rights
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetGeneralRequestCommunicationMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetGeneralRequestCommunicationMaster", data);
                return objAction;
            }
        }


    }
}
