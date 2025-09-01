using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Exch_Category_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("category_name", Order = 2, TypeName = "text")]
       public string? category_name { get; set; }

       [Column("category_id", Order = 3, TypeName = "bigint(10)")]
       public long? category_id { get; set; }

       [Column("p_pi_pn", Order = 4, TypeName = "varchar(10)")]
       public string? p_pi_pn { get; set; }

   }
}
