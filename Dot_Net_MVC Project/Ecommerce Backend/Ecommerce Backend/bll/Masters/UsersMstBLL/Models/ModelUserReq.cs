using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;


namespace RTA.Admin.Models
{
    public class ModelUserReq
    {

        //public long user_code { get; set; }

        public string user_name { get; set; }

        public string user_pass { get; set; }

        public long user_profile_id { get; set; }

        public string user_status { get; set; }

        public long user_mobile { get; set; }

        public string user_email { get; set; }

        public string? user_email_pass { get; set; }

        public string? software_version { get; set; }

        public string? user_allotement_status { get; set; }


    }
}