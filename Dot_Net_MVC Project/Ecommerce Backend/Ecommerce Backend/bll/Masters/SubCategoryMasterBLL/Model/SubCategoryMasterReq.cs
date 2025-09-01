using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SubCategoryMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public string? sub_category_name { get; set; }
        public long? parent_category_id { get; set; }
        public string? parent_category_name { get; set; }
        public string? sub_heading { get; set; }
        public string? username { get; set; }
    }
}
