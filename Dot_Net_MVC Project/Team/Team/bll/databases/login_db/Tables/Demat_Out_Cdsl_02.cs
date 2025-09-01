using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Demat_Out_Cdsl_02
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

       [Column("record_number_in_the_file", Order = 11, TypeName = "float")]
       public long? record_number_in_the_file { get; set; }

       [Column("upload_type", Order = 12, TypeName = "float")]
       public long? upload_type { get; set; }

       [Column("field_1", Order = 13, TypeName = "varchar(13)")]
       public string? field_1 { get; set; }

       [Column("bo_id", Order = 14, TypeName = "varchar(16)")]
       public string? bo_id { get; set; }

       [Column("field_2", Order = 15, TypeName = "varchar(16)")]
       public string? field_2 { get; set; }

       [Column("isin", Order = 16, TypeName = "varchar(12)")]
       public string? isin { get; set; }

       [Column("quantity", Order = 17, TypeName = "float")]
       public long? quantity { get; set; }

       [Column("internal_reference_number", Order = 18, TypeName = "varchar(16)")]
       public string? internal_reference_number { get; set; }

       [Column("business_date", Order = 19, TypeName = "varchar(8)")]
       public string? business_date { get; set; }

       [Column("drn_rrn", Order = 20, TypeName = "float")]
       public long? drn_rrn { get; set; }

       [Column("destat_type_restat_type", Order = 21, TypeName = "varchar(1)")]
       public string? destat_type_restat_type { get; set; }

       [Column("field_3", Order = 22, TypeName = "varchar(8)")]
       public string? field_3 { get; set; }

       [Column("field_4", Order = 23, TypeName = "varchar(8)")]
       public string? field_4 { get; set; }

       [Column("rejection_sequence_number", Order = 24, TypeName = "float")]
       public long? rejection_sequence_number { get; set; }

       [Column("field_5", Order = 25, TypeName = "varchar(1)")]
       public string? field_5 { get; set; }

       [Column("reason_code", Order = 26, TypeName = "float")]
       public long? reason_code { get; set; }

       [Column("number_of_dn_ranges", Order = 27, TypeName = "varchar(16)")]
       public string? number_of_dn_ranges { get; set; }

       [Column("field_7", Order = 28, TypeName = "varchar(13)")]
       public string? field_7 { get; set; }

       [Column("demat_request_form_number_drf", Order = 29, TypeName = "varchar(16)")]
       public string? demat_request_form_number_drf { get; set; }

       [Column("verified_accepted_quantity_mutual_fund_amount", Order = 30, TypeName = "float")]
       public long? verified_accepted_quantity_mutual_fund_amount { get; set; }

       [Column("verified_rejected_quantity", Order = 31, TypeName = "float")]
       public long? verified_rejected_quantity { get; set; }

       [Column("confirmed_accepted_quantity", Order = 32, TypeName = "float")]
       public long? confirmed_accepted_quantity { get; set; }

       [Column("confirmed_rejected_quantity", Order = 33, TypeName = "float")]
       public long? confirmed_rejected_quantity { get; set; }

       [Column("confirmation_rejected_part_quantity", Order = 34, TypeName = "float")]
       public long? confirmation_rejected_part_quantity { get; set; }

       [Column("all_quantity_flag", Order = 35, TypeName = "varchar(1)")]
       public string? all_quantity_flag { get; set; }

       [Column("lock_in_status", Order = 36, TypeName = "varchar(1)")]
       public string? lock_in_status { get; set; }

       [Column("field_8", Order = 37, TypeName = "float")]
       public long? field_8 { get; set; }

       [Column("field_9", Order = 38, TypeName = "varchar(8)")]
       public string? field_9 { get; set; }

       [Column("folio_number", Order = 39, TypeName = "varchar(16)")]
       public string? folio_number { get; set; }

       [Column("field_10", Order = 40, TypeName = "varchar(20)")]
       public string? field_10 { get; set; }

       [Column("field_11", Order = 41, TypeName = "varchar(16)")]
       public string? field_11 { get; set; }

       [Column("rejection_reason_description", Order = 42, TypeName = "varchar(100)")]
       public string? rejection_reason_description { get; set; }

       [Column("field_12", Order = 43, TypeName = "float")]
       public long? field_12 { get; set; }

       [Column("field_13", Order = 44, TypeName = "float")]
       public long? field_13 { get; set; }

       [Column("verification_confirmation_flag", Order = 45, TypeName = "varchar(1)")]
       public string? verification_confirmation_flag { get; set; }

       [Column("field_14", Order = 46, TypeName = "varchar(1)")]
       public string? field_14 { get; set; }

       [Column("field_15", Order = 47, TypeName = "float")]
       public long? field_15 { get; set; }

       [Column("field_16", Order = 48, TypeName = "varchar(8)")]
       public string? field_16 { get; set; }

       [Column("field_17", Order = 49, TypeName = "varchar(16)")]
       public string? field_17 { get; set; }

       [Column("field_18", Order = 50, TypeName = "float")]
       public long? field_18 { get; set; }

       [Column("request_receive_date", Order = 51, TypeName = "varchar(14)")]
       public string? request_receive_date { get; set; }

       [Column("filler_1_document_type", Order = 52, TypeName = "varchar(8)")]
       public string? filler_1_document_type { get; set; }

       [Column("filler_2", Order = 53, TypeName = "varchar(16)")]
       public string? filler_2 { get; set; }

       [Column("filler_3", Order = 54, TypeName = "float")]
       public long? filler_3 { get; set; }

       [Column("error_code", Order = 55, TypeName = "varchar(9)")]
       public string? error_code { get; set; }

   }
}
