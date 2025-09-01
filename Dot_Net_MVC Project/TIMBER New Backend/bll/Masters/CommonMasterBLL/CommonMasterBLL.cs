using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Collections.Specialized.BitVector32;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Drawing;

namespace RTA.Masters
{
    public class CommonMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public CommonMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
        public CommonMasterResp InsertCsvFileDataCommonMaster(List<dynamic> fileData, string? flagName)
        {
            if (flagName == "finance")
            {
                foreach (var record in fileData)
                {

                    if (record == null || string.IsNullOrEmpty(record?.PName))
                    {
                        continue;
                    }

                    CaseMaster SampData = new CaseMaster
                    {
                        Case_Financed_Item = record?.IteM_Financed,
                        Case_Financed_Type = record?.F_Item_Group,
                        Case_Finance_Amt = record.Finance_Amt,
                        Case_Duration_Type = "months",
                        Case_Duration_Value = record.Duration,
                        Case_Instalments = record.Instalments,
                        Case_Montly_Amt = record.Montly_Amt,
                        Case_Total_Amt_Due = record.Total_Amt_Due,
                        Case_Total_Cost = record.Total_Cost,
                        Case_ADVANCE_REQ = record.ADVANCE_REQ.ToString(),
                        Case_TOTAL_ADV_REQ = record.TOTAL_ADV_REQ.ToString(),

                        Case_Due_Date = ConvertToDateWithoutTime(record.Due_Date),
                        //ase_Due_Date = DateTime.Parse(record.Due_Date),

                        Case_Payment_By = record.Instalments_By,
                        Case_Chq_NO = record.Chq_NO.ToString(),
                        Case_Case_Remark = record.Case_Remark.ToString(),
                        Case_F_O_CHARGE = record.OTHER_CHARGES.ToString(),        //Case_F_O_CHARGE,
                        Case_Total_hp = record.Total_hp,
                        Case_X = record.Duration,                                 //Case_X,
                        Case_Rate_of_Interest = record.Rate_of_Interest,
                        Case_hp = record.Montly_interest,                         //Case_hp
                        Case_Extra_Inst = record.Extra_Inst,
                        Case_Instalments_By = record.Instalments_By,
                        Case_Finance_Amt_2 = record.Finance_Amt_2,
                        Case_Pending_Amt = record.Pending_Amt,
                        Case_end_Date = ConvertToDateWithoutTime(record.end_Date),
                        Case_Manual_Lg = record.Manual_Lg_No,
                        Case_Dealer_Name = record.Dealer_Name,
                        Case_Curr_Date = ConvertToDateWithoutTime(record.Curr_Date),
                        Case_Case_No = record.Case_No,
                        Case_Ac_Close = record.Ac_Close,
                        Case_Ac_Close_Date = ConvertToDateWithoutTime(record.Ac_Close_Date),
                        Case_Block_YN = record.Block_YN,
                        Case_Interest_type = record.Interest_type,
                        Case_Finance_Company = record.Hirer_company,
                        Hire_Name = record.PName,
                        Case_F_O_Select = record.Incl_Oth_Ch

                        //Case_Case_stage = records.Case_Case_stage,
                        //Hire_SWH_Name = records.Hire_SWH_Name,
                        //Case_Financed_Type = records.case_Financed_Type,
                        //Case_Relation_Type = records.case_relation_type

                    };

                    DB.CaseMaster.Add(SampData);
                    DB.SaveChanges();

                    // Correctly call the CalculateEmiData method
                    // int.Parse(record.Extra_Inst),
                    var emiData = CalculateEmiData(
                        double.Parse(record.Finance_Amt),
                        double.Parse(record.Finance_Amt),
                        double.Parse(record.Rate_of_Interest),
                        int.Parse(record.Duration), // Ensure Duration is parsed as int
                        true,
                        SampData.id,
                        ConvertToDateWithoutTime(record.Due_Date)
                    );

                    var lastId = (long)(DB.PartyMaster.Max(u => (long?)u.id) ?? 0);

                    string pName = record.PName;

                    //var agrCode = string.Concat(pName.Split(' ')
                    //.Select(word => word[0].ToString().ToUpper())) + lastId;

                    var agrCode = string.Concat(pName.Split(' ')
                    .Where(word => !string.IsNullOrEmpty(word))  // Filter out empty strings
                    .Select(word => word[0].ToString().ToUpper())) + lastId;

                    PartyMaster PSampData = new PartyMaster
                    {
                        name = record.PName,
                        party_group_category_name = "Debtors",
                        party_agr_code = agrCode,
                        case_master_case_no = record.Case_No,
                    };

                    DB.PartyMaster.Add(PSampData);
                    DB.SaveChanges();



                    //  ========================   address detail   ============================== 

                    // primary address  

                    if (!string.IsNullOrEmpty(record.padd1) || !string.IsNullOrEmpty(record.padd2))
                    {

                        PartyAddressTransMaster SampData2 = new PartyAddressTransMaster()
                        {
                            party_master_id = PSampData.id,
                            case_master_id = SampData.id,
                            party_address_description = "primary",
                            party_address_1 = record.padd1,
                            party_address_2 = record.padd2,
                            party_address_area_code = record.area_code,
                            party_address_location = record.Loc_Code

                            //party_pincode = item.party_pincode,
                            //party_state = item.party_state,
                            //party_country = item.party_country,
                            //party_gst_type = item.party_gst_type,
                            //party_gst_code = item.party_gst_code,
                            //party_gst_address_no = item.party_gst_address_no,

                        };

                        DB.PartyAddressTransMaster.Add(SampData2);
                        DB.SaveChanges();

                    }

                    // guarantor1 address  

                    if (!string.IsNullOrEmpty(record.Guarantor_Res_Add1_1) || !string.IsNullOrEmpty(record.Guarantor_Res_Add2_1))

                    {
                        PartyAddressTransMaster SampData3 = new PartyAddressTransMaster()
                        {
                            party_master_id = PSampData.id,
                            case_master_id = SampData.id,
                            party_address_description = "guarantor1",
                            party_address_1 = record.Guarantor_Res_Add1_1,
                            party_address_2 = record.Guarantor_Res_Add2_1,
                            //party_address_area_code = record.area_code,
                            //party_address_location = record.Loc_Code
                            //party_pincode = item.party_pincode,
                            //party_state = item.party_state,
                            //party_country = item.party_country,
                            //party_gst_type = item.party_gst_type,
                            //party_gst_code = item.party_gst_code,
                            //party_gst_address_no = item.party_gst_address_no,

                        };

                        DB.PartyAddressTransMaster.Add(SampData3);
                        DB.SaveChanges();

                    }

                    // guarantor2 address  

                    if (!string.IsNullOrEmpty(record.Guarantor_Res_Add1_2) || !string.IsNullOrEmpty(record.Guarantor_Res_Add2_2))
                    {

                        PartyAddressTransMaster SampData4 = new PartyAddressTransMaster()
                        {
                            party_master_id = PSampData.id,
                            case_master_id = SampData.id,
                            party_address_description = "guarantor2",
                            party_address_1 = record.Guarantor_Res_Add1_2,
                            party_address_2 = record.Guarantor_Res_Add2_2,
                            // party_address_area_code = record.Guarantor_Res_Add1_2,
                            // party_address_location = record.Loc_Code

                            //party_pincode = item.party_pincode,
                            //party_state = item.party_state,
                            //party_country = item.party_country,

                            //party_gst_type = item.party_gst_type,
                            //party_gst_code = item.party_gst_code,
                            //party_gst_address_no = item.party_gst_address_no,

                        };

                        DB.PartyAddressTransMaster.Add(SampData4);
                        DB.SaveChanges();

                    }

                    //  ========================   contact detail   ============================== 

                    // primary contact 
                    if (!string.IsNullOrEmpty(record.opadd1) || !string.IsNullOrEmpty(record.pph1) || !string.IsNullOrEmpty(record.pph1))
                    {
                        PartyContactTransMaster SampData5 = new PartyContactTransMaster()
                        {
                            party_master_id = PSampData.id,
                            case_master_id = SampData.id,
                            party_contact_description = "primary",
                            party_contact_name = record.PName,
                            party_landline_no = record.opadd1,
                            party_contact_mobile = record.pph1,
                            party_contact_whatsapp_mobile = record.pph1,

                            //party_contact_email = record.party_contact_email,
                            //party_contact_description = record.party_contact_description,
                            //party_contact_department = record.party_contact_department,
                            //party_contact_designation = record.party_contact_designation,
                            //party_contact_website = record.party_contact_website,
                            //party_contact_twitter_id = record.party_contact_twitter_id,
                            //party_contact_fb_id = record.party_contact_fb_id,
                            //party_contact_youtube_id = record.party_contact_youtube_id,
                            //party_contact_instagram_id = record.party_contact_instagram_id,

                        };

                        DB.PartyContactTransMaster.Add(SampData5);
                        DB.SaveChanges();

                    }


                    //guarantor name 1
                    if (!string.IsNullOrEmpty(record.Guarantor_Name_1) || !string.IsNullOrEmpty(record.Guarantor_Res_Pho_1) || !string.IsNullOrEmpty(record.Guarantor_Res_Pho_1))
                    {
                        PartyContactTransMaster SampData6 = new PartyContactTransMaster()
                        {
                            party_master_id = PSampData.id,
                            case_master_id = SampData.id,
                            party_contact_description = "guarantor1",
                            party_contact_name = record.Guarantor_Name_1,
                            //party_landline_no = record.opadd1,
                            party_contact_mobile = record.Guarantor_Res_Pho_1,
                            party_contact_whatsapp_mobile = record.Guarantor_Res_Pho_1,

                            //party_contact_email = record.party_contact_email,
                            //party_contact_description = record.party_contact_description,
                            //party_contact_department = record.party_contact_department,
                            //party_contact_designation = record.party_contact_designation,
                            //party_contact_website = record.party_contact_website,
                            //party_contact_twitter_id = record.party_contact_twitter_id,
                            //party_contact_fb_id = record.party_contact_fb_id,
                            //party_contact_youtube_id = record.party_contact_youtube_id,
                            //party_contact_instagram_id = record.party_contact_instagram_id,

                        };

                        DB.PartyContactTransMaster.Add(SampData6);
                        DB.SaveChanges();

                    }


                    //guarantor name 2
                    if (!string.IsNullOrEmpty(record.Guarantor_Name_2) || !string.IsNullOrEmpty(record.Guarantor_Res_Pho_2) || !string.IsNullOrEmpty(record.Guarantor_Res_Pho_2))
                    {
                        PartyContactTransMaster SampData7 = new PartyContactTransMaster()
                        {
                            party_master_id = PSampData.id,
                            case_master_id = SampData.id,
                            party_contact_description = "guarantor2",
                            party_contact_name = record.Guarantor_Name_2,
                            //party_landline_no = record.opadd1,
                            party_contact_mobile = record.Guarantor_Res_Pho_2,
                            party_contact_whatsapp_mobile = record.Guarantor_Res_Pho_2,

                            //party_contact_email = record.party_contact_email,
                            //party_contact_description = record.party_contact_description,
                            //party_contact_department = record.party_contact_department,
                            //party_contact_designation = record.party_contact_designation,
                            //party_contact_website = record.party_contact_website,
                            //party_contact_twitter_id = record.party_contact_twitter_id,
                            //party_contact_fb_id = record.party_contact_fb_id,
                            //party_contact_youtube_id = record.party_contact_youtube_id,
                            //party_contact_instagram_id = record.party_contact_instagram_id,

                        };

                        DB.PartyContactTransMaster.Add(SampData7);
                        DB.SaveChanges();
                    }


                    //  ========================   case master extra detail   ============================== 
                    ExtraDetail SampData8 = new ExtraDetail
                    {
                        Case_Master_id = SampData.id,
                        extra_Registration_No = record.Reg_No,
                        extra_Hirer_Name = record.Hirer_company,
                        extra_Item_Type = record.Item_type,
                        // extra_Manufacturer = samp.extra_Manufacturer,
                        extra_Model_Name = record.Model_Name,
                        extra_Year_of_Registration = record.year_veh,
                        extra_RC_Given = record.RC_GIVEN,
                        extra_RC_Given_Date = ConvertToDateWithoutTime(record.RC_GIVEN_Date),
                        extra_RC_Taken_By = record.RC_Taken_By,
                        extra_Chassis_No = record.Chassis_No,
                        extra_Engine_No = record.Engine_No,
                        extra_NOC_Made = record.NOC_YN,
                        extra_Taken_By = record.NOC_Taken_By,
                        extra_Addhaar_No = record.Addhaar_NO,
                        extra_Pan_Card_No = record.Pan_No,
                        extra_DL_No = record.DL_No,
                        // extra_Case_No = samp.extra_Case_No,
                        //  extra_Date = samp.extra_Date,
                        // extra_Date_Taken_By = samp.extra_Date_Taken_By
                    };
                    DB.ExtraDetail.Add(SampData8);
                    DB.SaveChanges();

                }

            }

            if (flagName == "party")
            {
                foreach (var record in fileData)
                {

                    //var lastId = (long)(DB.PartyMaster.Max(u => (long?)u.id) ?? 0);

                    //string pName = record.pname;

                    ////var agrCode = string.Concat(pName.Split(' ')
                    ////.Select(word => word[0].ToString().ToUpper())) + lastId;

                    //var agrCode = string.Concat(pName.Split(' ')
                    //.Where(word => !string.IsNullOrEmpty(word))  // Filter out empty strings
                    //.Select(word => word[0].ToString().ToUpper())) + lastId;

                    PartyMaster PSampData = new PartyMaster
                    {
                        name = record.pname,
                        party_company_name = record.pname,
                        party_agr_code = !string.IsNullOrEmpty(record.agr_code) ? record.agr_code: "",
                        party_group_category_name = !string.IsNullOrEmpty(record.g_name) ? record.g_name : "",
                        party_group_category_id = !string.IsNullOrEmpty(record.pgroupcode) ? long.Parse(record.pgroupcode) : null,
                        //case_master_case_no = record.Case_No,
                        old_software_code_ya_id = !string.IsNullOrEmpty(record.pcode) ? long.Parse(record.pcode) : null,
                        status_option = !string.IsNullOrEmpty(record.delete_option) ? record.delete_option : "empty"
                    };

                    DB.PartyMaster.Add(PSampData);
                    DB.SaveChanges();



                    //  ========================   address detail   ============================== 

                    // primary address  

                    if (!string.IsNullOrEmpty(record.padd1) || !string.IsNullOrEmpty(record.padd2))
                    {

                        PartyAddressTransMaster SampData2 = new PartyAddressTransMaster()
                        {
                            party_master_id = PSampData.id,
                            party_address_description = "primary",
                            party_address_1 = !string.IsNullOrEmpty(record.padd1) ? record.padd1 : "",
                            party_address_2 = !string.IsNullOrEmpty(record.padd2) ? record.padd2 : "",
                            party_pincode = !string.IsNullOrEmpty(record.ppin) ? long.Parse(record.ppin) : null,
                            old_software_code_ya_id = !string.IsNullOrEmpty(record.pcode) ? long.Parse(record.pcode) : null,
                            party_state = !string.IsNullOrEmpty(record.padd4) ? record.padd4 : "",

                            //party_address_area_code = record.area_code,
                            //party_address_location = record.Loc_Code
                            //party_country = item.party_country,
                            //party_gst_type = item.party_gst_type,
                            //party_gst_code = item.party_gst_code,
                            //party_gst_address_no = item.party_gst_address_no,

                        };

                        DB.PartyAddressTransMaster.Add(SampData2);
                        DB.SaveChanges();

                    }

                    //  ========================   contact detail   ============================== 

                    // primary contact 
                    if (!string.IsNullOrEmpty(record.pph2) || !string.IsNullOrEmpty(record.pph1))
                    {
                        PartyContactTransMaster SampData5 = new PartyContactTransMaster()
                        {
                            party_master_id = PSampData.id,
                            // case_master_id = SampData.id,
                            party_contact_description = "primary",
                            party_contact_name = !string.IsNullOrEmpty(record.pname) ? record.pname : "",
                            party_landline_no = !string.IsNullOrEmpty(record.pph2) ? record.pph2 : "",
                            party_contact_mobile = !string.IsNullOrEmpty(record.pph1) ? record.pph1 : "",
                            party_contact_whatsapp_mobile = !string.IsNullOrEmpty(record.pph1) ? record.pph1 : "",


                            //party_contact_email = record.party_contact_email,
                            //party_contact_description = record.party_contact_description,
                            //party_contact_department = record.party_contact_department,
                            //party_contact_designation = record.party_contact_designation,
                            //party_contact_website = record.party_contact_website,
                            //party_contact_twitter_id = record.party_contact_twitter_id,
                            //party_contact_fb_id = record.party_contact_fb_id,
                            //party_contact_youtube_id = record.party_contact_youtube_id,
                            //party_contact_instagram_id = record.party_contact_instagram_id,
                            old_software_code_ya_id = !string.IsNullOrEmpty(record.pcode) ? long.Parse(record.pcode) : null

                        };

                        DB.PartyContactTransMaster.Add(SampData5);
                        DB.SaveChanges();

                    }


                }

            }

            if (flagName == "party_aggrement")
            {
                foreach (var record in fileData)
                {
                    long pcode = long.Parse(record.pcode);
                    var checkPartyMaster = DB.PartyMaster.Where(ES => ES.old_software_code_ya_id == pcode).FirstOrDefault();


                    checkPartyMaster.party_agr_code = !string.IsNullOrEmpty(record.agr_refno) ? record.agr_refno : "";
                    checkPartyMaster.status_option = "done";
                    checkPartyMaster.Dr_Cr = !string.IsNullOrEmpty(record.baldrcr) ? record.baldrcr : "";
                    checkPartyMaster.Op_Bal = !string.IsNullOrEmpty(record.agr_opbal) ? long.Parse(record.agr_opbal) : 0;
                    checkPartyMaster.Ac_Opening_Date = !string.IsNullOrEmpty(record.agr_date) ? ConvertToDateWithoutTime(record.agr_date) : null;
                    checkPartyMaster.hire_status = !string.IsNullOrEmpty(record.gtype) ? record.gtype : "";
                    checkPartyMaster.dr = !string.IsNullOrEmpty(record.secdrcr) ? record.secdrcr : "";


                    /* PartyMaster PSampData = new PartyMaster
                     {
                         name = record.agr_name,
                         party_agr_code = record.agr_refno,
                         // party_group_category_name = !string.IsNullOrEmpty(record.g_name) ? record.g_name : "",
                         //party_group_category_id = !string.IsNullOrEmpty(record.pgroupcode) ? long.Parse(record.pgroupcode) : null,
                         //case_master_case_no = record.Case_No,
                     };

                     DB.PartyMaster.Add(PSampData);
                     DB.SaveChanges();*/


                    // primary address
                    if (!string.IsNullOrEmpty(record.agr_sadd1) || !string.IsNullOrEmpty(record.agr_sadd2))
                    {

                        PartyAddressTransMaster SampData2 = new PartyAddressTransMaster()
                        {
                            party_master_id = checkPartyMaster.id,
                            party_address_description = "primary",
                            party_address_1 = !string.IsNullOrEmpty(record.agr_sadd1) ? record.agr_sadd1 : "",
                            party_address_2 = !string.IsNullOrEmpty(record.agr_sadd2) ? record.agr_sadd2 : "",
                            party_state = !string.IsNullOrEmpty(record.agr_sadd4) ? record.agr_sadd4 : "",
                            //party_pincode = !string.IsNullOrEmpty(record.ppin) ? long.Parse(record.ppin) : null,
                            //party_address_area_code = record.area_code,
                            //party_address_location = record.Loc_Code
                            //party_country = item.party_country,
                            //party_gst_type = item.party_gst_type,
                            //party_gst_code = item.party_gst_code,
                            //party_gst_address_no = item.party_gst_address_no,
                        };

                        DB.PartyAddressTransMaster.Add(SampData2);
                        DB.SaveChanges();

                    }

                    // primary contact 
                    if (!string.IsNullOrEmpty(record.agr_pers1) || !string.IsNullOrEmpty(record.agr_pers2))
                    {
                        PartyContactTransMaster SampData5 = new PartyContactTransMaster()
                        {
                            party_master_id = checkPartyMaster.id,
                            party_contact_description = "primary",
                            party_contact_name = !string.IsNullOrEmpty(record.agr_name) ? record.agr_name : "",
                            party_landline_no = !string.IsNullOrEmpty(record.agr_pers2) ? record.agr_pers2 : "",
                            party_contact_mobile = !string.IsNullOrEmpty(record.agr_pers1) ? record.agr_pers1 : "",
                            party_contact_whatsapp_mobile = !string.IsNullOrEmpty(record.agr_pers1) ? record.agr_pers1 : "",


                            //party_contact_email = record.party_contact_email,
                            //party_contact_description = record.party_contact_description,
                            //party_contact_department = record.party_contact_department,
                            //party_contact_designation = record.party_contact_designation,
                            //party_contact_website = record.party_contact_website,
                            //party_contact_twitter_id = record.party_contact_twitter_id,
                            //party_contact_fb_id = record.party_contact_fb_id,
                            //party_contact_youtube_id = record.party_contact_youtube_id,
                            //party_contact_instagram_id = record.party_contact_instagram_id,

                        };

                        DB.PartyContactTransMaster.Add(SampData5);
                        DB.SaveChanges();
                    }
                }
            }

            if (flagName == "party_aggrement_item")
            {
                foreach (var record in fileData)
                {
                    long pcode = long.Parse(record.pcode);
                    var checkPartyMaster = DB.PartyMaster.Where(ES => ES.old_software_code_ya_id == pcode).FirstOrDefault();

                    if (checkPartyMaster != null)
                    {

                        AggrementMaster SampData = new AggrementMaster

                        {
                            pname = checkPartyMaster.name,
                            pcode = checkPartyMaster.id,
                            party_master_id = checkPartyMaster.id,
                            //pname_short_code = samp.pname_short_code,
                            agr_code_old = !string.IsNullOrEmpty(record.agr_code) ? record.agr_code : "",
                            agr_no_old = !string.IsNullOrEmpty(record.agr_no) ? record.agr_no : "",


                            //item_code = !string.IsNullOrEmpty(record.item_code) ? long.Parse(record.item_code) : null,
                            item_name = !string.IsNullOrEmpty(record.itemname) ? record.itemname : "",
                            item_short_name = !string.IsNullOrEmpty(record.item_short_name) ? record.item_short_name : "",
                            //item_group_code = !string.IsNullOrEmpty(record.item_group_code) ? long.Parse(record.item_group_code) : null,
                            item_group_name = !string.IsNullOrEmpty(record.item_group_name) ? record.item_group_name : "",
                            mix_item_yes_no = !string.IsNullOrEmpty(record.mix_item_yes_no) ? record.mix_item_yes_no : "",
                            rent_rate = !string.IsNullOrEmpty(record.rentrate) ? double.Parse(record.rentrate) : null,
                            broken_chg = !string.IsNullOrEmpty(record.broken_chg) ? double.Parse(record.broken_chg) : null,
                            agr_qty = !string.IsNullOrEmpty(record.agr_qty) ? double.Parse(record.agr_qty) : null,
                            agr_date = !string.IsNullOrEmpty(record.agr_date) ? ConvertToDateWithoutTime(record.agr_date) : null,
                            opening_qty = !string.IsNullOrEmpty(record.opening_qty) ? double.Parse(record.opening_qty) : null,
                            rate_on_type = !string.IsNullOrEmpty(record.type) ? record.type : "",
                            missing_rate = !string.IsNullOrEmpty(record.missing_rate) ? double.Parse(record.missing_rate) : null,
                            s_no = !string.IsNullOrEmpty(record.s_no) ? long.Parse(record.s_no) : null,
                            rate_of_one_pcs = !string.IsNullOrEmpty(record.rate_of_one_pcs) ? record.rate_of_one_pcs : "",


                            //notaxrate = !string.IsNullOrEmpty(record.notaxrate) ? double.Parse(record.notaxrate) : null,
                            //item_loc = !string.IsNullOrEmpty(record.item_loc) ? record.item_loc : "",

                            // weight_of_one_pcs = samp.weight_of_one_pcs,
                            //item_status_agr = samp.item_status_agr,
                            created_on = DateTime.Now,
                            updated_on = DateTime.Now,
                        };

                        DB.AggrementMaster.Add(SampData);

                        checkPartyMaster.agreement_yn = "yes";
                        DB.SaveChanges();
                    }
                }
            }

            if (flagName == "item")
            {
                foreach (var record in fileData)
                {
                    ItemMaster SampData = new ItemMaster()
                    {
                        item_short_name = record.item_short_name,
                        item_name = record.item_name,
                        group = record.item_group_name,
                        hsn_code = record.hsn_code,
                        tax_per = record.i_tax_per,
                        old_software_code_ya_id = long.Parse(record.item_code)

                        //convertion_of_pcs = samp.convertion_of_pcs,
                        //price_purchase_rate = samp.price_purchase_rate,
                        //price_value_per_pcs = samp.price_value_per_pcs,
                        //price_avg_weight_per_pcs = samp.price_avg_weight_per_pcs,
                        //price_opening_stock_rate = samp.price_opening_stock_rate,
                        //opening_stock_shop = samp.opening_stock_shop,
                        //stock_shop = samp.stock_shop,
                        //opening_stock_godown = samp.opening_stock_godown,
                        //stock_godown = samp.stock_godown,
                        //total_stock = samp.total_stock,
                        //item_type = samp.item_type,
                        //item_packing_type = samp.item_packing_type,

                        //price_purchase_discount_percentage = samp.price_purchase_discount_percentage,
                        //price_purchase_discount_amt = samp.price_purchase_discount_amt,
                        //price_purchase_amount_after_discount = samp.price_purchase_amount_after_discount,
                        //price_purchase_packing_cost = samp.price_purchase_packing_cost,
                        //price_purchase_packing_cost_incl_yn = samp.price_purchase_packing_cost_incl_yn,
                        //price_purchase_amount_with_packing_cost = samp.price_purchase_amount_with_packing_cost,
                        //price_purchase_gst_percentage = samp.price_purchase_gst_percentage,
                        //price_purchase_gst_amount = samp.price_purchase_gst_amount,
                        //price_purchase_amount_with_gst = samp.price_purchase_amount_with_gst,
                        //price_purchase_margin_profit_percentage = samp.price_purchase_margin_profit_percentage,
                        //price_purchase_margin_profit_amount = samp.price_purchase_margin_profit_amount,
                        //price_purchase_rate_approx = samp.price_purchase_rate_approx,

                        //price_sell_rate = samp.price_sell_rate,
                        //price_sell_discount_percentage = samp.price_sell_discount_percentage,
                        //price_sell_discount_amount = samp.price_sell_discount_amount,
                        //price_sell_amount_after_discount = samp.price_sell_amount_after_discount,
                        //price_sell_gst_percentage = samp.price_sell_gst_percentage,
                        //price_sell_gst_amount = samp.price_sell_gst_amount,
                        //price_sell_amount_with_gst = samp.price_sell_amount_with_gst,
                        //purchase_unit_name = samp.purchase_unit_name,
                        //purchase_unit_qty = samp.purchase_unit_qty,
                        //sale_unit_name = samp.sale_unit_name,
                        //item_barcode_no = samp.item_barcode_no,
                        //item_remark_no = samp.item_remark_no,
                        //item_min_qty = samp.item_min_qty,
                        //item_reorder_qty = samp.item_reorder_qty,
                        //item_max_qty = samp.item_max_qty,

                    };

                    DB.ItemMaster.Add(SampData);
                    DB.SaveChanges();

                }
            }

            if (flagName == "partycategory")
            {
                foreach (var record in fileData)
                {
                    PartyCategoryMaster categoryObj = new PartyCategoryMaster
                    {
                        table_flag = !string.IsNullOrEmpty(record.table_flag) ? record.table_flag : "empty",
                        category_name = !string.IsNullOrEmpty(record.category_name) ? record.category_name : "",
                        cate_type = !string.IsNullOrEmpty(record.cate_type) ? record.cate_type : "",
                        cate_id_if_sub_Selected = !string.IsNullOrEmpty(record.cate_id_if_sub_Selected) ? long.Parse(record.cate_id_if_sub_Selected) : null,
                        cate_name_if_sub_Selected = !string.IsNullOrEmpty(record.cate_name_if_sub_Selected) ? record.cate_name_if_sub_Selected : "",
                        super_cate_id = !string.IsNullOrEmpty(record.super_cate_id) ? long.Parse(record.super_cate_id) : null,
                        balance_sheet_id = !string.IsNullOrEmpty(record.balance_sheet_id) ? long.Parse(record.balance_sheet_id) : null,
                        balance_sheet_cate_name = !string.IsNullOrEmpty(record.balance_sheet_cate_name) ? record.balance_sheet_cate_name : "",
                        old_software_code_ya_id = !string.IsNullOrEmpty(record.id) ? long.Parse(record.id) : null,
                        delete_option = !string.IsNullOrEmpty(record.DELETE_OPTION) ? record.DELETE_OPTION : "",
                    };

                    DB.PartyCategoryMaster.Add(categoryObj);
                    DB.SaveChanges();

                }
            }


            if (flagName == "issuechallan")
            {

                foreach (var record in fileData)
                {

                    string challanNo = record.challanno;
                    var checkIssueChallan = DB.IssueReceiptMaster.Where(e => e.challanno == challanNo).FirstOrDefault();
                    long challanMasterId;
                    if (checkIssueChallan == null)
                    {
                        IssueReceiptMaster SampData = new IssueReceiptMaster()
                        {

                            irflag = !string.IsNullOrEmpty(record.irflag) ? record.irflag : "",
                            //"IC",
                            billno_automatic = !string.IsNullOrEmpty(record.BillNo_Automatic) ? long.Parse(record.BillNo_Automatic) : null,
                            challanno = !string.IsNullOrEmpty(record.challanno) ? record.challanno : null,
                            bill_date = !string.IsNullOrEmpty(record.Bill_Date) ? ConvertToDateWithoutTime(record.Bill_Date) : null,

                            //agr_code_old = record.agr_code,
                            //agr_no_old = record.agr_no,
                            //item_code = record.item_code,
                            //item_short_name = record.item_short_name,
                            //item_name = record.itemname,
                            //item_group_code = record.item_group_code,
                            //item_group_name = record.item_group_name,
                            //issue_qty = record.issue_qty,
                            //recv_qty = record.recv_qty,
                            //irflag = record.irflag,
                            //billfr = record.billfr,
                            //billto = record.billto,
                            //rent_rate = record.rate,
                            //broken_amt = record.broken_amt,

                            frshop = !string.IsNullOrEmpty(record.frshop) ? double.Parse(record.frshop) : null,
                            froffice = !string.IsNullOrEmpty(record.froffice) ? double.Parse(record.froffice) : null,
                            brok_qty = !string.IsNullOrEmpty(record.brok_qty) ? double.Parse(record.brok_qty) : null,
                            brok_rate = !string.IsNullOrEmpty(record.brok_rate) ? double.Parse(record.brok_rate) : null,
                            miss_flag = !string.IsNullOrEmpty(record.miss_flag) ? record.miss_flag : "",
                            cartcode = !string.IsNullOrEmpty(record.cartcode) ? record.cartcode : "",
                            cart_amt = !string.IsNullOrEmpty(record.cartamt) ? double.Parse(record.cartamt) : null,
                            prnnarr = !string.IsNullOrEmpty(record.prnnarr) ? record.prnnarr : "",
                            remark_note = !string.IsNullOrEmpty(record.remark) ? record.remark : "",


                            misc1 = !string.IsNullOrEmpty(record.misc1) ? double.Parse(record.misc1) : null,
                            misc2 = !string.IsNullOrEmpty(record.misc2) ? double.Parse(record.misc2) : null,
                            misc3 = !string.IsNullOrEmpty(record.misc3) ? double.Parse(record.misc3) : null,
                            misc4 = !string.IsNullOrEmpty(record.misc4) ? double.Parse(record.misc4) : null,
                            misc5 = !string.IsNullOrEmpty(record.misc5) ? double.Parse(record.misc5) : null,
                            misc6 = !string.IsNullOrEmpty(record.misc6) ? double.Parse(record.misc6) : null,
                            sno = !string.IsNullOrEmpty(record.SNO) ? long.Parse(record.SNO) : "",
                            contact_prs_ph = !string.IsNullOrEmpty(record.Contact_Prs_Ph) ? record.Contact_Prs_Ph : "",
                            transporter_name = !string.IsNullOrEmpty(record.Transporter_Name) ? record.Transporter_Name : "",
                            gr_no = !string.IsNullOrEmpty(record.Gr_No) ? record.Gr_No : "",
                            vehicleno = !string.IsNullOrEmpty(record.VehicleNo) ? record.VehicleNo : "",
                            driver_name = !string.IsNullOrEmpty(record.Driver_Name) ? record.Driver_Name : "",
                            dl_no = !string.IsNullOrEmpty(record.DL_No) ? record.DL_No : "",
                            permit_no = !string.IsNullOrEmpty(record.Permit_no) ? record.Permit_no : "",
                            contact_prs_ph_no = !string.IsNullOrEmpty(record.Contact_Prs_Ph_No) ? record.Contact_Prs_Ph_No : "",
                            apx_weight = !string.IsNullOrEmpty(record.Apx_weight) ? double.Parse(record.Apx_weight) : null,
                            apx_value = !string.IsNullOrEmpty(record.Apx_value) ? record.Apx_value : "",
                            bill_enter_date = !string.IsNullOrEmpty(record.bill_Enter_Date) ? ConvertToDateWithoutTime(record.bill_Enter_Date) : null,
                            trip_no = !string.IsNullOrEmpty(record.Trip_No) ? long.Parse(record.Trip_No) : null,
                            bill_amt = !string.IsNullOrEmpty(record.Bill_Amt) ? double.Parse(record.Bill_Amt) : null,
                            rec_type = !string.IsNullOrEmpty(record.rec_type) ? record.rec_type : "",
                            tnx_type = !string.IsNullOrEmpty(record.Tnx_type) ? record.Tnx_type : "",
                            unit_name = !string.IsNullOrEmpty(record.UNIT_NAME) ? record.UNIT_NAME : "",
                            itemtype = !string.IsNullOrEmpty(record.ItemType) ? record.ItemType : "",
                            tax_code = !string.IsNullOrEmpty(record.Tax_Code) ? long.Parse(record.Tax_Code) : null,
                            tax_name = !string.IsNullOrEmpty(record.Tax_Name) ? record.Tax_Name : "",
                            tax_per = !string.IsNullOrEmpty(record.Tax_Per) ? double.Parse(record.Tax_Per) : null,
                            tax_amt = !string.IsNullOrEmpty(record.Tax_Amt) ? double.Parse(record.Tax_Amt) : null,
                            dis_per = !string.IsNullOrEmpty(record.Dis_Per) ? double.Parse(record.Dis_Per) : null,
                            dis_amt = !string.IsNullOrEmpty(record.Dis_Amt) ? double.Parse(record.Dis_Amt) : null,
                            gross_amt = !string.IsNullOrEmpty(record.Gross_Amt) ? double.Parse(record.Gross_Amt) : null,
                            tot_qty = !string.IsNullOrEmpty(record.Tot_Qty) ? double.Parse(record.Tot_Qty) : null,
                            add_off_site = !string.IsNullOrEmpty(record.B_Add_Off_Site) ? record.B_Add_Off_Site : "",
                            hsn_code = !string.IsNullOrEmpty(record.B_HSN_Code) ? record.B_HSN_Code : "",
                            gst_type = !string.IsNullOrEmpty(record.B_GST_Type) ? record.B_GST_Type : "",
                            state_code = !string.IsNullOrEmpty(record.B_State_Code) ? record.B_State_Code : "",
                            tax_yn = !string.IsNullOrEmpty(record.B_Tax_YN) ? record.B_Tax_YN : "",
                            igst_per = !string.IsNullOrEmpty(record.B_IGST_Per) ? double.Parse(record.B_IGST_Per) : null,
                            igst_amt = !string.IsNullOrEmpty(record.B_IGST_Amt) ? double.Parse(record.B_IGST_Amt) : null,
                            sgst_per = !string.IsNullOrEmpty(record.B_SGST_Per) ? double.Parse(record.B_SGST_Per) : null,
                            sgst_amt = !string.IsNullOrEmpty(record.B_SGST_Amt) ? double.Parse(record.B_SGST_Amt) : null,
                            cgst_per = !string.IsNullOrEmpty(record.B_CGST_Per) ? double.Parse(record.B_CGST_Per) : null,
                            cgst_amt = !string.IsNullOrEmpty(record.B_CGST_Amt) ? double.Parse(record.B_CGST_Amt) : null,

                            reverse_charge = !string.IsNullOrEmpty(record.B_Reverse_Charge) ? record.B_Reverse_Charge : "",
                            electronic_ref_no = !string.IsNullOrEmpty(record.B_Electronic_Ref_No) ? record.B_Electronic_Ref_No : "",
                            ref_2 = !string.IsNullOrEmpty(record.B_REF_2) ? record.B_REF_2 : "",
                            weight_of_one_pcs = !string.IsNullOrEmpty(record.Weight_Per_pcs) ? double.Parse(record.Weight_Per_pcs) : null,
                            tot_weight_of_pcs = !string.IsNullOrEmpty(record.Tot_Weight_of_pcs) ? double.Parse(record.Tot_Weight_of_pcs) : null,
                            manual_billno = !string.IsNullOrEmpty(record.Manual_BillNo) ? record.Manual_BillNo : "",
                            ordno = !string.IsNullOrEmpty(record.ORDNO) ? record.ORDNO : "",
                            ord_date = !string.IsNullOrEmpty(record.ORD_DATE) ? ConvertToDateWithoutTime(record.ORD_DATE) : null,
                            trx_code = !string.IsNullOrEmpty(record.Trx_CODE) ? double.Parse(record.Trx_CODE) : null,
                            trx_name = !string.IsNullOrEmpty(record.Trx_Name) ? record.Trx_Name : "",
                            pkg = !string.IsNullOrEmpty(record.PKG) ? record.PKG : "",
                            c_form = !string.IsNullOrEmpty(record.C_FORM) ? record.C_FORM : "",
                            net_amt = !string.IsNullOrEmpty(record.NET_AMT) ? double.Parse(record.NET_AMT) : null,
                            tot_amt = !string.IsNullOrEmpty(record.tot_amt) ? double.Parse(record.tot_amt) : null,
                            transporter_code = !string.IsNullOrEmpty(record.Transporter_Code) ? record.Transporter_Code : "",
                            fraight = !string.IsNullOrEmpty(record.Fraight) ? record.Fraight : "",
                            site_add = !string.IsNullOrEmpty(record.site_add) ? record.site_add : "",
                            todo = !string.IsNullOrEmpty(record.TODO) ? record.TODO : "",
                            amt_in_wor = !string.IsNullOrEmpty(record.AMT_IN_WOR) ? record.AMT_IN_WOR : "",
                            duedate = !string.IsNullOrEmpty(record.DUEDATE) ? ConvertToDateWithoutTime(record.DUEDATE) : null,
                            round_off_yn = "yes",
                            round_off_amt = !string.IsNullOrEmpty(record.ROUNDOFF) ? double.Parse(record.ROUNDOFF) : null,
                            station_name = !string.IsNullOrEmpty(record.station_Name) ? record.station_Name : "",
                            qty_kg = !string.IsNullOrEmpty(record.Qty_Kg) ? double.Parse(record.Qty_Kg) : null,
                            tot_kg = !string.IsNullOrEmpty(record.Tot_Kg) ? double.Parse(record.Tot_Kg) : null,



                            //cart_amt_transporter = record.cart_amt_transporter

                            // old  
                            //pcode = samp.pcode,
                            //pname = samp.pname,
                            //pname_short_code = samp.pname_short_code,
                            //client_type = samp.client_type,


                            //misc_ac_code = samp.misc_ac_code,
                            //misc_exp_total = samp.misc_exp_total,
                            //stkvalue = samp.stkvalue,
                            //contact_prs = samp.contact_prs,
                            //add1 = samp.add1,
                            //add2 = samp.add2,
                            //add3_location = samp.add3_location,
                            //add4_city = samp.add4_city,
                            //add5_state = samp.add5_state,
                            //add6_pincode = samp.add6_pincode,
                            //add7_state_code = samp.add7_state_code,
                            //country_name = samp.country_name,
                            //addr_type = samp.addr_type,
                            //addr_gst_type = samp.addr_gst_type,
                            //gstno = samp.gstno,
                            //rent_on_type = samp.rent_on_type,
                            //opening_qty = samp.opening_qty,
                            //issued_bal_on_chal_date = samp.issued_bal_on_chal_date,
                            //unique_number = samp.unique_number,
                            //contact_prs_whts_no = samp.contact_prs_whts_no,
                            //irflag_detail = samp.irflag_detail,
                            //final_amount = samp.final_amount,
                        };
                        DB.IssueReceiptMaster.Add(SampData);
                        DB.SaveChanges();

                        challanMasterId = SampData.id;
                    }
                    else
                    {
                        challanMasterId = checkIssueChallan.id;
                    }



                    IssueReceiptTransDetail SampData1 = new IssueReceiptTransDetail
                    {
                        challan_master_id = challanMasterId,
                        // pcode = key.pcode,
                        pname = !string.IsNullOrEmpty(record.agr_name) ? record.agr_name : "",
                        //item_code = !string.IsNullOrEmpty(record.Item_code) ? long.Parse(record.Item_code) : null,
                        item_short_name = !string.IsNullOrEmpty(record.item_Short_name) ? record.item_Short_name : "",
                        item_name = !string.IsNullOrEmpty(record.itemname) ? record.itemname : "",
                        item_group_code = !string.IsNullOrEmpty(record.Item_group_code) ? long.Parse(record.Item_group_code) : null,
                        item_group_name = !string.IsNullOrEmpty(record.item_group_name) ? record.item_group_name : "",
                        issue_qty = !string.IsNullOrEmpty(record.issue_qty) ? double.Parse(record.issue_qty) : null,
                        recv_qty = !string.IsNullOrEmpty(record.recv_qty) ? double.Parse(record.recv_qty) : null,
                        irflag = !string.IsNullOrEmpty(record.irflag) ? record.irflag : "",
                        rent_rate = !string.IsNullOrEmpty(record.rate) ? double.Parse(record.rate) : null,
                        //unit_name = key.unit_name,
                        // itemtype = key.itemtype,
                        //rate_of_one_pcs = key.rate_of_one_pcs,
                        //weight_of_one_pcs = key.weight_of_one_pcs,
                        // unique_number = samp.unique_number,
                        // opening_qty = key.opening_qty,
                        //aggrement_id = checkAggrement.id,
                        //item_scheme_type_one_pc = key.item_scheme_type_one_pc
                    };
                    DB.IssueReceiptTransDetail.Add(SampData1);
                    DB.SaveChanges();




                    //IssueReceiptMiscTransDetail SampData2 = new IssueReceiptMiscTransDetail
                    //{
                    //    challan_master_id = challanMasterId,
                    //    bill_no_automatic = !string.IsNullOrEmpty(record.BillNo_Automatic) ? long.Parse(record.BillNo_Automatic) : null,
                    //    //pcode = key.pcode,
                    //    //pname = key.pname,
                    //    //agr_code_old = key.agr_code_old,
                    //    ch_no = !string.IsNullOrEmpty(record.challanno) ? record.challanno :  "",
                    //    bill_date = ConvertToDateWithoutTime(record.Bill_Date),
                    //    //exp_ac_name = key.exp_ac_name,
                    //    //exp_amt = key.exp_amt,
                    //    //exp_remarks = key.exp_remarks,
                    //    //ir_flag = key.ir_flag,
                    //    //fo_oh = key.fo_oh,

                    //};
                    //DB.IssueReceiptMiscTransDetail.Add(SampData2);
                    //DB.SaveChanges();


                    IssueReceiptBreakageTransDetail SampData3 = new IssueReceiptBreakageTransDetail
                    {
                        challan_master_id = challanMasterId,
                        challan_trans_id = SampData1.id,
                        rate = !string.IsNullOrEmpty(record.brok_rate) ? double.Parse(record.brok_rate) : null,
                        qty = !string.IsNullOrEmpty(record.brok_qty) ? double.Parse(record.brok_qty) : null,
                        amt = !string.IsNullOrEmpty(record.broken_amt) ? double.Parse(record.broken_amt) : null,
                        //narr = breakageKey.narr,
                        //damage = breakageKey.damage,
                        //missing = breakageKey.missing,
                        //item_name = breakageKey.item_name,
                        // unique_number = samp.unique_number
                    };

                    DB.IssueReceiptBreakageTransDetail.Add(SampData3);
                    DB.SaveChanges();

                }

            }

            if (flagName == "issuechallanMisc")
            {
                foreach (var record in fileData)
                {
                    string challanNo = record.CH_NO;
                    var checkIssueChallan = DB.IssueReceiptMaster.Where(e => e.challanno == challanNo).FirstOrDefault();

                    IssueReceiptMiscTransDetail SampData2 = new IssueReceiptMiscTransDetail
                    {
                        challan_master_id = checkIssueChallan.id,
                        bill_no_automatic = !string.IsNullOrEmpty(record.BillNo_Automatic) ? long.Parse(record.BillNo_Automatic) : null,
                        //pcode = key.pcode,
                        //pname = key.pname,
                        agr_code_old = record.AGR_CODE,
                        ch_no = !string.IsNullOrEmpty(record.CH_NO) ? record.CH_NO : "",
                        bill_date = ConvertToDateWithoutTime(record.BILL_DATE),
                        exp_ac_name = !string.IsNullOrEmpty(record.EXP_AC_NAME) ? record.EXP_AC_NAME : "",
                        exp_amt = !string.IsNullOrEmpty(record.EXP_AMT) ? long.Parse(record.EXP_AMT) : null,
                        exp_remarks = !string.IsNullOrEmpty(record.EXP_AMT) ? record.EXP_REMARKS : "",
                        ir_flag = !string.IsNullOrEmpty(record.EXP_AMT) ? record.IRflag : "",
                        fo_oh = !string.IsNullOrEmpty(record.EXP_AMT) ? record.FO_OH : "",

                    };
                    DB.IssueReceiptMiscTransDetail.Add(SampData2);
                    DB.SaveChanges();
                }
            }


            CommonMasterResp data = new CommonMasterResp()
            {
                status = true,
                Message = "File upload successfully"
            };
            return data;
        }

