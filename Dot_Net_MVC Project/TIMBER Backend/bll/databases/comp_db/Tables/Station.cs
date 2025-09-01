using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("station")] 
       
   public class Station
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("location_code", Order = 2, TypeName = "bigint(10)")]
       public long? location_code { get; set; }

       [Column("location_name", Order = 3, TypeName = "varchar(50)")]
       public string? location_name { get; set; }

       [Column("city_code", Order = 4, TypeName = "bigint(10)")]
       public long? city_code { get; set; }

       [Column("city_name", Order = 5, TypeName = "varchar(50)")]
       public string? city_name { get; set; }

       [Column("c_code", Order = 6, TypeName = "bigint(10)")]
       public long? c_code { get; set; }

       [Column("c_name", Order = 7, TypeName = "varchar(50)")]
       public string? c_name { get; set; }

       [Column("state_code", Order = 8, TypeName = "bigint(10)")]
       public long? state_code { get; set; }

       [Column("state_name", Order = 9, TypeName = "varchar(50)")]
       public string? state_name { get; set; }

       [Column("pincode", Order = 10, TypeName = "bigint(10)")]
       public long? pincode { get; set; }

       [Column("stdcode", Order = 11, TypeName = "bigint(10)")]
       public long? stdcode { get; set; }

       [Column("stdcode_txt", Order = 12, TypeName = "varchar(50)")]
       public string? stdcode_txt { get; set; }

   }
}
