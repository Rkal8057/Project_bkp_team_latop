using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Mker_Cker_Trans_Status_Msg_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("status_msg_id", Order = 2, TypeName = "bigint(10)")]
       public long? status_msg_id { get; set; }

       [Column("status_msg", Order = 3, TypeName = "text")]
       public string? status_msg { get; set; }

       [Column("status_msg_for", Order = 4, TypeName = "text")]
       public string? status_msg_for { get; set; }

       [Column("created_on", Order = 5, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 6, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

   }
}