        public static DateTime? ConvertToDateWithoutTime(string dateTimeString)
        {
            if (DateTime.TryParse(dateTimeString, out DateTime dateTime))
            {
                return dateTime.Date;
            }
            else
            {
                return null; // or return DateTime.MinValue;
            }
        }



        public CommonMasterResp AllDeleteDataCommonMaster(string? flagName)
        {

            if (flagName == "party")
            {
                DB.PartyItemRateTrans.RemoveRange(DB.PartyItemRateTrans.ToList());
                DB.PartyContactTransMaster.RemoveRange(DB.PartyContactTransMaster.ToList());
                DB.PartyAddressTransMaster.RemoveRange(DB.PartyAddressTransMaster.ToList());
                DB.Remark_Upload_Detail.RemoveRange(DB.Remark_Upload_Detail.ToList());
                DB.AggrementMaster.RemoveRange(DB.AggrementMaster.ToList());
                DB.PartyMaster.RemoveRange(DB.PartyMaster.ToList());
                DB.SaveChanges();
            }

            if (flagName == "partycategory")
            {
                DB.PartyCategoryMaster.RemoveRange(DB.PartyCategoryMaster.ToList());
                DB.SaveChanges();

            }

            if (flagName == "case")
            {
                DB.CaseHireMaster.RemoveRange(DB.CaseHireMaster.ToList());
                DB.Guarantor1Detail.RemoveRange(DB.Guarantor1Detail.ToList());
                DB.Guarantor2Detail.RemoveRange(DB.Guarantor2Detail.ToList());
                DB.RecieptDetail.RemoveRange(DB.RecieptDetail.ToList());
                DB.ExtraDetail.RemoveRange(DB.ExtraDetail.ToList());
                DB.EMIDetail.RemoveRange(DB.EMIDetail.ToList());
                DB.UploadDocument.RemoveRange(DB.UploadDocument.ToList());
                DB.PartyContactTransMaster.RemoveRange(DB.PartyContactTransMaster.ToList());
                DB.PartyAddressTransMaster.RemoveRange(DB.PartyAddressTransMaster.ToList());
                DB.CaseMaster.RemoveRange(DB.CaseMaster.ToList());
                DB.SaveChanges();
            }


            if (flagName == "item")
            {
                DB.ItemTransStockDetail.RemoveRange(DB.ItemTransStockDetail.ToList());
                DB.ItemTransMixDetail.RemoveRange(DB.ItemTransMixDetail.ToList());
                DB.AggrementMaster.RemoveRange(DB.AggrementMaster.ToList());
                DB.Location_Master.RemoveRange(DB.Location_Master.ToList());
                DB.Remark_Upload_Detail.RemoveRange(DB.Remark_Upload_Detail.ToList());
                DB.IssueReceiptTransDetail.RemoveRange(DB.IssueReceiptTransDetail.ToList());
                DB.ItemMaster.RemoveRange(DB.ItemMaster.ToList());
                DB.SaveChanges();
            }


            if (flagName == "issue")
            {
                DB.IssueReceiptMiscTransDetail.RemoveRange(DB.IssueReceiptMiscTransDetail.ToList());
                DB.IssueItemExtraDetail.RemoveRange(DB.IssueItemExtraDetail.ToList());
                DB.IssueReceiptBreakageTransDetail.RemoveRange(DB.IssueReceiptBreakageTransDetail.ToList());
                DB.IssueReceiptTransDetail.RemoveRange(DB.IssueReceiptTransDetail.ToList());
                DB.Challan_Single_Item_Master.RemoveRange(DB.Challan_Single_Item_Master.ToList());
                DB.IssueReceiptMaster.RemoveRange(DB.IssueReceiptMaster.ToList());
                DB.SaveChanges();
            }


            if (flagName == "voucher")
            {
                DB.vou_trn_master.RemoveRange(DB.vou_trn_master.ToList());
                DB.vou_master.RemoveRange(DB.vou_master.ToList());
                DB.SaveChanges();
            }

            if (flagName == "rent_bill")
            {
                DB.Bill_Rent_Master.RemoveRange(DB.Bill_Rent_Master.ToList());
                DB.SaveChanges();
            }

            CommonMasterResp data = new CommonMasterResp()
            {
                status = true,
                Message = "All Delete Successfully"
            };
            return data;
        }

