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
    public class IssueReceiptController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public IssueReceiptController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult CreateChallanMaster([FromBody] IssueReceiptReq samp)
        {
            try
            {


                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);

                //var checkChallanNumber = sample.CheckChallanNumber(samp.challanno);
                //if (checkChallanNumber.IssueReceiptMasterDetailByID != null)
                //{
                //        objAction = CreatedAtAction("CreateChallanMaster", checkChallanNumber);
                //        return objAction;
                //}

                var Res = sample.InsertIssueReceiptMaster(samp);
                objAction = CreatedAtAction("CreateChallanMaster", Res);


                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateChallanMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult UpdateChallanMaster([FromBody] IssueReceiptReq samp)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.UpdateIssueReceiptMaster(samp);
                objAction = CreatedAtAction("UpdateChallanMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateChallanMaster", data);
                return objAction;
            }
        }


        [HttpGet("allchallan")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetAllChallanMaster()
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.GetIssueReceiptMaster();
                objAction = CreatedAtAction("GetAllChallanMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllChallanMaster", data);
                return objAction;
            }
        }



        [HttpGet("challanById")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetChallanMasterById([FromQuery] long challanId)
        {
            try
            {
                if (challanId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "challanId is required", Data = false });
                }

                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.GetIssueReceiptMasterById(challanId);
                objAction = CreatedAtAction("GetChallanMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetChallanMasterById", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult DeleteChallanMaster([FromQuery] long challanId)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.DeleteIssueReceiptMaster(challanId);
                objAction = CreatedAtAction("DeleteChallanMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteChallanMaster", data);
                return objAction;
            }
        }





        [HttpGet("challanId")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetLastChallanMasterId(string? irFlag)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.GetLastChallanMasterId(irFlag);
                objAction = CreatedAtAction("GetLastChallanMasterId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetLastChallanMasterId", data);
                return objAction;
            }
        }


        // ==========================  Challan Brokage Master Api ============================

        [HttpPost("createChallanBrokage")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult InsertIssueReceiptBreakageMaster([FromBody] IssueReceiptReq samp)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.InsertIssueReceiptBreakageMaster(samp);
                objAction = CreatedAtAction("CreateChallanBrokageMaster", Res);

                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateChallanBrokageMaster", data);
                return objAction;
            }
        }


        [HttpPut("updateChallanBrokage")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult UpdateIssueReceiptBreakageMaster([FromBody] IssueReceiptReq samp)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.UpdateIssueReceiptBreakageMaster(samp);
                objAction = CreatedAtAction("UpdateIssueReceiptBreakageMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateIssueReceiptBreakageMaster", data);
                return objAction;
            }
        }



        [HttpDelete("deleteChallanBrokage")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult DeleteIssueReceiptBreakageMaster([FromQuery] long challanId)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.DeleteIssueReceiptBreakageMaster(challanId);
                objAction = CreatedAtAction("DeleteIssueReceiptBreakageMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteIssueReceiptBreakageMaster", data);
                return objAction;
            }
        }


        [HttpGet("allChallanBrokageByChallanTransId")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetIssueReceiptBreakageByIssueTransMaster(long challan_trans_id, long challan_master_id)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.GetIssueReceiptBreakageByIssueTransMaster(challan_trans_id,  challan_master_id);
                objAction = CreatedAtAction("GetAllChallanMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllChallanMaster", data);
                return objAction;
            }
        }


        


        [HttpGet("lastFiveRecords")]
        [Produces("application/json", Type = typeof(IssueReceiptResp))]
        public IActionResult GetIssueReceiptMasterByLastRecords(long? challanId)
        {
            try
            {
                IssueReceiptMasterBLL sample = new IssueReceiptMasterBLL(DBConnStr);
                var Res = sample.GetIssueReceiptMasterByLastRecords(challanId);
                objAction = CreatedAtAction("GetIssueReceiptMasterByLastRecords", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                IssueReceiptResp data = new IssueReceiptResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetIssueReceiptMasterByLastRecords", data);
                return objAction;
            }
        }
    }
}

