using DB.Login;
using System;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using RTA.Masters.Models;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.EntityFrameworkCore;

namespace RTA.Masters
{
    public class ComplaintMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ComplaintMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ModelComplaintMasterResp InsertComplaintMaster(ModelComplaintMasterReq complaintMasterReq)
        {

            var timestamp = DateTime.UtcNow.ToString("yyyyMMdd");
            var random = new Random();
            var randomSuffix = random.Next(1000, 9999);
            long uniqueComplaintId = long.Parse($"{timestamp}{randomSuffix}");

            Complaint_Master SampData = new Complaint_Master()
            {
                user_id = complaintMasterReq.user_id,
                user_code = complaintMasterReq.user_code,
                unique_complaint_id = uniqueComplaintId,
                name = complaintMasterReq.name,
                email  = complaintMasterReq.email,
                phone = complaintMasterReq.phone,
                subject = complaintMasterReq.subject,
                complaint_description = complaintMasterReq.complaint_description,
                attached_file = complaintMasterReq?.attached_file?.FileName
            };
            DB.Complaint_Master.Add(SampData);
            DB.SaveChanges();

            long last_id = SampData.id;

            Complaint_Master insertData = DB.Complaint_Master.Where(e => e.id == last_id).FirstOrDefault();
            ModelComplaintMasterResp data = new ModelComplaintMasterResp()
            {
                status = true,
                Message = "inserted successfully",
                Complaint_MasterDataByID = insertData
            };
            return data;
        }


        public ModelComplaintMasterResp UpdateComplaint(ModelComplaintMasterUpdateReq complaintMasterReq ,  long complain_id)
        {
            Complaint_Master updateComplaint = DB.Complaint_Master.FirstOrDefault(e => e.unique_complaint_id == complain_id);

            updateComplaint.nature_of_complaint = complaintMasterReq.nature_of_complaint;
            updateComplaint.nature_of_complaint_detail = complaintMasterReq.nature_of_complaint_detail;
            updateComplaint.nature_of_complaint_remark = complaintMasterReq.nature_of_complaint_remark;
            updateComplaint.status = complaintMasterReq.status;

            DB.SaveChanges();


            ModelComplaintMasterResp data = new ModelComplaintMasterResp()
            {
                status = true,
                Message = "update successfully",
            };
            return data;
        }

        public ModelComplaintMasterResp GetComplaintByID(int id)
        {
            ModelComplaintMasterResp data = new ModelComplaintMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Complaint_MasterDataByID = DB.Complaint_Master.
                Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        
        public ModelComplaintMasterResp GetComplaintByUrn(long urn)
        {
            ModelComplaintMasterResp data = new ModelComplaintMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Complaint_MasterDataByID = DB.Complaint_Master.
                Where(e => e.unique_complaint_id == urn).SingleOrDefault()
            };

            return data;
        }


        public ModelComplaintMasterResp GetAllComplaintUser(long id, int pageNo, int limit, string filter = null)
        {

            int totalCount = DB.Complaint_Master.Count(e => e.user_id == id);
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

            List<Complaint_Master> list = DB.Complaint_Master
                .Where(e => (string.IsNullOrEmpty(filter) || e.status.Contains(filter)) && e.user_id == id)
                .Skip(skip)
                .Take(limit)
                .ToList();

            ModelComplaintMasterResp data = new ModelComplaintMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Complaint_MasterData = list,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };

            return data;
        }
                
        public ModelComplaintMasterResp DeleteComplaintByID(long Id)
        {
            Complaint_Master del = DB.Complaint_Master.Find(Id);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.status = "cancel by user";
            DB.SaveChanges();
            ModelComplaintMasterResp data = new ModelComplaintMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }
    }
}