using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Vers_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("vers_id", Order = 2, TypeName = "bigint(10)")]
       public long? vers_id { get; set; }

       [Column("version_detail", Order = 3, TypeName = "varchar(100)")]
       public string? version_detail { get; set; }

       [Column("version_updated_on", Order = 4, TypeName = "datetime")]
       public DateTime? version_updated_on { get; set; }

   }
}
