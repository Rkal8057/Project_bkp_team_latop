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
    public class PartyCategoryMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public PartyCategoryMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public PartyCategoryMasterResp InsertPartyCategoryMaster(PartyCategoryMasterReq samp)
        {
          
            PartyCategoryMaster categoryObj = new PartyCategoryMaster
            {
                table_flag = samp.table_flag,
                category_name = samp.category_name,
                cate_type = samp.cate_type,
                cate_id_if_sub_Selected = samp.cate_id_if_sub_Selected,
                cate_name_if_sub_Selected = samp.cate_name_if_sub_Selected,
                super_cate_id = samp.super_cate_id,
                balance_sheet_id = samp.balance_sheet_id,
                balance_sheet_cate_name = samp.balance_sheet_cate_name
            };

            DB.PartyCategoryMaster.Add(categoryObj);
            DB.SaveChanges();


            var check = DB.PartyCategoryMaster.Where(E => E.id == categoryObj.id).FirstOrDefault();
            if( samp.super_cate_id == 0)
            {
                check.super_cate_id = categoryObj.id;
            }
            DB.SaveChanges();




            PartyCategoryMasterResp data = new PartyCategoryMasterResp()    
            {
                status = true,
                Message = "Inserted successfully"
            };


            return data;
        }


        public PartyCategoryMasterResp GetAllPartyCategoryMaster(int pageNo, int limit, string? searchKey = null, string? categoryName= null)
        {

            IQueryable<PartyCategoryMaster> query = DB.PartyCategoryMaster.Where(e => e.delete_at == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                EF.Functions.Like(e.category_name, $"%{searchKey}%") ||
                EF.Functions.Like(e.cate_type, $"%{searchKey}%"));
                // EF.Functions.Like(e.address, $"%{searchKey}%") ||
                // EF.Functions.Like(e.mobile_number.ToString(), $"%{searchKey}%"));

            }

            if (!string.IsNullOrEmpty(categoryName))
            {
                query = query.Where(e=> e.category_name != categoryName);
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

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyCategoryMasterData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;

          /*  PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyCategoryMasterData = DB.PartyCategoryMaster.Where( e => e.delete_at == 0).ToList(),

            };
            return data;*/
        }

        public PartyCategoryMasterResp GetPartyCategoryMasterById(long partyCategoryId)
        {

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyCategoryMasterByID = DB.PartyCategoryMaster.FirstOrDefault(e => e.id == partyCategoryId)
            };


            return data;
        }


        public PartyCategoryMasterResp UpdatePartyCategoryMaster(long categoryId, PartyCategoryMasterReq samp)
        {
            var existingCategory = DB.PartyCategoryMaster.Find(categoryId);

            if (existingCategory == null)
            {

                PartyCategoryMasterResp data1 = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            if (existingCategory != null)
            {
                if(existingCategory.category_name != samp.category_name)
                {
                    PartyCategoryMaster checkPartyCategoryName =   DB.PartyCategoryMaster.Where(e => e.category_name == samp.category_name.Trim()).FirstOrDefault();
                    if(checkPartyCategoryName != null)
                    {
                        PartyCategoryMasterResp data1 = new PartyCategoryMasterResp()
                        {
                            status = true,
                            Message = $"Party Category name '{samp.category_name.Trim()}' already exists.",

                        };
                        return data1;

                    }

                }

            }

                //existingCategory.table_flag = samp.table_flag,
            existingCategory.category_name = samp.category_name;
            existingCategory.cate_type = samp.cate_type;
            existingCategory.cate_id_if_sub_Selected = samp.cate_id_if_sub_Selected;
            existingCategory.cate_name_if_sub_Selected = samp.cate_name_if_sub_Selected;
            existingCategory.super_cate_id = samp.super_cate_id;
            existingCategory.balance_sheet_id = samp.balance_sheet_id;
            existingCategory.balance_sheet_cate_name = samp.balance_sheet_cate_name;

            var check = DB.PartyCategoryMaster.Where(E => E.id == existingCategory.id).FirstOrDefault();
            if (samp.super_cate_id == 0)
            {
                check.super_cate_id = existingCategory.id;
            }
            else
            {
                check.super_cate_id = samp.balance_sheet_id;
            }

            DB.SaveChanges();

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public PartyCategoryMasterResp CheckDeletePartyCategoryIfExistsInMaster(long partyCategoryId)
        {

            var partyMaster = DB.PartyMaster
             .Where(e => e.party_group_category_id == partyCategoryId && e.delete_at == 0)
             .ToList();

            if (partyMaster.Count != 0)
            {
                PartyCategoryMasterResp data1 = new PartyCategoryMasterResp()
                {
                    status = false,
                    Message = "Party Category cannot be deleted because it exists in:"
                };


                if (partyMaster != null)
                {
                    data1.Message += " Party Detail";
                    data1.PartyMaster = partyMaster;
                }

                return data1;

            }

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "Party Category cannot exist in another data",
                PartyMaster = partyMaster
            };
            return data;


            //PartyCategoryMaster del = DB.PartyCategoryMaster
            //    .SingleOrDefault(parent => parent.id == partyCategoryId);

            //if (del == null)
            //{
            //    throw new Exception("RECORD NOT FOUND");
            //}


            //DB.PartyCategoryMaster.Remove(del);
            //DB.SaveChanges();

            //PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            //{
            //    status = true,
            //    Message = "deleted successfully"
            //};
            //return data;
        }

        public PartyCategoryMasterResp DeletePartyCategory(long partyCategoryId)
        {

            PartyCategoryMaster del = DB.PartyCategoryMaster
                .SingleOrDefault(parent => parent.id == partyCategoryId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            //DB.PartyCategoryMaster.Remove(del);
            del.delete_at = 1;
            DB.SaveChanges();

            PartyCategoryMasterResp data = new PartyCategoryMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}