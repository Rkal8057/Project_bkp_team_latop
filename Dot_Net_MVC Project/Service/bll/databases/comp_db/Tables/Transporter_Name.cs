using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("transporter_name")] 
       
   public class Transporter_Name
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("transporter_id", Order = 2, TypeName = "bigint(10)")]
       public long? transporter_id { get; set; }

       [Column("transporter_name", Order = 3, TypeName = "varchar(250)")]
       public string? transporter_name { get; set; }

   }
}
