using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class VoucherMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public VoucherMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public VoucherMasterResp GetVoucherMasterList()
        {

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                vou_list_masterData = DB.vou_list_master.ToList()
            };
            return data;
        }


        public VoucherMasterResp GetVoucherMasterById(long voucherId)
        {

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                vou_masterByID = DB.vou_master.
                Where(e => e.status == 0 && e.id == voucherId)
                //.Include(es => es.vou_trn_master)
                //.Where(e => e.status == 0 && e.id == voucherId && e.vou_trn_master.Any(es => es.status == 0))
                .FirstOrDefault()
            };
            return data;
        }


        //public VoucherMasterResp GetvoucherMaster()
        //{

        //    VoucherMasterResp data = new VoucherMasterResp()
        //    {
        //        status = true,
        //        Message = "data fetched successfully",
        //        vou_masterData = DB.vou_master.Where(e => e.status == 0).ToList()
        //    };
        //    return data;
        //}

        public VoucherMasterResp GetvoucherMaster(string? search = null ,string? type = null , DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = DB.vou_master.Where(e => e.status == 0);

            if (!string.IsNullOrEmpty(search))
            {
               
                query = query.Where(e =>
                    EF.Functions.Like(e.vou_ref_no, $"%{search}%") ||
                    EF.Functions.Like(e.vou_cash_bank_name, $"%{search}%") ||
                    EF.Functions.Like(e.vou_type, $"%{search}%"));


    
            }
            if (!string.IsNullOrEmpty(type))
            {
                query = query.Where(e => e.vou_type == type);
            }

            if (startDate.HasValue)
            {
                query = query.Where(e => e.vou_date >= startDate.Value); 
            }

            if (endDate.HasValue)
            {
                // adjustedEndDate = endDate.Value.Date.AddDays(1).AddTicks(-1);
                query = query.Where(e => e.vou_date <= endDate); 
            }

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                vou_masterData = query.Take(10).ToList()
            };
            return data;
        }

        public VoucherMasterResp InsertVoucherMaster(VoucherMasterReq samp)
        {
            vou_master SampData = new vou_master()
            {
                unique_trn_id = samp.unique_trn_id, // Assuming samp is defined elsewhere and has a unique_trn_id property
                client_purchaser_code = samp.client_purchaser_code,
                client_purchaser_name = samp.client_purchaser_name,
                agent_code = samp.agent_code,
                agent_name = samp.agent_name,
                vender_code = samp.vender_code,
                vender_name = samp.vender_name,
                vou_type_id = samp.vou_type_id,
                vou_type = samp.vou_type,
                vou_fa_year = samp.vou_fa_year,
                vou_ref_no = samp.vou_ref_no,
                vou_date = samp.vou_date,
                vou_cash_bank_id = samp.vou_cash_bank_id,
                vou_cash_bank_name = samp.vou_cash_bank_name,
                tot_vou_amt = samp.tot_vou_amt,
                created_on = DateTime.Now,
                updated_on = DateTime.Now,
                username = samp.username,
                month = DateTime.Now.Month,
                year = DateTime.Now.Year,
            };

            DB.vou_master.Add(SampData);
            DB.SaveChanges();

            foreach (var voucherMasterData in samp.VoucherMasterTranxKey)
            {
                vou_trn_master SampData1 = new vou_trn_master()
                {
                    voucher_master_id = SampData.id,
                    unique_trn_id = voucherMasterData.unique_trn_id,
                    client_purchaser_code = voucherMasterData.client_purchaser_code,
                    client_purchaser_name = voucherMasterData.client_purchaser_name,
                    agent_code = voucherMasterData.agent_code,
                    agent_name = voucherMasterData.agent_name,
                    vender_code = voucherMasterData.vender_code,
                    vender_name = voucherMasterData.vender_name,
                    vou_p_id = voucherMasterData.vou_p_id,
                    vou_pname = voucherMasterData.vou_pname,
                    vou_chq_detail = voucherMasterData.vou_chq_detail,
                    vou_narr = voucherMasterData.vou_narr,
                    vou_amt = voucherMasterData.vou_amt,
                    vou_agst_bill = voucherMasterData.vou_agst_bill,
                    created_on = DateTime.Now,
                    updated_on = DateTime.Now,
                    username = voucherMasterData.username,
                };

                DB.vou_trn_master.Add(SampData1);
            }
            DB.SaveChanges();


            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "inserted successfully",
                vou_masterByID = DB.vou_master.Where(e => e.id == SampData.id).FirstOrDefault()
            };
            return data;
        }

        public VoucherMasterResp UpdateVoucherMaster(long voucherId, VoucherMasterReq samp)
        {

            var existingProduct = DB.vou_master.Where(e => e.id == voucherId).FirstOrDefault();

            if (existingProduct == null)
            {

                VoucherMasterResp data1 = new VoucherMasterResp()
                {
                    status = false,
                    Message = "Voucher not found"
                };

                return data1;
            }

            existingProduct.unique_trn_id = samp.unique_trn_id;
            existingProduct.client_purchaser_code = samp.client_purchaser_code;
            existingProduct.client_purchaser_name = samp.client_purchaser_name;
            existingProduct.agent_code = samp.agent_code;
            existingProduct.agent_name = samp.agent_name;
            existingProduct.vender_code = samp.vender_code;
            existingProduct.vender_name = samp.vender_name;
            existingProduct.vou_type_id = samp.vou_type_id;
            existingProduct.vou_type = samp.vou_type;
            existingProduct.vou_fa_year = samp.vou_fa_year;
            existingProduct.vou_ref_no = samp.vou_ref_no;
            existingProduct.vou_date = samp.vou_date;
            existingProduct.vou_cash_bank_id = samp.vou_cash_bank_id;
            existingProduct.vou_cash_bank_name = samp.vou_cash_bank_name;
            existingProduct.tot_vou_amt = samp.tot_vou_amt;
            existingProduct.updated_on = DateTime.Now;
            existingProduct.username = samp.username;

            foreach (var voucherMasterData in samp.VoucherMasterTranxKey)
            {
                vou_trn_master existingData = DB.vou_trn_master.FirstOrDefault(e => e.id == voucherMasterData.id);
                if (existingData == null)
                {
                    vou_trn_master SampData1 = new vou_trn_master()
                    {
                        voucher_master_id = existingProduct.id,
                        unique_trn_id = voucherMasterData.unique_trn_id,
                        client_purchaser_code = voucherMasterData.client_purchaser_code,
                        client_purchaser_name = voucherMasterData.client_purchaser_name,
                        agent_code = voucherMasterData.agent_code,
                        agent_name = voucherMasterData.agent_name,
                        vender_code = voucherMasterData.vender_code,
                        vender_name = voucherMasterData.vender_name,
                        vou_p_id = voucherMasterData.vou_p_id,
                        vou_pname = voucherMasterData.vou_pname,
                        vou_chq_detail = voucherMasterData.vou_chq_detail,
                        vou_narr = voucherMasterData.vou_narr,
                        vou_amt = voucherMasterData.vou_amt,
                        vou_agst_bill = voucherMasterData.vou_agst_bill,
                        created_on = DateTime.Now,
                        updated_on = DateTime.Now,
                        username = voucherMasterData.username,
                    };

                    DB.vou_trn_master.Add(SampData1);
                }
                else
                {

                    existingData.unique_trn_id = voucherMasterData.unique_trn_id;
                    existingData.client_purchaser_code = voucherMasterData.client_purchaser_code;
                    existingData.client_purchaser_name = voucherMasterData.client_purchaser_name;
                    existingData.agent_code = voucherMasterData.agent_code;
                    existingData.agent_name = voucherMasterData.agent_name;
                    existingData.vender_code = voucherMasterData.vender_code;
                    existingData.vender_name = voucherMasterData.vender_name;
                    existingData.vou_p_id = voucherMasterData.vou_p_id;
                    existingData.vou_pname = voucherMasterData.vou_pname;
                    existingData.vou_chq_detail = voucherMasterData.vou_chq_detail;
                    existingData.vou_narr = voucherMasterData.vou_narr;
                    existingData.vou_amt = voucherMasterData.vou_amt;
                    existingData.vou_agst_bill = voucherMasterData.vou_agst_bill;
                    existingData.updated_on = DateTime.Now;
                    existingData.username = voucherMasterData.username;

                }
                DB.SaveChanges();
            }

            DB.SaveChanges();

            foreach (var keyName in samp.VoucherTranxDeleteArray)
            {
                vou_trn_master del = DB.vou_trn_master.Where(e => e.id == keyName.id).FirstOrDefault();
                del.status = 1;
                DB.SaveChanges();
            }


            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;
        }

        public VoucherMasterResp DeleteVoucherMaster(long voucherId)
        {
            var del = DB.vou_master.Where(e => e.id == voucherId).Include(e => e.vou_trn_master).FirstOrDefault();

            if (del == null)
            {

                VoucherMasterResp data1 = new VoucherMasterResp()
                {
                    status = false,
                    Message = "Voucher not found"
                };

                return data1;
            }

            del.status = 1;
            foreach (var vouTrnMaster in del.vou_trn_master)
            {
                vouTrnMaster.status = 1;
            }

            DB.SaveChanges();
            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "delete successfully"
            };
            return data;
        }


        public VoucherMasterResp GetLastVoucherMasterId()
        {
            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                lastId = (long)(DB.vou_master.Max(u => (long?)u.id) ?? 0)
            };
            return data;
        }


        //========================  Voucher Trans Master API ================================

        public VoucherMasterResp InsertVoucherTansDetail(VoucherMasterReq samp)
        {
            
                      
            vou_trn_master SampData1 = new vou_trn_master()
            {
                voucher_master_id = samp.VoucherMasterTranxDetail.voucher_master_id,
                unique_trn_id = samp.VoucherMasterTranxDetail.unique_trn_id,
                client_purchaser_code = samp.VoucherMasterTranxDetail.client_purchaser_code,
                client_purchaser_name = samp.VoucherMasterTranxDetail.client_purchaser_name,
                agent_code = samp.VoucherMasterTranxDetail.agent_code,
                agent_name = samp.VoucherMasterTranxDetail.agent_name,
                vender_code = samp.VoucherMasterTranxDetail.vender_code,
                vender_name = samp.VoucherMasterTranxDetail.vender_name,
                vou_p_id = samp.VoucherMasterTranxDetail.vou_p_id,
                vou_pname = samp.VoucherMasterTranxDetail.vou_pname,
                vou_chq_detail = samp.VoucherMasterTranxDetail.vou_chq_detail,
                vou_narr = samp.VoucherMasterTranxDetail.vou_narr,
                vou_amt = samp.VoucherMasterTranxDetail.vou_amt,
                vou_agst_bill = samp.VoucherMasterTranxDetail.vou_agst_bill,
                created_on = DateTime.Now,
                updated_on = DateTime.Now,
                month = DateTime.Now.Month, 
                year = DateTime.Now.Year,
                username = samp.VoucherMasterTranxDetail.username,
                vou_gst_amt = samp.VoucherMasterTranxDetail.vou_gst_amt,
                vou_gst_per = samp.VoucherMasterTranxDetail.vou_gst_per,
                vou_gross_amt = samp.VoucherMasterTranxDetail.vou_gross_amt,
            };

            DB.vou_trn_master.Add(SampData1);
            DB.SaveChanges();

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "insert successfully"
            };
            return data;

        }

        public VoucherMasterResp GetVoucherTansDetailList(long? VoucherTransId)
        {
            if (VoucherTransId == null)
            {
                throw new Exception("Voucher trans id is Required");
            }

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "data successfully",
                vou_Trn_Master_List = DB.vou_trn_master.Where(E => E.voucher_master_id == VoucherTransId && E.status == 0 ).ToList(),
            };
            return data;
        }

        public VoucherMasterResp DeleteVoucherTansDetail(long? VoucherTransId)
        {

            vou_trn_master del = DB.vou_trn_master.Where(E => E.id == VoucherTransId).FirstOrDefault();
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.status = 1;
            DB.SaveChanges();

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "delete successfully",
            };
            return data;

        }



        public VoucherMasterResp UpdateVoucherTansDetail(VoucherMasterReq samp)
        {
            
            vou_trn_master exitngData =  DB.vou_trn_master.Where(E=> E.id == samp.VoucherMasterTranxDetail.id).FirstOrDefault();

            if(exitngData != null)
            {
                //exitngData.voucher_master_id = samp.VoucherMasterTranxDetail.voucher_master_id,
                //unique_trn_id = samp.VoucherMasterTranxDetail.unique_trn_id,
                exitngData.client_purchaser_code = samp.VoucherMasterTranxDetail.client_purchaser_code;
                exitngData.client_purchaser_name = samp.VoucherMasterTranxDetail.client_purchaser_name;
                exitngData.agent_code = samp.VoucherMasterTranxDetail.agent_code;
                exitngData.agent_name = samp.VoucherMasterTranxDetail.agent_name;
                exitngData.vender_code = samp.VoucherMasterTranxDetail.vender_code;
                exitngData.vender_name = samp.VoucherMasterTranxDetail.vender_name;
                //vou_p_id = samp.VoucherMasterTranxDetail.vou_p_id;
                exitngData.vou_pname = samp.VoucherMasterTranxDetail.vou_pname;
                exitngData.vou_chq_detail = samp.VoucherMasterTranxDetail.vou_chq_detail;
                exitngData.vou_narr = samp.VoucherMasterTranxDetail.vou_narr;
                exitngData.vou_amt = samp.VoucherMasterTranxDetail.vou_amt;
                exitngData.vou_agst_bill = samp.VoucherMasterTranxDetail.vou_agst_bill;
                exitngData.updated_on = DateTime.Now;
                exitngData.username = samp.VoucherMasterTranxDetail.username;
                exitngData.vou_gst_amt = samp.VoucherMasterTranxDetail.vou_gst_amt;
                exitngData.vou_gst_per = samp.VoucherMasterTranxDetail.vou_gst_per;
                exitngData.vou_gross_amt = samp.VoucherMasterTranxDetail.vou_gross_amt;
            }
          

            DB.SaveChanges();

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;

        }





    }
}