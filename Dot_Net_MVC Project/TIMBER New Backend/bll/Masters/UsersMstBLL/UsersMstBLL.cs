using System;
using DB.Login;
using DB.Login.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MailKit.Net.Smtp;
using MimeKit;
using RTA.Admin.Models;
using RTA.Common;
using RTA.Common.Models;
using System.Data;
using UsersMstBLL.Email;
using System.Reflection;

namespace RTA.Admin
{
    public class UsersMstBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public UsersMstBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
        public List<User_Detail> GetUsers()
        {
            return DB.User_Detail.Take(100).ToList();
        }

        public ModelUserResp GetUserById(long Id)
        {
            return new ModelUserResp()
            {
                status = true,
                Message = "user fetched successfully",
                User_Detail = DB.User_Detail.Where(x => x.id == Id).FirstOrDefault()
            };

        }

        private void Log_Data(User_Detail User)
        {
            User_Log_Master log_detail = new User_Log_Master()
            {
                log_user_name = User.user_name,
                log_user_id = User.id,
                log_user_type = User.user_profile,
                log_in_time = DateTime.Now
            };
            DB.User_Log_Master.Add(log_detail);
            DB.SaveChanges();

        }

        public ModelLoginResp Login(ModelLoginReq LoginReq)
        {
            ModelLoginResp Resp = new ModelLoginResp();
            IQueryable<User_Detail> query = DB.User_Detail.AsQueryable();

            if (query.Where(s => s.user_mobile == LoginReq.user_mobile).Count() == 0)
            {
                Resp.status = false;
                Resp.ErrorMessage = "Your Mobile no is not registered";
                return Resp;
            }

            if (query.Where(x => x.user_mobile == LoginReq.user_mobile && x.user_pass == LoginReq.user_pass).Count() == 0)
            {
                Resp.status = false;
                Resp.ErrorMessage = "Your Password is incorrect";
                return Resp;
            }

            if (query.Where(x => x.user_mobile == LoginReq.user_mobile && x.user_pass == LoginReq.user_pass && x.user_status == "ACTIVE").Count() == 0)
            {
                Resp.status = false;
                Resp.ErrorMessage = "This user has been deactivated";
                return Resp;
            }


            User_Detail user_Detail = query.Where(x => x.user_mobile == LoginReq.user_mobile && x.user_pass == LoginReq.user_pass && x.user_status == "ACTIVE").FirstOrDefault();


            if (user_Detail == null)
            {
                throw new Exception("The user does not exist");
            }

            ModelAuth modelAuth = new ModelAuth();

            // ModelLoginResp Resp = new ModelLoginResp()
            // {
            //     status = false,
            //     ErrorMessage = "Usercode or Password is incorrect"
            // };
            User_Profile_Master userProfileRight = DB.User_Profile_Master.Where(x => x.id == user_Detail.user_profile_id).FirstOrDefault();
            if (LoginReq.auth_type != "auth_type")
            {
                LoginReq.auth_type = "profile_type";
            }

            if (user_Detail != null)
            {

                if (LoginReq.auth_type == "profile_type")
                {
                    modelAuth.auth_type = "profile_type";
                    modelAuth.User = user_Detail;
                    modelAuth.UserProfileRights = userProfileRight;
                    Console.WriteLine("CHECK 1" + userProfileRight.save_yes_no);

                }


                if (LoginReq.auth_type == "user_type")
                {
                    modelAuth.auth_type = "user_type";
                    modelAuth.User = user_Detail;
                    modelAuth.UserRights = DB.Forms_Trx_Master.Where(x => x.user_id == user_Detail.id && (
                        x.save_yes_no == "YES" ||
                        x.delete_yes_no == "YES" ||
                        x.modify_yes_no == "YES" ||
                        x.print_only == "YES" ||
                        x.report_yes_no == "YES" ||
                        x.view_yes_no == "YES"
                    )).ToList();
                    //Console.WriteLine("CHECK" + modelAuth.UserRights);
                }

                Log_Data(user_Detail);
                Resp.status = true;
                Resp.ErrorMessage = "Login Successful";
                Resp.User = user_Detail;
            }

            AuthTokenBLL authTokenBLL = new AuthTokenBLL(DBConnStr);
            Resp.AuthToken = authTokenBLL.GenerateToken(modelAuth);
            return Resp;
        }