        public List<dynamic> CalculateEmiData(
             double loanAmount, double principal,
             double monthlyInterest,
             int totalMonths, bool roundOff,
             long? caseMasterId,
             DateTime currentDate
            )
        {

            List<dynamic> emiDataArray = new List<dynamic>();
            double remainingBalance = loanAmount;

            // TO DO SETUP THE INTEERATE RATE CODE AND CONDITION
            var monthlyInterestRates = (monthlyInterest) / 12 / 100;


            for (int i = 0; i < totalMonths; i++)
            {
                double interestAmount = loanAmount * monthlyInterestRates;
                double totalPayment = interestAmount + (principal / totalMonths);
                remainingBalance -= (principal / totalMonths);

                //string paymentDate = currentDate;

                EMIDetail emiObject = new EMIDetail
                {
                    Case_Master_id = caseMasterId,
                    emi_PaymentDate = currentDate,
                    emi_Monthly_Amount = roundOff ? Math.Round(principal / totalMonths).ToString() : (principal / totalMonths).ToString(),
                    emi_Interest_Amount = roundOff ? Math.Round(interestAmount).ToString() : interestAmount.ToString(),
                    emi_Monthly_Interest_Amount = roundOff ? Math.Round(totalPayment).ToString() : totalPayment.ToString(),
                    // remainingBalance = remainingBalance // Uncomment if you want to include this in EmiObject
                };


                currentDate = currentDate.AddMonths(1);
                if (currentDate.Month >= 13)
                {
                    currentDate = currentDate.AddYears(1); // Increment current date by one year
                }

                //emiDataArray.Add(emiObject);
                DB.EMIDetail.Add(emiObject);
            }
            DB.SaveChanges();

            return emiDataArray;
        }


