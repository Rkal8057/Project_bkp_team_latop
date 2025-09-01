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
   public class System_Records
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }

       [Column("home_state_code", Order = 2, TypeName = "varchar(50)")]
       public string? home_state_code { get; set; }

       [Column("default_tax_name", Order = 3, TypeName = "varchar(50)")]
       public string? default_tax_name { get; set; }

       [Column("default_tax_per", Order = 4, TypeName = "text")]
       public string? default_tax_per { get; set; }

       [Column("default_unit", Order = 5, TypeName = "varchar(50)")]
       public string? default_unit { get; set; }

       [Column("default_hsn_code", Order = 6, TypeName = "text")]
       public string? default_hsn_code { get; set; }

       [Column("default_company_no", Order = 7, TypeName = "varchar(50)")]
       public string? default_company_no { get; set; }

       [Column("company_name", Order = 8, TypeName = "varchar(50)")]
       public string? company_name { get; set; }

       [Column("company_address", Order = 9, TypeName = "varchar(50)")]
       public string? company_address { get; set; }

       [Column("company_address_1", Order = 10, TypeName = "varchar(50)")]
       public string? company_address_1 { get; set; }

       [Column("company_phone", Order = 11, TypeName = "varchar(50)")]
       public string? company_phone { get; set; }

       [Column("sale_retrun_code", Order = 12, TypeName = "bigint(10)")]
       public long? sale_retrun_code { get; set; }

       [Column("sale_return_name_default", Order = 13, TypeName = "varchar(50)")]
       public string? sale_return_name_default { get; set; }

       [Column("sale_code", Order = 14, TypeName = "bigint(10)")]
       public long? sale_code { get; set; }

       [Column("sale_name_default", Order = 15, TypeName = "varchar(50)")]
       public string? sale_name_default { get; set; }

       [Column("bank_code", Order = 16, TypeName = "bigint(10)")]
       public long? bank_code { get; set; }

       [Column("bank_name_default", Order = 17, TypeName = "varchar(50)")]
       public string? bank_name_default { get; set; }

       [Column("cash_name_default", Order = 18, TypeName = "varchar(50)")]
       public string? cash_name_default { get; set; }

       [Column("cash_code", Order = 19, TypeName = "bigint(10)")]
       public long? cash_code { get; set; }

       [Column("year_from", Order = 20, TypeName = "datetime")]
       public DateTime? year_from { get; set; }

       [Column("year_to", Order = 21, TypeName = "datetime")]
       public DateTime? year_to { get; set; }

       [Column("display_height", Order = 22, TypeName = "varchar(50)")]
       public string? display_height { get; set; }

       [Column("saledatabaselock", Order = 23, TypeName = "varchar(50)")]
       public string? saledatabaselock { get; set; }

       [Column("database_1_path", Order = 24, TypeName = "varchar(50)")]
       public string? database_1_path { get; set; }

       [Column("database_2_path", Order = 25, TypeName = "varchar(50)")]
       public string? database_2_path { get; set; }

       [Column("auto_raw_yes_no", Order = 26, TypeName = "varchar(50)")]
       public string? auto_raw_yes_no { get; set; }

       [Column("weekly_off_day", Order = 27, TypeName = "varchar(50)")]
       public string? weekly_off_day { get; set; }

       //[Column("other2", Order = 28, TypeName = "varchar(50)")]
       //public string? other2 { get; set; }

       //[Column("other3", Order = 29, TypeName = "varchar(50)")]
       //public string? other3 { get; set; }

       //[Column("other4", Order = 30, TypeName = "varchar(50)")]
       //public string? other4 { get; set; }

       //[Column("other5", Order = 31, TypeName = "varchar(50)")]
       //public string? other5 { get; set; }

       //[Column("other6", Order = 32, TypeName = "varchar(50)")]
       //public string? other6 { get; set; }

       //[Column("other7", Order = 33, TypeName = "varchar(50)")]
       //public string? other7 { get; set; }

       //[Column("other8", Order = 34, TypeName = "varchar(50)")]
       //public string? other8 { get; set; }

       //[Column("other9", Order = 35, TypeName = "varchar(50)")]
       //public string? other9 { get; set; }

       //[Column("other10", Order = 36, TypeName = "varchar(50)")]
       //public string? other10 { get; set; }

       //[Column("other11", Order = 37, TypeName = "varchar(50)")]
       //public string? other11 { get; set; }

       //[Column("other12", Order = 38, TypeName = "varchar(50)")]
       //public string? other12 { get; set; }

       //[Column("other13", Order = 39, TypeName = "varchar(50)")]
       //public string? other13 { get; set; }

       //[Column("other14", Order = 40, TypeName = "varchar(50)")]
       //public string? other14 { get; set; }

       //[Column("other15", Order = 41, TypeName = "varchar(50)")]
       //public string? other15 { get; set; }

       //[Column("other16", Order = 42, TypeName = "varchar(50)")]
       //public string? other16 { get; set; }

       //[Column("other17", Order = 43, TypeName = "varchar(50)")]
       //public string? other17 { get; set; }

       //[Column("other18", Order = 44, TypeName = "varchar(50)")]
       //public string? other18 { get; set; }

       //[Column("other19", Order = 45, TypeName = "varchar(50)")]
       //public string? other19 { get; set; }

       //[Column("other20", Order = 46, TypeName = "varchar(50)")]
       // public string? other20 { get; set; }

        [Column("sale_format", Order = 47, TypeName = "varchar(250)")]
       public string? sale_format { get; set; }

       [Column("home_state", Order = 48, TypeName = "varchar(250)")]
       public string? home_state { get; set; }

       [Column("email_sender", Order = 49, TypeName = "varchar(250)")]
       public string? email_sender { get; set; }

       [Column("email_receiver", Order = 50, TypeName = "varchar(250)")]
       public string? email_receiver { get; set; }

       [Column("ch_bill_header_name", Order = 51, TypeName = "varchar(100)")]
       public string? ch_bill_header_name { get; set; }

       [Column("ss_bill_header_name", Order = 52, TypeName = "varchar(100)")]
       public string? ss_bill_header_name { get; set; }

       [Column("sr_bill_header_name", Order = 53, TypeName = "varchar(100)")]
       public string? sr_bill_header_name { get; set; }

       [Column("pp_bill_header_name", Order = 54, TypeName = "varchar(100)")]
       public string? pp_bill_header_name { get; set; }

       [Column("pr_bill_header_name", Order = 55, TypeName = "varchar(100)")]
       public string? pr_bill_header_name { get; set; }

       [Column("po_bill_header_name", Order = 56, TypeName = "varchar(100)")]
       public string? po_bill_header_name { get; set; }

       [Column("so_bill_header_name", Order = 57, TypeName = "varchar(100)")]
       public string? so_bill_header_name { get; set; }

       [Column("rc_bill_header_name", Order = 58, TypeName = "text")]
       public string? rc_bill_header_name { get; set; }

       [Column("qu_bill_header_name", Order = 59, TypeName = "varchar(100)")]
       public string? qu_bill_header_name { get; set; }

       [Column("rounded_off", Order = 60, TypeName = "varchar(15)")]
       public string? rounded_off { get; set; }

       [Column("c_rta_id", Order = 61, TypeName = "varchar(100)")]
       public string? c_rta_id { get; set; }

       [Column("c_operator_id", Order = 62, TypeName = "varchar(100)")]
       public string? c_operator_id { get; set; }

       [Column("p_register_comp_add", Order = 63, TypeName = "text")]
       public string? p_register_comp_add { get; set; }

       [Column("data_validation_check_yn", Order = 64, TypeName = "varchar(3)")]
       public string? data_validation_check_yn { get; set; }

        [Column("cart_tcs_value", Order = 65, TypeName = "float")]
        public double? cart_tcs_value { get; set; }

        [Column("bill_type_method", Order = 66, TypeName = "text")]
        public string? bill_type_method { get; set; }

        [Column("batch_no", Order = 67, TypeName = "text")]
        public string? batch_no { get; set; }

        [Column("style", Order = 68, TypeName = "text")]
        public string? style { get; set; }

        [Column("brand", Order = 69, TypeName = "text")]
        public string? brand { get; set; }

        [Column("color", Order = 70, TypeName = "text")]
        public string? color { get; set; }

        [Column("agent", Order = 71, TypeName = "text")]
        public string? agent { get; set; }

        [Column("dealer", Order = 72, TypeName = "text")]
        public string? dealer { get; set; }

        [Column("round_off", Order = 73, TypeName = "text")]
        public string? round_off { get; set; }

        [Column("transporter_cartage_yn", Order = 74, TypeName = "text")]
        public string? transporter_cartage_yn { get; set; }

        [Column("maintain_accounting_yn", Order = 75, TypeName = "text")]
        public string? maintain_accounting_yn { get; set; }

        [Column("challan_master_method", Order = 76, TypeName = "text")]
        public string? challan_master_method { get; set; }

        [Column("purchase_rate_yn", Order = 77, TypeName = "text")]
        public string? purchase_rate_yn { get; set; }

        [Column("profit_yn", Order = 78, TypeName = "text")]
        public string? profit_yn { get; set; }

        [Column("discount_amount_yn", Order = 79, TypeName = "text")]
        public string? discount_amount_yn { get; set; }

        [Column("discount_rate_yn", Order = 80, TypeName = "text")]
        public string? discount_rate_yn { get; set; }

        [Column("gst_amount_yn", Order = 81, TypeName = "text")]
        public string? gst_amount_yn { get; set; }

        [Column("total_profit_yn", Order = 82, TypeName = "text")]
        public string? total_profit_yn { get; set; }

        [Column("total_weight_yn", Order = 83, TypeName = "text")]
        public string? total_weight_yn { get; set; }

        [Column("gst_rate_yn", Order = 84, TypeName = "text")]
        public string? gst_rate_yn { get; set; }

        [Column("pc_rmt_pp_yn", Order = 86, TypeName = "text")]
        public string? pc_rmt_pp_yn { get; set; }

        [Column("agr_qty_yn", Order = 87, TypeName = "text")]
        public string? agr_qty_yn { get; set; }

        [Column("rent_rate_yn", Order = 88, TypeName = "text")]
        public string? rent_rate_yn { get; set; }

        [Column("missing_yn", Order = 89, TypeName = "text")]
        public string? missing_yn { get; set; }

        [Column("damage_yn", Order = 90, TypeName = "text")]
        public string? damage_yn { get; set; }

        [Column("opening_yn", Order = 91, TypeName = "text")]
        public string? opening_yn { get; set; }

        [Column("delete_at", Order = 92, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("created_at", Order = 93, TypeName = "datetime")]
        public DateTime? created_at { get; set; } 

        [Column("updated_at", Order = 94, TypeName = "datetime")]
        public DateTime? updated_at { get; set; }

        [Column("old_software_code_ya_id", Order = 95, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        [Column("irflag", Order = 96, TypeName = "text")]
        public string? irflag { get; set; }

        [Column("otp_req_deletion_yn", Order = 97, TypeName = "text")]
        public string? otp_req_deletion_yn { get; set; }

        [Column("hsn_code_yn", Order = 99, TypeName = "text")]
        public string? hsn_code_yn { get; set; }

        [Column("packing_type_yn", Order = 100, TypeName = "text")]
        public string? packing_type_yn { get; set; }

        [Column("scheme_type_yn", Order = 101, TypeName = "text")]
        public string? scheme_type_yn { get; set; }

        [Column("remarks_yn", Order = 102, TypeName = "text")]
        public string? remarks_yn { get; set; }

        [Column("sale_rate_yn", Order = 103, TypeName = "text")]
        public string? sale_rate_yn { get; set; }

        [Column("issue_qty_yn", Order = 104, TypeName = "text")]
        public string? issue_qty_yn { get; set; }

        [Column("discount_percentage_yn", Order = 105, TypeName = "text")]
        public string? discount_percentage_yn { get; set; }

        [Column("grand_total_yn", Order = 106, TypeName = "text")]
        public string? grand_total_yn { get; set; }

        [Column("gst_percentage_yn", Order = 107, TypeName = "text")]
        public string? gst_percentage_yn { get; set; }

        [Column("rate_after_gst_yn", Order = 108, TypeName = "text")]
        public string? rate_after_gst_yn { get; set; }

        [Column("total_amount_yn", Order = 109, TypeName = "text")]
        public string? total_amount_yn { get; set; }

        [Column("current_stock_yn", Order = 110, TypeName = "text")]
        public string? current_stock_yn { get; set; }

        [Column("balance_qty_yn", Order = 111, TypeName = "text")]
        public string? balance_qty_yn { get; set; }

        [Column("recv_qty_yn", Order = 112, TypeName = "text")]
        public string? recv_qty_yn { get; set; }

        [Column("sale_qty_yn", Order = 113, TypeName = "text")]
        public string? sale_qty_yn { get; set; }

        [Column("purchase_qty_yn", Order = 114, TypeName = "text")]
        public string? purchase_qty_yn { get; set; }

        [Column("system_invoice", Order = 115, TypeName = "text")]
        public string? system_invoice { get; set; }

        [Column("company_about", Order = 116, TypeName = "text")]
        public string? company_about { get; set; }

        [Column("company_image", Order = 117, TypeName = "text")]
        public string? company_image { get; set; }

        [Column("company_logo", Order = 118, TypeName = "text")]
        public string? company_logo { get; set; }

        [Column("facebook_link", Order = 119, TypeName = "text")]
        public string? facebook_link { get; set; }

        [Column("twitter_link", Order = 120, TypeName = "text")]
        public string? twitter_link { get; set; }

        [Column("youtube_link", Order = 121, TypeName = "text")]
        public string? youtube_link { get; set; }

        [Column("linkedin_link", Order = 122, TypeName = "text")]
        public string? linkedin_link { get; set; }

        [Column("map_link", Order = 123, TypeName = "text")]
        public string? map_link { get; set; }

        [Column("private_policy", Order = 124, TypeName = "text")]
        public string? private_policy { get; set; }

        [Column("business_card_link", Order = 126, TypeName = "text")]
        public string? business_card_link { get; set; }

        [Column("vendor_code", Order =127, TypeName = "text")]
        public string? vendor_code { get; set; }
       
        [Column("sms_provider_user_id", Order = 128, TypeName = "text")]
        public string? sms_provider_user_id { get; set; }

        [Column("sms_provider_user_pass", Order = 129, TypeName = "text")]
        public string? sms_provider_user_pass { get; set; }

        [Column("sms_provider_gsmid", Order = 130, TypeName = "text")]
        public string? sms_provider_gsmid { get; set; }

        [Column("sms_provider_peid", Order = 131, TypeName = "text")]
        public string? sms_provider_peid { get; set; }

        [Column("sms_unicode", Order = 132, TypeName = "text")]
        public string? sms_unicode { get; set; }

        [Column("sms_base_url", Order = 133, TypeName = "text")]
        public string? sms_base_url { get; set; }
        
        [Column("comp_email_for_otp", Order = 134, TypeName = "text")]
        public string? comp_email_for_otp { get; set; }

        [Column("comp_otp_email_pass", Order = 135, TypeName = "text")]
        public string? comp_otp_email_pass { get; set; }

        [Column("comp_api_baseurl", Order = 136, TypeName = "text")]
        public string? comp_api_baseurl { get; set; }

         [Column("comp_email_server", Order = 137, TypeName = "text")]
        public string? comp_email_server { get; set; }

        [Column("comp_email_port", Order = 138, TypeName = "bigint(10)")]
        public int? comp_email_port { get; set; }

        [Column("comp_email_username", Order = 139, TypeName = "text")]
        public string? comp_email_username { get; set; }
        
        [Column("comp_email_alias_name", Order = 140, TypeName = "text")]
        public string? comp_email_alias_name { get; set; }

        [Column("comp_email_security", Order = 141, TypeName = "text")]
        public string? comp_email_security { get; set; } = "SSL";        

       [Column("comp_login_otp_type", Order = 142, TypeName = "varchar(50)")]
       public string? comp_login_otp_type { get; set; }
        
        [Column("user_mobile", Order = 143, TypeName = "text")]
        public string? user_mobile { get; set; }
        
        [Column("user_name", Order = 144, TypeName = "text")]
        public string? user_name { get; set; }
        
        [Column("user_email", Order = 145, TypeName = "text")]
        public string? user_email { get; set; }

        [Column("created_on", Order = 146, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 147, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }


    }
}
