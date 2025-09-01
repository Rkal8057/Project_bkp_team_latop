using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("nsdl_cdls_tmp_rpt_master2")] 
       
   public class Nsdl_Cdls_Tmp_Rpt_Master2
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("import_date", Order = 2, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("import_id", Order = 3, TypeName = "float")]
       public long? import_id { get; set; }

       [Column("import_date2", Order = 4, TypeName = "varchar(10)")]
       public string? import_date2 { get; set; }

   }
}
