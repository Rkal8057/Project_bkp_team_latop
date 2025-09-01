using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tran_detail_tmp")] 
       
   public class Tran_Detail_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trfno", Order = 2, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("distno", Order = 3, TypeName = "float")]
       public long? distno { get; set; }

       [Column("certno", Order = 4, TypeName = "float")]
       public long? certno { get; set; }

       [Column("shares", Order = 5, TypeName = "float")]
       public long? shares { get; set; }

       [Column("camount", Order = 6, TypeName = "float")]
       public long? camount { get; set; }

       [Column("trfdate", Order = 7, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("prfolio", Order = 8, TypeName = "varchar(6)")]
       public string? prfolio { get; set; }

       [Column("printcode", Order = 9, TypeName = "varchar(100)")]
       public string? printcode { get; set; }

       [Column("sellcode", Order = 10, TypeName = "varchar(100)")]
       public string? sellcode { get; set; }

       [Column("purcode", Order = 11, TypeName = "varchar(100)")]
       public string? purcode { get; set; }

       [Column("cvcode", Order = 12, TypeName = "varchar(100)")]
       public string? cvcode { get; set; }

       [Column("rflag", Order = 13, TypeName = "varchar(10)")]
       public string? rflag { get; set; }

       [Column("csflag", Order = 14, TypeName = "varchar(10)")]
       public string? csflag { get; set; }

       [Column("panno", Order = 15, TypeName = "varchar(13)")]
       public string? panno { get; set; }

       [Column("req_no", Order = 16, TypeName = "varchar(50)")]
       public string? req_no { get; set; }

       [Column("req_date", Order = 17, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_comp_date", Order = 18, TypeName = "datetime")]
       public DateTime? req_comp_date { get; set; }

       [Column("value_date", Order = 19, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("user_name", Order = 20, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 21, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("t_panno", Order = 22, TypeName = "varchar(15)")]
       public string? t_panno { get; set; }

       [Column("t_names", Order = 23, TypeName = "varchar(50)")]
       public string? t_names { get; set; }

       [Column("t_fname", Order = 24, TypeName = "varchar(50)")]
       public string? t_fname { get; set; }

       [Column("t_email", Order = 25, TypeName = "varchar(50)")]
       public string? t_email { get; set; }

       [Column("t_mobile", Order = 26, TypeName = "varchar(50)")]
       public string? t_mobile { get; set; }

       [Column("t_dp_id_1", Order = 27, TypeName = "varchar(8)")]
       public string? t_dp_id_1 { get; set; }

       [Column("t_cl_id_2", Order = 28, TypeName = "varchar(8)")]
       public string? t_cl_id_2 { get; set; }

       [Column("t_sta", Order = 29, TypeName = "varchar(30)")]
       public string? t_sta { get; set; }

       [Column("t_m_f", Order = 30, TypeName = "varchar(20)")]
       public string? t_m_f { get; set; }

       [Column("t_dob", Order = 31, TypeName = "varchar(25)")]
       public string? t_dob { get; set; }

       [Column("t_emailid", Order = 32, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("t_phone", Order = 33, TypeName = "varchar(100)")]
       public string? t_phone { get; set; }

       [Column("rej_code", Order = 34, TypeName = "varchar(3)")]
       public string? rej_code { get; set; }

       [Column("reject_remark", Order = 35, TypeName = "varchar(50)")]
       public string? reject_remark { get; set; }

       [Column("create_new", Order = 36, TypeName = "varchar(3)")]
       public string? create_new { get; set; }

       [Column("p_panno", Order = 37, TypeName = "varchar(15)")]
       public string? p_panno { get; set; }

       [Column("p_names", Order = 38, TypeName = "varchar(50)")]
       public string? p_names { get; set; }

       [Column("p_fname", Order = 39, TypeName = "varchar(50)")]
       public string? p_fname { get; set; }

       [Column("p_email", Order = 40, TypeName = "varchar(50)")]
       public string? p_email { get; set; }

       [Column("p_mobile", Order = 41, TypeName = "varchar(50)")]
       public string? p_mobile { get; set; }

       [Column("p_dp_id_1", Order = 42, TypeName = "varchar(8)")]
       public string? p_dp_id_1 { get; set; }

       [Column("p_cl_id_2", Order = 43, TypeName = "varchar(8)")]
       public string? p_cl_id_2 { get; set; }

       [Column("p_sta", Order = 44, TypeName = "varchar(30)")]
       public string? p_sta { get; set; }

       [Column("p_m_f", Order = 45, TypeName = "varchar(20)")]
       public string? p_m_f { get; set; }

       [Column("p_dob", Order = 46, TypeName = "varchar(15)")]
       public string? p_dob { get; set; }

       [Column("p_emailid", Order = 47, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("p_phone", Order = 48, TypeName = "varchar(100)")]
       public string? p_phone { get; set; }

   }
}
