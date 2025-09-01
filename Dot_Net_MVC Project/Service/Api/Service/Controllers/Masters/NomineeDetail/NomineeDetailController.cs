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
    public class NomineeDetailController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public NomineeDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }


        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(NomineeDetailResp))]
        public IActionResult GetNomineeDetail()
        {
            try
            {

                NomineeDetailBLL sample = new NomineeDetailBLL(DBConnStr);
                var Res = sample.GetNomineeDetail();
                objAction = CreatedAtAction("GetNomineeDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NomineeDetailResp data = new NomineeDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetNomineeDetail", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(NomineeDetailResp))]
        public IActionResult GetNomineeDetailByID(int id)
        {
            try
            {

                RTA.Masters.NomineeDetailBLL sample = new NomineeDetailBLL(DBConnStr);
                var Res = sample.GetNomineeDetailByID(id);
                objAction = CreatedAtAction("GetNomineeDetailByID", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NomineeDetailResp data = new NomineeDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetNomineeDetailByID", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(NomineeDetailResp))]
        public IActionResult InsertNomineeDetail([FromBody] NomineeDetailReq samp)
        {
            try
            {

                RTA.Masters.NomineeDetailBLL sample = new NomineeDetailBLL(DBConnStr);
                var Res = sample.InsertNomineeDetail(samp);
                objAction = CreatedAtAction("InsertNomineeDetail", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NomineeDetailResp data = new NomineeDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("InsertNomineeDetail", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(NomineeDetailResp))]
        public IActionResult UpdateNomineeDetail(int id, [FromBody] NomineeDetailReq samp)
        {
            try
            {

                RTA.Masters.NomineeDetailBLL sample = new NomineeDetailBLL(DBConnStr);
                var Res = sample.UpdateNomineeDetail(id, samp);
                objAction = CreatedAtAction("UpdateNomineeDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NomineeDetailResp data = new NomineeDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateNomineeDetail", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(NomineeDetailResp))]
        public IActionResult DeleteNomineeDetail(int id)
        {
            try
            {

                RTA.Masters.NomineeDetailBLL inwaard = new NomineeDetailBLL(DBConnStr);
                var Res = inwaard.DeleteNomineeDetail(id);
                objAction = CreatedAtAction("DeleteNomineeDetail", Res);
                return objAction;
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NomineeDetailResp data = new NomineeDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteNomineeDetail", data);
                return objAction;
            }
        }
    }
}
