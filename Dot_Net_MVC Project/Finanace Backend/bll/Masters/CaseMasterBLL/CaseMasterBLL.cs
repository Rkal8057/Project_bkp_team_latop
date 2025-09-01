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

        public CaseMasterResp GetAllCaseMaster()
        {
            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CaseMasterData = DB.CaseMaster.Include(e => e.CaseHireMaster)
                 .Include(e => e.Guarantor1Detail).Include(e => e.Guarantor2Detail)
                 .Include(e => e.RecieptDetail).Include(e => e.ExtraDetail)
                 .Include(e => e.EMIDetail).Include(e => e.UploadDocument)
                 .ToList()
            };
            return data;
        }

        public CaseMasterResp GetCaseMasterById(long id)
        {

            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CaseMasterByID = DB.CaseMaster.Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public CaseMasterResp InsertCaseMaster(CaseMasterReq samp)
        {

             CaseMaster SampData = new CaseMaster()
            {
                case_financed_item = samp.case_financed_item,
                Case_Finance_Amt = samp.Case_Finance_Amt,
                case_Duration_Type = samp.case_Duration_Type,
                case_Duration_Value = samp.case_Duration_Value,
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
            };

            DB.CaseMaster.Add(SampData);
            DB.SaveChanges();

            CaseHireMaster SampData1 = new CaseHireMaster()
            {
                Case_Master_id = SampData.id,
                Hire_Name = samp.Hire_Name,
                Hire_SWH_Name = samp.Hire_SWH_Name,
                Hire_Resi_Address = samp.Hire_Resi_Address,
                Hire_Ph_No = samp.Hire_Ph_No,
                Hire_Company_Name = samp.Hire_Company_Name,
                Hire_Off_Ph_Nos = samp.Hire_Off_Ph_Nos,
                Hire_Off_Address = samp.Hire_Off_Address,
                Hire_Ph_No2 = samp.Hire_Ph_No2,
                Hire_Post = samp.Hire_Post,
                Hire_Profession = samp.Hire_Profession,
                Hire_Area = samp.Hire_Area,
                Hire_Location = samp.Hire_Location,
                Hire_Email = samp.Hire_Email,
                Hire_Whatsapp_Phone = samp.Hire_Whatsapp_Phone,
            };
            DB.CaseHireMaster.Add(SampData1);
            DB.SaveChanges();


            Guarantor1Detail SampData2 = new Guarantor1Detail
            {
                Case_Master_id = SampData.id,
                guarantor1_Name = samp.guarantor1_Name,
                guarantor1_SWH_Name = samp.guarantor1_SWH_Name,
                guarantor1_Resi_Address = samp.guarantor1_Resi_Address,
                guarantor1_Phones_No = samp.guarantor1_Phones_No,
                guarantor1_Company_Name = samp.guarantor1_Company_Name,
                guarantor1_Off_Address = samp.guarantor1_Off_Address,
                guarantor1_Off_Phone_No = samp.guarantor1_Off_Phone_No
            };

            DB.Guarantor1Detail.Add(SampData2);
            DB.SaveChanges();


            Guarantor2Detail SampData3 = new Guarantor2Detail
            {
                Case_Master_id = SampData.id,
                guarantor2_Name = samp.guarantor2_Name,
                guarantor2_SWH_Name = samp.guarantor2_SWH_Name,
                guarantor2_Resi_Address = samp.guarantor2_Resi_Address,
                guarantor2_Phones_No = samp.guarantor2_Phones_No,
                guarantor2_Company_Name = samp.guarantor2_Company_Name,
                guarantor2_Off_Address = samp.guarantor2_Off_Address,
                guarantor2_Off_Phone_No = samp.guarantor2_Off_Phone_No
            };
            DB.Guarantor2Detail.Add(SampData3);
            DB.SaveChanges();


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


            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public CaseMasterResp UpdateCaseMaster(long ID, CaseMasterReq samp)
        {
            CaseMaster existingEntity = DB.CaseMaster.Include(e => e.CaseHireMaster)
                .Include(e => e.Guarantor1Detail).Include(e => e.Guarantor2Detail)
                .Include(e => e.RecieptDetail).Include(e => e.ExtraDetail)
                .Include(e => e.EMIDetail).Include(e => e.UploadDocument)
                .FirstOrDefault(e => e.id == ID);

            if (existingEntity != null)
            {
                existingEntity.case_financed_item = samp.case_financed_item;
                existingEntity.Case_Finance_Amt = samp.Case_Finance_Amt;
                existingEntity.case_Duration_Type = samp.case_Duration_Type;
                existingEntity.case_Duration_Value = samp.case_Duration_Value;
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

                if (existingEntity.CaseHireMaster != null)
                {
                    CaseHireMaster hireMasterToUpdate = existingEntity.CaseHireMaster.FirstOrDefault(h => h.Case_Master_id == existingEntity.id);

                    hireMasterToUpdate.Hire_Name = samp.Hire_Name;
                    hireMasterToUpdate.Hire_SWH_Name = samp.Hire_SWH_Name;
                    hireMasterToUpdate.Hire_Resi_Address = samp.Hire_Resi_Address;
                    hireMasterToUpdate.Hire_Ph_No = samp.Hire_Ph_No;
                    hireMasterToUpdate.Hire_Company_Name = samp.Hire_Company_Name;
                    hireMasterToUpdate.Hire_Off_Ph_Nos = samp.Hire_Off_Ph_Nos;
                    hireMasterToUpdate.Hire_Off_Address = samp.Hire_Off_Address;
                    hireMasterToUpdate.Hire_Ph_No2 = samp.Hire_Ph_No2;
                    hireMasterToUpdate.Hire_Post = samp.Hire_Post;
                    hireMasterToUpdate.Hire_Profession = samp.Hire_Profession;
                    hireMasterToUpdate.Hire_Area = samp.Hire_Area;
                    hireMasterToUpdate.Hire_Location = samp.Hire_Location;
                    hireMasterToUpdate.Hire_Email = samp.Hire_Email;
                    hireMasterToUpdate.Hire_Whatsapp_Phone = samp.Hire_Whatsapp_Phone;
                }

                if (existingEntity.Guarantor1Detail != null)
                {
                    Guarantor1Detail guarantor1ToUpdate = existingEntity.Guarantor1Detail.FirstOrDefault(h => h.Case_Master_id == existingEntity.id);

                    if (guarantor1ToUpdate != null)
                    {
                        guarantor1ToUpdate.guarantor1_Name = samp.guarantor1_Name; // Replace samp with your new data
                        guarantor1ToUpdate.guarantor1_SWH_Name = samp.guarantor1_SWH_Name;
                        guarantor1ToUpdate.guarantor1_Resi_Address = samp.guarantor1_Resi_Address;
                        guarantor1ToUpdate.guarantor1_Phones_No = samp.guarantor1_Phones_No;
                        guarantor1ToUpdate.guarantor1_Company_Name = samp.guarantor1_Company_Name;
                        guarantor1ToUpdate.guarantor1_Off_Address = samp.guarantor1_Off_Address;
                        guarantor1ToUpdate.guarantor1_Off_Phone_No = samp.guarantor1_Off_Phone_No;
                    }
                }

                if (existingEntity.Guarantor2Detail != null)
                {
                    Guarantor2Detail guarantor2ToUpdate = existingEntity.Guarantor2Detail.FirstOrDefault(h => h.Case_Master_id == existingEntity.id);

                    if (guarantor2ToUpdate != null)
                    {
                        guarantor2ToUpdate.guarantor2_Name = samp.guarantor2_Name; // Replace samp with your new data
                        guarantor2ToUpdate.guarantor2_SWH_Name = samp.guarantor2_SWH_Name;
                        guarantor2ToUpdate.guarantor2_Resi_Address = samp.guarantor2_Resi_Address;
                        guarantor2ToUpdate.guarantor2_Phones_No = samp.guarantor2_Phones_No;
                        guarantor2ToUpdate.guarantor2_Company_Name = samp.guarantor2_Company_Name;
                        guarantor2ToUpdate.guarantor2_Off_Address = samp.guarantor2_Off_Address;
                        guarantor2ToUpdate.guarantor2_Off_Phone_No = samp.guarantor2_Off_Phone_No;

                    }

                }

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
            CaseMaster del = DB.CaseMaster.Include(e => e.CaseHireMaster)
                     .Include(e => e.Guarantor1Detail).Include(e => e.Guarantor2Detail)
                     .Include(e => e.RecieptDetail).Include(e => e.ExtraDetail)
                     .Include(e => e.EMIDetail).Include(e => e.UploadDocument)
                     .Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            DB.UploadDocument.RemoveRange(del.UploadDocument);
            DB.EMIDetail.RemoveRange(del.EMIDetail);
            DB.ExtraDetail.RemoveRange(del.ExtraDetail);
            DB.RecieptDetail.RemoveRange(del.RecieptDetail);
            DB.Guarantor1Detail.RemoveRange(del.Guarantor1Detail);
            DB.Guarantor2Detail.RemoveRange(del.Guarantor2Detail);
            DB.CaseHireMaster.RemoveRange(del.CaseHireMaster);
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
            var lastrow = DB.CaseMaster.Max(u => u.id);
            var lastCaseNo = DB.CaseMaster.FirstOrDefault(u => u.id == lastrow);

            //.Take(1);
            CaseMasterResp data = new CaseMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
               CaseNo = lastCaseNo.Case_Case_No
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