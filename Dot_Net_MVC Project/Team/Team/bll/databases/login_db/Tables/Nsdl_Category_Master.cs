using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Nsdl_Category_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("nsdl_create_id", Order = 2, TypeName = "bigint(10)")]
       public long? nsdl_create_id { get; set; }

       [Column("ben_type", Order = 3, TypeName = "float")]
       public long? ben_type { get; set; }

       [Column("sub_type", Order = 4, TypeName = "float")]
       public long? sub_type { get; set; }

       [Column("type_name", Order = 5, TypeName = "text")]
       public string? type_name { get; set; }

       [Column("soft_uniq_types", Order = 6, TypeName = "text")]
       public string? soft_uniq_types { get; set; }

       [Column("soft_uniq_code", Order = 7, TypeName = "float")]
       public long? soft_uniq_code { get; set; }

       [Column("p_pi_pn", Order = 8, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_ph", Order = 9, TypeName = "varchar(2)")]
       public string? p_pi_ph { get; set; }

   }
}
