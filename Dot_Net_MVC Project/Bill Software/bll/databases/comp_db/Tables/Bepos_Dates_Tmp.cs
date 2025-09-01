using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("bepos_dates_tmp")] 
       
   public class Bepos_Dates_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("import_date", Order = 2, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("day_name", Order = 3, TypeName = "varchar(30)")]
       public string? day_name { get; set; }

       [Column("bepos_dates_id", Order = 4, TypeName = "bigint(10)")]
       public long? bepos_dates_id { get; set; }

   }
}
