using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Complaint_Rec_Master
   {
       [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cplt_rec_id_auto_id", Order = 2, TypeName = "double(18,3)")]
       public long? cplt_rec_id_auto_id { get; set; }

       [Column("cplt_rec_entry_by_user", Order = 3, TypeName = "text")]
       public string? cplt_rec_entry_by_user { get; set; }

       [Column("cplt_rec_verify_by_checker_yn", Order = 4, TypeName = "varchar(3)")]
       public string? cplt_rec_verify_by_checker_yn { get; set; }

       [Column("cplt_rec_verify_by_user", Order = 5, TypeName = "text")]
       public string? cplt_rec_verify_by_user { get; set; }

       [Column("cplt_rec_verify_by_status", Order = 6, TypeName = "text")]
       public string? cplt_rec_verify_by_status { get; set; }

       [Column("cplt_rec_verify_by_remark", Order = 7, TypeName = "text")]
       public string? cplt_rec_verify_by_remark { get; set; }

       [Column("cplt_rec_verify_datetime_auto", Order = 8, TypeName = "datetime")]
       public DateTime? cplt_rec_verify_datetime_auto { get; set; }

       [Column("cplt_rec_status", Order = 9, TypeName = "text")]
       public string? cplt_rec_status { get; set; }

       [Column("cplt_rec_reject_yn", Order = 10, TypeName = "text")]
       public string? cplt_rec_reject_yn { get; set; }

       [Column("cplt_rec_reject_remark", Order = 11, TypeName = "text")]
       public string? cplt_rec_reject_remark { get; set; }

       [Column("cplt_rec_pod_no", Order = 12, TypeName = "text")]
       public string? cplt_rec_pod_no { get; set; }

       [Column("cplt_rec_manual_no", Order = 13, TypeName = "text")]
       public string? cplt_rec_manual_no { get; set; }

       [Column("cplt_rec_rec_date", Order = 14, TypeName = "datetime")]
       public DateTime? cplt_rec_rec_date { get; set; }

       [Column("cplt_rec_rec_compl_date", Order = 15, TypeName = "datetime")]
       public DateTime? cplt_rec_rec_compl_date { get; set; }

       [Column("cplt_rec_in_datetime_auto", Order = 16, TypeName = "datetime")]
       public DateTime? cplt_rec_in_datetime_auto { get; set; }

       [Column("cplt_rec_inward_category", Order = 17, TypeName = "text")]
       public string? cplt_rec_inward_category { get; set; }

       [Column("cplt_rec_sender_name", Order = 18, TypeName = "text")]
       public string? cplt_rec_sender_name { get; set; }

       [Column("cplt_rec_sender_email", Order = 19, TypeName = "text")]
       public string? cplt_rec_sender_email { get; set; }

       [Column("cplt_rec_sender_contact", Order = 20, TypeName = "text")]
       public string? cplt_rec_sender_contact { get; set; }

       [Column("cplt_rec_address_detail1", Order = 21, TypeName = "text")]
       public string? cplt_rec_address_detail1 { get; set; }

       [Column("cplt_rec_address_detail2", Order = 22, TypeName = "text")]
       public string? cplt_rec_address_detail2 { get; set; }

       [Column("cplt_rec_dp_id", Order = 23, TypeName = "text")]
       public string? cplt_rec_dp_id { get; set; }

       [Column("cplt_rec_cl_id_folio", Order = 24, TypeName = "text")]
       public string? cplt_rec_cl_id_folio { get; set; }

       [Column("cplt_rec_drn_rr_no", Order = 25, TypeName = "text")]
       public string? cplt_rec_drn_rr_no { get; set; }

       [Column("cplt_rec_receiver_name", Order = 26, TypeName = "text")]
       public string? cplt_rec_receiver_name { get; set; }

       [Column("cplt_rec_maker_flag", Order = 27, TypeName = "text")]
       public string? cplt_rec_maker_flag { get; set; }

       [Column("cplt_rec_checker_flag", Order = 28, TypeName = "text")]
       public string? cplt_rec_checker_flag { get; set; }

       [Column("cplt_rec_docu_type", Order = 29, TypeName = "text")]
       public string? cplt_rec_docu_type { get; set; }

       [Column("cplt_rec_purpose_detail", Order = 30, TypeName = "text")]
       public string? cplt_rec_purpose_detail { get; set; }

       [Column("cplt_rec_remark", Order = 31, TypeName = "text")]
       public string? cplt_rec_remark { get; set; }

       [Column("cplt_rec_in_user_name", Order = 32, TypeName = "text")]
       public string? cplt_rec_in_user_name { get; set; }

       [Column("cplt_rec_finish_date", Order = 33, TypeName = "datetime")]
       public DateTime? cplt_rec_finish_date { get; set; }

       [Column("cplt_rec_finish_remark", Order = 34, TypeName = "text")]
       public string? cplt_rec_finish_remark { get; set; }

       [Column("cplt_rec_finish_datetime_auto", Order = 35, TypeName = "datetime")]
       public DateTime? cplt_rec_finish_datetime_auto { get; set; }

       [Column("cplt_rec_finish_user_name", Order = 36, TypeName = "text")]
       public string? cplt_rec_finish_user_name { get; set; }

       [Column("cplt_rec_req_comp_name", Order = 37, TypeName = "text")]
       public string? cplt_rec_req_comp_name { get; set; }

       [Column("cplt_rec_req_comp_name_short", Order = 38, TypeName = "text")]
       public string? cplt_rec_req_comp_name_short { get; set; }

       [Column("cplt_rec_req_comp_isin", Order = 39, TypeName = "text")]
       public string? cplt_rec_req_comp_isin { get; set; }

       [Column("cplt_rec_req_comp_sno", Order = 40, TypeName = "text")]
       public string? cplt_rec_req_comp_sno { get; set; }

       [Column("req_rec_id", Order = 41, TypeName = "float")]
       public long? req_rec_id { get; set; }

       [Column("req_rec_date", Order = 42, TypeName = "datetime")]
       public DateTime? req_rec_date { get; set; }

       [Column("req_rec_status", Order = 43, TypeName = "varchar(100)")]
       public string? req_rec_status { get; set; }

       [Column("req_rec_reject_yn", Order = 44, TypeName = "varchar(1)")]
       public string? req_rec_reject_yn { get; set; }

       [Column("imported_iw_in_atuo_id", Order = 45, TypeName = "double(18,3)")]
       public long? imported_iw_in_atuo_id { get; set; }

       [Column("imported_iw_out_atuo_id", Order = 46, TypeName = "double(18,3)")]
       public long? imported_iw_out_atuo_id { get; set; }

       [Column("folio_no", Order = 47, TypeName = "varchar(20)")]
       public string? folio_no { get; set; }

       [Column("cplt_rec_id", Order = 48, TypeName = "bigint(10)")]
       public long? cplt_rec_id { get; set; }

       [Column("cplt_rec_naturn_of_complaint", Order = 49, TypeName = "text")]
       public string? cplt_rec_naturn_of_complaint { get; set; }

       [Column("cplt_rec_nature_detail", Order = 50, TypeName = "text")]
       public string? cplt_rec_nature_detail { get; set; }

   }
}
