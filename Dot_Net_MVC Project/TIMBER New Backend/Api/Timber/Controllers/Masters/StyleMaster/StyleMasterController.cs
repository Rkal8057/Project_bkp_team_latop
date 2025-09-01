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
    public class StyleMasterController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public StyleMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }


        [HttpGet("allstyle")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult GetStyleMaster()
        {
            try
            {
                RTA.Masters.StyleMasterBLL sample = new StyleMasterBLL(DBConnStr);
                var Res = sample.GetStyleMaster();
                objAction = CreatedAtAction("GetStyleMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetStyleMaster", data);
                return objAction;
            }
        }


        [HttpGet("allstylebyid")]
        [Produces("application/json", Type = typeof(SliderMasterResp))]
        public IActionResult GetStyleMasterById(long styleId)
        {
            try
            {
                RTA.Masters.StyleMasterBLL sample = new StyleMasterBLL(DBConnStr);
                var Res = sample.GetStyleMasterById(styleId);
                objAction = CreatedAtAction("GetStyleMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                SliderMasterResp data = new SliderMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetStyleMaster", data);
                return objAction;
            }
        }


        [HttpPost("create")]
        [Produces("application/json", Type = typeof(StyleMasterResp))]
        public IActionResult CreateStyleMaster([FromBody] StyleMasterReq samp)
        {
            try
            {
                RTA.Masters.StyleMasterBLL sample = new StyleMasterBLL(DBConnStr);
                var Res = sample.InsertStyleMaster(samp);
                objAction = CreatedAtAction("CreateStyleMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                StyleMasterResp data = new StyleMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateStyleMaster", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(StyleMasterResp))]
        public IActionResult UpdateStyleMaster([FromBody] StyleMasterReq samp , long styleId)
        {
            try
            {
                RTA.Masters.StyleMasterBLL sample = new StyleMasterBLL(DBConnStr);
                var Res = sample.UpdateStyleMaster(styleId, samp);
                objAction = CreatedAtAction("UpdateStyleMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                StyleMasterResp data = new StyleMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateStyleMaster", data);
                return objAction;
            }
        }



        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(StyleMasterResp))]
        public IActionResult DeleteStyleMaster([FromQuery] long styleId)
        {
            try
            {
               
                RTA.Masters.StyleMasterBLL sample = new StyleMasterBLL(DBConnStr);
                var Res = sample.DeleteStyleMaster(styleId);
                objAction = CreatedAtAction("DeleteStyleMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                StyleMasterResp data = new StyleMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteStyleMaster", data);
                return objAction;
            }
        }

    }
}
