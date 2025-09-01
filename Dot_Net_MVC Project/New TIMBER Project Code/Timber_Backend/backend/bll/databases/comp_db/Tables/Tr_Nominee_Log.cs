using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_nominee_log")] 
       
   public class Tr_Nominee_Log
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trfno", Order = 2, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("comp_sno", Order = 3, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 4, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 5, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 6, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("vou_type", Order = 7, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("current_status", Order = 8, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("entry_by_maker", Order = 9, TypeName = "varchar(50)")]
       public string? entry_by_maker { get; set; }

       [Column("entry_check_by_checker", Order = 10, TypeName = "varchar(50)")]
       public string? entry_check_by_checker { get; set; }

       [Column("checker_username", Order = 11, TypeName = "varchar(50)")]
       public string? checker_username { get; set; }

       [Column("remarks", Order = 12, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("trfolio", Order = 13, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("trfdate", Order = 14, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("recdate", Order = 15, TypeName = "datetime")]
       public DateTime? recdate { get; set; }

       [Column("dmdate", Order = 16, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("dpidno", Order = 17, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 18, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("printcode", Order = 19, TypeName = "varchar(100)")]
       public string? printcode { get; set; }

       [Column("rtag", Order = 20, TypeName = "varchar(100)")]
       public string? rtag { get; set; }

       [Column("rejres", Order = 21, TypeName = "varchar(100)")]
       public string? rejres { get; set; }

       [Column("rflag", Order = 22, TypeName = "varchar(100)")]
       public string? rflag { get; set; }

       [Column("csflag", Order = 23, TypeName = "varchar(100)")]
       public string? csflag { get; set; }

       [Column("panno", Order = 24, TypeName = "varchar(20)")]
       public string? panno { get; set; }

       [Column("derno", Order = 25, TypeName = "varchar(250)")]
       public string? derno { get; set; }

       [Column("derno_rrno", Order = 26, TypeName = "varchar(250)")]
       public string? derno_rrno { get; set; }

       [Column("req_no", Order = 27, TypeName = "varchar(50)")]
       public string? req_no { get; set; }

       [Column("req_date", Order = 28, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_comp_date", Order = 29, TypeName = "datetime")]
       public DateTime? req_comp_date { get; set; }

       [Column("req_foliono", Order = 30, TypeName = "varchar(50)")]
       public string? req_foliono { get; set; }

       [Column("req_folio_name", Order = 31, TypeName = "varchar(50)")]
       public string? req_folio_name { get; set; }

       [Column("value_date", Order = 32, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("entey_date", Order = 33, TypeName = "datetime")]
       public DateTime? entey_date { get; set; }

       [Column("user_name", Order = 34, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 35, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("reject_code", Order = 36, TypeName = "varchar(50)")]
       public string? reject_code { get; set; }

       [Column("reject_remark", Order = 37, TypeName = "varchar(50)")]
       public string? reject_remark { get; set; }

       [Column("create_new", Order = 38, TypeName = "varchar(100)")]
       public string? create_new { get; set; }

       [Column("vou_action_type", Order = 39, TypeName = "varchar(50)")]
       public string? vou_action_type { get; set; }

       [Column("share_accept_yn", Order = 40, TypeName = "varchar(50)")]
       public string? share_accept_yn { get; set; }

       [Column("reject_code_grid", Order = 41, TypeName = "varchar(50)")]
       public string? reject_code_grid { get; set; }

       [Column("reject_remark_grid", Order = 42, TypeName = "varchar(50)")]
       public string? reject_remark_grid { get; set; }

       [Column("n_name", Order = 43, TypeName = "varchar(50)")]
       public string? n_name { get; set; }

       [Column("n_pan", Order = 44, TypeName = "varchar(20)")]
       public string? n_pan { get; set; }

       [Column("n_relation", Order = 45, TypeName = "varchar(50)")]
       public string? n_relation { get; set; }

       [Column("n_f_m_w_name", Order = 46, TypeName = "varchar(50)")]
       public string? n_f_m_w_name { get; set; }

       [Column("n_m_f", Order = 47, TypeName = "varchar(50)")]
       public string? n_m_f { get; set; }

       [Column("n_nsdl_id_1", Order = 48, TypeName = "varchar(8)")]
       public string? n_nsdl_id_1 { get; set; }

       [Column("n_nsdl_id_2", Order = 49, TypeName = "varchar(8)")]
       public string? n_nsdl_id_2 { get; set; }

       [Column("n_cdsl_id_1", Order = 50, TypeName = "varchar(8)")]
       public string? n_cdsl_id_1 { get; set; }

       [Column("n_cl_id", Order = 51, TypeName = "varchar(8)")]
       public string? n_cl_id { get; set; }

       [Column("n_dob", Order = 52, TypeName = "varchar(50)")]
       public string? n_dob { get; set; }

       [Column("n_phone", Order = 53, TypeName = "varchar(50)")]
       public string? n_phone { get; set; }

       [Column("n_add2", Order = 54, TypeName = "varchar(50)")]
       public string? n_add2 { get; set; }

       [Column("n_add1", Order = 55, TypeName = "varchar(50)")]
       public string? n_add1 { get; set; }

       [Column("n_city", Order = 56, TypeName = "varchar(50)")]
       public string? n_city { get; set; }

       [Column("n_pincode", Order = 57, TypeName = "varchar(50)")]
       public string? n_pincode { get; set; }

       [Column("n_state", Order = 58, TypeName = "varchar(50)")]
       public string? n_state { get; set; }

       [Column("n_country", Order = 59, TypeName = "varchar(50)")]
       public string? n_country { get; set; }

       [Column("n_email", Order = 60, TypeName = "varchar(50)")]
       public string? n_email { get; set; }

       [Column("n_occupation_det", Order = 61, TypeName = "varchar(50)")]
       public string? n_occupation_det { get; set; }

       [Column("nominee_opting_out_yn", Order = 62, TypeName = "varchar(1)")]
       public string? nominee_opting_out_yn { get; set; }

       [Column("nominee_is_a_minor_yn", Order = 63, TypeName = "varchar(1)")]
       public string? nominee_is_a_minor_yn { get; set; }

       [Column("n_date_of_att_majority", Order = 64, TypeName = "varchar(100)")]
       public string? n_date_of_att_majority { get; set; }

       [Column("n_gaurdian_name", Order = 65, TypeName = "varchar(50)")]
       public string? n_gaurdian_name { get; set; }

       [Column("n_gaurdian_address", Order = 66, TypeName = "varchar(50)")]
       public string? n_gaurdian_address { get; set; }

       [Column("n_name_new", Order = 67, TypeName = "varchar(50)")]
       public string? n_name_new { get; set; }

       [Column("n_pan_new", Order = 68, TypeName = "varchar(20)")]
       public string? n_pan_new { get; set; }

       [Column("n_relation_new", Order = 69, TypeName = "varchar(50)")]
       public string? n_relation_new { get; set; }

       [Column("n_f_m_w_name_new", Order = 70, TypeName = "varchar(50)")]
       public string? n_f_m_w_name_new { get; set; }

       [Column("n_m_f_new", Order = 71, TypeName = "varchar(50)")]
       public string? n_m_f_new { get; set; }

       [Column("n_nsdl_id_1_new", Order = 72, TypeName = "varchar(8)")]
       public string? n_nsdl_id_1_new { get; set; }

       [Column("n_nsdl_id_2_new", Order = 73, TypeName = "varchar(8)")]
       public string? n_nsdl_id_2_new { get; set; }

       [Column("n_cdsl_id_1_new", Order = 74, TypeName = "varchar(8)")]
       public string? n_cdsl_id_1_new { get; set; }

       [Column("n_cl_id_new", Order = 75, TypeName = "varchar(8)")]
       public string? n_cl_id_new { get; set; }

       [Column("n_dob_new", Order = 76, TypeName = "varchar(50)")]
       public string? n_dob_new { get; set; }

       [Column("n_phone_new", Order = 77, TypeName = "varchar(50)")]
       public string? n_phone_new { get; set; }

       [Column("n_add2_new", Order = 78, TypeName = "varchar(50)")]
       public string? n_add2_new { get; set; }

       [Column("n_add1_new", Order = 79, TypeName = "varchar(50)")]
       public string? n_add1_new { get; set; }

       [Column("n_city_new", Order = 80, TypeName = "varchar(50)")]
       public string? n_city_new { get; set; }

       [Column("n_pincode_new", Order = 81, TypeName = "varchar(50)")]
       public string? n_pincode_new { get; set; }

       [Column("n_state_new", Order = 82, TypeName = "varchar(50)")]
       public string? n_state_new { get; set; }

       [Column("n_country_new", Order = 83, TypeName = "varchar(50)")]
       public string? n_country_new { get; set; }

       [Column("n_email_new", Order = 84, TypeName = "varchar(50)")]
       public string? n_email_new { get; set; }

       [Column("n_occupation_det_new", Order = 85, TypeName = "varchar(50)")]
       public string? n_occupation_det_new { get; set; }

       [Column("nominee_opting_out_yn_new", Order = 86, TypeName = "varchar(1)")]
       public string? nominee_opting_out_yn_new { get; set; }

       [Column("nominee_is_a_minor_yn_new", Order = 87, TypeName = "varchar(1)")]
       public string? nominee_is_a_minor_yn_new { get; set; }

       [Column("n_date_of_att_majority_new", Order = 88, TypeName = "varchar(100)")]
       public string? n_date_of_att_majority_new { get; set; }

       [Column("n_gaurdian_name_new", Order = 89, TypeName = "varchar(50)")]
       public string? n_gaurdian_name_new { get; set; }

       [Column("n_gaurdian_address_new", Order = 90, TypeName = "varchar(50)")]
       public string? n_gaurdian_address_new { get; set; }

       [Column("trx_remark", Order = 91, TypeName = "varchar(50)")]
       public string? trx_remark { get; set; }

       [Column("trx_multi_reject_codes", Order = 92, TypeName = "varchar(50)")]
       public string? trx_multi_reject_codes { get; set; }

       [Column("trx_setup_date", Order = 93, TypeName = "datetime")]
       public DateTime? trx_setup_date { get; set; }

       [Column("trx_uploaded_to_exchange_yn", Order = 94, TypeName = "varchar(3)")]
       public string? trx_uploaded_to_exchange_yn { get; set; }

       [Column("trx_delay_yn", Order = 95, TypeName = "varchar(3)")]
       public string? trx_delay_yn { get; set; }

       [Column("master_trfno", Order = 96, TypeName = "float")]
       public long? master_trfno { get; set; }

       [Column("p_names_2", Order = 97, TypeName = "varchar(50)")]
       public string? p_names_2 { get; set; }

       [Column("p_names_3", Order = 98, TypeName = "varchar(50)")]
       public string? p_names_3 { get; set; }

       [Column("t_names_2", Order = 99, TypeName = "varchar(50)")]
       public string? t_names_2 { get; set; }

       [Column("t_names_3", Order = 100, TypeName = "varchar(50)")]
       public string? t_names_3 { get; set; }

       [Column("demat_cum_trx_no", Order = 101, TypeName = "varchar(50)")]
       public string? demat_cum_trx_no { get; set; }

       [Column("multiple_folio", Order = 102, TypeName = "varchar(3)")]
       public string? multiple_folio { get; set; }

       [Column("rr_flag_name", Order = 103, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("p_panno2", Order = 104, TypeName = "varchar(50)")]
       public string? p_panno2 { get; set; }

       [Column("t_panno3", Order = 105, TypeName = "varchar(50)")]
       public string? t_panno3 { get; set; }

       [Column("p_panno3", Order = 106, TypeName = "varchar(50)")]
       public string? p_panno3 { get; set; }

       [Column("t_panno2", Order = 107, TypeName = "varchar(50)")]
       public string? t_panno2 { get; set; }

       [Column("mis_match_present_yn", Order = 108, TypeName = "varchar(1)")]
       public string? mis_match_present_yn { get; set; }

       [Column("mis_match_detail", Order = 109, TypeName = "varchar(50)")]
       public string? mis_match_detail { get; set; }

       [Column("name_mismatch_yn", Order = 110, TypeName = "varchar(1)")]
       public string? name_mismatch_yn { get; set; }

       [Column("name_mismatch_yn_code", Order = 111, TypeName = "varchar(10)")]
       public string? name_mismatch_yn_code { get; set; }

       [Column("share_price", Order = 112, TypeName = "float")]
       public long? share_price { get; set; }

       [Column("share_type", Order = 113, TypeName = "varchar(50)")]
       public string? share_type { get; set; }

       [Column("t_ad1", Order = 114, TypeName = "varchar(50)")]
       public string? t_ad1 { get; set; }

       [Column("t_ad2", Order = 115, TypeName = "varchar(50)")]
       public string? t_ad2 { get; set; }

       [Column("t_city", Order = 116, TypeName = "varchar(50)")]
       public string? t_city { get; set; }

       [Column("t_state", Order = 117, TypeName = "varchar(50)")]
       public string? t_state { get; set; }

       [Column("t_pincode", Order = 118, TypeName = "varchar(50)")]
       public string? t_pincode { get; set; }

       [Column("t_country_name", Order = 119, TypeName = "varchar(50)")]
       public string? t_country_name { get; set; }

       [Column("p_ad1", Order = 120, TypeName = "varchar(50)")]
       public string? p_ad1 { get; set; }

       [Column("p_ad2", Order = 121, TypeName = "varchar(50)")]
       public string? p_ad2 { get; set; }

       [Column("p_city", Order = 122, TypeName = "varchar(50)")]
       public string? p_city { get; set; }

       [Column("p_state", Order = 123, TypeName = "varchar(50)")]
       public string? p_state { get; set; }

       [Column("p_pincode", Order = 124, TypeName = "varchar(50)")]
       public string? p_pincode { get; set; }

       [Column("p_country_name", Order = 125, TypeName = "varchar(50)")]
       public string? p_country_name { get; set; }

       [Column("p_adhaar_no", Order = 126, TypeName = "varchar(30)")]
       public string? p_adhaar_no { get; set; }

       [Column("p_voter_id", Order = 127, TypeName = "varchar(30)")]
       public string? p_voter_id { get; set; }

       [Column("p_dl_no", Order = 128, TypeName = "varchar(30)")]
       public string? p_dl_no { get; set; }

       [Column("p_passport_no", Order = 129, TypeName = "varchar(30)")]
       public string? p_passport_no { get; set; }

       [Column("t_adhaar_no", Order = 130, TypeName = "varchar(30)")]
       public string? t_adhaar_no { get; set; }

       [Column("t_voter_id", Order = 131, TypeName = "varchar(30)")]
       public string? t_voter_id { get; set; }

       [Column("t_dl_no", Order = 132, TypeName = "varchar(30)")]
       public string? t_dl_no { get; set; }

       [Column("t_passport_no", Order = 133, TypeName = "varchar(30)")]
       public string? t_passport_no { get; set; }

       [Column("t_folio_address", Order = 134, TypeName = "varchar(50)")]
       public string? t_folio_address { get; set; }

       [Column("p_folio_address", Order = 135, TypeName = "varchar(50)")]
       public string? p_folio_address { get; set; }

       [Column("t_bank_ac_no", Order = 136, TypeName = "varchar(55)")]
       public string? t_bank_ac_no { get; set; }

       [Column("t_account_type", Order = 137, TypeName = "varchar(55)")]
       public string? t_account_type { get; set; }

       [Column("t_bank_name", Order = 138, TypeName = "varchar(50)")]
       public string? t_bank_name { get; set; }

       [Column("t_bank_micrno", Order = 139, TypeName = "varchar(55)")]
       public string? t_bank_micrno { get; set; }

       [Column("t_bank_ifsc_code", Order = 140, TypeName = "varchar(55)")]
       public string? t_bank_ifsc_code { get; set; }

       [Column("t_bank_add1", Order = 141, TypeName = "varchar(50)")]
       public string? t_bank_add1 { get; set; }

       [Column("t_bank_add2", Order = 142, TypeName = "varchar(50)")]
       public string? t_bank_add2 { get; set; }

       [Column("t_bank_add3", Order = 143, TypeName = "varchar(50)")]
       public string? t_bank_add3 { get; set; }

       [Column("t_bank_city", Order = 144, TypeName = "varchar(100)")]
       public string? t_bank_city { get; set; }

       [Column("t_bank_state", Order = 145, TypeName = "varchar(100)")]
       public string? t_bank_state { get; set; }

       [Column("t_bank_pincode", Order = 146, TypeName = "varchar(25)")]
       public string? t_bank_pincode { get; set; }

       [Column("t_bank_country", Order = 147, TypeName = "varchar(100)")]
       public string? t_bank_country { get; set; }

       [Column("p_bank_ac_no", Order = 148, TypeName = "varchar(55)")]
       public string? p_bank_ac_no { get; set; }

       [Column("p_account_type", Order = 149, TypeName = "varchar(55)")]
       public string? p_account_type { get; set; }

       [Column("p_bank_name", Order = 150, TypeName = "varchar(50)")]
       public string? p_bank_name { get; set; }

       [Column("p_bank_micrno", Order = 151, TypeName = "varchar(55)")]
       public string? p_bank_micrno { get; set; }

       [Column("p_bank_ifsc_code", Order = 152, TypeName = "varchar(55)")]
       public string? p_bank_ifsc_code { get; set; }

       [Column("p_bank_add1", Order = 153, TypeName = "varchar(50)")]
       public string? p_bank_add1 { get; set; }

       [Column("p_bank_add2", Order = 154, TypeName = "varchar(50)")]
       public string? p_bank_add2 { get; set; }

       [Column("p_bank_add3", Order = 155, TypeName = "varchar(50)")]
       public string? p_bank_add3 { get; set; }

       [Column("p_bank_city", Order = 156, TypeName = "varchar(100)")]
       public string? p_bank_city { get; set; }

       [Column("p_bank_state", Order = 157, TypeName = "varchar(100)")]
       public string? p_bank_state { get; set; }

       [Column("p_bank_pincode", Order = 158, TypeName = "varchar(25)")]
       public string? p_bank_pincode { get; set; }

       [Column("p_bank_country", Order = 159, TypeName = "varchar(100)")]
       public string? p_bank_country { get; set; }

       [Column("pan1_addhar_linked_yn", Order = 160, TypeName = "varchar(3)")]
       public string? pan1_addhar_linked_yn { get; set; }

       [Column("pan2_addhar_linked_yn", Order = 161, TypeName = "varchar(3)")]
       public string? pan2_addhar_linked_yn { get; set; }

       [Column("pan3_addhar_linked_yn", Order = 162, TypeName = "varchar(3)")]
       public string? pan3_addhar_linked_yn { get; set; }

   }
}
