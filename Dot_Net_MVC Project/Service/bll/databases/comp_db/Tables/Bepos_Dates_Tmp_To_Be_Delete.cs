using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("bepos_dates_tmp_to_be_delete")] 
       
   public class Bepos_Dates_Tmp_To_Be_Delete
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("import_date", Order = 2, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("day_name", Order = 3, TypeName = "varchar(30)")]
       public string? day_name { get; set; }

   }
}
