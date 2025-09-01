using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RTA.Masters.Models
{
    public class CaseMasterReq
    {
        public string? Case_Financed_Item { get; set; }
        public string? Case_Finance_Amt { get; set; }
        public string? Case_Duration_Value { get; set; }
        public string? Case_Duration_Type { get; set; }
        public string? Case_Instalments { get; set; }
        public string? Case_Montly_Amt { get; set; }
        public string? Case_Total_Amt_Due { get; set; }
        public string? Case_Total_Cost { get; set; }
        public string? Case_ADVANCE_REQ { get; set; }
        public string? Case_TOTAL_ADV_REQ { get; set; }
        public DateTime? Case_Due_Date { get; set; }
        public string? Case_Payment_By { get; set; } 
        public string? Case_Chq_NO { get; set; }
        public string? Case_Case_Remark { get; set; }
        public string? Case_Interest_type { get; set; }
        public string? Case_F_O_CHARGE { get; set; }
        public string? Case_Total_hp { get; set; }
        public string? Case_X { get; set; }
        public string? Case_Rate_of_Interest { get; set; }
        public string? Case_hp { get; set; }
        public string? Case_Extra_Inst { get; set; }
        public string? Case_Instalments_By { get; set; }
        public string? Case_Finance_Amt_2 { get; set; }
        public string? Case_Pending_Amt { get; set; }
        public DateTime? Case_end_Date { get; set; }
        public string? Case_Manual_Lg { get; set; }
        public string? Case_Dealer_Name { get; set; }
        public DateTime? Case_Curr_Date { get; set; }
        public string? Case_Case_No { get; set; }
        public string? Case_Case_stage { get; set; }
        public string? Case_Ac_Close { get; set; }
        public DateTime? Case_Ac_Close_Date { get; set; }
        public string? Case_Block_YN { get; set; }
        public string? Case_Finance_Company { get; set; }
        public string? Case_Financed_Type { get; set; }
        public string? Case_Relation_Type { get; set; }


        public string? Case_RoundOff_yn { get; set; }
        public string? Case_F_O_Select { get; set; }



        // hire detail key name


        public string? Hire_Name { get; set; }
        public string? Hire_SWH_Name { get; set; }
        public string? Hire_Resi_Address { get; set; }
        public string? Hire_Ph_No { get; set; }
        public string? Hire_Company_Name { get; set; }
        public string? Hire_Off_Ph_Nos { get; set; }
        public string? Hire_Off_Address { get; set; }
        public string? Hire_Ph_No2 { get; set; }
        public string? Hire_Post { get; set; }
        public string? Hire_Profession { get; set; }
        public string? Hire_Area { get; set; }
        public string? Hire_Location { get; set; }
        public string? Hire_Email { get; set; }
        public string? Hire_Whatsapp_Phone { get; set; }


        // guarantor1 detail key name

        public string? guarantor1_Name { get; set; }
        public string? guarantor1_SWH_Name { get; set; }
        public string? guarantor1_Resi_Address { get; set; }
        public string? guarantor1_Phones_No { get; set; }
        public string? guarantor1_Company_Name { get; set; }
        public string? guarantor1_Off_Address { get; set; }
        public string? guarantor1_Off_Phone_No { get; set; }


        // guarantor2 detail key name

        public string? guarantor2_Name { get; set; }
        public string? guarantor2_SWH_Name { get; set; }
        public string? guarantor2_Resi_Address { get; set; }
        public string? guarantor2_Phones_No { get; set; }
        public string? guarantor2_Company_Name { get; set; }
        public string? guarantor2_Off_Address { get; set; }
        public string? guarantor2_Off_Phone_No { get; set; }



        // receipt detail key name
        public string? receipt_System_Bill_No { get; set; }
        public string? receipt_Case_No { get; set; }
        public string? receipt_Instalment_No { get; set; }
        public DateTime? receipt_Due_Date { get; set; }
        public DateTime? receipt_Deposit_Date { get; set; }
        public string? receipt_Receipt_No { get; set; }
        public DateTime? receipt_Receipt_Date { get; set; }
        public string? receipt_Party_Name { get; set; }
        public decimal? receipt_Due_Amt { get; set; }
        public long? receipt_No_of_Inst_of_Int { get; set; } = 1;
        public decimal? receipt_Rec_Amt { get; set; }
        public string? receipt_By_Cash_Bank { get; set; }
        public string? receipt_Cheque_No { get; set; }
        public string? receipt_Chq_Deposit { get; set; }
        public decimal? receipt_Bank_Chgs_Amt { get; set; }
        public string? receipt_Late_Bounse { get; set; }
        public string? receipt_Remark { get; set; }
        public DateTime? receipt_Current_Date { get; set; }
        public string? receipt_A_c_Close { get; set; }
        public DateTime? receipt_Close_Date { get; set; }
        public string? receipt_Case_Type { get; set; }
        public decimal? receipt_Pric1 { get; set; }
        public decimal? receipt_Hp1 { get; set; }
        public decimal? receipt_Pric2 { get; set; }
        public decimal? receipt_Hp2 { get; set; }
        public string? Chq_Bounce { get; set; }
        public decimal? receipt_Bank_Chgs_Amt_Rec { get; set; }
        public string? receipt_Late_Boun_Rec { get; set; }


        // extra table detail key name
        public string? extra_Registration_No { get; set; }
        public string? extra_Hirer_Name { get; set; }
        public string? extra_Item_Type { get; set; }
        public string? extra_Manufacturer { get; set; }
        public string? extra_Model_Name { get; set; }
        public string? extra_Year_of_Registration { get; set; }
        public string? extra_RC_Given { get; set; }
        public string? extra_RC_Taken_By { get; set; }
        public string? extra_Chassis_No { get; set; }
        public string? extra_Engine_No { get; set; }
        public string? extra_NOC_Made { get; set; }
        public string? extra_Taken_By { get; set; }
        public string? extra_Addhaar_No { get; set; }
        public string? extra_Pan_Card_No { get; set; }
        public string? extra_DL_No { get; set; }
        public string? extra_Case_No { get; set; }
        public DateTime? extra_RC_Given_Date { get; set; }
        public DateTime? extra_Date { get; set; }
        public DateTime? extra_Date_Taken_By { get; set; }

        // emi table  key ina array 
        public ICollection<EmiKey>?EmiKeys { get; set; }
        public List<UploadDocumentKey>? UploadDocumentKey { get; set; }


        public List<caseAddressTranskey>? caseAddressTranskey { get; set; }
        public List<caseConactTranskey>? caseConactTranskey { get; set; }

        public List<caseDeleteAddressTranskey>? caseDeleteAddressTranskey { get; set; }
        public List<caseDeleteContactTranskey>? caseDeleteContactTranskey { get; set; }
    }

    public class EmiKey
    {
        public long? Id { get; set; }
        public DateTime? emi_PaymentDate { get; set; }
        public string? emi_Monthly_Amount { get; set; }
        public string? emi_Interest_Amount { get; set; }
        public string? emi_Monthly_Interest_Amount { get; set; }
    }

    public class UploadDocumentKey
    {
        public long? Id { get; set; }
        public string? upload_document_name { get; set; }
        public string? upload_document_path { get; set; }

    }

    public class caseAddressTranskey
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
        public string? party_address_area_code { get; set; }

    }

    public class caseConactTranskey
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


    public class caseDeleteAddressTranskey
    {
        public long? id { get; set; }
        public string? party_address_1 { get; set; }
        public string? party_address_2 { get; set; }
        public long? party_pincode { get; set; }
        public string? party_state { get; set; }
        public string? party_country { get; set; }
        public string? party_address_description { get; set; }

    }

    public class caseDeleteContactTranskey
    {
        public long? id { get; set; }
        public string? party_contact_name { get; set; }
        public long? party_contact_mobile { get; set; }
        public long? party_contact_whatsapp_mobile { get; set; }
        public string? party_contact_email { get; set; }
        public string? party_contact_description { get; set; }

    }

}
