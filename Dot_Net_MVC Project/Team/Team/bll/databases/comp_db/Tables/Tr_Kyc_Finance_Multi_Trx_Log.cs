using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_kyc_finance_multi_trx_log")] 
       
   public class Tr_Kyc_Finance_Multi_Trx_Log
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

       [Column("p_update_type_finance", Order = 7, TypeName = "varchar(50)")]
       public string? p_update_type_finance { get; set; }

       [Column("p_bank_ac_no", Order = 8, TypeName = "varchar(55)")]
       public string? p_bank_ac_no { get; set; }

       [Column("p_account_type", Order = 9, TypeName = "varchar(55)")]
       public string? p_account_type { get; set; }

       [Column("p_bank_name", Order = 10, TypeName = "varchar(50)")]
       public string? p_bank_name { get; set; }

       [Column("p_bank_micrno", Order = 11, TypeName = "varchar(55)")]
       public string? p_bank_micrno { get; set; }

       [Column("p_bank_ifsc_code", Order = 12, TypeName = "varchar(55)")]
       public string? p_bank_ifsc_code { get; set; }

       [Column("p_bank_add1", Order = 13, TypeName = "varchar(50)")]
       public string? p_bank_add1 { get; set; }

       [Column("p_bank_add2", Order = 14, TypeName = "varchar(50)")]
       public string? p_bank_add2 { get; set; }

       [Column("p_bank_add3", Order = 15, TypeName = "varchar(50)")]
       public string? p_bank_add3 { get; set; }

       [Column("p_bank_city", Order = 16, TypeName = "varchar(100)")]
       public string? p_bank_city { get; set; }

       [Column("p_bank_state", Order = 17, TypeName = "varchar(100)")]
       public string? p_bank_state { get; set; }

       [Column("p_bank_pincode", Order = 18, TypeName = "varchar(25)")]
       public string? p_bank_pincode { get; set; }

       [Column("p_bank_country", Order = 19, TypeName = "varchar(100)")]
       public string? p_bank_country { get; set; }

       [Column("t_panno1", Order = 20, TypeName = "varchar(20)")]
       public string? t_panno1 { get; set; }

       [Column("t_panno2", Order = 21, TypeName = "varchar(20)")]
       public string? t_panno2 { get; set; }

       [Column("t_panno3", Order = 22, TypeName = "varchar(20)")]
       public string? t_panno3 { get; set; }

       [Column("p_panno1", Order = 23, TypeName = "varchar(20)")]
       public string? p_panno1 { get; set; }

       [Column("p_panno2", Order = 24, TypeName = "varchar(20)")]
       public string? p_panno2 { get; set; }

       [Column("p_panno3", Order = 25, TypeName = "varchar(20)")]
       public string? p_panno3 { get; set; }

       [Column("p_adhaar_no", Order = 26, TypeName = "varchar(30)")]
       public string? p_adhaar_no { get; set; }

       [Column("p_voter_id", Order = 27, TypeName = "varchar(30)")]
       public string? p_voter_id { get; set; }

       [Column("p_dl_no", Order = 28, TypeName = "varchar(30)")]
       public string? p_dl_no { get; set; }

       [Column("p_passport_no", Order = 29, TypeName = "varchar(30)")]
       public string? p_passport_no { get; set; }

       [Column("t_adhaar_no", Order = 30, TypeName = "varchar(30)")]
       public string? t_adhaar_no { get; set; }

       [Column("t_voter_id", Order = 31, TypeName = "varchar(30)")]
       public string? t_voter_id { get; set; }

       [Column("t_dl_no", Order = 32, TypeName = "varchar(30)")]
       public string? t_dl_no { get; set; }

       [Column("t_passport_no", Order = 33, TypeName = "varchar(30)")]
       public string? t_passport_no { get; set; }

       [Column("t_bank_ac_no", Order = 34, TypeName = "varchar(55)")]
       public string? t_bank_ac_no { get; set; }

       [Column("t_account_type", Order = 35, TypeName = "varchar(55)")]
       public string? t_account_type { get; set; }

       [Column("t_bank_name", Order = 36, TypeName = "varchar(50)")]
       public string? t_bank_name { get; set; }

       [Column("t_bank_micrno", Order = 37, TypeName = "varchar(55)")]
       public string? t_bank_micrno { get; set; }

       [Column("t_bank_ifsc_code", Order = 38, TypeName = "varchar(55)")]
       public string? t_bank_ifsc_code { get; set; }

       [Column("t_bank_add1", Order = 39, TypeName = "varchar(50)")]
       public string? t_bank_add1 { get; set; }

       [Column("t_bank_add2", Order = 40, TypeName = "varchar(50)")]
       public string? t_bank_add2 { get; set; }

       [Column("t_bank_add3", Order = 41, TypeName = "varchar(50)")]
       public string? t_bank_add3 { get; set; }

       [Column("t_bank_city", Order = 42, TypeName = "varchar(100)")]
       public string? t_bank_city { get; set; }

       [Column("t_bank_state", Order = 43, TypeName = "varchar(100)")]
       public string? t_bank_state { get; set; }

       [Column("t_bank_pincode", Order = 44, TypeName = "varchar(25)")]
       public string? t_bank_pincode { get; set; }

       [Column("t_bank_country", Order = 45, TypeName = "varchar(100)")]
       public string? t_bank_country { get; set; }

       [Column("rr_flag_name", Order = 46, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("rejecte_yn", Order = 47, TypeName = "varchar(3)")]
       public string? rejecte_yn { get; set; }

       [Column("verify_yn", Order = 48, TypeName = "varchar(3)")]
       public string? verify_yn { get; set; }

       [Column("verify_by_username", Order = 49, TypeName = "varchar(100)")]
       public string? verify_by_username { get; set; }

       [Column("verify_status_msg", Order = 50, TypeName = "varchar(50)")]
       public string? verify_status_msg { get; set; }

       [Column("verify_remark", Order = 51, TypeName = "varchar(50)")]
       public string? verify_remark { get; set; }

       [Column("verify_updated_on", Order = 52, TypeName = "datetime")]
       public DateTime? verify_updated_on { get; set; }

       [Column("maker_id", Order = 53, TypeName = "bigint(10)")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 54, TypeName = "varchar(100)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 55, TypeName = "varchar(50)")]
       public string? maker_remark { get; set; }

       [Column("maker_status", Order = 56, TypeName = "varchar(50)")]
       public string? maker_status { get; set; }

       [Column("maker_status_created_on", Order = 57, TypeName = "datetime")]
       public DateTime? maker_status_created_on { get; set; }

       [Column("checker_id", Order = 58, TypeName = "bigint(10)")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 59, TypeName = "varchar(100)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 60, TypeName = "varchar(50)")]
       public string? checker_remark { get; set; }

       [Column("checker_status", Order = 61, TypeName = "varchar(50)")]
       public string? checker_status { get; set; }

       [Column("checker_status_created_on", Order = 62, TypeName = "datetime")]
       public DateTime? checker_status_created_on { get; set; }

       [Column("current_status", Order = 63, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("p_emailid", Order = 64, TypeName = "varchar(50)")]
       public string? p_emailid { get; set; }

       [Column("p_phone", Order = 65, TypeName = "varchar(50)")]
       public string? p_phone { get; set; }

       [Column("t_emailid", Order = 66, TypeName = "varchar(50)")]
       public string? t_emailid { get; set; }

       [Column("t_phone", Order = 67, TypeName = "varchar(50)")]
       public string? t_phone { get; set; }

       [Column("pan1_addhar_linked_yn", Order = 68, TypeName = "varchar(3)")]
       public string? pan1_addhar_linked_yn { get; set; }

       [Column("pan2_addhar_linked_yn", Order = 69, TypeName = "varchar(3)")]
       public string? pan2_addhar_linked_yn { get; set; }

       [Column("pan3_addhar_linked_yn", Order = 70, TypeName = "varchar(3)")]
       public string? pan3_addhar_linked_yn { get; set; }

   }
}