        private bool New_User(User_Registration_History User_Detail)
        {
            try
            {

                User_Profile_Master userProfile = DB.User_Profile_Master.Where(x => x.id == User_Detail.user_profile_id).FirstOrDefault();

                if (userProfile == null)
                {
                    return false;
                    throw new Exception("The user profile id is not correct or does not exist");
                }

                User_Detail nu = new User_Detail()
                {
                    user_code = User_Detail.user_mobile,
                    user_name = User_Detail.user_name,
                    user_pass = User_Detail.user_pass,
                    user_email = User_Detail.user_email,
                    user_email_pass = User_Detail.user_email_pass,
                    user_pancard = User_Detail.user_pancard,
                    user_mobile = User_Detail.user_mobile,
                    user_status = "ACTIVE",
                    software_version = User_Detail.software_version,
                    user_allotement_status = User_Detail.user_allotement_status,
                    user_profile_id = User_Detail.user_profile_id,
                    user_profile = userProfile.user_profile,
                    save_yes_no = userProfile.save_yes_no,
                    delete_yes_no = userProfile.delete_yes_no,
                    modify_yes_no = userProfile.modify_yes_no,
                    report_yes_no = userProfile.report_yes_no,
                    print_only = userProfile.print_only,
                    view_yes_no = userProfile.view_yes_no,
                    user_created_on = DateTime.Now,

                };

                //DB.SaveChanges();

                List<Forms_Master> frms = DB.Forms_Master.ToList();

                foreach (Forms_Master frm in frms)
                {
                    //Console.WriteLine("CHECKPOINT 4 user_id" );

                    Forms_Trx_Master ftm = new Forms_Trx_Master()
                    {

                        delete_yes_no = userProfile.delete_yes_no,
                        modify_yes_no = userProfile.modify_yes_no,
                        save_yes_no = userProfile.save_yes_no,
                        print_only = userProfile.print_only,
                        view_yes_no = userProfile.view_yes_no,
                        report_yes_no = userProfile.report_yes_no,
                        form_master_id = frm.id,
                    };
                    //Console.WriteLine("CHECKPOINT 3" + ftm);

                    nu.Forms_Trx_Masters.Add(ftm);

                    //Console.WriteLine("CHECKPOINT 4" + ftm);


                }
                DB.User_Detail.Add(nu);

                DB.SaveChanges();


                // Resp.status = true;
                // Resp.Message = "The user has been saved successfully";

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error : " + ex.Message);
                return false;
            }

        }


        public ModelUserResp New_User_Profile_Role(User_Profile_Master User_Profile_Master)
        {
            try
            {
                DB.User_Profile_Master.Add(User_Profile_Master);
                DB.SaveChanges();
                ModelUserResp Resp = new ModelUserResp()
                {
                    status = true,
                    Message = "The user role has been saved successfully"
                };

                return Resp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error : " + ex.Message);
            }

        }

