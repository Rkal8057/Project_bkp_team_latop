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
    public class CategoryMasterReq
    {
        public string? category_name { get; set; }
        public string? category_content { get; set; }
        public string? category_image { get; set; }
        public string? online_yn { get; set; }

        public string? cate_type { get; set; }
        public long? cate_id_if_sub_Selected { get; set; }
        public string? cate_name_if_sub_Selected { get; set; }
        public long? super_cate_id { get; set; }
        public long? balance_sheet_id { get; set; }
        public string? balance_sheet_cate_name { get; set; }

    }
}
