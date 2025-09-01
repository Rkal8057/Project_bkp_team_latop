using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class NomineeDetailBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public NomineeDetailBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public NomineeDetailResp GetNomineeDetail()
        {
            NomineeDetailResp data = new NomineeDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                NomineeDetailData = DB.NomineeDetail.ToList()
            };
            return data;
        }

        public NomineeDetailResp GetNomineeDetailByID(int id)
        {

            NomineeDetailResp data = new NomineeDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                NomineeDetailDataByID = DB.NomineeDetail.Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public NomineeDetailResp InsertNomineeDetail(NomineeDetailReq samp)
        {
            NomineeDetail SampData = new NomineeDetail()
            {
                table_trf_no = samp.table_trf_no,
                multi_master_trx_no = samp.multi_master_trx_no,
                master_req_id = samp.master_req_id,
                master_inward_id = samp.master_inward_id,
                master_trf_no = samp.master_trf_no,
                n_update_type_nominee = samp.n_update_type_nominee,
                n_name_new = samp.n_name_new,
                n_pan_new = samp.n_pan_new,
                n_relation_new = samp.n_relation_new,
                n_f_m_w_name_new = samp.n_f_m_w_name_new,
                n_m_f_new = samp.n_m_f_new,
                n_nsdl_id_1_new = samp.n_nsdl_id_1_new,
                n_nsdl_id_2_new = samp.n_nsdl_id_2_new,
                n_cdsl_id_1_new = samp.n_cdsl_id_1_new,
                n_cl_id_new = samp.n_cl_id_new,
                n_dob_new = samp.n_dob_new,
                n_phone_new = samp.n_phone_new,
                n_add2_new = samp.n_add2_new,
                n_add1_new = samp.n_add1_new,
                n_city_new = samp.n_city_new,
                n_pincode_new = samp.n_pincode_new,
                n_state_new = samp.n_state_new,
                n_country_new = samp.n_country_new,
                n_email_new = samp.n_email_new,
                n_address_type_code_nominee = samp.n_address_type_code_nominee,
                n_address_type_code_detail_nominee = samp.n_address_type_code_detail_nominee,
                n_occupation_det_new_code = samp.n_occupation_det_new_code,
                n_occupation_det_new = samp.n_occupation_det_new,
                n_nominee_opting_out_yn_new = samp.n_nominee_opting_out_yn_new,
                n_nominee_is_a_minor_yn_new = samp.n_nominee_is_a_minor_yn_new,
                n_date_of_att_majority_new = samp.n_date_of_att_majority_new,
                n_gaurdian_name_new = samp.n_gaurdian_name_new,
                n_gaurdian_address_new = samp.n_gaurdian_address_new,
                rr_flag_name = samp.rr_flag_name,
                rejecte_yn = samp.rejecte_yn,
                verify_yn = samp.verify_yn,
                verify_by_user_name = samp.verify_by_user_name,
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


            DB.NomineeDetail.Add(SampData);
            DB.SaveChanges();
            NomineeDetailResp data = new NomineeDetailResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public NomineeDetailResp UpdateNomineeDetail(long ID, NomineeDetailReq samp)
        {
            // Retrieve the existing record from the database
            NomineeDetail existingNominee = DB.NomineeDetail.Find(ID);

            if (existingNominee == null)
            {
                // Handle the case where the record with the given ID is not found
                NomineeDetailResp dataNotFound = new NomineeDetailResp()
                {
                    status = false,
                    Message = "Record not found for the given ID"
                };
                return dataNotFound;
            }

            existingNominee.table_trf_no = samp.table_trf_no;
            existingNominee.multi_master_trx_no = samp.multi_master_trx_no;
            existingNominee.master_req_id = samp.master_req_id;
            existingNominee.master_inward_id = samp.master_inward_id;
            existingNominee.master_trf_no = samp.master_trf_no;
            existingNominee.n_update_type_nominee = samp.n_update_type_nominee;
            existingNominee.n_name_new = samp.n_name_new;
            existingNominee.n_pan_new = samp.n_pan_new;
            existingNominee.n_relation_new = samp.n_relation_new;
            existingNominee.n_f_m_w_name_new = samp.n_f_m_w_name_new;
            existingNominee.n_m_f_new = samp.n_m_f_new;
            existingNominee.n_nsdl_id_1_new = samp.n_nsdl_id_1_new;
            existingNominee.n_nsdl_id_2_new = samp.n_nsdl_id_2_new;
            existingNominee.n_cdsl_id_1_new = samp.n_cdsl_id_1_new;
            existingNominee.n_cl_id_new = samp.n_cl_id_new;
            existingNominee.n_dob_new = samp.n_dob_new;
            existingNominee.n_phone_new = samp.n_phone_new;
            existingNominee.n_add2_new = samp.n_add2_new;
            existingNominee.n_add1_new = samp.n_add1_new;
            existingNominee.n_city_new = samp.n_city_new;
            existingNominee.n_pincode_new = samp.n_pincode_new;
            existingNominee.n_state_new = samp.n_state_new;
            existingNominee.n_country_new = samp.n_country_new;
            existingNominee.n_email_new = samp.n_email_new;
            existingNominee.n_address_type_code_nominee = samp.n_address_type_code_nominee;
            existingNominee.n_address_type_code_detail_nominee = samp.n_address_type_code_detail_nominee;
            existingNominee.n_occupation_det_new_code = samp.n_occupation_det_new_code;
            existingNominee.n_occupation_det_new = samp.n_occupation_det_new;
            existingNominee.n_nominee_opting_out_yn_new = samp.n_nominee_opting_out_yn_new;
            existingNominee.n_nominee_is_a_minor_yn_new = samp.n_nominee_is_a_minor_yn_new;
            existingNominee.n_date_of_att_majority_new = samp.n_date_of_att_majority_new;
            existingNominee.n_gaurdian_name_new = samp.n_gaurdian_name_new;
            existingNominee.n_gaurdian_address_new = samp.n_gaurdian_address_new;
            existingNominee.rr_flag_name = samp.rr_flag_name;
            existingNominee.rejecte_yn = samp.rejecte_yn;
            existingNominee.verify_yn = samp.verify_yn;
            existingNominee.verify_by_user_name = samp.verify_by_user_name;
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

            DB.NomineeDetail.Update(existingNominee);
            DB.SaveChanges();

            NomineeDetailResp data = new NomineeDetailResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }


        public NomineeDetailResp DeleteNomineeDetail(int ID)
        {
            NomineeDetail del = DB.NomineeDetail.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.NomineeDetail.Remove(del);
            DB.SaveChanges();
            NomineeDetailResp data = new NomineeDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    }

}
