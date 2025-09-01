using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_03_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("req_rec_online_isin_no", Order = 3, TypeName = "text")]
       public string? req_rec_online_isin_no { get; set; }

       [Column("req_rec_online_isin_company", Order = 4, TypeName = "text")]
       public string? req_rec_online_isin_company { get; set; }

       [Column("req_rec_online_trx_no", Order = 5, TypeName = "float")]
       public long? req_rec_online_trx_no { get; set; }

       [Column("trx_no", Order = 6, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 7, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 8, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("req_rec_record_date", Order = 9, TypeName = "datetime")]
       public DateTime? req_rec_record_date { get; set; }

       [Column("req_rec_record_date_text", Order = 10, TypeName = "varchar(20)")]
       public string? req_rec_record_date_text { get; set; }

       [Column("rtm8_trx_no", Order = 11, TypeName = "float")]
       public long? rtm8_trx_no { get; set; }

       [Column("record_type", Order = 12, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("line_number", Order = 13, TypeName = "varchar(7)")]
       public string? line_number { get; set; }

       [Column("dp_id", Order = 14, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("demat_remat_soa_indicator", Order = 15, TypeName = "varchar(28)")]
       public string? demat_remat_soa_indicator { get; set; }

       [Column("drn_rrn_crn", Order = 16, TypeName = "varchar(24)")]
       public string? drn_rrn_crn { get; set; }

       [Column("beneficiary_account_number", Order = 17, TypeName = "varchar(16)")]
       public string? beneficiary_account_number { get; set; }

       [Column("folio_number", Order = 18, TypeName = "varchar(20)")]
       public string? folio_number { get; set; }

       [Column("certificate_number", Order = 19, TypeName = "varchar(18)")]
       public string? certificate_number { get; set; }

       [Column("certificate_number_upto", Order = 20, TypeName = "varchar(18)")]
       public string? certificate_number_upto { get; set; }

       [Column("dnr_from", Order = 21, TypeName = "float")]
       public long? dnr_from { get; set; }

       [Column("dnr_to", Order = 22, TypeName = "float")]
       public long? dnr_to { get; set; }

       [Column("quantity", Order = 23, TypeName = "float")]
       public long? quantity { get; set; }

       [Column("name_mismatch_indicator", Order = 24, TypeName = "varchar(1)")]
       public string? name_mismatch_indicator { get; set; }

       [Column("filler_03", Order = 25, TypeName = "varchar(100)")]
       public string? filler_03 { get; set; }

       [Column("mismatch_yn", Order = 26, TypeName = "varchar(3)")]
       public string? mismatch_yn { get; set; }

       [Column("mismatch_code", Order = 27, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 28, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("user_name", Order = 29, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 30, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
