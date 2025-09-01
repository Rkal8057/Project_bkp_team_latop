using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Categroy_Master_Phy
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cate_id", Order = 2, TypeName = "bigint(10)")]
       public long? cate_id { get; set; }

       [Column("cate_id_status", Order = 3, TypeName = "text")]
       public string? cate_id_status { get; set; }

       [Column("unique_id", Order = 4, TypeName = "text")]
       public string? unique_id { get; set; }

       [Column("cdsl_unique_code", Order = 5, TypeName = "text")]
       public string? cdsl_unique_code { get; set; }

       [Column("exchange_unique_code", Order = 6, TypeName = "text")]
       public string? exchange_unique_code { get; set; }

       [Column("exchange_name", Order = 7, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("cate_code_1", Order = 8, TypeName = "float")]
       public long? cate_code_1 { get; set; }

       [Column("cate_code_2", Order = 9, TypeName = "float")]
       public long? cate_code_2 { get; set; }

       [Column("cate_code_3", Order = 10, TypeName = "float")]
       public long? cate_code_3 { get; set; }

       [Column("category_header_detail", Order = 11, TypeName = "text")]
       public string? category_header_detail { get; set; }

       [Column("category_header", Order = 12, TypeName = "text")]
       public string? category_header { get; set; }

       [Column("category_header_discreption", Order = 13, TypeName = "text")]
       public string? category_header_discreption { get; set; }

   }
}
