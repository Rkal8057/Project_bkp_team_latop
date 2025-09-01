using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class PartyMasterReq
    {
        public string? name { get; set; }
        public string? email { get; set; }
        public long? mobile_number { get; set; }
        public string? address { get; set; }
        public DateTime? agreement_start_date { get; set; }
        public DateTime? agreement_end_date { get; set; }
        public string? type_of_service { get; set; }
        public long? pincode { get; set; }
        public string? hire_status { get; set; }
        public string? bill_type { get; set; }
        public string? group { get; set; }
        public decimal? security_amount { get; set; }
        public string? tax_type { get; set; }
        public decimal? percentage { get; set; }
        public string? dr { get; set; }
        public string? gstin { get; set; }
        public string? ref_by { get; set; }
        public string? ref_commission { get; set; }
        public string? party_group_category_name { get; set; }
        public string? party_company_name { get; set; }
        public string? party_agr_code { get; set; }



        // Finaance table key name

        public string? GSTIN_No { get; set; }
        public string? Pay_Term_Days { get; set; }
        public string? Addhar_No { get; set; }
        public string? PAN_NO { get; set; }
        public DateTime? Ac_Opening_Date { get; set; }
        public long? Op_Bal { get; set; }
        public string? Dr_Cr { get; set; }

        public long? party_group_category_id { get; set; }

        public string? agreement_yn { get; set; }




        public string? DL_NO { get; set; }
        public string? martital_status { get; set; }
        public string? gender { get; set; }
        public DateTime? dob { get; set; }
        public DateTime? anniversary { get; set; }
        public string? loyalty { get; set; }
        public string? important { get; set; }


        public string? swh_Name { get; set; }
        public string? relation_type { get; set; }



        public List<partyAddressTranskey>? partyAddressTranskey { get; set; }
        public List<partyConactTranskey>? partyConactTranskey { get; set; }

        public List<partyDeleteAddressTranskey>? partyDeleteAddressTranskey { get; set; }
        public List<partyDeleteContactTranskey>? partyDeleteContactTranskey { get; set; }
        public List<AgreementMasterKey>? AgreementMasterKey { get; set; }

        public List<PM_Remark_Upload_Detail_Key>? PM_Remark_Upload_Detail_Key { get; set; }

        public List<PM_Remove_Remark_Upload_Detail_Key>? PM_Remove_Remark_Upload_Detail_Key { get; set; }


    }

    public class partyAddressTranskey
    {
        public long? id { get; set; }
        public string? party_address_1 { get; set; }
        public string? party_address_2 { get; set; }
        public long? party_pincode { get; set; }
        public string? party_state { get; set; }
        public string? party_country { get; set; }
        public string? party_address_description { get; set; }
        public string? party_gst_code { get; set; }
        public string? party_gst_type { get; set; }
        public string? party_gst_address_no { get; set; }
        public string? party_address_location { get; set; }


    }

    public class partyConactTranskey
    {
        public long? id { get; set; }
        public string? party_contact_name { get; set; }
        public string? party_contact_mobile { get; set; }
        public string? party_contact_whatsapp_mobile { get; set; }
        public string? party_contact_email { get; set; }
        public string? party_contact_description { get; set; }


        public string? party_contact_department { get; set; }
        public string? party_contact_designation { get; set; }
        public string? party_contact_website { get; set; }
        public string? party_contact_twitter_id { get; set; }
        public string? party_contact_fb_id { get; set; }
        public string? party_contact_instagram_id { get; set; }
        public string? party_landline_no { get; set; }
        public string? party_contact_youtube_id { get; set; }

    }


    public class partyDeleteAddressTranskey
    {
        public long? id { get; set; }
        public string? party_address_1 { get; set; }
        public string? party_address_2 { get; set; }
        public long? party_pincode { get; set; }
        public string? party_state { get; set; }
        public string? party_country { get; set; }
        public string? party_address_description { get; set; }

    }

    public class partyDeleteContactTranskey
    {
        public long? id { get; set; }
        public string? party_contact_name { get; set; }
        public long? party_contact_mobile { get; set; }
        public long? party_contact_whatsapp_mobile { get; set; }
        public string? party_contact_email { get; set; }
        public string? party_contact_description { get; set; }

    }

    public class AgreementMasterKey
    {
        public string? short_name { get; set; }
        public string? name { get; set; }
        public long? agr_qty { get; set; }
        public long? rate { get; set; }
        public long? pc_rmt_pp { get; set; }
        public long? missing { get; set; }
        public long? damage { get; set; }
        public decimal? opening { get; set; }
    }


    public class PM_Remark_Upload_Detail_Key
    {
        public long id { get; set; }
        public string? upload_document_path { get; set; }
        public string? remarks { get; set; }
        public string? attended_by { get; set; }

    }
    public class PM_Remove_Remark_Upload_Detail_Key
    {
        public long id { get; set; }
        public string? upload_document_path { get; set; }
        public string? remarks { get; set; }
        public string? attended_by { get; set; }
    }
}
