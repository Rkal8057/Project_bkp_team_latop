using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("index_tmp_detail_all_save_4_futre")] 
       
   public class Index_Tmp_Detail_All_Save_4_Futre
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("share_qty_per", Order = 3, TypeName = "float")]
       public long? share_qty_per { get; set; }

       [Column("dpid", Order = 4, TypeName = "varchar(16)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 5, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("fstnm", Order = 6, TypeName = "varchar(50)")]
       public string? fstnm { get; set; }

       [Column("pan_no", Order = 7, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("phy_cdsl_nsdl", Order = 8, TypeName = "varchar(8)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("clinet_holding_amt", Order = 9, TypeName = "float")]
       public long? clinet_holding_amt { get; set; }

       [Column("non_promoter", Order = 10, TypeName = "varchar(12)")]
       public string? non_promoter { get; set; }

       [Column("category_header_detail", Order = 11, TypeName = "varchar(50)")]
       public string? category_header_detail { get; set; }

       [Column("category_header", Order = 12, TypeName = "varchar(50)")]
       public string? category_header { get; set; }

       [Column("p_pi_pn", Order = 13, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("import_date", Order = 14, TypeName = "varchar(10)")]
       public string? import_date { get; set; }

       [Column("record_auto_id", Order = 15, TypeName = "bigint(10)")]
       public long? record_auto_id { get; set; }

   }
}
