using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Ward_Master_Out1
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("iw_id", Order = 2, TypeName = "bigint(10)")]
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

       [Column("iw_despatch_by", Order = 12, TypeName = "text")]
       public string? iw_despatch_by { get; set; }

       [Column("iw_destination", Order = 13, TypeName = "text")]
       public string? iw_destination { get; set; }

       [Column("iw_despatch_wt", Order = 14, TypeName = "float")]
       public long? iw_despatch_wt { get; set; }

       [Column("iw_despatch_amt", Order = 15, TypeName = "float")]
       public long? iw_despatch_amt { get; set; }

       [Column("iw_despatch_to_be_bill", Order = 16, TypeName = "varchar(3)")]
       public string? iw_despatch_to_be_bill { get; set; }

       [Column("iw_sender_name", Order = 17, TypeName = "text")]
       public string? iw_sender_name { get; set; }

       [Column("iw_sender_email", Order = 18, TypeName = "text")]
       public string? iw_sender_email { get; set; }

       [Column("iw_sender_contact", Order = 19, TypeName = "text")]
       public string? iw_sender_contact { get; set; }

       [Column("iw_address_detail1", Order = 20, TypeName = "text")]
       public string? iw_address_detail1 { get; set; }

       [Column("iw_address_detail2", Order = 21, TypeName = "text")]
       public string? iw_address_detail2 { get; set; }

       [Column("iw_dp_id", Order = 22, TypeName = "text")]
       public string? iw_dp_id { get; set; }

       [Column("iw_cl_id_folio", Order = 23, TypeName = "text")]
       public string? iw_cl_id_folio { get; set; }

       [Column("iw_drn_rr_no", Order = 24, TypeName = "text")]
       public string? iw_drn_rr_no { get; set; }

       [Column("iw_receiver_name", Order = 25, TypeName = "text")]
       public string? iw_receiver_name { get; set; }

       [Column("iw_maker_flag", Order = 26, TypeName = "text")]
       public string? iw_maker_flag { get; set; }

       [Column("iw_checker_flag", Order = 27, TypeName = "text")]
       public string? iw_checker_flag { get; set; }

       [Column("iw_docu_type", Order = 28, TypeName = "text")]
       public string? iw_docu_type { get; set; }

       [Column("iw_purpose_detail", Order = 29, TypeName = "text")]
       public string? iw_purpose_detail { get; set; }

       [Column("iw_remark", Order = 30, TypeName = "text")]
       public string? iw_remark { get; set; }

       [Column("iw_in_user_name", Order = 31, TypeName = "text")]
       public string? iw_in_user_name { get; set; }

       [Column("io_finish_date", Order = 32, TypeName = "datetime")]
       public DateTime? io_finish_date { get; set; }

       [Column("io_finish_remark", Order = 33, TypeName = "text")]
       public string? io_finish_remark { get; set; }

       [Column("io_finish_datetime_auto", Order = 34, TypeName = "datetime")]
       public DateTime? io_finish_datetime_auto { get; set; }

       [Column("io_finish_user_name", Order = 35, TypeName = "text")]
       public string? io_finish_user_name { get; set; }

   }
}
