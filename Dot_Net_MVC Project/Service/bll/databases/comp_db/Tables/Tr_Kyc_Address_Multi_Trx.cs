using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_kyc_address_multi_trx")] 
       
   public class Tr_Kyc_Address_Multi_Trx
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "double(18,3)")]
       public long? table_id { get; set; }

       [Column("table_trf_no", Order = 3, TypeName = "double(18,3)")]
       public long? table_trf_no { get; set; }

       [Column("multi_master_trx_no", Order = 4, TypeName = "double(18,3)")]
       public long? multi_master_trx_no { get; set; }

       [Column("master_trf_no", Order = 5, TypeName = "double(18,3)")]
       public long? master_trf_no { get; set; }

       [Column("master_req_id", Order = 6, TypeName = "double(18,3)")]
       public long? master_req_id { get; set; }

       [Column("t_ad1", Order = 7, TypeName = "varchar(50)")]
       public string? t_ad1 { get; set; }

       [Column("t_ad2", Order = 8, TypeName = "varchar(50)")]
       public string? t_ad2 { get; set; }

       [Column("t_city", Order = 9, TypeName = "varchar(50)")]
       public string? t_city { get; set; }

       [Column("t_state", Order = 10, TypeName = "varchar(50)")]
       public string? t_state { get; set; }

       [Column("t_pincode", Order = 11, TypeName = "varchar(50)")]
       public string? t_pincode { get; set; }

       [Column("t_country_name", Order = 12, TypeName = "varchar(50)")]
       public string? t_country_name { get; set; }

       [Column("t_phone", Order = 13, TypeName = "varchar(50)")]
       public string? t_phone { get; set; }

       [Column("t_emailid", Order = 14, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("p_ad1", Order = 15, TypeName = "varchar(50)")]
       public string? p_ad1 { get; set; }

       [Column("p_ad2", Order = 16, TypeName = "varchar(50)")]
       public string? p_ad2 { get; set; }

       [Column("p_city", Order = 17, TypeName = "varchar(50)")]
       public string? p_city { get; set; }

       [Column("p_state", Order = 18, TypeName = "varchar(50)")]
       public string? p_state { get; set; }

       [Column("p_pincode", Order = 19, TypeName = "varchar(50)")]
       public string? p_pincode { get; set; }

       [Column("p_country_name", Order = 20, TypeName = "varchar(50)")]
       public string? p_country_name { get; set; }

       [Column("p_phone", Order = 21, TypeName = "varchar(50)")]
       public string? p_phone { get; set; }

       [Column("p_emailid", Order = 22, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("rr_flag_name", Order = 23, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("rejecte_yn", Order = 24, TypeName = "varchar(3)")]
       public string? rejecte_yn { get; set; }

       [Column("verify_yn", Order = 25, TypeName = "varchar(3)")]
       public string? verify_yn { get; set; }

       [Column("verify_by_username", Order = 26, TypeName = "varchar(100)")]
       public string? verify_by_username { get; set; }

       [Column("verify_status_msg", Order = 27, TypeName = "varchar(50)")]
       public string? verify_status_msg { get; set; }

       [Column("verify_remark", Order = 28, TypeName = "varchar(50)")]
       public string? verify_remark { get; set; }

       [Column("verify_updated_on", Order = 29, TypeName = "datetime")]
       public DateTime? verify_updated_on { get; set; }

       [Column("maker_id", Order = 30, TypeName = "bigint(10)")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 31, TypeName = "varchar(100)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 32, TypeName = "varchar(50)")]
       public string? maker_remark { get; set; }

       [Column("maker_status", Order = 33, TypeName = "varchar(50)")]
       public string? maker_status { get; set; }

       [Column("maker_status_created_on", Order = 34, TypeName = "datetime")]
       public DateTime? maker_status_created_on { get; set; }

       [Column("checker_id", Order = 35, TypeName = "bigint(10)")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 36, TypeName = "varchar(100)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 37, TypeName = "varchar(50)")]
       public string? checker_remark { get; set; }

       [Column("checker_status", Order = 38, TypeName = "varchar(50)")]
       public string? checker_status { get; set; }

       [Column("checker_status_created_on", Order = 39, TypeName = "datetime")]
       public DateTime? checker_status_created_on { get; set; }

       [Column("current_status", Order = 40, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

   }
}
