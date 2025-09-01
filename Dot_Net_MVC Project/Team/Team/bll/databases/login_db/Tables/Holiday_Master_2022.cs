using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Holiday_Master_2022
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("holiday_date", Order = 3, TypeName = "datetime")]
       public DateTime? holiday_date { get; set; }

       [Column("holiday_date_name", Order = 4, TypeName = "text")]
       public string? holiday_date_name { get; set; }

       [Column("office_date_type", Order = 5, TypeName = "text")]
       public string? office_date_type { get; set; }

       [Column("holiday_category_type", Order = 6, TypeName = "text")]
       public string? holiday_category_type { get; set; }

       [Column("holiday_comment", Order = 7, TypeName = "text")]
       public string? holiday_comment { get; set; }

       [Column("created_on", Order = 8, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 9, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("user_id", Order = 10, TypeName = "text")]
       public string? user_id { get; set; }

       [Column("user_name", Order = 11, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 12, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
