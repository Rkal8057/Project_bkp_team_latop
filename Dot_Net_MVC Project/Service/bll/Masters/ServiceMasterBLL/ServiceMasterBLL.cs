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
    public class ServiceMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ServiceMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ServiceMasterResp InsertServiceMaster(ServiceMasterReq samp)
        {
            //ServiceMaster SampData = new ServiceMaster()
            //{
            //    service_name = samp.service_name,   
            //    CategoryMaster =  samp.CategoryMaster,  
            //};

            //DB.ServiceMaster.Add(SampData);
            //DB.SaveChanges();

            //CheckListMaster checklistobj = new CheckListMaster()
            //{
            //    CheckListMaster = samp.CheckListMaster,
            //    category_id = SampData.CategoryMaster.id
            //};

            //DB.CheckListMaster.Add(checklistobj);
            //DB.SaveChanges();

            ServiceMaster SampData = new ServiceMaster()
            {
                service_name = samp.service_name,
            };

            DB.ServiceMaster.Add(SampData);
            DB.SaveChanges();

            CategoryMaster categoryObj = new CategoryMaster()
            {
                service_type = samp.service_type,
                approx_amount = samp.approx_amount,
                approx_days = samp.approx_days,
                service_id = SampData.id 
            };

            DB.CategoryMaster.Add(categoryObj);
            DB.SaveChanges();

            List<CheckListMaster> checklistItems = samp.CheckListMaster.Select(item => new CheckListMaster
            {
                document_required_name = item.document_required_name,
                document_required_type = item.document_required_type,
                category_id = categoryObj.id 
            }).ToList();

            DB.CheckListMaster.AddRange(checklistItems);
            DB.SaveChanges();


            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }



        public ServiceMasterResp GetServiceMaster()
        {
            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ServiceMasterDetailData = DB.ServiceMaster.ToList()
            };
            return data;
        }
        

        public ServiceMasterResp GetServiceMasterById( long? id)
        {
            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ServiceMasterDetailData = DB.ServiceMaster
                .Include(r => r.CategoryMaster)
                .ThenInclude(category => category.CheckListMaster)
                .Where(service => service.id == id)
                .ToList()
        };
            return data;
        }







        public ServiceMasterResp GetAllServiceMaster(int pageNo, int limit)
        {

            /*  var result1 = DB.ServiceMaster
                      .Join(
                          DB.CategoryMaster,
                          service => service.id,       // ServiceMaster.id
                          category => category.service_id, // CategoryMaster.service_id
                          (service, category) => new { Service = service, Category = category }
                      )
                       .GroupJoin(
                          DB.CheckListMaster,
                          joined => joined.Category.id,
                          checklist => checklist.category_id,
                          (joined, checklists) => new
                          {
                              Service = joined.Service,
                              Category = joined.Category,
                              CheckLists = checklists.ToList()
                          }
                      )
                      .ToList();*/

            int totalCount = DB.ServiceMaster
                .Include(r => r.CategoryMaster)
                 .ThenInclude(category => category.CheckListMaster).Count();
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



            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                ServiceMasterDetailData = DB.ServiceMaster
                .Include(r => r.CategoryMaster)
                 .ThenInclude(category => category.CheckListMaster)
                  .Skip(skip)
                .Take(limit)
                .ToList(),
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,
            };

            return data;
        }


        public ServiceMasterResp DeleteServiceMaster(long id)
        {

            ServiceMaster del = DB.ServiceMaster.Include(r => r.CategoryMaster)
                                            .ThenInclude(category => category.CheckListMaster)
                                            .FirstOrDefault(parent => parent.id == id);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            if (del.CategoryMaster != null && del.CategoryMaster.Any())
            {
                // DB.CheckListMaster.RemoveRange(del.CategoryMaster.SelectMany(category => category.CheckListMaster));

                foreach (var category in del.CategoryMaster)
                {
                    if (category.CheckListMaster != null && category.CheckListMaster.Any())
                    {
                        DB.CheckListMaster.RemoveRange(category.CheckListMaster);
                    }
                }
                DB.CategoryMaster.RemoveRange(del.CategoryMaster);
            }

            DB.ServiceMaster.Remove(del);
            DB.SaveChanges();

            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


        public ServiceMasterResp UpdateServiceMaster(long id , UpdateServiceMasterReq updatedService)
        {
            var existingService = DB.ServiceMaster.Include(s => s.CategoryMaster).ThenInclude(c => c.CheckListMaster)
           .FirstOrDefault(s => s.id == id);

            if (existingService == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            existingService.service_name = updatedService.service_name;

            foreach (var updatedCategory in updatedService.CategoryMaster)
            {
                var existingCategory = existingService.CategoryMaster.FirstOrDefault(c => c.id == updatedCategory.id);

                if (existingCategory != null)
                {
                    existingCategory.service_type = updatedCategory.service_type;
                    existingCategory.approx_amount = updatedCategory.approx_amount;
                    existingCategory.approx_days = updatedCategory.approx_days;

                    // Update checklists
                    foreach (var updatedChecklist in updatedCategory.CheckListMaster)
                    {
                        var existingChecklist = existingCategory.CheckListMaster.FirstOrDefault(cl => cl.id == updatedChecklist.id);

                        if (existingChecklist != null)
                        {
                            existingChecklist.document_required_name = updatedChecklist.document_required_name;
                            existingChecklist.document_required_type = updatedChecklist.document_required_type;
                            // Update other properties as needed
                        }
                        else
                        {
                            // Add new checklist to the existing category
                            existingCategory.CheckListMaster.Add(updatedChecklist);
                        }
                    }
                }
                else
                {
                    // Add new category to the existing service
                    existingService.CategoryMaster.Add(updatedCategory);
                }

            }

            DB.SaveChanges();
            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;
        }


    }
}