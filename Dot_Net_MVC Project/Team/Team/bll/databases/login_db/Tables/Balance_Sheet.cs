using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Balance_Sheet
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cat_code", Order = 2, TypeName = "bigint(10)")]
       public long? cat_code { get; set; }

       [Column("cat_name", Order = 3, TypeName = "varchar(50)")]
       public string? cat_name { get; set; }

       [Column("cat_type", Order = 4, TypeName = "varchar(50)")]
       public string? cat_type { get; set; }

       [Column("cat_main", Order = 5, TypeName = "varchar(50)")]
       public string? cat_main { get; set; }

       [Column("supermain", Order = 6, TypeName = "varchar(50)")]
       public string? supermain { get; set; }

       [Column("drcr", Order = 7, TypeName = "varchar(50)")]
       public string? drcr { get; set; }

       [Column("todo", Order = 8, TypeName = "varchar(1)")]
       public string? todo { get; set; }

       [Column("window", Order = 9, TypeName = "varchar(1)")]
       public string? window { get; set; }

       [Column("mindex", Order = 10, TypeName = "bigint(10)")]
       public long? mindex { get; set; }

       [Column("del_yn", Order = 11, TypeName = "varchar(1)")]
       public string? del_yn { get; set; }

   }
}
