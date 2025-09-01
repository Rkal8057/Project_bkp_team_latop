using DB.Login;
using DB.Login.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Rta.Services.EmailService;
using RTA.Masters;
using RTA.Masters.Models;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Rta.Controllers.Masters.ComplaintTrxMaster
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintTrxMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ComplaintTrxMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }

        [HttpPost("CreateComplaintTrx")]
        [Produces("application/json", Type = typeof(ModelComplaintTrxMasterResp))]
        public IActionResult CreateComplaintTrx([FromForm] ModelComplaintTrxMasterReq Data)
        {
            try
            {
                if (Data.attached_file != null)
                {
                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "complainted_reply_file");
                    if (!Directory.Exists(uploadDirectory))
                    {
                        Directory.CreateDirectory(uploadDirectory);
                    }

                    var randomKey = GenerateRandomString(10);
                    var newFileName = randomKey + "_" + Data.attached_file.FileName;

                    var filePath = Path.Combine(uploadDirectory, newFileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        Data.attached_file.CopyTo(stream);
                    }

                    var base_url = $"{Configurations["BaseUrl"]}/complainted_reply_file/{newFileName}";
                    using (var urlStream = new MemoryStream(Encoding.UTF8.GetBytes(base_url)))
                    {
                        var newFile = new FormFile(urlStream, 0, urlStream.Length, "formFile", base_url);
                        Data.attached_file = newFile;
                    }
                }
                ComplaintTrxMasterBLL rb = new ComplaintTrxMasterBLL(DBConnStr);
                var Res = rb.InsertComplaintTrxMaster(Data);
                objAction = CreatedAtAction("CreateComplaintTrx", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintTrxMasterResp data = new ModelComplaintTrxMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateComplaintTrx", data);
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



        /* [HttpPut("UpdateComplaintTrx")]
         [Produces("application/json", Type = typeof(ModelComplaintTrxMasterResp))]
         public IActionResult UpdateComplaintTrx([FromBody]
         ModelComplaintTrxMasterYUpdateReq Data, long unique_complaint_id)
         {
             try
             {

                 ComplaintTrxMasterBLL rb = new ComplaintTrxMasterBLL(DBConnStr);
                 var Res = rb.UpdateComplaintTrxMaster(unique_complaint_id, Data);

                 //List<string> recipientEmails = new List<string>
                 //{
                 //    "rohit@yopmail.com",
                 //    "rohit1@yopmail.com",
                 //};
                 //EmailService.SendMultipleEmail(recipientEmails, "tesing", "heelo");

                 objAction = CreatedAtAction("UpdateComplaintTrx", Res);
                 return objAction;
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                 ModelComplaintTrxMasterResp data = new ModelComplaintTrxMasterResp()
                 {
                     status = false,
                     Message = ex.Message
                 };
                 objAction = CreatedAtAction("UpdateComplaintTrx", data);
                 return objAction;
             }
         }*/


        [HttpGet("GetComplaintTrxByComplaintId")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult GetComplaintTrxByComplaintId([FromQuery] long ComplaintId)
        {
            try
            {
                if (ComplaintId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "ComplaintId is required", Data = false });
                }

                ComplaintTrxMasterBLL rb = new ComplaintTrxMasterBLL(DBConnStr);
                var Res = rb.GetComplaintTrxByID(ComplaintId);
                objAction = CreatedAtAction("GetComplaintTrxByComplaintId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintTrxMasterResp data = new ModelComplaintTrxMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetComplaintTrxByComplaintId", data);
                return objAction;
            }
        }
    }
}
