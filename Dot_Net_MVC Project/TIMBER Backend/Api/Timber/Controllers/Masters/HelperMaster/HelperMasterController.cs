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
//using RTA.Common.Models;
using Microsoft.AspNetCore.WebUtilities;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelperMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
       // private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public HelperMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }



        [HttpGet("all")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult GetAllHelperMaster()
        {
            try
            {
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
                var Res = sample.GetAllHelperMaster();
                objAction = CreatedAtAction("GetAllHelperMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllHelperMaster", data);
                return objAction;
            }
        }



        [HttpGet("allOption")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult GetHelperMaster(string fromName)
        {
            try
            {
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
                var Res = sample.GetHelperMaster(fromName);
                objAction = CreatedAtAction("GetHelperMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetHelperMaster", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult GetHelperMasterById(long helperId)
        {
            try
            {
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
                var Res = sample.GetHelperMasterById(helperId);
                objAction = CreatedAtAction("GetHelperMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetHelperMasterById", data);
                return objAction;
            }
        }



        [HttpPost("create")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult AddHelperMaster([FromBody] HelperMasterReq samp)
        {
            try
            {


                //ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
               // if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                //{

                    var Res = sample.InsertHelperMaster(samp);
                    objAction = CreatedAtAction("AddHelperMaster", Res);
                    return objAction;
                //}

                //HelperMasterResp data = new HelperMasterResp()
                //{
                //    status = false,
                //    Message = modelAuth.message
                //};
                //objAction = CreatedAtAction("AddHelperMaster", data);
                //return objAction;

              

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddHelperMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult UpdateHelperMaster(
             long helperId, [FromBody] HelperMasterReq samp)
        {
            try
            {

              //  ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
                //if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                //{

                    var Res = sample.UpdateHelperMaster(helperId, samp);
                    objAction = CreatedAtAction("UpdateHelperMaster", Res);
                    return objAction;
                //}

                //HelperMasterResp data = new HelperMasterResp()
                //{
                //    status = false,
                //    Message = modelAuth.message
                //};
                //objAction = CreatedAtAction("UpdateHelperMaster", data);
                //return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateHelperMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult DeleteHelperMaster(long helperId)
        {
            try
            {
               

               // ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
                //if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                //{
                    var Res = sample.DeleteHelperMaster(helperId);
                    objAction = CreatedAtAction("DeleteHelperMaster", Res);
                    return objAction;
                //}

                //HelperMasterResp data = new HelperMasterResp()
                //{
                //    status = false,
                //    Message = modelAuth.message
                //};
                //objAction = CreatedAtAction("DeleteHelperMaster", data);
                //return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteHelperMaster", data);
                return objAction;
            }
        }



        /// =============================== State Master   ========================================== ///


        [HttpGet("allState")]
        [Produces("application/json", Type = typeof(HelperMasterResp))]
        public IActionResult GetStateMaster()
        {
            try
            {
                RTA.Masters.HelperMasterBLL sample = new HelperMasterBLL(DBConnStr);
                var Res = sample.GetStateMaster();
                objAction = CreatedAtAction("GetStateMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HelperMasterResp data = new HelperMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetStateMaster", data);
                return objAction;
            }
        }


    }
}
