using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("a1_tables_datatype_info_master")] 
       
   public class A1_Tables_Datatype_Info_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("old_id", Order = 2, TypeName = "bigint(10)")]
       public long? old_old_id { get; set; }

       [Column("table_name", Order = 3, TypeName = "varchar(50)")]
       public string? table_name { get; set; }

       [Column("column_name", Order = 4, TypeName = "varchar(50)")]
       public string? column_name { get; set; }

       [Column("column_type", Order = 5, TypeName = "varchar(100)")]
       public string? column_type { get; set; }

       [Column("column_lenght", Order = 6, TypeName = "varchar(100)")]
       public string? column_lenght { get; set; }

       [Column("null_flag", Order = 7, TypeName = "varchar(100)")]
       public string? null_flag { get; set; }

       [Column("column_other_detail", Order = 8, TypeName = "varchar(50)")]
       public string? column_other_detail { get; set; }

   }
}