        public ModelUserResp Edit_User(long Id, ModelUserReq UserReq)
        {
            try
            {
                AuthTokenBLL authTokenBLL = new AuthTokenBLL(DBConnStr);
                authTokenBLL.DeleteToken(UserReq.user_mobile);

                ModelUserResp Resp = new ModelUserResp();

                User_Profile_Master userProfile = DB.User_Profile_Master.Where(x => x.id == UserReq.user_profile_id).FirstOrDefault();

                if (userProfile == null)
                {
                    Resp.status = false;
                    Resp.Message = "The user profile id is not correct or does not exist";
                    throw new Exception("The user profile id is not correct or does not exist");
                }

                User_Detail editUser = new User_Detail()
                {
                    id = Id,
                    user_code = UserReq.user_mobile,
                    user_name = UserReq.user_name,
                    user_pass = UserReq.user_pass,
                    user_email = UserReq.user_email,
                    user_email_pass = UserReq.user_email_pass,
                    user_mobile = UserReq.user_mobile,
                    user_status = UserReq.user_status,
                    software_version = UserReq.software_version,
                    user_allotement_status = UserReq.user_allotement_status,
                    user_profile_id = UserReq.user_profile_id,
                    user_profile = userProfile.user_profile,
                    save_yes_no = userProfile.save_yes_no,
                    delete_yes_no = userProfile.delete_yes_no,
                    modify_yes_no = userProfile.modify_yes_no,
                    report_yes_no = userProfile.report_yes_no,
                    print_only = userProfile.print_only,
                    view_yes_no = userProfile.view_yes_no,
                    user_created_on = DateTime.Now,

                };
                DB.User_Detail.Update(editUser);
                //DB.SaveChanges();

                //delete all form trx of that user
                List<Forms_Trx_Master> frm_trx = DB.Forms_Trx_Master.Where(x => x.user_id == Id).ToList();
                DB.RemoveRange(frm_trx);
                DB.SaveChanges();

                List<Forms_Master> frms = DB.Forms_Master.ToList();

                foreach (Forms_Master frm in frms)
                {

                    Forms_Trx_Master ftm = new Forms_Trx_Master()
                    {
                        user_id = Id,
                        delete_yes_no = userProfile.delete_yes_no,
                        modify_yes_no = userProfile.modify_yes_no,
                        save_yes_no = userProfile.save_yes_no,
                        print_only = userProfile.print_only,
                        report_yes_no = userProfile.report_yes_no,
                        form_master_id = frm.id,
                    };
                    DB.Forms_Trx_Master.Add(ftm);

                    //DB.Forms_Trx_Master.Add(ftm);

                    Console.WriteLine("CHECKPOINT 4" + ftm);


                }
                DB.SaveChanges();

                Resp.status = true;
                Resp.Message = "The user role has been UPDATED successfully";


                return Resp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error : " + ex.Message);
            }

        }

        public ModelRegistrationResp GetRegistrationById(long Id)
        {
            return new ModelRegistrationResp()
            {
                status = true,
                Message = "Registration fetched successfully",
                User_Detail = DB.User_Detail.Where(x => x.id == Id).FirstOrDefault()
            };

        }

        //public ModelOTPResp InsertOTPTransaction(ModelOTPReq otp)
        //{

        //    User_OTP_Transaction transaction = new User_OTP_Transaction()
        //    {
        //        UserRegistrationId = otp.UserRegistrationId,
        //        u_verification = otp.u_verification,
        //        u_purpose = otp.u_purpose,
        //        u_otpno = otp.u_otpno,

