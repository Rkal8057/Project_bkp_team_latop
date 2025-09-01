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

namespace Rta.Controllers.Masters.CompaintMaster
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaintMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CompaintMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }

        [HttpPost("CreateComplaint")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult CreateComplaint([FromForm] ModelComplaintMasterReq Data)
        {
            try
            {

                if (Data.attached_file != null)
                {
                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "complainted_file");
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

                    var base_url = $"{Configurations["BaseUrl"]}/complainted_file/{newFileName}";
                    using (var urlStream = new MemoryStream(Encoding.UTF8.GetBytes(base_url)))
                    {
                        var newFile = new FormFile(urlStream, 0, urlStream.Length, "formFile", base_url);
                        Data.attached_file = newFile;
                    }
                }

                ComplaintMasterBLL rb = new ComplaintMasterBLL(DBConnStr);
                var Res = rb.InsertComplaintMaster(Data);

                //List<string> recipientEmails = new List<string>
                //{
                //    "rohit@yopmail.com",
                //    "rohit1@yopmail.com",
                //};
                //EmailService.SendMultipleEmail(recipientEmails, "tesing", "heelo");

                objAction = CreatedAtAction("CreateComplaint", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintMasterResp data = new ModelComplaintMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateComplaint", data);
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



        [HttpPut("UpdateComplaint")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult UpdateComplaint(long complain_id,[FromBody] ModelComplaintMasterUpdateReq Data)
        {
            try
            {
                ComplaintMasterBLL rb = new ComplaintMasterBLL(DBConnStr);
                var Res = rb.UpdateComplaint(Data, complain_id);
                objAction = CreatedAtAction("UpdateComplaint", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintMasterResp data = new ModelComplaintMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateComplaint", data);
                return objAction;
            }
        }














        [HttpGet("GetComplaintByUserId")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult GetComplaintByUserId([FromQuery] int Id )
        {
            try
            {
                if (Id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }

                ComplaintMasterBLL rb = new ComplaintMasterBLL(DBConnStr);
                var Res = rb.GetComplaintByID(Id);
                objAction = CreatedAtAction("GetComplaintByUserId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintMasterResp data = new ModelComplaintMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetComplaintByUserId", data);
                return objAction;
            }
        }


        [HttpGet("GetComplaintByUrnId")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult GetComplaintByUrnId([FromQuery] long urnId)
        {
            try
            {
                if (urnId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }

                ComplaintMasterBLL rb = new ComplaintMasterBLL(DBConnStr);
                var Res = rb.GetComplaintByUrn(urnId);
                objAction = CreatedAtAction("GetComplaintByUrnId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintMasterResp data = new ModelComplaintMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetComplaintByUrnId", data);
                return objAction;
            }
        }


        [HttpGet("GetAllComplaintByUser")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult GetAllComplaintByUser([FromQuery] long Id, int page =1, int limit=20, string? filter = null)
        {
            try
            {
                if (Id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                }

                ComplaintMasterBLL rb = new ComplaintMasterBLL(DBConnStr);
                var Res = rb.GetAllComplaintUser(Id, page, limit, filter);
                objAction = CreatedAtAction("GetAllComplaintByUser", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintMasterResp data = new ModelComplaintMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllComplaintByUser", data);
                return objAction;
            }
        }



        [HttpDelete("DeleteComplaintByUserId")]
        [Produces("application/json", Type = typeof(ModelComplaintMasterResp))]
        public IActionResult DeleteComplaintByUserId([FromQuery] int id)
        {
            try
            {
                if ( id <= 0)
                {
                    return BadRequest(new { Status = false, Message = "Userid is required", Data = false });
                }

                ComplaintMasterBLL rb = new ComplaintMasterBLL(DBConnStr);
                var Res = rb.DeleteComplaintByID(id);
                objAction = CreatedAtAction("DeleteComplaintByUserId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelComplaintMasterResp data = new ModelComplaintMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteComplaintByUserId", data);
                return objAction;
            }
        }

    }
}
