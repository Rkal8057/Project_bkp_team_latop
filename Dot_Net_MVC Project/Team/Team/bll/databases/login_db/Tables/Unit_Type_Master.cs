using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Unit_Type_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("unit_id", Order = 2, TypeName = "bigint(10)")]
       public long? unit_id { get; set; }

       [Column("unit_type_name", Order = 3, TypeName = "text")]
       public string? unit_type_name { get; set; }

   }
}
