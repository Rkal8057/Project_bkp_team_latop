using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class BlogMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public string? blog_title { get; set; }
        public string? blog_category { get; set; }
        public string? blog_category_id { get; set; }
        public string? blog_description { get; set; }
        public string? blog_content { get; set; }
        public long? blog_status { get; set; }
        public long? deleted { get; set; }
        public string? img_url { get; set; }
        public string? username { get; set; }

    }
}
