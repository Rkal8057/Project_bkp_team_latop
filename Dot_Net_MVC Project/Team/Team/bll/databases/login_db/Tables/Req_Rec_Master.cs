using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("req_id", Order = 2, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("req_status", Order = 3, TypeName = "text")]
       public string? req_status { get; set; }

       [Column("reject_yn", Order = 4, TypeName = "text")]
       public string? reject_yn { get; set; }

       [Column("reject_code", Order = 5, TypeName = "text")]
       public string? reject_code { get; set; }

       [Column("reject_remark", Order = 6, TypeName = "text")]
       public string? reject_remark { get; set; }

       [Column("req_ref_no", Order = 7, TypeName = "text")]
       public string? req_ref_no { get; set; }

       [Column("req_ref_date", Order = 8, TypeName = "datetime")]
       public DateTime? req_ref_date { get; set; }

       [Column("req_ref_entry_dt", Order = 9, TypeName = "datetime")]
       public DateTime? req_ref_entry_dt { get; set; }

       [Column("req_flag", Order = 10, TypeName = "text")]
       public string? req_flag { get; set; }

       [Column("req_flag_name", Order = 11, TypeName = "text")]
       public string? req_flag_name { get; set; }

       [Column("checking_flag", Order = 12, TypeName = "text")]
       public string? checking_flag { get; set; }

       [Column("req_date", Order = 13, TypeName = "datetime")]
       public DateTime? req_date { get; set; }

       [Column("req_compl_date", Order = 14, TypeName = "datetime")]
       public DateTime? req_compl_date { get; set; }

       [Column("req_holder_name", Order = 15, TypeName = "text")]
       public string? req_holder_name { get; set; }

       [Column("req_foliono", Order = 16, TypeName = "text")]
       public string? req_foliono { get; set; }

       [Column("req_certi_no", Order = 17, TypeName = "text")]
       public string? req_certi_no { get; set; }

       [Column("req_dist_no", Order = 18, TypeName = "text")]
       public string? req_dist_no { get; set; }

       [Column("req_sha_qty", Order = 19, TypeName = "text")]
       public string? req_sha_qty { get; set; }

       [Column("req_comp", Order = 20, TypeName = "text")]
       public string? req_comp { get; set; }

       [Column("req_comp_name", Order = 21, TypeName = "text")]
       public string? req_comp_name { get; set; }

       [Column("req_comp_code", Order = 22, TypeName = "text")]
       public string? req_comp_code { get; set; }

       [Column("req_comp_id", Order = 23, TypeName = "text")]
       public string? req_comp_id { get; set; }

       [Column("req_form_master", Order = 24, TypeName = "text")]
       public string? req_form_master { get; set; }

       [Column("req_remark", Order = 25, TypeName = "text")]
       public string? req_remark { get; set; }

       [Column("user_name", Order = 26, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("req_entry_date", Order = 27, TypeName = "datetime")]
       public DateTime? req_entry_date { get; set; }

       [Column("pod_no", Order = 28, TypeName = "text")]
       public string? pod_no { get; set; }

       [Column("unique_trn_id", Order = 29, TypeName = "text")]
       public string? unique_trn_id { get; set; }

       [Column("verify_yn", Order = 30, TypeName = "varchar(3)")]
       public string? verify_yn { get; set; }

       [Column("verify_by_username", Order = 31, TypeName = "text")]
       public string? verify_by_username { get; set; }

       [Column("verify_status_msg", Order = 32, TypeName = "text")]
       public string? verify_status_msg { get; set; }

       [Column("verify_remark", Order = 33, TypeName = "text")]
       public string? verify_remark { get; set; }

       [Column("verify_updated_on", Order = 34, TypeName = "datetime")]
       public DateTime? verify_updated_on { get; set; }

       [Column("suggestion_type", Order = 35, TypeName = "text")]
       public string? suggestion_type { get; set; }

       [Column("cl_id", Order = 36, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("dp_id", Order = 37, TypeName = "varchar(8)")]
       public string? dp_id { get; set; }

       [Column("derno", Order = 38, TypeName = "varchar(50)")]
       public string? derno { get; set; }

       [Column("req_id_delete_status", Order = 39, TypeName = "varchar(50)")]
       public string? req_id_delete_status { get; set; }

       [Column("req_id_delete_status_id", Order = 40, TypeName = "float")]
       public long? req_id_delete_status_id { get; set; }

       [Column("req_holder_name_2", Order = 41, TypeName = "varchar(150)")]
       public string? req_holder_name_2 { get; set; }

       [Column("req_holder_name_3", Order = 42, TypeName = "varchar(150)")]
       public string? req_holder_name_3 { get; set; }

       [Column("multiple_folio", Order = 43, TypeName = "varchar(3)")]
       public string? multiple_folio { get; set; }

       [Column("master_trfno", Order = 44, TypeName = "float")]
       public long? master_trfno { get; set; }

       [Column("master_req_id", Order = 45, TypeName = "float")]
       public long? master_req_id { get; set; }

       [Column("multiple_trx_yn", Order = 46, TypeName = "varchar(3)")]
       public string? multiple_trx_yn { get; set; }

       [Column("multiple_req_status", Order = 47, TypeName = "text")]
       public string? multiple_req_status { get; set; }

       [Column("multiple_req_ref_no", Order = 48, TypeName = "text")]
       public string? multiple_req_ref_no { get; set; }

       [Column("multiple_req_flag_codes_and_names", Order = 49, TypeName = "text")]
       public string? multiple_req_flag_codes_and_names { get; set; }

       [Column("setup_date", Order = 50, TypeName = "datetime")]
       public DateTime? setup_date { get; set; }

       [Column("share_qty_tot", Order = 51, TypeName = "float")]
       public long? share_qty_tot { get; set; }

       [Column("certificate_tot", Order = 52, TypeName = "float")]
       public long? certificate_tot { get; set; }

       [Column("partial_demat_request_yn", Order = 53, TypeName = "varchar(3)")]
       public string? partial_demat_request_yn { get; set; }

       [Column("req_holder_name_as_per_record_1", Order = 54, TypeName = "text")]
       public string? req_holder_name_as_per_record_1 { get; set; }

       [Column("req_holder_name_as_per_record_2", Order = 55, TypeName = "text")]
       public string? req_holder_name_as_per_record_2 { get; set; }

       [Column("req_holder_name_as_per_record_3", Order = 56, TypeName = "text")]
       public string? req_holder_name_as_per_record_3 { get; set; }

       [Column("name_mismatch_yn", Order = 57, TypeName = "varchar(3)")]
       public string? name_mismatch_yn { get; set; }

       [Column("mis_match_detail", Order = 58, TypeName = "text")]
       public string? mis_match_detail { get; set; }

       [Column("mis_match_present_yn", Order = 59, TypeName = "varchar(3)")]
       public string? mis_match_present_yn { get; set; }

       [Column("kyc_status", Order = 60, TypeName = "varchar(3)")]
       public string? kyc_status { get; set; }

       [Column("mismatch_code", Order = 61, TypeName = "varchar(10)")]
       public string? mismatch_code { get; set; }

       [Column("mismatch_detail", Order = 62, TypeName = "text")]
       public string? mismatch_detail { get; set; }

       [Column("drn_from_setup_file_yn", Order = 63, TypeName = "varchar(1)")]
       public string? drn_from_setup_file_yn { get; set; }

       [Column("validate_inward_id_yn", Order = 64, TypeName = "varchar(1)")]
       public string? validate_inward_id_yn { get; set; }

       [Column("dp_folio_no_req", Order = 65, TypeName = "text")]
       public string? dp_folio_no_req { get; set; }

       [Column("multi_folio_count", Order = 66, TypeName = "float")]
       public long? multi_folio_count { get; set; }

       [Column("allow_drn_setup_mismatch_folio_yn", Order = 67, TypeName = "varchar(1)")]
       public string? allow_drn_setup_mismatch_folio_yn { get; set; }

   }
}
