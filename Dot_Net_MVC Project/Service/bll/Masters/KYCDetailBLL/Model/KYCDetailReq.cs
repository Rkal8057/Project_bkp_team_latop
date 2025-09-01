using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class KYCDetailReq
    {
        public decimal table_trf_no { get; set; }
        public decimal multi_master_trx_no { get; set; }
        public decimal master_req_id { get; set; }
        public decimal master_inward_id { get; set; }
        public decimal master_trf_no { get; set; }
        public string p_update_type_finance { get; set; }
        public string p_address_type_code_bank { get; set; }
        public string p_address_type_code_detail_bank { get; set; }
        public string p_account_type_code { get; set; }
        public string p_bank_ac_no { get; set; }
        public string p_account_type { get; set; }
        public string p_bank_name { get; set; }
        public string p_bank_micrno { get; set; }
        public string p_bank_ifsc_code { get; set; }
        public string p_bank_add1 { get; set; }
        public string p_bank_add2 { get; set; }
        public string p_bank_add3 { get; set; }
        public string p_bank_city { get; set; }
        public string p_bank_state { get; set; }
        public string p_bank_pincode { get; set; }
        public string p_bank_country { get; set; }
        public string t_panno1 { get; set; }
        public string t_panno2 { get; set; }
        public string t_panno3 { get; set; }
        public string p_panno1 { get; set; }
        public string p_panno2 { get; set; }
        public string p_panno3 { get; set; }
        public string p_adhaar_no { get; set; }
        public string p_voter_id { get; set; }
        public string p_dl_no { get; set; }
        public string p_passport_no { get; set; }
        public string p_emailid { get; set; }
        public string p_phone { get; set; }
        public string pan1_addhar_linked_yn { get; set; }
        public string pan2_addhar_linked_yn { get; set; }
        public string pan3_addhar_linked_yn { get; set; }
        public string rr_flag_name { get; set; }
        public string rejecte_yn { get; set; }
        public string verify_yn { get; set; }
        public string verify_by_username { get; set; }
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
