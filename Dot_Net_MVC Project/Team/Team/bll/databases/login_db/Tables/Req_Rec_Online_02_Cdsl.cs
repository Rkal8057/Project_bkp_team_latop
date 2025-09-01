using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Online_02_Cdsl
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

       [Column("setup_complete_date", Order = 11, TypeName = "datetime")]
       public DateTime? setup_complete_date { get; set; }

       [Column("document_recv_yn", Order = 12, TypeName = "varchar(3)")]
       public string? document_recv_yn { get; set; }

       [Column("folio_no", Order = 13, TypeName = "varchar(16)")]
       public string? folio_no { get; set; }

       [Column("demat_rta_id_0", Order = 14, TypeName = "varchar(40)")]
       public string? demat_rta_id_0 { get; set; }

       [Column("demat_dp_id_1", Order = 15, TypeName = "varchar(16)")]
       public string? demat_dp_id_1 { get; set; }

       [Column("demat_request_number_2", Order = 16, TypeName = "varchar(100)")]
       public string? demat_request_number_2 { get; set; }

       [Column("quantity_type_code_3", Order = 17, TypeName = "varchar(1)")]
       public string? quantity_type_code_3 { get; set; }

       [Column("quantity_type_description_4", Order = 18, TypeName = "varchar(40)")]
       public string? quantity_type_description_4 { get; set; }

       [Column("demat_requested_quantity_5", Order = 19, TypeName = "float")]
       public long? demat_requested_quantity_5 { get; set; }

       [Column("accepted_quantity_6", Order = 20, TypeName = "float")]
       public long? accepted_quantity_6 { get; set; }

       [Column("rejected_qty_7", Order = 21, TypeName = "float")]
       public long? rejected_qty_7 { get; set; }

       [Column("lock_in_quantity_8", Order = 22, TypeName = "float")]
       public long? lock_in_quantity_8 { get; set; }

       [Column("lock_in_reason_code_9", Order = 23, TypeName = "varchar(40)")]
       public string? lock_in_reason_code_9 { get; set; }

       [Column("lock_in_reason_description_10", Order = 24, TypeName = "varchar(140)")]
       public string? lock_in_reason_description_10 { get; set; }

       [Column("number_of_certificates_11", Order = 25, TypeName = "float")]
       public long? number_of_certificates_11 { get; set; }

       [Column("demat_request_status_code_12", Order = 26, TypeName = "varchar(10)")]
       public string? demat_request_status_code_12 { get; set; }

       [Column("demat_request_status_description_13", Order = 27, TypeName = "varchar(140)")]
       public string? demat_request_status_description_13 { get; set; }

       [Column("isin_14", Order = 28, TypeName = "varchar(12)")]
       public string? isin_14 { get; set; }

       [Column("isin_name_15", Order = 29, TypeName = "varchar(140)")]
       public string? isin_name_15 { get; set; }

       [Column("security_type_16", Order = 30, TypeName = "varchar(10)")]
       public string? security_type_16 { get; set; }

       [Column("security_description_17", Order = 31, TypeName = "varchar(140)")]
       public string? security_description_17 { get; set; }

       [Column("drn_setup_date_dd_mon_yyyy_18", Order = 32, TypeName = "varchar(20)")]
       public string? drn_setup_date_dd_mon_yyyy_18 { get; set; }

       [Column("drn_received_date_by_rta_dd_mon_yyyy_19", Order = 33, TypeName = "varchar(20)")]
       public string? drn_received_date_by_rta_dd_mon_yyyy_19 { get; set; }

       [Column("drn_closed_date_by_rta_dd_mon_yyyy_20", Order = 34, TypeName = "varchar(20)")]
       public string? drn_closed_date_by_rta_dd_mon_yyyy_20 { get; set; }

       [Column("bo_account_number_21", Order = 35, TypeName = "varchar(16)")]
       public string? bo_account_number_21 { get; set; }

       [Column("drf_no_22", Order = 36, TypeName = "varchar(32)")]
       public string? drf_no_22 { get; set; }

       [Column("rta_internal_reference_number_23", Order = 37, TypeName = "varchar(16)")]
       public string? rta_internal_reference_number_23 { get; set; }

       [Column("number_of_days_pending_24", Order = 38, TypeName = "float")]
       public long? number_of_days_pending_24 { get; set; }

       [Column("days_remaining_to_confirm_25", Order = 39, TypeName = "float")]
       public long? days_remaining_to_confirm_25 { get; set; }

       [Column("name_first_sole_holder_name_26", Order = 40, TypeName = "varchar(142)")]
       public string? name_first_sole_holder_name_26 { get; set; }

       [Column("first_joint_holders_name_27", Order = 41, TypeName = "varchar(142)")]
       public string? first_joint_holders_name_27 { get; set; }

       [Column("second_joint_holders_name_28", Order = 42, TypeName = "varchar(142)")]
       public string? second_joint_holders_name_28 { get; set; }

       [Column("bo_address_line_1_29", Order = 43, TypeName = "varchar(155)")]
       public string? bo_address_line_1_29 { get; set; }

       [Column("bo_address_line_2_30", Order = 44, TypeName = "varchar(155)")]
       public string? bo_address_line_2_30 { get; set; }

       [Column("bo_address_line_3_31", Order = 45, TypeName = "varchar(155)")]
       public string? bo_address_line_3_31 { get; set; }

       [Column("bo_towncity_32", Order = 46, TypeName = "varchar(125)")]
       public string? bo_towncity_32 { get; set; }

       [Column("bo_state_33", Order = 47, TypeName = "varchar(125)")]
       public string? bo_state_33 { get; set; }

       [Column("bo_country_34", Order = 48, TypeName = "varchar(125)")]
       public string? bo_country_34 { get; set; }

       [Column("bo_pin_code_35", Order = 49, TypeName = "varchar(20)")]
       public string? bo_pin_code_35 { get; set; }

       [Column("bo_poa_name_36", Order = 50, TypeName = "varchar(142)")]
       public string? bo_poa_name_36 { get; set; }

       [Column("drn_rejection_sequence_37", Order = 51, TypeName = "float")]
       public long? drn_rejection_sequence_37 { get; set; }

       [Column("rejected_quantity_38", Order = 52, TypeName = "float")]
       public long? rejected_quantity_38 { get; set; }

       [Column("rejection_code_39", Order = 53, TypeName = "varchar(20)")]
       public string? rejection_code_39 { get; set; }

       [Column("rejection_reason_40", Order = 54, TypeName = "varchar(200)")]
       public string? rejection_reason_40 { get; set; }

       [Column("mismatch_yn", Order = 55, TypeName = "varchar(3)")]
       public string? mismatch_yn { get; set; }

       [Column("mismatch_code", Order = 56, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 57, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("user_name", Order = 58, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 59, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
