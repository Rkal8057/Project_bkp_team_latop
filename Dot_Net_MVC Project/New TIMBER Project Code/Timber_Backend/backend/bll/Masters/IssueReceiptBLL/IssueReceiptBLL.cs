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

namespace RTA.Masters
{
    public class IssueReceiptMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public IssueReceiptMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public IssueReceiptResp InsertIssueReceiptMaster(IssueReceiptReq samp)
        {


            IssueReceiptMaster SampData = new IssueReceiptMaster()
            {
                billno_automatic = samp.billno_automatic,
                pcode = samp.pcode,
                pname = samp.pname,
                pname_short_code = samp.pname_short_code,
                agr_code_old = samp.agr_code_old,
                agr_no_old = samp.agr_no_old,
                client_type = samp.client_type,
                item_code = samp.item_code,
                item_short_name = samp.item_short_name,
                item_name = samp.item_name,
                item_group_code = samp.item_group_code,
                item_group_name = samp.item_group_name,
                bill_date = samp.bill_date,
                challanno = samp.challanno,
                issue_qty = samp.issue_qty,
                recv_qty = samp.recv_qty,
                irflag = samp.irflag,
                billfr = samp.billfr,
                billto = samp.billto,
                rent_rate = samp.rent_rate,
                broken_amt = samp.broken_amt,
                frshop = samp.frshop,
                froffice = samp.froffice,
                brok_qty = samp.brok_qty,
                brok_rate = samp.brok_rate,
                miss_flag = samp.miss_flag,
                misc_ac_code = samp.misc_ac_code,
                misc_exp_total = samp.misc_exp_total,
                cartcode = samp.cartcode,
                cart_amt = samp.cart_amt,
                remark_note = samp.remark_note,
                prnnarr = samp.prnnarr,
                stkvalue = samp.stkvalue,
                misc1 = samp.misc1,
                misc2 = samp.misc2,
                misc3 = samp.misc3,
                misc4 = samp.misc4,
                misc5 = samp.misc5,
                misc6 = samp.misc6,
                sno = samp.sno,
                contact_prs_ph = samp.contact_prs_ph,
                transporter_name = samp.transporter_name,
                gr_no = samp.gr_no,
                vehicleno = samp.vehicleno,
                driver_name = samp.driver_name,
                dl_no = samp.dl_no,
                permit_no = samp.permit_no,
                contact_prs_ph_no = samp.contact_prs_ph_no,
                apx_weight = samp.apx_weight,
                apx_value = samp.apx_value,
                bill_enter_date = samp.bill_enter_date,
                trip_no = samp.trip_no,
              
                bill_amt = samp.bill_amt,
                rec_type = samp.rec_type,
                tnx_type = samp.tnx_type,
                unit_name = samp.unit_name,
                itemtype = samp.itemtype,
                tax_code = samp.tax_code,
                tax_name = samp.tax_name,
                tax_per = samp.tax_per,
                tax_amt = samp.tax_amt,
                dis_per = samp.dis_per,
                dis_amt = samp.dis_amt,
                gross_amt = samp.gross_amt,
                tot_qty = samp.tot_qty,
                add_off_site = samp.add_off_site,
                hsn_code = samp.hsn_code,
                gst_type = samp.gst_type,
                state_code = samp.state_code,
                //tax_yn = samp.tax_yn,
               
                
                igst_per = samp.igst_per,
                igst_amt = samp.igst_amt,
                sgst_per = samp.sgst_per,
                sgst_amt = samp.sgst_amt,
                cgst_per = samp.cgst_per,
                cgst_amt = samp.cgst_amt,


                reverse_charge = samp.reverse_charge,
                electronic_ref_no = samp.electronic_ref_no,
                ref_2 = samp.ref_2,
                weight_of_one_pcs = samp.weight_of_one_pcs,
                tot_weight_of_pcs = samp.tot_weight_of_pcs,
                manual_billno = samp.manual_billno,
                ordno = samp.ordno,
                ord_date = samp.ord_date,
                trx_code = samp.trx_code,
                trx_name = samp.trx_name,
                pkg = samp.pkg,
                c_form = samp.c_form,
                net_amt = samp.net_amt,
                tot_amt = samp.tot_amt,
                transporter_code = samp.transporter_code,
                fraight = samp.fraight,
                contact_prs = samp.contact_prs,
                site_add = samp.site_add,
                todo = samp.todo,
                amt_in_wor = samp.amt_in_wor,
                duedate = samp.duedate,
                round_off_yn = samp.round_off_yn,
                round_off_amt = samp.round_off_amt,
                station_name = samp.station_name,
                qty_kg = samp.qty_kg,
                tot_kg = samp.tot_kg,
                add1 = samp.add1,
                add2 = samp.add2,
                add3_location = samp.add3_location,
                add4_city = samp.add4_city,
                add5_state = samp.add5_state,
                add6_pincode = samp.add6_pincode,
                add7_state_code = samp.add7_state_code,
                country_name = samp.country_name,
                addr_type = samp.addr_type,
                addr_gst_type = samp.addr_gst_type,
                gstno = samp.gstno,
                rent_on_type = samp.rent_on_type,
                opening_qty = samp.opening_qty,
                issued_bal_on_chal_date = samp.issued_bal_on_chal_date,
                unique_number = samp.unique_number,
                contact_prs_whts_no = samp.contact_prs_whts_no,
                irflag_detail  = samp.irflag_detail,
                final_amount = samp.final_amount,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,

        };

            DB.IssueReceiptMaster.Add(SampData);
            DB.SaveChanges();


            if (samp.ChallanTrnKey != null && samp.ChallanTrnKey.Count > 0)
            {
                foreach (var key in samp.ChallanTrnKey)
                {

                    AggrementMaster checkAggrement = DB.AggrementMaster.Find(key.id);

                    IssueReceiptTransDetail SampData1 = new IssueReceiptTransDetail
                    {
                        challan_master_id = SampData.id,
                        pcode = key.pcode,
                        pname = key.pname,
                        item_code = key.item_code,
                        item_short_name = key.item_short_name,
                        item_name = key.item_name,
                        item_group_code = key.item_group_code,
                        item_group_name = key.item_group_name,
                        unit_name = key.unit_name,
                        itemtype = key.itemtype,
                        issue_qty = key.issue_qty,
                        recv_qty = key.recv_qty,
                        irflag = key.irflag,
                        rent_rate = key.rent_rate,
                        rate_of_one_pcs = key.rate_of_one_pcs,
                        weight_of_one_pcs = key.weight_of_one_pcs,
                        unique_number = samp.unique_number,
                        opening_qty = key.opening_qty,
                        aggrement_id = checkAggrement.id,
                        item_scheme_type_one_pc = key.item_scheme_type_one_pc
                    };


                    DB.IssueReceiptTransDetail.Add(SampData1);
                }

                DB.SaveChanges();
            }


            if (samp.ChallanMiscTranxKey != null)
            {

                foreach (var key in samp.ChallanMiscTranxKey)
                {
                    IssueReceiptMiscTransDetail SampData2 = new IssueReceiptMiscTransDetail
                    {
                        challan_master_id = SampData.id,
                        bill_no_automatic = key.bill_no_automatic,
                        pcode = key.pcode,
                        pname = key.pname,
                        agr_code_old = key.agr_code_old,
                        ch_no = key.ch_no,
                        bill_date = key.bill_date,
                        exp_ac_name = key.exp_ac_name,
                        exp_amt = key.exp_amt,
                        exp_remarks = key.exp_remarks,
                        ir_flag = key.ir_flag,
                        fo_oh = key.fo_oh,
                        unique_number = samp.unique_number

                    };



                    DB.IssueReceiptMiscTransDetail.Add(SampData2);
                }
                DB.SaveChanges();
            }

