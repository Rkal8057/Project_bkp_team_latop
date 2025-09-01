using DB.Login;
using DB.Login.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RTA.Masters;
using RTA.Masters.Models;

namespace Rta.Controllers.Masters.Sh14
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sh14Controller : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public Sh14Controller(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);

            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("CreateSh14")]
        [Produces("application/json", Type = typeof(ModelSh14Resp))]
        public IActionResult CreateSh14([FromBody] ModelSh14Req Data)
        {
            try
            {

                Sh14BLL rb = new Sh14BLL(DBConnStr);
                var Res = rb.InsertSh14(Data);
                objAction = CreatedAtAction("CreateSh14", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSh14Resp data = new ModelSh14Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateSh14", data);
                return objAction;
            }
        }
    }
}
