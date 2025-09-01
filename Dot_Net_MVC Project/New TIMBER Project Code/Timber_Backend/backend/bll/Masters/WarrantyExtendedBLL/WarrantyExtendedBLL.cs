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

            long lastId = (long)(DB.IssueReceiptTransDetail
                     .Where(u => u.irflag == samp.irflag)
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
                warranty_serial_no = serial_no
            };

            DB.WarrantyExtended.Add(newWarranty);
            DB.SaveChanges();

            /*
             * irflag name  reqyured
             * challan id  
             * item id 
             */

            if (samp.IssueReceiptTransWarrantyArrayKeys != null)
            {
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
                        warranty_serial_no = serial_no,
                        warranty_flag = key.warranty_flag,
                    };


                    DB.IssueReceiptTransWarrantyDetail.Add(sampData);
                    DB.SaveChanges();
                }
            }

            WarrantyExtendedResp data = new WarrantyExtendedResp()
            {
                status = true,
                Message = "Inserted successfully",
            };
            return data;
        }


        public WarrantyExtendedResp UpdateWarrantyExtendedMaster( long warrantyId ,WarrantyExtendedReq samp)
        {
            var checkWarranty = DB.WarrantyExtended.Where( e=> e.id == warrantyId).FirstOrDefault();
            
            /*checkWarranty.item_code = samp.item_code;
            checkWarranty.party_code = samp.party_code;*/
            checkWarranty.warranty_start_date = samp.warranty_start_date;
            checkWarranty.warranty_end_date = samp.warranty_end_date;
            checkWarranty.coverage_details = samp.coverage_details;
            checkWarranty.warranty_cost = samp.warranty_cost;
            checkWarranty.warranty_serial_no = samp.warranty_serial_no;

            DB.SaveChanges();



            //long lastId = (long)(DB.IssueReceiptTransDetail
            //         .Where(u => u.irflag == samp.irflag)
            //         .Max(u => (long?)u.id) ?? 0);
            //string currentDate = DateTime.Now.ToString("yyyyMMdd");
            //var serial_no = $"{currentDate}_{samp.challan_id}_{samp.item_code}_{lastId + 1}";




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
                Message = "Updated successfully",
            };
            return data;
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
                .Where(e => e.id == warrantyId).FirstOrDefault()
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

    }
}