            if (samp.ChallanBreakageTransKey != null)
            {
                foreach (var breakageKey in samp.ChallanBreakageTransKey)
                {
                    IssueReceiptBreakageTransDetail SampData3 = new IssueReceiptBreakageTransDetail
                    {
                        challan_master_id = SampData.id,
                        challan_trans_id = breakageKey.challan_trans_id,
                        rate = breakageKey.rate,
                        qty = breakageKey.qty,
                        amt = breakageKey.amt,
                        narr = breakageKey.narr,
                        damage = breakageKey.damage,
                        missing = breakageKey.missing,
                        item_name = breakageKey.item_name,
                        unique_number = samp.unique_number
                    };

                    DB.IssueReceiptBreakageTransDetail.Add(SampData3);
                }

                DB.SaveChanges();
            }


            //if( samp.ChallanSingleItemArrayKey != null )
            //{
            //    foreach (var key in samp.ChallanSingleItemArrayKey)
            //    {
            //        Challan_Single_Item_Master SampData3 = new Challan_Single_Item_Master
            //        {
            //            item_name = key.item_name,
            //            item_purchase_one_pc = key.item_purchase_one_pc,
            //            item_rate_one_pc = key.item_rate_one_pc,
            //            item_profit_one_pc = key.item_profit_one_pc,
            //            item_qty = key.item_qty,
            //            item_discount_percentage_one_pc = key.item_discount_percentage_one_pc,
            //            item_discount_amount_one_pc = key.item_discount_amount_one_pc,
            //            item_discount_rate_one_pc = key.item_discount_rate_one_pc,
            //            item_gross_amount_one_pc = key.item_gross_amount_one_pc,
            //            item_gst_percenatge_one_pc = key.item_gst_percenatge_one_pc,
            //            item_gst_amt_one_pc = key.item_gst_amt_one_pc,
            //            item_gst_rate_one_pc = key.item_gst_rate_one_pc,
            //            item_rate_after_gst_one_pc = key.item_rate_after_gst_one_pc,
            //            total_amount_with_gst_one_pc = key.total_amount_with_gst_one_pc,
            //            profit_amount_one_pc = key.profit_amount_one_pc,
            //            item_hsn_code_one_pc = key.item_hsn_code_one_pc,
            //            item_packing_type_one_pc = key.item_packing_type_one_pc,
            //            item_remarks_one_pc = key.item_remarks_one_pc,
            //            issue_master_id = SampData.id,
            //            item_weight_one_pc = key.item_weight_one_pc,
            //            item_scheme_type_one_pc = key.item_scheme_type_one_pc


            //        };

            //        DB.Challan_Single_Item_Master.Add(SampData3);
            //    }

            //    DB.SaveChanges();
            //}


            IssueReceiptMaster challandata = DB.IssueReceiptMaster.Include(e => e.IssueReceiptTransDetail)
                .Include(e => e.IssueReceiptMiscTransDetail)
                .Include(e => e.IssueReceiptBreakageTransDetail)
                .Include(e=> e.Challan_Single_Item_Master)
                .Where(es => es.id == SampData.id).FirstOrDefault();

            var data = new IssueReceiptResp()
            {
                status = true,
                Message = "Inserted successfully",
                IssueReceiptMasterDetailByID = challandata
            };
            return data;
        }


        //public IssueReceiptResp GetIssueReceiptMaster( string ? flag)
        //{
        //    IssueReceiptResp data = new IssueReceiptResp()
        //    {
        //        status = true,
        //        Message = "data fetched successfully",
        //        IssueReceiptMasterDetailData = DB.IssueReceiptMaster.Where(e=>e.delete_at == 0 && e.irflag == flag).ToList()
        //    };
        //    return data;
        //}

