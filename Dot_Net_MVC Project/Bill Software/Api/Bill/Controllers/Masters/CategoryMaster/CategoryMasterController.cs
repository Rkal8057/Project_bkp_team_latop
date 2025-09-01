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

                //CategoryMaster isCheckCategoryName = sample.CategoryNameExistsInDatabase();
                //if (isCheckCategoryName != null) {
                //    CategoryMasterResp data = new CategoryMasterResp()
                //    {
                //        status = false,
                //        Message = "Category name already exists in the database."
                //    };
                //    objAction = BadRequest(data); // Return a 400 Bad Request status
                //}

                
                
                // Category name doesn't exist, proceed with insertion
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

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult UpdateCategoryMaster([FromBody] CategoryMasterReq samp,[FromQuery] long categoryId)
        {
            try
            {
                CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                var Res = sample.UpdateCategoryMaster( categoryId ,samp);
                objAction = CreatedAtAction("UpdateCategoryMaster", Res);
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


        [HttpGet("allcategory")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult GetAllCategoryMaster(int pageNo =1, int limit =10, string? searchKey = null)
        {
            try
            {
                CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                var Res = sample.GetAllCategoryMaster(pageNo, limit, searchKey);
                objAction = CreatedAtAction("GetAllCategoryMaster", Res);
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
                objAction = CreatedAtAction("GetAllCategoryMaster", data);
                return objAction;
            }
        }



        [HttpGet("categorybyid")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult GetCategoryMasterById([FromQuery] long categoryId)
        {
            try
            {
                if (categoryId <= 0)
                {
                    return BadRequest(new { Status = false, Message = "categoryId is required", Data = false });
                }

                CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
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

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult DeleteCategoryMaster([FromQuery] long categoryId)
        {
            try
            {
                CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                var Res = sample.DeleteCategoryMaster(categoryId);
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
