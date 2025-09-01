using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_upload_rpt_tmp")] 
       
   public class E_Upload_Rpt_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("selected_trf_no", Order = 2, TypeName = "varchar(1)")]
       public string? selected_trf_no { get; set; }

       [Column("tr_sno", Order = 3, TypeName = "float")]
       public long? tr_sno { get; set; }

       [Column("new_tr_sno", Order = 4, TypeName = "float")]
       public long? new_tr_sno { get; set; }

       [Column("from_date", Order = 5, TypeName = "varchar(10)")]
       public string? from_date { get; set; }

       [Column("upto_date", Order = 6, TypeName = "varchar(10)")]
       public string? upto_date { get; set; }

       [Column("demat_type_selection", Order = 7, TypeName = "varchar(16)")]
       public string? demat_type_selection { get; set; }

       [Column("trx_comp_isin", Order = 8, TypeName = "varchar(50)")]
       public string? trx_comp_isin { get; set; }

       [Column("trx_company_type", Order = 9, TypeName = "varchar(9)")]
       public string? trx_company_type { get; set; }

       [Column("trx_company_name", Order = 10, TypeName = "varchar(50)")]
       public string? trx_company_name { get; set; }

       [Column("trfno", Order = 11, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("vou_type", Order = 12, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("current_status", Order = 13, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("entry_by_maker", Order = 14, TypeName = "varchar(50)")]
       public string? entry_by_maker { get; set; }

       [Column("entry_check_by_checker", Order = 15, TypeName = "varchar(50)")]
       public string? entry_check_by_checker { get; set; }

       [Column("checker_username", Order = 16, TypeName = "varchar(50)")]
       public string? checker_username { get; set; }

       [Column("remarks", Order = 17, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("trfolio", Order = 18, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("distno", Order = 19, TypeName = "float")]
       public long? distno { get; set; }

       [Column("distno_upto", Order = 20, TypeName = "float")]
       public long? distno_upto { get; set; }

       [Column("old_distno", Order = 21, TypeName = "float")]
       public long? old_distno { get; set; }

       [Column("certno", Order = 22, TypeName = "varchar(250)")]
       public string? certno { get; set; }

       [Column("pr_certno", Order = 23, TypeName = "varchar(250)")]
       public string? pr_certno { get; set; }

       [Column("old_certno", Order = 24, TypeName = "varchar(250)")]
       public string? old_certno { get; set; }

       [Column("old_distno_new", Order = 25, TypeName = "varchar(250)")]
       public string? old_distno_new { get; set; }

       [Column("shares", Order = 26, TypeName = "float")]
       public long? shares { get; set; }

       [Column("rcshare", Order = 27, TypeName = "float")]
       public long? rcshare { get; set; }

       [Column("old_sahre_qty", Order = 28, TypeName = "float")]
       public long? old_sahre_qty { get; set; }

       [Column("camount", Order = 29, TypeName = "float")]
       public long? camount { get; set; }

       [Column("stamp_duty", Order = 30, TypeName = "float")]
       public long? stamp_duty { get; set; }

       [Column("trfdate", Order = 31, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("recdate", Order = 32, TypeName = "datetime")]
       public DateTime? recdate { get; set; }

       [Column("dmdate", Order = 33, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("old_exchange_type", Order = 34, TypeName = "varchar(250)")]
       public string? old_exchange_type { get; set; }

       [Column("prindt", Order = 35, TypeName = "datetime")]
       public DateTime? prindt { get; set; }

       [Column("prfolio", Order = 36, TypeName = "varchar(16)")]
       public string? prfolio { get; set; }

       [Column("dpidno", Order = 37, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 38, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("printcode", Order = 39, TypeName = "varchar(100)")]
       public string? printcode { get; set; }

       [Column("sellcode", Order = 40, TypeName = "varchar(100)")]
       public string? sellcode { get; set; }

       [Column("purcode", Order = 41, TypeName = "varchar(100)")]
       public string? purcode { get; set; }

       [Column("cvcode", Order = 42, TypeName = "varchar(100)")]
       public string? cvcode { get; set; }

       [Column("rtag", Order = 43, TypeName = "varchar(100)")]
       public string? rtag { get; set; }

       [Column("rejres", Order = 44, TypeName = "varchar(100)")]
       public string? rejres { get; set; }

       [Column("rflag", Order = 45, TypeName = "varchar(100)")]
       public string? rflag { get; set; }

       [Column("csflag", Order = 46, TypeName = "varchar(100)")]
       public string? csflag { get; set; }

       [Column("panno", Order = 47, TypeName = "varchar(20)")]
       public string? panno { get; set; }

       [Column("derno", Order = 48, TypeName = "varchar(250)")]
       public string? derno { get; set; }

       [Column("derno_rrno", Order = 49, TypeName = "varchar(250)")]
       public string? derno_rrno { get; set; }

       [Column("req_no", Order = 50, TypeName = "varchar(50)")]
       public string? req_no { get; set; }

       [Column("req_date", Order = 51, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_comp_date", Order = 52, TypeName = "datetime")]
       public DateTime? req_comp_date { get; set; }

       [Column("req_foliono", Order = 53, TypeName = "varchar(50)")]
       public string? req_foliono { get; set; }

       [Column("req_folio_name", Order = 54, TypeName = "varchar(50)")]
       public string? req_folio_name { get; set; }

       [Column("value_date", Order = 55, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("entey_date", Order = 56, TypeName = "datetime")]
       public DateTime? entey_date { get; set; }

       [Column("user_name", Order = 57, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 58, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("t_panno", Order = 59, TypeName = "varchar(20)")]
       public string? t_panno { get; set; }

       [Column("t_names", Order = 60, TypeName = "varchar(50)")]
       public string? t_names { get; set; }

       [Column("t_fname", Order = 61, TypeName = "varchar(50)")]
       public string? t_fname { get; set; }

       [Column("t_email", Order = 62, TypeName = "varchar(50)")]
       public string? t_email { get; set; }

       [Column("t_mobile", Order = 63, TypeName = "varchar(50)")]
       public string? t_mobile { get; set; }

       [Column("t_dp_id_1", Order = 64, TypeName = "varchar(16)")]
       public string? t_dp_id_1 { get; set; }

       [Column("t_cl_id_2", Order = 65, TypeName = "varchar(16)")]
       public string? t_cl_id_2 { get; set; }

       [Column("t_sta", Order = 66, TypeName = "varchar(30)")]
       public string? t_sta { get; set; }

       [Column("t_m_f", Order = 67, TypeName = "varchar(20)")]
       public string? t_m_f { get; set; }

       [Column("t_dob", Order = 68, TypeName = "varchar(25)")]
       public string? t_dob { get; set; }

       [Column("t_emailid", Order = 69, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("t_phone", Order = 70, TypeName = "varchar(100)")]
       public string? t_phone { get; set; }

       [Column("reject_code", Order = 71, TypeName = "varchar(50)")]
       public string? reject_code { get; set; }

       [Column("reject_remark", Order = 72, TypeName = "varchar(50)")]
       public string? reject_remark { get; set; }

       [Column("create_new", Order = 73, TypeName = "varchar(100)")]
       public string? create_new { get; set; }

       [Column("p_panno", Order = 74, TypeName = "varchar(20)")]
       public string? p_panno { get; set; }

       [Column("p_names", Order = 75, TypeName = "varchar(50)")]
       public string? p_names { get; set; }

       [Column("p_fname", Order = 76, TypeName = "varchar(50)")]
       public string? p_fname { get; set; }

       [Column("p_email", Order = 77, TypeName = "varchar(50)")]
       public string? p_email { get; set; }

       [Column("p_mobile", Order = 78, TypeName = "varchar(50)")]
       public string? p_mobile { get; set; }

       [Column("p_dp_id_1", Order = 79, TypeName = "varchar(16)")]
       public string? p_dp_id_1 { get; set; }

       [Column("p_cl_id_2", Order = 80, TypeName = "varchar(16)")]
       public string? p_cl_id_2 { get; set; }

       [Column("p_sta", Order = 81, TypeName = "varchar(30)")]
       public string? p_sta { get; set; }

       [Column("p_m_f", Order = 82, TypeName = "varchar(20)")]
       public string? p_m_f { get; set; }

       [Column("p_dob", Order = 83, TypeName = "varchar(15)")]
       public string? p_dob { get; set; }

       [Column("p_emailid", Order = 84, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("p_phone", Order = 85, TypeName = "varchar(100)")]
       public string? p_phone { get; set; }

       [Column("comp_sno", Order = 86, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 87, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 88, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 89, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("reject_code_grid", Order = 90, TypeName = "varchar(50)")]
       public string? reject_code_grid { get; set; }

       [Column("reject_remark_grid", Order = 91, TypeName = "varchar(50)")]
       public string? reject_remark_grid { get; set; }

       [Column("multiple_folio", Order = 92, TypeName = "varchar(3)")]
       public string? multiple_folio { get; set; }

       [Column("rr_flag_name", Order = 93, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("demat_cum_trx_no", Order = 94, TypeName = "varchar(50)")]
       public string? demat_cum_trx_no { get; set; }

       [Column("mis_match_present_yn", Order = 95, TypeName = "varchar(1)")]
       public string? mis_match_present_yn { get; set; }

       [Column("mis_match_detail", Order = 96, TypeName = "varchar(50)")]
       public string? mis_match_detail { get; set; }

       [Column("name_mismatch_yn", Order = 97, TypeName = "varchar(1)")]
       public string? name_mismatch_yn { get; set; }

       [Column("name_mismatch_yn_code", Order = 98, TypeName = "varchar(10)")]
       public string? name_mismatch_yn_code { get; set; }

   }
}
