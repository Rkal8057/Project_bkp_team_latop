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
    public class KYCDetailController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public KYCDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }


        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(KYCDetailResp))]
        public IActionResult GetKYCDetail()
        {
            try
            {

                KYCDetailBLL sample = new KYCDetailBLL(DBConnStr);
                var Res = sample.GetKYCDetail();
                objAction = CreatedAtAction("GetKYCDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                KYCDetailResp data = new KYCDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetKYCDetail", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(KYCDetailResp))]
        public IActionResult GetKYCDetailByID(int id)
        {
            try
            {

                RTA.Masters.KYCDetailBLL sample = new KYCDetailBLL(DBConnStr);
                var Res = sample.GetKYCDetailByID(id);
                objAction = CreatedAtAction("GetKYCDetailByID", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                KYCDetailResp data = new KYCDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetKYCDetailByID", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(KYCDetailResp))]
        public IActionResult InsertKYCDetail([FromBody] KYCDetailReq samp)
        {
            try
            {

                RTA.Masters.KYCDetailBLL sample = new KYCDetailBLL(DBConnStr);
                var Res = sample.InsertKYCDetail(samp);
                objAction = CreatedAtAction("InsertKYCDetail", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                KYCDetailResp data = new KYCDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("InsertKYCDetail", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(KYCDetailResp))]
        public IActionResult UpdateKYCDetail(int id, [FromBody] KYCDetailReq samp)
        {
            try
            {

                RTA.Masters.KYCDetailBLL sample = new KYCDetailBLL(DBConnStr);
                var Res = sample.UpdateKYCDetail(id, samp);
                objAction = CreatedAtAction("UpdateKYCDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                KYCDetailResp data = new KYCDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateKYCDetail", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(KYCDetailResp))]
        public IActionResult DeleteKYCDetail(int id)
        {
            try
            {

                RTA.Masters.KYCDetailBLL sample = new KYCDetailBLL(DBConnStr);
                var Res = sample.DeleteKYCDetail(id);
                objAction = CreatedAtAction("DeleteKYCDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                KYCDetailResp data = new KYCDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteKYCDetail", data);
                return objAction;
            }
        }
    }
}
