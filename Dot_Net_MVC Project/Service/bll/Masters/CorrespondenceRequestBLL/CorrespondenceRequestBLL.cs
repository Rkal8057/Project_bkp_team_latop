using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;

namespace RTA.Masters
{
    public class CorrespondenceRequestBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public CorrespondenceRequestBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
       
        public CorrespondenceRequestResp InsertCorrespondenceRequest( CorrespondenceRequestReq samp)
        {
            CorrespondenceRequest SampData = new CorrespondenceRequest()
            {
                company_name = samp.company_name,
                reply_date = samp.reply_date,
                reject_yn = samp.reject_yn,
                work_category = samp.work_category,
                purpose = samp.purpose,
                sender_name = samp.sender_name, 
                sender_email = samp.sender_email,
                sender_mobile = samp.sender_mobile,
                status = samp.status
            };

            DB.CorrespondenceRequest.Add(SampData);
            DB.SaveChanges();

            CorrespondenceRequestResp data = new CorrespondenceRequestResp()
            {
                status = true,
                Message = "Inserted successfully"
            };

            return data;
        }


        public CorrespondenceRequestResp GetCorrespondenceRequestById(long id)
        {

            CorrespondenceRequest detail = DB.CorrespondenceRequest.FirstOrDefault(r => r.id == id);
            CorrespondenceRequestResp data = new CorrespondenceRequestResp()
            {
                status = true,
                Message = "data fetched successfully",
                CorrespondenceRequestDetailByID = detail,
            };
            return data;
        }

        public CorrespondenceRequestResp GetCorrespondenceRequest( int pageNo, int limit , string status=null)
        {
            int totalCount = DB.CorrespondenceRequest.Count();
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

            var query = DB.CorrespondenceRequest.AsQueryable();

            // Add the status filter conditionally
            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(r => r.status == status);
            }

            List<CorrespondenceRequest> list = query.Skip(skip).Take(limit).ToList();


            CorrespondenceRequestResp data = new CorrespondenceRequestResp()
            {
                status = true,
                Message = "data fetched successfully",
                CorrespondenceRequestDetailData = list,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
           
        }

        public CorrespondenceRequestResp UpdateCorrespondenceRequest(int id,CorrespondenceRequestReq samp)
        {
            CorrespondenceRequest checklist = DB.CorrespondenceRequest.FirstOrDefault(x => x.id == id);
            checklist.reject_yn = samp.reject_yn;
            checklist.work_category = samp.work_category;
            checklist.purpose = samp.purpose;
            checklist.status = samp.status;

            DB.CorrespondenceRequest.Update(checklist);
            DB.SaveChanges();
            CorrespondenceRequestResp data = new CorrespondenceRequestResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public CorrespondenceRequestResp DeleteCorrespondenceRequest(long id)
        {
            CorrespondenceRequest del = DB.CorrespondenceRequest.Where(x => x.id == id).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.CorrespondenceRequest.Remove(del);
            DB.SaveChanges();
            CorrespondenceRequestResp data = new CorrespondenceRequestResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

        

    }
}