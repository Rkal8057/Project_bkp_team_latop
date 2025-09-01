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
                item_type = samp.item_type,
                item_packing_type= samp.item_packing_type,




                price_purchase_discount_percentage = samp.price_purchase_discount_percentage,
                price_purchase_discount_amt = samp.price_purchase_discount_amt,
                price_purchase_amount_after_discount = samp.price_purchase_amount_after_discount,
                price_purchase_packing_cost = samp.price_purchase_packing_cost,
                price_purchase_packing_cost_incl_yn = samp.price_purchase_packing_cost_incl_yn,
                price_purchase_amount_with_packing_cost = samp.price_purchase_amount_with_packing_cost,
                price_purchase_gst_percentage = samp.price_purchase_gst_percentage,
                price_purchase_gst_amount = samp.price_purchase_gst_amount,
                price_purchase_amount_with_gst = samp.price_purchase_amount_with_gst,
                price_purchase_margin_profit_percentage = samp.price_purchase_margin_profit_percentage,
                price_purchase_margin_profit_amount = samp.price_purchase_margin_profit_amount,
                price_purchase_rate_approx = samp.price_purchase_rate_approx,






                price_sell_rate = samp.price_sell_rate,
                price_sell_discount_percentage = samp.price_sell_discount_percentage,
                price_sell_discount_amount = samp.price_sell_discount_amount,
                price_sell_amount_after_discount = samp.price_sell_amount_after_discount,
                price_sell_gst_percentage = samp.price_sell_gst_percentage,
                price_sell_gst_amount = samp.price_sell_gst_amount,
                price_sell_amount_with_gst = samp.price_sell_amount_with_gst,

                purchase_unit_name = samp.purchase_unit_name,
                purchase_unit_qty = samp.purchase_unit_qty,
                sale_unit_name = samp.sale_unit_name,

                item_barcode_no = samp.item_barcode_no,
                item_remark_no = samp.item_remark_no,

                item_min_qty = samp.item_min_qty,
                 item_reorder_qty = samp.item_reorder_qty,
                item_max_qty = samp.item_max_qty,

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



            foreach (var key in samp.ItemTransStockDetailKey)
            {
                ItemTransStockDetail SampData2 = new ItemTransStockDetail
                {
                    item_stock_date = key.item_stock_date,
                    item_stock_location = key.item_stock_location,
                    item_stock_qty = key.item_stock_qty,
                    item_stock_rate = key.item_stock_rate,
                    item_stock_value = key.item_stock_value,
                    item_master_id = SampData.id,

                    item_batch_no = key.item_batch_no,
                    item_style = key.item_style,
                    item_brand = key.item_brand,
                    item_color = key.item_color,
                    item_agent = key.item_agent,
                    item_dealer = key.item_dealer
                };

                DB.ItemTransStockDetail.Add(SampData2);
            }


            foreach (var key in samp.Remark_Upload_Detail_Key)
            {
                Remark_Upload_Detail SampData3 = new Remark_Upload_Detail
                {
                    upload_document_path = key.upload_document_path,
                    attended_by = key.attended_by,
                    remarks = key.remarks,
                    item_master_id = SampData.id,
                    flag_master = "item"
                };

                DB.Remark_Upload_Detail.Add(SampData3);
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
                ItemMasterDetailByID = DB.ItemMaster.Where(e => e.item_name == samp.item_name
                &&  e.delete_at == 0).FirstOrDefault()
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
                 .Include(E => E.ItemTransStockDetail.Where(p => p.delete_at == 0))
                 .Include(E=> E.Remark_Upload_Detail.Where(p => p.delete_at == 0))
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
            existingItem.item_packing_type = samp.item_packing_type;
            existingItem.item_barcode_no = samp.item_barcode_no;
            existingItem.item_remark_no = samp.item_remark_no;

            existingItem.price_purchase_discount_percentage = samp.price_purchase_discount_percentage;
            existingItem.price_purchase_discount_amt = samp.price_purchase_discount_amt;
            existingItem.price_purchase_amount_after_discount = samp.price_purchase_amount_after_discount;
            existingItem.price_purchase_packing_cost = samp.price_purchase_packing_cost;
            existingItem.price_purchase_packing_cost_incl_yn = samp.price_purchase_packing_cost_incl_yn;
            existingItem.price_purchase_amount_with_packing_cost = samp.price_purchase_amount_with_packing_cost;
            existingItem.price_purchase_gst_percentage = samp.price_purchase_gst_percentage;
            existingItem.price_purchase_gst_amount = samp.price_purchase_gst_amount;
            existingItem.price_purchase_amount_with_gst = samp.price_purchase_amount_with_gst;
            existingItem.price_purchase_margin_profit_percentage = samp.price_purchase_margin_profit_percentage;
            existingItem.price_purchase_margin_profit_amount = samp.price_purchase_margin_profit_amount;
            existingItem.price_purchase_rate_approx = samp.price_purchase_rate_approx;

            existingItem.price_sell_rate = samp.price_sell_rate;
            existingItem.price_sell_discount_percentage = samp.price_sell_discount_percentage;
            existingItem.price_sell_discount_amount = samp.price_sell_discount_amount;
            existingItem.price_sell_amount_after_discount = samp.price_sell_amount_after_discount;
            existingItem.price_sell_gst_percentage = samp.price_sell_gst_percentage;
            existingItem.price_sell_gst_amount = samp.price_sell_gst_amount;
            existingItem.price_sell_amount_with_gst = samp.price_sell_amount_with_gst;

            existingItem.purchase_unit_name = samp.purchase_unit_name;
            existingItem.purchase_unit_qty = samp.purchase_unit_qty;
            existingItem.sale_unit_name = samp.sale_unit_name;



            existingItem.item_min_qty = samp.item_min_qty;
            existingItem.item_reorder_qty = samp.item_reorder_qty;
            existingItem.item_max_qty = samp.item_max_qty;


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


            foreach (var key in samp.ItemTransStockDetailKey)
            {
                ItemTransStockDetail exitingdata = DB.ItemTransStockDetail.Where(e => e.id == key.id && e.delete_at == 0).FirstOrDefault();

                if (exitingdata != null)
                {
                    exitingdata.item_stock_date = key.item_stock_date;
                    exitingdata.item_stock_location = key.item_stock_location;
                    exitingdata.item_stock_qty = key.item_stock_qty;
                    exitingdata.item_stock_rate = key.item_stock_rate;
                    exitingdata.item_stock_value = key.item_stock_value;


                    exitingdata.item_batch_no = key.item_batch_no;
                    exitingdata.item_style = key.item_style;
                    exitingdata.item_brand = key.item_brand;
                    exitingdata.item_color = key.item_color;
                    exitingdata.item_agent = key.item_agent;
                    exitingdata.item_dealer = key.item_dealer;
                }
                else
                {
                    ItemTransStockDetail SampData2 = new ItemTransStockDetail
                    {
                        item_stock_date = key.item_stock_date,
                        item_stock_location = key.item_stock_location,
                        item_stock_qty = key.item_stock_qty,
                        item_stock_rate = key.item_stock_rate,
                        item_stock_value = key.item_stock_value,
                        item_master_id = existingItem.id,
                        item_batch_no = key.item_batch_no,
                        item_style = key.item_style,
                        item_brand = key.item_brand,
                        item_color = key.item_color,
                        item_agent = key.item_agent,
                        item_dealer = key.item_dealer
                    };

                    DB.ItemTransStockDetail.Add(SampData2);

                }
                DB.SaveChanges();
            }


            foreach (var key in samp.Remark_Upload_Detail_Key)
            {
                Remark_Upload_Detail exitingdata = DB.Remark_Upload_Detail.Where(e => e.id == key.id && e.delete_at == 0).FirstOrDefault();

                if(exitingdata != null)
                {
                    exitingdata.upload_document_path = key.upload_document_path;
                    exitingdata.attended_by = key.attended_by;
                    exitingdata.remarks = key.remarks;
                  
                }else
                {
                    Remark_Upload_Detail SampData3 = new Remark_Upload_Detail
                    {
                        upload_document_path = key.upload_document_path,
                        attended_by = key.attended_by,
                        remarks = key.remarks,
                        item_master_id = existingItem.id,
                        flag_master = "item"
                    };
                    DB.Remark_Upload_Detail.Add(SampData3);
                }
                DB.SaveChanges();

            }

            foreach (var key in samp.ItemTransMixDetailDeleteKey)
            {
                ItemTransMixDetail existingDeleteData = DB.ItemTransMixDetail.Where(e => e.id == key.id).FirstOrDefault();
                if (existingDeleteData != null)
                {
                    existingDeleteData.delete_at = 1;
                    DB.SaveChanges();
                }
            }

            foreach (var key in samp.ItemTransStockDetailDeleteKey)
            {
                ItemTransStockDetail existingDeleteData = DB.ItemTransStockDetail.Where(e => e.id == key.id).FirstOrDefault();
                if (existingDeleteData != null)
                {
                    existingDeleteData.delete_at = 1;
                    DB.SaveChanges();
                }
            }

            foreach (var key in samp.Remove_Remark_Upload_Detail_Key)
            {
                Remark_Upload_Detail existingDeleteData = DB.Remark_Upload_Detail.Where(e => e.id == key.id).FirstOrDefault();
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


        public ItemMasterResp CheckDeleteItemMasterIfExitInMaster(long itemId, string Masterflag)
        {

            if(Masterflag =="item")
            {
                var aggrement = DB.AggrementMaster
                   .Where(e => e.item_code == itemId && e.delete == 0)
                   .FirstOrDefault();

                var partyItemRate = DB.PartyItemRateTrans
                    .Where(e => e.item_code == itemId && e.delete == 0)
                    .FirstOrDefault();


                //var issueReceiptTransDetail = DB.IssueReceiptMaster
                //.Where(e => e.delete_at == 0 && DB.IssueReceiptTransDetail.
                //Any(p => p.delete_at == 0 && p.item_code == itemId && p.challan_master_id == e.id))
                //.ToList();

                var issueReceiptTransDetail = DB.IssueReceiptMaster
                .Include(e => e.IssueReceiptTransDetail.Where(p => p.delete_at == 0 && p.item_code == itemId))
                .Where(e => e.delete_at == 0 && e.IssueReceiptTransDetail.Any(p => p.delete_at == 0 && p.item_code == itemId))
                .ToList();

                if (aggrement != null || partyItemRate != null || issueReceiptTransDetail.Count != 0)
                {

                    ItemMasterResp data1 = new ItemMasterResp()
                    {
                        status = false,
                        Message = "Item cannot be deleted because it exists in:"
                    };


                    if (aggrement != null)
                    {
                        data1.Message += " AggrementMaster";
                        data1.AggrementMaster = aggrement;
                    }

                    if (partyItemRate != null)
                    {
                        data1.Message += " PartyItemRateTrans";
                        data1.PartyItemRateTrans = partyItemRate;
                    }

                    if (issueReceiptTransDetail.Count != 0)
                    {
                        if (aggrement != null || partyItemRate != null)
                        {
                            data1.Message += " and";
                        }
                        data1.Message += " ChallanMaster";
                        data1.IssueReceiptTransDetail = issueReceiptTransDetail;
                    }

                    return data1;
                }

            }

            if (Masterflag == "party")
            {
                var challan = DB.IssueReceiptMaster
                 .Where(e => e.pcode == itemId && e.delete_at == 0)
                 .ToList();

                if (challan.Count != null)
                {
                    ItemMasterResp data1 = new ItemMasterResp()
                    {
                        status = false,
                        Message = "Item cannot be deleted because it exists in:"
                    };

                    if (challan.Count != 0)
                    {

                        data1.Message += " Issue Receipted Detail";
                        data1.IssueReceiptMaster = challan;

                        return data1;
                    }
                }

            }

            if (Masterflag == "partyCategory")
            {
                var partyMaster = DB.PartyMaster
                 .Where(e => e.party_group_category_id == itemId && e.delete_at == 0)
                 .ToList();

                if (partyMaster.Count != 0)
                {
                    ItemMasterResp data1 = new ItemMasterResp()
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

            }
                

            if( Masterflag == "issue")
            {


            }

            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "Item cannot exist in another data",
            };
            return data;
        }




        public ItemMasterResp DeleteItemMaster(
            string Masterflag, long Id, long otp)
        {

            if ( otp != 1234)
            {
                throw new Exception("Invalid OTP");
            }

            if (Masterflag == "item")
            {
                var aggrement = DB.AggrementMaster
                   .Where(e => e.item_code == Id && e.delete == 0)
                   .ToList();


                if (aggrement.Count != 0)
                {
                    foreach (var item in aggrement)
                    {
                        item.delete = 1;
                    }
                }

                var partyItemRate = DB.PartyItemRateTrans
                    .Where(e => e.item_code == Id && e.delete == 0)
                    .ToList();

                if (partyItemRate.Count != 0)
                {
                    // Perform operations on partyItemRate
                    foreach (var rate in partyItemRate)
                    {
                        rate.delete = 1;
                    }
                }

                DB.SaveChanges();

                ItemMaster del = DB.ItemMaster.Include(e => e.ItemTransMixDetail)
                                               .Include(e => e.ItemTransStockDetail)
                                               .SingleOrDefault(x => x.id == Id && x.delete_at == 0);

                if (del != null)
                {
                    del.delete_at = 1;
                }

                DB.SaveChanges();

            }

            if (Masterflag == "party")
            {
                PartyMaster del = DB.PartyMaster.
               Include(e => e.PartyAddressTransMaster).
               Include(e => e.PartyContactTransMaster).
               Include(e => e.AggrementMaster).
               Include(e => e.PartyItemRateTrans).
               Where(x => x.id == Id).SingleOrDefault();

                if (del == null)
                {
                    throw new Exception("RECORD NOT FOUND");
                }


                if (del.PartyAddressTransMaster != null)
                {
                    DB.PartyAddressTransMaster.RemoveRange(del.PartyAddressTransMaster);
                }

                if (del.PartyContactTransMaster != null)
                {
                    DB.PartyContactTransMaster.RemoveRange(del.PartyContactTransMaster);
                }

                if (del.AggrementMaster != null)
                {
                    DB.AggrementMaster.RemoveRange(del.AggrementMaster);
                }

                if (del.PartyItemRateTrans != null)
                {
                    DB.PartyItemRateTrans.RemoveRange(del.PartyItemRateTrans);
                }

                del.delete_at = 1;
                DB.SaveChanges();
            }

            if (Masterflag == "partyCategory")
            {

                PartyCategoryMaster del = DB.PartyCategoryMaster
                    .SingleOrDefault(parent => parent.id == Id);

                if (del == null)
                {
                    throw new Exception("RECORD NOT FOUND");
                }

                del.delete_at = 1;
                DB.SaveChanges();
            }

            if (Masterflag == "issue")
            {
                IssueReceiptMaster del = DB.IssueReceiptMaster.
                 Where(x => x.id == Id)
                 .Include(e => e.IssueReceiptTransDetail)
                 .Include(e => e.IssueReceiptMiscTransDetail)
                 .Include(e => e.IssueReceiptBreakageTransDetail)
                 .Include(e => e.Challan_Single_Item_Master)
                 .SingleOrDefault();

                if (del == null)
                {
                    throw new Exception("RECORD NOT FOUND");
                }

                if (del.IssueReceiptBreakageTransDetail != null)
                {
                    foreach (var e in del.IssueReceiptBreakageTransDetail.ToList())
                    {
                        //DB.IssueReceiptBreakageTransDetail.Remove(e);
                        e.delete_at = 1;

                    }
                }

                if (del.IssueReceiptMiscTransDetail != null)
                {
                    foreach (var e in del.IssueReceiptMiscTransDetail.ToList())
                    {
                        //DB.IssueReceiptMiscTransDetail.Remove(e);
                        e.delete_at = 1;

                    }
                }

                if (del.IssueReceiptTransDetail != null)
                {
                    foreach (var e in del.IssueReceiptTransDetail.ToList())
                    {
                        //DB.IssueReceiptTransDetail.Remove(e);
                        e.delete_at = 1;
                    }
                }


                if (del.Challan_Single_Item_Master != null)
                {
                    foreach (var e in del.Challan_Single_Item_Master.ToList())
                    {
                        //DB.Challan_Single_Item_Master.Remove(e);
                        e.delete_at = 1;
                    }
                }

                del.delete_at = 1;
                DB.SaveChanges();

            }



            ItemMasterResp data = new ItemMasterResp()
            {
                status = true,
                Message = "delete successfully",
            };
            return data;
        }


    }
}