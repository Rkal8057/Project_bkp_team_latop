using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_detail_nsdl_phy_dnr")] 
       
   public class Iepf_Detail_Nsdl_Phy_Dnr
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("folio_no", Order = 3, TypeName = "varchar(16)")]
       public string? folio_no { get; set; }

       [Column("c1_rec_id", Order = 4, TypeName = "varchar(2)")]
       public string? c1_rec_id { get; set; }

       [Column("c2_rec_iine_no", Order = 5, TypeName = "varchar(7)")]
       public string? c2_rec_iine_no { get; set; }

       [Column("c3_isin", Order = 6, TypeName = "varchar(12)")]
       public string? c3_isin { get; set; }

       [Column("c4_dr_cr_type", Order = 7, TypeName = "varchar(1)")]
       public string? c4_dr_cr_type { get; set; }

       [Column("c5_dist_no_from", Order = 8, TypeName = "varchar(18)")]
       public string? c5_dist_no_from { get; set; }

       [Column("c7_dist_no_upto", Order = 9, TypeName = "varchar(18)")]
       public string? c7_dist_no_upto { get; set; }

       [Column("c8_qty", Order = 10, TypeName = "varchar(18)")]
       public string? c8_qty { get; set; }

       [Column("c9_flag_4_status_dn_range", Order = 11, TypeName = "varchar(2)")]
       public string? c9_flag_4_status_dn_range { get; set; }

       [Column("c10_ca_type", Order = 12, TypeName = "varchar(4)")]
       public string? c10_ca_type { get; set; }

   }
}
