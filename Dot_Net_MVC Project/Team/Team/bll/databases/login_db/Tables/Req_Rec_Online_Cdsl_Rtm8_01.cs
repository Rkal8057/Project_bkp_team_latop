using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_Cdsl_Rtm8_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("rtm8_01_ref_no", Order = 3, TypeName = "double(18,3)")]
       public long? rtm8_01_ref_no { get; set; }

       [Column("ref_date", Order = 4, TypeName = "datetime")]
       public DateTime? ref_date { get; set; }

       [Column("enter_date", Order = 5, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 6, TypeName = "varchar(1000)")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 7, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 8, TypeName = "text")]
       public string? row_text1 { get; set; }

       [Column("row_header_type", Order = 9, TypeName = "varchar(2)")]
       public string? row_header_type { get; set; }

       [Column("rtm8_id", Order = 10, TypeName = "double(18,3)")]
       public long? rtm8_id { get; set; }

       [Column("rec_type", Order = 11, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("record_identifier", Order = 12, TypeName = "varchar(2)")]
       public string? record_identifier { get; set; }

       [Column("total_records", Order = 13, TypeName = "double(18,3)")]
       public long? total_records { get; set; }

       [Column("trx_no", Order = 14, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("tmp_trx_no", Order = 15, TypeName = "varchar(50)")]
       public string? tmp_trx_no { get; set; }

       [Column("trx_batch_no", Order = 16, TypeName = "text")]
       public string? trx_batch_no { get; set; }

       [Column("trx_date", Order = 17, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("rtm8_record_date", Order = 18, TypeName = "datetime")]
       public DateTime? rtm8_record_date { get; set; }

       [Column("rtm8_record_date_text", Order = 19, TypeName = "varchar(20)")]
       public string? rtm8_record_date_text { get; set; }

   }
}
