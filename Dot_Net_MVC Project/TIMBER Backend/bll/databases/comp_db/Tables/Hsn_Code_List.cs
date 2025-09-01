using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("hsn_code_list")] 
       
   public class Hsn_Code_List
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("old_id", Order = 2, TypeName = "bigint(10)")]
       public long? old_old_id { get; set; }

       [Column("hsn_code", Order = 3, TypeName = "varchar(50)")]
       public string? hsn_code { get; set; }

       [Column("hsn_description", Order = 4, TypeName = "varchar(50)")]
       public string? hsn_description { get; set; }

   }
}
