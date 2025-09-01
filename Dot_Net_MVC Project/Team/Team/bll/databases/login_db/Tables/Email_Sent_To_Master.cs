using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Email_Sent_To_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sent_to_id", Order = 2, TypeName = "bigint(10)")]
       public long? sent_to_id { get; set; }

       [Column("sent_to_address", Order = 3, TypeName = "text")]
       public string? sent_to_address { get; set; }

       [Column("sent__to_created_by", Order = 4, TypeName = "text")]
       public string? sent__to_created_by { get; set; }

       [Column("sent_to_created_on", Order = 5, TypeName = "datetime")]
       public DateTime? sent_to_created_on { get; set; }

   }
}
