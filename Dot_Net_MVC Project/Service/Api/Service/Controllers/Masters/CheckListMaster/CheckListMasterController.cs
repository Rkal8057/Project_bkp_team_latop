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
    public class CheckListMasterController : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public CheckListMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            //commonAuth = new CommonAuth(DBConnStr);
        }

        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(CheckListMasterResp))]
        public IActionResult DeleteCheckListMaster([FromQuery] long id)
        {
            try
            {
                CheckListMasterBLL sample = new CheckListMasterBLL(DBConnStr);
                var Res = sample.DeleteCheckListMaster(id);
                objAction = CreatedAtAction("DeleteCheckListMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CheckListMasterResp data = new CheckListMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteCheckListMaster", data);
                return objAction;
            }
        }



        [HttpPut("update")]
        [Produces("application/json", Type = typeof(CheckListMasterResp))]
        public IActionResult UpdateCheckListMaster([FromQuery]int id, string? document_required_name , string? document_required_type)
        {
            try
            {
                CheckListMasterBLL sample = new CheckListMasterBLL(DBConnStr);
                var Res = sample.UpdateCheckListMaster(id, document_required_name, document_required_type);
                objAction = CreatedAtAction("UpdateCheckListMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CheckListMasterResp data = new CheckListMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateCheckListMaster", data);
                return objAction;
            }
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(CheckListMasterResp))]
        public IActionResult AddCheckListMaster( [FromBody] List<CheckListMasterReq> samp )
        {
            try
            {       
                CheckListMasterBLL sample = new CheckListMasterBLL(DBConnStr);
                var Res = sample.InsertCheckListMaster(samp);
                objAction = CreatedAtAction("AddCheckListMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                CheckListMasterResp data = new CheckListMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddCheckListMaster", data);
                return objAction;
            }
        }
    }
}
