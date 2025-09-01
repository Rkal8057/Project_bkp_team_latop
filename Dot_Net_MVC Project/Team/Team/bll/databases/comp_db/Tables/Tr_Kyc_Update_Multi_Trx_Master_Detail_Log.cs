using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_kyc_update_multi_trx_master_detail_log")] 
       
   public class Tr_Kyc_Update_Multi_Trx_Master_Detail_Log
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("multi_master_trx_no", Order = 2, TypeName = "double(18,3)")]
       public long? multi_master_trx_no { get; set; }

       [Column("multi_master_trf_date", Order = 3, TypeName = "datetime")]
       public DateTime? multi_master_trf_date { get; set; }

       [Column("created_on", Order = 4, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 5, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("master_req_id", Order = 6, TypeName = "float")]
       public long? master_req_id { get; set; }

       [Column("address_req_rec_yn", Order = 7, TypeName = "varchar(3)")]
       public string? address_req_rec_yn { get; set; }

       [Column("address_trfno", Order = 8, TypeName = "float")]
       public long? address_trfno { get; set; }

       [Column("finance_req_rec_yn", Order = 9, TypeName = "varchar(3)")]
       public string? finance_req_rec_yn { get; set; }

       [Column("finance_trfno", Order = 10, TypeName = "float")]
       public long? finance_trfno { get; set; }

       [Column("nomniee_req_rec_yn", Order = 11, TypeName = "varchar(3)")]
       public string? nomniee_req_rec_yn { get; set; }

       [Column("nominee_trfno", Order = 12, TypeName = "float")]
       public long? nominee_trfno { get; set; }

       [Column("selected_table", Order = 13, TypeName = "varchar(100)")]
       public string? selected_table { get; set; }

       [Column("trfno", Order = 14, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trfdate", Order = 15, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("foliono", Order = 16, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("form_name", Order = 17, TypeName = "varchar(100)")]
       public string? form_name { get; set; }

       [Column("unique_trn_id", Order = 18, TypeName = "varchar(100)")]
       public string? unique_trn_id { get; set; }

       [Column("user_id", Order = 19, TypeName = "float")]
       public long? user_id { get; set; }

       [Column("user_name", Order = 20, TypeName = "varchar(100)")]
       public string? user_name { get; set; }

       [Column("current_status", Order = 21, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("maker_name", Order = 22, TypeName = "varchar(50)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 23, TypeName = "varchar(50)")]
       public string? maker_remark { get; set; }

       [Column("checker_name", Order = 24, TypeName = "varchar(50)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 25, TypeName = "varchar(50)")]
       public string? checker_remark { get; set; }

   }
}
