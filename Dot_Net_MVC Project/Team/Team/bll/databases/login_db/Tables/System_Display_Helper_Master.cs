using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class System_Display_Helper_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("table_field_extra_string_before", Order = 3, TypeName = "varchar(250)")]
       public string? table_field_extra_string_before { get; set; }

       [Column("table_field_name", Order = 4, TypeName = "varchar(250)")]
       public string? table_field_name { get; set; }

       [Column("table_field_extra_string_after", Order = 5, TypeName = "varchar(250)")]
       public string? table_field_extra_string_after { get; set; }

       [Column("table_field_display_name", Order = 6, TypeName = "varchar(250)")]
       public string? table_field_display_name { get; set; }

       [Column("selected_table", Order = 7, TypeName = "text")]
       public string? selected_table { get; set; }

       [Column("selected_table_flag", Order = 8, TypeName = "text")]
       public string? selected_table_flag { get; set; }

       [Column("user_id", Order = 9, TypeName = "bigint(10)")]
       public long? user_id { get; set; }

       [Column("user_name", Order = 10, TypeName = "varchar(250)")]
       public string? user_name { get; set; }

       [Column("index_no", Order = 11, TypeName = "bigint(10)")]
       public long? index_no { get; set; }

       [Column("diplay_status", Order = 12, TypeName = "varchar(50)")]
       public string? diplay_status { get; set; }

       [Column("created_by", Order = 13, TypeName = "varchar(250)")]
       public string? created_by { get; set; }

       [Column("updated_by", Order = 14, TypeName = "varchar(250)")]
       public string? updated_by { get; set; }

       [Column("help_created_on", Order = 15, TypeName = "datetime")]
       public DateTime? help_created_on { get; set; }

       [Column("help_updated_on", Order = 16, TypeName = "datetime")]
       public DateTime? help_updated_on { get; set; }

   }
}
