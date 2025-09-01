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
    public class VoucherMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public VoucherMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }




        [HttpGet("allVoucherList")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult GetVoucherMasterList()
        {
            try
            {
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                var Res = sample.GetVoucherMasterList();
                objAction = CreatedAtAction("GetVoucherMasterList", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetVoucherMasterList", data);
                return objAction;
            }
        }


        [HttpGet("allVoucher")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult GetvoucherMaster()
        {
            try
            {
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                var Res = sample.GetvoucherMaster();
                objAction = CreatedAtAction("GetvoucherMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetvoucherMaster", data);
                return objAction;
            }
        }

        [HttpGet("voucherDetail")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult GetvoucherMasterById(long voucherId)
        {
            try
            {
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                var Res = sample.GetVoucherMasterById(voucherId);
                objAction = CreatedAtAction("GetvoucherMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetvoucherMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult AddvoucherMaster([FromBody] VoucherMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertVoucherMaster(samp);
                    objAction = CreatedAtAction("AddvoucherMaster", Res);
                    return objAction;
                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddvoucherMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddvoucherMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult UpdatevoucherMaster(long voucherId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] VoucherMasterReq samp)
        {
            try
            {
                
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateVoucherMaster(voucherId, samp);
                    objAction = CreatedAtAction("UpdatevoucherMaster", Res);
                    return objAction;

                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdatevoucherMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdatevoucherMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult DeletevoucherMaster(long companyId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteVoucherMaster(companyId);
                    objAction = CreatedAtAction("DeletevoucherMaster", Res);
                    return objAction;

                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeletevoucherMaster", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeletevoucherMaster", data);
                return objAction;
            }
        }


    }
}
