using DB.Login;
using DB.Login.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RTA.Masters;
using RTA.Masters.Models;

namespace Rta.Controllers.Masters.Sh13
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sh13Controller : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public Sh13Controller(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);

            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("CreateSh13")]
        [Produces("application/json", Type = typeof(ModelSh13Resp))]
        public IActionResult CreateSh13([FromBody] ModelSh13Req Data)
        {
            try
            {

                Sh13BLL rb = new Sh13BLL(DBConnStr);
                var Res = rb.InsertSh13(Data);
                objAction = CreatedAtAction("CreateSh13", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelSh13Resp data = new ModelSh13Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateSh13", data);
                return objAction;
            }
        }
    }
}
