using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Isin_Status_Master_Nsdl_Cdsl_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("isin_status_import_trx_no", Order = 5, TypeName = "double(18,3)")]
       public long? isin_status_import_trx_no { get; set; }

       [Column("trx_date", Order = 6, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("isin_status_record_date", Order = 7, TypeName = "datetime")]
       public DateTime? isin_status_record_date { get; set; }

       [Column("isin_status_record_date_text", Order = 8, TypeName = "varchar(50)")]
       public string? isin_status_record_date_text { get; set; }

       [Column("enter_date", Order = 9, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 10, TypeName = "text")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 11, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 12, TypeName = "text")]
       public string? row_text1 { get; set; }

       [Column("rec_type", Order = 13, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("isin_status_id", Order = 14, TypeName = "varchar(16)")]
       public string? isin_status_id { get; set; }

       [Column("full_incremental_flag", Order = 15, TypeName = "varchar(10)")]
       public string? full_incremental_flag { get; set; }

       [Column("incremental_reference_datetime", Order = 16, TypeName = "varchar(30)")]
       public string? incremental_reference_datetime { get; set; }

       [Column("statement_preparation_date", Order = 17, TypeName = "varchar(20)")]
       public string? statement_preparation_date { get; set; }

       [Column("statement_preparation_time", Order = 18, TypeName = "varchar(20)")]
       public string? statement_preparation_time { get; set; }

       [Column("total_number_of_detail_records", Order = 19, TypeName = "float")]
       public long? total_number_of_detail_records { get; set; }

       [Column("filler", Order = 20, TypeName = "varchar(10)")]
       public string? filler { get; set; }

       [Column("user_name", Order = 21, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 22, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
