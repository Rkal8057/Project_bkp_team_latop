using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class SystemMaster
    {

        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("unique_trn_id", Order = 1, TypeName = "bigint")]
        public long? unique_trn_id { get; set; }

        [Column("client_purchaser_code", Order = 2, TypeName = "bigint")]
        public long? client_purchaser_code { get; set; }

        [Column("client_purchaser_name", Order = 3, TypeName = "text")]
        public string? client_purchaser_name { get; set; }

        [Column("agent_code", Order = 4, TypeName = "bigint")]
        public long? agent_code { get; set; }

        [Column("agent_name", Order = 5, TypeName = "text")]
        public string? agent_name { get; set; }

        [Column("vender_code", Order = 6, TypeName = "bigint")]
        public long? vender_code { get; set; }

        [Column("vender_name", Order = 7, TypeName = "text")]
        public string? vender_name { get; set; }

        [Column("company_name", Order = 8, TypeName = "text")]
        public string? company_name { get; set; }

        [Column("company_address", Order = 9, TypeName = "text")]
        public string? company_address { get; set; }

        [Column("company_pincode", Order = 10, TypeName = "text")]
        public string? company_pincode { get; set; }

        [Column("company_phone_number", Order = 11,TypeName = "text")]
        public string? company_phoneNumber { get; set; }

        [Column("company_img_url", Order = 12, TypeName = "text")]
        public string? company_img_url { get; set; }

        [Column("company_email", Order = 13, TypeName = "text")]
        public string? company_email { get; set; }

        [Column("company_linkedin_link", Order = 14, TypeName = "text")]
        public string? company_linkedin_link { get; set; }

        [Column("company_fb_link", Order = 15, TypeName = "text")]
        public string? company_fb_link { get; set; }

        [Column("company_intragram_link", Order = 16,TypeName = "text")]
        public string? company_intragram_link { get; set; }

        [Column("company_twitter_link", Order = 17 ,TypeName = "text")]
        public string? company_twitter_link { get; set; }

        [Column("company_status", Order = 18 ,TypeName = "bigint")]
        public long? company_status { get; set; } = 0;

        [Column("company_delete_status", Order = 19, TypeName = "bigint")]
        public long? company_delete_status { get; set; } = 0;

        [Column("company_about_detail", Order = 20, TypeName = "text")]
        public string? company_about_detail { get; set; }


        [Column("company_terms", Order = 21, TypeName = "text")]
        public string? company_terms { get; set; }

        [Column("company_policy", Order = 22, TypeName = "text")]
        public string? company_policy { get; set; }

        [Column("company_return", Order = 23, TypeName = "text")]
        public string? company_return { get; set; }

        [Column("company_order_otp_active", Order = 24, TypeName = "bit")]
        public bool? company_order_otp_active { get; set; } = false;
    }
}
