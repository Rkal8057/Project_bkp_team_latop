using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Email_Sender_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sender_id", Order = 2, TypeName = "bigint(10)")]
       public long? sender_id { get; set; }

       [Column("sender_address", Order = 3, TypeName = "text")]
       public string? sender_address { get; set; }

       [Column("sender_password", Order = 4, TypeName = "text")]
       public string? sender_password { get; set; }

       [Column("sender_created_by", Order = 5, TypeName = "text")]
       public string? sender_created_by { get; set; }

       [Column("sender_created_on", Order = 6, TypeName = "datetime")]
       public DateTime? sender_created_on { get; set; }

   }
}
