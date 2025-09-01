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


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CategoryMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult CreateCategoryMaster([FromBody] CategoryMasterReq samp)
        {
            try
            {
                CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                var Res = sample.InsertCategoryMaster(samp);
                objAction = CreatedAtAction("CreateCategoryMaster", Res);
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
                objAction = CreatedAtAction("CreateCategoryMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult DeleteCategoryMaster([FromQuery] long id)
        {
            try
            {
                CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                var Res = sample.DeleteCategoryMaster(id);
                objAction = CreatedAtAction("DeleteCategoryMaster", Res);
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
