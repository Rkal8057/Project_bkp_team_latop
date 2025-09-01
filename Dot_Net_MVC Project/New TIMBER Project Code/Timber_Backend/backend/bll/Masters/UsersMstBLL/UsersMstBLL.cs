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
using BC = BCrypt.Net.BCrypt;

namespace RTA.Admin
{
    public class UsersMstBLL
    {
        private loginDBContext DB;
        private string VendorCode;
        private string DBConnStr;
        public UsersMstBLL(string _DBConnStr, string _VendorCode)
        {
            DBConnStr = _DBConnStr;
            VendorCode = _VendorCode;
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

            User_Detail user_Detail = query.Where(s => s.user_mobile == LoginReq.user_mobile).FirstOrDefault();

            if (user_Detail == null)
            {
                Resp.status = false;
                Resp.Message = "Your Phone no. is not registered";
                return Resp;
            }

            if (user_Detail != null)
            {
                bool isPassValid = BC.Verify(LoginReq.user_pass, user_Detail.user_pass, false, BCrypt.Net.HashType.SHA384);

                if (!isPassValid)
                {
                    Resp.status = false;
                    Resp.Message = "Your Password is incorrect";
                    return Resp;
                }

                if (user_Detail.user_status != "ACTIVE")
                {
                    Resp.status = false;
                    Resp.Message = "This user has been deactivated";
                    return Resp;
                }
            }


            ModelAuth modelAuth = new ModelAuth();


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
                }

                Log_Data(user_Detail);
                Resp.status = true;
                Resp.Message = "Login Successful";
                Resp.User = user_Detail;
            }

