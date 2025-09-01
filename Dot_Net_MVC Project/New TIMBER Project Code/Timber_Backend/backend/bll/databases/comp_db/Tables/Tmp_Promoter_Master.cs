using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tmp_promoter_master")] 
       
   public class Tmp_Promoter_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("prom_id", Order = 2, TypeName = "double(18,3)")]
       public long? prom_id { get; set; }

       [Column("porm_panno", Order = 3, TypeName = "varchar(50)")]
       public string? porm_panno { get; set; }

       [Column("porm_category_name", Order = 4, TypeName = "varchar(50)")]
       public string? porm_category_name { get; set; }

   }
}
