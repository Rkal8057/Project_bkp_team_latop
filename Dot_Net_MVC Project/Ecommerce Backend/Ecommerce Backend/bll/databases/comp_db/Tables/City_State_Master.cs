using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("city_state_master")] 
       
   public class City_State_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("s_no", Order = 2, TypeName = "bigint(10)")]
       public long? s_no { get; set; }

       [Column("name_of_city", Order = 3, TypeName = "varchar(50)")]
       public string? name_of_city { get; set; }

       [Column("state", Order = 4, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("type", Order = 5, TypeName = "varchar(50)")]
       public string? type { get; set; }

   }
}
