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
    public class ReturnMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public ReturnMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }



        [HttpGet("allReturnOrder")]
        [Produces("application/json", Type = typeof(ReturnMasterResp))]
        public IActionResult GetReturnMaster()
        {
            try
            {
                RTA.Masters.ReturnMasterBLL sample = new ReturnMasterBLL(DBConnStr);
                var Res = sample.GetReturnMaster();
                objAction = CreatedAtAction("GetReturnMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReturnMasterResp data = new ReturnMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetReturnMaster", data);
                return objAction;
            }
        }



        [HttpGet("returnOrderByOrderItemId")]
        [Produces("application/json", Type = typeof(ReturnMasterResp))]
        public IActionResult GetReturnMasterByOrderItemId(long orderItemId)
        {
            try
            {
                RTA.Masters.ReturnMasterBLL sample = new ReturnMasterBLL(DBConnStr);
                var Res = sample.GetReturnMasterByOrderItemId(orderItemId);
                objAction = CreatedAtAction("GetReturnMasterByOrderItemId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReturnMasterResp data = new ReturnMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetReturnMasterByOrderItemId", data);
                return objAction;
            }
        }


        [HttpPut("updateOrderReturnStatus")]
        [Produces("application/json", Type = typeof(ReturnMasterResp))]
        public IActionResult UpdateOrderTrackingStatus(
               [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long orderItemId, [FromBody] ReturnMasterReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ReturnMasterBLL sample = new ReturnMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateOrderReturnTrackingStatus(orderItemId, samp);
                    objAction = CreatedAtAction("UpdateOrderTrackingStatus", Res);
                    return objAction;

                }

                ReturnMasterResp data = new ReturnMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateOrderTrackingStatus", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReturnMasterResp data = new ReturnMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateOrderTrackingStatus", data);
                return objAction;
            }
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ReturnMasterResp))]
        public IActionResult AddReturnMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,[FromBody] ReturnMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ReturnMasterBLL sample = new ReturnMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertReturnMaster(samp);
                    objAction = CreatedAtAction("AddReturnMaster", Res);
                    return objAction;
                }

                ReturnMasterResp data = new ReturnMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddReturnMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReturnMasterResp data = new ReturnMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddReturnMaster", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult UploadReturnMasterFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Return_Courier_recipt_Image");
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
                var base_url = $"{Configurations["BaseUrl"]}/Return_Courier_recipt_Image/{newFileName}";

                objAction = CreatedAtAction("UploadReturnMasterFile", new
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
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadReturnMasterFile", data);
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
