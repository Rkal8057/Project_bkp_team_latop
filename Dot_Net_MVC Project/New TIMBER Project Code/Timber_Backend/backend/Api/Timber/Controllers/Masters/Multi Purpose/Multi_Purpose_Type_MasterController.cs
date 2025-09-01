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
    public class Multi_Purpose_Type_MasterController : ControllerBase
    {
        IConfiguration Configurations;
        string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        public Multi_Purpose_Type_MasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("AddMulti_Purpose_Type_Master")]
        [Produces("application/json", Type = typeof(Multi_Purpose_Type_Master_ModelResponse))]
        public IActionResult AddMulti_Purpose_Type_Master(
     [FromBody] Multi_Purpose_Type_Master_ModelRequest samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)

        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                User_Detail user = modelAuth.User;
                MultiPurposeMasterBLL sample = new MultiPurposeMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertMulti_Purpose_Type_Master(samp, user);
                    objAction = CreatedAtAction("AddMulti_Purpose_Type_Master", Res);
                    return objAction;
                }
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddMulti_Purpose_Type_Master", samp);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("AddMulti_Purpose_Type_Master", data);
                return objAction;
            }
        }

        [HttpGet("GetMulti_Purpose_Type_Master")]
        [Produces("application/json", Type = typeof(Multi_Purpose_Type_Master_ModelResponse))]
        public IActionResult GetMulti_Purpose_Type_Master(
[FromQuery] string? searchItem
   )
        {
            try
            {

                MultiPurposeMasterBLL sample = new MultiPurposeMasterBLL(DBConnStr);
                var Res = sample.GetMulti_Purpose_Type_Master(searchItem);

                objAction = CreatedAtAction("GetMulti_Purpose_Type_Master", Res);
                return objAction;

                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetMulti_Purpose_Type_Master", data);
                return objAction;
            }
        }


        [HttpPut("UpdateMulti_Purpose_Type_Master")]
        [Produces("application/json", Type = typeof(Multi_Purpose_Type_Master_ModelResponse))]
        public IActionResult UpdateMulti_Purpose_Type_Master(
            int id,
       [FromBody] Multi_Purpose_Type_Master_ModelRequest samp, long Token_ID,
            [FromHeader] string Token_Data
       )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                User_Detail user = modelAuth.User;
                MultiPurposeMasterBLL sample = new MultiPurposeMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateMulti_Purpose_Type_Master(id, samp, user);
                    objAction = CreatedAtAction("UpdateMulti_Purpose_Type_Master", Res);
                    return objAction;
                }
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateMulti_Purpose_Type_Master", samp);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateMulti_Purpose_Type_Master", data);
                return objAction;
            }
        }

        [HttpDelete("DeleteMulti_Purpose_Type_Master")]
        [Produces("application/json", Type = typeof(Multi_Purpose_Type_Master_ModelResponse))]
        public IActionResult DeleteMulti_Purpose_Type_Master(
             long Token_ID,
            [FromHeader] string Token_Data,
            int id
        )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                MultiPurposeMasterBLL sample = new MultiPurposeMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.DeleteMulti_Purpose_Type_Master(id);
                    objAction = CreatedAtAction("DeleteMulti_Purpose_Type_Master", Res);
                    return objAction;

                }

                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteMulti_Purpose_Type_Master", data);
                return objAction;
            }
        }
        [HttpGet("Get_All_Multi_Purpose_Type_Master")]
        [Produces("application/json", Type = typeof(Multi_Purpose_Type_Master_ModelResponse))]
        public IActionResult Get_All_Multi_Purpose_Type_Master(

  )
        {
            try
            {

                MultiPurposeMasterBLL sample = new MultiPurposeMasterBLL(DBConnStr);
                var Res = sample.Get_All_Multi_Purpose_Type_Master();

                objAction = CreatedAtAction("Get_All_Multi_Purpose_Type_Master", Res);
                return objAction;

                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Multi_Purpose_Type_Master_ModelResponse data = new Multi_Purpose_Type_Master_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("Get_All_Multi_Purpose_Type_Master", data);
                return objAction;
            }
        }

    }
}
