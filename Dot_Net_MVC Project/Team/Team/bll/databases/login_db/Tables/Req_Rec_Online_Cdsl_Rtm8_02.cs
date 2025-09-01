using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_Cdsl_Rtm8_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("rtm8_02_ref_no", Order = 3, TypeName = "double(18,3)")]
       public long? rtm8_02_ref_no { get; set; }

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

       [Column("drn_status", Order = 10, TypeName = "text")]
       public string? drn_status { get; set; }

       [Column("rtm8_id", Order = 11, TypeName = "double(18,3)")]
       public long? rtm8_id { get; set; }

       [Column("rec_type", Order = 12, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("record_identifier", Order = 13, TypeName = "varchar(2)")]
       public string? record_identifier { get; set; }

       [Column("drn_rrn_crn", Order = 14, TypeName = "varchar(40)")]
       public string? drn_rrn_crn { get; set; }

       [Column("record_number", Order = 15, TypeName = "double(18,3)")]
       public long? record_number { get; set; }

       [Column("ranges_from_number_dnfrm", Order = 16, TypeName = "double(18,3)")]
       public long? ranges_from_number_dnfrm { get; set; }

       [Column("ranges_to_number_dnto", Order = 17, TypeName = "double(18,3)")]
       public long? ranges_to_number_dnto { get; set; }

       [Column("folio_number", Order = 18, TypeName = "varchar(18)")]
       public string? folio_number { get; set; }

       [Column("cert_frm", Order = 19, TypeName = "varchar(18)")]
       public string? cert_frm { get; set; }

       [Column("cert_to", Order = 20, TypeName = "varchar(18)")]
       public string? cert_to { get; set; }

       [Column("alrt_flag", Order = 21, TypeName = "varchar(10)")]
       public string? alrt_flag { get; set; }

       [Column("mismatch_yn", Order = 22, TypeName = "varchar(3)")]
       public string? mismatch_yn { get; set; }

       [Column("mismatch_code", Order = 23, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 24, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("trx_no", Order = 25, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("tmp_trx_no", Order = 26, TypeName = "varchar(50)")]
       public string? tmp_trx_no { get; set; }

       [Column("trx_batch_no", Order = 27, TypeName = "text")]
       public string? trx_batch_no { get; set; }

       [Column("trx_date", Order = 28, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("rtm8_record_date", Order = 29, TypeName = "datetime")]
       public DateTime? rtm8_record_date { get; set; }

       [Column("rtm8_record_date_text", Order = 30, TypeName = "varchar(20)")]
       public string? rtm8_record_date_text { get; set; }

   }
}
