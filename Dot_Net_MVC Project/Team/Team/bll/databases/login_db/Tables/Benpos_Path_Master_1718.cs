using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Benpos_Path_Master_1718
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("path_id", Order = 2, TypeName = "bigint(10)")]
       public long? path_id { get; set; }

       [Column("path_detail", Order = 3, TypeName = "text")]
       public string? path_detail { get; set; }

       [Column("benpos_type", Order = 4, TypeName = "varchar(100)")]
       public string? benpos_type { get; set; }

       [Column("benpos_flag", Order = 5, TypeName = "varchar(100)")]
       public string? benpos_flag { get; set; }

       [Column("benpos_detail", Order = 6, TypeName = "text")]
       public string? benpos_detail { get; set; }

   }
}
