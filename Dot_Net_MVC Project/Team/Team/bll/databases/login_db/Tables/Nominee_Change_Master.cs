using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Nominee_Change_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("nominee_change_id", Order = 2, TypeName = "bigint(10)")]
       public long? nominee_change_id { get; set; }

       [Column("change_created_on", Order = 3, TypeName = "datetime")]
       public DateTime? change_created_on { get; set; }

       [Column("change_updated_on", Order = 4, TypeName = "datetime")]
       public DateTime? change_updated_on { get; set; }

       [Column("dp_id", Order = 5, TypeName = "varchar(8)")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 6, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("change_flag", Order = 7, TypeName = "varchar(8)")]
       public string? change_flag { get; set; }

       [Column("minor", Order = 8, TypeName = "varchar(1)")]
       public string? minor { get; set; }

       [Column("nomgur", Order = 9, TypeName = "varchar(1)")]
       public string? nomgur { get; set; }

       [Column("ngname", Order = 10, TypeName = "text")]
       public string? ngname { get; set; }

       [Column("ngad1", Order = 11, TypeName = "text")]
       public string? ngad1 { get; set; }

       [Column("ngad2", Order = 12, TypeName = "text")]
       public string? ngad2 { get; set; }

       [Column("ngad3", Order = 13, TypeName = "text")]
       public string? ngad3 { get; set; }

       [Column("ngad4", Order = 14, TypeName = "text")]
       public string? ngad4 { get; set; }

       [Column("ngpin", Order = 15, TypeName = "varchar(10)")]
       public string? ngpin { get; set; }

   }
}
