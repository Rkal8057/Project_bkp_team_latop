using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Field_Master_4_Update
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("field_id", Order = 2, TypeName = "bigint(10)")]
       public long? field_id { get; set; }

       [Column("field_name", Order = 3, TypeName = "text")]
       public string? field_name { get; set; }

       [Column("field_type", Order = 4, TypeName = "text")]
       public string? field_type { get; set; }

       [Column("field_lenght", Order = 5, TypeName = "text")]
       public string? field_lenght { get; set; }

       [Column("table_name_4_update", Order = 6, TypeName = "text")]
       public string? table_name_4_update { get; set; }

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
