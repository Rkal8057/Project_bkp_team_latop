using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("distribution_master")] 
       
   public class Distribution_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("distribution_id", Order = 2, TypeName = "float")]
       public long? distribution_id { get; set; }

       [Column("qty_slab", Order = 3, TypeName = "varchar(50)")]
       public string? qty_slab { get; set; }

       [Column("share_holders", Order = 4, TypeName = "float")]
       public long? share_holders { get; set; }

       [Column("tot_holder", Order = 5, TypeName = "float")]
       public long? tot_holder { get; set; }

       [Column("share_qty", Order = 6, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("tot_share", Order = 7, TypeName = "float")]
       public long? tot_share { get; set; }

   }
}
