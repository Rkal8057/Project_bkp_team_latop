using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class User_Log_Master
   {
       [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("log_id", Order = 2, TypeName = "double(18,3)")]
       public long? log_id { get; set; }

       [Column("log_user_id", Order = 3, TypeName = "double(18,3)")]
       public long? log_user_id { get; set; }

       [Column("log_user_name", Order = 4, TypeName = "varchar(250)")]
       public string? log_user_name { get; set; }

       [Column("log_user_type", Order = 5, TypeName = "varchar(250)")]
       public string? log_user_type { get; set; }

       [Column("log_in_time", Order = 6, TypeName = "datetime")]
       public DateTime? log_in_time { get; set; }

       [Column("log_out_time", Order = 7, TypeName = "datetime")]
       public DateTime? log_out_time { get; set; }

   }
}
