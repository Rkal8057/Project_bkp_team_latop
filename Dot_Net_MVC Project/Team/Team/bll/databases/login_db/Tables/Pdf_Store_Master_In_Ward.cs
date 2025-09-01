using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Pdf_Store_Master_In_Ward
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("store_id", Order = 2, TypeName = "bigint(10)")]
       public long? store_id { get; set; }

       [Column("store_file_name", Order = 3, TypeName = "text")]
       public string? store_file_name { get; set; }

       [Column("trx_id", Order = 4, TypeName = "double(18,3)")]
       public long? trx_id { get; set; }

       [Column("record_insert_on", Order = 5, TypeName = "datetime")]
       public DateTime? record_insert_on { get; set; }

       [Column("store_path", Order = 6, TypeName = "text")]
       public string? store_path { get; set; }

       [Column("company_id", Order = 7, TypeName = "double(18,3)")]
       public long? company_id { get; set; }

       [Column("company_isin", Order = 8, TypeName = "text")]
       public string? company_isin { get; set; }

       [Column("company_name", Order = 9, TypeName = "text")]
       public string? company_name { get; set; }

       [Column("dp_id", Order = 10, TypeName = "text")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 11, TypeName = "text")]
       public string? cl_id { get; set; }

       [Column("phy_cdsl_nsdl", Order = 12, TypeName = "text")]
       public string? phy_cdsl_nsdl { get; set; }

   }
}
