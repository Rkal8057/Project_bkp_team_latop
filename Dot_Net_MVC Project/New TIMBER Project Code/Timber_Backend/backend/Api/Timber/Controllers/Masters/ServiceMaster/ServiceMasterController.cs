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
using Microsoft.AspNetCore.Mvc.RazorPages;
using RTA.Common.Models;


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ServiceMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult CreateServiceMaster(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, 
            [FromBody] ServiceMasterReq samp
        ){
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE")) // Adjusted to use "DELETE"
                {
                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);

                    var checkService = sample.CheckServiceName(samp.service_name);
                    if (checkService.status == false)
                    {
                        objAction = CreatedAtAction("CreateServiceMaster", checkService);
                        return objAction;
                    }

                    var Res = sample.InsertServiceMaster(samp);
                    objAction = CreatedAtAction("CreateServiceMaster", Res);
                    return objAction;
                }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateServiceMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateServiceMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult DeleteServiceMaster(
     [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromQuery] long id)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to delete a service master
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                    var Res = sample.DeleteServiceMaster(id);
                    objAction = CreatedAtAction("DeleteServiceMaster", Res);
                    return objAction;
                }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteServiceMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteServiceMaster", data);
                return objAction;
            }
        }

        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult GetServiceMaster(
           )
        {
            try
            {
                // Authenticate the user
               /* ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to read service master details
                if (commonAuth.VerifyFormRights(modelAuth, 1, "READ"))
                {*/
                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                    var Res = sample.GetServiceMaster();
                    objAction = CreatedAtAction("GetServiceMaster", Res);
                    return objAction;
              /*  }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetServiceMaster", data);
                return objAction;*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetServiceMaster", data);
                return objAction;
            }
        }


        [HttpGet("Alldetail")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult GetAllServiceMaster(
     
             int page = 1,
             int limit = 20,
             string? searchKey = null)
        {
            try
            {
                // Authenticate the user
              /*  ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to read all service masters
                if (commonAuth.VerifyFormRights(modelAuth, 1, "READ"))
                {*/
                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                    var Res = sample.GetAllServiceMaster(page, limit, searchKey);
                    objAction = CreatedAtAction("GetAllServiceMaster", Res);
                    return objAction;
               /* }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllServiceMaster", data);
                return objAction;
*/            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllServiceMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult UpdateServiceMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long id,
            [FromBody] UpdateServiceMasterReq samp)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to update a service master
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (id <= 0)
                    {
                        return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                    }

                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                    var Res = sample.UpdateServiceMaster(id, samp);
                    objAction = CreatedAtAction("UpdateServiceMaster", Res);
                    return objAction;
                }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateServiceMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateServiceMaster", data);
                return objAction;
            }
        }

        [HttpPost("createnew")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult CreateServiceMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] UpdateServiceMasterReq samp)
        {
            try
            {
                // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to create a service master
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);

                    var checkService = sample.CheckServiceName(samp.service_name);
                    if (checkService.status == false)
                    {
                        objAction = CreatedAtAction("CreateServiceMaster", checkService);
                        return objAction;
                    }

                    var Res = sample.CreateServiceMaster(samp);
                    objAction = CreatedAtAction("CreateServiceMaster", Res);
                    return objAction;
                }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateServiceMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateServiceMaster", data);
                return objAction;
            }
        }

        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult GetServiceMasterById(
            [FromQuery] long id)
        {
            try
            {
               /* // Authenticate the user
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                // Check if the user has permission to read a service master by ID
                if (commonAuth.VerifyFormRights(modelAuth, 1, "READ"))
                {*/
                    if (id <= 0)
                    {
                        return BadRequest(new { Status = false, Message = "Id is required", Data = false });
                    }

                    ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                    var Res = sample.GetServiceMasterById(id);
                    objAction = CreatedAtAction("GetServiceMasterById", Res);
                    return objAction;
             /*   }

                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetServiceMasterById", data);
                return objAction;*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetServiceMasterById", data);
                return objAction;
            }
        }


        /// -============================ SUB-SERVICE MASTER FUNCTION  =============================


        [HttpDelete("subservice/delete")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult DeleteSubServiceMaster([FromQuery] long id)
        {
            try
            {
                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.DeleteSubServiceMaster(id);
                objAction = CreatedAtAction("DeleteSubServiceMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSubServiceMaster", data);
                return objAction;
            }
        }


        /// -============================ CHECKLIST MASTER FUNCTION  =============================


        [HttpDelete("checklist/delete")]
        [Produces("application/json", Type = typeof(ServiceMasterResp))]
        public IActionResult DeleteCheckListMaster([FromQuery] long id)
        {
            try
            {
                ServiceMasterBLL sample = new ServiceMasterBLL(DBConnStr);
                var Res = sample.DeleteCheckListMaster(id);
                objAction = CreatedAtAction("DeleteCheckListMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ServiceMasterResp data = new ServiceMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCheckListMaster", data);
                return objAction;
            }
        }

    }
}
