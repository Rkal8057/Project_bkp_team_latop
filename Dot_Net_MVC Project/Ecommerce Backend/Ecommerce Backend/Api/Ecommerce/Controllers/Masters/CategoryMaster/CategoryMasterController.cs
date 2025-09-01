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
    public class CategoryMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public CategoryMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpGet("allcategory")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult GetCategoryMaster(
            // [FromHeader] long Token_ID,
            //[FromHeader] string Token_Data,
            string? searchKey = null
            )
        {
            try
            {

                //ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                //if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                //{
                    var Res = sample.GetCategoryMaster(searchKey);
                    objAction = CreatedAtAction("GetCategoryMaster", Res);
                    return objAction;
                //}
                //CategoryMasterResp data = new CategoryMasterResp()
                //{
                //    status = false,
                //    Message = modelAuth.message
                //};
                //objAction = CreatedAtAction("GetCategoryMaster", data);
                //return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCategoryMaster", data);
                return objAction;
            }
        }


        [HttpGet("categoryDetail")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult GetCategoryMasterById(long categoryId)
        {
            try
            {
                RTA.Masters.CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                var Res = sample.GetCategoryMasterById(categoryId);
                objAction = CreatedAtAction("GetCategoryMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetCategoryMasterById", data);
                return objAction;
            }
        }










        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult AddCategoryMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] CategoryMasterReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertCategoryMaster(samp);
                    objAction = CreatedAtAction("AddCategoryMaster", Res);
                    return objAction;
                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddCategoryMaster", data);
                return objAction;
              

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddCategoryMaster", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult UpdateCategoryMaster(long categoryId, [FromBody] CategoryMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
        )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateCategoryMaster(categoryId, samp);
                    objAction = CreatedAtAction("UpdateCategoryMaster", Res);
                    return objAction;
                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateCategoryMaster", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateCategoryMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult DeleteCategoryMaster(long categoryId,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
        )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteCategoryMaster(categoryId);
                    objAction = CreatedAtAction("DeleteCategoryMaster", Res);
                    return objAction;
                }
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteCategoryMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCategoryMaster", data);
                return objAction;
            }
        }

    }
}
