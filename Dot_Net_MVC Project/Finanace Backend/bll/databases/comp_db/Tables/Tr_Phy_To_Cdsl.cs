using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_phy_to_cdsl")] 
       
   public class Tr_Phy_To_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trfno", Order = 2, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("vou_type", Order = 3, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("current_status", Order = 4, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("entry_by_maker", Order = 5, TypeName = "varchar(50)")]
       public string? entry_by_maker { get; set; }

       [Column("entry_check_by_checker", Order = 6, TypeName = "varchar(50)")]
       public string? entry_check_by_checker { get; set; }

       [Column("checker_username", Order = 7, TypeName = "varchar(50)")]
       public string? checker_username { get; set; }

       [Column("remarks", Order = 8, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("trfolio", Order = 9, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("distno", Order = 10, TypeName = "float")]
       public long? distno { get; set; }

       [Column("distno_upto", Order = 11, TypeName = "float")]
       public long? distno_upto { get; set; }

       [Column("old_distno", Order = 12, TypeName = "float")]
       public long? old_distno { get; set; }

       [Column("certno", Order = 13, TypeName = "varchar(250)")]
       public string? certno { get; set; }

       [Column("pr_certno", Order = 14, TypeName = "varchar(250)")]
       public string? pr_certno { get; set; }

       [Column("old_certno", Order = 15, TypeName = "varchar(250)")]
       public string? old_certno { get; set; }

       [Column("old_distno_new", Order = 16, TypeName = "varchar(250)")]
       public string? old_distno_new { get; set; }

       [Column("shares", Order = 17, TypeName = "float")]
       public long? shares { get; set; }

       [Column("rcshare", Order = 18, TypeName = "float")]
       public long? rcshare { get; set; }

       [Column("old_sahre_qty", Order = 19, TypeName = "float")]
       public long? old_sahre_qty { get; set; }

       [Column("camount", Order = 20, TypeName = "float")]
       public long? camount { get; set; }

       [Column("share_type", Order = 21, TypeName = "varchar(50)")]
       public string? share_type { get; set; }

       [Column("stamp_duty", Order = 22, TypeName = "float")]
       public long? stamp_duty { get; set; }

       [Column("trfdate", Order = 23, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("recdate", Order = 24, TypeName = "datetime")]
       public DateTime? recdate { get; set; }

       [Column("dmdate", Order = 25, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("old_exchange_type", Order = 26, TypeName = "varchar(250)")]
       public string? old_exchange_type { get; set; }

       [Column("prindt", Order = 27, TypeName = "datetime")]
       public DateTime? prindt { get; set; }

       [Column("prfolio", Order = 28, TypeName = "varchar(16)")]
       public string? prfolio { get; set; }

       [Column("dpidno", Order = 29, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 30, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("printcode", Order = 31, TypeName = "varchar(100)")]
       public string? printcode { get; set; }

       [Column("sellcode", Order = 32, TypeName = "varchar(100)")]
       public string? sellcode { get; set; }

       [Column("purcode", Order = 33, TypeName = "varchar(100)")]
       public string? purcode { get; set; }

       [Column("cvcode", Order = 34, TypeName = "varchar(100)")]
       public string? cvcode { get; set; }

       [Column("rtag", Order = 35, TypeName = "varchar(100)")]
       public string? rtag { get; set; }

       [Column("rejres", Order = 36, TypeName = "varchar(100)")]
       public string? rejres { get; set; }

       [Column("rflag", Order = 37, TypeName = "varchar(100)")]
       public string? rflag { get; set; }

       [Column("csflag", Order = 38, TypeName = "varchar(100)")]
       public string? csflag { get; set; }

       [Column("panno", Order = 39, TypeName = "varchar(20)")]
       public string? panno { get; set; }

       [Column("derno", Order = 40, TypeName = "varchar(250)")]
       public string? derno { get; set; }

       [Column("derno_rrno", Order = 41, TypeName = "varchar(250)")]
       public string? derno_rrno { get; set; }

       [Column("req_no", Order = 42, TypeName = "varchar(50)")]
       public string? req_no { get; set; }

       [Column("req_date", Order = 43, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_comp_date", Order = 44, TypeName = "datetime")]
       public DateTime? req_comp_date { get; set; }

       [Column("req_foliono", Order = 45, TypeName = "varchar(50)")]
       public string? req_foliono { get; set; }

       [Column("req_folio_name", Order = 46, TypeName = "varchar(50)")]
       public string? req_folio_name { get; set; }

       [Column("value_date", Order = 47, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("entey_date", Order = 48, TypeName = "datetime")]
       public DateTime? entey_date { get; set; }

       [Column("user_name", Order = 49, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 50, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("t_panno", Order = 51, TypeName = "varchar(20)")]
       public string? t_panno { get; set; }

       [Column("t_names", Order = 52, TypeName = "varchar(50)")]
       public string? t_names { get; set; }

       [Column("t_fname", Order = 53, TypeName = "varchar(50)")]
       public string? t_fname { get; set; }

       [Column("t_email", Order = 54, TypeName = "varchar(50)")]
       public string? t_email { get; set; }

       [Column("t_mobile", Order = 55, TypeName = "varchar(50)")]
       public string? t_mobile { get; set; }

       [Column("t_dp_id_1", Order = 56, TypeName = "varchar(16)")]
       public string? t_dp_id_1 { get; set; }

       [Column("t_cl_id_2", Order = 57, TypeName = "varchar(16)")]
       public string? t_cl_id_2 { get; set; }

       [Column("t_sta", Order = 58, TypeName = "varchar(30)")]
       public string? t_sta { get; set; }

       [Column("t_m_f", Order = 59, TypeName = "varchar(20)")]
       public string? t_m_f { get; set; }

       [Column("t_dob", Order = 60, TypeName = "varchar(25)")]
       public string? t_dob { get; set; }

       [Column("t_emailid", Order = 61, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("t_phone", Order = 62, TypeName = "varchar(100)")]
       public string? t_phone { get; set; }

       [Column("reject_code", Order = 63, TypeName = "varchar(50)")]
       public string? reject_code { get; set; }

       [Column("reject_remark", Order = 64, TypeName = "varchar(50)")]
       public string? reject_remark { get; set; }

       [Column("create_new", Order = 65, TypeName = "varchar(100)")]
       public string? create_new { get; set; }

       [Column("p_panno", Order = 66, TypeName = "varchar(20)")]
       public string? p_panno { get; set; }

       [Column("p_names", Order = 67, TypeName = "varchar(50)")]
       public string? p_names { get; set; }

       [Column("p_fname", Order = 68, TypeName = "varchar(50)")]
       public string? p_fname { get; set; }

       [Column("p_email", Order = 69, TypeName = "varchar(50)")]
       public string? p_email { get; set; }

       [Column("p_mobile", Order = 70, TypeName = "varchar(50)")]
       public string? p_mobile { get; set; }

       [Column("p_dp_id_1", Order = 71, TypeName = "varchar(16)")]
       public string? p_dp_id_1 { get; set; }

       [Column("p_cl_id_2", Order = 72, TypeName = "varchar(16)")]
       public string? p_cl_id_2 { get; set; }

       [Column("p_sta", Order = 73, TypeName = "varchar(30)")]
       public string? p_sta { get; set; }

       [Column("p_m_f", Order = 74, TypeName = "varchar(20)")]
       public string? p_m_f { get; set; }

       [Column("p_dob", Order = 75, TypeName = "varchar(15)")]
       public string? p_dob { get; set; }

       [Column("p_emailid", Order = 76, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("p_phone", Order = 77, TypeName = "varchar(100)")]
       public string? p_phone { get; set; }

       [Column("multiple_folio", Order = 78, TypeName = "varchar(3)")]
       public string? multiple_folio { get; set; }

       [Column("rr_flag_name", Order = 79, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("trx_remark", Order = 80, TypeName = "varchar(50)")]
       public string? trx_remark { get; set; }

       [Column("reject_code_grid", Order = 81, TypeName = "varchar(50)")]
       public string? reject_code_grid { get; set; }

       [Column("reject_remark_grid", Order = 82, TypeName = "varchar(50)")]
       public string? reject_remark_grid { get; set; }

       [Column("t_ad1", Order = 83, TypeName = "varchar(50)")]
       public string? t_ad1 { get; set; }

       [Column("t_ad2", Order = 84, TypeName = "varchar(50)")]
       public string? t_ad2 { get; set; }

       [Column("t_city", Order = 85, TypeName = "varchar(50)")]
       public string? t_city { get; set; }

       [Column("t_state", Order = 86, TypeName = "varchar(50)")]
       public string? t_state { get; set; }

       [Column("t_pincode", Order = 87, TypeName = "varchar(50)")]
       public string? t_pincode { get; set; }

       [Column("t_country_name", Order = 88, TypeName = "varchar(50)")]
       public string? t_country_name { get; set; }

       [Column("p_ad1", Order = 89, TypeName = "varchar(50)")]
       public string? p_ad1 { get; set; }

       [Column("p_ad2", Order = 90, TypeName = "varchar(50)")]
       public string? p_ad2 { get; set; }

       [Column("p_city", Order = 91, TypeName = "varchar(50)")]
       public string? p_city { get; set; }

       [Column("p_state", Order = 92, TypeName = "varchar(50)")]
       public string? p_state { get; set; }

       [Column("p_pincode", Order = 93, TypeName = "varchar(50)")]
       public string? p_pincode { get; set; }

       [Column("p_country_name", Order = 94, TypeName = "varchar(50)")]
       public string? p_country_name { get; set; }

       [Column("vou_action_type", Order = 95, TypeName = "varchar(50)")]
       public string? vou_action_type { get; set; }

       [Column("p_names_2", Order = 96, TypeName = "varchar(50)")]
       public string? p_names_2 { get; set; }

       [Column("p_names_3", Order = 97, TypeName = "varchar(50)")]
       public string? p_names_3 { get; set; }

       [Column("t_names_2", Order = 98, TypeName = "varchar(50)")]
       public string? t_names_2 { get; set; }

       [Column("t_names_3", Order = 99, TypeName = "varchar(50)")]
       public string? t_names_3 { get; set; }

       [Column("demat_cum_trx_no", Order = 100, TypeName = "varchar(50)")]
       public string? demat_cum_trx_no { get; set; }

       [Column("share_accept_yn_13_05_2022_t45_16_45_51", Order = 101, TypeName = "varchar(50)")]
       public string? share_accept_yn_13_05_2022_t45_16_45_51 { get; set; }

       [Column("p_panno2", Order = 102, TypeName = "varchar(50)")]
       public string? p_panno2 { get; set; }

       [Column("t_panno3", Order = 103, TypeName = "varchar(50)")]
       public string? t_panno3 { get; set; }

       [Column("p_panno3", Order = 104, TypeName = "varchar(50)")]
       public string? p_panno3 { get; set; }

       [Column("t_panno2", Order = 105, TypeName = "varchar(50)")]
       public string? t_panno2 { get; set; }

       [Column("p_adhaar_no", Order = 106, TypeName = "varchar(30)")]
       public string? p_adhaar_no { get; set; }

       [Column("p_voter_id", Order = 107, TypeName = "varchar(30)")]
       public string? p_voter_id { get; set; }

       [Column("p_dl_no", Order = 108, TypeName = "varchar(30)")]
       public string? p_dl_no { get; set; }

       [Column("p_passport_no", Order = 109, TypeName = "varchar(30)")]
       public string? p_passport_no { get; set; }

       [Column("t_adhaar_no", Order = 110, TypeName = "varchar(30)")]
       public string? t_adhaar_no { get; set; }

       [Column("t_voter_id", Order = 111, TypeName = "varchar(30)")]
       public string? t_voter_id { get; set; }

       [Column("t_dl_no", Order = 112, TypeName = "varchar(30)")]
       public string? t_dl_no { get; set; }

       [Column("t_passport_no", Order = 113, TypeName = "varchar(30)")]
       public string? t_passport_no { get; set; }

       [Column("t_folio_address", Order = 114, TypeName = "varchar(50)")]
       public string? t_folio_address { get; set; }

       [Column("p_folio_address", Order = 115, TypeName = "varchar(50)")]
       public string? p_folio_address { get; set; }

       [Column("t_bank_ac_no", Order = 116, TypeName = "varchar(55)")]
       public string? t_bank_ac_no { get; set; }

       [Column("t_account_type", Order = 117, TypeName = "varchar(55)")]
       public string? t_account_type { get; set; }

       [Column("t_bank_name", Order = 118, TypeName = "varchar(50)")]
       public string? t_bank_name { get; set; }

       [Column("t_bank_micrno", Order = 119, TypeName = "varchar(55)")]
       public string? t_bank_micrno { get; set; }

       [Column("t_bank_ifsc_code", Order = 120, TypeName = "varchar(55)")]
       public string? t_bank_ifsc_code { get; set; }

       [Column("t_bank_add1", Order = 121, TypeName = "varchar(50)")]
       public string? t_bank_add1 { get; set; }

       [Column("t_bank_add2", Order = 122, TypeName = "varchar(50)")]
       public string? t_bank_add2 { get; set; }

       [Column("t_bank_add3", Order = 123, TypeName = "varchar(50)")]
       public string? t_bank_add3 { get; set; }

       [Column("t_bank_city", Order = 124, TypeName = "varchar(100)")]
       public string? t_bank_city { get; set; }

       [Column("t_bank_state", Order = 125, TypeName = "varchar(100)")]
       public string? t_bank_state { get; set; }

       [Column("t_bank_pincode", Order = 126, TypeName = "varchar(25)")]
       public string? t_bank_pincode { get; set; }

       [Column("t_bank_country", Order = 127, TypeName = "varchar(100)")]
       public string? t_bank_country { get; set; }

       [Column("p_bank_ac_no", Order = 128, TypeName = "varchar(55)")]
       public string? p_bank_ac_no { get; set; }

       [Column("p_account_type", Order = 129, TypeName = "varchar(55)")]
       public string? p_account_type { get; set; }

       [Column("p_bank_name", Order = 130, TypeName = "varchar(50)")]
       public string? p_bank_name { get; set; }

       [Column("p_bank_micrno", Order = 131, TypeName = "varchar(55)")]
       public string? p_bank_micrno { get; set; }

       [Column("p_bank_ifsc_code", Order = 132, TypeName = "varchar(55)")]
       public string? p_bank_ifsc_code { get; set; }

       [Column("p_bank_add1", Order = 133, TypeName = "varchar(50)")]
       public string? p_bank_add1 { get; set; }

       [Column("p_bank_add2", Order = 134, TypeName = "varchar(50)")]
       public string? p_bank_add2 { get; set; }

       [Column("p_bank_add3", Order = 135, TypeName = "varchar(50)")]
       public string? p_bank_add3 { get; set; }

       [Column("p_bank_city", Order = 136, TypeName = "varchar(100)")]
       public string? p_bank_city { get; set; }

       [Column("p_bank_state", Order = 137, TypeName = "varchar(100)")]
       public string? p_bank_state { get; set; }

       [Column("p_bank_pincode", Order = 138, TypeName = "varchar(25)")]
       public string? p_bank_pincode { get; set; }

       [Column("p_bank_country", Order = 139, TypeName = "varchar(100)")]
       public string? p_bank_country { get; set; }

       [Column("mis_match_present_yn", Order = 140, TypeName = "varchar(1)")]
       public string? mis_match_present_yn { get; set; }

       [Column("mis_match_detail", Order = 141, TypeName = "varchar(50)")]
       public string? mis_match_detail { get; set; }

       [Column("name_mismatch_yn", Order = 142, TypeName = "varchar(1)")]
       public string? name_mismatch_yn { get; set; }

       [Column("name_mismatch_yn_code", Order = 143, TypeName = "varchar(10)")]
       public string? name_mismatch_yn_code { get; set; }

       [Column("share_accept_yn", Order = 144, TypeName = "varchar(50)")]
       public string? share_accept_yn { get; set; }

       [Column("share_price", Order = 145, TypeName = "float")]
       public long? share_price { get; set; }

       [Column("comp_isin", Order = 146, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 147, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 148, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("comp_sno", Order = 149, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("pan1_addhar_linked_yn", Order = 150, TypeName = "varchar(3)")]
       public string? pan1_addhar_linked_yn { get; set; }

       [Column("pan2_addhar_linked_yn", Order = 151, TypeName = "varchar(3)")]
       public string? pan2_addhar_linked_yn { get; set; }

       [Column("pan3_addhar_linked_yn", Order = 152, TypeName = "varchar(3)")]
       public string? pan3_addhar_linked_yn { get; set; }

   }
}
