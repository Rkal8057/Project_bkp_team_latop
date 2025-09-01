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
                category_content= samp.category_content,
                category_image = samp.category_image,
                online_yn = samp.online_yn,
                cate_type = samp.cate_type,
                cate_id_if_sub_Selected = samp.cate_id_if_sub_Selected,
                cate_name_if_sub_Selected = samp.cate_name_if_sub_Selected,
                super_cate_id = samp.super_cate_id,
                balance_sheet_id = samp.balance_sheet_id,
                balance_sheet_cate_name = samp.balance_sheet_cate_name
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


        
        public CategoryMasterResp CategoryNameExistsInDatabase(CategoryMasterReq samp)
        {
            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = false,
                Message = $"Category name '{samp.category_name.Trim()}' already exists.",
                CategoryMasterDetailByID = DB.CategoryMaster.Where(e => e.category_name == samp.category_name.Trim() && e.delete_at == false).FirstOrDefault()
            };
            return data;
        }


        public CategoryMasterResp GetAllCategoryMaster(int pageNo, int limit, string searchKey = null, string? categoryName= null)
        {
            
            IQueryable<CategoryMaster> query = DB.CategoryMaster.Where(e=> e.delete_at == false);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => EF.Functions.Like(e.category_name, $"%{searchKey}%"));
            }

            if(!string.IsNullOrEmpty(categoryName))
            {

                query = query.Where(e => e.category_name != categoryName);
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
                CategoryMasterDetailByID = DB.CategoryMaster.FirstOrDefault(e => e.id == categoryId && e.delete_at == false)
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

            if (existingCategory != null)
            {
                if (existingCategory.category_name != samp.category_name)
                {
                    CategoryMaster checkItemCategoryName = DB.CategoryMaster.Where(e => e.category_name == samp.category_name.Trim()).FirstOrDefault();
                    if (checkItemCategoryName != null)
                    {
                        CategoryMasterResp data1 = new CategoryMasterResp()
                        {
                            status = true,
                           Message = $"Category name '{samp.category_name.Trim()}' already exists.",


                        };
                        return data1;

                    }

                }

            }


            existingCategory.category_name = samp.category_name;
            existingCategory.category_content = samp.category_content;
            existingCategory.category_image = samp.category_image;
            existingCategory.online_yn = samp.online_yn;
            existingCategory.cate_type = samp.cate_type;
            existingCategory.cate_id_if_sub_Selected = samp.cate_id_if_sub_Selected;
            existingCategory.cate_name_if_sub_Selected = samp.cate_name_if_sub_Selected;
            existingCategory.super_cate_id = samp.super_cate_id;
            existingCategory.balance_sheet_id = samp.balance_sheet_id;
            existingCategory.balance_sheet_cate_name = samp.balance_sheet_cate_name;


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
            
            CategoryMaster del = DB.CategoryMaster
                                            .SingleOrDefault(parent => parent.id == categoryId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }
          
            DB.CategoryMaster.Remove(del);
            DB.SaveChanges();

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
            
         
        }


        public CategoryMasterResp GetCategoryMasterWithCategoryType(string? categoryType = null,
            long? categoryId = null)
        {

            var fetch = new List<CategoryMaster>(); 
            if (categoryType != null)
            {
                fetch = DB.CategoryMaster.Where(parent => parent.delete_at == false 
                && parent.cate_type == categoryType).ToList();
            }

            if(categoryId != null)
            {
                fetch = DB.CategoryMaster.Where(parent => parent.delete_at == false &&
                parent.cate_id_if_sub_Selected == categoryId)
                                        .ToList();
            }

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "deleted successfully",
                CategoryMasterDetailData = fetch
            };
            return data;
        }

    }
}