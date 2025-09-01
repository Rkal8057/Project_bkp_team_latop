using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reco_Import_Row_File
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("ref_date", Order = 3, TypeName = "datetime")]
       public DateTime? ref_date { get; set; }

       [Column("enter_date", Order = 4, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 5, TypeName = "varchar(1000)")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 6, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 7, TypeName = "varchar(1000)")]
       public string? row_text1 { get; set; }

       [Column("row_header_type", Order = 8, TypeName = "varchar(2)")]
       public string? row_header_type { get; set; }

       [Column("user_name", Order = 9, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 10, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
