using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("a1_tables_info_master_main")] 
       
   public class A1_Tables_Info_Master_Main
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_catalog", Order = 2, TypeName = "varchar(128)")]
       public string? table_catalog { get; set; }

       [Column("table_schema", Order = 3, TypeName = "varchar(128)")]
       public string? table_schema { get; set; }

       [Column("table_name", Order = 4, TypeName = "varchar(128)")]
       public string? table_name { get; set; }

       [Column("table_type", Order = 5, TypeName = "varchar(10)")]
       public string? table_type { get; set; }

   }
}
