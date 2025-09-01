using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reject_Code_Msg_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("rej_id", Order = 2, TypeName = "bigint(10)")]
       public long? rej_id { get; set; }

       [Column("reject_code", Order = 3, TypeName = "varchar(60)")]
       public string? reject_code { get; set; }

       [Column("rej_reason", Order = 4, TypeName = "text")]
       public string? rej_reason { get; set; }

       [Column("rej_flag", Order = 5, TypeName = "varchar(60)")]
       public string? rej_flag { get; set; }

       [Column("nature_type", Order = 6, TypeName = "text")]
       public string? nature_type { get; set; }

       [Column("flag_type", Order = 7, TypeName = "text")]
       public string? flag_type { get; set; }

   }
}
