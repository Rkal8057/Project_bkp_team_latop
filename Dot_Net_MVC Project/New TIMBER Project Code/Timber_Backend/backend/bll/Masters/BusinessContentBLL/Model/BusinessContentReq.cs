using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class BusinessContentReq
    {
        public long? id { get; set; }
        public string? type { get; set; }
        public string? label { get; set; }
        public string? value { get; set; }
        public string? label_bold { get; set; }
        public string? value_bold { get; set; }
        public string? alignment { get; set; }
        public string? icon { get; set; }
        public string? button_alignment { get; set; }
        public string? content_position { get; set; }
        public string? business_section_name { get; set; }
        public long? business_section_id { get; set; }

        public long? business_user_detail_id { get; set; }

        public long? delete { get; set; }
    }
}
