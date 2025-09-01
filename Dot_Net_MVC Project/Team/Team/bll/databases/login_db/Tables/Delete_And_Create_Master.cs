using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Delete_And_Create_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("del_create_id", Order = 2, TypeName = "bigint(10)")]
       public long? del_create_id { get; set; }

       [Column("del_create_name", Order = 3, TypeName = "text")]
       public string? del_create_name { get; set; }

       [Column("auto_create_table_yn", Order = 4, TypeName = "varchar(3)")]
       public string? auto_create_table_yn { get; set; }

   }
}
