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


namespace Service.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CategoryMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult CreateCategoryMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] CategoryMasterReq samp)
        {
            try
            {
             
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {

                    CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                    var isCheckCategoryName = sample.CategoryNameExistsInDatabase(samp);
                    if (isCheckCategoryName.CategoryMasterDetailByID != null)
                    {
                        return CreatedAtAction("CreateCategoryMaster", isCheckCategoryName);
                    }

                    // Category name doesn't exist, proceed with insertion
                    var Res = sample.InsertCategoryMaster(samp);
                    objAction = CreatedAtAction("CreateCategoryMaster", Res);


                    return objAction;
                }

                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateCategoryMaster", data);
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
        public IActionResult UpdateCategoryMaster(
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromBody] CategoryMasterReq samp, [FromQuery] long categoryId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
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



        [HttpGet("allcategory")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult GetAllCategoryMaster(
            int pageNo = 1, int limit = 10, string? searchKey = null, string? categoryName = null)
        {
            try
            {
                //ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                //if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                //{
                    CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                    var Res = sample.GetAllCategoryMaster(pageNo, limit, searchKey, categoryName);
                    objAction = CreatedAtAction("GetAllCategoryMaster", Res);
                   return objAction;
                //}

                //CategoryMasterResp data = new CategoryMasterResp()
                //{
                //    status = false,
                //    Message = modelAuth.message
                //};
                //objAction = CreatedAtAction("GetAllCategoryMaster", data);
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

               /* ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {*/
                    CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                    var Res = sample.GetCategoryMasterById(categoryId);
                    objAction = CreatedAtAction("GetCategoryMasterById", Res);
                    return objAction;
                /*}

                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetCategoryMasterById", data);
                return objAction;*/
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
        public IActionResult DeleteCategoryMaster([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] long categoryId)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
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


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult UploadCategoryMasterFile([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, IFormFile? signature)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    if (signature == null)
                    {
                        return BadRequest(new { status = 404, message = "File is required", data = false });
                    }

                    var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Category_Image");
                    if (!Directory.Exists(uploadDirectory))
                    {
                        Directory.CreateDirectory(uploadDirectory);
                    }

                    var randomKey = GenerateRandomString(10);
                    var newFileName = randomKey + "_" + signature.FileName;

                    var filePath = Path.Combine(uploadDirectory, newFileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        signature.CopyTo(stream);
                    }
                    var base_url = $"/Category_Image/{newFileName}";

                    objAction = CreatedAtAction("UploadCategoryMasterFile", new
                    {
                        status = true,
                        Message = "File upload successfully",
                        Data = base_url
                    });
                    return objAction;
                }

                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UploadCategoryMasterFile", data);
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
                objAction = CreatedAtAction("UploadCategoryMasterFile", data);
                return objAction;
            }
        }
        string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }




        [HttpGet("allcategoryWithCategoryType")]
        [Produces("application/json", Type = typeof(CategoryMasterResp))]
        public IActionResult GetCategoryMasterWithCategoryType([FromHeader] long Token_ID,
            [FromHeader] string Token_Data, [FromQuery] string? categoryType , long? categoryId = null)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "DELETE"))
                {
                    CategoryMasterBLL sample = new CategoryMasterBLL(DBConnStr);
                    var Res = sample.GetCategoryMasterWithCategoryType(categoryType , categoryId);
                    objAction = CreatedAtAction("GetCategoryMasterWithCategoryType", Res);
                    return objAction;
                }

                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetCategoryMasterWithCategoryType", data);
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
                objAction = CreatedAtAction("GetCategoryMasterWithCategoryType", data);
                return objAction;
            }
        }

    }
}
