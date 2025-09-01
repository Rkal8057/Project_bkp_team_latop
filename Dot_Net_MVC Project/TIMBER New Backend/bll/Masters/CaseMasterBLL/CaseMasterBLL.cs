using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RTA.Masters
{

    public class CaseMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public CaseMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public CaseMasterResp GetAllCaseMaster(int pageNo, int limit, string searchKey)
        {


            IQueryable<CaseMaster> query = DB.CaseMaster
                .Include(e => e.PartyAddressTransMaster)
                .Include(e => e.PartyContactTransMaster)

                 /*.Include(e => e.CaseHireMaster)
                 .Include(e => e.Guarantor1Detail)
                 .Include(e => e.Guarantor2Detail)
                 .Include(e => e.RecieptDetail)*/
                 .Include(e => e.ExtraDetail)
                 .Include(e => e.EMIDetail)
                 .Include(e => e.UploadDocument);
            
                 if (!string.IsNullOrEmpty(searchKey))
                 {
                     query = query.Where(e =>
                        EF.Functions.Like(e.Case_Case_No, $"%{searchKey}%") ||
                        EF.Functions.Like(e.Case_Financed_Item, $"%{searchKey}%") ||
                        EF.Functions.Like(e.Hire_Name, $"%{searchKey}%") ||
                        EF.Functions.Like(e.Case_Duration_Value, $"%{searchKey}%"));
                 }
             
                int totalCount = query.Count();
                int totalPages = (int)Math.Ceiling((double)totalCount / limit);
                int skip;
                if (pageNo != 1)
                {
                    skip = (pageNo - 1) * limit;
                }
                else
                {
                    skip = 0;
                }



            var pagedQuery = query.Skip(skip).Take(limit).ToList();

            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CaseMasterData = pagedQuery
               /* TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,*/

            };
            return data;
        }

        public CaseMasterResp GetCaseMasterById(long id)
        {

            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CaseMasterByID = DB.CaseMaster
                .Include(e => e.PartyAddressTransMaster)
                .Include(e => e.PartyContactTransMaster)

                 /*.Include(e => e.CaseHireMaster)
                .Include(e => e.Guarantor1Detail)
                .Include(e => e.Guarantor2Detail)
                .Include(e => e.RecieptDetail)*/
                 .Include(e => e.ExtraDetail)
                 .Include(e => e.EMIDetail)
                 .Include(e => e.UploadDocument)
                 .Where(e => e.id == id)
                 .FirstOrDefault()

            };

            return data;
        }

        public CaseMasterResp InsertCaseMaster(CaseMasterReq samp)
        {

            CaseMaster SampData = new CaseMaster()
            {
                Case_Financed_Item = samp.Case_Financed_Item,
                Case_Finance_Amt = samp.Case_Finance_Amt,
                Case_Duration_Type = samp.Case_Duration_Type,
                Case_Duration_Value = samp.Case_Duration_Value,
                Case_Instalments = samp.Case_Instalments,
                Case_Montly_Amt = samp.Case_Montly_Amt,
                Case_Total_Amt_Due = samp.Case_Total_Amt_Due,
                Case_Total_Cost = samp.Case_Total_Cost,
                Case_ADVANCE_REQ = samp.Case_ADVANCE_REQ,
                Case_TOTAL_ADV_REQ = samp.Case_TOTAL_ADV_REQ,
                Case_Due_Date = samp.Case_Due_Date,
                Case_Payment_By = samp.Case_Payment_By,
                Case_Chq_NO = samp.Case_Chq_NO,
                Case_Case_Remark = samp.Case_Case_Remark,
                Case_F_O_CHARGE = samp.Case_F_O_CHARGE,
                Case_Total_hp = samp.Case_Total_hp,
                Case_X = samp.Case_X,
                Case_Rate_of_Interest = samp.Case_Rate_of_Interest,
                Case_hp = samp.Case_hp,
                Case_Extra_Inst = samp.Case_Extra_Inst,
                Case_Instalments_By = samp.Case_Instalments_By,
                Case_Finance_Amt_2 = samp.Case_Finance_Amt_2,
                Case_Pending_Amt = samp.Case_Pending_Amt,
                Case_end_Date = samp.Case_end_Date,
                Case_Manual_Lg = samp.Case_Manual_Lg,
                Case_Dealer_Name = samp.Case_Dealer_Name,
                Case_Curr_Date = samp.Case_Curr_Date,
                Case_Case_No = samp.Case_Case_No,
                Case_Case_stage = samp.Case_Case_stage,
                Case_Ac_Close = samp.Case_Ac_Close,
                Case_Ac_Close_Date = samp.Case_Ac_Close_Date,
                Case_Block_YN = samp.Case_Block_YN,
                Case_Interest_type = samp.Case_Interest_type,
                Hire_Name = samp.Hire_Name,
                Hire_SWH_Name = samp.Hire_SWH_Name,
                Case_Financed_Type = samp.Case_Financed_Type,
                Case_Finance_Company = samp.Case_Finance_Company,
                Case_Relation_Type = samp.Case_Relation_Type,
                Case_RoundOff_yn = samp.Case_RoundOff_yn,
                Case_F_O_Select = samp.Case_F_O_Select,

            };

            DB.CaseMaster.Add(SampData);
            DB.SaveChanges();


            // part master  insert start 
            PartyMaster PSampData = new PartyMaster()
            {
                name = samp.Hire_Name,
                party_group_category_name = "Debtors"
                //group = "debtors",
                //email = samp.email,
                //mobile_number = samp.mobile_number,
                //address = samp.address,
                //pincode = samp.pincode,
                //hire_status = samp.hire_status,
                //agreement_start_date = samp.agreement_start_date,
                //agreement_end_date = samp.agreement_end_date,
                //type_of_service = samp.type_of_service,
                //bill_type = samp.bill_type,
                //security_amount = samp.security_amount,
                //tax_type = samp.tax_type,
                //percentage = samp.percentage,
                //dr = samp.dr,
                //gstin = samp.gstin,
                //ref_by = samp.ref_by,
                //party_company_name = samp.party_company_name,
                //party_group_category_name = samp.party_group_category_name,
                //ref_commission = samp.ref_commission,
                //party_agr_code = samp.party_agr_code,


                //GSTIN_No = samp.GSTIN_No,
                //Pay_Term_Days = samp.Pay_Term_Days,
                //Addhar_No = samp.Addhar_No,
                //PAN_NO = samp.PAN_NO,
                //Ac_Opening_Date = samp.Ac_Opening_Date,
                //Op_Bal = samp.Op_Bal,
                //Dr_Cr = samp.Dr_Cr,

                //DL_NO = samp.DL_NO,
                //martital_status = samp.martital_status,
                //gender = samp.gender,
                //dob = samp.dob,
                //anniversary = samp.anniversary,
                //loyalty = samp.loyalty,
                //important = samp.important,
                //party_group_category_id = samp.party_group_category_id
            };

            DB.PartyMaster.Add(PSampData);
            DB.SaveChanges();

            //CaseHireMaster SampData1 = new CaseHireMaster()
            //{
            //    Case_Master_id = SampData.id,
            //    Hire_Name = samp.Hire_Name,
            //    Hire_SWH_Name = samp.Hire_SWH_Name,
            //    Hire_Resi_Address = samp.Hire_Resi_Address,
            //    Hire_Ph_No = samp.Hire_Ph_No,
            //    Hire_Company_Name = samp.Hire_Company_Name,
            //    Hire_Off_Ph_Nos = samp.Hire_Off_Ph_Nos,
            //    Hire_Off_Address = samp.Hire_Off_Address,
            //    Hire_Ph_No2 = samp.Hire_Ph_No2,
            //    Hire_Post = samp.Hire_Post,
            //    Hire_Profession = samp.Hire_Profession,
            //    Hire_Area = samp.Hire_Area,
            //    Hire_Location = samp.Hire_Location,
            //    Hire_Email = samp.Hire_Email,
            //    Hire_Whatsapp_Phone = samp.Hire_Whatsapp_Phone,
            //};
            //DB.CaseHireMaster.Add(SampData1);
            //DB.SaveChanges();


            //Guarantor1Detail SampData2 = new Guarantor1Detail
            //{
            //    Case_Master_id = SampData.id,
            //    guarantor1_Name = samp.guarantor1_Name,
            //    guarantor1_SWH_Name = samp.guarantor1_SWH_Name,
            //    guarantor1_Resi_Address = samp.guarantor1_Resi_Address,
            //    guarantor1_Phones_No = samp.guarantor1_Phones_No,
            //    guarantor1_Company_Name = samp.guarantor1_Company_Name,
            //    guarantor1_Off_Address = samp.guarantor1_Off_Address,
            //    guarantor1_Off_Phone_No = samp.guarantor1_Off_Phone_No
            //};

            //DB.Guarantor1Detail.Add(SampData2);
            //DB.SaveChanges();


            //Guarantor2Detail SampData3 = new Guarantor2Detail
            //{
            //    Case_Master_id = SampData.id,
            //    guarantor2_Name = samp.guarantor2_Name,
            //    guarantor2_SWH_Name = samp.guarantor2_SWH_Name,
            //    guarantor2_Resi_Address = samp.guarantor2_Resi_Address,
            //    guarantor2_Phones_No = samp.guarantor2_Phones_No,
            //    guarantor2_Company_Name = samp.guarantor2_Company_Name,
            //    guarantor2_Off_Address = samp.guarantor2_Off_Address,
            //    guarantor2_Off_Phone_No = samp.guarantor2_Off_Phone_No
            //};
            //DB.Guarantor2Detail.Add(SampData3);
            //DB.SaveChanges();


            foreach (var item in samp.caseAddressTranskey)
            {
                PartyAddressTransMaster SampData1 = new PartyAddressTransMaster()
                {
                    party_master_id = PSampData.id,
                    party_address_1 = item.party_address_1,
                    party_address_2 = item.party_address_2,
                    party_pincode = item.party_pincode,
                    party_state = item.party_state,
                    party_country = item.party_country,
                    party_address_description = item.party_address_description,

                    party_gst_type = item.party_gst_type,
                    party_gst_code = item.party_gst_code,
                    party_gst_address_no = item.party_gst_address_no,
                    party_address_location = item.party_address_location,
                    case_master_id = SampData.id,
                    party_address_area_code = item.party_address_area_code

                };
                DB.PartyAddressTransMaster.Add(SampData1);
                DB.SaveChanges();
            }

            foreach (var item in samp.caseConactTranskey)
            {
                PartyContactTransMaster SampData2 = new PartyContactTransMaster()
                {
                    party_master_id = PSampData.id,
                    party_contact_name = item.party_contact_name,
                    party_contact_mobile = item.party_contact_mobile,
                    party_contact_whatsapp_mobile = item.party_contact_whatsapp_mobile,
                    party_contact_email = item.party_contact_email,
                    party_contact_description = item.party_contact_description,

                    party_contact_department = item.party_contact_department,
                    party_contact_designation = item.party_contact_designation,
                    party_contact_website = item.party_contact_website,
                    party_contact_twitter_id = item.party_contact_twitter_id,
                    party_contact_fb_id = item.party_contact_fb_id,
                    party_contact_youtube_id = item.party_contact_youtube_id,
                    party_landline_no = item.party_landline_no,
                    party_contact_instagram_id = item.party_contact_instagram_id,
                    case_master_id = SampData.id

                };
                DB.PartyContactTransMaster.Add(SampData2);
                DB.SaveChanges();
            }

            RecieptDetail SampData4 = new RecieptDetail
            {
                Case_Master_id = SampData.id,
                receipt_System_Bill_No = samp.receipt_System_Bill_No,
                receipt_Case_No = samp.receipt_Case_No,
                receipt_Instalment_No = samp.receipt_Instalment_No,
                receipt_Due_Date = samp.receipt_Due_Date,
                receipt_Deposit_Date = samp.receipt_Deposit_Date,
                receipt_Receipt_No = samp.receipt_Receipt_No,
                receipt_Receipt_Date = samp.receipt_Receipt_Date,
                receipt_Party_Name = samp.receipt_Party_Name,
                receipt_Due_Amt = samp.receipt_Due_Amt,
                receipt_No_of_Inst_of_Int = samp.receipt_No_of_Inst_of_Int,
                receipt_Rec_Amt = samp.receipt_Rec_Amt,
                receipt_By_Cash_Bank = samp.receipt_By_Cash_Bank,
                receipt_Cheque_No = samp.receipt_Cheque_No,
                receipt_Chq_Deposit = samp.receipt_Chq_Deposit,
                receipt_Bank_Chgs_Amt = samp.receipt_Bank_Chgs_Amt,
                receipt_Late_Bounse = samp.receipt_Late_Bounse,
                receipt_Remark = samp.receipt_Remark,
                receipt_Current_Date = samp.receipt_Current_Date,
                receipt_A_c_Close = samp.receipt_A_c_Close,
                receipt_Close_Date = samp.receipt_Close_Date,
                receipt_Case_Type = samp.receipt_Case_Type,
                receipt_Pric1 = samp.receipt_Pric1,
                receipt_Hp1 = samp.receipt_Hp1,
                receipt_Pric2 = samp.receipt_Pric2,
                receipt_Hp2 = samp.receipt_Hp2,
                Chq_Bounce = samp.Chq_Bounce,
                receipt_Bank_Chgs_Amt_Rec = samp.receipt_Bank_Chgs_Amt_Rec,
                receipt_Late_Boun_Rec = samp.receipt_Late_Boun_Rec
            };
            DB.RecieptDetail.Add(SampData4);
            DB.SaveChanges();

            ExtraDetail SampData5 = new ExtraDetail
            {
                Case_Master_id = SampData.id,
                extra_Registration_No = samp.extra_Registration_No,
                extra_Hirer_Name = samp.extra_Hirer_Name,
                extra_Item_Type = samp.extra_Item_Type,
                extra_Manufacturer = samp.extra_Manufacturer,
                extra_Model_Name = samp.extra_Model_Name,
                extra_Year_of_Registration = samp.extra_Year_of_Registration,
                extra_RC_Given = samp.extra_RC_Given,
                extra_RC_Taken_By = samp.extra_RC_Taken_By,
                extra_Chassis_No = samp.extra_Chassis_No,
                extra_Engine_No = samp.extra_Engine_No,
                extra_NOC_Made = samp.extra_NOC_Made,
                extra_Taken_By = samp.extra_Taken_By,
                extra_Addhaar_No = samp.extra_Addhaar_No,
                extra_Pan_Card_No = samp.extra_Pan_Card_No,
                extra_DL_No = samp.extra_DL_No,
                extra_Case_No = samp.extra_Case_No,
                extra_RC_Given_Date = samp.extra_RC_Given_Date,
                extra_Date = samp.extra_Date,
                extra_Date_Taken_By = samp.extra_Date_Taken_By
            };
            DB.ExtraDetail.Add(SampData5);
            DB.SaveChanges();

            if (samp.EmiKeys != null)
            {
                foreach (var item in samp.EmiKeys)
                {
                    EMIDetail SampData6 = new EMIDetail
                    {
                        Case_Master_id = SampData.id,
                        emi_PaymentDate = item.emi_PaymentDate,
                        emi_Monthly_Amount = item.emi_Monthly_Amount,
                        emi_Interest_Amount = item.emi_Interest_Amount,
                        emi_Monthly_Interest_Amount = item.emi_Monthly_Interest_Amount
                    };
                    DB.EMIDetail.Add(SampData6);
                }
                DB.SaveChanges();
            }

            if (samp.UploadDocumentKey != null)
            {
                foreach (var item in samp.UploadDocumentKey)
                {
                    UploadDocument SampData6 = new UploadDocument
                    {
                        Case_Master_id = SampData.id,
                        upload_document_name = item.upload_document_name,
                        upload_document_path = item.upload_document_path,
                    };
                    DB.UploadDocument.Add(SampData6);
                }
                DB.SaveChanges();
            }

          


            //foreach (var key in samp.Remark_Upload_Detail_Key)
            //{
            //    Remark_Upload_Detail SampData3 = new Remark_Upload_Detail
            //    {
            //        upload_document_path = key.upload_document_path,
            //        attended_by = key.attended_by,
            //        remarks = key.remarks,
            //        party_master_id = SampData.id,
            //        flag_master = "party"
            //    };

            //    DB.Remark_Upload_Detail.Add(SampData3);
            //}

            DB.SaveChanges();


            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public CaseMasterResp UpdateCaseMaster(long ID, CaseMasterReq samp)
        {
            CaseMaster existingEntity = DB.CaseMaster
                //.Include(e => e.CaseHireMaster)
                //.Include(e => e.Guarantor1Detail)
                //.Include(e => e.Guarantor2Detail)
                //.Include(e => e.RecieptDetail)
                .Include(e => e.ExtraDetail)
                .Include(e => e.EMIDetail).Include(e => e.UploadDocument)
                .FirstOrDefault(e => e.id == ID);

            if (existingEntity != null)
            {
                existingEntity.Case_Financed_Item = samp.Case_Financed_Item;
                existingEntity.Case_Finance_Amt = samp.Case_Finance_Amt;
                existingEntity.Case_Duration_Type = samp.Case_Duration_Type;
                existingEntity.Case_Duration_Value = samp.Case_Duration_Value;
                existingEntity.Case_Instalments = samp.Case_Instalments;
                existingEntity.Case_Montly_Amt = samp.Case_Montly_Amt;
                existingEntity.Case_Total_Amt_Due = samp.Case_Total_Amt_Due;
                existingEntity.Case_Total_Cost = samp.Case_Total_Cost;
                existingEntity.Case_ADVANCE_REQ = samp.Case_ADVANCE_REQ;
                existingEntity.Case_TOTAL_ADV_REQ = samp.Case_TOTAL_ADV_REQ;
                existingEntity.Case_Due_Date = samp.Case_Due_Date;
                existingEntity.Case_Payment_By = samp.Case_Payment_By;
                existingEntity.Case_Chq_NO = samp.Case_Chq_NO;
                existingEntity.Case_Case_Remark = samp.Case_Case_Remark;
                existingEntity.Case_Interest_type = samp.Case_Interest_type;
                existingEntity.Case_F_O_CHARGE = samp.Case_F_O_CHARGE;
                existingEntity.Case_Total_hp = samp.Case_Total_hp;
                existingEntity.Case_X = samp.Case_X;
                existingEntity.Case_Rate_of_Interest = samp.Case_Rate_of_Interest;
                existingEntity.Case_hp = samp.Case_hp;
                existingEntity.Case_Extra_Inst = samp.Case_Extra_Inst;
                existingEntity.Case_Instalments_By = samp.Case_Instalments_By;
                existingEntity.Case_Finance_Amt_2 = samp.Case_Finance_Amt_2;
                existingEntity.Case_Pending_Amt = samp.Case_Pending_Amt;
                existingEntity.Case_end_Date = samp.Case_end_Date;
                existingEntity.Case_Manual_Lg = samp.Case_Manual_Lg;
                existingEntity.Case_Dealer_Name = samp.Case_Dealer_Name;
                existingEntity.Case_Curr_Date = samp.Case_Curr_Date;
                existingEntity.Case_Case_No = samp.Case_Case_No;
                existingEntity.Case_Case_stage = samp.Case_Case_stage;
                existingEntity.Case_Ac_Close = samp.Case_Ac_Close;
                existingEntity.Case_Ac_Close_Date = samp.Case_Ac_Close_Date;
                existingEntity.Case_Block_YN = samp.Case_Block_YN;
                existingEntity.Case_Financed_Type = samp.Case_Financed_Type;
                existingEntity.Case_Finance_Company = samp.Case_Finance_Company;
                existingEntity.Case_Relation_Type = samp.Case_Relation_Type;
                existingEntity.Case_RoundOff_yn = samp.Case_RoundOff_yn;
                existingEntity.Case_F_O_Select = samp.Case_F_O_Select;




                if (existingEntity.RecieptDetail != null)
                {
                    RecieptDetail recieptDetailToUpdate = existingEntity.RecieptDetail.FirstOrDefault(h => h.Case_Master_id == existingEntity.id);

                    if (recieptDetailToUpdate != null)
                    {
                        recieptDetailToUpdate.receipt_System_Bill_No = samp.receipt_System_Bill_No;
                        recieptDetailToUpdate.receipt_Case_No = samp.receipt_Case_No;
                        recieptDetailToUpdate.receipt_Instalment_No = samp.receipt_Instalment_No;
                        recieptDetailToUpdate.receipt_Due_Date = samp.receipt_Due_Date;
                        recieptDetailToUpdate.receipt_Deposit_Date = samp.receipt_Deposit_Date;
                        recieptDetailToUpdate.receipt_Receipt_No = samp.receipt_Receipt_No;
                        recieptDetailToUpdate.receipt_Receipt_Date = samp.receipt_Receipt_Date;
                        recieptDetailToUpdate.receipt_Party_Name = samp.receipt_Party_Name;
                        recieptDetailToUpdate.receipt_Due_Amt = samp.receipt_Due_Amt;
                        recieptDetailToUpdate.receipt_No_of_Inst_of_Int = samp.receipt_No_of_Inst_of_Int;
                        recieptDetailToUpdate.receipt_Rec_Amt = samp.receipt_Rec_Amt;
                        recieptDetailToUpdate.receipt_By_Cash_Bank = samp.receipt_By_Cash_Bank;
                        recieptDetailToUpdate.receipt_Cheque_No = samp.receipt_Cheque_No;
                        recieptDetailToUpdate.receipt_Chq_Deposit = samp.receipt_Chq_Deposit;
                        recieptDetailToUpdate.receipt_Bank_Chgs_Amt = samp.receipt_Bank_Chgs_Amt;
                        recieptDetailToUpdate.receipt_Late_Bounse = samp.receipt_Late_Bounse;
                        recieptDetailToUpdate.receipt_Remark = samp.receipt_Remark;
                        recieptDetailToUpdate.receipt_Current_Date = samp.receipt_Current_Date;
                        recieptDetailToUpdate.receipt_A_c_Close = samp.receipt_A_c_Close;
                        recieptDetailToUpdate.receipt_Close_Date = samp.receipt_Close_Date;
                        recieptDetailToUpdate.receipt_Case_Type = samp.receipt_Case_Type;
                        recieptDetailToUpdate.receipt_Pric1 = samp.receipt_Pric1;
                        recieptDetailToUpdate.receipt_Hp1 = samp.receipt_Hp1;
                        recieptDetailToUpdate.receipt_Pric2 = samp.receipt_Pric2;
                        recieptDetailToUpdate.receipt_Hp2 = samp.receipt_Hp2;
                        recieptDetailToUpdate.Chq_Bounce = samp.Chq_Bounce;
                        recieptDetailToUpdate.receipt_Bank_Chgs_Amt_Rec = samp.receipt_Bank_Chgs_Amt_Rec;
                        recieptDetailToUpdate.receipt_Late_Boun_Rec = samp.receipt_Late_Boun_Rec;

                    }

                }

                if (existingEntity.ExtraDetail != null)
                {
                    ExtraDetail extraDetailToUpdate = existingEntity.ExtraDetail.FirstOrDefault(h => h.Case_Master_id == existingEntity.id);

                    if (extraDetailToUpdate != null)
                    {
                        extraDetailToUpdate.extra_Registration_No = samp.extra_Registration_No;
                        extraDetailToUpdate.extra_Hirer_Name = samp.extra_Hirer_Name;
                        extraDetailToUpdate.extra_Item_Type = samp.extra_Item_Type;
                        extraDetailToUpdate.extra_Manufacturer = samp.extra_Manufacturer;
                        extraDetailToUpdate.extra_Model_Name = samp.extra_Model_Name;
                        extraDetailToUpdate.extra_Year_of_Registration = samp.extra_Year_of_Registration;
                        extraDetailToUpdate.extra_RC_Given = samp.extra_RC_Given;
                        extraDetailToUpdate.extra_RC_Taken_By = samp.extra_RC_Taken_By;
                        extraDetailToUpdate.extra_Chassis_No = samp.extra_Chassis_No;
                        extraDetailToUpdate.extra_Engine_No = samp.extra_Engine_No;
                        extraDetailToUpdate.extra_NOC_Made = samp.extra_NOC_Made;
                        extraDetailToUpdate.extra_Taken_By = samp.extra_Taken_By;
                        extraDetailToUpdate.extra_Addhaar_No = samp.extra_Addhaar_No;
                        extraDetailToUpdate.extra_Pan_Card_No = samp.extra_Pan_Card_No;
                        extraDetailToUpdate.extra_DL_No = samp.extra_DL_No;
                        extraDetailToUpdate.extra_Case_No = samp.extra_Case_No;
                        extraDetailToUpdate.extra_RC_Given_Date = samp.extra_RC_Given_Date;
                        extraDetailToUpdate.extra_Date = samp.extra_Date;
                        extraDetailToUpdate.extra_Date_Taken_By = samp.extra_Date_Taken_By;
                    }
                }


                if (existingEntity.EMIDetail != null)
                {

                    foreach (var updatedEmilist in samp.EmiKeys)
                    {
                        var existingemilist = existingEntity.EMIDetail.FirstOrDefault(cl => cl.Id == updatedEmilist.Id);

                        if (existingemilist != null)
                        {
                            existingemilist.emi_PaymentDate = updatedEmilist.emi_PaymentDate;
                            existingemilist.emi_Monthly_Amount = updatedEmilist.emi_Monthly_Amount;
                            existingemilist.emi_Interest_Amount = updatedEmilist.emi_Monthly_Interest_Amount;
                            existingemilist.emi_Monthly_Interest_Amount = updatedEmilist.emi_Interest_Amount;
                        }
                        else
                        {
                            EMIDetail SampData = new EMIDetail
                            {
                                Case_Master_id = existingEntity.id,
                                emi_PaymentDate = updatedEmilist.emi_PaymentDate,
                                emi_Monthly_Amount = updatedEmilist.emi_Monthly_Amount,
                                emi_Interest_Amount = updatedEmilist.emi_Interest_Amount,
                                emi_Monthly_Interest_Amount = updatedEmilist.emi_Monthly_Interest_Amount
                            };
                            existingEntity.EMIDetail.Add(SampData);
                        }
                    }
                }

                if (existingEntity.UploadDocument != null)
                {

                    foreach (var updatedUploadlist in samp.UploadDocumentKey)
                    {
                        var existingemilist = existingEntity.UploadDocument.FirstOrDefault(cl => cl.Id == updatedUploadlist.Id);

                        if (existingemilist != null)
                        {
                            existingemilist.upload_document_name = updatedUploadlist.upload_document_name;
                            existingemilist.upload_document_path = updatedUploadlist.upload_document_path;
                        }
                        else
                        {
                            UploadDocument SampData = new UploadDocument
                            {
                                Case_Master_id = existingEntity.id,
                                upload_document_name = updatedUploadlist.upload_document_name,
                                upload_document_path = updatedUploadlist.upload_document_path,
                            };
                            existingEntity.UploadDocument.Add(SampData);
                        }
                    }
                }


                foreach (var item in samp.caseAddressTranskey)
                {
                    var existingAddress = DB.PartyAddressTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingAddress == null)
                    {
                        PartyAddressTransMaster SampData1 = new PartyAddressTransMaster()
                        {
                            case_master_id = existingEntity.id,
                            party_address_1 = item.party_address_1,
                            party_address_2 = item.party_address_2,
                            party_pincode = item.party_pincode,
                            party_state = item.party_state,
                            party_country = item.party_country,
                            party_address_description = item.party_address_description,
                            party_gst_type = item.party_gst_type,
                            party_gst_code = item.party_gst_code,
                            party_gst_address_no = item.party_gst_address_no,
                            party_address_location = item.party_address_location,

                        };
                        DB.PartyAddressTransMaster.Add(SampData1);
                    }
                    else
                    {
                        existingAddress.party_address_1 = item.party_address_1;
                        existingAddress.party_address_2 = item.party_address_2;
                        existingAddress.party_pincode = item.party_pincode;
                        existingAddress.party_state = item.party_state;
                        existingAddress.party_country = item.party_country;
                        existingAddress.party_address_description = item.party_address_description;
                        existingAddress.party_gst_type = item.party_gst_type;
                        existingAddress.party_gst_code = item.party_gst_code;
                        existingAddress.party_gst_address_no = item.party_gst_address_no;
                        existingAddress.party_address_location = item.party_address_location;


                    }
                }

                foreach (var item in samp.caseConactTranskey)
                {
                    var existingContact = DB.PartyContactTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingContact == null)
                    {
                        PartyContactTransMaster SampData2 = new PartyContactTransMaster()
                        {
                            case_master_id = existingEntity.id,
                            party_contact_name = item.party_contact_name,
                            party_contact_mobile = item.party_contact_mobile,
                            party_contact_whatsapp_mobile = item.party_contact_whatsapp_mobile,
                            party_contact_email = item.party_contact_email,
                            party_contact_description = item.party_contact_description,
                            party_contact_department = item.party_contact_department,
                            party_contact_designation = item.party_contact_designation,
                            party_contact_website = item.party_contact_website,
                            party_contact_twitter_id = item.party_contact_twitter_id,
                            party_contact_fb_id = item.party_contact_fb_id,
                            party_contact_youtube_id = item.party_contact_youtube_id,
                            party_landline_no = item.party_landline_no,
                            party_contact_instagram_id = item.party_contact_instagram_id

                        };
                        DB.PartyContactTransMaster.Add(SampData2);
                    }
                    else
                    {
                        existingContact.party_contact_name = item.party_contact_name;
                        existingContact.party_contact_mobile = item.party_contact_mobile;
                        existingContact.party_contact_whatsapp_mobile = item.party_contact_whatsapp_mobile;
                        existingContact.party_contact_email = item.party_contact_email;
                        existingContact.party_contact_description = item.party_contact_description;
                        existingContact.party_contact_department = item.party_contact_department;
                        existingContact.party_contact_designation = item.party_contact_designation;
                        existingContact.party_contact_website = item.party_contact_website;
                        existingContact.party_contact_twitter_id = item.party_contact_twitter_id;
                        existingContact.party_contact_fb_id = item.party_contact_fb_id;
                        existingContact.party_contact_youtube_id = item.party_contact_youtube_id;
                        existingContact.party_landline_no = item.party_landline_no;
                        existingContact.party_contact_instagram_id = item.party_contact_instagram_id;

                    }
                }

                foreach (var item in samp.caseDeleteAddressTranskey)
                {
                    var existingAddress = DB.PartyAddressTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingAddress != null)
                    {
                        DB.PartyAddressTransMaster.Remove(existingAddress);
                    }
                }

                foreach (var item in samp.caseDeleteContactTranskey)
                {
                    var existingContact = DB.PartyContactTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingContact != null)
                    {
                        DB.PartyContactTransMaster.Remove(existingContact);
                    }
                }
            }

            DB.SaveChanges();
            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;

        }

        public CaseMasterResp DeleteCaseMaster(long ID)
        {
            CaseMaster del = DB.CaseMaster
                //.Include(e => e.CaseHireMaster)
                 //    .Include(e => e.Guarantor1Detail).Include(e => e.Guarantor2Detail)
                     //.Include(e => e.RecieptDetail)
                     .Include(e => e.ExtraDetail)
                     .Include(e => e.EMIDetail).Include(e => e.UploadDocument)
                     .Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            DB.UploadDocument.RemoveRange(del.UploadDocument);
            DB.EMIDetail.RemoveRange(del.EMIDetail);
            DB.ExtraDetail.RemoveRange(del.ExtraDetail);
            //DB.RecieptDetail.RemoveRange(del.RecieptDetail);
           // DB.Guarantor1Detail.RemoveRange(del.Guarantor1Detail);
            //DB.Guarantor2Detail.RemoveRange(del.Guarantor2Detail);
            //DB.CaseHireMaster.RemoveRange(del.CaseHireMaster);
            DB.CaseMaster.Remove(del);
            DB.SaveChanges();
            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

        public CaseMasterResp GetCaseMasterLastCaseNo() 
        {
            //var lastrow = DB.CaseMaster.Max(u => u.id);
            //var lastCaseNo = DB.CaseMaster.FirstOrDefault(u => u.id == lastrow);

            //lastId = (long)(DB.CaseMaster.Max(u => (long?)u.id) ?? 0)


            //.Take(1);
            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
               CaseNo = (long)(DB.CaseMaster.Max(u => (long?)u.id) ?? 0)
            };
            return data;
        }



        public CaseMasterResp CheckCaseNo(string caseNo)
        {
            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "CaseNo already exists",
                CaseMasterByID = DB.CaseMaster.Where(e => e.Case_Case_No == caseNo).SingleOrDefault()
            };
            return data;
        }

        public CaseMasterResp GetFinanceByCaseNo(string caseNo)
        {


            CaseMaster caseMaster = DB.CaseMaster
               .Include(e => e.EMIDetail)
               .SingleOrDefault(e => e.Case_Case_No == caseNo);

            var emidetail = DB.EMIDetail.Where(e => e.Case_Master_id == caseMaster.id && e.emi_Status == "Completed").ToList();


            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                CaseMasterByID = caseMaster,
                checkEMICompleted = emidetail

            };

            return data;
        }

    }
}