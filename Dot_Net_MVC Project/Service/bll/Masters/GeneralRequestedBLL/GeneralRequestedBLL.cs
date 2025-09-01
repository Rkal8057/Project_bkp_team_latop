using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace RTA.Masters
{
    public class GeneralRequestedBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public GeneralRequestedBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public GeneralRequestedResp InsertGeneralRequested(GeneralRequestedReq samp)
        {
            GeneralRequestedDetail SampData = new GeneralRequestedDetail()
            {
                user_id = samp.user_id,
                service_id = samp.service_id,
                category_id = samp.category_id,
                ProcessRequestDetail = samp.ProcessRequestDetail,
            };

            DB.GeneralRequestedDetail.Add(SampData);
            DB.SaveChanges();
            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public GeneralRequestedResp GetGeneralRequested(long id, int pageNo, int limit, string filter = null)
        {

            int totalCount = DB.GeneralRequestedDetail.Count(e => e.user_id == id);
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

            /* List<GeneralRequestedDetail> list = DB.GeneralRequestedDetail
             .Join(
                 DB.ServiceMaster,
                 generalReq => generalReq.service_id,
                 service => service.id,
                 (generalReq, service) => new GeneralRequestedDetail
                 {
                     id = generalReq.id,
                     user_id = generalReq.user_id,
                     service_id = generalReq.service_id,
                     category_id = generalReq.category_id,
                     status = generalReq.status,
                     // Add other properties from GeneralRequestedBLL
                 }
             )
             .ToList();*/

            /*List<GeneralRequestedDetail> list = DB.GeneralRequestedDetail
             .Include(r => r.ProcessRequestDetail)
             .Include(r => r.ServiceMaster)
             .ThenInclude(category => category.CategoryMaster)
             .Where(r => r.user_id == id)
             .Skip(skip)
             .Take(limit)
             .ToList();*/


        

            var query = DB.GeneralRequestedDetail
                .Include(r => r.ProcessRequestDetail)
                .Include(r => r.ServiceMaster)
                .Where(r => r.user_id == id);

            // Add the status filter conditionally
            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(r => r.status == filter);
            }

            List<GeneralRequestedDetail> list = query
                .Skip(skip)
                .Take(limit)
                .Select(r => new GeneralRequestedDetail
                {
                    id = r.id,
                    status = r.status,
                    user_id = r.user_id,
                    ServiceMaster = new ServiceMaster
                    {
                        service_name = r.ServiceMaster.service_name,
                    },
                    CategoryMaster = new CategoryMaster
                    {
                        service_type = r.CategoryMaster.service_type,
                        // Add other CategoryMaster properties as needed
                    },
                    ProcessRequestDetail = r.ProcessRequestDetail.Select(prd => new ProcessRequestDetail
                    {
                        required_info = prd.required_info,
                        required_info_data = prd.required_info_data,
                        // Add other ProcessRequestDetail properties as needed
                    }).ToList()
                })
                .ToList();




            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "data fetched successfully",
                GeneralRequestedDetailData = list,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public GeneralRequestedResp DeleteGeneralRequested(long id)
        {

            GeneralRequestedDetail del = DB.GeneralRequestedDetail.Include(r => r.ProcessRequestDetail).SingleOrDefault(parent => parent.id == id);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.GeneralRequestedDetail.Remove(del);
            DB.ProcessRequestDetail.RemoveRange(del.ProcessRequestDetail);
            DB.SaveChanges();
            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

        public GeneralRequestedResp UpdateGeneralRequested(int id, GeneralRequestedReq samp)
        {

            GeneralRequestedDetail parentEntity = DB.GeneralRequestedDetail
            .Include(p => p.ProcessRequestDetail)
            .SingleOrDefault(p => p.id == id);


            if (parentEntity != null)
            {
                //                parentEntity.service_id = samp.service_id;

                foreach (ProcessRequestDetail updatedProcessDetail in samp.ProcessRequestDetail)
                {
                    ProcessRequestDetail existingCategory = parentEntity.ProcessRequestDetail.FirstOrDefault(c => c.id == updatedProcessDetail.id);

                    if (existingCategory != null)
                    {
                        existingCategory.required_info = updatedProcessDetail.required_info;
                        existingCategory.required_info_data = updatedProcessDetail.required_info_data;
                    }
                }
                DB.SaveChanges();
            }

            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public GeneralRequestedResp GetGeneralRequestedById(long id)
        {

            GeneralRequestedDetail detail = DB.GeneralRequestedDetail
            .Include(r => r.ProcessRequestDetail)
            .Include(r => r.ServiceMaster)
            .Include(r => r.CategoryMaster)
            .FirstOrDefault(r => r.id == id);
         


            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "data fetched successfully",
                GeneralRequestedDetailByID = detail,
            };
            return data;
        }




    }
}