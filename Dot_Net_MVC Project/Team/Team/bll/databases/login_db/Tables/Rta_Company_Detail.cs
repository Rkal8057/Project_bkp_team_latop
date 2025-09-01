using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Rta_Company_Detail
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("upload_id_cdsl", Order = 3, TypeName = "text")]
       public string? upload_id_cdsl { get; set; }

       [Column("operator_id_cdsl", Order = 4, TypeName = "text")]
       public string? operator_id_cdsl { get; set; }

       [Column("upload_id_nsdl", Order = 5, TypeName = "text")]
       public string? upload_id_nsdl { get; set; }

       [Column("operator_id_nsdl", Order = 6, TypeName = "text")]
       public string? operator_id_nsdl { get; set; }

       [Column("ph_nos", Order = 7, TypeName = "text")]
       public string? ph_nos { get; set; }

       [Column("website_address", Order = 8, TypeName = "text")]
       public string? website_address { get; set; }

       [Column("email_address", Order = 9, TypeName = "text")]
       public string? email_address { get; set; }

       [Column("owner_nanme", Order = 10, TypeName = "text")]
       public string? owner_nanme { get; set; }

       [Column("company_pcode", Order = 11, TypeName = "double(18,3)")]
       public long? company_pcode { get; set; }

       [Column("company_short", Order = 12, TypeName = "text")]
       public string? company_short { get; set; }

       [Column("updated_by", Order = 13, TypeName = "text")]
       public string? updated_by { get; set; }

       [Column("created_by", Order = 14, TypeName = "text")]
       public string? created_by { get; set; }

       [Column("updated_on", Order = 15, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("created_on", Order = 16, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("activate_date", Order = 17, TypeName = "datetime")]
       public DateTime? activate_date { get; set; }

       [Column("de_activate_date", Order = 18, TypeName = "datetime")]
       public DateTime? de_activate_date { get; set; }

       [Column("detail_remark", Order = 19, TypeName = "text")]
       public string? detail_remark { get; set; }

       [Column("isin_detail", Order = 20, TypeName = "text")]
       public string? isin_detail { get; set; }

       [Column("tan_no", Order = 21, TypeName = "text")]
       public string? tan_no { get; set; }

       [Column("company_name", Order = 22, TypeName = "text")]
       public string? company_name { get; set; }

       [Column("cin_no", Order = 23, TypeName = "text")]
       public string? cin_no { get; set; }

       [Column("pan_no", Order = 24, TypeName = "text")]
       public string? pan_no { get; set; }

       [Column("register_gstin", Order = 25, TypeName = "text")]
       public string? register_gstin { get; set; }

       [Column("isin_no", Order = 26, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("branch_off_email", Order = 27, TypeName = "text")]
       public string? branch_off_email { get; set; }

       [Column("register_email", Order = 28, TypeName = "text")]
       public string? register_email { get; set; }

       [Column("register_country", Order = 29, TypeName = "text")]
       public string? register_country { get; set; }

       [Column("branch_off_country", Order = 30, TypeName = "text")]
       public string? branch_off_country { get; set; }

       [Column("branch_off_pincode", Order = 31, TypeName = "text")]
       public string? branch_off_pincode { get; set; }

       [Column("branch_off_state_code", Order = 32, TypeName = "text")]
       public string? branch_off_state_code { get; set; }

       [Column("branch_off_state_name", Order = 33, TypeName = "text")]
       public string? branch_off_state_name { get; set; }

       [Column("branch_off_city", Order = 34, TypeName = "text")]
       public string? branch_off_city { get; set; }

       [Column("branch_off_location", Order = 35, TypeName = "text")]
       public string? branch_off_location { get; set; }

       [Column("branch_off_add_2", Order = 36, TypeName = "text")]
       public string? branch_off_add_2 { get; set; }

       [Column("branch_off_add_1", Order = 37, TypeName = "text")]
       public string? branch_off_add_1 { get; set; }

       [Column("register_pincode", Order = 38, TypeName = "text")]
       public string? register_pincode { get; set; }

       [Column("branch_off_mobile_ph", Order = 39, TypeName = "text")]
       public string? branch_off_mobile_ph { get; set; }

       [Column("branch_off_landline_ph", Order = 40, TypeName = "text")]
       public string? branch_off_landline_ph { get; set; }

       [Column("branch_off_contact_person", Order = 41, TypeName = "text")]
       public string? branch_off_contact_person { get; set; }

       [Column("resister_mobile_ph", Order = 42, TypeName = "text")]
       public string? resister_mobile_ph { get; set; }

       [Column("resister_landline_ph", Order = 43, TypeName = "text")]
       public string? resister_landline_ph { get; set; }

       [Column("resister_contact_person", Order = 44, TypeName = "text")]
       public string? resister_contact_person { get; set; }

       [Column("register_add_1", Order = 45, TypeName = "text")]
       public string? register_add_1 { get; set; }

       [Column("register_add_2", Order = 46, TypeName = "text")]
       public string? register_add_2 { get; set; }

       [Column("register_location", Order = 47, TypeName = "text")]
       public string? register_location { get; set; }

       [Column("register_city", Order = 48, TypeName = "text")]
       public string? register_city { get; set; }

       [Column("register_state_name", Order = 49, TypeName = "text")]
       public string? register_state_name { get; set; }

       [Column("bank_contact_person", Order = 50, TypeName = "text")]
       public string? bank_contact_person { get; set; }

       [Column("bank_email", Order = 51, TypeName = "text")]
       public string? bank_email { get; set; }

       [Column("bank_mobile_ph", Order = 52, TypeName = "text")]
       public string? bank_mobile_ph { get; set; }

       [Column("bank_landline_ph", Order = 53, TypeName = "text")]
       public string? bank_landline_ph { get; set; }

       [Column("bstate_country", Order = 54, TypeName = "text")]
       public string? bstate_country { get; set; }

       [Column("bank_location", Order = 55, TypeName = "text")]
       public string? bank_location { get; set; }

       [Column("bstate", Order = 56, TypeName = "text")]
       public string? bstate { get; set; }

       [Column("bcity", Order = 57, TypeName = "text")]
       public string? bcity { get; set; }

       [Column("badd3", Order = 58, TypeName = "text")]
       public string? badd3 { get; set; }

       [Column("badd2", Order = 59, TypeName = "text")]
       public string? badd2 { get; set; }

       [Column("badd1", Order = 60, TypeName = "text")]
       public string? badd1 { get; set; }

       [Column("bank_micr", Order = 61, TypeName = "text")]
       public string? bank_micr { get; set; }

       [Column("bank_ifsc", Order = 62, TypeName = "text")]
       public string? bank_ifsc { get; set; }

       [Column("bank_ac_no", Order = 63, TypeName = "text")]
       public string? bank_ac_no { get; set; }

       [Column("bank_name", Order = 64, TypeName = "text")]
       public string? bank_name { get; set; }

       [Column("depository_detail", Order = 65, TypeName = "text")]
       public string? depository_detail { get; set; }

       [Column("member_in_exchange", Order = 66, TypeName = "text")]
       public string? member_in_exchange { get; set; }

       [Column("category_type", Order = 67, TypeName = "text")]
       public string? category_type { get; set; }

       [Column("compliance_officer", Order = 68, TypeName = "text")]
       public string? compliance_officer { get; set; }

       [Column("compliance_officer_mob", Order = 69, TypeName = "text")]
       public string? compliance_officer_mob { get; set; }

   }
}
