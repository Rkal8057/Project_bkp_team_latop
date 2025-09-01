using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("narration_master")] 
       
   public class Narration_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("narr_code", Order = 2, TypeName = "float")]
       public long? narr_code { get; set; }

       [Column("narr_name", Order = 3, TypeName = "varchar(50)")]
       public string? narr_name { get; set; }

   }
}
