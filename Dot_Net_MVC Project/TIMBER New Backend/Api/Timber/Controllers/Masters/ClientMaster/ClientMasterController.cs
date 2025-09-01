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
    public class ClientMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public ClientMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }


        [HttpGet("allclient")]
        [Produces("application/json", Type = typeof(ClientMasterResp))]
        public IActionResult GetClientMaster( string? flagName)
        {
            try
            {
                RTA.Masters.ClientMasterBLL sample = new ClientMasterBLL(DBConnStr);
                var Res = sample.GetClientMaster(flagName);
                objAction = CreatedAtAction("GetClientMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetClientMaster", data);
                return objAction;
            }
        }


        [HttpGet("clientDetail")]
        [Produces("application/json", Type = typeof(ClientMasterResp))]
        public IActionResult GetClientMasterById(long clientId)
        {
            try
            {
                //long client_purchaser_code = long.Parse(Configurations["CLIENT_PURCHASE_CODE"]);
                RTA.Masters.ClientMasterBLL sample = new ClientMasterBLL(DBConnStr);
                var Res = sample.GetClientMasterById(clientId);
                objAction = CreatedAtAction("GetClientMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetClientMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ClientMasterResp))]
        public IActionResult AddClientMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] ClientMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ClientMasterBLL sample = new ClientMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.InsertClientMaster(samp);
                    objAction = CreatedAtAction("AddClientMaster", Res);
                    return objAction;

                }

                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddClientMaster", data);
                return objAction;


                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddClientMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ClientMasterResp))]
        public IActionResult UpdateClientMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long clientId, [FromBody] ClientMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ClientMasterBLL sample = new ClientMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.UpdateClientMaster(clientId, samp);
                    objAction = CreatedAtAction("UpdateClientMaster", Res);
                    return objAction;

                }

                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateClientMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateClientMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ClientMasterResp))]
        public IActionResult DeleteClientMaster(long clientId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ClientMasterBLL sample = new ClientMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteClientMaster(clientId);
                    objAction = CreatedAtAction("DeleteClientMaster", Res);
                    return objAction;
                }

                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteClientMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteClientMaster", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(ClientMasterResp))]
        public IActionResult UploadClientMasterFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Client_Image");
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
                var base_url = $"/Client_Image/{newFileName}";

                objAction = CreatedAtAction("UploadClientMasterFile", new
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
                ClientMasterResp data = new ClientMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadClientMasterFile", data);
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
