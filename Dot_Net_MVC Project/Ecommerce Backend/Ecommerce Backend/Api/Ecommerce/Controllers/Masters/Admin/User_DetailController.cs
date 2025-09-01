//using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DB.Login;
using DB.Login.Tables;
using RTA.Admin;
using RTA.Admin.Models;
using RTAAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RTA.Common.Models;
using RTA.Masters.Models;
using RTA.Masters;

namespace Rta.Controllers.Admin
{
    //[Authorize]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class User_DetailController : ControllerBase
    {
        IConfiguration Configurations;
        string DBConnStr;
        private loginDBContext LoginDB;
        private CommonAuth commonAuth;
        private IActionResult objAction;

        public User_DetailController(IConfiguration config)
        {
            Configurations = config;
            DBConnStr = RTAAPI.DB.GetDBCred(Configurations);
            commonAuth = new CommonAuth(DBConnStr);
        }

        //GET ALL RECORDS
        [HttpGet("GetUsers")]
        [Produces("application/json", Type = typeof(List<User_Detail>))]
        public IActionResult GetTblRecords(
               [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
            )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = um.GetUsers();
                    IActionResult objAction = CreatedAtAction("GetTblRecords", Res);
                    return objAction;
                }
                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error : " + ex.Message);
            }
        }


        //Login
        [HttpPost("Login")]
        [Produces("application/json", Type = typeof(ModelLoginResp))]
        [Consumes("application/json")]
        public IActionResult Login(
            [FromBody] ModelLoginReq LoginReq)
        {
            try
            {
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                var Res = um.Login(LoginReq);
                IActionResult objAction = CreatedAtAction("Login", Res);
                return objAction;
            }
            catch (Exception ex)
            {
                ModelLoginResp Res = new ModelLoginResp()
                {
                    status = false,
                    ErrorMessage = ex.Message
                };
                IActionResult objAction = CreatedAtAction("Login", Res);
                return objAction;
            }
        }


        // [HttpPost("Save_User")]
        // [Produces("application/json", Type = typeof(ModelUserResp))]
        // [Consumes("application/json")]
        // public IActionResult Save_User([FromBody] ModelUserReq User_Detail)
        // {
        //     try
        //     {
        //         RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
        //         um.New_User(User_Detail);
        //         IActionResult objAction = CreatedAtAction("Save_User", "success");
        //         return objAction;

        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine(ex.Message);
        //         ModelUserResp data = new ModelUserResp()
        //         {
        //             status = false,
        //             Message = ex.InnerException.Message
        //         };
        //         IActionResult objAction = CreatedAtAction("Save_User", data);
        //         return objAction;
        //     }

        // }

        [HttpGet("GetUserById")]
        [Produces("application/json", Type = typeof(ModelUserResp))]
        [Consumes("application/json")]
        public IActionResult GetUserById(
            [FromQuery] long Id,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data
            )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                ModelUserResp Res = new ModelUserResp();

                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {

                    RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                    Res = um.GetUserById(Id);
                    objAction = CreatedAtAction("GetUserById", Res);
                    return objAction;
                }
                Res = new ModelUserResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("GetUserById", Res);
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserResp data = new ModelUserResp()
                {
                    status = false,
                    Message = ex.InnerException.Message
                };
                IActionResult objAction = CreatedAtAction("GetUserById", data);
                return objAction;
            }

        }

        [HttpPost("Edit_User")]
        [Produces("application/json", Type = typeof(ModelUserResp))]
        [Consumes("application/json")]
        public IActionResult Edit_User(
            [FromHeader] long Id,
            [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            [FromBody] ModelUserReq UserReq
            )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);

                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                um.Edit_User(Id, UserReq);
                IActionResult objAction = CreatedAtAction("Edit_User", "success");
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserResp data = new ModelUserResp()
                {
                    status = false,
                    Message = ex.InnerException.Message
                };
                IActionResult objAction = CreatedAtAction("Edit_User", data);
                return objAction;
            }

        }

        [HttpPost("Save_User_Pofile")]
        [Produces("application/json", Type = typeof(ModelUserResp))]
        [Consumes("application/json")]
        public IActionResult Save_User_Pofile([FromBody] User_Profile_Master User_Profile_Master)
        {
            try
            {
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                um.New_User_Profile_Role(User_Profile_Master);
                IActionResult objAction = CreatedAtAction("Save_User_Pofile", "success");
                return objAction;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserResp data = new ModelUserResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("Save_User_Pofile", data);
                return objAction;
            }

        }

        [HttpPost("InsertRegistration")]
        [Produces("application/json", Type = typeof(ModelRegistrationResp))]
        [Consumes("application/json")]
        public IActionResult InsertRegistration([FromBody] ModelRegistrationReq res)
        {
            try
            {
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                var Registration = um.InsertRegistration(res);
                IActionResult objAction = CreatedAtAction("InsertRegistration", Registration);
                return objAction;
            }
            catch (Exception ex)
            {
                ModelRegistrationResp Res = new ModelRegistrationResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("InsertRegistration", Res);
                return objAction;
            }
        }

        // [HttpGet("ValidateMobileOTP")]
        // [Produces("application/json")]
        // [Consumes("application/json")]
        // public IActionResult ValidateMobileOTP(long mobile, string otp)
        // {
        //     try
        //     {
        //         RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
        //         var Registration = um.ValidateMobileOTP(mobile, otp);
        //         IActionResult objAction = CreatedAtAction("ValidateMobileOTP", Registration);
        //         return objAction;
        //     }
        //     catch (Exception ex)
        //     {
        //         ModelRegistrationResp res = new ModelRegistrationResp()
        //         {
        //             status = false,
        //             Message = ex.Message
        //         };
        //         IActionResult objAction = CreatedAtAction("ValidateMobileOTP", res);
        //         return objAction;
        //     }
        // }


        [HttpGet("ValidateEmailOTP")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult ValidateEmailOTP(string email, string otp)
        {
            try
            {
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                var Registration = um.ValidateEmailOTP(email, otp);
                IActionResult objAction = CreatedAtAction("ValidateEmailOTP", Registration);
                return objAction;
            }
            catch (Exception ex)
            {
                ModelRegistrationResp res = new ModelRegistrationResp()
                {
                    status = false,
                    Message = "Internal servor error"
                };
                IActionResult objAction = CreatedAtAction("ValidateEmailOTP", res);
                return objAction;
            }
        }

        [HttpGet("GenerateOTP")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult GenerateOTP(string email, string otp_purpose)
        {
            try
            {
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                var Registration = um.GenerateOTP(email, otp_purpose);
                IActionResult objAction = CreatedAtAction("GenerateOTP", Registration);
                return objAction;
            }
            catch (Exception ex)
            {
                ModelRegistrationResp res = new ModelRegistrationResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GenerateOTP", res);
                return objAction;
            }
        }

        // [HttpGet("ValidateEmailByLink")]
        // [Produces("application/json")]
        // [Consumes("application/json")]
        // public IActionResult ValidateEmailByLink(string email)
        // {
        //     try
        //     {
        //         RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
        //         var valemail = um.ValidateEmailByLink(email);
        //         IActionResult objAction = CreatedAtAction("ValidateEmailByLink", valemail);
        //         return objAction;
        //     }
        //     catch (Exception ex)
        //     {
        //         ModelRegistrationResp res = new ModelRegistrationResp()
        //         {
        //             status = false,
        //             Message = ex.Message
        //         };
        //         IActionResult objAction = CreatedAtAction("ValidateEmailByLink", res);
        //         return objAction;
        //     }
        // }

        // [HttpGet("VerifyEmailByotp")]
        // [Produces("application/json")]
        // [Consumes("application/json")]
        // public IActionResult VerifyEmailByotp(string email, string otp, long id)
        // {
        //     try
        //     {
        //         RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
        //         var valemail = um.VerifyEmailByotp(email, otp, id);
        //         IActionResult objAction = CreatedAtAction("VerifyEmailByotp", valemail);
        //         return objAction;
        //     }
        //     catch (Exception ex)
        //     {
        //         ModelRegistrationResp res = new ModelRegistrationResp()
        //         {
        //             status = false,
        //             Message = ex.Message
        //         };
        //         IActionResult objAction = CreatedAtAction("VerifyEmailByotp", res);
        //         return objAction;
        //     }
        // }

        // //[HttpGet("CreatePassword")]
        //[Produces("application/json")]
        //[Consumes("application/json")]
        //public IActionResult CreatePassword(string password, string email)
        //{
        //    try
        //    {
        //        RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
        //        var valemail = um.CreatePassword(password, email);
        //        IActionResult objAction = CreatedAtAction("CreatePassword", valemail);
        //        return objAction;
        //    }
        //    catch (Exception ex)
        //    {
        //        ModelRegistrationResp res = new ModelRegistrationResp()
        //        {
        //            status = false,
        //            Message = ex.Message
        //        };
        //        IActionResult objAction = CreatedAtAction("CreatePassword", res);
        //        return objAction;
        //    }
        //}

        [HttpGet("ForgotPassword")]
        [Produces("application/json")]
        [Consumes("application/json")]
        public IActionResult ForgotPassword(string password, string confirmPassword, string email, string otp)
        {
            try
            {
                RTA.Admin.UsersMstBLL um = new RTA.Admin.UsersMstBLL(DBConnStr);
                var valemail = um.ForgotPassword(password, confirmPassword, email, otp);
                IActionResult objAction = CreatedAtAction("ForgotPassword", valemail);
                return objAction;
            }
            catch (Exception ex)
            {
                ModelRegistrationResp res = new ModelRegistrationResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("ForgotPassword", res);
                return objAction;
            }
        }


        [HttpPost("AddMultiAddress")]
        [Produces("application/json", Type = typeof(ModelUserMultiAddResp))]
        public IActionResult AddUserMultiAddress(
      [FromHeader] long Token_ID,
     [FromHeader] string Token_Data,
     [FromBody] ModelUserMultiAddReq samp)

        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Admin.UsersMstBLL sample = new RTA.Admin.UsersMstBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "VIEW"))
                {

                    var Res = sample.InsertUserMultiAddress(samp);
                    objAction = CreatedAtAction("AddUserMultiAddress", Res);
                    return objAction;
                }
                ModelUserMultiAddResp data = new ModelUserMultiAddResp()
                {
                    status = false,
                    Message = "USER DONT HAVE RIGHTSS"
                };
                objAction = CreatedAtAction("AddUserMultiAddress", samp);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserMultiAddResp data = new ModelUserMultiAddResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("AddUserMultiAddress", data);
                return objAction;
            }
        }

        [HttpGet("GetUserMultiAddress")]
        [Produces("application/json", Type = typeof(ModelUserMultiAddResp))]
        public IActionResult GetUserMultiAddress(
              [FromHeader] long Token_ID,
              [FromHeader] long User_id,
              [FromHeader] string Token_Data
   )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Admin.UsersMstBLL sample = new RTA.Admin.UsersMstBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "VIEW"))
                {
                    var Res = sample.GetUserMultiAddress(User_id);

                    objAction = CreatedAtAction("GetUserMultiAddress", Res);
                    return objAction;
                }
                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserMultiAddResp data = new ModelUserMultiAddResp()
                {
                    status = false,
                    Message = ex.Message
                };
                IActionResult objAction = CreatedAtAction("GetUserMultiAddress", data);
                return objAction;
            }
        }


        [HttpPut("UpdateUserMultiAdd")]
        [Produces("application/json", Type = typeof(ModelUserMultiAddResp))]
        public IActionResult UpdateUserMultiAdd(
             [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int id,
       [FromBody] ModelUserMultiAddReq samp
       )
        {
            try
            {
                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Admin.UsersMstBLL sample = new RTA.Admin.UsersMstBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.UpdateUserMultiAdd(id, samp);
                    objAction = CreatedAtAction("UpdateUserMultiAdd", Res);
                    return objAction;

                }
                ModelUserMultiAddResp data = new ModelUserMultiAddResp()
                {
                    status = false,
                    Message = modelAuth.message
                };
                objAction = CreatedAtAction("UpdateUserMultiAdd", samp);
                return objAction;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserMultiAddResp data = new ModelUserMultiAddResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("UpdateUserMultiAdd", data);
                return objAction;
            }
        }

        [HttpDelete("DeletUserMulAdd")]
        [Produces("application/json", Type = typeof(ModelUserMultiAddResp))]
        public IActionResult DeletUserMulAdd(
              [FromHeader] long Token_ID,
            [FromHeader] string Token_Data,
            int id
        )
        {
            try
            {

                ModelAuth modelAuth = commonAuth.Login_Auth(Token_ID, Token_Data);
                RTA.Admin.UsersMstBLL sample = new RTA.Admin.UsersMstBLL(DBConnStr);
                if (commonAuth.VerifyFormRights(modelAuth, 1, "REPORT"))
                {
                    var Res = sample.DeletUserMulAdd(id);
                    objAction = CreatedAtAction("DeletUserMulAdd", Res);
                    return objAction;
                }

                throw new Exception("User doesnot have rights");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ModelUserMultiAddResp data = new ModelUserMultiAddResp()
                {
                    status = false,
                    Message = ex.Message
                };
                objAction = CreatedAtAction("DeletUserMulAdd", data);
                return objAction;
            }
        }
    }
}
