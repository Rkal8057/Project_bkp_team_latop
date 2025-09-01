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

namespace Rta.Controllers.Masters.ReqRec
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReqRecController : ControllerBase
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ReqRecController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        //GET ALL RECORDS
        [HttpGet("GetRecords")]
        [Produces("application/json", Type = typeof(ModelReqResp))]
        public IActionResult GetRecords(
            //[FromHeader] long Token_ID,
            //[FromHeader] string Token_Data
            )
        {
            try
            {
                //User_Detail User = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(User, 1, "REPORT"))
                //{
                ReqRecBLL rb = new ReqRecBLL(DBConnStr);

                var Res = rb.GetRecordData();

                objAction = CreatedAtAction("GetRecords", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelReqResp data = new ModelReqResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetRecords", data);
                return objAction;
            }
        }



        [HttpGet("GetRecordByID/{id}")]
        [Produces("application/json", Type = typeof(ModelReqResp))]
        public IActionResult GetRecordByID(int id)
        {
            try
            {
                ReqRecBLL rb = new ReqRecBLL(DBConnStr);
                var Res = rb.GetRecordDataById(id);

                objAction = CreatedAtAction("GetRecordByID", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelReqResp data = new ModelReqResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetRecordByID", data);
                return objAction;
            }
        }

        [HttpPost("AddRecord")]
        [Produces("application/json", Type = typeof(ModelReqResp))]
        public IActionResult CreateRecord([FromBody] ModelReq Data)
        {
            try
            {
                ReqRecBLL rb = new ReqRecBLL(DBConnStr);
                var Res = rb.InsertSample(Data);

                objAction = CreatedAtAction("CreateRecord", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelReqResp data = new ModelReqResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateRecord", data);
                return objAction;
            }
        }



        [HttpPut("UpdateRecordByID/{id}")]
        [Produces("application/json", Type = typeof(ModelReqResp))]
        public IActionResult UpdateRecord( int id, [FromBody] ModelReq Data)
        {

            try
            {
                Console.WriteLine(id);
                RTA.Masters.ReqRecBLL rb = new ReqRecBLL(DBConnStr);
                var Res = rb.UpdateSample(id, Data);
                objAction = CreatedAtAction("UpdateRecord", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelReqResp data = new ModelReqResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateRecord", data);
                return objAction;
            }

        }



        [HttpPut("DeleteRecordByID")]
        [Produces("application/json", Type = typeof(ModelReqResp))]
        public IActionResult DeleteRecord(int id)
        {
            try
            {
                ReqRecBLL rb = new ReqRecBLL(DBConnStr);
                var Res = rb.DeleteSample(id);

                objAction = CreatedAtAction("DeleteRecord", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelReqResp data = new ModelReqResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteRecord", data);
                return objAction;
            }


        }

    }
}
