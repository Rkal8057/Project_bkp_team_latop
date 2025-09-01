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
    public class System_RecordsController : ControllerBase
    {
        IConfiguration Configurations;
        string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;

        public System_RecordsController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("AddSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult AddSystem_Records(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,  [FromBody] System_Records_ModelRequest samp)

        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);

                    var Res = sample.InsertSystem_Records(samp);
                    objAction = CreatedAtAction("AddSystem_Records", Res);
                    return objAction;
                }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSystem_Records", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("AddSystem_Records", data);
                return objAction;
            }
        }

        [HttpGet("GetSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult GetSystem_Records([FromHeader] long Token_ID, [FromHeader] string Token_Data, [FromQuery] string? searchItem)
        {
            try
            {
               /* // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to read system records
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {*/
                    System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                    var Res = sample.GetSystem_Records(searchItem);
                    objAction = CreatedAtAction("GetSystem_Records", Res);
                    return objAction;
               /* }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetSystem_Records", data);
                return objAction;*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetSystem_Records", data);
                return objAction;
            }
        }

        [HttpGet("GetSystem_RecordsById")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult GetSystem_RecordsById()
        {
            try
            {
                // Authenticate the user
               /* ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to read system records by ID
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {*/
                    System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                    var Res = sample.GetSystem_RecordsById();
                    objAction = CreatedAtAction("GetSystem_RecordsById", Res);
                    return objAction;
/*                }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetSystem_RecordsById", data);
                return objAction;*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetSystem_RecordsById", data);
                return objAction;
            }
        }

        [HttpGet("GetSystem_RecordsByIdWithFlag")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult GetSystem_RecordsByIdWithFlag([FromHeader] long Token_ID, [FromHeader] string Token_Data, string flag)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to read system records by ID with flag
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                    var Res = sample.GetSystem_RecordsByIdWithFlag(flag);
                    objAction = CreatedAtAction("GetSystem_RecordsByIdWithFlag", Res);
                    return objAction;
                }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetSystem_RecordsByIdWithFlag", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetSystem_RecordsByIdWithFlag", data);
                return objAction;
            }
        }

        [HttpPut("UpdateSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult UpdateSystem_Records([FromHeader] long Token_ID, [FromHeader] string Token_Data, int id, [FromBody] System_Records_ModelRequest samp)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to update system records
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                    var Res = sample.UpdateSystem_Records(id, samp);
                    objAction = CreatedAtAction("UpdateSystem_Records", Res);
                    return objAction;
                }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateSystem_Records", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("UpdateSystem_Records", data);
                return objAction;
            }
        }

        [HttpDelete("DeleteSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult DeleteSystem_Records([FromHeader] long Token_ID, [FromHeader] string Token_Data, int id)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to delete system records
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                    var Res = sample.DeleteSystem_Records(id);
                    objAction = CreatedAtAction("DeleteSystem_Records", Res);
                    return objAction;
                }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteSystem_Records", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("DeleteSystem_Records", data);
                return objAction;
            }
        }

        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult UploadSystem_RecordFile([FromHeader] long Token_ID, [FromHeader] string Token_Data, IFormFile? signature)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to upload files
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjust to appropriate permission
                {
                    if (signature == null)
                    {
                        return BadRequest(new { status = 404, message = "File is required", data = false });
                    }

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "System_Image");
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
                    var base_url = $"/System_Image/{newFileName}";

                    objAction = CreatedAtAction("UploadSystem_RecordFile", new
                    {
                        status = true,
                        Message = "File upload successfully",
                        Data = base_url
                    });
                    return objAction;
                }

                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadSystem_RecordFile", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadSystem_RecordFile", data);
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
