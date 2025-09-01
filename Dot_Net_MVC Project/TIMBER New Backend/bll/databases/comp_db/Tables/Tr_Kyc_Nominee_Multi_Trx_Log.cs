using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_kyc_nominee_multi_trx_log")] 
       
   public class Tr_Kyc_Nominee_Multi_Trx_Log
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

       [Column("n_update_type_nominee", Order = 7, TypeName = "varchar(50)")]
       public string? n_update_type_nominee { get; set; }

       [Column("n_name_new", Order = 8, TypeName = "varchar(50)")]
       public string? n_name_new { get; set; }

       [Column("n_pan_new", Order = 9, TypeName = "varchar(20)")]
       public string? n_pan_new { get; set; }

       [Column("n_relation_new", Order = 10, TypeName = "varchar(50)")]
       public string? n_relation_new { get; set; }

       [Column("n_f_m_w_name_new", Order = 11, TypeName = "varchar(50)")]
       public string? n_f_m_w_name_new { get; set; }

       [Column("n_m_f_new", Order = 12, TypeName = "varchar(50)")]
       public string? n_m_f_new { get; set; }

       [Column("n_nsdl_id_1_new", Order = 13, TypeName = "varchar(8)")]
       public string? n_nsdl_id_1_new { get; set; }

       [Column("n_nsdl_id_2_new", Order = 14, TypeName = "varchar(8)")]
       public string? n_nsdl_id_2_new { get; set; }

       [Column("n_cdsl_id_1_new", Order = 15, TypeName = "varchar(8)")]
       public string? n_cdsl_id_1_new { get; set; }

       [Column("n_cl_id_new", Order = 16, TypeName = "varchar(8)")]
       public string? n_cl_id_new { get; set; }

       [Column("n_dob_new", Order = 17, TypeName = "varchar(50)")]
       public string? n_dob_new { get; set; }

       [Column("n_phone_new", Order = 18, TypeName = "varchar(50)")]
       public string? n_phone_new { get; set; }

       [Column("n_add2_new", Order = 19, TypeName = "varchar(50)")]
       public string? n_add2_new { get; set; }

       [Column("n_add1_new", Order = 20, TypeName = "varchar(50)")]
       public string? n_add1_new { get; set; }

       [Column("n_city_new", Order = 21, TypeName = "varchar(50)")]
       public string? n_city_new { get; set; }

       [Column("n_pincode_new", Order = 22, TypeName = "varchar(50)")]
       public string? n_pincode_new { get; set; }

       [Column("n_state_new", Order = 23, TypeName = "varchar(50)")]
       public string? n_state_new { get; set; }

       [Column("n_country_new", Order = 24, TypeName = "varchar(50)")]
       public string? n_country_new { get; set; }

       [Column("n_email_new", Order = 25, TypeName = "varchar(50)")]
       public string? n_email_new { get; set; }

       [Column("n_occupation_det_new", Order = 26, TypeName = "varchar(50)")]
       public string? n_occupation_det_new { get; set; }

       [Column("n_nominee_opting_out_yn_new", Order = 27, TypeName = "varchar(1)")]
       public string? n_nominee_opting_out_yn_new { get; set; }

       [Column("n_nominee_is_a_minor_yn_new", Order = 28, TypeName = "varchar(1)")]
       public string? n_nominee_is_a_minor_yn_new { get; set; }

       [Column("n_date_of_att_majority_new", Order = 29, TypeName = "varchar(100)")]
       public string? n_date_of_att_majority_new { get; set; }

       [Column("n_gaurdian_name_new", Order = 30, TypeName = "varchar(50)")]
       public string? n_gaurdian_name_new { get; set; }

       [Column("n_gaurdian_address_new", Order = 31, TypeName = "varchar(50)")]
       public string? n_gaurdian_address_new { get; set; }

       [Column("t_n_name", Order = 32, TypeName = "varchar(50)")]
       public string? t_n_name { get; set; }

       [Column("t_n_pan", Order = 33, TypeName = "varchar(20)")]
       public string? t_n_pan { get; set; }

       [Column("t_n_relation", Order = 34, TypeName = "varchar(50)")]
       public string? t_n_relation { get; set; }

       [Column("t_n_f_m_w_name", Order = 35, TypeName = "varchar(50)")]
       public string? t_n_f_m_w_name { get; set; }

       [Column("t_n_m_f", Order = 36, TypeName = "varchar(50)")]
       public string? t_n_m_f { get; set; }

       [Column("t_n_nsdl_id_1", Order = 37, TypeName = "varchar(8)")]
       public string? t_n_nsdl_id_1 { get; set; }

       [Column("t_n_nsdl_id_2", Order = 38, TypeName = "varchar(8)")]
       public string? t_n_nsdl_id_2 { get; set; }

       [Column("t_n_cdsl_id_1", Order = 39, TypeName = "varchar(8)")]
       public string? t_n_cdsl_id_1 { get; set; }

       [Column("t_n_cl_id", Order = 40, TypeName = "varchar(8)")]
       public string? t_n_cl_id { get; set; }

       [Column("t_n_dob", Order = 41, TypeName = "varchar(50)")]
       public string? t_n_dob { get; set; }

       [Column("t_n_phone", Order = 42, TypeName = "varchar(50)")]
       public string? t_n_phone { get; set; }

       [Column("t_n_add2", Order = 43, TypeName = "varchar(50)")]
       public string? t_n_add2 { get; set; }

       [Column("t_n_add1", Order = 44, TypeName = "varchar(50)")]
       public string? t_n_add1 { get; set; }

       [Column("t_n_city", Order = 45, TypeName = "varchar(50)")]
       public string? t_n_city { get; set; }

       [Column("t_n_pincode", Order = 46, TypeName = "varchar(50)")]
       public string? t_n_pincode { get; set; }

       [Column("t_n_state", Order = 47, TypeName = "varchar(50)")]
       public string? t_n_state { get; set; }

       [Column("t_n_country", Order = 48, TypeName = "varchar(50)")]
       public string? t_n_country { get; set; }

       [Column("t_n_email", Order = 49, TypeName = "varchar(50)")]
       public string? t_n_email { get; set; }

       [Column("t_n_occupation_det", Order = 50, TypeName = "varchar(50)")]
       public string? t_n_occupation_det { get; set; }

       [Column("t_n_nominee_opting_out_yn", Order = 51, TypeName = "varchar(1)")]
       public string? t_n_nominee_opting_out_yn { get; set; }

       [Column("t_n_nominee_is_a_minor_yn", Order = 52, TypeName = "varchar(1)")]
       public string? t_n_nominee_is_a_minor_yn { get; set; }

       [Column("t_n_date_of_att_majority", Order = 53, TypeName = "varchar(100)")]
       public string? t_n_date_of_att_majority { get; set; }

       [Column("t_n_gaurdian_name", Order = 54, TypeName = "varchar(50)")]
       public string? t_n_gaurdian_name { get; set; }

       [Column("t_n_gaurdian_address", Order = 55, TypeName = "varchar(50)")]
       public string? t_n_gaurdian_address { get; set; }

       [Column("rr_flag_name", Order = 56, TypeName = "varchar(50)")]
       public string? rr_flag_name { get; set; }

       [Column("rejecte_yn", Order = 57, TypeName = "varchar(3)")]
       public string? rejecte_yn { get; set; }

       [Column("verify_yn", Order = 58, TypeName = "varchar(3)")]
       public string? verify_yn { get; set; }

       [Column("verify_by_username", Order = 59, TypeName = "varchar(100)")]
       public string? verify_by_username { get; set; }

       [Column("verify_status_msg", Order = 60, TypeName = "varchar(50)")]
       public string? verify_status_msg { get; set; }

       [Column("verify_remark", Order = 61, TypeName = "varchar(50)")]
       public string? verify_remark { get; set; }

       [Column("verify_updated_on", Order = 62, TypeName = "datetime")]
       public DateTime? verify_updated_on { get; set; }

       [Column("maker_id", Order = 63, TypeName = "bigint(10)")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 64, TypeName = "varchar(100)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 65, TypeName = "varchar(50)")]
       public string? maker_remark { get; set; }

       [Column("maker_status", Order = 66, TypeName = "varchar(50)")]
       public string? maker_status { get; set; }

       [Column("maker_status_created_on", Order = 67, TypeName = "datetime")]
       public DateTime? maker_status_created_on { get; set; }

       [Column("checker_id", Order = 68, TypeName = "bigint(10)")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 69, TypeName = "varchar(100)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 70, TypeName = "varchar(50)")]
       public string? checker_remark { get; set; }

       [Column("checker_status", Order = 71, TypeName = "varchar(50)")]
       public string? checker_status { get; set; }

       [Column("checker_status_created_on", Order = 72, TypeName = "datetime")]
       public DateTime? checker_status_created_on { get; set; }

       [Column("current_status", Order = 73, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

   }
}
