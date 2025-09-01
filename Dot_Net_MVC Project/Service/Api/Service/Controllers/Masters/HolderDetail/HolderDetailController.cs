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

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class HolderDetailController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public HolderDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpGet("detail")]
        [Produces("application/json", Type = typeof(HolderDetailResp))]
        public IActionResult GetHolderDetail([FromQuery]  int pageNo=1, int limit=10, string? searchKey = null)
        {
            try
            {
             
                HolderDetailBLL sample = new HolderDetailBLL(DBConnStr);
                var Res = sample.GetHolderDetail(pageNo,limit,searchKey);
                objAction = CreatedAtAction("GetHolderDetail", Res);
                return objAction;
          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HolderDetailResp data = new HolderDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetHolderDetail", data);
                return objAction;
            }
        }


        [HttpGet("detailById")]
        [Produces("application/json", Type = typeof(HolderDetailResp))]
        public IActionResult GetHolderDetailByID(int id)
        {
            try
            {

                RTA.Masters.HolderDetailBLL sample = new HolderDetailBLL(DBConnStr);
                var Res = sample.GetHolderDetailByID(id);
                objAction = CreatedAtAction("GetHolderDetailByID", Res);
                return objAction;
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HolderDetailResp data = new HolderDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetHolderDetailByID", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(HolderDetailResp))]
        public IActionResult AddSampleMaster( [FromBody] HolderDetailReq samp)
        {
            try
            {
                    
                RTA.Masters.HolderDetailBLL sample = new HolderDetailBLL(DBConnStr);
                var Res = sample.InsertHolderDetail(samp);
                objAction = CreatedAtAction("AddSampleMaster", Res);
                return objAction;
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HolderDetailResp data = new HolderDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSampleMaster", data);
                return objAction;
            }
        }

        [HttpPut("update")]
        [Produces("application/json", Type = typeof(HolderDetailResp))]
        public IActionResult UpdateSampleMaster(int id,[FromBody] HolderDetailReq samp)
        {
            try
            {

                RTA.Masters.HolderDetailBLL sample = new HolderDetailBLL(DBConnStr);
                var Res = sample.UpdateHolderDetail(id, samp);
                objAction = CreatedAtAction("UpdateSampleMaster", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HolderDetailResp data = new HolderDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSampleMaster", data);
                return objAction;
            }
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(HolderDetailResp))]
        public IActionResult DeleteSampleMaster(int id)
        {
            try
            {
            
                RTA.Masters.HolderDetailBLL inwaard = new HolderDetailBLL(DBConnStr);
                var Res = inwaard.DeleteHolderDetail(id);
                objAction = CreatedAtAction("DeleteSampleMaster", Res);
                return objAction;
                //}
                //throw new Exception ( "User doesnot have rights");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                HolderDetailResp data = new HolderDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddSampleMaster", data);
                return objAction;
            }
        }
    }
}
