using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reject_Code_Msg_Master_Trx
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("old_id", Order = 2, TypeName = "bigint(10)")]
       public long? old_old_id { get; set; }

       [Column("rej_id", Order = 3, TypeName = "bigint(10)")]
       public long? rej_id { get; set; }

       [Column("rej_reason_trx", Order = 4, TypeName = "text")]
       public string? rej_reason_trx { get; set; }

   }
}
