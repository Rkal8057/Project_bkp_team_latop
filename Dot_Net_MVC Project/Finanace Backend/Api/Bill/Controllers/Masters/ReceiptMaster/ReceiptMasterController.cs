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

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ReceiptMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ReceiptMasterResp))]
        public IActionResult CreateReceiptMaster([FromBody] ReceiptMasterReq samp)
        {
            try
            {

                ReceiptMasterBLL sample = new ReceiptMasterBLL(DBConnStr);
                var Res = sample.InsertReceiptMaster(samp);
                objAction = CreatedAtAction("CreateReceiptMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReceiptMasterResp data = new ReceiptMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateReceiptMaster", data);
                return objAction;
            }
        }


        
        [HttpGet("receiptByCaseNo")]
        [Produces("application/json", Type = typeof(ReceiptMasterResp))]
        public IActionResult GetReceiptByCaseNo([FromQuery] string CaseNo)
        {
            try
            {

                ReceiptMasterBLL sample = new ReceiptMasterBLL(DBConnStr);
                var Res = sample.GetReceiptByCaseNo(CaseNo);
                objAction = CreatedAtAction("GetReceiptByCaseNo", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReceiptMasterResp data = new ReceiptMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetReceiptByCaseNo", data);
                return objAction;
            }
        }
    }
}
