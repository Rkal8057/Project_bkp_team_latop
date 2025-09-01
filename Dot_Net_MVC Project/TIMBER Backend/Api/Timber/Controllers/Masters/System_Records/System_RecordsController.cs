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
    public class System_RecordsController : ControllerBase
    {
        IConfiguration Configurations;
        string DBConnStr;
        private IActionResult objAction;

        public System_RecordsController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
        }

        [HttpPost("AddSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult AddSystem_Records([FromBody] System_Records_ModelRequest samp)

        {
            try
            {
                System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);

                var Res = sample.InsertSystem_Records(samp);
                objAction = CreatedAtAction("AddSystem_Records", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("AddSystem_Records", data);
                return objAction;
            }
        }

        [HttpGet("GetSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult GetSystem_Records([FromQuery] string? searchItem)
        {
            try
            {

                System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                var Res = sample.GetSystem_Records(searchItem);

                objAction = CreatedAtAction("GetSystem_Records", Res);
                return objAction;

                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetSystem_Records", data);
                return objAction;
            }
        }


        [HttpGet("GetSystem_RecordsById")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult GetSystem_RecordsById()
        {
            try
            {

                System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                var Res = sample.GetSystem_RecordsById();

                objAction = CreatedAtAction("GetSystem_RecordsById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetSystem_RecordsById", data);
                return objAction;
            }
        }


        [HttpPut("UpdateSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult UpdateSystem_Records( int id,[FromBody] System_Records_ModelRequest samp )
        {
            try
            {

                System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);

                var Res = sample.UpdateSystem_Records(id, samp);
                objAction = CreatedAtAction("UpdateSystem_Records", Res);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateSystem_Records", data);
                return objAction;
            }
        }

        [HttpDelete("DeleteSystem_Records")]
        [Produces("application/json", Type = typeof(System_Records_ModelRequest))]
        public IActionResult DeleteSystem_Records(int id )
        {
            try
            {

                System_RecordsBLL sample = new System_RecordsBLL(DBConnStr);
                var Res = sample.DeleteSystem_Records(id);
                objAction = CreatedAtAction("DeleteSystem_Records", Res);
                return objAction;


                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System_Records_ModelResponse data = new System_Records_ModelResponse()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteSystem_Records", data);
                return objAction;
            }
        }
    }

}
