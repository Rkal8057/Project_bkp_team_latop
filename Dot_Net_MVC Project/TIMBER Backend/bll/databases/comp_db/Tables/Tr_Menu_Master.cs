using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_menu_master")] 
       
   public class Tr_Menu_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("tr_sno", Order = 2, TypeName = "bigint(10)")]
       public long? tr_sno { get; set; }

       [Column("form_master_name", Order = 3, TypeName = "varchar(50)")]
       public string? form_master_name { get; set; }

   }
}
