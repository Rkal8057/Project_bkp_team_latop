using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Exch_Category_Master_Software
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("software_categroy_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? software_categroy_auto_id { get; set; }

       [Column("software_category_name", Order = 3, TypeName = "text")]
       public string? software_category_name { get; set; }

       [Column("software_qtr_categroy_name", Order = 4, TypeName = "text")]
       public string? software_qtr_categroy_name { get; set; }

       [Column("p_pi_pn", Order = 5, TypeName = "varchar(10)")]
       public string? p_pi_pn { get; set; }

   }
}
