using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class NomineeDetailReq
    {
        public decimal table_trf_no { get; set; }
        public decimal multi_master_trx_no { get; set; }
        public decimal master_req_id { get; set; }
        public decimal master_inward_id { get; set; }
        public decimal master_trf_no { get; set; }

        public string n_update_type_nominee { get; set; }
        public string n_name_new { get; set; }
        public string n_pan_new { get; set; }
        public string n_relation_new { get; set; }
        public string n_f_m_w_name_new { get; set; }
        public string n_m_f_new { get; set; }
        public string n_nsdl_id_1_new { get; set; }
        public string n_nsdl_id_2_new { get; set; }
        public string n_cdsl_id_1_new { get; set; }
        public string n_cl_id_new { get; set; }
        public DateTime n_dob_new { get; set; }
        public string n_phone_new { get; set; }
        public string n_add2_new { get; set; }
        public string n_add1_new { get; set; }
        public string n_city_new { get; set; }
        public string n_pincode_new { get; set; }
        public string n_state_new { get; set; }
        public string n_country_new { get; set; }
        public string n_email_new { get; set; }
        public string n_address_type_code_nominee { get; set; }
        public string n_address_type_code_detail_nominee { get; set; }
        public string n_occupation_det_new_code { get; set; }
        public string n_occupation_det_new { get; set; }
        public string n_nominee_opting_out_yn_new { get; set; }
        public string n_nominee_is_a_minor_yn_new { get; set; }
        public DateTime n_date_of_att_majority_new { get; set; }
        public string n_gaurdian_name_new { get; set; }
        public string n_gaurdian_address_new { get; set; }
        public string rr_flag_name { get; set; }
        public string rejecte_yn { get; set; }
        public string verify_yn { get; set; }
        public string verify_by_user_name { get; set; }
        public string verify_status_msg { get; set; }
        public string verify_remark { get; set; }
        public DateTime? verify_updated_on { get; set; }
        public int? maker_id { get; set; }
        public string maker_name { get; set; }
        public string maker_remark { get; set; }
        public string maker_status { get; set; }
        public DateTime? maker_status_created_on { get; set; }
        public int? checker_id { get; set; }
        public string checker_name { get; set; }
        public string checker_remark { get; set; }
        public string checker_status { get; set; }
        public DateTime? checker_status_created_on { get; set; }
        public string current_status { get; set; }
    }
}
