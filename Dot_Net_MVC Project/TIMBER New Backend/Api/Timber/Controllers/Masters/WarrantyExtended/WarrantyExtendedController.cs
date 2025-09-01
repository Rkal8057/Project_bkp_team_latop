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
using System.ComponentModel.Design;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarrantyExtendedController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public WarrantyExtendedController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult AddWarrantyExtended([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] WarrantyExtendedReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {

                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.InsertWarrantyExtendedMaster(samp);
                    objAction = CreatedAtAction("AddWarrantyExtended", Res);
                    return objAction;

                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddWarrantyExtended", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddWarrantyExtended", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult UpdateWarrantyExtended([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long warrantyId, [FromBody] WarrantyExtendedReq samp)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.UpdateWarrantyExtendedMaster(warrantyId, samp);
                    objAction = CreatedAtAction("UpdateWarrantyExtended", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateWarrantyExtended", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateWarrantyExtended", data);
                return objAction;
            }
        }



        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult DeleteWarrantyExtended([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long warrantyId)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.DeleteWarrantyExtendedMaster(warrantyId);
                    objAction = CreatedAtAction("DeleteWarrantyExtended", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteWarrantyExtended", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteWarrantyExtended", data);
                return objAction;
            }
        }



        [HttpGet("warrantyExtendedById")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult GetWarrantyExtendedMasterById([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long warrantyId)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.GetWarrantyExtendedMasterById(warrantyId);
                    objAction = CreatedAtAction("GetWarrantyExtendedMasterById", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetWarrantyExtendedMasterById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetWarrantyExtendedMasterById", data);
                return objAction;
            }
        }



        [HttpGet("allWarrantyExtended")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult GetAllWarrantyExtended([FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.GetWarrantyExtendedMasterList();
                    objAction = CreatedAtAction("GetAllWarrantyExtended", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllWarrantyExtended", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllWarrantyExtended", data);
                return objAction;
            }
        }

        // ================================= Issue Challan Api Start=====================

        [HttpGet("allSingleItem")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult GetAllIssueChallanSingleItem([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? searchKey = null)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.GetAllIssueChallanSingleItem(searchKey);
                    objAction = CreatedAtAction("GetAllIssueChallanSingleItem", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetAllIssueChallanSingleItem", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllIssueChallanSingleItem", data);
                return objAction;
            }
        }


        [HttpGet("SingleItemById")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult GetIssueChallanSingleItemById(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long? challanId, long? itemId)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.GetIssueChallanSingleItemById(challanId, itemId);
                    objAction = CreatedAtAction("GetIssueChallanSingleItemById", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetIssueChallanSingleItemById", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetIssueChallanSingleItemById", data);
                return objAction;
            }
        }

        // ================================= Issue Challan Api End =====================


        [HttpGet("LastId")]
        [Produces("application/json", Type = typeof(WarrantyExtendedResp))]
        public IActionResult GetLastIdWarrantyExtended(
        [FromHeader] long Token_ID,
        [FromHeader] string Token_Data)
        {
            try
            {
                // Authenticate user and verify form rights
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    RTA.Masters.WarrantyExtendedBLL sample = new WarrantyExtendedBLL(DBConnStr);
                    var Res = sample.GetLastIdWarrantyExtended();
                    objAction = CreatedAtAction("GetLastIdWarrantyExtended", Res);
                    return objAction;
                }

                // Handle case where the user doesn't have the required rights
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetLastIdWarrantyExtended", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                WarrantyExtendedResp data = new WarrantyExtendedResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetLastIdWarrantyExtended", data);
                return objAction;
            }
        }
    }
}
