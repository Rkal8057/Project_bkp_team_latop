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
    public class Bill_Rent_MasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public Bill_Rent_MasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public Bill_Rent_MasterResp InsertBill_Rent_Master(Bill_Rent_MasterReq samp)
        {

            Bill_Rent_Master sampData = new Bill_Rent_Master()
            {
                bill_date = samp.bill_date,
                bill_upto = samp.bill_upto,
                bill_from = samp.bill_from,
                bill_to = samp.bill_to,
                bill_text = samp.bill_text,
                itemname = samp.itemname,
                open_stock = samp.open_stock,
                iss_stock = samp.iss_stock,
                rec_stock = samp.rec_stock,
                close_stock = samp.close_stock,
                days = samp.days,
                numbers = samp.numbers,
                amt_number_wise = samp.amt_number_wise,
                rent_rate = samp.rent_rate,
                amt = samp.amt,
                vat_cst = samp.vat_cst,
                vat_per = samp.vat_per,
                tax_amt = samp.tax_amt,
                rounded_off_amt = samp.rounded_off_amt,
                amt_after_vat_cst = samp.amt_after_vat_cst,
                cartage_amt = samp.cartage_amt,
                trip_nos = samp.trip_nos,
                misc_charges = samp.misc_charges,
                misc_charges_detail = samp.misc_charges_detail,
                gross_amt = samp.gross_amt,
                outstanding_amt_date = samp.outstanding_amt_date,
                outstanding_amt = samp.outstanding_amt,
                payment_rec_in_period = samp.payment_rec_in_period,
                amount_due = samp.amount_due,
                amt_in_words = samp.amt_in_words,
                breakage_amt = samp.breakage_amt,
                missing_amt = samp.missing_amt,
                add1 = samp.add1,
                add2 = samp.add2,
                add3 = samp.add3,
                add4 = samp.add4,
                bill_from_2 = samp.bill_from_2,
                bill_to_2 = samp.bill_to_2,
                bill_date_2 = samp.bill_date_2,
                bill_no = samp.bill_no,
                final_y_n = samp.final_y_n,
                invoice_type = samp.invoice_type,
                billing_on_pp_pc_rmt = samp.billing_on_pp_pc_rmt,
                agr_uni_code = samp.agr_uni_code,
                agr_code = samp.agr_code,
                agr_name = samp.agr_name,
                item_balance = samp.item_balance,
                total_item_balance = samp.total_item_balance,
                billno = samp.billno,
                challanno = samp.challanno,
                sale_type = samp.sale_type,
                auto_matic_billno = samp.auto_matic_billno,
                //igst_per = samp.igst_per,
                //igst_amt = samp.igst_amt,
                //sgst_per = samp.sgst_per,
                //sgst_amt = samp.sgst_amt,
                //cgst_per = samp.cgst_per,
                //cgst_amt = samp.cgst_amt,
                gst_type = samp.gst_type,
                b_hsn_code = samp.b_hsn_code,
                state_code = samp.state_code,
                state_name = samp.state_name,
                p_gstno = samp.p_gstno
            };

            if (samp.gst_type == "IGST")
            {
                sampData.igst_amt = (decimal)samp.tax_amt;
                sampData.igst_per = (decimal)samp.tax_code;
                sampData.cgst_amt = 0;
                sampData.cgst_per = 0;
                sampData.sgst_amt = 0;
                sampData.sgst_per = 0;
            }
            else if (samp.gst_type == "SGST-CGST")
            {
                sampData.cgst_amt = (decimal)samp.tax_amt / 2;
                sampData.cgst_per = samp.tax_code != null ? (decimal)samp.tax_code / 2 : 0;
                sampData.sgst_amt = (decimal)samp.tax_amt / 2;
                sampData.sgst_per = samp.tax_code != null ? (decimal)samp.tax_code / 2 : 0;
                sampData.igst_amt = 0;
                sampData.igst_per = 0;
            }




            DB.Bill_Rent_Master.Add(sampData);
            DB.SaveChanges();


            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public Bill_Rent_MasterResp GetAllBill_Rent_Master(int pageNo, int limit, string searchKey)
        {

            IQueryable<Bill_Rent_Master> query = DB.Bill_Rent_Master.Where(e=>e.delete == 0 );

            if (!string.IsNullOrEmpty(searchKey))
            {
               query = query.Where(e => EF.Functions.Like(e.state_name, $"%{searchKey}%"));
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

            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "data fetched successfully",
               Bill_Rent_MasterData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public Bill_Rent_MasterResp GetBill_Rent_MasterById(long billId)
        {

            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                Bill_Rent_MasterById = DB.Bill_Rent_Master.Where(e=> e.id == billId && e.delete == 0).FirstOrDefault(),
            };


            return data;
        }

        public Bill_Rent_MasterResp UpdateBill_Rent_Master(long billId, Bill_Rent_MasterReq samp)
        {
            var existingCategory = DB.Bill_Rent_Master.Find(billId);

            if (existingCategory == null)
            {

                Bill_Rent_MasterResp data1 = new Bill_Rent_MasterResp()
                {
                    status = false,
                    Message = "Bill not found"
                };

                existingCategory.bill_date = samp.bill_date;
                existingCategory.bill_upto = samp.bill_upto;
                existingCategory.bill_from = samp.bill_from;
                existingCategory.bill_to = samp.bill_to;
                existingCategory.bill_text = samp.bill_text;
                existingCategory.itemname = samp.itemname;
                existingCategory.open_stock = samp.open_stock;
                existingCategory.iss_stock = samp.iss_stock;
                existingCategory.rec_stock = samp.rec_stock;
                existingCategory.close_stock = samp.close_stock;
                existingCategory.days = samp.days;
                existingCategory.numbers = samp.numbers;
                existingCategory.amt_number_wise = samp.amt_number_wise;
                existingCategory.rent_rate = samp.rent_rate;
                existingCategory.amt = samp.amt;
                existingCategory.vat_cst = samp.vat_cst;
                existingCategory.vat_per = samp.vat_per;
                existingCategory.tax_amt = samp.tax_amt;
                existingCategory.rounded_off_amt = samp.rounded_off_amt;
                existingCategory.amt_after_vat_cst = samp.amt_after_vat_cst;
                existingCategory.cartage_amt = samp.cartage_amt;
                existingCategory.trip_nos = samp.trip_nos;
                existingCategory.misc_charges = samp.misc_charges;
                existingCategory.misc_charges_detail = samp.misc_charges_detail;
                existingCategory.gross_amt = samp.gross_amt;
                existingCategory.outstanding_amt_date = samp.outstanding_amt_date;
                existingCategory.outstanding_amt = samp.outstanding_amt;
                existingCategory.payment_rec_in_period = samp.payment_rec_in_period;
                existingCategory.amount_due = samp.amount_due;
                existingCategory.amt_in_words = samp.amt_in_words;
                existingCategory.breakage_amt = samp.breakage_amt;
                existingCategory.missing_amt = samp.missing_amt;
                existingCategory.add1 = samp.add1;
                existingCategory.add2 = samp.add2;
                existingCategory.add3 = samp.add3;
                existingCategory.add4 = samp.add4;
                existingCategory.bill_from_2 = samp.bill_from_2;
                existingCategory.bill_to_2 = samp.bill_to_2;
                existingCategory.bill_date_2 = samp.bill_date_2;
                existingCategory.bill_no = samp.bill_no;
                existingCategory.final_y_n = samp.final_y_n;
                existingCategory.invoice_type = samp.invoice_type;
                existingCategory.billing_on_pp_pc_rmt = samp.billing_on_pp_pc_rmt;
                existingCategory.agr_uni_code = samp.agr_uni_code;
                existingCategory.agr_code = samp.agr_code;
                existingCategory.agr_name = samp.agr_name;
                existingCategory.item_balance = samp.item_balance;
                existingCategory.total_item_balance = samp.total_item_balance;
                existingCategory.billno = samp.billno;
                existingCategory.challanno = samp.challanno;
                existingCategory.sale_type = samp.sale_type;
                existingCategory.auto_matic_billno = samp.auto_matic_billno;
                existingCategory.igst_per = samp.igst_per;
                existingCategory.igst_amt = samp.igst_amt;
                existingCategory.sgst_per = samp.sgst_per;
                existingCategory.sgst_amt = samp.sgst_amt;
                existingCategory.cgst_per = samp.cgst_per;
                existingCategory.cgst_amt = samp.cgst_amt;
                existingCategory.gst_type = samp.gst_type;
                existingCategory.b_hsn_code = samp.b_hsn_code;
                existingCategory.state_code = samp.state_code;
                existingCategory.state_name = samp.state_name;
                existingCategory.p_gstno = samp.p_gstno;

                return data1;
            }


            DB.SaveChanges();

            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public Bill_Rent_MasterResp DeleteBill_Rent_Master(long billId)
        {

            Bill_Rent_Master del = DB.Bill_Rent_Master
                                            .SingleOrDefault(parent => parent.id == billId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            DB.Remove(del);
            //del.delete = 1;
            DB.SaveChanges();

            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;




        }

        public Bill_Rent_MasterResp GetLastBillMasterId(string? irFlag)
        {
            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                lastId = (long)(DB.Bill_Rent_Master.Max(u => (long?)u.id) ?? 0)
                //lastId = (long)(DB.IssueReceiptMaster
                //    .Where(u => u.irflag == irFlag) 
                //    .Max(u => (long?)u.id) ?? 0)


            };
            return data;
        }


        public Bill_Rent_MasterResp GetChallanMasterByFilter(DateTime? fromDate, DateTime? toDate, string? partyName)
        {
            // Query to filter the data based on the provided parameters
            var challanQuery = DB.IssueReceiptMaster.
                Include( e=> e.IssueReceiptTransDetail)
                .Include(e => e.IssueReceiptMiscTransDetail)
                .Include(e=> e.IssueReceiptBreakageTransDetail)
                .Where(e=> e.delete_at == 0)
                .AsQueryable();

            if (fromDate.HasValue)
            {
                challanQuery = challanQuery.Where(challan => challan.bill_date >= fromDate.Value.Date);
            }

            if (toDate.HasValue)
            {
                challanQuery = challanQuery.Where(challan => challan.bill_date <= toDate.Value.Date);
            }

            if (!string.IsNullOrEmpty(partyName))
            {
                challanQuery = challanQuery.Where(challan => challan.pname.Contains(partyName));
            }

            var challanList = challanQuery.ToList();

            // Create the response object
            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                issueReceiptMasters = challanList 
            };

            return data;
        }



        public Bill_Rent_MasterResp GetBillMasterByLastRecords(long? billId)
        {
            IQueryable<Bill_Rent_Master> query = DB.Bill_Rent_Master.OrderByDescending(x => x.id);

            if (billId != null)
            {
                query = query.Where(x => x.id != billId);
            }

            Bill_Rent_MasterResp data = new Bill_Rent_MasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                Bill_Rent_MasterData = query.Take(5).ToList()
            };

            return data;
        }
    }
}