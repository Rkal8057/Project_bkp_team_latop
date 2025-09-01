using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class ReceiptMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ReceiptMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ReceiptMasterResp InsertReceiptMaster(ReceiptMasterReq samp)
        {
            RecieptDetail SampData = new RecieptDetail
            {
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
                receipt_Late_Boun_Rec = samp.receipt_Late_Boun_Rec,
                Case_Master_id =samp.case_Master_id
            };
            DB.RecieptDetail.Add(SampData);
            DB.SaveChanges();

            List<EMIDetail> emidata = DB.EMIDetail
                            .Where(e => e.Case_Master_id == samp.case_Master_id &&
                                        e.emi_Status == "Pending")
                            .OrderBy(e => e.Id)
                            .ToList();

            if (emidata.Count > 0)
            {
                emidata[0].emi_Status = "Completed";
                DB.SaveChanges(); // Save the changes to the database
            }
            ReceiptMasterResp data = new ReceiptMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }



        public ReceiptMasterResp GetReceiptByCaseNo( string caseNo )
        {
            ReceiptMasterResp data = new ReceiptMasterResp()
            {
                status = true,
                Message = "inserted successfully",
                RecieptDetailData = DB.RecieptDetail.Where(e=>e.receipt_Case_No == caseNo).ToList()
            };
            return data;
        }
        public ReceiptMasterResp UpdateReceiptMaster(long ID, ReceiptMasterReq samp)
        {

            RecieptDetail recieptDetailToUpdate = DB.RecieptDetail.FirstOrDefault(e => e.id == ID);
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
            DB.SaveChanges();

            ReceiptMasterResp data = new ReceiptMasterResp()
            {
                status = true,
                Message = "updated successfully"
            };
            return data;
        }
        public ReceiptMasterResp DeleteReceiptMaster(long ID)
        {
            RecieptDetail del = DB.RecieptDetail.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.RecieptDetail.Remove(del);
            DB.SaveChanges();
            ReceiptMasterResp data = new ReceiptMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }



    }
}