            AuthTokenBLL authTokenBLL = new AuthTokenBLL(DBConnStr);
            Resp.AuthToken = authTokenBLL.GenerateToken(modelAuth);
            return Resp;
        }

        private bool New_User(User_Registration_History Reg_User_Detail)
        {
            try
            {

                User_Profile_Master userProfile = DB.User_Profile_Master.Where(x => x.id == Reg_User_Detail.user_profile_id).FirstOrDefault();

                if (userProfile == null)
                {
                    throw new Exception("The user profile id is not correct or does not exist");
                    return false;
                }

                User_Detail nu = new User_Detail()
                {
                    user_code = long.Parse(Reg_User_Detail.user_mobile),
                    user_name = Reg_User_Detail.user_name,
                    user_pass = Reg_User_Detail.user_pass,
                    user_email = Reg_User_Detail.user_email,
                    user_email_pass = Reg_User_Detail.user_email_pass,
                    user_pancard = Reg_User_Detail.user_pancard,
                    user_mobile = Reg_User_Detail.user_mobile,
                    user_status = "ACTIVE",
                    software_version = Reg_User_Detail.software_version,
                    user_allotement_status = Reg_User_Detail.user_allotement_status,
                    user_profile_id = Reg_User_Detail.user_profile_id,
                    user_profile = userProfile.user_profile,
                    save_yes_no = userProfile.save_yes_no,
                    delete_yes_no = userProfile.delete_yes_no,
                    modify_yes_no = userProfile.modify_yes_no,
                    report_yes_no = userProfile.report_yes_no,
                    print_only = userProfile.print_only,
                    view_yes_no = userProfile.view_yes_no,
                    user_created_on = DateTime.Now,

                    sponsored_user_id = Reg_User_Detail.sponsored_user_id,
                    sponsored_user_mobile = Reg_User_Detail.sponsored_user_mobile,
                    sponsored_by_user_name = Reg_User_Detail.sponsored_by_user_name,
                    
                    left_side_user_id = 0,
                    right_side_user_id = 0,

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
                //get sponsor data
                User_Detail sponserData = DB.User_Detail.Where(s => s.id == nu.sponsored_user_id && s.user_status == "ACTIVE").FirstOrDefault();

                // Check if the newUserId is already used in LeftSide or RightSide
                bool isIdUsed = DB.User_Detail.Any(x => x.left_side_user_id == nu.left_side_user_id || x.right_side_user_id == nu.right_side_user_id);

                if (!isIdUsed)
                {
                    throw new Exception("This id is already updated under a user's left or right side");
                    return false;
                }

                if (sponserData.left_side_user_id == null || sponserData.left_side_user_id == 0)
                {
                    sponserData.left_side_user_id = nu.id;
                    sponserData.left_side_user_mobile = nu.user_mobile;
                    //registered user under which user
                    nu.under_user_id = sponserData.id;
                    nu.under_user_mobile = sponserData.user_mobile;
                    DB.SaveChanges();
                }
                else if (sponserData.right_side_user_id == null || sponserData.right_side_user_id == 0)
                {
                    sponserData.right_side_user_id = nu.id;
                    sponserData.right_side_user_mobile = nu.user_mobile;
                    //registered user under which user
                    nu.under_user_id = sponserData.id;
                    nu.under_user_mobile = sponserData.user_mobile;
                    DB.SaveChanges();
                }
                else
                {
                    // Fetch users with both LeftSide and RightSide as null
                    List<User_Detail> availableUsers = DB.User_Detail.Where(u => u.left_side_user_id == null || u.right_side_user_id == null).ToList();

                    if (availableUsers.Any())
                    {
                        // Get the first user where both sides are null
                        User_Detail userToUpdate = availableUsers.First();

                        // Assign the new user to the LeftSide first if it's null
                        if (userToUpdate.left_side_user_id == null)
                        {
                            userToUpdate.left_side_user_id = nu.id;
                            userToUpdate.left_side_user_mobile = nu.user_mobile;
                            //registered user under which user
                            nu.under_user_id = userToUpdate.id;
                            nu.under_user_mobile = userToUpdate.user_mobile;
                            DB.SaveChanges();
                        }
                        // Otherwise, assign to the RightSide
                        else if (userToUpdate.right_side_user_id == null)
                        {
                            userToUpdate.right_side_user_id = nu.id;
                            userToUpdate.right_side_user_mobile = nu.user_mobile;
                            //registered user under which user
                            nu.under_user_id = userToUpdate.id;
                            nu.under_user_mobile = userToUpdate.user_mobile;
                            DB.SaveChanges();
                        }
                    }

                }

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
                authTokenBLL.DeleteToken(UserReq.user_code);

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
                    user_code = long.Parse(UserReq.user_mobile),
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

        public ModelRegistrationResp InsertRegistration(ModelRegistrationReq res)
        {
            //decide whether on mobile or on email otp would be send (static) [for dynamic system records -> comp_login_otp_type]
            string sendOtponMob = "n"; //change to y for on mobile

            long? id = null;
            RTA.Common.CommonMstBLL common = new RTA.Common.CommonMstBLL(DBConnStr);

            ModelRegistrationResp data = new ModelRegistrationResp();
            // if (!common.IsMobileValid(res.user_mobile))
            // {
            //     data.status = false;
            //     data.Message = "This Mobile no. is invalid";
            //     return data;
            // }

            // if (!common.IsValidPanCard(res.user_pancard))
            // {
            //     data.status = false;
            //     data.Message = "This Pancard no. is not in correct format";
            //     return data;
            // }

            // if (!common.IsValidEmail(res.user_email))
            // {
            //     data.status = false;
            //     data.Message = "This Email address is invalid";
            //     return data;
            // }

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

            long sponsorId = 0;
            string sponsorMob = "";
            string sponsorName = "";

            if (!String.IsNullOrEmpty(res.sponsored_user_mobile))
            {
                //find user linked with the mentioned sponser no.
                User_Detail sponserData = DB.User_Detail.Where(s => s.user_mobile == res.sponsored_user_mobile && s.user_status == "ACTIVE").FirstOrDefault();
                if (sponserData == null)
                {
                    data.status = false;
                    data.Message = "Sponser's Mobile no. is not registered";
                    return data;
                }
                sponsorId = sponserData.id;
                sponsorMob = sponserData.user_mobile;
                sponsorName = sponserData.user_name;
            }
            else
            {
                System_Records SystemCompData = DB.System_Records.Where(s => s.vendor_code == VendorCode).FirstOrDefault();

                User_Detail sponserData = DB.User_Detail.Where(s => s.user_mobile == SystemCompData.company_phone && s.user_status == "ACTIVE").FirstOrDefault();
                if (sponserData == null)
                {
                    data.status = false;
                    data.Message = "Company Sponser's Data not found";
                    return data;
                }

                sponsorId = sponserData.id;
                sponsorMob = sponserData.user_mobile;
                sponsorName = "Company";

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
                    data.Message = "The user profile does not exist";
                    return data;
                }

                // Hash the password
                string hashedPassword = BC.HashPassword(res.user_pass);

                User_Registration_History regis = new User_Registration_History()
                {
                    user_name = res.user_name,
                    user_pass = hashedPassword,
                    user_mobile = res.user_mobile,
                    user_email = res.user_email,
                    user_pancard = res.user_pancard,
                    user_status = "Unverified",
                    user_code = long.Parse(res.user_mobile),
                    user_profile = "customer",
                    user_profile_id = userProfile.id,
                    save_yes_no = userProfile.save_yes_no,
                    delete_yes_no = userProfile.delete_yes_no,
                    modify_yes_no = userProfile.modify_yes_no,
                    report_yes_no = userProfile.report_yes_no,
                    print_only = userProfile.print_only,
                    view_yes_no = userProfile.view_yes_no,
                    user_created_on = DateTime.Now,

                    sponsored_user_id = sponsorId,
                    sponsored_user_mobile = sponsorMob,
                    sponsored_by_user_name = sponsorName
                    //under_user_id = sponsorId,
                };
                DB.User_Registration_History.Add(regis);

                List<User_OTP_Transaction> prev_otps = DB.User_OTP_Transaction.Where(x => x.user_email == res.user_email && x.delete_status == 0).ToList();
                foreach (var row in prev_otps)
                {
                    row.delete_status = 1;
                }

                DB.SaveChanges();

                string otp = EmailSend.GenerateOTP();
                //string otp = "1234";
                string otp_purpose = "New Registration";

                //bool smsSent = true;
                if(sendOtponMob == "y")
                {
                    //send otp via SMS on mobile
                    bool smsSent = sendSmsMsg(res.user_mobile, otp_purpose, otp, null);    
                    if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending SMS. See logs for details";
                    return data;
                }            
                }else{
                    //otp on email
                //send otp via email
                bool smsSent = sendEmailMsg(res.user_email, otp_purpose, otp, null);
                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
                }
                }
                
                
               
                id = regis.id;
                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    //UserDetailId = 0,
                    user_register_id = id.Value,
                    u_verification = "Mobile no Verification",
                    u_purpose = otp_purpose,
                    u_otpno = otp,
                    user_mobile = res.user_mobile,
                    //user_email = res.user_email,
                    delete_status = 0,
                    created_on = DateTime.Now
                };
                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();
            }
            data.status = true;
            data.Message = !result ? "Details enetered and OTP sent successfully" : "record already exists";
            data.User_Registration_History = DB.User_Registration_History.FirstOrDefault(s => s.id == id);
            return data;
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
        // public ModelRegistrationResp InsertRegistration(ModelRegistrationReq res)
        // {
        //     long? id = null;
        //     ModelRegistrationResp data = new ModelRegistrationResp();
        //     if (DB.User_Detail.Any(s => s.user_email == res.user_email))
        //     {
        //         data.status = false;
        //         data.Message = "Your Email is already registered";
        //         return data;
        //     }
        //     if (DB.User_Detail.Any(s => s.user_mobile == res.user_mobile))
        //     {
        //         data.status = false;
        //         data.Message = "Your Mobile no is already registered";
        //         return data;
        //     }

        //     if (res.confirm_user_pass != res.user_pass)
        //     {
        //         data.status = false;
        //         data.Message = "Password and Confirm Password fields doesn't match ";
        //         return data;
        //     }
        //     var result = DB.User_Detail.Any(s => s.user_email == res.user_email && s.user_mobile == res.user_mobile);
        //     if (!result)
        //     {
        //         User_Profile_Master userProfile = DB.User_Profile_Master.Where(x => x.user_profile == "customer").FirstOrDefault();
        //         if (userProfile == null)
        //         {
        //             data.status = false;
        //             data.Message = "The user profile is not correct";
        //             throw new Exception("The user profile is not correct");
        //         }

        //         User_Registration_History regis = new User_Registration_History()
        //         {
        //             user_name = res.user_name,
        //             user_pass = res.user_pass,
        //             user_mobile = res.user_mobile,
        //             user_email = res.user_email,
        //             user_pancard = res.user_pancard,
        //             user_status = "Unverified ",
        //             user_code = long.Parse(res.user_mobile),
        //             user_profile = "customer",
        //             user_profile_id = userProfile.id,
        //             save_yes_no = userProfile.save_yes_no,
        //             delete_yes_no = userProfile.delete_yes_no,
        //             modify_yes_no = userProfile.modify_yes_no,
        //             report_yes_no = userProfile.report_yes_no,
        //             print_only = userProfile.print_only,
        //             view_yes_no = userProfile.view_yes_no,
        //             user_created_on = DateTime.Now

        //         };
        //         DB.User_Registration_History.Add(regis);

        //         List<User_OTP_Transaction> prev_otps = DB.User_OTP_Transaction.Where(x => x.user_email == res.user_email).ToList();
        //         foreach (var row in prev_otps)
        //         {
        //             row.delete_status = 1;
        //         }

        //         DB.SaveChanges();

        //         string otp = EmailSend.GenerateOTP();

        //         //Console.WriteLine(otp);

        //         EmailSend.SendEmail(res.user_email, "OTP for Registration", $"Your OTP for registration is {otp}");

        //         id = regis.id;
        //         User_OTP_Transaction transaction = new User_OTP_Transaction()
        //         {
        //             //UserDetailId = 0,
        //             user_register_id = id.Value,
        //             u_verification = "Email Verification",
        //             u_purpose = "New Registration",
        //             u_otpno = otp,
        //             user_email = res.user_email,
        //             delete_status = 0,
        //             created_on = DateTime.Now
        //         };
        //         DB.User_OTP_Transaction.Add(transaction);
        //         DB.SaveChanges();
        //     }
        //     data.status = true;
        //     data.Message = !result ? "inserted successfully" : "record already exists";
        //     data.User_Registration_History = DB.User_Registration_History.FirstOrDefault(s => s.id == id);
        //     return data;
        // }

        public ModelOTPResp LoginWithOtp(ModelOTPLoginReq loginReq)
        {
            ModelOTPResp Resp = new ModelOTPResp();
            IQueryable<User_Detail> query = DB.User_Detail.AsQueryable();

            User_Detail user_Detail = new User_Detail();

            if (loginReq.Identifier.Contains("@"))
            {
                if (String.IsNullOrEmpty(loginReq.RecOtpOn))
                {
                    loginReq.RecOtpOn = "email";
                }
                user_Detail = query.Where(s => s.user_email == loginReq.Identifier).FirstOrDefault();
                Resp.Message = "This Email address is not registered";
            }
            else
            {
                if (String.IsNullOrEmpty(loginReq.RecOtpOn))
                {
                    loginReq.RecOtpOn = "mobile";
                }
                long MobileNo = long.Parse(loginReq.Identifier);
                user_Detail = query.Where(s => s.user_code == MobileNo).FirstOrDefault();
                Resp.Message = "This Phone no. is not registered";
            }

            if (user_Detail != null)
            {
                if (!String.IsNullOrEmpty(loginReq.Password))
                {
                    bool isPassValid = BC.Verify(loginReq.Password, user_Detail.user_pass, false, BCrypt.Net.HashType.SHA384);

                    if (!isPassValid)
                    {
                        Resp.status = false;
                        Resp.Message = "Your Password is incorrect";
                        return Resp;
                    }

                }


                if (user_Detail.user_status != "ACTIVE")
                {
                    Resp.status = false;
                    Resp.Message = "This user has been deactivated";
                    return Resp;
                }

                if (loginReq.RecOtpOn == "mobile")
                {
                    //otp to investors
                    var otpResp = GenerateMobileOTP(user_Detail.user_mobile, "Login", user_Detail.id, null, null);

                    if (otpResp.status == false)
                    {
                        Resp.status = false;
                        Resp.Message = otpResp.Message;
                        return Resp;
                    }
                    Resp.status = true;
                    Resp.Message = "OTP sent on your registered mobile no. successfully";
                    return Resp;
                }
                else if (loginReq.RecOtpOn == "email")
                {
                    //otp to investors
                    var otpResp = GenerateEmailOTP(user_Detail.user_email, "Login", user_Detail.id, null, null);

                    if (otpResp.status == false)
                    {
                        Resp.status = false;
                        Resp.Message = otpResp.Message;
                        return Resp;
                    }
                    Resp.status = true;
                    Resp.Message = "OTP sent on your registered email address successfully";
                    return Resp;
                }
                else
                {
                    Resp.status = false;
                    Resp.Message = "Unable to Login with OTP";
                    return Resp;
                }
            }

            Resp.status = false;
            return Resp;



        }


        public ModelOTPResp GenerateEmailOTP(string? email, string otp_purpose, long? userId, long? urn, string? flag)
        {
            ModelOTPResp data = new ModelOTPResp();
            IQueryable<User_OTP_Transaction> query = DB.User_OTP_Transaction;

            query = query.Where(x => x.user_email == email || x.UserDetailId == userId);
            query = query.Where(x => x.delete_status == 0);

            var prev_otps = query.ToList();
            // foreach (var row in prev_otps)
            // {
            //     row.delete_status = 1;
            // }
            // DB.User_OTP_Transaction.Update(prev_otps);

            prev_otps.ForEach(data => data.delete_status = 1);
            DB.SaveChanges();

            if (otp_purpose == "New Registration")
            {
                if (DB.User_Detail.Any(s => s.user_email == email && s.user_email_verified_yn == "yes"))
                {
                    data.status = false;
                    data.Message = "Your Email is already registered and verified";
                    return data;
                }

                User_Detail user_data = DB.User_Detail.Where(x => x.id == userId && x.user_email_verified_yn == "no").FirstOrDefault();
                if (user_data == null)
                {
                    data.status = false; data.Message = "User does not exist";
                }

                string otp = EmailSend.GenerateOTP();

                //send otp via email
                bool smsSent = sendEmailMsg(email, otp_purpose, otp, null);
                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
                }

                //EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");

                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
                }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    UserDetailId = user_data.id,
                    //user_register_id = DB.User_Registration_History.Where(x => x.user_email == email).OrderByDescending(u => u.id).Select(p => p.id).FirstOrDefault(),
                    u_verification = "Email Verification",
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

            }
            else if (otp_purpose == "Forgot Password")
            {
                string otp = EmailSend.GenerateOTP();
                //EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");
                long user_id = DB.User_Detail.Where(x => x.user_email == email).Select(p => p.id).FirstOrDefault();



                if (user_id == null)
                {
                    data.status = false;
                    data.Message = "This email is not registered";
                    return data;
                }

                //send otp via email
                bool smsSent = sendEmailMsg(email, otp_purpose, otp, null);
                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
                }

                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
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

            }
            else if (otp_purpose == "Login")
            {
                //string otp = EmailSend.GenerateOTP(); //uncomment in production                
                string otp = "1234";

                //EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");
                User_Detail Ud = DB.User_Detail.Where(x => x.user_email == email).FirstOrDefault();

                if (Ud == null)
                {
                    data.status = false;
                    data.Message = "This email is not registered";
                    return data;
                }

                
                //send otp via SMS
                bool smsSent = true;

                // bool smsSent = sendEmailMsg(email, otp_purpose, otp, null);              

                // if (!smsSent)
                // {
                //     data.status = true;
                //     data.Message = "Error in sending email. See logs for details";
                //     return data;
                // }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {

                    UserDetailId = Ud.id,
                    u_verification = "Two factor Authentication",
                    u_purpose = "Login",
                    u_otpno = otp,
                    user_email = email,
                    user_mobile = Ud.user_mobile,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";

            }
            else if (otp_purpose == "Order Delievery")
            {
                string otp = EmailSend.GenerateOTP();
                //EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");
                User_Detail user_data = DB.User_Detail.Where(x => x.id == userId).FirstOrDefault();

                if (user_data == null)
                {
                    data.status = false;
                    data.Message = "This email is not registered";
                    return data;
                }

                //send otp via email
                bool smsSent = sendEmailMsg(user_data.user_email, otp_purpose, otp, null);
                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
                }

                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending email. See logs for details";
                    return data;
                }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    UserDetailId = userId,
                    u_verification = "Order Delievery",
                    u_purpose = "Order Delievery",
                    u_otpno = otp,
                    user_email = user_data.user_email,
                    user_mobile = user_data.user_mobile,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";
                data.otp_transaction = transaction;
                data.Otp = otp;

            }
            else
            {
                data.status = false;
                data.Message = "Could not sent OTP!";
            }


            return data;


        }

        public ModelOTPResp GenerateMobileOTP(string mobile, string otp_purpose, long? userId, long? urn, string? flag)
        {
            ModelOTPResp data = new ModelOTPResp();
            IQueryable<User_OTP_Transaction> query = DB.User_OTP_Transaction;

            query = query.Where(x => x.user_mobile == mobile || x.UserDetailId == userId);
            query = query.Where(x => x.delete_status == 0);

            var prev_otps = query.ToList();
            // foreach (var row in prev_otps)
            // {
            //     row.delete_status = 1;
            // }
            // DB.User_OTP_Transaction.Update(prev_otps);

            prev_otps.ForEach(data => data.delete_status = 1);
            DB.SaveChanges();

            if (otp_purpose == "New Registration")
            {
                User_Detail user = DB.User_Detail.Where(x => x.user_mobile == mobile).FirstOrDefault();

                if (user != null)
                {
                    data.status = false;
                    data.Message = "User is already Registered";
                    return data;
                }

                //generate otp
                //string otp = EmailSend.GenerateOTP();
                string otp = "1234";

                //send otp via SMS
                bool smsSent = true;
                //send otp via SMS
                // bool smsSent = sendSmsMsg(mobile, otp_purpose, otp, null);
                // if (!smsSent)
                // {
                //     data.status = true;
                //     data.Message = "Error in sending SMS/OTP. See logs for details";
                //     return data;
                // }


                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    //UserDetailId = 0,
                    user_register_id = DB.User_Registration_History.Where(x => x.user_mobile == mobile).OrderByDescending(u => u.id).Select(p => p.id).FirstOrDefault(),
                    u_verification = "Resend OTP for Mobile Verification",
                    u_purpose = "New Registration",
                    u_otpno = otp,
                    user_email = "",
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";

            }
            else if (otp_purpose == "Forgot Password")
            {
                User_Detail user = DB.User_Detail.Where(x => x.user_mobile == mobile).FirstOrDefault();

                if (user == null)
                {
                    data.status = false;
                    data.Message = "This mobile no. is not registered";
                    return data;
                }

                string otp = EmailSend.GenerateOTP();

                //send otp via email
                //EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");

                //send otp via SMS
                bool smsSent = sendSmsMsg(mobile, otp_purpose, otp, null);
                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending SMS/OTP. See logs for details";
                    return data;
                }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {

                    UserDetailId = user.id,
                    u_verification = "Change Password",
                    u_purpose = otp_purpose,
                    u_otpno = otp,
                    user_email = user.user_email,
                    user_mobile = mobile,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";

            }
            else if (otp_purpose == "Login")
            {
                User_Detail user = DB.User_Detail.Where(x => x.user_mobile == mobile).FirstOrDefault();

                if (user == null)
                {
                    data.status = false;
                    data.Message = "This mobile no. is not registered";
                    return data;
                }

                //string otp = EmailSend.GenerateOTP();
                string otp = "1234";


                //send otp via SMS
                bool smsSent = true;
                // bool smsSent = sendSmsMsg(mobile, otp_purpose, otp, null);
                // if (!smsSent)
                // {
                //     data.status = true;
                //     data.Message = "Error in sending SMS/OTP. See logs for details";
                //     return data;
                // }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {

                    UserDetailId = user.id,
                    u_verification = "Two factor Authentication",
                    u_purpose = otp_purpose,
                    u_otpno = otp,
                    user_email = user.user_email,
                    user_mobile = mobile,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";

            }
            else if (otp_purpose == "Order Delievery")
            {
                User_Detail user = DB.User_Detail.Where(x => x.user_mobile == mobile).FirstOrDefault();

                if (user == null)
                {
                    data.status = false;
                    data.Message = "This mobile no. is not registered";
                    return data;
                }

                string otp = EmailSend.GenerateOTP();

                //send otp via email
                //EmailSend.SendEmail(email, $"Your OTP for {otp_purpose}", $"is {otp}");

                //send otp via SMS
                bool smsSent = sendSmsMsg(mobile, otp_purpose, otp, null);
                if (!smsSent)
                {
                    data.status = true;
                    data.Message = "Error in sending SMS/OTP. See logs for details";
                    return data;
                }

                User_OTP_Transaction transaction = new User_OTP_Transaction()
                {
                    UserDetailId = userId,
                    u_verification = "Order Delievery",
                    u_purpose = "Order Delievery",
                    u_otpno = otp,
                    user_email = user.user_email,
                    user_mobile = user.user_mobile,
                    delete_status = 0,
                    created_on = DateTime.Now
                };

                DB.User_OTP_Transaction.Add(transaction);
                DB.SaveChanges();

                data.status = true;
                data.Message = "OTP Sent successfully!";
                data.otp_transaction = transaction;
                data.Otp = otp;

            }
            else
            {
                data.status = false;
                data.Message = "Could not sent OTP!";
            }


            return data;


        }

        private bool sendSmsMsg(string mobile_no, string otp_purpose, string? otp, long? urn)
        {
            System_Records SystemCompData = DB.System_Records.Where(s => s.vendor_code == VendorCode).FirstOrDefault();

            if (SystemCompData == null)
            {
                Console.WriteLine("The Company system data not found");
                return false;
            }

            Sms_Msg_Master sms_data = DB.Sms_Msg_Master.Where(x => x.vendor_code == VendorCode && x.sms_purpose == otp_purpose).FirstOrDefault();

            if (sms_data == null)
            {
                Console.WriteLine("The SMS Template was not found in the database");
                return false;
            }

            string message = "";
            if (otp != null)
            {
                message = sms_data.sms_msg.Replace("var_otp", otp);
            }
            if (urn != null)
            {
                message = sms_data.sms_msg.Replace("var_urn", urn.ToString());
            }

            var apiUrl = "";

            apiUrl += SystemCompData.sms_base_url;

            if (VendorCode == "abhipra_103")
            {
                apiUrl += "auth=" + SystemCompData.sms_provider_user_pass + "&";// api user pass D!~5541WL1ZdT8OXm
                apiUrl += "senderid=" + SystemCompData.sms_provider_user_id + "&"; //sender mobile no

                apiUrl += "msisdn=" + mobile_no + "&";//api user id ABHPRA
                apiUrl += "message=" + message; //sms msg

            }
            else if (VendorCode == "maashitla_102")
            {
                apiUrl += "uname=" + SystemCompData.sms_provider_user_id + "&"; //sender USER ID
                apiUrl += "pass=" + SystemCompData.sms_provider_user_pass + "&";// api user pass D!~5541WL1ZdT8OXm
                apiUrl += "send=" + SystemCompData.sms_provider_gsmid + "&";// api SEND D!~5541WL1ZdT8OXm

                apiUrl += "dest=" + mobile_no + "&";//api user id ABHPRA
                apiUrl += "msg=" + message; //sms msg

            }
            else if (VendorCode == "ski_104")
            {
                apiUrl += "key=" + SystemCompData.sms_provider_user_pass + "&";// MFpnI9H5

                apiUrl += "to=" + mobile_no + "&";//mob no
                apiUrl += "from=" + SystemCompData.sms_provider_gsmid + "&";// SKIIND

                apiUrl += "body=" + message + "&"; //sms msg
                apiUrl += "entityid=" + SystemCompData.sms_provider_peid + "&"; //sms sms_provider_peid 1701159189704789729
                apiUrl += "templateid=" + sms_data.sms_temp_id; //sms msg

            }
            else
            {
                //for indus

                apiUrl += "UserID=" + SystemCompData.sms_provider_user_id + "&";
                apiUrl += "UserPass=" + SystemCompData.sms_provider_user_pass + "&";
                apiUrl += "MobileNo=" + mobile_no + "&";
                apiUrl += "GSMID=" + SystemCompData.sms_provider_gsmid + "&";
                apiUrl += "PEID=" + SystemCompData.sms_provider_peid + "&";
                apiUrl += "Message=" + message + "&";
                apiUrl += "TEMPID=" + sms_data.sms_temp_id + "&";
                apiUrl += "UNICODE=" + SystemCompData.sms_unicode;

            }

            //var encodedUrl = Uri.EscapeDataString(apiUrl);

            Console.WriteLine(apiUrl);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(apiUrl).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
            return true;

        }

        private bool sendEmailMsg(string email, string otp_purpose, string? otp, long? urn)
        {

            System_Records SystemCompData = DB.System_Records.Where(s => s.vendor_code == VendorCode).FirstOrDefault();

            if (SystemCompData == null)
            {
                Console.WriteLine("The Company system record not found in the Database");
                return false;
            }

            Sms_Msg_Master sms_data = DB.Sms_Msg_Master.Where(x => x.vendor_code == VendorCode && x.sms_purpose == otp_purpose).FirstOrDefault();

            if (sms_data == null)
            {
                Console.WriteLine("SMS Template not found in the Database");
                return false;
            }

            string message = "";
            string messageOtporUrn = "";
            if (otp != null)
            {
                message = sms_data.sms_msg.Replace("var_otp", otp);
                messageOtporUrn = "OTP : " + otp;
            }
            if (urn != null)
            {
                message = sms_data.sms_msg.Replace("var_urn", urn.ToString());
                messageOtporUrn = "URN : " + urn.ToString();
            }

            Console.WriteLine("email checkpoint 0", email, otp_purpose, message, messageOtporUrn);
            Console.WriteLine(SystemCompData);

            bool emailSent = EmailSend.SendEmail(email, otp_purpose, message, messageOtporUrn, SystemCompData);

            if (emailSent)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public ModelOTPResp ValidateMobileOTPforRegistration(string mobile, string otp)
        {
            ModelOTPResp data = new ModelOTPResp();

            User_Detail user_data = DB.User_Detail.Where(x => x.user_mobile == mobile).FirstOrDefault();

            if (user_data != null)
            {
                data.status = false;
                data.Message = "User is already registered and verified, if you don't remember your password go to Login page and use Forgot Password to proceed further...";
                return data;
            }

            var validateOTP = (from user in DB.User_Registration_History
                               join other in DB.User_OTP_Transaction on user.id equals other.user_register_id
                               where user.user_mobile == mobile && other.u_otpno == otp && other.delete_status == 0
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

                validateOTP.Other.delete_status = 1;
                DB.SaveChanges();


                data.status = true;
                data.Message = "OTP Validated Successfully";
                data.otp_transaction = validateOTP;


            }
            else
            {

                data.status = false;
                data.Message = "The OTP does not match";

            }

            return data;
        }

        public ModelOTPResp ValidateEmailOTPforRegistration(string email, string otp)
        {
            ModelOTPResp data = new ModelOTPResp();

            User_Detail user_data = DB.User_Detail.Where(x => x.user_email == email).FirstOrDefault();

            if (user_data != null)
            {
                data.status = false;
                data.Message = "User is already registered and verified, if you don't remember your password go to Login page and use Forgot Password to proceed further...";
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

                validateOTP.Other.delete_status = 1;
                DB.SaveChanges();


                data.status = true;
                data.Message = "OTP Validated Successfully";
                data.otp_transaction = validateOTP;


            }
            else
            {

                data.status = false;
                data.Message = "The OTP does not match";

            }

            return data;
        }



        public ModelLoginResp ValidateOTPforLogin(string Identifier, string otp)
        {
            ModelLoginResp Resp = new ModelLoginResp();

            //IQueryable<User_Detail> query = DB.User_Detail.AsQueryable();

            var query = DB.User_Detail.Join(
                DB.User_OTP_Transaction, user => user.id, other => other.UserDetailId,
                (user, other) => new
                {
                    User = user,
                    Other = other
                })
            .Where(uo => uo.Other.u_otpno == otp && uo.Other.delete_status == 0);


            if (Identifier.Contains("@"))
            {
                query = query.Where(uo => uo.User.user_email == Identifier);
            }
            else
            {
                //long MobileNo = long.Parse(Identifier);
                query = query.Where(uo => uo.User.user_mobile == Identifier);
            }

            var validateOTP = query.Select(uo =>
            new
            {
                User = uo.User,
                Other = uo.Other
            })
            .FirstOrDefault();

            // if (user_data == null)
            // {
            //     data.status = false;
            //     data.Message = "The User does not exist";
            //     return data;
            // }


            // var validateOTP = (from user in DB.User_Detail
            //                    join other in DB.User_OTP_Transaction on user.id equals other.id
            //                    where user.user_mobile == mobile && other.u_otpno == otp && other.delete_status == 0
            //                    select new
            //                    {
            //                        User = user,
            //                        Other = other
            //                    }).FirstOrDefault();

            if (validateOTP != null)
            {
                User_Profile_Master userProfileRight = DB.User_Profile_Master.Where(x => x.id == validateOTP.User.user_profile_id).FirstOrDefault();

                validateOTP.Other.delete_status = 1;
                DB.SaveChanges();

                ModelAuth modelAuth = new ModelAuth();

                modelAuth.auth_type = "profile_type";
                modelAuth.User = validateOTP.User;
                modelAuth.UserProfileRights = userProfileRight;

                AuthTokenBLL authTokenBLL = new AuthTokenBLL(DBConnStr);

                //login info logs
                Log_Data(validateOTP.User);

                Resp.status = true;
                Resp.Message = "Login Successful";
                Resp.User = validateOTP.User;
                Resp.AuthToken = authTokenBLL.GenerateToken(modelAuth);
                return Resp;


            }
            else
            {

                Resp.status = false;
                Resp.Message = "Incorrect OTP";

            }

            return Resp;
        }

        public ModelOTPResp ValidateMobileOTP(long mobile, string otp)
        {
            string MobStr = mobile.ToString();
            var validateOTP = (from user in DB.User_Detail
                               join other in DB.User_OTP_Transaction on user.id equals other.UserDetailId
                               where user.user_mobile == MobStr && other.u_otpno == otp
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

            if (user_data != null)
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


            }
            else
            {

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