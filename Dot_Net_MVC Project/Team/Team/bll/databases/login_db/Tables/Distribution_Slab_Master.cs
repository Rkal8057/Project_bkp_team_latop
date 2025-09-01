using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Distribution_Slab_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("disti_id", Order = 2, TypeName = "bigint(10)")]
       public long? disti_id { get; set; }

       [Column("start_qty", Order = 3, TypeName = "float")]
       public long? start_qty { get; set; }

       [Column("end_qty", Order = 4, TypeName = "float")]
       public long? end_qty { get; set; }

       [Column("remark_note", Order = 5, TypeName = "text")]
       public string? remark_note { get; set; }

   }
}
