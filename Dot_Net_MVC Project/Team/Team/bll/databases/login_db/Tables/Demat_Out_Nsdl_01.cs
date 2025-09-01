using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Demat_Out_Nsdl_01
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

       [Column("batch_number", Order = 11, TypeName = "varchar(20)")]
       public string? batch_number { get; set; }

       [Column("record_type", Order = 12, TypeName = "varchar(20)")]
       public string? record_type { get; set; }

       [Column("branch_code", Order = 13, TypeName = "varchar(36)")]
       public string? branch_code { get; set; }

       [Column("sr_bp_id", Order = 14, TypeName = "varchar(80)")]
       public string? sr_bp_id { get; set; }

       [Column("bp_role", Order = 15, TypeName = "varchar(20)")]
       public string? bp_role { get; set; }

       [Column("batch_acceptance_status", Order = 16, TypeName = "varchar(10)")]
       public string? batch_acceptance_status { get; set; }

       [Column("total_demat_accepted_position", Order = 17, TypeName = "float")]
       public long? total_demat_accepted_position { get; set; }

       [Column("total_demat_rejected_position", Order = 18, TypeName = "float")]
       public long? total_demat_rejected_position { get; set; }

       [Column("total_remat_accepted_position", Order = 19, TypeName = "float")]
       public long? total_remat_accepted_position { get; set; }

       [Column("total_remat_rejected_position", Order = 20, TypeName = "float")]
       public long? total_remat_rejected_position { get; set; }

       [Column("total_repurchase_accepted_position", Order = 21, TypeName = "float")]
       public long? total_repurchase_accepted_position { get; set; }

       [Column("total_repurchase_rejected_position", Order = 22, TypeName = "float")]
       public long? total_repurchase_rejected_position { get; set; }

       [Column("total_number_of_detail_records_7", Order = 23, TypeName = "float")]
       public long? total_number_of_detail_records_7 { get; set; }

       [Column("current_business_date", Order = 24, TypeName = "varchar(40)")]
       public string? current_business_date { get; set; }

       [Column("user_id_upload", Order = 25, TypeName = "varchar(36)")]
       public string? user_id_upload { get; set; }

       [Column("filler_01", Order = 26, TypeName = "varchar(10)")]
       public string? filler_01 { get; set; }

   }
}
