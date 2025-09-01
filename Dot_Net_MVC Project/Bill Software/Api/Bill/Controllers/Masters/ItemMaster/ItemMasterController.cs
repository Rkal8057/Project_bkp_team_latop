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

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ItemMasterResp))]
        public IActionResult DeleteItemMaster([FromQuery] long itemId)
        {
            try
            {
                ItemMasterBLL sample = new ItemMasterBLL(DBConnStr);
                var Res = sample.DeleteItemMaster(itemId);
                objAction = CreatedAtAction("DeleteItemMaster", Res);
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
                objAction = CreatedAtAction("DeleteItemMaster", data);
                return objAction;
            }
        }
    }
}
