using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("state_master")] 
       
   public class State_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("state_id", Order = 2, TypeName = "bigint(10)")]
       public long? state_id { get; set; }

       [Column("state_name", Order = 3, TypeName = "varchar(50)")]
       public string? state_name { get; set; }

       [Column("state_no", Order = 4, TypeName = "varchar(10)")]
       public string? state_no { get; set; }

       [Column("state_code", Order = 5, TypeName = "varchar(10)")]
       public string? state_code { get; set; }

   }
}
