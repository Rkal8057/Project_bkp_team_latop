using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Ward_Master_In
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("iw_id", Order = 2, TypeName = "double(18,3)")]
       public long? iw_id { get; set; }

       [Column("iw_status", Order = 3, TypeName = "text")]
       public string? iw_status { get; set; }

       [Column("iw_reject_yn", Order = 4, TypeName = "text")]
       public string? iw_reject_yn { get; set; }

       [Column("iw_reject_remark", Order = 5, TypeName = "text")]
       public string? iw_reject_remark { get; set; }

       [Column("iw_pod_no", Order = 6, TypeName = "text")]
       public string? iw_pod_no { get; set; }

       [Column("iw_manual_no", Order = 7, TypeName = "text")]
       public string? iw_manual_no { get; set; }

       [Column("iw_rec_date", Order = 8, TypeName = "datetime")]
       public DateTime? iw_rec_date { get; set; }

       [Column("iw_rec_compl_date", Order = 9, TypeName = "datetime")]
       public DateTime? iw_rec_compl_date { get; set; }

       [Column("iw_in_datetime_auto", Order = 10, TypeName = "datetime")]
       public DateTime? iw_in_datetime_auto { get; set; }

       [Column("iw_inward_category", Order = 11, TypeName = "text")]
       public string? iw_inward_category { get; set; }

       [Column("iw_sender_name", Order = 12, TypeName = "text")]
       public string? iw_sender_name { get; set; }

       [Column("iw_sender_email", Order = 13, TypeName = "text")]
       public string? iw_sender_email { get; set; }

       [Column("iw_sender_contact", Order = 14, TypeName = "text")]
       public string? iw_sender_contact { get; set; }

       [Column("iw_address_detail1", Order = 15, TypeName = "text")]
       public string? iw_address_detail1 { get; set; }

       [Column("iw_address_detail2", Order = 16, TypeName = "text")]
       public string? iw_address_detail2 { get; set; }

       [Column("iw_dp_id", Order = 17, TypeName = "text")]
       public string? iw_dp_id { get; set; }

       [Column("iw_cl_id_folio", Order = 18, TypeName = "text")]
       public string? iw_cl_id_folio { get; set; }

       [Column("iw_drn_rr_no", Order = 19, TypeName = "text")]
       public string? iw_drn_rr_no { get; set; }

       [Column("iw_receiver_name", Order = 20, TypeName = "text")]
       public string? iw_receiver_name { get; set; }

       [Column("iw_maker_flag", Order = 21, TypeName = "text")]
       public string? iw_maker_flag { get; set; }

       [Column("iw_checker_flag", Order = 22, TypeName = "text")]
       public string? iw_checker_flag { get; set; }

       [Column("iw_docu_type", Order = 23, TypeName = "text")]
       public string? iw_docu_type { get; set; }

       [Column("iw_purpose_detail", Order = 24, TypeName = "text")]
       public string? iw_purpose_detail { get; set; }

       [Column("iw_remark", Order = 25, TypeName = "text")]
       public string? iw_remark { get; set; }

       [Column("iw_in_user_name", Order = 26, TypeName = "text")]
       public string? iw_in_user_name { get; set; }

       [Column("io_finish_date", Order = 27, TypeName = "datetime")]
       public DateTime? io_finish_date { get; set; }

       [Column("io_finish_remark", Order = 28, TypeName = "text")]
       public string? io_finish_remark { get; set; }

       [Column("io_finish_datetime_auto", Order = 29, TypeName = "datetime")]
       public DateTime? io_finish_datetime_auto { get; set; }

       [Column("io_finish_user_name", Order = 30, TypeName = "text")]
       public string? io_finish_user_name { get; set; }

       [Column("req_comp", Order = 31, TypeName = "text")]
       public string? req_comp { get; set; }

       [Column("req_comp_name", Order = 32, TypeName = "text")]
       public string? req_comp_name { get; set; }

       [Column("req_comp_code", Order = 33, TypeName = "text")]
       public string? req_comp_code { get; set; }

       [Column("req_comp_id", Order = 34, TypeName = "text")]
       public string? req_comp_id { get; set; }

       [Column("req_rec_id", Order = 35, TypeName = "float")]
       public long? req_rec_id { get; set; }

       [Column("req_rec_date", Order = 36, TypeName = "datetime")]
       public DateTime? req_rec_date { get; set; }

       [Column("req_rec_status", Order = 37, TypeName = "varchar(100)")]
       public string? req_rec_status { get; set; }

       [Column("req_rec_reject_yn", Order = 38, TypeName = "varchar(1)")]
       public string? req_rec_reject_yn { get; set; }

       [Column("imported_iw_atuo_id", Order = 39, TypeName = "text")]
       public string? imported_iw_atuo_id { get; set; }

       [Column("cplt_rec_id", Order = 40, TypeName = "text")]
       public string? cplt_rec_id { get; set; }

       [Column("trfno", Order = 41, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("vou_type", Order = 42, TypeName = "text")]
       public string? vou_type { get; set; }

       [Column("filling_master_auto_id", Order = 43, TypeName = "double(18,3)")]
       public long? filling_master_auto_id { get; set; }

       [Column("filling_status", Order = 44, TypeName = "varchar(100)")]
       public string? filling_status { get; set; }

       [Column("un_delivered_yn", Order = 45, TypeName = "text")]
       public string? un_delivered_yn { get; set; }

       [Column("un_delivered_date", Order = 46, TypeName = "datetime")]
       public DateTime? un_delivered_date { get; set; }

       [Column("un_delivered_remark", Order = 47, TypeName = "text")]
       public string? un_delivered_remark { get; set; }

       [Column("exchange_name", Order = 48, TypeName = "varchar(50)")]
       public string? exchange_name { get; set; }

       [Column("pod_rec_type", Order = 49, TypeName = "text")]
       public string? pod_rec_type { get; set; }

       [Column("courier_name", Order = 50, TypeName = "text")]
       public string? courier_name { get; set; }

       [Column("folio_no", Order = 51, TypeName = "varchar(20)")]
       public string? folio_no { get; set; }

   }
}
