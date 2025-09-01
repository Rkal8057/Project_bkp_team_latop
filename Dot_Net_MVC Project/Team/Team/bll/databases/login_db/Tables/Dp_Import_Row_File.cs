using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Dp_Import_Row_File
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 5, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("dp_record_date", Order = 6, TypeName = "datetime")]
       public DateTime? dp_record_date { get; set; }

       [Column("dp_record_date_text", Order = 7, TypeName = "varchar(50)")]
       public string? dp_record_date_text { get; set; }

       [Column("enter_date", Order = 8, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 9, TypeName = "varchar(1000)")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 10, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 11, TypeName = "varchar(1000)")]
       public string? row_text1 { get; set; }

       [Column("row_header_type", Order = 12, TypeName = "varchar(2)")]
       public string? row_header_type { get; set; }

       [Column("user_name", Order = 13, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 14, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
