using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_03_Nsdl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

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

       [Column("record_type", Order = 11, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("line_number", Order = 12, TypeName = "varchar(7)")]
       public string? line_number { get; set; }

       [Column("dp_id", Order = 13, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("demat_remat_soa_indicator", Order = 14, TypeName = "varchar(18)")]
       public string? demat_remat_soa_indicator { get; set; }

       [Column("drn_rrn_crn", Order = 15, TypeName = "varchar(40)")]
       public string? drn_rrn_crn { get; set; }

       [Column("beneficiary_account_number", Order = 16, TypeName = "varchar(16)")]
       public string? beneficiary_account_number { get; set; }

       [Column("folio_number", Order = 17, TypeName = "varchar(20)")]
       public string? folio_number { get; set; }

       [Column("certificate_number", Order = 18, TypeName = "varchar(18)")]
       public string? certificate_number { get; set; }

       [Column("dnr_from", Order = 19, TypeName = "float")]
       public long? dnr_from { get; set; }

       [Column("dnr_to", Order = 20, TypeName = "float")]
       public long? dnr_to { get; set; }

       [Column("quantity", Order = 21, TypeName = "float")]
       public long? quantity { get; set; }

       [Column("name_mismatch_indicator", Order = 22, TypeName = "varchar(1)")]
       public string? name_mismatch_indicator { get; set; }

       [Column("mismatch_yn", Order = 23, TypeName = "varchar(3)")]
       public string? mismatch_yn { get; set; }

       [Column("mismatch_code", Order = 24, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 25, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("filler_03", Order = 26, TypeName = "varchar(100)")]
       public string? filler_03 { get; set; }

       [Column("certificate_number_upto", Order = 27, TypeName = "varchar(18)")]
       public string? certificate_number_upto { get; set; }

   }
}
