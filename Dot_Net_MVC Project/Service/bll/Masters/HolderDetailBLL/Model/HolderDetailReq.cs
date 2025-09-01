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
    public class HolderDetailReq
    {
        public string? holder_fullname { get; set; }
        public string? holder_gender { get; set; }
        public string? holder_dob { get; set; }
        public string? holder_occupation { get; set; }
        public string? holder_fathername { get; set; }
        public string? holder_address1 { get; set; }
        public string? holder_address2 { get; set; }
        public string? holder_city { get; set; }
        public string? holder_state { get; set; }
        public string? holder_country { get; set; }
        public string? holder_email { get; set; }
        public string? holder_phone { get; set; }
        public string? holder_pincode { get; set; }
        public string? holder_pincard { get; set; }
        public string? holder_kyc_updated { get; set; }
        public string? holder_folio_no { get; set; }











        public string? p_account_type_code { get; set; }
        public string? p_account_type { get; set; }
        public string? p_bank_ac_no { get; set; }
        public string? p_bank_name { get; set; }
        public string? p_bank_micrno { get; set; }
        public string? p_bank_add1 { get; set; }
        public string? p_bank_add2 { get; set; }
        public string? p_address_type_code_bank { get; set; }
        public string? p_bank_city { get; set; }
        public string? p_bank_state { get; set; }
        public string? p_bank_pincode { get; set; }
        public string? p_bank_country { get; set; }
        public string? p_bank_ifsc_code { get; set; }








        public string? n_update_type_nominee { get; set; }
        public string? n_name_new { get; set; }
        public string? n_relation_new { get; set; }
        public string? n_gender_new { get; set; }
        public string? n_pan_new { get; set; }
        public string? n_f_m_w_name_new { get; set; }
        public DateTime? n_dob_new { get; set; } // Assuming date of birth is DateTime
        public string? n_phone_new { get; set; }
        public string? n_add2_new { get; set; }
        public string? n_add1_new { get; set; }
        public string? n_city_new { get; set; }
        public string? n_pincode_new { get; set; }
        public string? n_state_new { get; set; }
        public string? n_country_new { get; set; }
        public string? n_email_new { get; set; }
        public string? n_address_type_code_nominee { get; set; }
        public string? n_occupation_det_new_code { get; set; }
        public DateTime? n_date_of_att_majority_new { get; set; }
        public string? n_gaurdian_name_new { get; set; }
        public string? n_gaurdian_address_new { get; set; }




        public string? power_attorney_TrfNo { get; set; }  
        public DateTime? power_attorney_Date { get; set; }
        public string power_attorney_Name { get; set; }
        public string power_attorney_Type { get; set; }
        public string power_attorney_PanNo { get; set; }
        public string power_attorney_Relation { get; set; }
        public string power_attorney_F_M_W_Name { get; set; }
        public DateTime? power_attorney_Dob { get; set; }
        public string power_attorney_M_F { get; set; }
        public string power_attorney_Add1 { get; set; }
        public string power_attorney_Add2 { get; set; }
        public string power_attorney_City { get; set; }
        public string power_attorney_Pincode { get; set; }
        public string power_attorney_State { get; set; }
        public string power_attorney_Country { get; set; }
        public string power_attorney_Email { get; set; }
        public string power_attorney_Phone { get; set; }


    }
}
