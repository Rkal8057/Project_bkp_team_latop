using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_Row_File_Nsdl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 5, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("req_rec_online_isin_no", Order = 6, TypeName = "text")]
       public string? req_rec_online_isin_no { get; set; }

       [Column("req_rec_online_isin_company", Order = 7, TypeName = "text")]
       public string? req_rec_online_isin_company { get; set; }

       [Column("req_rec_record_date", Order = 8, TypeName = "datetime")]
       public DateTime? req_rec_record_date { get; set; }

       [Column("req_rec_record_date_text", Order = 9, TypeName = "varchar(20)")]
       public string? req_rec_record_date_text { get; set; }

       [Column("enter_date", Order = 10, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 11, TypeName = "text")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 12, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 13, TypeName = "text")]
       public string? row_text1 { get; set; }

       [Column("row_header_type", Order = 14, TypeName = "varchar(2)")]
       public string? row_header_type { get; set; }

       [Column("folder_name", Order = 15, TypeName = "text")]
       public string? folder_name { get; set; }

       [Column("user_name", Order = 16, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 17, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
