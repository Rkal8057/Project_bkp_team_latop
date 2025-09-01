using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("category_master")] 
       
   public class Category_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cat_code", Order = 2, TypeName = "bigint(10)")]
       public long? cat_code { get; set; }

       [Column("cat_name", Order = 3, TypeName = "varchar(50)")]
       public string? cat_name { get; set; }

       [Column("cat_type", Order = 4, TypeName = "varchar(50)")]
       public string? cat_type { get; set; }

       [Column("cat_main_code", Order = 5, TypeName = "bigint(10)")]
       public long? cat_main_code { get; set; }

       [Column("cat_main", Order = 6, TypeName = "varchar(50)")]
       public string? cat_main { get; set; }

       [Column("supermain_code", Order = 7, TypeName = "bigint(10)")]
       public long? supermain_code { get; set; }

       [Column("undercode", Order = 8, TypeName = "bigint(10)")]
       public long? undercode { get; set; }

       [Column("undername", Order = 9, TypeName = "varchar(50)")]
       public string? undername { get; set; }

       [Column("delete_option", Order = 10, TypeName = "varchar(50)")]
       public string? delete_option { get; set; }

   }
}
