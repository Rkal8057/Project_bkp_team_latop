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
using System.Security.Cryptography.Xml;

namespace Rta.Controllers.Masters.Isr_1
{
    [Route("api/[controller]")]
    [ApiController]
    public class Isr1Controller : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public Isr1Controller(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("CreateIsr1")]
        [Produces("application/json", Type = typeof(ModelIsr1Resp))]
        public IActionResult CreateIsr1([FromBody] ModelIsr1Req Data)
        {
            try
            {
                isrBLL rb = new isrBLL(DBConnStr);
                var Res = rb.InsertIsr(Data);
                objAction = CreatedAtAction("CreateIsr1", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelIsr1Resp data = new ModelIsr1Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateIsr1", data);
                return objAction;
            }
        }

        [HttpGet("GetIsr1")]
        [Produces("application/json", Type = typeof(ModelIsr1Resp))]
        public IActionResult GetIsr1()
        {
            try
            {
               
                isrBLL rb = new isrBLL(DBConnStr);
                var Res = rb.GetIsr1Data();
                objAction = CreatedAtAction("GetIsr1", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelIsr1Resp data = new ModelIsr1Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetIsr1", data);
                return objAction;
            }
        }


        [HttpGet("GetIsr1ById")]
        [Produces("application/json", Type = typeof(ModelIsr1Resp))]
        public IActionResult GetIsr1ById([FromQuery] int id)
        {
            try
            {

                var data  =  new { status = 404, message = "Id is Required", data = false };
                if (id <=0 )
                {
                    return BadRequest(new { status = 404, message = "Id is Required", data = false });
                }
                isrBLL rb = new isrBLL(DBConnStr);
                var Res = rb.GetIsr1DataByID(id);
                objAction = CreatedAtAction("GetIsr1ById", Res);
                return objAction;

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                ModelIsr1Resp data = new ModelIsr1Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetIsr1ById", data);
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

        [HttpPost("UploadFile")]
        [Produces("application/json", Type = typeof(ModelIsr1Resp))]

        public IActionResult UploadIsr1File( IFormFile? signature)
        {
            try
            {
                if (signature == null || signature.Length == 0)
                {
                    return BadRequest(new { status = 404, message = "Id is Required", data = false });
                }

                string fileExtension = Path.GetExtension(signature.FileName)?.ToLower();
                if (fileExtension != ".jpg" && fileExtension != ".png" && fileExtension != ".jpeg")
                {
                    return BadRequest(new { status = 400, message = "Invalid file format. Only JPG and PNG and JPEG files are allowed.", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Isr1_image");
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
                var base_url = $"{Configurations["BaseUrl"]}/Isr1_image/{newFileName}";


                objAction = CreatedAtAction("UploadIsr1File",  new {
                    status = true,
                    Message = "File upload successfully",
                    Data = base_url
                });
                return objAction;

            }
            catch (Exception ex)
            {
                ModelIsr1Resp data = new ModelIsr1Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadIsr1File", data);
                return objAction;

            }
        }



    }

}