        public IssueReceiptResp GetIssueReceiptMaster(string? flag, 
            DateTime? startDate, DateTime? endDate, string? searchKey)
        {
            var query = DB.IssueReceiptMaster.Where(e => e.delete_at == 0 && e.irflag == flag);

           /* if (!string.IsNullOrEmpty(flag))
            {
                query = query.Where(e => e.irflag == flag);
            }*/

            if (startDate.HasValue)
            {
                query = query.Where(e => e.bill_date >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(e => e.bill_date <= endDate.Value);
            }

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                       //EF.Functions.Like(e.billno_automatic, $"%{searchKey}%") ||
                       EF.Functions.Like(e.challanno, $"%{searchKey}%") ||
                       EF.Functions.Like(e.pname, $"%{searchKey}%"));
                       //EF.Functions.Like(e.Case_Duration_Value, $"%{searchKey}%"));
                        //query = query.Where(e => e.someField.Contains(searchKey));
            }

            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "data fetched successfully",
                IssueReceiptMasterDetailData = query.ToList()
            };

            return data;
        }



        public IssueReceiptResp GetIssueReceiptMasterByLastRecords(long? challanId, string ? flag)
        {
            IQueryable<IssueReceiptMaster> query = DB.IssueReceiptMaster.OrderByDescending(x => x.id)
                .Where( e => e.irflag == flag );

            if (challanId != null)
            {
                query = query.Where(x => x.id != challanId);
            }

            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "Data fetched successfully",
                IssueReceiptMasterDetailData = query.Take(5).ToList()
            };

            return data;
        }

        public IssueReceiptResp GetLastChallanMasterId(string? irFlag)
        {
            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "data fetched successfully",
                //lastId = (long)(DB.IssueReceiptMaster.Max(u => (long?)u.id) ?? 0)
                lastId = (long)(DB.IssueReceiptMaster
                    .Where(u => u.irflag == irFlag)
                    .Max(u => (long?)u.billno_automatic) ?? 0)


            };
            return data;
        }

        public IssueReceiptResp CheckChallanNumber(long? billNumber, string flag)
        {
            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = false,
                Message = "Challan number is already exits, Redirecting To Exist Bill",
                IssueReceiptMasterDetailByID = DB.IssueReceiptMaster
                .Include(e => e.IssueReceiptTransDetail.Where(w => w.delete_at == 0))
                .ThenInclude(e => e.ItemMaster)
                .Include(e => e.IssueReceiptMiscTransDetail.Where(w => w.delete_at == 0))
                .Include(e => e.IssueReceiptBreakageTransDetail.Where(w => w.delete_at == 0))
                .Include(e => e.IssueItemExtraDetail.Where(w => w.delete_at == 0))

                // .Include( e=> e.Challan_Single_Item_Master)
                .Where(e => e.billno_automatic  == billNumber  && e.irflag == flag).FirstOrDefault(),
            };
            return data;
        }


        public IssueReceiptResp GetIssueReceiptMasterById(long challanId)
        {
            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "data fetched successfully",
                IssueReceiptMasterDetailByID = DB.IssueReceiptMaster
                .Include(e => e.IssueReceiptTransDetail.Where(w => w.delete_at == 0))
                .ThenInclude(e => e.ItemMaster)
                .Include(e => e.IssueReceiptMiscTransDetail.Where(w => w.delete_at == 0))
                .Include(e => e.IssueReceiptBreakageTransDetail.Where(w => w.delete_at == 0))
                .Include(e => e.IssueItemExtraDetail.Where(w => w.delete_at == 0))
                .Include(e => e.IssueReceiptTransWarrantyDetail)
                .Where(e => e.id == challanId).FirstOrDefault()
            };
            return data;
        }

        public IssueReceiptResp DeleteIssueReceiptMaster(long challanId)
        {
            IssueReceiptMaster del = DB.IssueReceiptMaster.
                Where(x => x.id == challanId)
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

            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


        public IssueReceiptResp UpdateIssueReceiptMaster(IssueReceiptReq samp)
        {

            string currentDate = DateTime.Now.ToString("yyyyMMdd");

            var existingChallan = DB.IssueReceiptMaster.Find(samp.id);

            if (existingChallan == null)
            {
                throw new Exception("Challan not found");
            }



            if (samp.gst_type == "IGST")
            {
                existingChallan.igst_amt = (double)samp.tax_amt;
                existingChallan.igst_per = (double)samp.tax_code;

                existingChallan.cgst_amt = 0;
                existingChallan.cgst_per = 0;

                existingChallan.sgst_amt = 0;
                existingChallan.sgst_per = 0;
            }
            else if (samp.gst_type == "SGST-CGST")
            {
                existingChallan.cgst_amt = (double)samp.tax_amt / 2;
                if (samp.tax_code != null)
                {
                    existingChallan.cgst_per = (double)samp.tax_code / 2;
                }
                else
                {
                    existingChallan.cgst_per = 0;
                }
                existingChallan.sgst_amt = (double)samp.tax_amt / 2;
                //existingChallan.sgst_per = samp.tax_code != 0 ? (double)samp.tax_code / 2 : 0;

                if (samp.tax_code != null)
                {
                    existingChallan.sgst_per = (double)samp.tax_code / 2;
                }
                else
                {
                    existingChallan.sgst_per = 0;
                }

                existingChallan.igst_amt = 0;
                existingChallan.igst_per = 0;
            }

            if( samp.tax_code != null)
            {
                existingChallan.tax_yn = "yes";
            }else
            {
                existingChallan.tax_yn = "no";
            }

            // Update existingChallan properties with new values from samp
            existingChallan.billno_automatic = samp.billno_automatic;
            existingChallan.pcode = samp.pcode;
            existingChallan.pname = samp.pname;
            existingChallan.pname_short_code = samp.pname_short_code;
            existingChallan.agr_code_old = samp.agr_code_old;
            existingChallan.agr_no_old = samp.agr_no_old;
            existingChallan.client_type = samp.client_type;
            existingChallan.item_code = samp.item_code;
            existingChallan.item_short_name = samp.item_short_name;
            existingChallan.item_name = samp.item_name;
            existingChallan.item_group_code = samp.item_group_code;
            existingChallan.item_group_name = samp.item_group_name;
            existingChallan.bill_date = samp.bill_date;
            existingChallan.challanno = samp.challanno;
            existingChallan.issue_qty = samp.issue_qty;
            existingChallan.recv_qty = samp.recv_qty;
            existingChallan.irflag = samp.irflag;
            existingChallan.billfr = samp.billfr;
            existingChallan.billto = samp.billto;
            existingChallan.rent_rate = samp.rent_rate;
            existingChallan.broken_amt = samp.broken_amt;
            existingChallan.frshop = samp.frshop;
            existingChallan.froffice = samp.froffice;
            existingChallan.brok_qty = samp.brok_qty;
            existingChallan.brok_rate = samp.brok_rate;
            existingChallan.miss_flag = samp.miss_flag;
            existingChallan.misc_ac_code = samp.misc_ac_code;
            existingChallan.misc_exp_total = samp.misc_exp_total;
            existingChallan.cartcode = samp.cartcode;
            existingChallan.cart_amt = samp.cart_amt;
            existingChallan.remark_note = samp.remark_note;
            existingChallan.prnnarr = samp.prnnarr;
            existingChallan.stkvalue = samp.stkvalue;
            existingChallan.misc1 = samp.misc1;
            existingChallan.misc2 = samp.misc2;
            existingChallan.misc3 = samp.misc3;
            existingChallan.misc4 = samp.misc4;
            existingChallan.misc5 = samp.misc5;
            existingChallan.misc6 = samp.misc6;
            existingChallan.sno = samp.sno;
            existingChallan.contact_prs_ph = samp.contact_prs_ph;
            existingChallan.transporter_name = samp.transporter_name;
            existingChallan.gr_no = samp.gr_no;
            existingChallan.vehicleno = samp.vehicleno;
            existingChallan.driver_name = samp.driver_name;
            existingChallan.dl_no = samp.dl_no;
            existingChallan.permit_no = samp.permit_no;
            existingChallan.contact_prs_ph_no = samp.contact_prs_ph_no;
            existingChallan.apx_weight = samp.apx_weight;
            existingChallan.apx_value = samp.apx_value;
            existingChallan.bill_enter_date = samp.bill_enter_date;
            existingChallan.trip_no = samp.trip_no;
            //existingChallan.b1_rate = samp.b1_rate;
            //existingChallan.b1_qty = samp.b1_qty;
            //existingChallan.b1_amt = samp.b1_amt;
            //existingChallan.b1_narr = samp.b1_narr;
            //existingChallan.b2_rate = samp.b2_rate;
            //existingChallan.b2_qty = samp.b2_qty;
            //existingChallan.b2_amt = samp.b2_amt;
            //existingChallan.b2_narr = samp.b2_narr;
            //existingChallan.b3_rate = samp.b3_rate;
            //existingChallan.b3_qty = samp.b3_qty;
            //existingChallan.b3_amt = samp.b3_amt;
            //existingChallan.b3_narr = samp.b3_narr;
            //existingChallan.b4_rate = samp.b4_rate;
            //existingChallan.b4_qty = samp.b4_qty;
            //existingChallan.b4_amt = samp.b4_amt;
            //existingChallan.b4_narr = samp.b4_narr;
            //existingChallan.b5_rate = samp.b5_rate;
            //existingChallan.b5_qty = samp.b5_qty;
            //existingChallan.b5_amt = samp.b5_amt;
            //existingChallan.b5_narr = samp.b5_narr;
            //existingChallan.b6_rate = samp.b6_rate;
            //existingChallan.b6_qty = samp.b6_qty;
            //existingChallan.b6_amt = samp.b6_amt;
            //existingChallan.b6_narr = samp.b6_narr;
            //existingChallan.b7_rate = samp.b7_rate;
            //existingChallan.b7_qty = samp.b7_qty;
            //existingChallan.b7_amt = samp.b7_amt;
            //existingChallan.b7_narr = samp.b7_narr;
            //existingChallan.b8_rate = samp.b8_rate;
            //existingChallan.b8_qty = samp.b8_qty;
            //existingChallan.b8_amt = samp.b8_amt;
            //existingChallan.b8_narr = samp.b8_narr;
            //existingChallan.b9_rate = samp.b9_rate;
            //existingChallan.b9_qty = samp.b9_qty;
            //existingChallan.b9_amt = samp.b9_amt;
            //existingChallan.b9_narr = samp.b9_narr;
            //existingChallan.b10_rate = samp.b10_rate;
            //existingChallan.b10_qty = samp.b10_qty;
            //existingChallan.b10_amt = samp.b10_amt;
            //existingChallan.b10_narr = samp.b10_narr;
            existingChallan.bill_amt = samp.bill_amt;
            existingChallan.rec_type = samp.rec_type;
            existingChallan.tnx_type = samp.tnx_type;
            existingChallan.unit_name = samp.unit_name;
            existingChallan.itemtype = samp.itemtype;
            existingChallan.tax_code = samp.tax_code;
            existingChallan.tax_name = samp.tax_name;
            existingChallan.tax_per = samp.tax_per;
            existingChallan.tax_amt = samp.tax_amt;
            existingChallan.dis_per = samp.dis_per;
            existingChallan.dis_amt = samp.dis_amt;
            existingChallan.gross_amt = samp.gross_amt;
            existingChallan.tot_qty = samp.tot_qty;
            existingChallan.add_off_site = samp.add_off_site;
            existingChallan.hsn_code = samp.hsn_code;
            existingChallan.gst_type = samp.gst_type;
            existingChallan.state_code = samp.state_code;
            //existingChallan.tax_yn = samp.tax_yn;
            //existingChallan.igst_per = samp.igst_per;
            //existingChallan.igst_amt = samp.igst_amt;
            //existingChallan.sgst_per = samp.sgst_per;
            //existingChallan.sgst_amt = samp.sgst_amt;
            //existingChallan.cgst_per = samp.cgst_per;
            //existingChallan.cgst_amt = samp.cgst_amt;
            existingChallan.reverse_charge = samp.reverse_charge;
            existingChallan.electronic_ref_no = samp.electronic_ref_no;
            existingChallan.ref_2 = samp.ref_2;
            existingChallan.weight_of_one_pcs = samp.weight_of_one_pcs;
            existingChallan.tot_weight_of_pcs = samp.tot_weight_of_pcs;
            existingChallan.manual_billno = samp.manual_billno;
            existingChallan.ordno = samp.ordno;
            existingChallan.ord_date = samp.ord_date;
            existingChallan.trx_code = samp.trx_code;
            existingChallan.trx_name = samp.trx_name;
            existingChallan.pkg = samp.pkg;
            existingChallan.c_form = samp.c_form;
            existingChallan.net_amt = samp.net_amt;
            existingChallan.tot_amt = samp.tot_amt;
            existingChallan.transporter_code = samp.transporter_code;
            existingChallan.fraight = samp.fraight;
            existingChallan.contact_prs = samp.contact_prs;
            existingChallan.site_add = samp.site_add;
            existingChallan.todo = samp.todo;
            existingChallan.amt_in_wor = samp.amt_in_wor;
            existingChallan.duedate = samp.duedate;
            existingChallan.round_off_yn = samp.round_off_yn;
            existingChallan.round_off_amt = samp.round_off_amt;
            existingChallan.station_name = samp.station_name;
            existingChallan.qty_kg = samp.qty_kg;  //            existingChallan.qty_kg = samp.qty_kg;
            existingChallan.tot_kg = samp.tot_kg;
            existingChallan.add1 = samp.add1;
            existingChallan.add2 = samp.add2;
            existingChallan.add3_location = samp.add3_location;
            existingChallan.add4_city = samp.add4_city;
            existingChallan.add5_state = samp.add5_state;
            existingChallan.add6_pincode = samp.add6_pincode;
            existingChallan.add7_state_code = samp.add7_state_code;
            existingChallan.country_name = samp.country_name;
            existingChallan.addr_type = samp.addr_type;
            existingChallan.addr_gst_type = samp.addr_gst_type;
            existingChallan.gstno = samp.gstno;
            existingChallan.rent_on_type = samp.rent_on_type;
            existingChallan.opening_qty = samp.opening_qty;
            existingChallan.issued_bal_on_chal_date = samp.issued_bal_on_chal_date;
           // existingChallan.unique_number = samp.unique_number;
            existingChallan.contact_prs_whts_no = samp.contact_prs_whts_no;
            existingChallan.irflag_detail = samp.irflag_detail;


            existingChallan.cart_po_date = samp.cart_po_date;
            existingChallan.cart_po_number = samp.cart_po_number;
            existingChallan.cart_transport_name = samp.cart_transport_name;
            existingChallan.cart_fraight_topay_paid = samp.cart_fraight_topay_paid;
            existingChallan.cart_amt_transporter = samp.cart_amt_transporter;
            existingChallan.cart_per_tax_transporter = samp.cart_per_tax_transporter;
            existingChallan.cart_amt_with_gst_transporter = samp.cart_amt_with_gst_transporter;
            existingChallan.cart_amt_final = samp.cart_amt_final; 
            existingChallan.cart_tcs_yn = samp.cart_tcs_yn;
            existingChallan.station = samp.station;

            existingChallan.roundoff_yn = samp.roundoff_yn;
            existingChallan.roundoff_amount = samp.roundoff_amount;
            existingChallan.cart_tcs_value = samp.cart_tcs_value;
            existingChallan.cart_tax_amount_transporter = samp.cart_tax_amount_transporter;
            existingChallan.cart_amt_maintain_yn = samp.cart_amt_maintain_yn;
            existingChallan.cart_transporter_cartage = samp.cart_transporter_cartage;
            existingChallan.cart_tcs_percentage = samp.cart_tcs_percentage;
            existingChallan.final_amount = samp.final_amount;
            existingChallan.updated_at = DateTime.Now;


            DB.IssueReceiptMaster.Update(existingChallan);
            DB.SaveChanges();

            if (samp.ChallanTrnKey != null && samp.ChallanTrnKey.Count > 0)
            {
                foreach (ChallanTrnKey challantrans in samp.ChallanTrnKey)
                {

                    var existingTransDetails = DB.IssueReceiptTransDetail.FirstOrDefault(x => x.id == challantrans.id
                    && x.challan_master_id == existingChallan.id);


                    if (existingTransDetails != null)
                    {
                        existingTransDetails.pcode = challantrans.pcode;
                        existingTransDetails.pname = challantrans.pname;
                        existingTransDetails.item_code = challantrans.item_code;
                        existingTransDetails.item_short_name = challantrans.item_short_name;
                        existingTransDetails.item_name = challantrans.item_name;
                        existingTransDetails.item_group_code = challantrans.item_group_code;
                        existingTransDetails.item_group_name = challantrans.item_group_name;
                        existingTransDetails.unit_name = challantrans.unit_name;
                        existingTransDetails.itemtype = challantrans.itemtype;
                        existingTransDetails.issue_qty = challantrans.issue_qty;
                        existingTransDetails.recv_qty = challantrans.recv_qty;
                        existingTransDetails.irflag = challantrans.irflag;
                        existingTransDetails.rent_rate = challantrans.rent_rate;
                        existingTransDetails.rate_of_one_pcs = challantrans.rate_of_one_pcs;
                        existingTransDetails.weight_of_one_pcs = challantrans.weight_of_one_pcs;
                        existingTransDetails.unique_number = challantrans.unique_number;
                        existingTransDetails.opening_qty = challantrans.opening_qty;


                        existingTransDetails.item_purchase_one_pc = challantrans.item_purchase_one_pc;
                        existingTransDetails.item_rate_one_pc = challantrans.item_rate_one_pc;
                        existingTransDetails.item_profit_one_pc = challantrans.item_profit_one_pc;
                        existingTransDetails.item_qty = challantrans.item_qty;
                        existingTransDetails.item_discount_percentage_one_pc = challantrans.item_discount_percentage_one_pc;
                        existingTransDetails.item_discount_amount_one_pc = challantrans.item_discount_amount_one_pc;
                        existingTransDetails.item_discount_rate_one_pc = challantrans.item_discount_rate_one_pc;
                        existingTransDetails.item_gross_amount_one_pc = challantrans.item_gross_amount_one_pc;
                        existingTransDetails.item_gst_percenatge_one_pc = challantrans.item_gst_percenatge_one_pc;
                        existingTransDetails.item_gst_amt_one_pc = challantrans.item_gst_amt_one_pc;
                        existingTransDetails.item_gst_rate_one_pc = challantrans.item_gst_rate_one_pc;
                        existingTransDetails.item_rate_after_gst_one_pc = challantrans.item_rate_after_gst_one_pc;
                        existingTransDetails.total_amount_with_gst_one_pc = challantrans.total_amount_with_gst_one_pc;
                        existingTransDetails.profit_amount_one_pc = challantrans.profit_amount_one_pc;
                        existingTransDetails.item_hsn_code_one_pc = challantrans.item_hsn_code_one_pc;
                        existingTransDetails.item_packing_type_one_pc = challantrans.item_packing_type_one_pc;
                        existingTransDetails.item_remarks_one_pc = challantrans.item_remarks_one_pc;
                        existingTransDetails.item_weight_one_pc = challantrans.item_weight_one_pc;
                        existingTransDetails.item_scheme_type_one_pc = challantrans.item_scheme_type_one_pc;

                    }
                    else
                    {
                        AggrementMaster checkAggrement = DB.AggrementMaster.Find(challantrans.id);

                        IssueReceiptTransDetail SampData1 = new IssueReceiptTransDetail
                        {


                            challan_master_id = existingChallan.id,
                            pcode = challantrans.pcode,
                            pname = challantrans.pname,
                            item_code = challantrans.item_code,
                            item_short_name = challantrans.item_short_name,
                            item_name = challantrans.item_name,
                            item_group_code = challantrans.item_group_code,
                            item_group_name = challantrans.item_group_name,
                            unit_name = challantrans.unit_name,
                            itemtype = challantrans.itemtype,
                            issue_qty = challantrans.issue_qty,
                            recv_qty = challantrans.recv_qty,
                            irflag = challantrans.irflag,
                            rent_rate = challantrans.rent_rate,
                            rate_of_one_pcs = challantrans.rate_of_one_pcs,
                            weight_of_one_pcs = challantrans.weight_of_one_pcs,
                            unique_number = existingChallan.unique_number,
                            opening_qty = challantrans.opening_qty,
                            aggrement_id = checkAggrement.id,


                            item_purchase_one_pc = challantrans.item_purchase_one_pc,
                            item_rate_one_pc = challantrans.item_rate_one_pc,
                            item_profit_one_pc = challantrans.item_profit_one_pc,
                            item_qty = challantrans.item_qty,
                            item_discount_percentage_one_pc = challantrans.item_discount_percentage_one_pc,
                            item_discount_amount_one_pc = challantrans.item_discount_amount_one_pc,
                            item_discount_rate_one_pc = challantrans.item_discount_rate_one_pc,
                            item_gross_amount_one_pc = challantrans.item_gross_amount_one_pc,
                            item_gst_percenatge_one_pc = challantrans.item_gst_percenatge_one_pc,
                            item_gst_amt_one_pc = challantrans.item_gst_amt_one_pc,
                            item_gst_rate_one_pc = challantrans.item_gst_rate_one_pc,
                            item_rate_after_gst_one_pc = challantrans.item_rate_after_gst_one_pc,
                            total_amount_with_gst_one_pc = challantrans.total_amount_with_gst_one_pc,
                            profit_amount_one_pc = challantrans.profit_amount_one_pc,
                            item_hsn_code_one_pc = challantrans.item_hsn_code_one_pc,
                            item_packing_type_one_pc = challantrans.item_packing_type_one_pc,
                            item_remarks_one_pc = challantrans.item_remarks_one_pc,
                            item_weight_one_pc = challantrans.item_weight_one_pc,
                            item_scheme_type_one_pc = challantrans.item_scheme_type_one_pc,

                    };

                        DB.IssueReceiptTransDetail.Add(SampData1);

                    }

                }

                DB.SaveChanges();
            }

            if (samp.ChallanMiscTranxKey != null)
            {
                foreach (var key in samp.ChallanMiscTranxKey)
                {

                    var existingMiscTransDetail = DB.IssueReceiptMiscTransDetail.Find(key.id);
                    if (existingMiscTransDetail != null)
                    {
                        existingMiscTransDetail.pcode = key.pcode;
                        existingMiscTransDetail.pname = key.pname;
                        existingMiscTransDetail.agr_code_old = key.agr_code_old;
                        existingMiscTransDetail.ch_no = key.ch_no;
                        existingMiscTransDetail.bill_date = key.bill_date;
                        existingMiscTransDetail.exp_ac_name = key.exp_ac_name;
                        existingMiscTransDetail.exp_amt = key.exp_amt;
                        existingMiscTransDetail.exp_remarks = key.exp_remarks;
                        existingMiscTransDetail.ir_flag = key.ir_flag;
                        existingMiscTransDetail.fo_oh = key.fo_oh;
                        existingMiscTransDetail.unique_number = key.unique_number;

                    }
                    else
                    {
                        IssueReceiptMiscTransDetail SampData2 = new IssueReceiptMiscTransDetail
                        {
                            challan_master_id = existingChallan.id,
                            bill_no_automatic = key.bill_no_automatic,
                            pcode = key.pcode,
                            pname = key.pname,
                            agr_code_old = key.agr_code_old,
                            ch_no = key.ch_no,
                            bill_date = key.bill_date,
                            exp_ac_name = key.exp_ac_name,
                            exp_amt = key.exp_amt,
                            exp_remarks = key.exp_remarks,
                            ir_flag = key.ir_flag,
                            fo_oh = key.fo_oh,
                            unique_number = existingChallan.unique_number,

                        };

                        DB.IssueReceiptMiscTransDetail.Add(SampData2);
                    }

                }

                DB.SaveChanges();
            }

            if (samp.ChallanBreakageTransKey != null)
            {
                foreach (var breakageKey in samp.ChallanBreakageTransKey)
                {
                    var existingBreakageDetail = DB.IssueReceiptBreakageTransDetail.FirstOrDefault(x => x.id == breakageKey.id); // Assuming id is the unique identifier

                    if (existingBreakageDetail != null)
                    {
                        // Update existing record
                        existingBreakageDetail.rate = breakageKey.rate;
                        existingBreakageDetail.qty = breakageKey.qty;
                        existingBreakageDetail.amt = breakageKey.amt;
                        existingBreakageDetail.narr = breakageKey.narr;
                        existingBreakageDetail.damage = breakageKey.damage;
                        existingBreakageDetail.missing = breakageKey.missing;
                        existingBreakageDetail.item_name = breakageKey.item_name;
                    }
                    else
                    {
                        // Add new record
                        IssueReceiptBreakageTransDetail SampData3 = new IssueReceiptBreakageTransDetail
                        {
                            challan_master_id = existingChallan.id,
                            rate = breakageKey.rate,
                            qty = breakageKey.qty,
                            amt = breakageKey.amt,
                            narr = breakageKey.narr,
                            damage = breakageKey.damage,
                            missing = breakageKey.missing,
                            item_name = breakageKey.item_name,
                            unique_number = existingChallan.unique_number,

                        };

                        DB.IssueReceiptBreakageTransDetail.Add(SampData3);
                    }
                }

                DB.SaveChanges();
            }

            if( samp.irflag =="IC" || samp.irflag == "SC" || samp.irflag == "PC")
            {

                if (samp.ChallanSingleItemArrayKey != null)
                {
                    foreach (var key in samp.ChallanSingleItemArrayKey)
                    {

                        long lastId = (long)(DB.IssueReceiptTransDetail
                        .Where(u => u.irflag == samp.irflag)
                        .Max(u => (long?)u.id) ?? 0);

                        var serial_no = $"{currentDate}_{existingChallan.id}_{key.item_code}_{lastId+1}";

                        var existingSelectItemDetail = DB.IssueReceiptTransDetail.FirstOrDefault(x => x.id == key.id
                        && x.challan_master_id == existingChallan.id
                        ); ;

                        if (existingSelectItemDetail != null)
                        {
                            existingSelectItemDetail.pcode = key.pcode;
                            existingSelectItemDetail.pname = key.pname;
                            existingSelectItemDetail.item_code = key.item_code;
                            existingSelectItemDetail.item_short_name = key.item_short_name;
                            existingSelectItemDetail.item_name = key.item_name;
                            existingSelectItemDetail.item_group_code = key.item_group_code;
                            existingSelectItemDetail.item_group_name = key.item_group_name;
                            existingSelectItemDetail.unit_name = key.unit_name;
                            existingSelectItemDetail.itemtype = key.itemtype;
                            existingSelectItemDetail.issue_qty = key.issue_qty;
                            existingSelectItemDetail.recv_qty = key.recv_qty;
                            existingSelectItemDetail.irflag = key.irflag;
                            existingSelectItemDetail.rent_rate = key.rent_rate;
                            existingSelectItemDetail.rate_of_one_pcs = key.rate_of_one_pcs;
                            existingSelectItemDetail.weight_of_one_pcs = key.weight_of_one_pcs;
                            existingSelectItemDetail.unique_number = key.unique_number;
                            existingSelectItemDetail.opening_qty = key.opening_qty;


                            existingSelectItemDetail.item_purchase_one_pc = key.item_purchase_one_pc;
                            existingSelectItemDetail.item_rate_one_pc = key.item_rate_one_pc;
                            existingSelectItemDetail.item_profit_one_pc = key.item_profit_one_pc;
                           // existingSelectItemDetail.item_qty = key.item_qty;
                            existingSelectItemDetail.item_discount_percentage_one_pc = key.item_discount_percentage_one_pc;
                            existingSelectItemDetail.item_discount_amount_one_pc = key.item_discount_amount_one_pc;
                            existingSelectItemDetail.item_discount_rate_one_pc = key.item_discount_rate_one_pc;
                            existingSelectItemDetail.item_gross_amount_one_pc = key.item_gross_amount_one_pc;
                            existingSelectItemDetail.item_gst_percenatge_one_pc = key.item_gst_percenatge_one_pc;
                            existingSelectItemDetail.item_gst_amt_one_pc = key.item_gst_amt_one_pc;
                            existingSelectItemDetail.item_gst_rate_one_pc = key.item_gst_rate_one_pc;
                            existingSelectItemDetail.item_rate_after_gst_one_pc = key.item_rate_after_gst_one_pc;
                            existingSelectItemDetail.total_amount_with_gst_one_pc = key.total_amount_with_gst_one_pc;
                            existingSelectItemDetail.profit_amount_one_pc = key.profit_amount_one_pc;
                            existingSelectItemDetail.item_hsn_code_one_pc = key.item_hsn_code_one_pc;
                            existingSelectItemDetail.item_packing_type_one_pc = key.item_packing_type_one_pc;
                            existingSelectItemDetail.item_remarks_one_pc = key.item_remarks_one_pc;
                            existingSelectItemDetail.item_weight_one_pc = key.item_weight_one_pc;
                            existingSelectItemDetail.item_scheme_type_one_pc = key.item_scheme_type_one_pc;

                            existingSelectItemDetail.item_warranty_mode = key.item_warranty_mode;
                            existingSelectItemDetail.item_warranty_period = key.item_warranty_period;
                            existingSelectItemDetail.item_warranty_visit_count = key.item_warranty_visit_count;
                            existingSelectItemDetail.item_warranty_expiry_date = key.item_warranty_expiry_date;


                          }
                        else
                        {

                            IssueReceiptTransDetail SampData4 = new IssueReceiptTransDetail
                            {
                                challan_master_id = existingChallan.id,
                                pcode = key.pcode,
                                pname = key.pname,
                                item_code = key.item_code,
                                item_short_name = key.item_short_name,
                                item_name = key.item_name,
                                item_group_code = key.item_group_code,
                                item_group_name = key.item_group_name,
                                unit_name = key.unit_name,
                                itemtype = key.itemtype,
                                issue_qty = key.issue_qty,
                                recv_qty = key.recv_qty,
                                irflag = key.irflag,
                                rent_rate = key.rent_rate,
                                rate_of_one_pcs = key.rate_of_one_pcs,
                                weight_of_one_pcs = key.weight_of_one_pcs,
                                unique_number = existingChallan.unique_number,
                                opening_qty = key.opening_qty,
                                aggrement_id = null,

                                item_purchase_one_pc = key.item_purchase_one_pc,
                                item_rate_one_pc = key.item_rate_one_pc,
                                item_profit_one_pc = key.item_profit_one_pc,
                                //item_qty = key.item_qty,
                                item_discount_percentage_one_pc = key.item_discount_percentage_one_pc,
                                item_discount_amount_one_pc = key.item_discount_amount_one_pc,
                                item_discount_rate_one_pc = key.item_discount_rate_one_pc,
                                item_gross_amount_one_pc = key.item_gross_amount_one_pc,
                                item_gst_percenatge_one_pc = key.item_gst_percenatge_one_pc,
                                item_gst_amt_one_pc = key.item_gst_amt_one_pc,
                                item_gst_rate_one_pc = key.item_gst_rate_one_pc,
                                item_rate_after_gst_one_pc = key.item_rate_after_gst_one_pc,
                                total_amount_with_gst_one_pc = key.total_amount_with_gst_one_pc,
                                profit_amount_one_pc = key.profit_amount_one_pc,
                                item_hsn_code_one_pc = key.item_hsn_code_one_pc,
                                item_packing_type_one_pc = key.item_packing_type_one_pc,
                                item_remarks_one_pc = key.item_remarks_one_pc,
                                item_weight_one_pc = key.item_weight_one_pc,
                                item_scheme_type_one_pc = key.item_scheme_type_one_pc,
                                item_warranty_mode = key.item_warranty_mode,
                                item_warranty_period = key.item_warranty_period,
                                item_warranty_visit_count = key.item_warranty_visit_count,
                                item_warranty_expiry_date = key.item_warranty_expiry_date,
                                warranty_serial_no = serial_no
                            };

                            DB.IssueReceiptTransDetail.Add(SampData4);
                        }


                        // add warrant mode setup code 

                        if (samp.IssueReceiptTransWarrantyArrayKey != null)
                        {
                            foreach (var item in samp.IssueReceiptTransWarrantyArrayKey)
                            {
                                var existingItem = DB.IssueReceiptTransWarrantyDetail.FirstOrDefault(e => e.id == item.id && e.challan_master_id == existingChallan.id);

                                if (existingItem != null)
                                {
                                    // Update existing item
                                    existingItem.warranty_serial_no = item.warranty_serial_no;
                                    existingItem.warranty_period = item.warranty_period;
                                    existingItem.warranty_visit_slot = item.warranty_visit_slot;
                                    existingItem.warranty_visit_charge = item.warranty_visit_charge;
                                    existingItem.item_name = item.item_name;
                                    existingItem.item_code = item.item_code;
                                    existingItem.warranty_visit_date = item.warranty_visit_date;



                                    DB.IssueReceiptTransWarrantyDetail.Update(existingItem);
                                    DB.SaveChanges();
                                }
                                else
                                {
                                    // Add new item if it doesn't exist
                                    if ( key.item_code == item.item_code)
                                    {
                                        IssueReceiptTransWarrantyDetail sampData6 = new IssueReceiptTransWarrantyDetail
                                        {
                                            warranty_period = item.warranty_period,
                                            warranty_visit_slot = item.warranty_visit_slot,
                                            warranty_visit_charge = item.warranty_visit_charge,
                                            challan_master_id = existingChallan.id,
                                            item_name = item.item_name,
                                            item_code = item.item_code,
                                            warranty_visit_date = item.warranty_visit_date,
                                            warranty_serial_no = serial_no,
                                            warranty_flag = item.warranty_flag
                                        };

                                        DB.IssueReceiptTransWarrantyDetail.Add(sampData6);
                                        DB.SaveChanges();
                                    }                                    
                                }
                            }
                        }

                    }

                    DB.SaveChanges();
                }
            }

            if (samp.irflag == "RC")
            {
                if (samp.ChallanSingleItemArrayKey != null)
                {
                    foreach (var key in samp.ChallanSingleItemArrayKey)
                    {

                        var existingSelectItemDetail = DB.IssueReceiptTransDetail.FirstOrDefault(x => x.id == key.id
                        && x.challan_master_id == existingChallan.id
                        ); ;

                        if (existingSelectItemDetail != null)
                        {
                            existingSelectItemDetail.pcode = key.pcode;
                            existingSelectItemDetail.pname = key.pname;
                            existingSelectItemDetail.item_code = key.item_code;
                            existingSelectItemDetail.item_short_name = key.item_short_name;
                            existingSelectItemDetail.item_name = key.item_name;
                            existingSelectItemDetail.item_group_code = key.item_group_code;
                            existingSelectItemDetail.item_group_name = key.item_group_name;
                            existingSelectItemDetail.unit_name = key.unit_name;
                            existingSelectItemDetail.itemtype = key.itemtype;
                            existingSelectItemDetail.issue_qty = key.issue_qty;
                            existingSelectItemDetail.recv_qty = key.recv_qty;
                            existingSelectItemDetail.irflag = key.irflag;
                            existingSelectItemDetail.rent_rate = key.rent_rate;
                            existingSelectItemDetail.rate_of_one_pcs = key.rate_of_one_pcs;
                            existingSelectItemDetail.weight_of_one_pcs = key.weight_of_one_pcs;
                            existingSelectItemDetail.unique_number = key.unique_number;
                            existingSelectItemDetail.opening_qty = key.opening_qty;


                            existingSelectItemDetail.item_purchase_one_pc = key.item_purchase_one_pc;
                            existingSelectItemDetail.item_rate_one_pc = key.item_rate_one_pc;
                            existingSelectItemDetail.item_profit_one_pc = key.item_profit_one_pc;
                            // existingSelectItemDetail.item_qty = key.item_qty;
                            existingSelectItemDetail.item_discount_percentage_one_pc = key.item_discount_percentage_one_pc;
                            existingSelectItemDetail.item_discount_amount_one_pc = key.item_discount_amount_one_pc;
                            existingSelectItemDetail.item_discount_rate_one_pc = key.item_discount_rate_one_pc;
                            existingSelectItemDetail.item_gross_amount_one_pc = key.item_gross_amount_one_pc;
                            existingSelectItemDetail.item_gst_percenatge_one_pc = key.item_gst_percenatge_one_pc;
                            existingSelectItemDetail.item_gst_amt_one_pc = key.item_gst_amt_one_pc;
                            existingSelectItemDetail.item_gst_rate_one_pc = key.item_gst_rate_one_pc;
                            existingSelectItemDetail.item_rate_after_gst_one_pc = key.item_rate_after_gst_one_pc;
                            existingSelectItemDetail.total_amount_with_gst_one_pc = key.total_amount_with_gst_one_pc;
                            existingSelectItemDetail.profit_amount_one_pc = key.profit_amount_one_pc;
                            existingSelectItemDetail.item_hsn_code_one_pc = key.item_hsn_code_one_pc;
                            existingSelectItemDetail.item_packing_type_one_pc = key.item_packing_type_one_pc;
                            existingSelectItemDetail.item_remarks_one_pc = key.item_remarks_one_pc;
                            existingSelectItemDetail.item_weight_one_pc = key.item_weight_one_pc;
                            existingSelectItemDetail.item_scheme_type_one_pc = key.item_scheme_type_one_pc;


                        }
                        else
                        {

                            IssueReceiptTransDetail SampData4 = new IssueReceiptTransDetail
                            {
                                challan_master_id = existingChallan.id,
                                pcode = key.pcode,
                                pname = key.pname,
                                item_code = key.item_code,
                                item_short_name = key.item_short_name,
                                item_name = key.item_name,
                                item_group_code = key.item_group_code,
                                item_group_name = key.item_group_name,
                                unit_name = key.unit_name,
                                itemtype = key.itemtype,
                                //issue_qty = key.issue_qty,
                                recv_qty = key.recv_qty,
                                irflag = key.irflag,
                                rent_rate = key.rent_rate,
                                rate_of_one_pcs = key.rate_of_one_pcs,
                                weight_of_one_pcs = key.weight_of_one_pcs,
                                //unique_number = key.unique_number,
                                unique_number = existingChallan.unique_number,

                                opening_qty = key.opening_qty,
                                aggrement_id = null,

                                item_purchase_one_pc = key.item_purchase_one_pc,
                                item_rate_one_pc = key.item_rate_one_pc,
                                item_profit_one_pc = key.item_profit_one_pc,
                                //item_qty = key.item_qty,
                                item_discount_percentage_one_pc = key.item_discount_percentage_one_pc,
                                item_discount_amount_one_pc = key.item_discount_amount_one_pc,
                                item_discount_rate_one_pc = key.item_discount_rate_one_pc,
                                item_gross_amount_one_pc = key.item_gross_amount_one_pc,
                                item_gst_percenatge_one_pc = key.item_gst_percenatge_one_pc,
                                item_gst_amt_one_pc = key.item_gst_amt_one_pc,
                                item_gst_rate_one_pc = key.item_gst_rate_one_pc,
                                item_rate_after_gst_one_pc = key.item_rate_after_gst_one_pc,
                                total_amount_with_gst_one_pc = key.total_amount_with_gst_one_pc,
                                profit_amount_one_pc = key.profit_amount_one_pc,
                                item_hsn_code_one_pc = key.item_hsn_code_one_pc,
                                item_packing_type_one_pc = key.item_packing_type_one_pc,
                                item_remarks_one_pc = key.item_remarks_one_pc,
                                item_weight_one_pc = key.item_weight_one_pc,
                                item_scheme_type_one_pc = key.item_scheme_type_one_pc
                            };

                            DB.IssueReceiptTransDetail.Add(SampData4);
                        }
                    }

                    DB.SaveChanges();
                }
            }


            if( samp.IssueItemExtraDetailKey != null)
            {
                foreach (var item in samp.IssueItemExtraDetailKey)
                {
                    var existingItem = DB.IssueItemExtraDetail.FirstOrDefault( e=> e.id == item.id && e.challan_master_id == existingChallan.id);
                    if (existingItem != null)
                    {
                         existingItem.item_stock_date = item.item_stock_date;
                         existingItem. item_stock_location = item.item_stock_location;
                         existingItem.item_stock_qty = item.item_stock_qty;
                         existingItem.item_stock_rate = item.item_stock_rate;
                         existingItem.item_stock_value = item.item_stock_value;
                         existingItem.item_batch_no = item.item_batch_no;
                         existingItem.item_style = item.item_style;
                         existingItem.item_brand = item.item_brand;
                         existingItem.item_color = item.item_color;
                         existingItem.item_agent = item.item_agent;
                         existingItem.item_dealer = item.item_dealer;
                         existingItem.item_code = item.item_code;
                         existingItem.item_name = item.item_name;
                         existingItem.pname = item.pname;
                         existingItem.pcode = item.pcode;
                         existingItem.irflag = item.irflag;
                         existingItem.updated_at = DateTime.Now;
                        existingItem.unique_number = item.unique_number;


                    }
                    else
                    {
                        IssueItemExtraDetail sampData5 = new IssueItemExtraDetail
                        {
                            //item_stock_date = item.item_stock_date;          
                            item_stock_location = item.item_stock_location,
                            item_stock_qty = item.item_stock_qty,
                            item_stock_rate = item.item_stock_rate,
                            item_stock_value = item.item_stock_value,
                            challan_master_id = existingChallan.id,
                            item_batch_no = item.item_batch_no,
                            item_style = item.item_style,
                            item_brand = item.item_brand,
                            item_color = item.item_color,
                            item_agent = item.item_agent,
                            item_dealer = item.item_dealer,
                            item_code = item.item_code,
                            item_name = item.item_name,
                            pname = item.pname,
                            pcode = item.pcode,
                            irflag = item.irflag,
                            created_at = DateTime.Now,
                            unique_number = existingChallan.unique_number,
                        };

                        DB.IssueItemExtraDetail.Add(sampData5);
                        DB.SaveChanges();
                    }
                }
            }


            foreach (var key in samp.RemoveChallanBreakageTransKey)
            {
                IssueReceiptBreakageTransDetail existingDeleteBreakageDetail = DB.IssueReceiptBreakageTransDetail.Find(key.id);
                if (existingDeleteBreakageDetail != null)
                {
                    //DB.Remove(existingDeleteBreakageDetail);
                    existingDeleteBreakageDetail.delete_at = 1;
                    DB.SaveChanges();
                }
            }


            foreach (var key in samp.RemoveChallanMiscTransKey)
            {
                IssueReceiptMiscTransDetail existingDeleteMiscDetail = DB.IssueReceiptMiscTransDetail.Find(key.id);
                if (existingDeleteMiscDetail != null)
                {
                    existingDeleteMiscDetail.delete_at = 1;
                    //DB.Remove(existingDeleteMiscDetail);
                    DB.SaveChanges();
                }
            }

            foreach( var key  in samp.RemoveChallanSingleItemArrayKey)
            {
                IssueReceiptTransDetail existingDeleteIssueTransDetail = DB.IssueReceiptTransDetail.Find(key.id);
                if (existingDeleteIssueTransDetail != null)
                {
                    existingDeleteIssueTransDetail.delete_at = 1;
                   // DB.Remove(existingDeleteIssueTransDetail);
                    DB.SaveChanges();
                }
            }

            foreach (var key in samp.RemoveIssueItemExtraDetailKey)
            {
                IssueItemExtraDetail existingDeleteIssueExtraDetail = DB.IssueItemExtraDetail.Find(key.id);
                if (existingDeleteIssueExtraDetail != null)
                {
                    existingDeleteIssueExtraDetail.delete_at = 1;
                    // DB.Remove(existingDeleteIssueTransDetail);
                    DB.SaveChanges();
                }

            }

            foreach (var key in samp.RemoveIssueReceiptTransWarrantyArrayKey)
            {
                IssueReceiptTransWarrantyDetail existingDeleteIssueWarrantyDetail = DB.IssueReceiptTransWarrantyDetail.Find(key.id);
                if (existingDeleteIssueWarrantyDetail != null)
                {
                    DB.Remove(existingDeleteIssueWarrantyDetail);
                    // DB.Remove(existingDeleteIssueTransDetail);
                    DB.SaveChanges();
                }

            }


            var data = new IssueReceiptResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }




        // ==========================  Challan Brokage Master Api ============================



        public IssueReceiptResp GetIssueReceiptBreakageByIssueTransMaster(long challan_trans_id, long challan_master_id)
        {
            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "data fetched successfully",
                IssueReceiptBreakageTransDetail = DB.IssueReceiptBreakageTransDetail
                .Where(e => e.challan_trans_id == challan_trans_id
                && e.challan_master_id == challan_master_id).ToList()
            };
            return data;
        }


        public IssueReceiptResp InsertIssueReceiptBreakageMaster(IssueReceiptReq samp)
        {

            if (samp.ChallanBreakageTransKey != null)
            {
                foreach (var breakageKey in samp.ChallanBreakageTransKey)
                {
                    IssueReceiptBreakageTransDetail SampData3 = new IssueReceiptBreakageTransDetail
                    {
                        challan_trans_id = breakageKey.challan_trans_id,
                        challan_master_id = breakageKey.challan_master_id,
                        rate = breakageKey.rate,
                        qty = breakageKey.qty,
                        amt = breakageKey.amt,
                        narr = breakageKey.narr,
                        damage = breakageKey.damage,
                        missing = breakageKey.missing,
                        item_name = breakageKey.item_name,
                        unique_number = breakageKey.unique_number

                    };

                    DB.IssueReceiptBreakageTransDetail.Add(SampData3);
                }

                DB.SaveChanges();
            }

            var data = new IssueReceiptResp()
            {
                status = true,
                Message = "Inserted successfully"
            };
            return data;
        }


        public IssueReceiptResp DeleteIssueReceiptBreakageMaster(long IssueReceiptBreakageId)
        {
            var del = DB.IssueReceiptBreakageTransDetail
                .Where(x => x.id == IssueReceiptBreakageId).FirstOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.IssueReceiptBreakageTransDetail.Remove(del);
            DB.SaveChanges();

            IssueReceiptResp data = new IssueReceiptResp()
            {
                status = true,
                Message = "Deleted successfully"
            };

            return data;
        }

        public IssueReceiptResp UpdateIssueReceiptBreakageMaster(IssueReceiptReq samp)
        {
            if (samp.ChallanBreakageTransKey != null)
            {
                foreach (var breakageKey in samp.ChallanBreakageTransKey)
                {
                    var existingRecord = DB.IssueReceiptBreakageTransDetail
                                           .FirstOrDefault(x => x.id == breakageKey.id);

                    if (existingRecord != null)
                    {
                        existingRecord.challan_master_id = breakageKey.challan_master_id;
                        existingRecord.challan_trans_id = breakageKey.challan_trans_id;
                        existingRecord.rate = breakageKey.rate;
                        existingRecord.qty = breakageKey.qty;
                        existingRecord.amt = breakageKey.amt;
                        existingRecord.narr = breakageKey.narr;
                        existingRecord.damage = breakageKey.damage;
                        existingRecord.missing = breakageKey.missing;
                        existingRecord.item_name = breakageKey.item_name;
                        existingRecord.unique_number = breakageKey.unique_number;

                    }
                    else
                    {
                        IssueReceiptBreakageTransDetail SampData3 = new IssueReceiptBreakageTransDetail
                        {
                            challan_master_id = breakageKey.challan_master_id,
                            challan_trans_id = breakageKey.challan_trans_id,
                            rate = breakageKey.rate,
                            qty = breakageKey.qty,
                            amt = breakageKey.amt,
                            narr = breakageKey.narr,
                            damage = breakageKey.damage,
                            missing = breakageKey.missing,
                            item_name = breakageKey.item_name,
                            unique_number = breakageKey.unique_number

                        };

                        DB.IssueReceiptBreakageTransDetail.Add(SampData3);
                    }
                }

                DB.SaveChanges();
            }

            var data = new IssueReceiptResp()
            {
                status = true,
                Message = "Updated successfully"
            };

            return data;
        }

    }
}