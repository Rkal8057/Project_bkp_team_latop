using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SystemMasterReq
    {
        public long? unique_trn_id { get; set; }

        public long? client_purchaser_code { get; set; }

        public string? client_purchaser_name { get; set; }

        public long? agent_code { get; set; }

        public string? agent_name { get; set; }

        public long? vender_code { get; set; }

        public string? vender_name { get; set; }
        public string? company_name { get; set; }
        public string? company_address { get; set; }

        public string? company_pincode { get; set; }

        public string? company_phoneNumber { get; set; }

        public string? company_img_url { get; set; }

        public string? company_email { get; set; }

        public string? company_linkedin_link { get; set; }

        public string? company_fb_link { get; set; }

        public string? company_intragram_link { get; set; }

        public string? company_twitter_link { get; set; }
        public string? company_about_detail { get; set; }



        public string? company_terms { get; set; }
        public string? company_policy { get; set; }
        

        public string? company_return { get; set; }

        public bool? company_order_otp_active { get; set; }

    }
}
