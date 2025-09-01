using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_upload_nsdl")] 
       
   public class E_Upload_Nsdl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("batch_number", Order = 3, TypeName = "varchar(8)")]
       public string? batch_number { get; set; }

       [Column("record_type", Order = 4, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("line_no", Order = 5, TypeName = "varchar(7)")]
       public string? line_no { get; set; }

       [Column("tran_type_col_4", Order = 6, TypeName = "varchar(8)")]
       public string? tran_type_col_4 { get; set; }

       [Column("tran_flag_col_5", Order = 7, TypeName = "varchar(2)")]
       public string? tran_flag_col_5 { get; set; }

       [Column("dp_id_col_6", Order = 8, TypeName = "varchar(18)")]
       public string? dp_id_col_6 { get; set; }

       [Column("drn_col_7", Order = 9, TypeName = "varchar(18)")]
       public string? drn_col_7 { get; set; }

       [Column("drf_dt_col_8", Order = 10, TypeName = "varchar(18)")]
       public string? drf_dt_col_8 { get; set; }

       [Column("demat_acpt_col_9", Order = 11, TypeName = "varchar(18)")]
       public string? demat_acpt_col_9 { get; set; }

       [Column("demat_rej_qty_col_10", Order = 12, TypeName = "varchar(18)")]
       public string? demat_rej_qty_col_10 { get; set; }

       [Column("lockin_reason_code_col_11", Order = 13, TypeName = "varchar(64)")]
       public string? lockin_reason_code_col_11 { get; set; }

       [Column("lockin_release_date_col_12", Order = 14, TypeName = "varchar(8)")]
       public string? lockin_release_date_col_12 { get; set; }

       [Column("own_ref_no_col_13", Order = 15, TypeName = "varchar(35)")]
       public string? own_ref_no_col_13 { get; set; }

       [Column("rej_code1_col_14", Order = 16, TypeName = "varchar(8)")]
       public string? rej_code1_col_14 { get; set; }

       [Column("rej_code2_col_15", Order = 17, TypeName = "varchar(4)")]
       public string? rej_code2_col_15 { get; set; }

       [Column("rej_code3_col_16", Order = 18, TypeName = "varchar(4)")]
       public string? rej_code3_col_16 { get; set; }

       [Column("rej_code4_col_17", Order = 19, TypeName = "varchar(4)")]
       public string? rej_code4_col_17 { get; set; }

       [Column("sender_ref_no1_col_18", Order = 20, TypeName = "varchar(50)")]
       public string? sender_ref_no1_col_18 { get; set; }

       [Column("sender_ref_no2_col_19", Order = 21, TypeName = "varchar(50)")]
       public string? sender_ref_no2_col_19 { get; set; }

       [Column("mf_indicator_col_20", Order = 22, TypeName = "varchar(1)")]
       public string? mf_indicator_col_20 { get; set; }

       [Column("final_crm_indicator_col_21", Order = 23, TypeName = "varchar(1)")]
       public string? final_crm_indicator_col_21 { get; set; }

       [Column("filler_col_22", Order = 24, TypeName = "varchar(1)")]
       public string? filler_col_22 { get; set; }

   }
}
