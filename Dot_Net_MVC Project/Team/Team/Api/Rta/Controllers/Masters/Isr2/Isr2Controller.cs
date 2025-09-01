using DB.Login;
using DB.Login.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RTA.Masters;
using RTA.Masters.Models;
using System.Text;

namespace Rta.Controllers.Masters.Isr2
{
    [Route("api/[controller]")]
    [ApiController]
    public class Isr2Controller : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private readonly IConfiguration _configuration;


        public Isr2Controller(IConfiguration config, IConfiguration configuration)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            _configuration = configuration;

            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("CreateIsr2")]
        [Produces("application/json", Type = typeof(ModalIsr2Resp))]
        public IActionResult CreateIsr2([FromForm] ModalIsr2Req Data)
        {
            try
            {
                // Add key-value pairs to the dictionary
                Dictionary<string, IFormFile> fileDictionary = new Dictionary<string, IFormFile>();

                fileDictionary["investor_signature1"] = Data.investor_signature1;
                fileDictionary["investor_signature2"] = Data.investor_signature2;
                fileDictionary["investor_signature3"] = Data.investor_signature3;
                fileDictionary["account_holder1_photo"] = Data.account_holder1_photo;
                fileDictionary["account_holder2_photo"] = Data.account_holder2_photo;
                fileDictionary["account_holder3_photo"] = Data.account_holder3_photo;


                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Isr2_image");
                if (!Directory.Exists(uploadDirectory))
                {
                    Directory.CreateDirectory(uploadDirectory);
                }

                foreach (var fileEntry in fileDictionary)
                {
                    string key = fileEntry.Key;
                    IFormFile file = fileEntry.Value;

                    if (file != null && file.Length > 0)
                    {
                        var randomKey = GenerateRandomString(10);
                        var newFileName = randomKey + "_" + file.FileName;

                        var filePath = Path.Combine(uploadDirectory, newFileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }

                        var base_url = $"{_configuration["BaseUrl"]}/Isr2_image/{newFileName}";
                        using (var urlStream = new MemoryStream(Encoding.UTF8.GetBytes(base_url)))
                        {
                            var newFile = new FormFile(urlStream, 0, urlStream.Length, "formFile", base_url);
                            switch (key)
                            {
                                case "investor_signature1":
                                    Data.investor_signature1 = newFile;
                                    break;
                                case "investor_signature2":
                                    Data.investor_signature2 = newFile;
                                    break;
                                case "investor_signature3":
                                    Data.investor_signature3 = newFile;
                                    break;
                                case "account_holder1_photo":
                                    Data.account_holder1_photo = newFile;
                                    break;
                                case "account_holder2_photo":
                                    Data.account_holder2_photo = newFile;
                                    break;
                                case "account_holder3_photo":
                                    Data.account_holder3_photo = newFile;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }

                Isr2BLL rb = new Isr2BLL(DBConnStr);
                var Res = rb.InsertIsr2(Data);
                objAction = CreatedAtAction("CreateIsr2", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModalIsr2Resp data = new ModalIsr2Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateIsr2", data);
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
