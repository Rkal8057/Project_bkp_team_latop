using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Cdsl_Category_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cdsl_create_id", Order = 2, TypeName = "bigint(10)")]
       public long? cdsl_create_id { get; set; }

       [Column("bosubtype", Order = 3, TypeName = "float")]
       public long? bosubtype { get; set; }

       [Column("bosubtype_name", Order = 4, TypeName = "text")]
       public string? bosubtype_name { get; set; }

       [Column("custtype", Order = 5, TypeName = "float")]
       public long? custtype { get; set; }

       [Column("custtype_name", Order = 6, TypeName = "text")]
       public string? custtype_name { get; set; }

       [Column("bopr", Order = 7, TypeName = "float")]
       public long? bopr { get; set; }

       [Column("bopr_nmae", Order = 8, TypeName = "text")]
       public string? bopr_nmae { get; set; }

       [Column("soft_uniq_code", Order = 9, TypeName = "float")]
       public long? soft_uniq_code { get; set; }

       [Column("soft_uniq_types", Order = 10, TypeName = "text")]
       public string? soft_uniq_types { get; set; }

       [Column("p_pi_pn", Order = 11, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_ph", Order = 12, TypeName = "varchar(2)")]
       public string? p_pi_ph { get; set; }

   }
}
