using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("distribution_tmp_1")] 
       
   public class Distribution_Tmp_1
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("dpid", Order = 3, TypeName = "varchar(8)")]
       public string? dpid { get; set; }

       [Column("folio_ci_id", Order = 4, TypeName = "varchar(8)")]
       public string? folio_ci_id { get; set; }

       [Column("sta", Order = 5, TypeName = "varchar(2)")]
       public string? sta { get; set; }

       [Column("phy_cdsl_nsdl", Order = 6, TypeName = "varchar(50)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("qty_slab", Order = 7, TypeName = "varchar(50)")]
       public string? qty_slab { get; set; }

       [Column("share_holders", Order = 8, TypeName = "varchar(50)")]
       public string? share_holders { get; set; }

   }
}
