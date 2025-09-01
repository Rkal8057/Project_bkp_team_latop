using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Masters_Show_Allow_User
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("master_form_id", Order = 2, TypeName = "bigint(10)")]
       public long? master_form_id { get; set; }

       [Column("master_form_name", Order = 3, TypeName = "text")]
       public string? master_form_name { get; set; }

       [Column("master_form_show_yn", Order = 4, TypeName = "varchar(3)")]
       public string? master_form_show_yn { get; set; }

       [Column("user_code", Order = 5, TypeName = "float")]
       public long? user_code { get; set; }

       [Column("user_name", Order = 6, TypeName = "varchar(100)")]
       public string? user_name { get; set; }

   }
}
