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
using Microsoft.AspNetCore.WebUtilities;


namespace Rta.Controllers.Masters
{

    [Route("api/[controller]")]
    [ApiController]
    public class AddToCartMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public AddToCartMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpGet("addToCartByUserId")]
        [Produces("application/json", Type = typeof(AddToCartMasterResp))]
        public IActionResult GetAddToCartMasterById(long? userId
            //[FromHeader] long Token_ID,
            //[FromHeader] string Token_Data
            )
        {
            try
            {

                //ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.AddToCartMasterBLL sample = new AddToCartMasterBLL(DBConnStr);
                //if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                //{
                    var Res = sample.GetAddToCartMasterById(userId);
                    objAction = CreatedAtAction("GetAddToCartMasterById", Res);
                    return objAction;
                //}
                //AddToCartMasterResp data = new AddToCartMasterResp()
                //{
                //    status = false,
                //    Message = modelAuth.message
                //};
                //objAction = CreatedAtAction("GetAddToCartMasterById", data);
                //return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AddToCartMasterResp data = new AddToCartMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAddToCartMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(AddToCartMasterResp))]
        public IActionResult AddAddToCartMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] List < AddToCartMasterReq>  samp, long userId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.AddToCartMasterBLL sample = new AddToCartMasterBLL(DBConnStr);
                
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertAddToCartMaster(samp, userId);
                    objAction = CreatedAtAction("AddAddToCartMaster", Res);
                    return objAction;
                }
                AddToCartMasterResp data = new AddToCartMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddAddToCartMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AddToCartMasterResp data = new AddToCartMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddAddToCartMaster", data);
                return objAction;
            }
        }

        [HttpPost("delete")]
        [Produces("application/json", Type = typeof(AddToCartMasterResp))]
        public IActionResult DeleteAddToCartMaster(List<AddToCartMasterReq> samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,long userId)
        {
            try
            {
         
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.AddToCartMasterBLL sample = new AddToCartMasterBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteAddToCartMaster(samp, userId);
                    objAction = CreatedAtAction("DeleteAddToCartMaster", Res);
                    return objAction;
                }

                AddToCartMasterResp data = new AddToCartMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddAddToCartMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                AddToCartMasterResp data = new AddToCartMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteAddToCartMaster", data);
                return objAction;
            }
        }

    }
}
