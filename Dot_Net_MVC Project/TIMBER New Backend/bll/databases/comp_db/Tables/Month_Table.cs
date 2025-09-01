using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("month_table")] 
       
   public class Month_Table
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("month_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? month_auto_id { get; set; }

       [Column("month_no", Order = 3, TypeName = "float")]
       public long? month_no { get; set; }

       [Column("month_name_short", Order = 4, TypeName = "varchar(50)")]
       public string? month_name_short { get; set; }

       [Column("month_name_long", Order = 5, TypeName = "varchar(50)")]
       public string? month_name_long { get; set; }

       [Column("year_name", Order = 6, TypeName = "bigint(10)")]
       public long? year_name { get; set; }

       [Column("dt_from", Order = 7, TypeName = "datetime")]
       public DateTime? dt_from { get; set; }

       [Column("dt_to", Order = 8, TypeName = "datetime")]
       public DateTime? dt_to { get; set; }

       [Column("no_index", Order = 9, TypeName = "float")]
       public long? no_index { get; set; }

       [Column("calculate_month", Order = 10, TypeName = "bigint(10)")]
       public long? calculate_month { get; set; }

       [Column("no_of_days", Order = 11, TypeName = "bigint(10)")]
       public long? no_of_days { get; set; }

   }
}
