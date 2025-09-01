using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SubCategoryMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public SubCategoryMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public SubCategoryMasterResp GetSubCategoryMaster(string searchKey = null)
        {

            List<SubCategoryMaster> subcategoryDetail;

            if (searchKey != null)
            {
                subcategoryDetail = DB.SubCategoryMaster.Where(e => e.sub_category_status == 0 && EF.Functions.Like(e.sub_category_name, "%" + searchKey + "%")).ToList();
            }
            else
            {
                subcategoryDetail = DB.SubCategoryMaster.Where(e => e.sub_category_status == 0).Take(20).ToList();
            }

            SubCategoryMasterResp data = new SubCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SubCategoryMasterData = subcategoryDetail
            };
            return data;
        }

        public SubCategoryMasterResp GetSubCategoryMasterById(long subcategoryId)
        {
            SubCategoryMasterResp data = new SubCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SubCategoryMasterDataByID = DB.SubCategoryMaster.Where(e => e.id == subcategoryId).FirstOrDefault() 
            };
            return data;
        }

        public SubCategoryMasterResp InsertSubCategoryMaster(SubCategoryMasterReq samp)
        {
            SubCategoryMaster SampData = new SubCategoryMaster()
            {
                unique_trn_id = samp.unique_trn_id,
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                sub_category_name = samp.sub_category_name,
                parent_category_id = samp.parent_category_id,
                parent_category_name = samp.parent_category_name,
                sub_heading = samp.sub_heading,
                username = samp.username
            };

            DB.SubCategoryMaster.Add(SampData);
            DB.SaveChanges();
            SubCategoryMasterResp data = new SubCategoryMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public SubCategoryMasterResp UpdateSubCategoryMaster(long SubcategoryId, SubCategoryMasterReq samp)
        {
            var existingCategory = DB.SubCategoryMaster.Find(SubcategoryId);

            if (existingCategory == null)
            {

                SubCategoryMasterResp data1 = new SubCategoryMasterResp()
                {
                    status = false,
                    Message = "Sub-Category not found"
                };

                return data1;
            }

            existingCategory.parent_category_id = samp.parent_category_id;
            existingCategory.parent_category_name = samp.parent_category_name;
            existingCategory.sub_category_name = samp.sub_category_name;
            DB.SaveChanges();

            SubCategoryMasterResp data = new SubCategoryMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }

        public SubCategoryMasterResp DeleteSubCategoryMaster(long subcategoryId)
        {

            SubCategoryMaster del = DB.SubCategoryMaster.Include(r => r.ProductMaster)
                                            .SingleOrDefault(parent => parent.id == subcategoryId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            if (del.ProductMaster != null && del.ProductMaster.Any())
            {
                SubCategoryMasterResp data1 = new SubCategoryMasterResp()
                {
                    status = true,
                    Message = " please delete the items related to that item "
                };

                return data1;
            }

            del.sub_category_status = 1;
            DB.SaveChanges();

            SubCategoryMasterResp data = new SubCategoryMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}