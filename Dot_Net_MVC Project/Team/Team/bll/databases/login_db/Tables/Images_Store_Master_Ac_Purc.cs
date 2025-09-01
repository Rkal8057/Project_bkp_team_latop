using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Images_Store_Master_Ac_Purc
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("image_id", Order = 2, TypeName = "bigint(10)")]
       public long? image_id { get; set; }

       [Column("image_name", Order = 3, TypeName = "text")]
       public string? image_name { get; set; }

       [Column("ac_purc_bill_id", Order = 4, TypeName = "double(18,3)")]
       public long? ac_purc_bill_id { get; set; }

       [Column("company_id", Order = 5, TypeName = "double(18,3)")]
       public long? company_id { get; set; }

       [Column("company_isin", Order = 6, TypeName = "text")]
       public string? company_isin { get; set; }

       [Column("company_name", Order = 7, TypeName = "text")]
       public string? company_name { get; set; }

       [Column("record_insert_on", Order = 8, TypeName = "datetime")]
       public DateTime? record_insert_on { get; set; }

       [Column("image_path", Order = 9, TypeName = "text")]
       public string? image_path { get; set; }

   }
}
