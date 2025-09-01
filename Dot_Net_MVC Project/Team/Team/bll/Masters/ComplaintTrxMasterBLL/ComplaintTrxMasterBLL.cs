//using DB.Login;
//using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore;
using DB.Login;

namespace RTA.Masters
{
    public class ComplaintTrxMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public ComplaintTrxMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelComplaintTrxMasterResp InsertComplaintTrxMaster(ModelComplaintTrxMasterReq complaintMasterReq)
        {
            Complaint_Trx_Master SampData = new Complaint_Trx_Master()
            {
                user_id = complaintMasterReq.user_id,
                unique_complaint_id = complaintMasterReq.unique_complaint_id,
                reply_to = complaintMasterReq.reply_to,
                reply_date = complaintMasterReq.reply_date,
                action_taken = complaintMasterReq.action_taken,
                action_remark = complaintMasterReq.action_remark,
                master_id = (long)complaintMasterReq.master_id,
                attached_file = complaintMasterReq?.attached_file?.FileName,

            };
            DB.Complaint_Trx_Master.Add(SampData);
            DB.SaveChanges();

            ModelComplaintTrxMasterResp data = new ModelComplaintTrxMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        /*public ModelComplaintTrxMasterResp UpdateComplaintTrxMaster(long ComplaintId, ModelComplaintTrxMasterYUpdateReq complaintMasterReq)
        {
            // Retrieve the existing complaint based on ComplaintId
            Complaint_Trx_Master existingComplaint = DB.Complaint_Trx_Master.FirstOrDefault(e => e.unique_complaint_id == ComplaintId);

            if (existingComplaint != null)
            {
                // Update the existing complaint
                existingComplaint.reply_to = complaintMasterReq.reply_to;
                existingComplaint.reply_date = complaintMasterReq.reply_date;
                existingComplaint.action_taken = complaintMasterReq.action_taken;
                existingComplaint.action_remark = complaintMasterReq.action_remark;

                // Save changes to the database
                DB.SaveChanges();

                ModelComplaintTrxMasterResp data = new ModelComplaintTrxMasterResp()
                {
                    status = true,
                    Message = "UPDATED successfully"
                };

                return data;
            }
            else
            {
                // Throw an exception if the entity with the specified ComplaintId is not found
                throw new Exception("RECORD NOT FOUND");
            }
        }*/









        public ModelComplaintTrxMasterResp GetComplaintTrxByID(long ComplaintId)
        {
            ModelComplaintTrxMasterResp data = new ModelComplaintTrxMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Complaint_Trx_MasterData  =  DB.Complaint_Trx_Master
               .Where(e => e.unique_complaint_id == ComplaintId)
              .ToList()
        };

            return data;
        }

        //bool checkMasterId = rb.CheckMasterId(Data.master_id.Value);
        //        if (!checkMasterId)
        //        {
        //            return BadRequest(new { Status = 400, Message = "Invalid Master id ", Data = false });
        //        }
        //public bool CheckMasterId ( long master_id)
        //{
        //    Complaint_Trx_Master complaintTrxMaster = DB.Complaint_Trx_Master.Find(master_id);
        //    if(complaintTrxMaster == null)
        //    {
        //        return false;
        //    }
        //    return true;
        //}


    }
}