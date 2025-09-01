using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Verify_Log_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("verify_log_id", Order = 2, TypeName = "bigint(10)")]
       public long? verify_log_id { get; set; }

       [Column("verify_log_detail", Order = 3, TypeName = "varchar(100)")]
       public string? verify_log_detail { get; set; }

       [Column("verify_log_captcha", Order = 4, TypeName = "varchar(100)")]
       public string? verify_log_captcha { get; set; }

       [Column("verify_log_checker_name", Order = 5, TypeName = "varchar(100)")]
       public string? verify_log_checker_name { get; set; }

       [Column("verify_log_checker_mobile", Order = 6, TypeName = "varchar(100)")]
       public string? verify_log_checker_mobile { get; set; }

       [Column("verify_log_checker_email", Order = 7, TypeName = "varchar(100)")]
       public string? verify_log_checker_email { get; set; }

       [Column("verify_log_maker_name", Order = 8, TypeName = "varchar(100)")]
       public string? verify_log_maker_name { get; set; }

       [Column("verify_log_maker_mobile", Order = 9, TypeName = "varchar(100)")]
       public string? verify_log_maker_mobile { get; set; }

       [Column("verify_log_maker_email", Order = 10, TypeName = "varchar(100)")]
       public string? verify_log_maker_email { get; set; }

       [Column("verify_log_updated_by_type", Order = 11, TypeName = "varchar(100)")]
       public string? verify_log_updated_by_type { get; set; }

       [Column("verify_log_used_for", Order = 12, TypeName = "varchar(100)")]
       public string? verify_log_used_for { get; set; }

       [Column("verify_log_updated_on", Order = 13, TypeName = "datetime")]
       public DateTime? verify_log_updated_on { get; set; }

   }
}
