using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Email_Users_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("email_user_id", Order = 2, TypeName = "bigint(10)")]
       public long? email_user_id { get; set; }

       [Column("email_user_address", Order = 3, TypeName = "text")]
       public string? email_user_address { get; set; }

       [Column("email_created_on", Order = 4, TypeName = "datetime")]
       public DateTime? email_created_on { get; set; }

   }
}
