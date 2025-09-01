using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class KYCDetailBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public KYCDetailBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public KYCDetailResp GetKYCDetail()
        {
            KYCDetailResp data = new KYCDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                KYCDetailData = DB.KYCDetail.ToList()
            };
            return data;
        }

        public KYCDetailResp GetKYCDetailByID(int id)
        {

            KYCDetailResp data = new KYCDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                KYCDetailByID = DB.KYCDetail.Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public KYCDetailResp InsertKYCDetail(KYCDetailReq samp)
        {
            KYCDetail SampData = new KYCDetail()
            {
                table_trf_no = samp.table_trf_no,
                multi_master_trx_no = samp.multi_master_trx_no,
                master_req_id = samp.master_req_id,
                master_inward_id = samp.master_inward_id,
                master_trf_no = samp.master_trf_no,
                p_update_type_finance = samp.p_update_type_finance,
                p_address_type_code_bank = samp.p_address_type_code_bank,
                p_address_type_code_detail_bank = samp.p_address_type_code_detail_bank,
                p_account_type_code = samp.p_account_type_code,
                p_bank_ac_no = samp.p_bank_ac_no,
                p_account_type = samp.p_account_type,
                p_bank_name = samp.p_bank_name,
                p_bank_micrno = samp.p_bank_micrno,
                p_bank_ifsc_code = samp.p_bank_ifsc_code,
                p_bank_add1 = samp.p_bank_add1,
                p_bank_add2 = samp.p_bank_add2,
                p_bank_add3 = samp.p_bank_add3,
                p_bank_city = samp.p_bank_city,
                p_bank_state = samp.p_bank_state,
                p_bank_pincode = samp.p_bank_pincode,
                p_bank_country = samp.p_bank_country,
                t_panno1 = samp.t_panno1,
                t_panno2 = samp.t_panno2,
                t_panno3 = samp.t_panno3,
                p_panno1 = samp.p_panno1,
                p_panno2 = samp.p_panno2,
                p_panno3 = samp.p_panno3,
                p_adhaar_no = samp.p_adhaar_no,
                p_voter_id = samp.p_voter_id,
                p_dl_no = samp.p_dl_no,
                p_passport_no = samp.p_passport_no,
                p_emailid = samp.p_emailid,
                p_phone = samp.p_phone,
                pan1_addhar_linked_yn = samp.pan1_addhar_linked_yn,
                pan2_addhar_linked_yn = samp.pan2_addhar_linked_yn,
                pan3_addhar_linked_yn = samp.pan3_addhar_linked_yn,
                rr_flag_name = samp.rr_flag_name,
                rejecte_yn = samp.rejecte_yn,
                verify_yn = samp.verify_yn,
                verify_by_username = samp.verify_by_username,
                verify_status_msg = samp.verify_status_msg,
                verify_remark = samp.verify_remark,
                verify_updated_on = samp.verify_updated_on,
                maker_id = samp.maker_id,
                maker_name = samp.maker_name,
                maker_remark = samp.maker_remark,
                maker_status = samp.maker_status,
                maker_status_created_on = samp.maker_status_created_on,
                checker_id = samp.checker_id,
                checker_name = samp.checker_name,
                checker_remark = samp.checker_remark,
                checker_status = samp.checker_status,
                checker_status_created_on = samp.checker_status_created_on,
                current_status = samp.current_status
            };



            DB.KYCDetail.Add(SampData);
            DB.SaveChanges();
            KYCDetailResp data = new KYCDetailResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public KYCDetailResp UpdateKYCDetail(long ID, KYCDetailReq samp)
        {
            // Retrieve the existing record from the database
            KYCDetail existingNominee = DB.KYCDetail.Find(ID);

            if (existingNominee == null)
            {
                // Handle the case where the record with the given ID is not found
                KYCDetailResp dataNotFound = new KYCDetailResp()
                {
                    status = false,
                    Message = "Record not found for the given ID"
                };
                return dataNotFound;
            }

            existingNominee.p_voter_id = samp.p_voter_id;
            existingNominee.p_dl_no = samp.p_dl_no;
            existingNominee.p_passport_no = samp.p_passport_no;
            existingNominee.p_emailid = samp.p_emailid;
            existingNominee.p_phone = samp.p_phone;
            existingNominee.pan1_addhar_linked_yn = samp.pan1_addhar_linked_yn;
            existingNominee.pan2_addhar_linked_yn = samp.pan2_addhar_linked_yn;
            existingNominee.pan3_addhar_linked_yn = samp.pan3_addhar_linked_yn;
            existingNominee.rr_flag_name = samp.rr_flag_name;
            existingNominee.rejecte_yn = samp.rejecte_yn;
            existingNominee.verify_yn = samp.verify_yn;
            existingNominee.verify_by_username = samp.verify_by_username;
            existingNominee.verify_status_msg = samp.verify_status_msg;
            existingNominee.verify_remark = samp.verify_remark;
            existingNominee.verify_updated_on = samp.verify_updated_on;
            existingNominee.maker_id = samp.maker_id;
            existingNominee.maker_name = samp.maker_name;
            existingNominee.maker_remark = samp.maker_remark;
            existingNominee.maker_status = samp.maker_status;
            existingNominee.maker_status_created_on = samp.maker_status_created_on;
            existingNominee.checker_id = samp.checker_id;
            existingNominee.checker_name = samp.checker_name;
            existingNominee.checker_remark = samp.checker_remark;
            existingNominee.checker_status = samp.checker_status;
            existingNominee.checker_status_created_on = samp.checker_status_created_on;
            existingNominee.current_status = samp.current_status;

            DB.KYCDetail.Update(existingNominee);
            DB.SaveChanges();

            KYCDetailResp data = new KYCDetailResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }


        public KYCDetailResp DeleteKYCDetail(int ID)
        {
            KYCDetail del = DB.KYCDetail.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.KYCDetail.Remove(del);
            DB.SaveChanges();
            KYCDetailResp data = new KYCDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    }

}
