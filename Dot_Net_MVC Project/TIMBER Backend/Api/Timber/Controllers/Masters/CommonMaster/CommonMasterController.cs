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
    public class CommonMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CommonMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("uploadfile")]
        [Produces("application/json")]
        public IActionResult UploadBlogMasterFile(IFormFile? signature)
        {
            try
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

                objAction = CreatedAtAction("UploadBlogMasterFile", new
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
                var data = new
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadBlogMasterFile", data);
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