        public CommonMasterResp GetAllBalanceSheetData()
        {

            CommonMasterResp data = new()
            {
                status = true,
                Message = "data fetched successfully",
                BalanceSheetMasterData = DB.balance_sheet_master.ToList()
            };

            return data;
        }

        public CommonMasterResp CheckDuplicateEntry(string flagName, string flagValue)
        {
            bool isDuplicate = false;
            string entityName = "";

            if (flagName == "partyCategory")
            {
                isDuplicate = DB.PartyCategoryMaster.Any(e => e.category_name == flagValue.Trim());
                entityName = $"Party Category name '{flagValue.Trim()}'";
            }
            else if (flagName == "itemCategory")
            {
                isDuplicate = DB.CategoryMaster.Any(e => e.category_name == flagValue.Trim());
                entityName = $"Item Category name '{flagValue.Trim()}'";

            }
            else if (flagName == "dailytask")
            {
                isDuplicate = DB.DailyTask.Any(e => e.task_title == flagValue.Trim());
                entityName = $"Daily Task name '{flagValue.Trim()}'";

            }

            CommonMasterResp data = new();
            if (isDuplicate)
            {

                data.status = false;
                data.Message = $"{entityName} already exists.";
                data.duplicate = isDuplicate;
            }

            return data;
        }



    }
}