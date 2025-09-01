using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_detail_ndsl_ndsl")] 
       
   public class Iepf_Detail_Ndsl_Ndsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("c2_m_r_i", Order = 3, TypeName = "varchar(2)")]
       public string? c2_m_r_i { get; set; }

       [Column("c3_m_rec_l_no", Order = 4, TypeName = "varchar(7)")]
       public string? c3_m_rec_l_no { get; set; }

       [Column("c4_m_cr_dp_id", Order = 5, TypeName = "varchar(8)")]
       public string? c4_m_cr_dp_id { get; set; }

       [Column("c5_m_cr_ci_id", Order = 6, TypeName = "varchar(8)")]
       public string? c5_m_cr_ci_id { get; set; }

       [Column("c6_m_cr_ci_ac_cate", Order = 7, TypeName = "varchar(2)")]
       public string? c6_m_cr_ci_ac_cate { get; set; }

       [Column("c7_m_dr_dp_id", Order = 8, TypeName = "varchar(8)")]
       public string? c7_m_dr_dp_id { get; set; }

       [Column("c8_m_dr_cl_id", Order = 9, TypeName = "varchar(8)")]
       public string? c8_m_dr_cl_id { get; set; }

       [Column("c9_m_dr_ci_ac_cate", Order = 10, TypeName = "varchar(2)")]
       public string? c9_m_dr_ci_ac_cate { get; set; }

       [Column("c10_m_cr_qty", Order = 11, TypeName = "varchar(18)")]
       public string? c10_m_cr_qty { get; set; }

       [Column("c11_m_dr_qty", Order = 12, TypeName = "varchar(18)")]
       public string? c11_m_dr_qty { get; set; }

       [Column("c13_o_cr_l_in_qty_code", Order = 13, TypeName = "varchar(2)")]
       public string? c13_o_cr_l_in_qty_code { get; set; }

       [Column("c14_o_cr_l_in_release_dt", Order = 14, TypeName = "varchar(8)")]
       public string? c14_o_cr_l_in_release_dt { get; set; }

       [Column("c15_o_dr_l_in_qty_code", Order = 15, TypeName = "varchar(2)")]
       public string? c15_o_dr_l_in_qty_code { get; set; }

       [Column("c16_o_dr_l_in_release_dt", Order = 16, TypeName = "varchar(8)")]
       public string? c16_o_dr_l_in_release_dt { get; set; }

   }
}
