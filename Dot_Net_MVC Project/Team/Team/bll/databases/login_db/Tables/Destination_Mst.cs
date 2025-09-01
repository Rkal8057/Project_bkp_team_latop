using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Destination_Mst
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("desti_name", Order = 2, TypeName = "text")]
       public string? desti_name { get; set; }

       [Column("desti_id", Order = 3, TypeName = "bigint(10)")]
       public long? desti_id { get; set; }

   }
}
