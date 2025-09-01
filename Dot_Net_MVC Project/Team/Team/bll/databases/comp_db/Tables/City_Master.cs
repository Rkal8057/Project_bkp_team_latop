using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("city_master")] 
       
   public class City_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("city_code", Order = 2, TypeName = "bigint(10)")]
       public long? city_code { get; set; }

       [Column("city_name", Order = 3, TypeName = "varchar(50)")]
       public string? city_name { get; set; }

   }
}
