using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

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
            //    ServiceSubCategoryMaster =  samp.ServiceSubCategoryMaster,  
            //};

            //DB.ServiceMaster.Add(SampData);
            //DB.SaveChanges();

            //CheckListMaster checklistobj = new CheckListMaster()
            //{
            //    CheckListMaster = samp.CheckListMaster,
            //    category_id = SampData.ServiceSubCategoryMaster.id
            //};

            //DB.CheckListMaster.Add(checklistobj);
            //DB.SaveChanges();

            ServiceMaster SampData = new ServiceMaster()
            {
                service_name = samp.service_name,
                item_category_main_id = samp.item_category_main_id
            };

            DB.ServiceMaster.Add(SampData);
            DB.SaveChanges();


            if (samp.service_type != null)
            {
                ServiceSubCategoryMaster categoryObj = new ServiceSubCategoryMaster()
                {
                    service_type = samp.service_type,
                    item_category_sub_id = samp.item_category_sub_id,
                    approx_amount = samp.approx_amount,
                    approx_days = samp.approx_days,
                    service_id = SampData.id,
                    commission_type = samp.commission_type,
                    commission_percentage = samp.commission_percentage ?? "0",
                    commission_amt = samp.commission_amt ?? "0",

                    cashback_amt= samp.cashback_amt ?? "0",
                    cashback_type = samp.cashback_type,
                    cashback_percentage = samp.cashback_percentage ?? "0",
                     
                };

                DB.ServiceSubCategoryMaster.Add(categoryObj);
                DB.SaveChanges();

                List<CheckListMaster> checklistItems = samp.CheckListMaster.Select(item => new CheckListMaster
                {
                    document_required_name = item.document_required_name,
                    document_required_type = item.document_required_type,
                    helper_master_document_id = item.helper_master_document_id ,
                    service_id = item.service_id,
                    subservice_id = categoryObj.id,
                    document_required_option = item.document_required_option,
                    document_required_col_size = item.document_required_col_size

                }).ToList();

                DB.CheckListMaster.AddRange(checklistItems);
                DB.SaveChanges();
            }

            ServiceMasterResp data = new ServiceMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

    

    public ServiceMasterResp CheckServiceName(string serviceName)
    {
        ServiceMaster check = DB.ServiceMaster.FirstOrDefault(e => e.service_name == serviceName.Trim());

        if (check == null) { 
            return new ServiceMasterResp

        {
            status = true,
            Message = "Service can be created"
        };
        }

        return new ServiceMasterResp

        {
            status = false,
            Message = "Service already exits",
            ServiceMasterDetailByID = check

        };
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


    public ServiceMasterResp GetServiceMasterById(long? id)
    {
        ServiceMasterResp data = new ServiceMasterResp()
        {
            status = true,
            Message = "data fetched successfully",
            ServiceMasterDetailData = DB.ServiceMaster
            .Include(r => r.ServiceSubCategoryMaster)
            .ThenInclude(category => category.CheckListMaster)
            .Where(service => service.id == id)
            .ToList()
        };
        return data;
    }







    public ServiceMasterResp GetAllServiceMaster(int pageNo, int limit, string searchKey = null)
    {
        IQueryable<ServiceMaster> query = DB.ServiceMaster
            .Include(r => r.ServiceSubCategoryMaster)
            //.ThenInclude(category => category.CheckListMaster);
                    .ThenInclude(category => category.CheckListMaster.OrderBy(c => c.document_required_position));


            // Add the search conditionally
            if (!string.IsNullOrEmpty(searchKey))
        {
            searchKey = searchKey.Trim(); // Trim whitespace
            query = query.Where(service =>
                EF.Functions.Like(service.service_name, $"%{searchKey}%"));
        }

        int totalCount = query.Count();

        int totalPages = (int)Math.Ceiling((double)totalCount / limit);

        int skip = (pageNo - 1) * limit;

        var serviceMasterDetails = query
            .Skip(skip)
            .Take(limit)
            .ToList();

        ServiceMasterResp data = new ServiceMasterResp()
        {
            status = true,
            Message = "Data fetched successfully",
            ServiceMasterDetailData = serviceMasterDetails,
            TotalCount = totalCount,
            TotalPages = totalPages,
            CurrentPage = pageNo,
            PageSize = limit,
        };

        return data;
    }


    public ServiceMasterResp DeleteServiceMaster(long id)
    {

        ServiceMaster del = DB.ServiceMaster.Include(r => r.ServiceSubCategoryMaster)
                                        .ThenInclude(category => category.CheckListMaster)
                                        .FirstOrDefault(parent => parent.id == id);
        if (del == null)
        {
            throw new Exception("RECORD NOT FOUND");
        }


        if (del.ServiceSubCategoryMaster != null && del.ServiceSubCategoryMaster.Any())
        {
            // DB.CheckListMaster.RemoveRange(del.ServiceSubCategoryMaster.SelectMany(category => category.CheckListMaster));

            foreach (var category in del.ServiceSubCategoryMaster)
            {
                if (category.CheckListMaster != null && category.CheckListMaster.Any())
                {
                    DB.CheckListMaster.RemoveRange(category.CheckListMaster);
                }
            }
            DB.ServiceSubCategoryMaster.RemoveRange(del.ServiceSubCategoryMaster);
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


    public ServiceMasterResp UpdateServiceMaster(long id, UpdateServiceMasterReq updatedService)
    {
        var existingService = DB.ServiceMaster.Include(s => s.ServiceSubCategoryMaster).ThenInclude(c => c.CheckListMaster)
       .FirstOrDefault(s => s.id == id);

        if (existingService == null)
        {
            throw new Exception("RECORD NOT FOUND");
        }

        if(existingService == null)
        {
            if(existingService.service_name != updatedService.service_name)
            {
                ServiceMaster checkName =  DB.ServiceMaster.Where(e => e.service_name == updatedService.service_name.Trim()).FirstOrDefault();
                if (checkName != null)
                {
                        ServiceMasterResp data1 = new ServiceMasterResp()
                        {
                            status = true,
                            Message = "Party already exits"
                        };
                        return data1;

                }
            }
        }



        existingService.service_name = updatedService.service_name;

        foreach (var updatedCategory in updatedService.ServiceSubCategoryMaster)
        {
            var existingCategory = existingService.ServiceSubCategoryMaster.FirstOrDefault(c => c.id == updatedCategory.id);

            if (existingCategory != null)
            {
                existingCategory.service_type = updatedCategory.service_type;
                existingCategory.item_category_sub_id = updatedCategory.item_category_sub_id;
                existingCategory.approx_amount = updatedCategory.approx_amount;
                existingCategory.approx_days = updatedCategory.approx_days;
                existingCategory.commission_type = updatedCategory.commission_type;
                existingCategory.commission_percentage = updatedCategory.commission_percentage;
                existingCategory.commission_amt = updatedCategory.commission_amt;
                existingCategory.cashback_amt = updatedCategory.cashback_amt;
                existingCategory.cashback_type = updatedCategory.cashback_type;
                existingCategory.cashback_percentage = updatedCategory.cashback_percentage;

                // Update checklists
                foreach (var updatedChecklist in updatedCategory.CheckListMaster)
                {
                    var existingChecklist = existingCategory.CheckListMaster.FirstOrDefault(cl => cl.id == updatedChecklist.id);

                    if (existingChecklist != null)
                    {
                            existingChecklist.document_required_name = updatedChecklist.document_required_name;
                            existingChecklist.document_required_type = updatedChecklist.document_required_type;
                            existingChecklist.helper_master_document_id = updatedChecklist.helper_master_document_id;
                            existingChecklist.document_required_position = updatedChecklist.document_required_position;
                            // Update other properties as needed
                            existingChecklist.document_required_option = updatedChecklist.document_required_option;
                            existingChecklist.document_required_col_size = updatedChecklist.document_required_col_size;
                        }
                    else
                    {
                        CheckListMaster ChecklistItem = new CheckListMaster()
                        {
                            document_required_name = updatedChecklist.document_required_name,
                            document_required_type = updatedChecklist.document_required_type,
                            helper_master_document_id = updatedChecklist.helper_master_document_id,
                            document_required_position = updatedChecklist.document_required_position,
                            service_id = existingService.id,
                            subservice_id = existingCategory.id,
                            document_required_option = updatedChecklist.document_required_option,
                            document_required_col_size = updatedChecklist.document_required_col_size
                        };
                        
                        // Add new checklist to the existing category
                        existingCategory.CheckListMaster.Add(ChecklistItem);
                    }
                }
            }
            else
            {
                    ServiceSubCategoryMaster categoryObj = new ServiceSubCategoryMaster()
                    {
                        service_type = updatedCategory.service_type,
                        item_category_sub_id = updatedCategory.item_category_sub_id,
                        approx_amount = updatedCategory.approx_amount,
                        approx_days = updatedCategory.approx_days,
                        service_id = existingService.id,
                        commission_type = updatedCategory.commission_type,
                        commission_percentage = updatedCategory.commission_percentage ?? "0",
                        commission_amt = updatedCategory.commission_amt ?? "0",
                        cashback_amt = updatedCategory.cashback_amt ?? "0",
                        cashback_type = updatedCategory.cashback_type,
                        cashback_percentage = updatedCategory.cashback_percentage ?? "0",
                    };
                    DB.ServiceSubCategoryMaster.Add(categoryObj);
                    DB.SaveChanges();

                    foreach (var updatedChecklist in updatedCategory.CheckListMaster)
                    {
                        var existingChecklist = existingCategory.CheckListMaster.FirstOrDefault(cl => cl.id == updatedChecklist.id);

                        if (existingChecklist != null)
                        {
                            existingChecklist.document_required_name = updatedChecklist.document_required_name;
                            existingChecklist.document_required_type = updatedChecklist.document_required_type;
                            existingChecklist.helper_master_document_id = updatedChecklist.helper_master_document_id;
                            existingChecklist.document_required_position = updatedChecklist.document_required_position;

                            existingChecklist.document_required_option = updatedChecklist.document_required_option;
                            existingChecklist.document_required_col_size = updatedChecklist.document_required_col_size;
                            // Update other properties as needed

                        }
                        else
                        {
                            CheckListMaster ChecklistItem = new CheckListMaster()
                            {
                                document_required_name = updatedChecklist.document_required_name,
                                document_required_type = updatedChecklist.document_required_type,
                                helper_master_document_id = updatedChecklist.helper_master_document_id,
                                document_required_position = updatedChecklist.document_required_position,
                                service_id = existingService.id,
                                subservice_id = categoryObj.id,
                                document_required_option = updatedChecklist.document_required_option,
                                document_required_col_size = updatedChecklist.document_required_col_size
                            };

                            // Add new checklist to the existing category
                            existingCategory.CheckListMaster.Add(ChecklistItem);



                        }
                    }

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

    public ServiceMasterResp CreateServiceMaster(UpdateServiceMasterReq updatedService)
    {
        ServiceMaster SampData = new ServiceMaster()
        {
            service_name = updatedService.service_name,
            item_category_main_id = updatedService.item_category_main_id
        };

        DB.ServiceMaster.Add(SampData);
        DB.SaveChanges();


        foreach (var updatedCategory in updatedService.ServiceSubCategoryMaster)
        {

            ServiceSubCategoryMaster categoryObj = new ServiceSubCategoryMaster()
            {
                service_type = updatedCategory.service_type,
                item_category_sub_id = updatedCategory.item_category_sub_id,
                approx_amount = updatedCategory.approx_amount,
                approx_days = updatedCategory.approx_days,
                service_id = SampData.id,
                commission_type = updatedCategory.commission_type,
             /* commission_percentage = updatedCategory.commission_percentage,
                commission_amt = updatedCategory.commission_amt*/

                commission_percentage = updatedCategory.commission_percentage ?? "0",
                commission_amt = updatedCategory.commission_amt ?? "0",
                cashback_amt = updatedCategory.cashback_amt ?? "0",
                cashback_type = updatedCategory.cashback_type,
                cashback_percentage = updatedCategory.cashback_percentage ?? "0",
            };
            DB.ServiceSubCategoryMaster.Add(categoryObj);
            DB.SaveChanges();


            foreach (var Checklist in updatedCategory.CheckListMaster)
            {
                CheckListMaster ChecklistItem = new CheckListMaster()
                {
                    document_required_name = Checklist.document_required_name,
                    document_required_type = Checklist.document_required_type,
                    helper_master_document_id = Checklist.helper_master_document_id,
                    document_required_position = Checklist.document_required_position,
                    service_id = SampData.id,
                    subservice_id = categoryObj.id,
                    document_required_option = Checklist.document_required_option,
                    document_required_col_size = Checklist.document_required_col_size
                };

                DB.CheckListMaster.Add(ChecklistItem);
                DB.SaveChanges();
            }

        }

        ServiceMasterResp data = new ServiceMasterResp()
        {
            status = true,
            Message = "inserted successfully"
        };
        return data;
    }



    // -============================ SUBSERVICE MASTER FUNCTION  =============================

    public ServiceMasterResp DeleteSubServiceMaster(long id)
    {
        ServiceSubCategoryMaster del = DB.ServiceSubCategoryMaster
        .Include(x => x.CheckListMaster)
        .SingleOrDefault(x => x.id == id);

        if (del == null)
        {
            throw new Exception("RECORD NOT FOUND");
        }

        if (del.CheckListMaster.Count > 0)
        {
            DB.CheckListMaster.RemoveRange(del.CheckListMaster);
        }
        DB.ServiceSubCategoryMaster.Remove(del);
        DB.SaveChanges();

        ServiceMasterResp data = new ServiceMasterResp()
        {
            status = true,
            Message = "deleted successfully"
        };
        return data;
    }


    // -============================ CHECKLIST MASTER FUNCTION  =============================

    public ServiceMasterResp DeleteCheckListMaster(long id)
    {
        CheckListMaster del = DB.CheckListMaster.Where(x => x.id == id).SingleOrDefault();

        if (del == null)
        {
            throw new Exception("RECORD NOT FOUND");
        }

        DB.CheckListMaster.Remove(del);
        DB.SaveChanges();
        ServiceMasterResp data = new ServiceMasterResp()
        {
            status = true,
            Message = "deleted successfully"
        };
        return data;

    }

}
}