using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("prawuse")] 
       
   public class Prawuse
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("billno", Order = 2, TypeName = "varchar(10)")]
       public string? billno { get; set; }

       [Column("pcode", Order = 3, TypeName = "varchar(10)")]
       public string? pcode { get; set; }

       [Column("date", Order = 4, TypeName = "datetime")]
       public DateTime? date { get; set; }

       [Column("fcode", Order = 5, TypeName = "varchar(10)")]
       public string? fcode { get; set; }

       [Column("sno", Order = 6, TypeName = "varchar(10)")]
       public string? sno { get; set; }

       [Column("rcode", Order = 7, TypeName = "varchar(10)")]
       public string? rcode { get; set; }

       [Column("qty", Order = 8, TypeName = "float")]
       public long? qty { get; set; }

       [Column("size", Order = 9, TypeName = "float")]
       public long? size { get; set; }

   }
}
