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


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneralRequestedController : Controller
    {
        
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public GeneralRequestedController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult CreateGeneralRequested( [FromBody] GeneralRequestedReq samp)
        {
            try
            {
                  
                GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                var Res = sample.InsertGeneralRequested(samp);
                objAction = CreatedAtAction("CreateGeneralRequested", Res);
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
        public IActionResult DeleteGeneralRequested([FromQuery] long id)
        {
            try
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
        public IActionResult GetAllGeneralRequested([FromQuery] long id , int page = 1, int limit = 20, string? filter = null)
        {
            try
            {

                if (id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }

                GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                var Res = sample.GetGeneralRequested(id, page, limit, filter);
                objAction = CreatedAtAction("GetAllGeneralRequested", Res);
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
        public IActionResult UpdateGeneralRequested(int id, [FromBody] GeneralRequestedReq samp )
        {
            try
            {
                GeneralRequestedBLL sample = new GeneralRequestedBLL(DBConnStr);
                var Res = sample.UpdateGeneralRequested(id, samp);
                objAction = CreatedAtAction("UpdateGeneralRequested", Res);
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


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult UploadGeneralRequestedFile(IFormFile? signature)
        {
            try
            {

                if (signature == null )
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
                var base_url = $"{Configurations["BaseUrl"]}/GeneralRequested_image/{newFileName}";

                objAction = CreatedAtAction("UploadGeneralRequestedFile", new
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
                GeneralRequestedResp data = new GeneralRequestedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadGeneralRequestedFile", data);
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

        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(GeneralRequestedResp))]
        public IActionResult GetGeneralRequestedById([FromQuery] long id)
        {
            try
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
    }
}
