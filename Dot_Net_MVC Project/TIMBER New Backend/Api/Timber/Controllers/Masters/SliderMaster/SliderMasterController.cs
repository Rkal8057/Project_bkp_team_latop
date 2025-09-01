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
    public class SliderMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public SliderMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }

        [HttpGet("allslider")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult GetSliderMaster()
        {
            try
            {
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                var Res = sample.GetSliderMaster();
                objAction = CreatedAtAction("GetSliderMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSliderMaster", data);
                return objAction;
            }
        }


        [HttpGet("sliderDetail")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult GetSliderMasterById(long sliderId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                var Res = sample.GetSliderMasterById(sliderId);
                objAction = CreatedAtAction("GetSliderMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSliderMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult AddSliderMaster([FromBody] SliderMasterReq samp
             , [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertSliderMaster(samp);
                    objAction = CreatedAtAction("AddSliderMaster", Res);
                    return objAction;

                }

                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSliderMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSliderMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult UpdateSliderMaster(long sliderId, [FromBody] SliderMasterReq samp
             , [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateSliderMaster(sliderId, samp);
                    objAction = CreatedAtAction("UpdateSliderMaster", Res);
                    return objAction;
                }

                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSliderMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSliderMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult DeleteSliderMaster(long sliderId,  [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                




                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SliderMasterBLL sample = new SliderMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteSliderMaster(sliderId);
                    objAction = CreatedAtAction("DeleteSliderMaster", Res);
                    return objAction;
                }

                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteSliderMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSliderMaster", data);
                return objAction;
            }
        }



        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(BlogMasterResp))]
        public IActionResult UploadSliderMasterFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Slider_Image");
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
                var base_url = $"/Slider_Image/{newFileName}";

                objAction = CreatedAtAction("UploadSliderMasterFile", new
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
                objAction = CreatedAtAction("UploadSliderMasterFile", data);
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
