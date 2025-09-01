using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Drn_Status_Nsdl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 5, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("req_rec_online_isin_no", Order = 6, TypeName = "text")]
       public string? req_rec_online_isin_no { get; set; }

       [Column("req_rec_record_date", Order = 7, TypeName = "datetime")]
       public DateTime? req_rec_record_date { get; set; }

       [Column("req_rec_record_date_text", Order = 8, TypeName = "varchar(8)")]
       public string? req_rec_record_date_text { get; set; }

       [Column("enter_date", Order = 9, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("drn_no", Order = 10, TypeName = "varchar(100)")]
       public string? drn_no { get; set; }

       [Column("drn_vou_type", Order = 11, TypeName = "text")]
       public string? drn_vou_type { get; set; }

       [Column("drn_status", Order = 12, TypeName = "text")]
       public string? drn_status { get; set; }

       [Column("drn_running_status", Order = 13, TypeName = "varchar(100)")]
       public string? drn_running_status { get; set; }

       [Column("drn_remark", Order = 14, TypeName = "text")]
       public string? drn_remark { get; set; }

       [Column("trf_no", Order = 15, TypeName = "double(18,3)")]
       public long? trf_no { get; set; }

       [Column("req_id", Order = 16, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("req_id_reject_yn", Order = 17, TypeName = "varchar(3)")]
       public string? req_id_reject_yn { get; set; }

       [Column("in_w_id", Order = 18, TypeName = "double(18,3)")]
       public long? in_w_id { get; set; }

       [Column("out_w_id", Order = 19, TypeName = "double(18,3)")]
       public long? out_w_id { get; set; }

       [Column("req_rec_complete_date", Order = 20, TypeName = "datetime")]
       public DateTime? req_rec_complete_date { get; set; }

       [Column("user_name", Order = 21, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 22, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
