using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

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

        public CategoryMasterResp GetCategoryMaster(string searchKey = null)
        {
            List<CategoryMaster> categoryDetail;

            if (searchKey != null)
            {
                categoryDetail = DB.CategoryMaster
                    .Include(e => e.subCategoryMasters)
                    .Where(e => e.category_status == 0 && EF.Functions.Like(e.category_name, "%" + searchKey + "%"))
                    .ToList();
            }
            else{
                categoryDetail = DB.CategoryMaster.Include(e=>e.subCategoryMasters)
                    .Include(e=>e.CategoryTranxMaster)
                    .Where(e => e.category_status == 0)
                    .Take(20).ToList();
            }


            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CategoryMasterData = categoryDetail
                //  Include(e => e.subCategoryMasters).ThenInclude(e => e.ProductMaster)

            };
            return data;
        }

        public CategoryMasterResp GetCategoryMasterById(long categoryId)
        {
            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CategoryMasterDataByID = DB.CategoryMaster
                    .Include(e => e.subCategoryMasters)
                    .Include(e => e.CategoryTranxMaster)
                    .Where(e => e.category_status == 0 && e.id == categoryId)
                    .FirstOrDefault()
            };
            return data;
        }

        public CategoryMasterResp InsertCategoryMaster(CategoryMasterReq samp)
        {
            CategoryMaster SampData = new CategoryMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                category_name = samp.category_name,
                img_url = samp.img_url,
                username = samp.username,
            };

            DB.CategoryMaster.Add(SampData);
            DB.SaveChanges();


            foreach (var keyName in samp.FilterArray)
            {
                CategoryTranxMaster SampData1 = new CategoryTranxMaster()
                {
                    category_id = SampData.id,
                    filter_name = keyName.filter_name.ToLower()
                };
                
                DB.CategoryTranxMaster.Add(SampData1);
                DB.SaveChanges();
            }

            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public CategoryMasterResp UpdateCategoryMaster(long categoryId, CategoryMasterReq samp)
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
            existingCategory.img_url = samp.img_url;

            foreach (var keyName in samp.FilterArray)
            {

                CategoryTranxMaster checkFilter = DB.CategoryTranxMaster.Where(E=>E.id == keyName.id).FirstOrDefault();
                if(checkFilter == null)
                {
                    CategoryTranxMaster SampData1 = new CategoryTranxMaster()
                    {
                        category_id = existingCategory.id,
                        filter_name = keyName.filter_name.ToLower()
                    };

                    DB.CategoryTranxMaster.Add(SampData1);
                }               
            }
            DB.SaveChanges();



            foreach (var delete in samp.DeleteFilterArray)
            {
                CategoryTranxMaster del = DB.CategoryTranxMaster.Where(e => e.id == delete.id).FirstOrDefault();
                DB.CategoryTranxMaster.Remove(del);
                DB.SaveChanges();
            }


            CategoryMasterResp data = new CategoryMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public CategoryMasterResp DeleteCategoryMaster(long categoryId)
        {

            CategoryMaster del = DB.CategoryMaster.Include(r => r.subCategoryMasters)
                                            .SingleOrDefault(parent => parent.id == categoryId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            if (del.subCategoryMasters != null && del.subCategoryMasters.Any())
            {
                CategoryMasterResp data1 = new CategoryMasterResp()
                {
                    status = true,
                    Message = " please delete the items related to that subcategory "
                };

                return data1;
            }
          
            del.category_status = 1;
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