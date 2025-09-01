using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_02_Nsdl
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

       [Column("setup_complete_date", Order = 11, TypeName = "datetime")]
       public DateTime? setup_complete_date { get; set; }

       [Column("document_recv_yn", Order = 12, TypeName = "varchar(3)")]
       public string? document_recv_yn { get; set; }

       [Column("folio_no", Order = 13, TypeName = "varchar(16)")]
       public string? folio_no { get; set; }

       [Column("record_type", Order = 14, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("line_number", Order = 15, TypeName = "varchar(7)")]
       public string? line_number { get; set; }

       [Column("dp_id", Order = 16, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("demat_remat_soa_indicator", Order = 17, TypeName = "varchar(1)")]
       public string? demat_remat_soa_indicator { get; set; }

       [Column("drn_rrn_crn", Order = 18, TypeName = "varchar(40)")]
       public string? drn_rrn_crn { get; set; }

       [Column("beneficiary_account_number", Order = 19, TypeName = "varchar(16)")]
       public string? beneficiary_account_number { get; set; }

       [Column("first_holders_name", Order = 20, TypeName = "varchar(142)")]
       public string? first_holders_name { get; set; }

       [Column("filler_02_1", Order = 21, TypeName = "varchar(115)")]
       public string? filler_02_1 { get; set; }

       [Column("second_holders_name", Order = 22, TypeName = "varchar(142)")]
       public string? second_holders_name { get; set; }

       [Column("third_holders_name", Order = 23, TypeName = "varchar(142)")]
       public string? third_holders_name { get; set; }

       [Column("free_lock_flag", Order = 24, TypeName = "varchar(1)")]
       public string? free_lock_flag { get; set; }

       [Column("locked_in_reason_code", Order = 25, TypeName = "varchar(2)")]
       public string? locked_in_reason_code { get; set; }

       [Column("locked_in_release_date", Order = 26, TypeName = "varchar(20)")]
       public string? locked_in_release_date { get; set; }

       [Column("requested_quantity", Order = 27, TypeName = "double(18,3)")]
       public long? requested_quantity { get; set; }

       [Column("internal_reference_number", Order = 28, TypeName = "varchar(35)")]
       public string? internal_reference_number { get; set; }

       [Column("instruction_receive_date_setup_date", Order = 29, TypeName = "datetime")]
       public DateTime? instruction_receive_date_setup_date { get; set; }

       [Column("drf_rrf_receive_date_crf_receive_date", Order = 30, TypeName = "varchar(20)")]
       public string? drf_rrf_receive_date_crf_receive_date { get; set; }

       [Column("drn_rrn_status_crn_status", Order = 31, TypeName = "varchar(2)")]
       public string? drn_rrn_status_crn_status { get; set; }

       [Column("confirmation_number", Order = 32, TypeName = "varchar(14)")]
       public string? confirmation_number { get; set; }

       [Column("confirmation_date", Order = 33, TypeName = "varchar(20)")]
       public string? confirmation_date { get; set; }

       [Column("accepted_quantity", Order = 34, TypeName = "double(18,3)")]
       public long? accepted_quantity { get; set; }

       [Column("rejected_quantity", Order = 35, TypeName = "double(18,3)")]
       public long? rejected_quantity { get; set; }

       [Column("confirmation_capture_date_time", Order = 36, TypeName = "varchar(20)")]
       public string? confirmation_capture_date_time { get; set; }

       [Column("verify_release_date_time", Order = 37, TypeName = "varchar(20)")]
       public string? verify_release_date_time { get; set; }

       [Column("instruction_receipt_date_time_from_nsdl_dm", Order = 38, TypeName = "varchar(20)")]
       public string? instruction_receipt_date_time_from_nsdl_dm { get; set; }

       [Column("confirmation_status", Order = 39, TypeName = "varchar(2)")]
       public string? confirmation_status { get; set; }

       [Column("rejection_reason_1", Order = 40, TypeName = "varchar(4)")]
       public string? rejection_reason_1 { get; set; }

       [Column("rejection_reason_2", Order = 41, TypeName = "varchar(4)")]
       public string? rejection_reason_2 { get; set; }

       [Column("rejection_reason_3", Order = 42, TypeName = "varchar(4)")]
       public string? rejection_reason_3 { get; set; }

       [Column("rejection_reason_4", Order = 43, TypeName = "varchar(4)")]
       public string? rejection_reason_4 { get; set; }

       [Column("no_of_certificates", Order = 44, TypeName = "varchar(8)")]
       public string? no_of_certificates { get; set; }

       [Column("all_units_indicator", Order = 45, TypeName = "varchar(1)")]
       public string? all_units_indicator { get; set; }

       [Column("all_units_final_confirmation_indicator", Order = 46, TypeName = "varchar(1)")]
       public string? all_units_final_confirmation_indicator { get; set; }

       [Column("beneficiary_type", Order = 47, TypeName = "varchar(2)")]
       public string? beneficiary_type { get; set; }

       [Column("beneficiary_sub_type", Order = 48, TypeName = "varchar(2)")]
       public string? beneficiary_sub_type { get; set; }

       [Column("beneficiary_address_part_1_bp_addr_1", Order = 49, TypeName = "varchar(136)")]
       public string? beneficiary_address_part_1_bp_addr_1 { get; set; }

       [Column("beneficiary_address_part_2_bp_addr_2", Order = 50, TypeName = "varchar(136)")]
       public string? beneficiary_address_part_2_bp_addr_2 { get; set; }

       [Column("beneficiary_address_part_3_bp_addr_3", Order = 51, TypeName = "varchar(136)")]
       public string? beneficiary_address_part_3_bp_addr_3 { get; set; }

       [Column("beneficiary_address_part_4_bp_addr_4", Order = 52, TypeName = "varchar(136)")]
       public string? beneficiary_address_part_4_bp_addr_4 { get; set; }

       [Column("beneficiary_address_pin_code", Order = 53, TypeName = "varchar(10)")]
       public string? beneficiary_address_pin_code { get; set; }

       [Column("first_holder_pan", Order = 54, TypeName = "varchar(130)")]
       public string? first_holder_pan { get; set; }

       [Column("second_holder_pan", Order = 55, TypeName = "varchar(130)")]
       public string? second_holder_pan { get; set; }

       [Column("third_holder_pan", Order = 56, TypeName = "varchar(130)")]
       public string? third_holder_pan { get; set; }

       [Column("first_holder_phone_number", Order = 57, TypeName = "varchar(24)")]
       public string? first_holder_phone_number { get; set; }

       [Column("first_holder_bank_name", Order = 58, TypeName = "varchar(30)")]
       public string? first_holder_bank_name { get; set; }

       [Column("first_holder_bank_account_no", Order = 59, TypeName = "varchar(30)")]
       public string? first_holder_bank_account_no { get; set; }

       [Column("micr_code", Order = 60, TypeName = "varchar(9)")]
       public string? micr_code { get; set; }

       [Column("indian_financial_system_code_ifsc", Order = 61, TypeName = "varchar(11)")]
       public string? indian_financial_system_code_ifsc { get; set; }

       [Column("account_status", Order = 62, TypeName = "varchar(10)")]
       public string? account_status { get; set; }

       [Column("filler_02_2", Order = 63, TypeName = "varchar(18)")]
       public string? filler_02_2 { get; set; }

       [Column("mismatch_yn", Order = 64, TypeName = "varchar(3)")]
       public string? mismatch_yn { get; set; }

       [Column("mismatch_code", Order = 65, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 66, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("user_name", Order = 67, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 68, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
