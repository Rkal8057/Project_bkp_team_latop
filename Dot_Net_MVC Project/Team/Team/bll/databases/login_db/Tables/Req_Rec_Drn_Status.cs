using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Drn_Status
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

       [Column("setup_date", Order = 11, TypeName = "datetime")]
       public DateTime? setup_date { get; set; }

       [Column("setup_complete_date", Order = 12, TypeName = "datetime")]
       public DateTime? setup_complete_date { get; set; }

       [Column("document_recv_yn", Order = 13, TypeName = "varchar(3)")]
       public string? document_recv_yn { get; set; }

       [Column("dp_id", Order = 14, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 15, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("folio_no", Order = 16, TypeName = "varchar(16)")]
       public string? folio_no { get; set; }

       [Column("first_holders_name", Order = 17, TypeName = "varchar(142)")]
       public string? first_holders_name { get; set; }

       [Column("second_holders_name", Order = 18, TypeName = "varchar(142)")]
       public string? second_holders_name { get; set; }

       [Column("third_holders_name", Order = 19, TypeName = "varchar(142)")]
       public string? third_holders_name { get; set; }

       [Column("share_qty_drn", Order = 20, TypeName = "double(18,3)")]
       public long? share_qty_drn { get; set; }

       [Column("drn_no", Order = 21, TypeName = "varchar(40)")]
       public string? drn_no { get; set; }

       [Column("exchange_name", Order = 22, TypeName = "varchar(100)")]
       public string? exchange_name { get; set; }

       [Column("drn_status", Order = 23, TypeName = "text")]
       public string? drn_status { get; set; }

       [Column("drn_running_status", Order = 24, TypeName = "varchar(100)")]
       public string? drn_running_status { get; set; }

       [Column("drn_remark", Order = 25, TypeName = "text")]
       public string? drn_remark { get; set; }

       [Column("mismatch_yn", Order = 26, TypeName = "varchar(3)")]
       public string? mismatch_yn { get; set; }

       [Column("mismatch_code", Order = 27, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 28, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("trf_no", Order = 29, TypeName = "double(18,3)")]
       public long? trf_no { get; set; }

       [Column("trf_date", Order = 30, TypeName = "datetime")]
       public DateTime? trf_date { get; set; }

       [Column("trf_days_count", Order = 31, TypeName = "double(18,3)")]
       public long? trf_days_count { get; set; }

       [Column("req_id", Order = 32, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("req_id_reject_yn", Order = 33, TypeName = "varchar(3)")]
       public string? req_id_reject_yn { get; set; }

       [Column("req_id_date", Order = 34, TypeName = "datetime")]
       public DateTime? req_id_date { get; set; }

       [Column("req_id_days_count", Order = 35, TypeName = "double(18,3)")]
       public long? req_id_days_count { get; set; }

       [Column("in_w_id", Order = 36, TypeName = "double(18,3)")]
       public long? in_w_id { get; set; }

       [Column("in_w_id_date", Order = 37, TypeName = "datetime")]
       public DateTime? in_w_id_date { get; set; }

       [Column("in_w_id_days_count", Order = 38, TypeName = "double(18,3)")]
       public long? in_w_id_days_count { get; set; }

       [Column("out_w_id", Order = 39, TypeName = "double(18,3)")]
       public long? out_w_id { get; set; }

       [Column("out_w_id_date", Order = 40, TypeName = "datetime")]
       public DateTime? out_w_id_date { get; set; }

       [Column("out_w_id_days_count", Order = 41, TypeName = "double(18,3)")]
       public long? out_w_id_days_count { get; set; }

       [Column("user_name", Order = 42, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 43, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
