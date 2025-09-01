using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics;

namespace RTA.Masters
{
    public class WarrantyExtendedBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public WarrantyExtendedBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public WarrantyExtendedResp InsertWarrantyExtendedMaster(WarrantyExtendedReq samp)
        {

            long lastId = (long)(DB.WarrantyExtended
                     //.Where(u => u.irflag == samp.irflag)
                     .Max(u => (long?)u.id) ?? 0);
            string currentDate = DateTime.Now.ToString("yyyyMMdd");
            var serial_no = $"{currentDate}_{samp.challan_id}_{samp.item_code}_{lastId + 1}";


            WarrantyExtended newWarranty = new WarrantyExtended
            {
                item_code = samp.item_code,
                issue_challan_single_item_id= samp.issue_challan_single_item_id,
                party_code = samp.party_code,
                warranty_start_date = samp.warranty_start_date,
                warranty_end_date = samp.warranty_end_date,
                warranty_period = samp.warranty_period,
                coverage_details = samp.coverage_details,
                warranty_cost = samp.warranty_cost,
                warranty_gst_percentage = samp.warranty_gst_percentage,
                warranty_gst_amount = samp.warranty_gst_amount,
                warranty_final_amount = samp.warranty_final_amount,
                warranty_visit_slot = samp.warranty_visit_slot,
                warranty_serial_no = serial_no,
                warranty_item_mode = samp.warranty_item_mode
            };

            DB.WarrantyExtended.Add(newWarranty);
            DB.SaveChanges();

            if( samp.WarrantyExtendedItemTransKey != null)
            {
                foreach( var key in samp.WarrantyExtendedItemTransKey) 
                {
                    WarrantyExtendedItemTran SampData = new WarrantyExtendedItemTran
                    {

                        warranty_master_id = newWarranty.id,
                        item_code = key.item_code,
                        warranty_serial_no = key.warranty_serial_no,
                        warranty_qty = key.warranty_qty,
                        warranty_period = key.warranty_period,
                        warranty_visit_type = key.warranty_visit_type, // online/offline
                        warranty_start_date = key.warranty_start_date,
                        warranty_end_date = key.warranty_end_date,
                        warranty_visit_date = key.warranty_visit_date,
                        warranty_charge_after_amc_expire = key.warranty_charge_after_amc_expire,
                        warranty_charge = key.warranty_charge,
                        warranty_gst_percentage = key.warranty_gst_percentage,
                        warranty_gst_amount = key.warranty_gst_amount,
                        warranty_final_amount = key.warranty_final_amount,
                        warranty_visit_slot = key.warranty_visit_slot,
                        warranty_visit_gap = key.warranty_visit_gap,
                        warranty_visit_charge = key.warranty_visit_charge
                    };

                    DB.WarrantyExtendedItemTran.Add(SampData);
                    DB.SaveChanges();


                    if (samp.WarrantyExtendedItemWarrantyTransKey != null)
                    {
                        foreach (var keyt in samp.WarrantyExtendedItemWarrantyTransKey)
                        {
                            WarrantyExtendedItemWarrantyTrans SampData1 = new WarrantyExtendedItemWarrantyTrans
                            {
                                warranty_serial_no = keyt.warranty_serial_no,
                                warranty_period = keyt.warranty_period,
                                warranty_visit_slot = keyt.warranty_visit_slot,
                                warranty_visit_charge = keyt.warranty_visit_charge,
                                warranty_trns_master_id = SampData.id,
                                warranty_master_id = newWarranty.id,
                                item_name = keyt.item_name,
                                item_code = keyt.item_code,
                                warranty_visit_start_date = keyt.warranty_visit_start_date,
                                warranty_visit_end_date = keyt.warranty_visit_end_date,
                                warranty_flag = keyt.warranty_flag,

                            };
                            DB.WarrantyExtendedItemWarrantyTrans.Add(SampData1);
                            DB.SaveChanges();
                        }
                    }
                }
            }

            

            //if (samp.IssueReceiptTransWarrantyArrayKeys != null)
            //{
            //    foreach (var key in samp.IssueReceiptTransWarrantyArrayKeys)
            //    {

