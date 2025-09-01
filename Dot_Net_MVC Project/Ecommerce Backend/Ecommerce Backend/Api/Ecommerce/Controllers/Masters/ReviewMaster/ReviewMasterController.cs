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
using Microsoft.AspNetCore.Authorization;
using RTA.Common.Models;

namespace Rta.Controllers.Masters
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReviewMasterController : Controller
    {


        private IConfiguration Configurations;
        private string DBConnStr;
        private IActionResult objAction;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;

        public ReviewMasterController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);

        }


        [HttpPost("allreview")]
        [Produces("application/json", Type = typeof(ReviewMasterResp))]
        public IActionResult GetReviewMaster()
        {
            try
            {
                RTA.Masters.ReviewMasterBLL sample = new ReviewMasterBLL(DBConnStr);
                var Res = sample.GetReviewMaster();
                objAction = CreatedAtAction("GetReviewMaster", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetReviewMaster", data);
                return objAction;
            }
        }


        [HttpGet("reviewDetail")]
        [Produces("application/json", Type = typeof(ReviewMasterResp))]
        public IActionResult GetReviewMasterById(long reviewId)
        {
            try
            {
                RTA.Masters.ReviewMasterBLL sample = new ReviewMasterBLL(DBConnStr);
                var Res = sample.GetReviewMasterById(reviewId);
                objAction = CreatedAtAction("GetReviewMasterById", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("GetReviewMasterById", data);
                return objAction;
            }
        }

        [HttpPost("create")]
        [Produces("application/json", Type = typeof(ReviewMasterResp))]
        public IActionResult AddReviewMaster([FromBody] ReviewMasterReq samp
            ,[FromHeader] long Token_ID,
            [FromHeader] string Token_Data
            )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ReviewMasterBLL sample = new ReviewMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.InsertReviewMaster(samp);
                    objAction = CreatedAtAction("AddReviewMaster", Res);
                    return objAction;
                }

                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("AddReviewMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("AddReviewMaster", data);
                return objAction;
            }
        }


        [HttpPut("update")]
        [Produces("application/json", Type = typeof(ReviewMasterResp))]
        public IActionResult UpdateReviewMaster(long reviewId, 
            [FromBody] ReviewMasterReq samp, [FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
             
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ReviewMasterBLL sample = new ReviewMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateReviewMaster(reviewId, samp);
                    objAction = CreatedAtAction("UpdateReviewMaster", Res);
                    return objAction;
                }

                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateReviewMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateReviewMaster", data);
                return objAction;
            }
        }


        [HttpDelete("delete")]
        [Produces("application/json", Type = typeof(ReviewMasterResp))]
        public IActionResult DeleteReviewMaster(long reviewId,[FromHeader] long Token_ID,
            [FromHeader] string Token_Data)
        {
            try
            {
               
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Masters.ReviewMasterBLL sample = new ReviewMasterBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    var Res = sample.DeleteReviewMaster(reviewId);
                    objAction = CreatedAtAction("DeleteReviewMaster", Res);
                    return objAction;
                }

                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("DeleteReviewMaster", data);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ReviewMasterResp data = new ReviewMasterResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeleteReviewMaster", data);
                return objAction;
            }
        }
    }
}