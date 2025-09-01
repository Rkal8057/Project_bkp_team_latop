using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RTA.Masters
{
    public class ItemMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public ItemMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ItemMasterResp InsertItemMaster(ItemMasterReq samp)
        {

            ItemMaster categoryObj = new ItemMaster()
            {
                 item_name = samp.item_name,
                 category_id = samp.category_id,
                 item_type = samp.item_type,
                 item_amount = samp.item_amount,
            };

            DB.ItemMaster.Add(categoryObj);
            DB.SaveChanges();


            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ItemMasterResp GetAllItemMaster(int pageNo, int limit, string searchKey)
        {

            IQueryable<ItemMaster> query = DB.ItemMaster.Include(item => item.CategoryMaster);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => EF.Functions.Like(e.item_name, $"%{searchKey}%"));
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
            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ItemMasterDetailData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }


        public ItemMasterResp UpdateItemMaster(long itemId, ItemMasterReq samp)
        {
            var existingCategory = DB.ItemMaster.Find(itemId);

            if (existingCategory == null)
            {

                ItemMasterResp data1 = new ItemMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            existingCategory.item_name = samp.item_name;
            existingCategory.category_id = samp.category_id;
            existingCategory.item_type = samp.item_type;
            existingCategory.item_amount = samp.item_amount;

            DB.SaveChanges();

            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public ItemMasterResp DeleteItemMaster(long itemId)
        {
            ItemMaster del = DB.ItemMaster
            .SingleOrDefault(x => x.id == itemId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }
            DB.ItemMaster.Remove(del);
            DB.SaveChanges();

            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

    }
}