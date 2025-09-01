using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("all_table_rpt_tmp")] 
       
   public class All_Table_Rpt_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trfno", Order = 2, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trfdate", Order = 3, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("req_no", Order = 4, TypeName = "varchar(50)")]
       public string? req_no { get; set; }

       [Column("req_date", Order = 5, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_comp_date", Order = 6, TypeName = "datetime")]
       public DateTime? req_comp_date { get; set; }

       [Column("trfolio", Order = 7, TypeName = "varchar(16)")]
       public string? trfolio { get; set; }

       [Column("distno", Order = 8, TypeName = "float")]
       public long? distno { get; set; }

       [Column("distno_upto", Order = 9, TypeName = "float")]
       public long? distno_upto { get; set; }

       [Column("old_distno", Order = 10, TypeName = "float")]
       public long? old_distno { get; set; }

       [Column("certno", Order = 11, TypeName = "varchar(250)")]
       public string? certno { get; set; }

       [Column("pr_certno", Order = 12, TypeName = "varchar(250)")]
       public string? pr_certno { get; set; }

       [Column("old_certno", Order = 13, TypeName = "varchar(250)")]
       public string? old_certno { get; set; }

       [Column("shares", Order = 14, TypeName = "float")]
       public long? shares { get; set; }

       [Column("rcshare", Order = 15, TypeName = "float")]
       public long? rcshare { get; set; }

       [Column("old_sahre_qty", Order = 16, TypeName = "float")]
       public long? old_sahre_qty { get; set; }

       [Column("camount", Order = 17, TypeName = "float")]
       public long? camount { get; set; }

       [Column("share_type", Order = 18, TypeName = "varchar(50)")]
       public string? share_type { get; set; }

       [Column("stamp_duty", Order = 19, TypeName = "float")]
       public long? stamp_duty { get; set; }

       [Column("dpidno", Order = 20, TypeName = "varchar(16)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 21, TypeName = "varchar(16)")]
       public string? clinid { get; set; }

       [Column("rflag", Order = 22, TypeName = "varchar(100)")]
       public string? rflag { get; set; }

       [Column("panno", Order = 23, TypeName = "varchar(20)")]
       public string? panno { get; set; }

       [Column("derno", Order = 24, TypeName = "varchar(250)")]
       public string? derno { get; set; }

       [Column("derno_rrno", Order = 25, TypeName = "varchar(250)")]
       public string? derno_rrno { get; set; }

       [Column("req_foliono", Order = 26, TypeName = "varchar(50)")]
       public string? req_foliono { get; set; }

       [Column("req_folio_name", Order = 27, TypeName = "varchar(50)")]
       public string? req_folio_name { get; set; }

       [Column("value_date", Order = 28, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("user_name", Order = 29, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 30, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("t_panno", Order = 31, TypeName = "varchar(20)")]
       public string? t_panno { get; set; }

       [Column("t_names", Order = 32, TypeName = "varchar(50)")]
       public string? t_names { get; set; }

       [Column("t_fname", Order = 33, TypeName = "varchar(50)")]
       public string? t_fname { get; set; }

       [Column("t_email", Order = 34, TypeName = "varchar(50)")]
       public string? t_email { get; set; }

       [Column("t_mobile", Order = 35, TypeName = "varchar(50)")]
       public string? t_mobile { get; set; }

       [Column("t_dp_id_1", Order = 36, TypeName = "varchar(16)")]
       public string? t_dp_id_1 { get; set; }

       [Column("t_cl_id_2", Order = 37, TypeName = "varchar(16)")]
       public string? t_cl_id_2 { get; set; }

       [Column("t_sta", Order = 38, TypeName = "varchar(30)")]
       public string? t_sta { get; set; }

       [Column("t_m_f", Order = 39, TypeName = "varchar(20)")]
       public string? t_m_f { get; set; }

       [Column("t_dob", Order = 40, TypeName = "varchar(25)")]
       public string? t_dob { get; set; }

       [Column("t_emailid", Order = 41, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("t_phone", Order = 42, TypeName = "varchar(100)")]
       public string? t_phone { get; set; }

       [Column("reject_code", Order = 43, TypeName = "varchar(50)")]
       public string? reject_code { get; set; }

       [Column("reject_remark", Order = 44, TypeName = "varchar(50)")]
       public string? reject_remark { get; set; }

       [Column("create_new", Order = 45, TypeName = "varchar(100)")]
       public string? create_new { get; set; }

       [Column("p_panno", Order = 46, TypeName = "varchar(20)")]
       public string? p_panno { get; set; }

       [Column("p_names", Order = 47, TypeName = "varchar(50)")]
       public string? p_names { get; set; }

       [Column("p_fname", Order = 48, TypeName = "varchar(50)")]
       public string? p_fname { get; set; }

       [Column("p_email", Order = 49, TypeName = "varchar(50)")]
       public string? p_email { get; set; }

       [Column("p_mobile", Order = 50, TypeName = "varchar(50)")]
       public string? p_mobile { get; set; }

       [Column("p_dp_id_1", Order = 51, TypeName = "varchar(16)")]
       public string? p_dp_id_1 { get; set; }

       [Column("p_cl_id_2", Order = 52, TypeName = "varchar(16)")]
       public string? p_cl_id_2 { get; set; }

       [Column("p_sta", Order = 53, TypeName = "varchar(30)")]
       public string? p_sta { get; set; }

       [Column("p_m_f", Order = 54, TypeName = "varchar(20)")]
       public string? p_m_f { get; set; }

       [Column("p_dob", Order = 55, TypeName = "varchar(15)")]
       public string? p_dob { get; set; }

       [Column("p_emailid", Order = 56, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("p_phone", Order = 57, TypeName = "varchar(100)")]
       public string? p_phone { get; set; }

   }
}
