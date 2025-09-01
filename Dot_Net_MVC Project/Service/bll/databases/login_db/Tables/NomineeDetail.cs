using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class NomineeDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("table_trf_no", Order = 1, TypeName = "decimal(18, 2)")]
        public decimal? table_trf_no { get; set; }

        [Column("multi_master_trx_no", Order = 2, TypeName = "decimal(18, 2)")]
        public decimal? multi_master_trx_no { get; set; }

        [Column("master_req_id", Order = 3, TypeName = "decimal(18, 2)")]
        public decimal? master_req_id { get; set; }

        [Column("master_inward_id", Order = 4, TypeName = "decimal(18, 2)")]
        public decimal? master_inward_id { get; set; }

        [Column("master_trf_no", Order = 5, TypeName = "decimal(18, 2)")]
        public decimal? master_trf_no { get; set; }

        [Column("n_update_type_nominee", Order = 6, TypeName = "text")]
        public string? n_update_type_nominee { get; set; }

        [Column("n_name_new", Order = 7, TypeName = "text")]
        public string? n_name_new { get; set; }

        [Column("n_pan_new", Order = 8, TypeName = "text")]
        public string? n_pan_new { get; set; }

        [Column("n_relation_new", Order = 9, TypeName = "text")]
        public string? n_relation_new { get; set; }

        [Column("n_f_m_w_name_new", Order = 10, TypeName = "text")]
        public string? n_f_m_w_name_new { get; set; }

        [Column("n_m_f_new", Order = 11, TypeName = "text")]
        public string? n_m_f_new { get; set; }

        [Column("n_nsdl_id_1_new", Order = 12, TypeName = "text")]
        public string? n_nsdl_id_1_new { get; set; }

        [Column("n_nsdl_id_2_new", Order = 13, TypeName = "text")]
        public string? n_nsdl_id_2_new { get; set; }

        [Column("n_cdsl_id_1_new", Order = 14, TypeName = "text")]
        public string? n_cdsl_id_1_new { get; set; }

        [Column("n_cl_id_new", Order = 15, TypeName = "text")]
        public string? n_cl_id_new { get; set; }

        [Column("n_dob_new", Order = 16, TypeName = "date")]
        public DateTime? n_dob_new { get; set; }

        [Column("n_phone_new", Order = 17, TypeName = "text")]
        public string? n_phone_new { get; set; }

        [Column("n_add2_new", Order = 18, TypeName = "text")]
        public string? n_add2_new { get; set; }

        [Column("n_add1_new", Order = 19, TypeName = "text")]
        public string? n_add1_new { get; set; }

        [Column("n_city_new", Order = 20, TypeName = "text")]
        public string? n_city_new { get; set; }

        [Column("n_pincode_new", Order = 21, TypeName = "text")]
        public string? n_pincode_new { get; set; }

        [Column("n_state_new", Order = 22, TypeName = "text")]
        public string? n_state_new { get; set; }

        [Column("n_country_new", Order = 23, TypeName = "text")]
        public string? n_country_new { get; set; }

        [Column("n_email_new", Order = 24, TypeName = "text")]
        public string? n_email_new { get; set; }

        [Column("n_address_type_code_nominee", Order = 25, TypeName = "text")]
        public string? n_address_type_code_nominee { get; set; }

        [Column("n_address_type_code_detail_nominee", Order = 26, TypeName = "text")]
        public string? n_address_type_code_detail_nominee { get; set; }

        [Column("n_occupation_det_new_code", Order = 27, TypeName = "text")]
        public string? n_occupation_det_new_code { get; set; }

        [Column("n_occupation_det_new", Order = 28, TypeName = "text")]
        public string? n_occupation_det_new { get; set; }

        [Column("n_nominee_opting_out_yn_new", Order = 29, TypeName = "text")]
        public string? n_nominee_opting_out_yn_new { get; set; }

        [Column("n_nominee_is_a_minor_yn_new", Order = 30, TypeName = "text")]
        public string? n_nominee_is_a_minor_yn_new { get; set; }

        [Column("n_date_of_att_majority_new", Order = 31, TypeName = "date")]
        public DateTime? n_date_of_att_majority_new { get; set; }

        [Column("n_gaurdian_name_new", Order = 32, TypeName = "text")]
        public string? n_gaurdian_name_new { get; set; }

        [Column("n_gaurdian_address_new", Order = 33, TypeName = "text")]
        public string? n_gaurdian_address_new { get; set; }

        [Column("rr_flag_name", Order = 34, TypeName = "text")]
        public string? rr_flag_name { get; set; }

        [Column("rejecte_yn", Order = 35, TypeName = "text")]
        public string? rejecte_yn { get; set; }

        [Column("verify_yn", Order = 36, TypeName = "text")]
        public string? verify_yn { get; set; }

        [Column("verify_by_user_name", Order = 37, TypeName = "text")]
        public string? verify_by_user_name { get; set; }

        [Column("verify_status_msg", Order = 38, TypeName = "text")]
        public string? verify_status_msg { get; set; }

        [Column("verify_remark", Order = 39, TypeName = "text")]
        public string? verify_remark { get; set; }

        [Column("verify_updated_on", Order = 40, TypeName = "datetime")]
        public DateTime? verify_updated_on { get; set; }

        [Column("maker_id", Order = 41, TypeName = "text")]
        public int? maker_id { get; set; }

        [Column("maker_name", Order = 42, TypeName = "text")]
        public string? maker_name { get; set; }

        [Column("maker_remark", Order = 43, TypeName = "text")]
        public string? maker_remark { get; set; }

        [Column("maker_status", Order = 44, TypeName = "text")]
        public string? maker_status { get; set; }

        [Column("maker_status_created_on", Order = 45, TypeName = "datetime")]
        public DateTime? maker_status_created_on { get; set; }

        [Column("checker_id", Order = 46, TypeName = "text")]
        public int? checker_id { get; set; }

        [Column("checker_name", Order = 47, TypeName = "text")]
        public string? checker_name { get; set; }

        [Column("checker_remark", Order = 48, TypeName = "text")]
        public string? checker_remark { get; set; }

        [Column("checker_status", Order = 49, TypeName = "text")]
        public string? checker_status { get; set; }

        [Column("checker_status_created_on", Order = 50, TypeName = "datetime")]
        public DateTime? checker_status_created_on { get; set; }

        [Column("current_status", Order = 51, TypeName = "text")]
        public string? current_status { get; set; }

        [Column("n_gender_new", Order = 52, TypeName = "text")]
        public string? n_gender_new { get; set; }

        [ForeignKey("HolderDetail"), Column("holder_detail_id", Order = 53, TypeName = "bigint")]
        public long? holder_detail_id { get; set; }

        [JsonIgnore]
        public virtual HolderDetail? HolderDetail { get; set; }
    }

}
