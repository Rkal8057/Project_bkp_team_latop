using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

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

            ItemMaster SampData = new ItemMaster()
            {
                item_code = samp.item_code,
                item_name = samp.item_name,
                group = samp.group,
                hsn_code = samp.hsn_code,
                tax_per = samp.tax_per,
                convertion_of_pcs = samp.convertion_of_pcs,
                price_purchase_rate = samp.price_purchase_rate,
                price_value_per_pcs = samp.price_value_per_pcs,
                price_avg_weight_per_pcs = samp.price_avg_weight_per_pcs,
                price_opening_stock_rate = samp.price_opening_stock_rate,
                opening_stock_shop = samp.opening_stock_shop,
                stock_shop = samp.stock_shop,
                opening_stock_godown = samp.opening_stock_godown,
                stock_godown = samp.stock_godown,
                total_stock = samp.total_stock,
                item_type = samp.item_type
            };

            DB.ItemMaster.Add(SampData);
            DB.SaveChanges();


            foreach (var key in samp.ItemTransMixDetailKey)
            {
                ItemTransMixDetail SampData1 = new ItemTransMixDetail
                {
                    item_name = key.item_name,
                    item_qty = key.item_qty,
                    item_rate = key.item_rate,
                    item_master_id = SampData.id,
                    item_type = key.item_type
                };

                DB.ItemTransMixDetail.Add(SampData1);
            }

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

            IQueryable<ItemMaster> query = DB.ItemMaster.Where(e => e.delete_at == 0);

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



        public ItemMasterResp ItemNameExistsInDatabase(ItemMasterReq samp)
        {
            ItemMasterResp data = new ItemMasterResp()
            {
                status = false,
                Message = "Item name already exists",
                ItemMasterDetailByID = DB.ItemMaster.Where(e => e.item_name == samp.item_name).FirstOrDefault()
            };
            return data;
        }



        public ItemMasterResp GetItemMasterByItemId(long itemId)
        {

            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ItemMasterDetailByID = DB.ItemMaster
                .Include(E => E.ItemTransMixDetail.Where(p => p.delete_at == 0))
                .Where(e => e.id == itemId && e.delete_at == 0)
                .FirstOrDefault()

        };
            return data;

        }
           
        public ItemMasterResp UpdateItemMaster(long itemId, ItemMasterReq samp)
        {
            var existingItem = DB.ItemMaster.Find(itemId);

            if (existingItem == null)
            {

                ItemMasterResp data1 = new ItemMasterResp()
                {
                    status = false,
                    Message = "Item not found"
                };

                return data1;
            }

            existingItem.item_code = samp.item_code;
            existingItem.item_name = samp.item_name;
            existingItem.group = samp.group;
            existingItem.hsn_code = samp.hsn_code;
            existingItem.tax_per = samp.tax_per;
            existingItem.convertion_of_pcs = samp.convertion_of_pcs;
            existingItem.price_purchase_rate = samp.price_purchase_rate;
            existingItem.price_value_per_pcs = samp.price_value_per_pcs;
            existingItem.price_avg_weight_per_pcs = samp.price_avg_weight_per_pcs;
            existingItem.price_opening_stock_rate = samp.price_opening_stock_rate;
            existingItem.opening_stock_shop = samp.opening_stock_shop;
            existingItem.stock_shop = samp.stock_shop;
            existingItem.opening_stock_godown = samp.opening_stock_godown;
            existingItem.stock_godown = samp.stock_godown;
            existingItem.total_stock = samp.total_stock;
            existingItem.item_type = samp.item_type;


            foreach (var key in samp.ItemTransMixDetailKey)
            {
                ItemTransMixDetail exitingdata =  DB.ItemTransMixDetail.Where(e=>e.id == key.id && e.delete_at == 0).FirstOrDefault();
               
                if(exitingdata != null)
                {
                    exitingdata.item_name = key.item_name;
                    exitingdata.item_qty = key.item_qty;
                    exitingdata.item_rate = key.item_rate;
                    exitingdata.item_type = key.item_type;

                }
                else
                {
                    ItemTransMixDetail SampData1 = new ItemTransMixDetail
                    {
                        item_name = key.item_name,
                        item_qty = key.item_qty,
                        item_rate = key.item_rate,
                        item_master_id = existingItem.id,
                        item_type = key.item_type

                    };

                    DB.ItemTransMixDetail.Add(SampData1);

                }
                DB.SaveChanges();
            }

            DB.SaveChanges();


            foreach (var key in samp.ItemTransMixDetailDeleteKey)
            {
                ItemTransMixDetail existingDeleteData = DB.ItemTransMixDetail.Where(e => e.id == key.id).FirstOrDefault();
                if (existingDeleteData != null)
                {
                    existingDeleteData.delete_at = 1;
                    DB.SaveChanges();
                }
            }

            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public ItemMasterResp DeleteItemMaster(long itemId)
        {
            ItemMaster del = DB.ItemMaster.Include(e=> e.ItemTransMixDetail)
            .SingleOrDefault(x => x.id == itemId && x.delete_at == 0);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            if(del.ItemTransMixDetail != null)
            {
                foreach (var item in del.ItemTransMixDetail)
                {
                    item.delete_at = 1;
                }
                DB.SaveChanges();
            }


            del.delete_at = 1;
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