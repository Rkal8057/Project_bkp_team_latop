using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Despatch_By_Mst
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("despatch_by_name", Order = 2, TypeName = "text")]
       public string? despatch_by_name { get; set; }

       [Column("despatch_by_id", Order = 3, TypeName = "bigint(10)")]
       public long? despatch_by_id { get; set; }

   }
}
