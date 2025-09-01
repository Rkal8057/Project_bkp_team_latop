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
    public class SampleController : ControllerBase
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public SampleController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        //GET ALL RECORDS
        [HttpGet("GetSampleRecords")]
        [Produces("application/json", Type = typeof(ModelSampleResp))]
        public IActionResult GetSampleRecords(
              //[FromHeader] long Token_ID,
              //[FromHeader] string Token_Data
            )
        {
            try
            {
                //User_Detail User = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(User, 1, "REPORT"))
                //{
                SampleMastBLL sample = new SampleMastBLL(DBConnStr);

                var Res = sample.GetSampleData();

                objAction = CreatedAtAction("GetSampleRecords", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSampleResp data = new ModelSampleResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSampleRecords", data);
                return objAction;
            }
        }


        [HttpGet("GetSampleRecordByID")]
        [Produces("application/json", Type = typeof(ModelSampleResp))]
        public IActionResult GetSampleRecordByID(int id
             //[FromHeader] long Token_ID,
             //[FromHeader] string Token_Data
        )
        {
            try
            {
                //User_Detail User = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(User, 1, "REPORT"))
                //{

                RTA.Masters.SampleMastBLL sample = new SampleMastBLL(DBConnStr);
                var Res = sample.GetSampleDataByID(id);
                objAction = CreatedAtAction("GetSampleRecordByID", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSampleResp data = new ModelSampleResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSampleRecordByID", data);
                return objAction;
            }
        }

        [HttpPost("AddSampleMaster")]
        [Produces("application/json", Type = typeof(ModelSampleResp))]
        public IActionResult AddSampleMaster(
        [FromBody] ModelSampleReq samp
        //,[FromHeader] long Token_ID,
        //[FromHeader] string Token_Data
        )
        {
            try
            {
                //User_Detail User = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(User, 1, "REPORT"))
                //{           
                RTA.Masters.SampleMastBLL sample = new SampleMastBLL(DBConnStr);
                var Res = sample.InsertSample(samp);
                objAction = CreatedAtAction("AddSampleMaster", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSampleResp data = new ModelSampleResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSampleMaster", data);
                return objAction;
            }
        }

        [HttpPut("UpdateSampleMaster")]
        [Produces("application/json", Type = typeof(ModelSampleResp))]
        public IActionResult UpdateSampleMaster(int id, 
        [FromBody] ModelSampleReq samp
        //,[FromHeader] long Token_ID,
        //[FromHeader] string Token_Data
        )
        {
            try
            {
                //User_Detail User = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(User, 1, "REPORT"))
                //{

                RTA.Masters.SampleMastBLL sample = new SampleMastBLL(DBConnStr);
                var Res = sample.UpdateSample(id, samp);
                objAction = CreatedAtAction("UpdateSampleMaster", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSampleResp data = new ModelSampleResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSampleMaster", data);
                return objAction;
            }
        }

        [HttpDelete("DeleteSampleMaster")]
        [Produces("application/json", Type = typeof(ModelSampleResp))]
        public IActionResult DeleteSampleMaster(int id
            //,[FromHeader] long Token_ID,
            //[FromHeader] string Token_Data
        )
        {
            try
            {
                //User_Detail User = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(User, 1, "REPORT"))
                //{
                RTA.Masters.SampleMastBLL inwaard = new SampleMastBLL(DBConnStr);
                var Res = inwaard.DeleteSample(id);
                objAction = CreatedAtAction("DeleteSampleMaster", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSampleResp data = new ModelSampleResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSampleMaster", data);
                return objAction;
            }
        }
    }
}
