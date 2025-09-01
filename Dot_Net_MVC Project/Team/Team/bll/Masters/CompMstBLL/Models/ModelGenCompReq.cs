using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;

namespace RTA.Masters.Models
{
    public class ModelGenCompReq
    {
        //public long c_comp_sno { get; set; }
        public string c_comp_isin { get; set; }
        public string c_comp_name { get; set; }
        //public string c_comp_short_name { get; set; }
        public long c_paid_up_capital { get; set; }
        public string c_add1 { get; set; }
        public string c_add2 { get; set; }
        public string c_add3 { get; set; }
        public string c_add4 { get; set; }
        public string c_city { get; set; }
        //public string c_database_name { get; set; }
        public string c_state { get; set; }
        //FETCHED AUTO FROM STATE
        public string c_state_code { get; set; }
        public string c_email { get; set; }
        public string c_website { get; set; }
        public string c_phones { get; set; }
        public string c_contact_person { get; set; }
        public string c_gstin { get; set; }
        //AUTO
        public string c_gst_type { get; set; }
        public string c_pan { get; set; }
        public string c_bank_ac_no { get; set; }
        public string c_bank_name { get; set; }
        public string c_badd1 { get; set; }
        public string c_badd2 { get; set; }
        public string c_badd3 { get; set; }
        public string c_bcity { get; set; }
        public string c_bstate { get; set; }
        //AUTO
        public string c_bstate_code { get; set; }
        public string c_bank_ifsc { get; set; }
        public string c_bank_micr { get; set; }
        //public DateTime c_create_date { get; set; }
        //public string c_temp_comp_id { get; set; }
        public long c_share_face_value { get; set; }
        public string c_folio_no_auto_yn { get; set; }
        public string c_company_type { get; set; }
        public string c_cin_bcin_no { get; set; }
        public string c_company_code { get; set; }
        public string c_company_sub_code { get; set; }
        public string c_more_isin_yn { get; set; }
        //DEPEND ON ABOVE YES TO SHOW OR NOT
        public string c_master_comp_isin { get; set; }
        public long c_master_comp_code { get; set; }
        public string c_master_comp_name { get; set; }
        public string c_nsdl_conn_yn { get; set; }
        public string c_cdsl_conn_yn { get; set; }
        public string c_phy_shares_yn { get; set; }
        public string c_tan { get; set; }
        public string c_isin_detail { get; set; }
        public long c_pay_term_days { get; set; }
        public string c_pay_term_detail { get; set; }
        public string c_other_detail { get; set; }
        public DateTime c_d_o_activate { get; set; }
        public DateTime c_d_o_apply { get; set; }
        //IF BLANK UPDATED BY SYSTEM
        public DateTime c_d_o_creation { get; set; }
        //public string c_created_by { get; set; }
        public DateTime c_d_o_updation { get; set; }
        //public string c_updated_by { get; set; }
        public string c_contact_person2 { get; set; }
        public long c_contact_ph { get; set; }
        public string c_contact_ph2 { get; set; }
        public string c_contact_p_email { get; set; }
        public string c_contact_p_email2 { get; set; }
        public string c_add1_2 { get; set; }
        public string c_add2_2 { get; set; }
        public string c_add3_2 { get; set; }
        public string c_city2 { get; set; }
        public string c_pincode_2 { get; set; }
        public string c_state2 { get; set; }
        public string c_state_code2 { get; set; }
        public string c_list_to_email_yn { get; set; }
        public string c_rep_top10_email_yn { get; set; }
        public string c_other_rpt_email_yn { get; set; }
        public string c_source_email_yn { get; set; }
        //public long c_comp_auto_id { get; set; }
        //DRPDOWN SYSTEM GENERATED
        public string c_maintain_type { get; set; }
        public string c_data_tyep_description { get; set; }
        public string c_isin_type { get; set; }
        public string c_phy_demat_both { get; set; }
        public string c_pincode { get; set; }
        public string c_group_name { get; set; }
        public string c_issuer_code { get; set; }
        public string c_phy_conn_yn { get; set; }
        public string c_rep_weekly_email_yn { get; set; }
        public string c_company_old_code { get; set; }
        //CALCULATE PARTIAL EQ + FULLY EQ (105+106 LINES)
        public long c_tot_equity { get; set; }
        public string cin_bcin_no { get; set; }
        public string folio_no_auto_yn { get; set; }
        //public string temp_comp_id { get; set; }
        public long c_tot_equity_fully { get; set; }
        public long c_tot_equity_partly { get; set; }
        public long c_share_face_value_partly { get; set; }
        public string c_sign_image_path_auto_yn { get; set; }
        public string c_scrip_code { get; set; }
        public string c_name_of_scrip { get; set; }
        public string c_class_of_security { get; set; }
        public string folio_convert_to_numrice_yn { get; set; }
        public string cert_convert_to_numrice_yn { get; set; }
        //public string test_coloum { get; set; }
        public string listing_on_bse_nse { get; set; }
        public string company_agreement_type { get; set; }
        public DateTime start_date_agree { get; set; }
        public DateTime end_date_agree { get; set; }
        //SYSTEM RECORD
        public string company_status { get; set; }
        public string folio_lenght { get; set; }
        public string listing_on_bse_yn { get; set; }
        public string listing_on_nse_yn { get; set; }
        public string listing_on_mse_yn { get; set; }


    }
}