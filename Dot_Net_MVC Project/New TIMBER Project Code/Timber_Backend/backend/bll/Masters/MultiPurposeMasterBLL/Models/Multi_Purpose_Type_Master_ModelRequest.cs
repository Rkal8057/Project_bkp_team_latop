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
    public class Multi_Purpose_Type_Master_ModelRequest
    {

        public long? auto_id { get; set; }

        public string? multi_purpose_flag { get; set; }

        public string? multi_purpose_code { get; set; }

        public string? multi_purpose_type { get; set; }

        public string? multi_purpose_remark { get; set; }

        public string? multi_purpose_delete_allow_yn { get; set; }

        public string? exchange_name { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
        public long? user_id { get; set; }
        public string? user_profile { get; set; }
        public string? user_name { get; set; }
        public long? user_mobile { get; set; }


    }
}
