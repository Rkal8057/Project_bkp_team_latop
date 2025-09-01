using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Ca_Codes_Type_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("exchange_name", Order = 3, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("s_no", Order = 4, TypeName = "float")]
       public long? s_no { get; set; }

       [Column("ca_desc_code", Order = 5, TypeName = "varchar(10)")]
       public string? ca_desc_code { get; set; }

       [Column("ca_main_discription", Order = 6, TypeName = "varchar(100)")]
       public string? ca_main_discription { get; set; }

       [Column("ca_value", Order = 7, TypeName = "varchar(10)")]
       public string? ca_value { get; set; }

       [Column("ca_under_name", Order = 8, TypeName = "varchar(100)")]
       public string? ca_under_name { get; set; }

       [Column("ca_type_main_sub", Order = 9, TypeName = "varchar(100)")]
       public string? ca_type_main_sub { get; set; }

       [Column("record_status", Order = 10, TypeName = "varchar(20)")]
       public string? record_status { get; set; }

   }
}
