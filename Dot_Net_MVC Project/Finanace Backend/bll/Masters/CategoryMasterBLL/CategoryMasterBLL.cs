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
    public class CategoryMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public CategoryMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

            
        public CategoryMasterResp InsertCategoryMaster(CategoryMasterReq samp)
        {
          
            CategoryMaster categoryObj = new CategoryMaster()
            {
                category_name = samp.category_name,
            };

            DB.CategoryMaster.Add(categoryObj);
            DB.SaveChanges();

           
            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }


        
        public CategoryMasterResp CategoryNameExistsInDatabase()
        {
            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CategoryMasterDetailData = DB.CategoryMaster.ToList()
            };


            return data;

        }


        public CategoryMasterResp GetAllCategoryMaster(int pageNo, int limit, string searchKey)
        {
            
            IQueryable<CategoryMaster> query = DB.CategoryMaster;

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => EF.Functions.Like(e.category_name, $"%{searchKey}%"));
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

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CategoryMasterDetailData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public CategoryMasterResp GetCategoryMasterById(long categoryId)
        {

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CategoryMasterDetailByID = DB.CategoryMaster.FirstOrDefault(e => e.id == categoryId)
            };


            return data;
        }

        public CategoryMasterResp UpdateCategoryMaster(long categoryId , CategoryMasterReq samp)
        {
            var existingCategory = DB.CategoryMaster.Find(categoryId);

            if (existingCategory == null)
            {
               
                CategoryMasterResp data1 = new CategoryMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            existingCategory.category_name = samp.category_name;

            DB.SaveChanges();

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public CategoryMasterResp DeleteCategoryMaster(long categoryId)
        {
            
            CategoryMaster del = DB.CategoryMaster.Include(r => r.ItemMaster)
                                            .SingleOrDefault(parent => parent.id == categoryId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            if (del.ItemMaster != null && del.ItemMaster.Any())
            {
                CategoryMasterResp data1 = new CategoryMasterResp()
                {
                    status = true,
                    Message = " please delete the items related to that category "
                };

                return data1;
                //foreach (var item in del.ItemMaster)
                //{
                //   DB.ItemMaster.RemoveRange(item);
                //}
            }else{
                DB.CategoryMaster.Remove(del);
                DB.SaveChanges();

                CategoryMasterResp data = new CategoryMasterResp()
                {
                    status = true,
                    Message = "deleted successfully"
                };
                return data;
            }
         

            
        }

    }
}