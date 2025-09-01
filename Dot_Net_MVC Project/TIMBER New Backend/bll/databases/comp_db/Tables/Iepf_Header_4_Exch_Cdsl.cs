using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_header_4_exch_cdsl")] 
       
   public class Iepf_Header_4_Exch_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("c1_r_i", Order = 3, TypeName = "varchar(2)")]
       public string? c1_r_i { get; set; }

       [Column("c2_rta_id", Order = 4, TypeName = "varchar(6)")]
       public string? c2_rta_id { get; set; }

       [Column("c3_rta_i_ref", Order = 5, TypeName = "varchar(16)")]
       public string? c3_rta_i_ref { get; set; }

       [Column("c4_isin", Order = 6, TypeName = "varchar(12)")]
       public string? c4_isin { get; set; }

       [Column("c5_ca_type", Order = 7, TypeName = "varchar(4)")]
       public string? c5_ca_type { get; set; }

       [Column("c6_board_a_d", Order = 8, TypeName = "varchar(8)")]
       public string? c6_board_a_d { get; set; }

       [Column("c7_execution_dt", Order = 9, TypeName = "varchar(8)")]
       public string? c7_execution_dt { get; set; }

       [Column("c8_total_d_qty", Order = 10, TypeName = "varchar(16)")]
       public string? c8_total_d_qty { get; set; }

       [Column("c9_total_d_l_in_qty", Order = 11, TypeName = "varchar(16)")]
       public string? c9_total_d_l_in_qty { get; set; }

       [Column("c10_filler", Order = 12, TypeName = "varchar(16)")]
       public string? c10_filler { get; set; }

       [Column("c11_total_c_qty", Order = 13, TypeName = "varchar(16)")]
       public string? c11_total_c_qty { get; set; }

       [Column("c12_total_c_l_in_qty", Order = 14, TypeName = "varchar(16)")]
       public string? c12_total_c_l_in_qty { get; set; }

       [Column("c13_total_n_of_detail_rec", Order = 15, TypeName = "varchar(5)")]
       public string? c13_total_n_of_detail_rec { get; set; }

       [Column("c14_total_n_of_detail_rec_dnr", Order = 16, TypeName = "varchar(5)")]
       public string? c14_total_n_of_detail_rec_dnr { get; set; }

       [Column("c15_cin_bcin_n0", Order = 17, TypeName = "varchar(21)")]
       public string? c15_cin_bcin_n0 { get; set; }

       [Column("c16_email_id_of_comp", Order = 18, TypeName = "varchar(50)")]
       public string? c16_email_id_of_comp { get; set; }

       [Column("c17_fin_year_detail", Order = 19, TypeName = "varchar(9)")]
       public string? c17_fin_year_detail { get; set; }

       [Column("c18_total_n_a_of_shares", Order = 20, TypeName = "varchar(16)")]
       public string? c18_total_n_a_of_shares { get; set; }

   }
}
