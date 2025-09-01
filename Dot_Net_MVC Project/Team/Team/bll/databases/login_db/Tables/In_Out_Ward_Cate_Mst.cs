using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class In_Out_Ward_Cate_Mst
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("in_out_ward_id", Order = 2, TypeName = "bigint(10)")]
       public long? in_out_ward_id { get; set; }

       [Column("ward_category", Order = 3, TypeName = "text")]
       public string? ward_category { get; set; }

       [Column("ward_flag", Order = 4, TypeName = "text")]
       public string? ward_flag { get; set; }

       [Column("ward_remark", Order = 5, TypeName = "text")]
       public string? ward_remark { get; set; }

   }
}
