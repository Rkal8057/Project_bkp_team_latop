
using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ApplicationMasterReq
    {
        public string? first_email { get; set; }
        public string? first_addres { get; set; }
        public string? first_city { get; set; }
        public string? first_state { get; set; }
        public string? first_pincode { get; set; }
        public string? first_mobile { get; set; }

        public DateTime? date { get; set; }
        public string? second_name { get; set; }
        public string? second_address { get; set; }
        public string? second_city { get; set; }
        public string? second_state { get; set; }
        public string? second_pincode { get; set; }
        public string? subject { get; set; }
        public string? total_day { get; set; }
        public string? type_of_leave { get; set; }
        public string? coWorker_name { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public DateTime? coming_date { get; set; }
        public string? disease { get; set; }
        public string? logo_image { get; set; }
        public string? sign_image { get; set; }

        public string? designation { get; set; }


    }
}



