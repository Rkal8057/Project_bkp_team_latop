using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

using System.Reflection.Metadata;

namespace RTA.Masters
{
    public class ApplicationMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public ApplicationMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ApplicationMasterResp InsertApplicationMaster(ApplicationMasterReq samp , string file_path)
        {

            ApplicationMaster categoryObj = new ApplicationMaster()
            {
                first_email = samp.first_email,   
                first_addres = samp.first_addres,   
                first_city = samp.first_city,   
                first_mobile = samp.first_mobile,   
                first_pincode = samp.first_pincode, 
                first_state = samp.first_state, 
                second_address = samp.second_address,
                second_city = samp.second_city,
                second_name = samp.second_name, 
                second_pincode = samp.second_pincode,
                second_state = samp.second_state,
                date = samp.date,
                start_date = samp.start_date,   
                end_date = samp.end_date,   
                disease = samp.disease,
                total_day = samp.total_day,
                type_of_leave = samp.type_of_leave,
                coming_date = samp.coming_date,
                coWorker_name = samp.coWorker_name,
                subject = samp.subject,
                file_path = file_path,
                sign_image = samp.sign_image,
                logo_image = samp.logo_image,
                designation = samp.designation, 
            };

            DB.ApplicationMaster.Add(categoryObj);
            DB.SaveChanges();

         


            ApplicationMasterResp data = new ApplicationMasterResp()
            {
                status = true,
                Message = "inserted successfully",
                DocsFile = file_path
            };
            return data;
        }

       


    }
}