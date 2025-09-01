using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Fin_Year_Selection_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("fa_id", Order = 2, TypeName = "bigint(10)")]
       public long? fa_id { get; set; }

       [Column("fa_start_date", Order = 3, TypeName = "datetime")]
       public DateTime? fa_start_date { get; set; }

       [Column("fa_end_date", Order = 4, TypeName = "datetime")]
       public DateTime? fa_end_date { get; set; }

       [Column("fa_financial_year", Order = 5, TypeName = "varchar(50)")]
       public string? fa_financial_year { get; set; }

       [Column("fa_financial_year_short", Order = 6, TypeName = "varchar(50)")]
       public string? fa_financial_year_short { get; set; }

       [Column("fa_financial_year_selected", Order = 7, TypeName = "varchar(50)")]
       public string? fa_financial_year_selected { get; set; }

       [Column("working_start_date", Order = 8, TypeName = "datetime")]
       public DateTime? working_start_date { get; set; }

       [Column("working_end_date", Order = 9, TypeName = "datetime")]
       public DateTime? working_end_date { get; set; }

       [Column("working_financial_year", Order = 10, TypeName = "varchar(50)")]
       public string? working_financial_year { get; set; }

       [Column("working_financial_year_short", Order = 11, TypeName = "varchar(50)")]
       public string? working_financial_year_short { get; set; }

       [Column("working_financial_year_selected", Order = 12, TypeName = "varchar(50)")]
       public string? working_financial_year_selected { get; set; }

   }
}
