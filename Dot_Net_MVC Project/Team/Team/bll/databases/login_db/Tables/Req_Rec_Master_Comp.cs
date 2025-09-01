using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Master_Comp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("req_id", Order = 2, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("request_type", Order = 3, TypeName = "text")]
       public string? request_type { get; set; }

       [Column("req_status", Order = 4, TypeName = "text")]
       public string? req_status { get; set; }

       [Column("manual_no", Order = 5, TypeName = "text")]
       public string? manual_no { get; set; }

       [Column("req_comp_name", Order = 6, TypeName = "text")]
       public string? req_comp_name { get; set; }

       [Column("comp_name", Order = 7, TypeName = "text")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 8, TypeName = "text")]
       public string? comp_name_short { get; set; }

       [Column("comp_id", Order = 9, TypeName = "text")]
       public string? comp_id { get; set; }

       [Column("comp_isin", Order = 10, TypeName = "text")]
       public string? comp_isin { get; set; }

       [Column("exchange_name", Order = 11, TypeName = "varchar(50)")]
       public string? exchange_name { get; set; }

       [Column("reject_yn", Order = 12, TypeName = "text")]
       public string? reject_yn { get; set; }

       [Column("reject_remark", Order = 13, TypeName = "text")]
       public string? reject_remark { get; set; }

       [Column("rec_date", Order = 14, TypeName = "datetime")]
       public DateTime? rec_date { get; set; }

       [Column("rec_compl_date", Order = 15, TypeName = "datetime")]
       public DateTime? rec_compl_date { get; set; }

       [Column("created_on", Order = 16, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 17, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("work_category", Order = 18, TypeName = "text")]
       public string? work_category { get; set; }

       [Column("sender_name", Order = 19, TypeName = "text")]
       public string? sender_name { get; set; }

       [Column("sender_email", Order = 20, TypeName = "text")]
       public string? sender_email { get; set; }

       [Column("sender_contact_no", Order = 21, TypeName = "text")]
       public string? sender_contact_no { get; set; }

       [Column("address_detail1", Order = 22, TypeName = "text")]
       public string? address_detail1 { get; set; }

       [Column("address_detail2", Order = 23, TypeName = "text")]
       public string? address_detail2 { get; set; }

       [Column("purpose_detail", Order = 24, TypeName = "text")]
       public string? purpose_detail { get; set; }

       [Column("remark", Order = 25, TypeName = "text")]
       public string? remark { get; set; }

       [Column("pod_no", Order = 26, TypeName = "text")]
       public string? pod_no { get; set; }

       [Column("pod_rec_type", Order = 27, TypeName = "text")]
       public string? pod_rec_type { get; set; }

       [Column("dp_id", Order = 28, TypeName = "text")]
       public string? dp_id { get; set; }

       [Column("cl_id_folio", Order = 29, TypeName = "text")]
       public string? cl_id_folio { get; set; }

       [Column("work_remark", Order = 30, TypeName = "text")]
       public string? work_remark { get; set; }

       [Column("receiver_name", Order = 31, TypeName = "text")]
       public string? receiver_name { get; set; }

       [Column("maker_flag", Order = 32, TypeName = "text")]
       public string? maker_flag { get; set; }

       [Column("checker_flag", Order = 33, TypeName = "text")]
       public string? checker_flag { get; set; }

       [Column("docu_req_yn", Order = 34, TypeName = "varchar(3)")]
       public string? docu_req_yn { get; set; }

       [Column("schedule_req_yn", Order = 35, TypeName = "varchar(3)")]
       public string? schedule_req_yn { get; set; }

       [Column("trfno", Order = 36, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trf_date", Order = 37, TypeName = "datetime")]
       public DateTime? trf_date { get; set; }

       [Column("verify_on", Order = 38, TypeName = "datetime")]
       public DateTime? verify_on { get; set; }

       [Column("entry_by", Order = 39, TypeName = "text")]
       public string? entry_by { get; set; }

       [Column("verify_by", Order = 40, TypeName = "text")]
       public string? verify_by { get; set; }

       [Column("item_name", Order = 41, TypeName = "text")]
       public string? item_name { get; set; }

       [Column("work_type", Order = 42, TypeName = "text")]
       public string? work_type { get; set; }

       [Column("chargable_type", Order = 43, TypeName = "text")]
       public string? chargable_type { get; set; }

       [Column("chargable_unit", Order = 44, TypeName = "double(18,3)")]
       public long? chargable_unit { get; set; }

       [Column("chargable_amt", Order = 45, TypeName = "double(18,3)")]
       public long? chargable_amt { get; set; }

       [Column("chargable_remark", Order = 46, TypeName = "text")]
       public string? chargable_remark { get; set; }

   }
}
