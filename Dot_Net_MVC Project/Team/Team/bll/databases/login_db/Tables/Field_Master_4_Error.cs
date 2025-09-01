using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Field_Master_4_Error
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("error_id", Order = 2, TypeName = "bigint(10)")]
       public long? error_id { get; set; }

       [Column("error_name", Order = 3, TypeName = "text")]
       public string? error_name { get; set; }

       [Column("error_type", Order = 4, TypeName = "text")]
       public string? error_type { get; set; }

       [Column("error_detail", Order = 5, TypeName = "text")]
       public string? error_detail { get; set; }

       [Column("error_table_name", Order = 6, TypeName = "text")]
       public string? error_table_name { get; set; }

       [Column("reason_or_remark", Order = 7, TypeName = "text")]
       public string? reason_or_remark { get; set; }

       [Column("database_used", Order = 8, TypeName = "text")]
       public string? database_used { get; set; }

       [Column("update_type", Order = 9, TypeName = "text")]
       public string? update_type { get; set; }

       [Column("created_on_text", Order = 10, TypeName = "text")]
       public string? created_on_text { get; set; }

       [Column("created_on_datetime", Order = 11, TypeName = "text")]
       public string? created_on_datetime { get; set; }

   }
}
