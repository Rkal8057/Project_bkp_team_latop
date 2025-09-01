using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Exch_Sub_Category_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("category_id", Order = 2, TypeName = "bigint(10)")]
       public long? category_id { get; set; }

       [Column("category_name", Order = 3, TypeName = "text")]
       public string? category_name { get; set; }

       [Column("main_cate_id", Order = 4, TypeName = "bigint(10)")]
       public long? main_cate_id { get; set; }

       [Column("main_cate_name", Order = 5, TypeName = "text")]
       public string? main_cate_name { get; set; }

   }
}