            //        IssueReceiptTransWarrantyDetail sampData = new IssueReceiptTransWarrantyDetail
            //        {
            //            warranty_period = key.warranty_period,
            //            warranty_visit_slot = key.warranty_visit_slot,
            //            warranty_visit_charge = key.warranty_visit_charge,
            //            challan_master_id = key.challan_master_id,
            //            item_name = key.item_name,
            //            item_code = key.item_code,
            //            warranty_visit_date = key.warranty_visit_date,
            //            warranty_serial_no = serial_no,
            //            warranty_flag = key.warranty_flag,
            //        };


            //        DB.IssueReceiptTransWarrantyDetail.Add(sampData);
            //        DB.SaveChanges();
            //    }
            //}

            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "Inserted successfully",
            };
            return data;
        }


        //public WarrantyExtendedResp UpdateWarrantyExtendedMaster( long warrantyId ,WarrantyExtendedReq samp)
        //{
        //    var checkWarranty = DB.WarrantyExtended.Where( e=> e.id == warrantyId).FirstOrDefault();
            
        //    /*checkWarranty.item_code = samp.item_code;
        //    checkWarranty.party_code = samp.party_code;*/
        //    checkWarranty.warranty_start_date = samp.warranty_start_date;
        //    checkWarranty.warranty_end_date = samp.warranty_end_date;
        //    checkWarranty.coverage_details = samp.coverage_details;
        //    checkWarranty.warranty_cost = samp.warranty_cost;
        //    checkWarranty.warranty_serial_no = samp.warranty_serial_no;

        //    DB.SaveChanges();



        //    //long lastId = (long)(DB.IssueReceiptTransDetail
        //    //         .Where(u => u.irflag == samp.irflag)
        //    //         .Max(u => (long?)u.id) ?? 0);
        //    //string currentDate = DateTime.Now.ToString("yyyyMMdd");
        //    //var serial_no = $"{currentDate}_{samp.challan_id}_{samp.item_code}_{lastId + 1}";




        //    //if (samp.IssueReceiptTransWarrantyArrayKeys != null)
        //    //{
        //    //    foreach (var key in samp.IssueReceiptTransWarrantyArrayKeys)
        //    //    {

        //    //        IssueReceiptTransWarrantyDetail sampData = new IssueReceiptTransWarrantyDetail
        //    //        {
        //    //            warranty_period = key.warranty_period,
        //    //            warranty_visit_slot = key.warranty_visit_slot,
        //    //            warranty_visit_charge = key.warranty_visit_charge,
        //    //            challan_master_id = key.challan_master_id,
        //    //            item_name = key.item_name,
        //    //            item_code = key.item_code,
        //    //            warranty_visit_date = key.warranty_visit_date,
        //    //            warranty_serial_no = serial_no,
        //    //            warranty_flag = key.warranty_flag,
        //    //        };


        //    //        DB.IssueReceiptTransWarrantyDetail.Add(sampData);
        //    //        DB.SaveChanges();
        //    //    }
        //    //}

        //    WarrantyExtendedResp data = new WarrantyExtendedResp()
        //    {
        //        status = true,
        //        Message = "Updated successfully",
        //    };
        //    return data;
        //}
        public WarrantyExtendedResp UpdateWarrantyExtendedMaster(long warrantyId ,WarrantyExtendedReq samp)
        {
          
                try
                {
                    // Find the existing warranty record by ID
                    var existingWarranty = DB.WarrantyExtended.FirstOrDefault(w => w.id == samp.id);

                    if (existingWarranty == null)
                    {
                        return new WarrantyExtendedResp
                        {
                            status = false,
                            Message = "Warranty record not found."
                        };
                    }

                    // Update the fields of the existing warranty
                    existingWarranty.item_code = samp.item_code;
                    existingWarranty.issue_challan_single_item_id = samp.issue_challan_single_item_id;
                    existingWarranty.party_code = samp.party_code;
                    existingWarranty.warranty_start_date = samp.warranty_start_date;
                    existingWarranty.warranty_end_date = samp.warranty_end_date;
                    existingWarranty.warranty_period = samp.warranty_period;
                    existingWarranty.coverage_details = samp.coverage_details;
                    existingWarranty.warranty_cost = samp.warranty_cost;
                    existingWarranty.warranty_gst_percentage = samp.warranty_gst_percentage;
                    existingWarranty.warranty_gst_amount = samp.warranty_gst_amount;
                    existingWarranty.warranty_final_amount = samp.warranty_final_amount;
                    existingWarranty.warranty_visit_slot = samp.warranty_visit_slot;
                    existingWarranty.warranty_item_mode = samp.warranty_item_mode;

                    DB.SaveChanges();

                    // Update WarrantyExtendedItemTransKey if present
                    if (samp.WarrantyExtendedItemTransKey != null)
                    {
                        // Remove existing related records first
                           
                        foreach (var key in samp.WarrantyExtendedItemTransKey)
                        {
                            var existingItemTrans = DB.WarrantyExtendedItemTran
                           .Where(w => w.warranty_master_id == key.id)
                           .FirstOrDefault();


                            if (existingItemTrans != null)
                            {
                                //existingItemTrans.warranty_master_id = existingWarranty.id;
                                existingItemTrans.item_code = key.item_code;
                                existingItemTrans.warranty_serial_no = key.warranty_serial_no;
                                existingItemTrans.warranty_qty = key.warranty_qty;
                                existingItemTrans.warranty_period = key.warranty_period;
                                existingItemTrans.warranty_visit_type = key.warranty_visit_type;
                                existingItemTrans.warranty_start_date = key.warranty_start_date;
                                existingItemTrans.warranty_end_date = key.warranty_end_date;
                                existingItemTrans.warranty_visit_date = key.warranty_visit_date;
                                existingItemTrans.warranty_charge_after_amc_expire = key.warranty_charge_after_amc_expire;
                                existingItemTrans.warranty_charge = key.warranty_charge;
                                existingItemTrans.warranty_gst_percentage = key.warranty_gst_percentage;
                                existingItemTrans.warranty_gst_amount = key.warranty_gst_amount;
                                existingItemTrans.warranty_final_amount = key.warranty_final_amount;

                            }
                            else
                            {
                                WarrantyExtendedItemTran sampData = new WarrantyExtendedItemTran
                                {
                                    warranty_master_id = existingWarranty.id,
                                    item_code = key.item_code,
                                    warranty_serial_no = key.warranty_serial_no,
                                    warranty_qty = key.warranty_qty,
                                    warranty_period = key.warranty_period,
                                    warranty_visit_type = key.warranty_visit_type,
                                    warranty_start_date = key.warranty_start_date,
                                    warranty_end_date = key.warranty_end_date,
                                    warranty_visit_date = key.warranty_visit_date,
                                    warranty_charge_after_amc_expire = key.warranty_charge_after_amc_expire,
                                    warranty_charge = key.warranty_charge,
                                    warranty_gst_percentage = key.warranty_gst_percentage,
                                    warranty_gst_amount = key.warranty_gst_amount,
                                    warranty_final_amount = key.warranty_final_amount
                                };

                                DB.WarrantyExtendedItemTran.Add(sampData);
                            }
                                DB.SaveChanges();
                        }
                       
                    }

                    // Uncomment and handle IssueReceiptTransWarrantyArrayKeys if needed
                    /*
                    if (samp.IssueReceiptTransWarrantyArrayKeys != null)
                    {
                        // Remove existing IssueReceiptTransWarrantyDetail records
                        var existingReceiptTrans = DB.IssueReceiptTransWarrantyDetail
                            .Where(i => i.warranty_serial_no == existingWarranty.warranty_serial_no)
                            .ToList();

                        DB.IssueReceiptTransWarrantyDetail.RemoveRange(existingReceiptTrans);
                        DB.SaveChanges();

                        // Add updated records
                        var issueReceiptTransDetails = new List<IssueReceiptTransWarrantyDetail>();

                        foreach (var key in samp.IssueReceiptTransWarrantyArrayKeys)
                        {
                            IssueReceiptTransWarrantyDetail sampData = new IssueReceiptTransWarrantyDetail
                            {
                                warranty_period = key.warranty_period,
                                warranty_visit_slot = key.warranty_visit_slot,
                                warranty_visit_charge = key.warranty_visit_charge,
                                challan_master_id = key.challan_master_id,
                                item_name = key.item_name,
                                item_code = key.item_code,
                                warranty_visit_date = key.warranty_visit_date,
                                warranty_serial_no = existingWarranty.warranty_serial_no,
                                warranty_flag = key.warranty_flag,
                            };

                            issueReceiptTransDetails.Add(sampData);
                        }

                        DB.IssueReceiptTransWarrantyDetail.AddRange(issueReceiptTransDetails);
                        DB.SaveChanges();
                    }
                    */

                    return new WarrantyExtendedResp
                    {
                        status = true,
                        Message = "Updated successfully",
                    };
                }
                catch (Exception ex)
                {
                    return new WarrantyExtendedResp
                    {
                        status = false,
                        Message = $"An error occurred: {ex.Message}",
                    };
                }
            
        }


        public WarrantyExtendedResp GetWarrantyExtendedMasterList()
        {
            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "data fetched successfully",
                WarrantyExtendedData = DB.WarrantyExtended.ToList()
            };
            return data;
        }



        public WarrantyExtendedResp GetWarrantyExtendedMasterById(long warrantyId)
        {
            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "data fetched successfully",
                WarrantyExtendedDataByID = DB.WarrantyExtended
                .Include(e => e.WarrantyExtendedItemTrans)
                .Where(e => e.id == warrantyId).FirstOrDefault(),

                WarrantyExtendedItemWarrantyTrans= DB.WarrantyExtendedItemWarrantyTrans.Where(e=> e.warranty_master_id == warrantyId).ToList(),
            };
            return data;
        }

        public WarrantyExtendedResp DeleteWarrantyExtendedMaster(long warrantyId)
        {
            WarrantyExtended del = DB.WarrantyExtended.Where(x => x.id == warrantyId)
                                   .SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete_at = 1;
            DB.SaveChanges();

            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }



        public WarrantyExtendedResp GetAllIssueChallanSingleItem(string? searchKey = null)
        {

            IQueryable<IssueReceiptTransDetail> query = DB.IssueReceiptTransDetail.Where(e => e.delete_at == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                      //EF.Functions.Like(e.billno_automatic, $"%{searchKey}%") ||
                      EF.Functions.Like(e.warranty_serial_no, $"%{searchKey}%") ||
                      EF.Functions.Like(e.item_name, $"%{searchKey}%") ||
                      EF.Functions.Like(e.pname, $"%{searchKey}%"));
            }

            var filteredData = query.Take(10).ToList();

            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "data fetched successfully",
                IssueReceiptTransData = filteredData
            };
            return data;
        }



        public WarrantyExtendedResp GetIssueChallanSingleItemById(long? challanId , long? itemId)
        {

            var checkSingleItem = DB.IssueReceiptTransDetail.Where(e => e.id == itemId).FirstOrDefault();

            var singleItemWarrantyVisitList = DB.IssueReceiptTransWarrantyDetail
                .Where( e => e.warranty_serial_no == checkSingleItem.warranty_serial_no 
                && e.warranty_flag == "new_warranty").ToList();

            var extendedWarranty = DB.WarrantyExtended.Where(e => e.issue_challan_single_item_id == itemId).FirstOrDefault();

            var singleItemWarrantyExtendedDetail = DB.IssueReceiptTransWarrantyDetail
             .Where(e => e.challan_master_id == challanId && e.item_code == checkSingleItem.item_code
              && e.warranty_flag == "extend_warranty").ToList();

            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "data fetched successfully",
                IssueReceiptTransById = checkSingleItem,
                IssueReceiptTransWarrantyDetail = singleItemWarrantyVisitList,
                WarrantyExtendedDataByID = extendedWarranty,
                IssueReceiptExtendedWarrantyTrans = singleItemWarrantyExtendedDetail,
            };
            return data;
        }


        public WarrantyExtendedResp GetLastIdWarrantyExtended()
        {
            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "data fetched successfully",
                lastId = (long)(DB.WarrantyExtended.Max(u => (long?)u.id) ?? 0)
            };
            return data;
        }

    }
}