using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Error_Code_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("exchange_name", Order = 3, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("error_code_description", Order = 4, TypeName = "text")]
       public string? error_code_description { get; set; }

       [Column("error_code", Order = 5, TypeName = "text")]
       public string? error_code { get; set; }

       [Column("record_status", Order = 6, TypeName = "varchar(20)")]
       public string? record_status { get; set; }

   }
}