        //    };
        //    DB.User_OTP_Transaction.Add(transaction);
        //    DB.SaveChanges();
        //    ModelOTPResp data = new ModelOTPResp()
        //    {
        //        status = true,
        //        Message = "inserted successfully"
        //    };
        //    return data;
        //}
        public ModelRegistrationResp InsertRegistration(ModelRegistrationReq res)
        {
            long? id = null;
            ModelRegistrationResp data = new ModelRegistrationResp();
            if (DB.User_Detail.Any(s => s.user_email == res.user_email))
            {
                data.status = false;
                data.Message = "Your Email is already registered";
                return data;
            }
            if (DB.User_Detail.Any(s => s.user_mobile == res.user_mobile))
            {
                data.status = false;
                data.Message = "Your Mobile no is already registered";
                return data;
            }

            if (res.confirm_user_pass != res.user_pass)
            {
                data.status = false;
                data.Message = "Password and Confirm Password fields doesn't match ";
                return data;
            }
            var result = DB.User_Detail.Any(s => s.user_email == res.user_email && s.user_mobile == res.user_mobile);
            if (!result)
            {
                User_Profile_Master userProfile = DB.User_Profile_Master.Where(x => x.user_profile == "customer").FirstOrDefault();
                if (userProfile == null)
                {
                    data.status = false;
                    data.Message = "The user profile is not correct";
                    throw new Exception("The user profile is not correct");
                }

                User_Registration_History regis = new User_Registration_History()
                {
                    user_name = res.user_name,
                    user_pass = res.user_pass,
                    user_mobile = res.user_mobile,
                    user_email = res.user_email,
                    user_pancard = res.user_pancard,
                    user_status = "Unverified ",
                    user_code = res.user_mobile,
                    user_profile = "customer",
                    user_profile_id = userProfile.id,
                    save_yes_no = userProfile.save_yes_no,
                    delete_yes_no = userProfile.delete_yes_no,
                    modify_yes_no = userProfile.modify_yes_no,
                    report_yes_no = userProfile.report_yes_no,
                    print_only = userProfile.print_only,
                    view_yes_no = userProfile.view_yes_no,
                    user_created_on = DateTime.Now

                };
                DB.User_Registration_History.Add(regis);

                List<User_OTP_Transaction> prev_otps = DB.User_OTP_Transaction.Where(x => x.user_email == res.user_email).ToList();
                foreach (var row in prev_otps)
                {
                    row.delete_status = 1;
                }

                DB.SaveChanges();

                string otp = EmailSend.GenerateOTP();

                //Console.WriteLine(otp);

                EmailSend.SendEmail(res.user_email, "OTP for Registration", $"Your OTP for registration is {otp}");

                id = regis.id;
                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    //UserDetailId = 0,
                    user_register_id = id.Value,
                    u_verification = "Email Verification",
                    u_purpose = "New Registration",
                    u_otpno = otp,
                    user_email = res.user_email,
                    delete_status = 0,
                    created_on = DateTime.Now
                };
                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();
            }
            data.status = true;
            data.Message = !result ? "inserted successfully" : "record already exists";
            data.User_Registration_History = DB.User_Registration_History.FirstOrDefault(s => s.id == id);
            return data;
        }

        public ModelOTPResp GenerateOTP(string? email, string otp_purpose,long? userId)
        {
            ModelOTPResp data = new ModelOTPResp();
            List<User_OTP_Transaction> prev_otps = DB.User_OTP_Transaction.Where(x => x.user_email == email||x.id==userId).ToList();
            foreach (var row in prev_otps)
            {
                row.delete_status = 1;
            }

            if (otp_purpose == "New Registration")
            {
                long user = DB.User_Detail.Where(x => x.user_email == email).Select(p => p.id).FirstOrDefault();

                if(user!=null){
                    data.status = false;
                    data.Message = "Email is already verified";
                }

                string otp = EmailSend.GenerateOTP();
                EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");
                
                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    //UserDetailId = 0,
                    user_register_id = DB.User_Registration_History.Where(x => x.user_email == email).OrderByDescending(u => u.id).Select(p => p.id).FirstOrDefault(),
                    u_verification = "Resend OTP for Email Verification",
                    u_purpose = "New Registration",
                    u_otpno = otp,
                    user_email = email,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";

            }else if(otp_purpose == "Forgot Password")
            {
                string otp = EmailSend.GenerateOTP();
                EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");
                long user_id = DB.User_Detail.Where(x => x.user_email == email).Select(p => p.id).FirstOrDefault();

                    if(user_id==null){
                        data.status = false;
                        data.Message = "User does not exist";
                    }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    
                    UserDetailId = user_id,
                    u_verification = "Change Password",
                    u_purpose = "Forgot Password",
                    u_otpno = otp,
                    user_email = email,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";

            }else if(otp_purpose=="Order Delievery")
            {
                string user_email = DB.User_Detail.Where(x => x.id == userId).Select(p => p.user_email).FirstOrDefault();
                
                string otp = EmailSend.GenerateOTP();
                EmailSend.SendEmail(user_email, $"Your OTP for {otp_purpose}", $"is {otp}");

                    if(userId==null){
                        data.status = false;
                        data.Message = "User does not exist";
                    }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    
                    UserDetailId = userId,
                    u_verification = "Order Delievery",
                    u_purpose = "Order Delievery",
                    u_otpno = otp,
                    user_email = user_email,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP sent successfully!";
                data.otp_transaction = transaction;
                data.Otp = otp;
            }
            else{
                data.status = false;
                data.Message = "Could not sent OTP!";
            }

           
            return data;


        }

        public ModelOTPResp ValidateMobileOTP(long mobile, string otp)
        {
            var validateOTP = (from user in DB.User_Detail
                               join other in DB.User_OTP_Transaction on user.id equals other.UserDetailId
                               where user.user_mobile == mobile && other.u_otpno == otp
                               select new
                               {
                                   User = user,
                                   Other = other
                               }).FirstOrDefault();
            User_Detail user_Detail = DB.User_Detail.FirstOrDefault(s => s.id == validateOTP.User.id);
            if (user_Detail != null)
            {
                user_Detail.user_status = "ACTIVE";
            }
            DB.SaveChanges();
            return new ModelOTPResp()
            {
                status = true,
                Message = validateOTP != null ? "Records fetched successfully" : "No records match",
                otp_transaction = validateOTP
            };
        }

        public ModelOTPResp ValidateEmailOTP(string email, string otp)
        {
            ModelOTPResp data = new ModelOTPResp();

            User_Detail user_data = DB.User_Detail.Where(x => x.user_email == email).FirstOrDefault();

            if(user_data!=null)
            {
                data.status = false;
                data.Message = "User is already registered and verified, if you don't remember your password go to login and use Forgot Password to proceed further";
                return data;
            }

            var validateOTP = (from user in DB.User_Registration_History
                               join other in DB.User_OTP_Transaction on user.id equals other.user_register_id
                               where user.user_email == email && other.u_otpno == otp && other.delete_status == 0
                               select new
                               {
                                   User = user,
                                   Other = other
                               }).FirstOrDefault();

            if (validateOTP != null)
            {
                User_Registration_History user_Detail = DB.User_Registration_History.FirstOrDefault(s => s.id == validateOTP.User.id);
                if (user_Detail != null)
                {
                    user_Detail.user_status = "Verified";
                    New_User(user_Detail);
                }

                DB.SaveChanges();

                
                    data.status = true;
                    data.Message = "OTP Validated";
                    data.otp_transaction = validateOTP;
                    

            }else{
                
                data.status = false;
                data.Message = "OTP does not match";

            }

            return data;
        }

        // public ModelOTPResp ValidateEmailByLink(string email)
        // {
        //     var user = DB.User_Detail.FirstOrDefault(s => s.user_email.Trim().ToLower() == email.Trim().ToLower());

        //     if (user != null)
        //     {
        //         string otp = EmailSend.GenerateOTP();
        //         string key = EmailSend.GetRandomString(24);
        //         string encryptEmail = Common.Common.CryptoEngine.Encrypt(email, key);

        //         var transaction = new User_OTP_Transaction();
        //         transaction.UserDetailId = user.id;
        //         transaction.u_verification = key;
        //         transaction.u_purpose = "Email";
        //         transaction.u_otpno = otp;
        //         DB.User_OTP_Transaction.Add(transaction);
        //         DB.SaveChanges();
        //         EmailSend.SendEmail(email, "Validate URL OTP", $"http://localhost:5200/api/admin/User_Detail/VerifyEmailByotp?email={encryptEmail}&otp={otp}&id={transaction.id}");
        //     }

        //     return new ModelOTPResp()
        //     {
        //         status = true,
        //         Message = user != null ? "Records fetched successfully" : "No records match",
        //         otp_transaction = user
        //     };
        // }

        // public ModelOTPResp VerifyEmailByotp(string email, string otp, long id)

        // {
        //     var transection = DB.User_OTP_Transaction.FirstOrDefault(s => s.id == id);
        //     if (transection != null)
        //     {
        //         string decryptEmail = Common.Common.CryptoEngine.Decrypt(email, transection.u_verification);
        //         if (decryptEmail != null)
        //         {
        //             var validateOTP = (
        //               from user in DB.User_Detail
        //               join other in DB.User_OTP_Transaction on user.id equals other.UserDetailId // Replace with the actual columns you want to join on
        //               where user.user_email == decryptEmail && other.u_otpno == otp
        //               select new
        //               {
        //                   User = user,
        //                   Other = other
        //               }).FirstOrDefault();
        //             User_Detail user_Detail = DB.User_Detail.FirstOrDefault(s => s.id == id); 
        //             if (user_Detail != null)
        //             {
        //                 user_Detail.user_status = "ACTIVE";
        //             }
        //             DB.SaveChanges();
        //             if (validateOTP != null)
        //             {
        //                 return new ModelOTPResp()
        //                 {
        //                     status = true,
        //                     Message = "Records fetched successfully",
        //                     otp_transaction = validateOTP
        //                 };
        //             }
        //         }
        //     }

        //     return new ModelOTPResp()
        //     {
        //         status = true,
        //         Message = "No records match",
        //         otp_transaction = transection
        //     };
        // }

        public ModelOTPResp ForgotPassword(string password, string confirmPassword, string email, string otp)
        {
            if (password != confirmPassword)
            {
                return new ModelOTPResp()
                {
                    status = true,
                    Message = "Password doesn't match to confirm Password",
                    otp_transaction = null
                };
            }
            var validateOTP = (from user in DB.User_Detail
                               join other in DB.User_OTP_Transaction on user.id equals other.UserDetailId
                               where user.user_email.ToLower() == email.ToLower() && other.u_otpno == otp
                               select new
                               {
                                   User = user,
                                   Other = other
                               }).FirstOrDefault();
            if (validateOTP == null)
            {
                throw new Exception("otp doesnt match");
            }
            var usertable = DB.User_Detail.FirstOrDefault(s => s.id == validateOTP.User.id);

            if (usertable != null)
            {
                usertable.user_pass = password;
                DB.SaveChanges();
            }

            return new ModelOTPResp()
            {
                status = true,
                Message = usertable != null ? "Records fetched successfully" : "No records match",
                otp_transaction = usertable
            };
        }

        //public ModelOTPResp CreatePassword(string password, string email)
        //{
        //    var user = DB.User_Detail.FirstOrDefault(s => s.user_email.Trim().ToLower() == email.Trim().ToLower());

        //    if (user != null)
        //    {
        //        user.user_pass = password;
        //        DB.SaveChanges();
        //    }

        //    return new ModelOTPResp()
        //    {
        //        status = true,
        //        Message = user != null ? "Records fetched successfully" : "No records match",
        //        otp_transaction = user
        //    };
        //}

        public ModelUserMultiAddResp InsertUserMultiAddress(ModelUserMultiAddReq mul)
        {
            UserMultiAddDetails multi = new UserMultiAddDetails()
            {

                userId = mul.userId,
                m_form_name = mul.m_form_name,
                m_address = mul.m_address,
                m_city = mul.m_city,
                m_pin_code = mul.m_pin_code,
                m_country = mul.m_country,
                m_address_type = mul.m_address_type,

            };
            DB.UserMultiAddDetails.Add(multi);
            DB.SaveChanges();
            ModelUserMultiAddResp data = new ModelUserMultiAddResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }
        public ModelUserMultiAddResp GetUserMultiAddress(long user_id)
        {

            ModelUserMultiAddResp data = new ModelUserMultiAddResp()
            {
                status = true,
                Message = "data fetched successfully",
                MultiUserAddData = DB.UserMultiAddDetails.Where(x => (x.userId == user_id)).ToList()
            };
            return data;
        }

        public ModelUserMultiAddResp UpdateUserMultiAdd(int ID, ModelUserMultiAddReq com)
        {
            var result = DB.UserMultiAddDetails.FirstOrDefault(s => s.id == ID);
            if (result != null)
            {


                result.userId = com.userId; // Update userId
                result.m_form_name = com.m_form_name; // Update m_form_name
                result.m_address = com.m_address; // Update m_address
                result.m_city = com.m_city; // Update m_city
                result.m_pin_code = com.m_pin_code; // Update m_pin_code
                result.m_country = com.m_country; // Update m_country
                result.m_address_type = com.m_address_type; // Update m_address_type

                DB.SaveChanges(); // Save changes to the database
            }

            ModelUserMultiAddResp data = new ModelUserMultiAddResp()
            {
                status = result != null ? true : false,
                Message = result != null ? "UPDATED successfully" : "Id Does not Exit"
            };
            return data;
        }

        public ModelUserMultiAddResp DeletUserMulAdd(int ID)
        {
            UserMultiAddDetails del = DB.UserMultiAddDetails.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.UserMultiAddDetails.Remove(del);
            DB.SaveChanges();
            ModelUserMultiAddResp data = new ModelUserMultiAddResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }
    }
}