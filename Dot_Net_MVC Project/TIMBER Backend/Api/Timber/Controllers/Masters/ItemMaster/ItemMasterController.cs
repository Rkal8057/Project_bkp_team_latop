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
    public class ItemMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public ItemMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult CreateItemMaster([FromBody] ItemMasterReq samp)
        {
            try
            {


                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);

                var isCheckItemName = sample.ItemNameExistsInDatabase(samp);
                if (isCheckItemName.ItemMasterDetailByID != null)
                {
                    return CreatedAtAction("CreateItemMaster", isCheckItemName);
                }


                var Res = sample.InsertItemMaster(samp);
                objAction = CreatedAtAction("CreateItemMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateItemMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult UpdateItemMaster([FromBody] ItemMasterReq samp, [FromQuery] long itemId)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.UpdateItemMaster(itemId, samp);
                objAction = CreatedAtAction("UpdateItemMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateItemMaster", data);
                return objAction;
            }
        }


        [HttpGet("allitem")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult GetAllItemMaster(int pageNo=1, int limit=10, string? searchKey = null)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.GetAllItemMaster(pageNo, limit,searchKey);
                objAction = CreatedAtAction("GetAllItemMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetAllItemMaster", data);
                return objAction;
            }
        }


        [HttpGet("itemDetailById")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult GetItemMasterByItemId(long itemId)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.GetItemMasterByItemId( itemId);
                objAction = CreatedAtAction("GetItemMasterByItemId", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetItemMasterByItemId", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult CheckDeleteItemMasterIfExitInMaster([FromQuery] long itemId, string Masterflag)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.CheckDeleteItemMasterIfExitInMaster(itemId,Masterflag);
                objAction = CreatedAtAction("CheckDeleteItemMasterIfExitInMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CheckDeleteItemMasterIfExitInMaster", data);
                return objAction;
            }
        }



        [HttpDelete("deleteAllItemRelatedData")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult DeleteItemMasterRelatedData(string Masterflag, long Id, long otp)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.DeleteItemMaster(Masterflag, Id, otp);
                objAction = CreatedAtAction("DeleteItemMasterRelatedData", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ItemMasterResp data = new ItemMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteItemMasterRelatedData", data);
                return objAction;
            }
        }
    }
}
