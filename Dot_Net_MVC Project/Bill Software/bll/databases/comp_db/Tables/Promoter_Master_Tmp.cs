using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("promoter_master_tmp")] 
       
   public class Promoter_Master_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("prom_id", Order = 2, TypeName = "varchar(50)")]
       public string? prom_id { get; set; }

       [Column("porm_panno", Order = 3, TypeName = "varchar(50)")]
       public string? porm_panno { get; set; }

       [Column("porm_category_name", Order = 4, TypeName = "varchar(50)")]
       public string? porm_category_name { get; set; }

       [Column("cdsl_unique_code", Order = 5, TypeName = "varchar(50)")]
       public string? cdsl_unique_code { get; set; }

       [Column("porm_name_via_import", Order = 6, TypeName = "varchar(50)")]
       public string? porm_name_via_import { get; set; }

       [Column("porm_group_type_via_import", Order = 7, TypeName = "varchar(100)")]
       public string? porm_group_type_via_import { get; set; }

       [Column("porm_holding_via_import", Order = 8, TypeName = "varchar(100)")]
       public string? porm_holding_via_import { get; set; }

   }
}
