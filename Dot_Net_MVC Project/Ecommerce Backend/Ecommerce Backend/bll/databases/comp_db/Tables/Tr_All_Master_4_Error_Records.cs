using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_all_master_4_error_records")] 
       
   public class Tr_All_Master_4_Error_Records
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trfno", Order = 2, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("vou_type", Order = 3, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("comp_sno", Order = 4, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 5, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 6, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 7, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

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

       [Column("distno", Order = 14, TypeName = "float")]
       public long? distno { get; set; }

       [Column("distno_upto", Order = 15, TypeName = "float")]
       public long? distno_upto { get; set; }

       [Column("old_distno", Order = 16, TypeName = "float")]
       public long? old_distno { get; set; }

       [Column("certno", Order = 17, TypeName = "varchar(250)")]
       public string? certno { get; set; }

       [Column("pr_certno", Order = 18, TypeName = "varchar(250)")]
       public string? pr_certno { get; set; }

       [Column("old_certno", Order = 19, TypeName = "varchar(250)")]
       public string? old_certno { get; set; }

       [Column("old_distno_new", Order = 20, TypeName = "varchar(250)")]
       public string? old_distno_new { get; set; }

       [Column("shares", Order = 21, TypeName = "float")]
       public long? shares { get; set; }

       [Column("rcshare", Order = 22, TypeName = "float")]
       public long? rcshare { get; set; }

       [Column("old_sahre_qty", Order = 23, TypeName = "float")]
       public long? old_sahre_qty { get; set; }

       [Column("camount", Order = 24, TypeName = "float")]
       public long? camount { get; set; }

       [Column("share_type", Order = 25, TypeName = "varchar(50)")]
       public string? share_type { get; set; }

       [Column("stamp_duty", Order = 26, TypeName = "float")]
       public long? stamp_duty { get; set; }

       [Column("trfdate", Order = 27, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("recdate", Order = 28, TypeName = "datetime")]
       public DateTime? recdate { get; set; }

       [Column("dmdate", Order = 29, TypeName = "datetime")]
       public DateTime? dmdate { get; set; }

       [Column("old_exchange_type", Order = 30, TypeName = "varchar(250)")]
       public string? old_exchange_type { get; set; }

       [Column("prindt", Order = 31, TypeName = "datetime")]
       public DateTime? prindt { get; set; }

       [Column("prfolio", Order = 32, TypeName = "varchar(16)")]
       public string? prfolio { get; set; }

       [Column("dpidno", Order = 33, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 34, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("printcode", Order = 35, TypeName = "varchar(100)")]
       public string? printcode { get; set; }

       [Column("sellcode", Order = 36, TypeName = "varchar(100)")]
       public string? sellcode { get; set; }

       [Column("purcode", Order = 37, TypeName = "varchar(100)")]
       public string? purcode { get; set; }

       [Column("cvcode", Order = 38, TypeName = "varchar(100)")]
       public string? cvcode { get; set; }

       [Column("rtag", Order = 39, TypeName = "varchar(100)")]
       public string? rtag { get; set; }

       [Column("rejres", Order = 40, TypeName = "varchar(100)")]
       public string? rejres { get; set; }

       [Column("rflag", Order = 41, TypeName = "varchar(100)")]
       public string? rflag { get; set; }

       [Column("csflag", Order = 42, TypeName = "varchar(100)")]
       public string? csflag { get; set; }

       [Column("panno", Order = 43, TypeName = "varchar(20)")]
       public string? panno { get; set; }

       [Column("derno", Order = 44, TypeName = "varchar(250)")]
       public string? derno { get; set; }

       [Column("derno_rrno", Order = 45, TypeName = "varchar(250)")]
       public string? derno_rrno { get; set; }

       [Column("req_no", Order = 46, TypeName = "varchar(50)")]
       public string? req_no { get; set; }

       [Column("req_date", Order = 47, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_comp_date", Order = 48, TypeName = "datetime")]
       public DateTime? req_comp_date { get; set; }

       [Column("req_foliono", Order = 49, TypeName = "varchar(50)")]
       public string? req_foliono { get; set; }

       [Column("req_folio_name", Order = 50, TypeName = "varchar(50)")]
       public string? req_folio_name { get; set; }

       [Column("value_date", Order = 51, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("entey_date", Order = 52, TypeName = "datetime")]
       public DateTime? entey_date { get; set; }

       [Column("user_name", Order = 53, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 54, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("t_panno", Order = 55, TypeName = "varchar(20)")]
       public string? t_panno { get; set; }

       [Column("t_names", Order = 56, TypeName = "varchar(50)")]
       public string? t_names { get; set; }

       [Column("t_fname", Order = 57, TypeName = "varchar(50)")]
       public string? t_fname { get; set; }

       [Column("t_email", Order = 58, TypeName = "varchar(50)")]
       public string? t_email { get; set; }

       [Column("t_mobile", Order = 59, TypeName = "varchar(50)")]
       public string? t_mobile { get; set; }

       [Column("t_dp_id_1", Order = 60, TypeName = "varchar(16)")]
       public string? t_dp_id_1 { get; set; }

       [Column("t_cl_id_2", Order = 61, TypeName = "varchar(16)")]
       public string? t_cl_id_2 { get; set; }

       [Column("t_sta", Order = 62, TypeName = "varchar(30)")]
       public string? t_sta { get; set; }

       [Column("t_m_f", Order = 63, TypeName = "varchar(20)")]
       public string? t_m_f { get; set; }

       [Column("t_dob", Order = 64, TypeName = "varchar(25)")]
       public string? t_dob { get; set; }

       [Column("t_emailid", Order = 65, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("t_phone", Order = 66, TypeName = "varchar(100)")]
       public string? t_phone { get; set; }

       [Column("reject_code", Order = 67, TypeName = "varchar(50)")]
       public string? reject_code { get; set; }

       [Column("reject_remark", Order = 68, TypeName = "varchar(50)")]
       public string? reject_remark { get; set; }

       [Column("create_new", Order = 69, TypeName = "varchar(100)")]
       public string? create_new { get; set; }

       [Column("p_panno", Order = 70, TypeName = "varchar(20)")]
       public string? p_panno { get; set; }

       [Column("p_names", Order = 71, TypeName = "varchar(50)")]
       public string? p_names { get; set; }

       [Column("p_fname", Order = 72, TypeName = "varchar(50)")]
       public string? p_fname { get; set; }

       [Column("p_email", Order = 73, TypeName = "varchar(50)")]
       public string? p_email { get; set; }

       [Column("p_mobile", Order = 74, TypeName = "varchar(50)")]
       public string? p_mobile { get; set; }

       [Column("p_dp_id_1", Order = 75, TypeName = "varchar(16)")]
       public string? p_dp_id_1 { get; set; }

       [Column("p_cl_id_2", Order = 76, TypeName = "varchar(16)")]
       public string? p_cl_id_2 { get; set; }

       [Column("p_sta", Order = 77, TypeName = "varchar(30)")]
       public string? p_sta { get; set; }

       [Column("p_m_f", Order = 78, TypeName = "varchar(20)")]
       public string? p_m_f { get; set; }

       [Column("p_dob", Order = 79, TypeName = "varchar(15)")]
       public string? p_dob { get; set; }

       [Column("p_emailid", Order = 80, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("p_phone", Order = 81, TypeName = "varchar(100)")]
       public string? p_phone { get; set; }

       [Column("multiple_folio", Order = 82, TypeName = "varchar(3)")]
       public string? multiple_folio { get; set; }

       [Column("rr_flag_name", Order = 83, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("trx_remark", Order = 84, TypeName = "varchar(50)")]
       public string? trx_remark { get; set; }

       [Column("reject_code_grid", Order = 85, TypeName = "varchar(50)")]
       public string? reject_code_grid { get; set; }

       [Column("reject_remark_grid", Order = 86, TypeName = "varchar(50)")]
       public string? reject_remark_grid { get; set; }

       [Column("share_accept_yn", Order = 87, TypeName = "varchar(3)")]
       public string? share_accept_yn { get; set; }

   }
}
