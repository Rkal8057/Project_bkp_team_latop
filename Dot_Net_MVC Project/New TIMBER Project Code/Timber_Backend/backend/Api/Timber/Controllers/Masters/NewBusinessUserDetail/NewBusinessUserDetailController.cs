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
using Microsoft.AspNetCore.WebUtilities;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Rta.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewBusinessUserDetailController : Controller
    {

        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private CommonAuth commonAuth;
        private loginDBContext LoginDB;

        public NewBusinessUserDetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }


        [HttpPost("createBussinessCard")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult CreateNewBusinessUserDetail([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] NewBusinessUserDetailReq samp)
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);

                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.CreateNewBusinessUserDetail(samp);
                    objAction = CreatedAtAction("CreateNewBusinessUserDetail", Res);
                    return objAction;
                }

                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("CreateNewBusinessUserDetail", data);
                return objAction;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("CreateNewBusinessUserDetail", data);
                return objAction;
            }
        }



        


        [HttpGet("BussinessCardByUserId")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult GetBusinessCardByuserId([FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            long buserId)
        {
            try
            {
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);

                var Res = sample.GetBusinessCardByuserId(buserId);
                objAction = CreatedAtAction("GetBusinessCardByuserId", Res);
                return objAction;
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessCardByuserId", data);
                return objAction;
            }
        }



        [HttpGet("GetBusinessCardWithSectionContentById")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult GetBusinessCardWithSectionContentById([FromHeader] long Token_ID,
          [FromHeader] string Token_Data,
          long BuserId)
        {
            try
            {
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);
                var Res = sample.GetBusinessCardWithSectionContentById(BuserId);
                objAction = CreatedAtAction("GetBusinessCardWithSectionContentById", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetBusinessCardWithSectionContentById", data);
                return objAction;
            }
        }



        [HttpPut("updateNewBussinessCard")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult UpdateNewBusinessUserDetail(NewBusinessUserDetailReq samp)
        {
            try
            {
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);
                var Res = sample.UpdateNewBusinessUserDetail(samp);
                objAction = CreatedAtAction("UpdateNewBusinessUserDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateNewBusinessUserDetail", data);
                return objAction;
            }
        }





        [HttpDelete("deleteNewBussinessCard")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult DeleteNewBusinessUserDetail(long tableId)
        {
            try
            {
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);
                var Res = sample.DeleteNewBusinessUserDetail(tableId);
                objAction = CreatedAtAction("DeleteNewBusinessUserDetail", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteNewBusinessUserDetail", data);
                return objAction;
            }
        }





        [HttpDelete("disableSection")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult DisableNewBusinessSection([FromHeader] long Token_ID,
           [FromHeader] string Token_Data, long sectionId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DisableNewBusinessSection(sectionId);
                    objAction = CreatedAtAction("DisableNewBusinessSection", Res);
                    return objAction;
                }

                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DisableNewBusinessSection", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DisableNewBusinessSection", data);
                return objAction;
            }
        }



        [HttpDelete("disableContent")]
        [Produces("application/json", Type = typeof(NewBusinessUserDetailResp))]
        public IActionResult DisableNewBusinessContent([FromHeader] long Token_ID,
           [FromHeader] string Token_Data, long contentId)
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.NewBusinessUserDetailBLL sample = new NewBusinessUserDetailBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DisableNewBusinessContent(contentId);
                    objAction = CreatedAtAction("DisableNewBusinessContent", Res);
                    return objAction;
                }

                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DisableNewBusinessContent", data);
                return objAction;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                NewBusinessUserDetailResp data = new NewBusinessUserDetailResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DisableNewBusinessContent", data);
                return objAction;
            }
        }



    }
}
