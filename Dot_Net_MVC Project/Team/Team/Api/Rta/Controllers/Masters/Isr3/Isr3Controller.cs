using DB.Login;
using DB.Login.Tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RTA.Masters;
using RTA.Masters.Models;
namespace Rta.Controllers.Masters.Isr3
{
    [Route("api/[controller]")]
    [ApiController]
    public class Isr3Controller : Controller
    {
        private IConfiguration Configurations;
        private string DBConnStr;
        //private CommonAuth commonAuth;
        private IActionResult objAction;
        private loginDBContext LoginDB;

        public Isr3Controller(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);

            //commonAuth = new CommonAuth(DBConnStr);
        }
        [HttpPost("CreateIsr3")]
        [Produces("application/json", Type = typeof(ModelIsr3Resp))]
        public IActionResult CreateIsr3([FromBody] ModelIsr3Req Data)
        {
            try
            {
               
                Isr3BLL rb = new Isr3BLL(DBConnStr);
                var Res = rb.InsertIsr3(Data);
                objAction = CreatedAtAction("CreateIsr3", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelIsr3Resp data = new ModelIsr3Resp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateIsr3", data);
                return objAction;
            }
        }


    }
}
