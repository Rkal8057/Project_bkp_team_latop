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
using RTA.Common.Models;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormMasterController : ControllerBase
    {

        IConfiguration Configurations;
        string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        public FormMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }

        [HttpPost("AddFormMaster")]
        [Produces("application/json", Type = typeof(FormMasterResp))]
        public IActionResult AddFormMaster([FromBody] FormMasterReq samp, [FromHeader]
        long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                User_Detail user = modelAuth.User;
                FormMasterBLL sample = new FormMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertFormMaster(samp,user);
                    objAction = CreatedAtAction("AddFormMaster", Res);
                    return objAction;
                }
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddFormMaster", samp);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("AddFormMaster", data);
                return objAction;
            }
        }

        [HttpGet("GetFormMaster")]
        [Produces("application/json", Type = typeof(FormMasterResp))]
        public IActionResult GetFormMaster(string? search)
        {
            try
            {

                FormMasterBLL sample = new FormMasterBLL(DBConnStr);
                var Res = sample.GetFormMaster(search);

                objAction = CreatedAtAction("GetFormMaster", Res);
                return objAction;

                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetFormMaster", data);
                return objAction;
            }
        }


        [HttpPut("UpdateFormMaster")]
        [Produces("application/json", Type = typeof(FormMasterResp))]
        public IActionResult UpdateFormMaster(
            int id,
       [FromBody] FormMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
       )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                User_Detail user = modelAuth.User;
                FormMasterBLL sample = new FormMasterBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.UpdateFormMaster(id, samp,user);
                objAction = CreatedAtAction("UpdateFormMaster", Res);
                return objAction;
                }
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateFormMaster", samp);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateFormMaster", data);
                return objAction;
            }
        }

        [HttpDelete("DeleteFormMaster")]
        [Produces("application/json", Type = typeof(FormMasterResp))]
        public IActionResult DeleteFormMaster(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int id
        )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                FormMasterBLL sample = new FormMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteFormMaster(id);
                    objAction = CreatedAtAction("DeleteFormMaster", Res);
                    return objAction;

                }
                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteFormMaster", data);
                return objAction;
            }
        }

        [HttpGet("GetFormMasterById")]
        [Produces("application/json", Type = typeof(FormMasterResp))]
        public IActionResult GetFormMasterById(long id)
        {
            try
            {

                FormMasterBLL sample = new FormMasterBLL(DBConnStr);
                var Res = sample.GetFormMasterById(id);

                objAction = CreatedAtAction("GetFormMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetFormMasterById", data);
                return objAction;
            }


        }


        [HttpGet("GetDisplayeMenu")]
        [Produces("application/json", Type = typeof(FormMasterResp))]
        public IActionResult GetDisplayeMenu([FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                User_Detail user = modelAuth.User;
                FormMasterBLL sample = new FormMasterBLL(DBConnStr);

                var Res = sample.GetDisplayeMenu(user);
                objAction = CreatedAtAction("GetDisplayeMenu", Res);
                return objAction;


                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                FormMasterResp data = new FormMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetDisplayeMenu", data);
                return objAction;
            }
        }
    }
}
