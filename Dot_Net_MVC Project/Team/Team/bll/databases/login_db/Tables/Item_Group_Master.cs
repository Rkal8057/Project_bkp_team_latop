using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Item_Group_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cat_code", Order = 2, TypeName = "bigint(10)")]
       public long? cat_code { get; set; }

       [Column("cat_name", Order = 3, TypeName = "varchar(50)")]
       public string? cat_name { get; set; }

       [Column("cat_type", Order = 4, TypeName = "varchar(5)")]
       public string? cat_type { get; set; }

       [Column("cat_main_code", Order = 5, TypeName = "bigint(10)")]
       public long? cat_main_code { get; set; }

       [Column("cat_main", Order = 6, TypeName = "varchar(50)")]
       public string? cat_main { get; set; }

       [Column("supermain_code", Order = 7, TypeName = "bigint(10)")]
       public long? supermain_code { get; set; }

       [Column("delete_option", Order = 8, TypeName = "varchar(50)")]
       public string? delete_option { get; set; }

       [Column("other1", Order = 9, TypeName = "varchar(250)")]
       public string? other1 { get; set; }

       [Column("other2", Order = 10, TypeName = "varchar(250)")]
       public string? other2 { get; set; }

       [Column("other_num1", Order = 11, TypeName = "bigint(10)")]
       public long? other_num1 { get; set; }

       [Column("other_num2", Order = 12, TypeName = "bigint(10)")]
       public long? other_num2 { get; set; }

       [Column("gst_tax_slab", Order = 13, TypeName = "double(18,3)")]
       public long? gst_tax_slab { get; set; }

   }
}
