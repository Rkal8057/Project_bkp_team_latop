using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Recent_Comp_Selection_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("c_comp_sno", Order = 2, TypeName = "float")]
       public long? c_comp_sno { get; set; }

       [Column("c_comp_isin", Order = 3, TypeName = "varchar(100)")]
       public string? c_comp_isin { get; set; }

       [Column("c_comp_name", Order = 4, TypeName = "varchar(100)")]
       public string? c_comp_name { get; set; }

       [Column("c_comp_short_name", Order = 5, TypeName = "varchar(100)")]
       public string? c_comp_short_name { get; set; }

       [Column("c_paid_up_capital", Order = 6, TypeName = "text")]
       public string? c_paid_up_capital { get; set; }

       [Column("c_add1", Order = 7, TypeName = "varchar(100)")]
       public string? c_add1 { get; set; }

       [Column("c_add2", Order = 8, TypeName = "varchar(100)")]
       public string? c_add2 { get; set; }

       [Column("c_add3", Order = 9, TypeName = "varchar(100)")]
       public string? c_add3 { get; set; }

       [Column("c_add4", Order = 10, TypeName = "varchar(100)")]
       public string? c_add4 { get; set; }

       [Column("c_city", Order = 11, TypeName = "varchar(100)")]
       public string? c_city { get; set; }

       [Column("c_database_name", Order = 12, TypeName = "varchar(100)")]
       public string? c_database_name { get; set; }

       [Column("c_state", Order = 13, TypeName = "varchar(100)")]
       public string? c_state { get; set; }

       [Column("c_state_code", Order = 14, TypeName = "varchar(10)")]
       public string? c_state_code { get; set; }

       [Column("c_email", Order = 15, TypeName = "text")]
       public string? c_email { get; set; }

       [Column("c_website", Order = 16, TypeName = "text")]
       public string? c_website { get; set; }

       [Column("c_phones", Order = 17, TypeName = "text")]
       public string? c_phones { get; set; }

       [Column("c_contact_person", Order = 18, TypeName = "text")]
       public string? c_contact_person { get; set; }

       [Column("c_gstin", Order = 19, TypeName = "varchar(50)")]
       public string? c_gstin { get; set; }

       [Column("c_gst_type", Order = 20, TypeName = "varchar(50)")]
       public string? c_gst_type { get; set; }

       [Column("c_pan", Order = 21, TypeName = "varchar(50)")]
       public string? c_pan { get; set; }

       [Column("c_bank_ac_no", Order = 22, TypeName = "varchar(50)")]
       public string? c_bank_ac_no { get; set; }

       [Column("c_bank_name", Order = 23, TypeName = "varchar(50)")]
       public string? c_bank_name { get; set; }

       [Column("c_badd1", Order = 24, TypeName = "varchar(100)")]
       public string? c_badd1 { get; set; }

       [Column("c_badd2", Order = 25, TypeName = "varchar(100)")]
       public string? c_badd2 { get; set; }

       [Column("c_badd3", Order = 26, TypeName = "varchar(100)")]
       public string? c_badd3 { get; set; }

       [Column("c_bcity", Order = 27, TypeName = "varchar(100)")]
       public string? c_bcity { get; set; }

       [Column("c_bstate", Order = 28, TypeName = "varchar(100)")]
       public string? c_bstate { get; set; }

       [Column("c_bstate_code", Order = 29, TypeName = "varchar(10)")]
       public string? c_bstate_code { get; set; }

       [Column("c_bank_ifsc", Order = 30, TypeName = "varchar(50)")]
       public string? c_bank_ifsc { get; set; }

       [Column("c_bank_micr", Order = 31, TypeName = "varchar(50)")]
       public string? c_bank_micr { get; set; }

       [Column("c_create_date", Order = 32, TypeName = "datetime")]
       public DateTime? c_create_date { get; set; }

       [Column("c_temp_comp_id", Order = 33, TypeName = "varchar(50)")]
       public string? c_temp_comp_id { get; set; }

       [Column("c_share_face_value", Order = 34, TypeName = "float")]
       public long? c_share_face_value { get; set; }

       [Column("c_folio_no_auto_yn", Order = 35, TypeName = "varchar(3)")]
       public string? c_folio_no_auto_yn { get; set; }

       [Column("c_company_type", Order = 36, TypeName = "varchar(50)")]
       public string? c_company_type { get; set; }

       [Column("c_cin_bcin_no", Order = 37, TypeName = "varchar(50)")]
       public string? c_cin_bcin_no { get; set; }

       [Column("c_company_code", Order = 38, TypeName = "varchar(4)")]
       public string? c_company_code { get; set; }

       [Column("c_company_sub_code", Order = 39, TypeName = "varchar(4)")]
       public string? c_company_sub_code { get; set; }

       [Column("c_database_type", Order = 40, TypeName = "varchar(50)")]
       public string? c_database_type { get; set; }

       [Column("c_more_isin_yn", Order = 41, TypeName = "varchar(3)")]
       public string? c_more_isin_yn { get; set; }

       [Column("c_master_comp_isin", Order = 42, TypeName = "varchar(12)")]
       public string? c_master_comp_isin { get; set; }

       [Column("c_master_comp_code", Order = 43, TypeName = "double(18,3)")]
       public long? c_master_comp_code { get; set; }

       [Column("c_master_comp_name", Order = 44, TypeName = "text")]
       public string? c_master_comp_name { get; set; }

       [Column("c_nsdl_conn_yn", Order = 45, TypeName = "varchar(3)")]
       public string? c_nsdl_conn_yn { get; set; }

       [Column("c_cdsl_conn_yn", Order = 46, TypeName = "varchar(3)")]
       public string? c_cdsl_conn_yn { get; set; }

       [Column("c_phy_shares_yn", Order = 47, TypeName = "varchar(3)")]
       public string? c_phy_shares_yn { get; set; }

       [Column("c_tan", Order = 48, TypeName = "varchar(10)")]
       public string? c_tan { get; set; }

       [Column("c_isin_detail", Order = 49, TypeName = "text")]
       public string? c_isin_detail { get; set; }

       [Column("c_pay_term_days", Order = 50, TypeName = "double(18,3)")]
       public long? c_pay_term_days { get; set; }

       [Column("c_pay_term_detail", Order = 51, TypeName = "text")]
       public string? c_pay_term_detail { get; set; }

       [Column("c_other_detail", Order = 52, TypeName = "text")]
       public string? c_other_detail { get; set; }

       [Column("c_d_o_activate", Order = 53, TypeName = "datetime")]
       public DateTime? c_d_o_activate { get; set; }

       [Column("c_d_o_apply", Order = 54, TypeName = "datetime")]
       public DateTime? c_d_o_apply { get; set; }

       [Column("c_d_o_creation", Order = 55, TypeName = "datetime")]
       public DateTime? c_d_o_creation { get; set; }

       [Column("c_created_by", Order = 56, TypeName = "text")]
       public string? c_created_by { get; set; }

       [Column("c_d_o_updation", Order = 57, TypeName = "datetime")]
       public DateTime? c_d_o_updation { get; set; }

       [Column("c_updated_by", Order = 58, TypeName = "text")]
       public string? c_updated_by { get; set; }

       [Column("c_contact_person2", Order = 59, TypeName = "varchar(100)")]
       public string? c_contact_person2 { get; set; }

       [Column("c_contact_ph", Order = 60, TypeName = "varchar(100)")]
       public string? c_contact_ph { get; set; }

       [Column("c_contact_ph2", Order = 61, TypeName = "varchar(100)")]
       public string? c_contact_ph2 { get; set; }

       [Column("c_contact_p_email", Order = 62, TypeName = "varchar(100)")]
       public string? c_contact_p_email { get; set; }

       [Column("c_contact_p_email2", Order = 63, TypeName = "varchar(100)")]
       public string? c_contact_p_email2 { get; set; }

       [Column("c_add1_2", Order = 64, TypeName = "text")]
       public string? c_add1_2 { get; set; }

       [Column("c_add2_2", Order = 65, TypeName = "text")]
       public string? c_add2_2 { get; set; }

       [Column("c_add3_2", Order = 66, TypeName = "text")]
       public string? c_add3_2 { get; set; }

       [Column("c_city2", Order = 67, TypeName = "varchar(100)")]
       public string? c_city2 { get; set; }

       [Column("c_pincode_2", Order = 68, TypeName = "varchar(10)")]
       public string? c_pincode_2 { get; set; }

       [Column("c_state2", Order = 69, TypeName = "varchar(100)")]
       public string? c_state2 { get; set; }

       [Column("c_state_code2", Order = 70, TypeName = "varchar(10)")]
       public string? c_state_code2 { get; set; }

       [Column("c_list_to_email_yn", Order = 71, TypeName = "text")]
       public string? c_list_to_email_yn { get; set; }

       [Column("c_rep_top10_email_yn", Order = 72, TypeName = "text")]
       public string? c_rep_top10_email_yn { get; set; }

       [Column("c_other_rpt_email_yn", Order = 73, TypeName = "text")]
       public string? c_other_rpt_email_yn { get; set; }

       [Column("c_source_email_yn", Order = 74, TypeName = "text")]
       public string? c_source_email_yn { get; set; }

       [Column("c_maintain_type", Order = 75, TypeName = "varchar(250)")]
       public string? c_maintain_type { get; set; }

       [Column("c_data_tyep_description", Order = 76, TypeName = "varchar(50)")]
       public string? c_data_tyep_description { get; set; }

       [Column("c_isin_type", Order = 77, TypeName = "varchar(50)")]
       public string? c_isin_type { get; set; }

       [Column("c_phy_demat_both", Order = 78, TypeName = "varchar(50)")]
       public string? c_phy_demat_both { get; set; }

       [Column("c_pincode", Order = 79, TypeName = "varchar(10)")]
       public string? c_pincode { get; set; }

       [Column("c_group_name", Order = 80, TypeName = "varchar(100)")]
       public string? c_group_name { get; set; }

       [Column("c_issuer_code", Order = 81, TypeName = "varchar(100)")]
       public string? c_issuer_code { get; set; }

       [Column("c_phy_conn_yn", Order = 82, TypeName = "varchar(3)")]
       public string? c_phy_conn_yn { get; set; }

       [Column("c_rep_weekly_email_yn", Order = 83, TypeName = "varchar(3)")]
       public string? c_rep_weekly_email_yn { get; set; }

       [Column("c_company_old_code", Order = 84, TypeName = "varchar(100)")]
       public string? c_company_old_code { get; set; }

       [Column("c_tot_equity", Order = 85, TypeName = "double(18,3)")]
       public long? c_tot_equity { get; set; }

       [Column("cin_bcin_no", Order = 86, TypeName = "varchar(50)")]
       public string? cin_bcin_no { get; set; }

       [Column("folio_no_auto_yn", Order = 87, TypeName = "varchar(1)")]
       public string? folio_no_auto_yn { get; set; }

       [Column("temp_comp_id", Order = 88, TypeName = "varchar(50)")]
       public string? temp_comp_id { get; set; }

       [Column("used_on_date_time", Order = 89, TypeName = "datetime")]
       public DateTime? used_on_date_time { get; set; }

       [Column("c_comp_auto_id", Order = 90, TypeName = "double(18,3)")]
       public long? c_comp_auto_id { get; set; }

       [Column("c_tot_equity_fully", Order = 91, TypeName = "double(18,3)")]
       public long? c_tot_equity_fully { get; set; }

       [Column("c_tot_equity_partly", Order = 92, TypeName = "double(18,3)")]
       public long? c_tot_equity_partly { get; set; }

       [Column("c_share_face_value_partly", Order = 93, TypeName = "double(18,3)")]
       public long? c_share_face_value_partly { get; set; }

   }
}
