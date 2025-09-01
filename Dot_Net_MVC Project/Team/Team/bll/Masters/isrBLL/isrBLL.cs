using DB.Login;
using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;


namespace RTA.Masters
{
    public class isrBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public isrBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelIsr1Resp GetIsr1Data()
        {
            ModelIsr1Resp data = new ModelIsr1Resp()
            {
                status = true,
                Message = "data fetched successfully",
                Isr1Data = DB.ISR_1.ToList()
            };
            return data;
        }

        public ModelIsr1Resp GetIsr1DataByID(int id)
        {

            ModelIsr1Resp data = new ModelIsr1Resp()
            {
                status = true,
                Message = "data fetched successfully",
                Isr1DataByID = DB.ISR_1.Where(e => e.Id == id).SingleOrDefault()
            };

            return data;
        }

        public ModelIsr1Resp InsertIsr(ModelIsr1Req isrReq)
        {
            ISR_1 SampData = new ISR_1()
            {
                CompanyName = isrReq.CompanyName,
                CheckboxPan = isrReq.CheckboxPan,
                CheckboxBankDetail = isrReq.CheckboxBankDetail,
                CheckboxSignature = isrReq.CheckboxSignature,
                CheckboxMobileNumber = isrReq.CheckboxMobileNumber,
                CheckboxEmailId = isrReq.CheckboxEmailId,
                CheckboxAddress = isrReq.CheckboxAddress,
                FirstHolder = isrReq.FirstHolder,
                SecondHolder = isrReq.SecondHolder,
                ThirdHolder = isrReq.ThirdHolder,
                Securities = isrReq.Securities,
                FaceValue = isrReq.FaceValue,
                DistinctiveNumbers = isrReq.DistinctiveNumbers,
                FirstHolderName = isrReq.FirstHolderName,
                SecondHolderName = isrReq.SecondHolderName,
                ThirdHolderName = isrReq.ThirdHolderName,
                DPIDClientID_CDSLClientID = isrReq.DPIDClientID_CDSLClientID,
                IFSCCode = isrReq.IFSCCode,
                AccountNumber = isrReq.AccountNumber,
                BankName = isrReq.BankName,
                BranchName = isrReq.BranchName,
                EmailAddress = isrReq.EMailAddress,
                MobileNumber = isrReq.MobileNumber,
                currentDate = isrReq.currentDate,
                Folio_Master = isrReq.folio_master,
                Holders_Master = isrReq.holder_master
            };
            DB.ISR_1.Add(SampData);
            DB.SaveChanges();

            ModelIsr1Resp data = new ModelIsr1Resp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        //public ModelIsrRes UpdateIsr(int ID, ModelIsrReq isrReq)
        //{

        //    ISR_1 SampData = new ISR_1()
        //    {
        //        id = ID,
        //        profession = samp.profession,
        //        name = samp.name,
        //        phone = samp.phone,
        //        email = samp.email,
        //        institute = samp.institute,
        //        isActive = samp.isActive
        //    };

        //    DB.ISR_1.Update(SampData);
        //    DB.SaveChanges();
        //    ModelIsrRes data = new ModelIsrRes()
        //    {
        //        status = true,
        //        Message = "UPDATED successfully"
        //    };
        //    return data;
        //}

        public ModelIsr1Resp DeleteIsr(int ID)
        {
            ISR_1 del = DB.ISR_1.Where(x => x.Id == ID).SingleOrDefault();
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.ISR_1.Remove(del);
            DB.SaveChanges();
            ModelIsr1Resp data = new ModelIsr1Resp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }
    }
}