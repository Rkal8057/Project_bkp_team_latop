using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class BusinessSectionReq
    {
        public long? id { get; set; }
        public string? title { get; set; }
        public string? title_alignment { get; set; }
        public string? title_bold { get; set; }
        public string? title_font_size { get; set; }
        public string? section_position { get; set; }
        public long? delete { get; set; }
        public long? business_user_detail_id { get; set; }
        public string? section_multiple { get; set; } 



    }
}
