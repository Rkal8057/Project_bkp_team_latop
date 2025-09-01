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
        public IActionResult GetvoucherMaster(string? search= null,string? type= null , DateTime? startDate= null, DateTime? endDate = null)
        {
            try
            {
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                var Res = sample.GetvoucherMaster(search ,type,startDate,endDate);
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
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
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
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
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
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
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






        [HttpGet("voucherId")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult GetLastVoucherMasterId()
        {
            try
            {
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                var Res = sample.GetLastVoucherMasterId();
                objAction = CreatedAtAction("GetLastVoucherMasterId", Res);
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
                objAction = CreatedAtAction("GetLastVoucherMasterId", data);
                return objAction;
            }
        }



        //========================  Voucher Trans Master API ================================
        [HttpPost("createVoucherTrans")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult AddvoucherTransMaster([FromBody] VoucherMasterReq samp,
          [FromHeader] long Token_ID,
          [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {

                    var Res = sample.InsertVoucherTansDetail(samp);
                    objAction = CreatedAtAction("AddvoucherTransMaster", Res);
                    return objAction;
                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddvoucherTransMaster", data);
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
                objAction = CreatedAtAction("AddvoucherTransMaster", data);
                return objAction;
            }
        }


        [HttpGet("allVoucherTrans")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult GetvoucherTransMaster(long? VoucherTransId)
        {
            try
            {
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                var Res = sample.GetVoucherTansDetailList(VoucherTransId);
                objAction = CreatedAtAction("GetvoucherTransMaster", Res);
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
                objAction = CreatedAtAction("GetvoucherTransMaster", data);
                return objAction;
            }
        }



        [HttpDelete("deleteVouhcerTrans")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult DeletevoucherMasterTrans(long VoucherTransId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    var Res = sample.DeleteVoucherTansDetail(VoucherTransId);
                    objAction = CreatedAtAction("DeletevoucherMasterTrans", Res);
                    return objAction;

                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeletevoucherMasterTrans", data);
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
                objAction = CreatedAtAction("DeletevoucherMasterTrans", data);
                return objAction;
            }
        }




        [HttpPut("updateVoucherTrans")]
        [Produces("application/json", Type = typeof(VoucherMasterResp))]
        public IActionResult UpdatevoucherTransMaster([FromBody] VoucherMasterReq samp,
        [FromHeader] long Token_ID,
        [FromHeader] string Token_Data)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.VoucherMasterBLL sample = new VoucherMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {

                    var Res = sample.UpdateVoucherTansDetail(samp);
                    objAction = CreatedAtAction("UpdatevoucherTransMaster", Res);
                    return objAction;
                }
                VoucherMasterResp data = new VoucherMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdatevoucherTransMaster", data);
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
                objAction = CreatedAtAction("UpdatevoucherTransMaster", data);
                return objAction;
            }
        }

    }
}
