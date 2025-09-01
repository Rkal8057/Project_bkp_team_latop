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
                vou_masterByID = DB.vou_master
                .Include(es => es.vou_trn_master)
                .Where(e => e.status == 0 && e.id == voucherId && e.vou_trn_master.Any(es => es.status == 0))
                .FirstOrDefault()
        };
            return data;
        }


        public VoucherMasterResp GetvoucherMaster()
        {

            VoucherMasterResp data = new VoucherMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                vou_masterData = DB.vou_master.Where(e => e.status == 0).ToList()
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
                Message = "inserted successfully"
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
                else{

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



    }
}