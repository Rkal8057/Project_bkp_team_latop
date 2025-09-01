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

namespace Rta.Controllers.Masters
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;


        public SubCategoryMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }


        [HttpGet("allsubcategory")]
        [Produces("application/json", Type = typeof(SubCategoryMasterResp))]
        public IActionResult GetSubCategoryMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, string? searchKey = null
          )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SubCategoryMasterBLL sample = new SubCategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.GetSubCategoryMaster(searchKey);
                    objAction = CreatedAtAction("GetSubCategoryMaster", Res);
                    return objAction;
                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetSubCategoryMaster", data);
                return objAction;
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SubCategoryMasterResp data = new SubCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSubCategoryMaster", data);
                return objAction;
            }
        }




        [HttpGet("subcategoryDetail")]
        [Produces("application/json", Type = typeof(SubCategoryMasterResp))]
        public IActionResult GetSubCategoryMasterById([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long subcategoryId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SubCategoryMasterBLL sample = new SubCategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.GetSubCategoryMasterById(subcategoryId);
                    objAction = CreatedAtAction("GetSubCategoryMasterById", Res);
                    return objAction;
                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetSubCategoryMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SubCategoryMasterResp data = new SubCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetSubCategoryMasterById", data);
                return objAction;
            }
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(SubCategoryMasterResp))]
        public IActionResult AddSubCategoryMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] SubCategoryMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SubCategoryMasterBLL sample = new SubCategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertSubCategoryMaster(samp);
                    objAction = CreatedAtAction("AddSubCategoryMaster", Res);
                    return objAction;
                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddSubCategoryMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SubCategoryMasterResp data = new SubCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSubCategoryMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(SubCategoryMasterResp))]
        public IActionResult UpdateSubCategoryMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long subcategoryId,[FromBody] SubCategoryMasterReq samp)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SubCategoryMasterBLL sample = new SubCategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateSubCategoryMaster(subcategoryId, samp);
                    objAction = CreatedAtAction("UpdateSubCategoryMaster", Res);
                    return objAction;

                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateSubCategoryMaster", data);
                return objAction;
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SubCategoryMasterResp data = new SubCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSubCategoryMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(SubCategoryMasterResp))]
        public IActionResult DeleteSubCategoryMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, long subcategoryId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.SubCategoryMasterBLL sample = new SubCategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteSubCategoryMaster(subcategoryId);
                    objAction = CreatedAtAction("DeleteSubCategoryMaster", Res);
                    return objAction;

                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteSubCategoryMaster", data);
                return objAction;               

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SubCategoryMasterResp data = new SubCategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSubCategoryMaster", data);
                return objAction;
            }
        }

    }
}
