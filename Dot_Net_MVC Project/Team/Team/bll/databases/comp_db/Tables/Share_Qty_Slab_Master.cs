using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("share_qty_slab_master")] 
       
   public class Share_Qty_Slab_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("start_qty", Order = 2, TypeName = "float")]
       public long? start_qty { get; set; }

       [Column("end_qty", Order = 3, TypeName = "float")]
       public long? end_qty { get; set; }

       [Column("remark_note", Order = 4, TypeName = "varchar(50)")]
       public string? remark_note { get; set; }

   }
}
