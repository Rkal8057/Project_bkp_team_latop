using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_header_4_all_exch_nsdl")] 
       
   public class Iepf_Header_4_All_Exch_Nsdl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("c1_r_i", Order = 3, TypeName = "varchar(2)")]
       public string? c1_r_i { get; set; }

       [Column("c2_file_id", Order = 4, TypeName = "varchar(16)")]
       public string? c2_file_id { get; set; }

       [Column("c3_rta_i_ref", Order = 5, TypeName = "varchar(16)")]
       public string? c3_rta_i_ref { get; set; }

       [Column("c4_isin_dr", Order = 6, TypeName = "varchar(12)")]
       public string? c4_isin_dr { get; set; }

       [Column("c5_isin_cr", Order = 7, TypeName = "varchar(12)")]
       public string? c5_isin_cr { get; set; }

       [Column("c6_ca_type", Order = 8, TypeName = "varchar(4)")]
       public string? c6_ca_type { get; set; }

       [Column("c7_board_a_d", Order = 9, TypeName = "varchar(8)")]
       public string? c7_board_a_d { get; set; }

       [Column("c8_ca_desc", Order = 10, TypeName = "varchar(4)")]
       public string? c8_ca_desc { get; set; }

       [Column("c9_execution_dt", Order = 11, TypeName = "varchar(8)")]
       public string? c9_execution_dt { get; set; }

       [Column("c10_total_d_qty", Order = 12, TypeName = "varchar(18)")]
       public string? c10_total_d_qty { get; set; }

       [Column("c11_total_d_l_in_qty", Order = 13, TypeName = "varchar(18)")]
       public string? c11_total_d_l_in_qty { get; set; }

       [Column("c12_filler", Order = 14, TypeName = "varchar(16)")]
       public string? c12_filler { get; set; }

       [Column("c13_total_c_qty", Order = 15, TypeName = "varchar(18)")]
       public string? c13_total_c_qty { get; set; }

       [Column("c14_total_c_l_in_qty", Order = 16, TypeName = "varchar(18)")]
       public string? c14_total_c_l_in_qty { get; set; }

       [Column("c15_total_n_of_detail_rec", Order = 17, TypeName = "varchar(7)")]
       public string? c15_total_n_of_detail_rec { get; set; }

       [Column("c16_filler_n_o", Order = 18, TypeName = "varchar(5)")]
       public string? c16_filler_n_o { get; set; }

       [Column("c17_cin_bcin_n0", Order = 19, TypeName = "varchar(21)")]
       public string? c17_cin_bcin_n0 { get; set; }

       [Column("c18_email_id_of_comp", Order = 20, TypeName = "varchar(50)")]
       public string? c18_email_id_of_comp { get; set; }

       [Column("c19_fin_year_detail", Order = 21, TypeName = "varchar(7)")]
       public string? c19_fin_year_detail { get; set; }

       [Column("c20_total_n_a_of_shares", Order = 22, TypeName = "varchar(16)")]
       public string? c20_total_n_a_of_shares { get; set; }

   }
}
