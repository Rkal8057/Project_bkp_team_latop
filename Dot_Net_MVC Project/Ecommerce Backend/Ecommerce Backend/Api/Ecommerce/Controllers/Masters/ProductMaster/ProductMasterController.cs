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
using Microsoft.AspNetCore.Authorization;
using RTA.Common.Models;

namespace Rta.Controllers.Masters
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public ProductMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }


        [HttpPost("allproduct")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult GetProductMaster(string? categorySearchKey, string? productSearchKey,string[]? searchKeys, string? subcategoryName, string? searchKeyData)
        {
            try
            {
                RTA.Masters.ProductMasterBLL sample = new ProductMasterBLL(DBConnStr);
                var Res = sample.GetProductMaster(categorySearchKey, productSearchKey, searchKeys, subcategoryName, searchKeyData);
                objAction = CreatedAtAction("GetProductMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetProductMaster", data);
                return objAction;
            }
        }


        [HttpGet("productDetail")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult GetProductMasterById(long productId )
        {
            try
            {
                RTA.Masters.ProductMasterBLL sample = new ProductMasterBLL(DBConnStr);
                var Res = sample.GetProductMasterById(productId);
                objAction = CreatedAtAction("GetProductMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetProductMasterById", data);
                return objAction;
            }
        }

        [HttpGet("relatedProduct")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult GetRelatedProduct(string subcategoryName, long productId)
        {
            try
            {
                RTA.Masters.ProductMasterBLL sample = new ProductMasterBLL(DBConnStr);
                var Res = sample.GetRelatedProduct(subcategoryName, productId);
                objAction = CreatedAtAction("GetRelatedProduct", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetRelatedProduct", data);
                return objAction;
            }
        }



        

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult AddProductMaster([FromBody] ProductMasterReq samp,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
            )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ProductMasterBLL sample = new ProductMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.InsertProductMaster(samp);
                    objAction = CreatedAtAction("AddProductMaster", Res);
                    return objAction;
                }

                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddProductMaster", data);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddProductMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult UpdateProductMaster(long productId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,[FromBody] ProductMasterReq samp)
        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ProductMasterBLL sample = new ProductMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateProductMaster(productId, samp);
                    objAction = CreatedAtAction("UpdateProductMaster", Res);
                    return objAction;
                }

                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateProductMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateProductMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult DeleteProductMaster(long productId, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
              
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ProductMasterBLL sample = new ProductMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeleteProductMaster(productId);
                    objAction = CreatedAtAction("DeleteProductMaster", Res);
                    return objAction;
                }

                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteProductMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteProductMaster", data);
                return objAction;
            }
        }


        [HttpPost("uploadfile")]
        [Produces("application/json", Type = typeof(ProductMasterResp))]
        public IActionResult UploadProductMasterFile(IFormFile? signature)
        {
            try
            {

                if (signature == null)
                {
                    return BadRequest(new { status = 404, message = "File is required", data = false });
                }

                var uploadDirectory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Product_Image");
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
                var base_url = $"{Configurations["BaseUrl"]}/Product_Image/{newFileName}";

                objAction = CreatedAtAction("UploadProductMasterFile", new
                {
                    status = true,
                    Message = "File upload successfully",
                    Data = base_url
                });
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ProductMasterResp data = new ProductMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UploadProductMasterFile", data);
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

    }
}
