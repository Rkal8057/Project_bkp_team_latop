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
    public class HolderDetailBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public HolderDetailBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public HolderDetailResp GetHolderDetail(int pageNo, int limit, string? searchKey = null)
        {

            var query = DB.HolderDetail
                .Include(e => e.KYCDetail)
                .Include(e => e.NomineeDetail)
                .Include(e => e.PowerAttorney)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(r =>
                    EF.Functions.Like(r.holder_fullname, $"%{searchKey}%") ||
                    EF.Functions.Like(r.holder_folio_no, $"%{searchKey}%")
                //r.NomineeDetail.Any(n => EF.Functions.Like(n.n_name_new, $"%{searchKey}%"))
                );
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

            List<HolderDetail> paginatedData = query.Skip(skip).Take(limit).ToList();

            HolderDetailResp data = new HolderDetailResp()
            {
                status = true,
                Message = "Data fetched successfully",
                HolderDetailDetailData = paginatedData,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit
            };

            return data;
        }

        public HolderDetailResp GetHolderDetailByID(int id)
        {

            HolderDetailResp data = new HolderDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                HolderDetailDetailByID = DB.HolderDetail
                .Include(e => e.KYCDetail)
                .Include(e => e.NomineeDetail)
                .Include(e => e.PowerAttorney)
                .Where(e => e.id == id)
                .SingleOrDefault()
            };

            return data;
        }

        public HolderDetailResp InsertHolderDetail(HolderDetailReq samp)
        {
            HolderDetail SampData = new HolderDetail()
            {
                holder_fullname = samp.holder_fullname,
                holder_gender = samp.holder_gender,
                holder_dob = samp.holder_dob,
                holder_occupation = samp.holder_occupation,
                holder_fathername = samp.holder_fathername,
                holder_address1 = samp.holder_address1,
                holder_address2 = samp.holder_address2,
                holder_city = samp.holder_city,
                holder_state = samp.holder_state,
                holder_country = samp.holder_country,
                holder_email = samp.holder_email,
                holder_phone = samp.holder_phone,
                holder_pincode = samp.holder_pincode,
                holder_pincard = samp.holder_pincard,
                holder_kyc_updated = samp.holder_kyc_updated,
                holder_folio_no = samp.holder_folio_no,
            };

            DB.HolderDetail.Add(SampData);
            DB.SaveChanges();

            KYCDetail sampData1 = new KYCDetail()
            {
                holder_detail_id = SampData.id,
                p_account_type_code = samp.p_account_type_code,
                p_account_type = samp.p_account_type,
                p_bank_ac_no = samp.p_bank_ac_no,
                p_bank_name = samp.p_bank_name,
                p_bank_micrno = samp.p_bank_micrno,
                p_bank_add1 = samp.p_bank_add1,
                p_bank_add2 = samp.p_bank_add2,
                p_address_type_code_bank = samp.p_address_type_code_bank,
                p_bank_city = samp.p_bank_city,
                p_bank_state = samp.p_bank_state,
                p_bank_pincode = samp.p_bank_pincode,
                p_bank_country = samp.p_bank_country,
                p_bank_ifsc_code = samp.p_bank_ifsc_code
            };

            DB.KYCDetail.Add(sampData1);
            DB.SaveChanges();

            NomineeDetail sampData2 = new NomineeDetail()
            {
                holder_detail_id = SampData.id,
                n_update_type_nominee = samp.n_update_type_nominee,
                n_name_new = samp.n_name_new,
                n_relation_new = samp.n_relation_new,
                n_gender_new = samp.n_gender_new,
                n_pan_new = samp.n_pan_new,
                n_f_m_w_name_new = samp.n_f_m_w_name_new,
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
                n_occupation_det_new_code = samp.n_occupation_det_new_code,
                n_date_of_att_majority_new = samp.n_date_of_att_majority_new,
                n_gaurdian_name_new = samp.n_gaurdian_name_new,
                n_gaurdian_address_new = samp.n_gaurdian_address_new,
            };
            DB.NomineeDetail.Add(sampData2);
            DB.SaveChanges();


            PowerAttorney sampData3 = new PowerAttorney
            {
                holder_detail_id = SampData.id,
                power_attorney_TrfNo = samp.power_attorney_TrfNo,
                power_attorney_Date = samp.power_attorney_Date,
                power_attorney_Name = samp.power_attorney_Name,
                power_attorney_PanNo = samp.power_attorney_PanNo,
                power_attorney_Type = samp.power_attorney_Type,
                power_attorney_Relation = samp.power_attorney_Relation,
                power_attorney_F_M_W_Name = samp.power_attorney_F_M_W_Name,
                power_attorney_Dob = samp.power_attorney_Dob,
                power_attorney_M_F = samp.power_attorney_M_F,
                power_attorney_Add1 = samp.power_attorney_Add1,
                power_attorney_Add2 = samp.power_attorney_Add2,
                power_attorney_City = samp.power_attorney_City,
                power_attorney_Pincode = samp.power_attorney_Pincode,
                power_attorney_State = samp.power_attorney_State,
                power_attorney_Country = samp.power_attorney_Country,
                power_attorney_Email = samp.power_attorney_Email,
                power_attorney_Phone = samp.power_attorney_Phone
            };

            DB.PowerAttorney.Add(sampData3);
            DB.SaveChanges();




            HolderDetailResp data = new HolderDetailResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public HolderDetailResp UpdateHolderDetail(int ID, HolderDetailReq samp)
        {

            HolderDetail existingSampData = DB.HolderDetail.Where(h => h.id == ID).FirstOrDefault();
            NomineeDetail nomineeDetail = DB.NomineeDetail.Where(h => h.holder_detail_id == existingSampData.id).FirstOrDefault();
            PowerAttorney powerAttorney = DB.PowerAttorney.Where(h => h.holder_detail_id == existingSampData.id).FirstOrDefault();
            KYCDetail kycDetail = DB.KYCDetail.Where(h => h.holder_detail_id == existingSampData.id).FirstOrDefault();


            if (existingSampData != null)
            {
                // Update properties with values from HolderDetailReq
                existingSampData.holder_fullname = samp.holder_fullname;
                existingSampData.holder_gender = samp.holder_gender;
                existingSampData.holder_dob = samp.holder_dob;
                existingSampData.holder_occupation = samp.holder_occupation;
                existingSampData.holder_fathername = samp.holder_fathername;
                existingSampData.holder_address1 = samp.holder_address1;
                existingSampData.holder_address2 = samp.holder_address2;
                existingSampData.holder_city = samp.holder_city;
                existingSampData.holder_state = samp.holder_state;
                existingSampData.holder_country = samp.holder_country;
                existingSampData.holder_email = samp.holder_email;
                existingSampData.holder_phone = samp.holder_phone;
                existingSampData.holder_pincode = samp.holder_pincode;
                existingSampData.holder_pincard = samp.holder_pincard;
                existingSampData.holder_kyc_updated = samp.holder_kyc_updated;
                existingSampData.holder_folio_no = samp.holder_folio_no;



                if (kycDetail != null)
                {
                    kycDetail.p_account_type_code = kycDetail.p_account_type_code;
                    kycDetail.p_account_type = kycDetail.p_account_type;
                    kycDetail.p_bank_ac_no = kycDetail.p_bank_ac_no;
                    kycDetail.p_bank_name = kycDetail.p_bank_name;
                    kycDetail.p_bank_micrno = kycDetail.p_bank_micrno;
                    kycDetail.p_bank_add1 = kycDetail.p_bank_add1;
                    kycDetail.p_bank_add2 = kycDetail.p_bank_add2;
                    kycDetail.p_address_type_code_bank = kycDetail.p_address_type_code_bank;
                    kycDetail.p_bank_city = kycDetail.p_bank_city;
                    kycDetail.p_bank_state = kycDetail.p_bank_state;
                    kycDetail.p_bank_pincode = kycDetail.p_bank_pincode;
                    kycDetail.p_bank_country = kycDetail.p_bank_country;
                    kycDetail.p_bank_ifsc_code = kycDetail.p_bank_ifsc_code;
                }

                if (nomineeDetail != null)
                {          
                    nomineeDetail.n_name_new = samp.n_name_new;
                    nomineeDetail.n_relation_new = samp.n_relation_new;
                    nomineeDetail.n_gender_new = samp.n_gender_new;
                    nomineeDetail.n_pan_new = samp.n_pan_new;
                    nomineeDetail.n_f_m_w_name_new = samp.n_f_m_w_name_new;
                    nomineeDetail.n_dob_new = samp.n_dob_new;
                    nomineeDetail.n_phone_new = samp.n_phone_new;
                    nomineeDetail.n_add2_new = samp.n_add2_new;
                    nomineeDetail.n_add1_new = samp.n_add1_new;
                    nomineeDetail.n_city_new = samp.n_city_new;
                    nomineeDetail.n_pincode_new = samp.n_pincode_new;
                    nomineeDetail.n_state_new = samp.n_state_new;
                    nomineeDetail.n_country_new = samp.n_country_new;
                    nomineeDetail.n_email_new = samp.n_email_new;
                    nomineeDetail.n_address_type_code_nominee = samp.n_address_type_code_nominee;
                    nomineeDetail.n_occupation_det_new_code = samp.n_occupation_det_new_code;
                    nomineeDetail.n_date_of_att_majority_new = samp.n_date_of_att_majority_new;
                    nomineeDetail.n_gaurdian_name_new = samp.n_gaurdian_name_new;
                    nomineeDetail.n_gaurdian_address_new = samp.n_gaurdian_address_new;
                }



                if (powerAttorney != null)
                {
                    powerAttorney.power_attorney_TrfNo = powerAttorney.power_attorney_TrfNo;
                    powerAttorney.power_attorney_Date = powerAttorney.power_attorney_Date;
                    powerAttorney.power_attorney_Name = powerAttorney.power_attorney_Name;
                    powerAttorney.power_attorney_Type = powerAttorney.power_attorney_Type;
                    powerAttorney.power_attorney_PanNo = powerAttorney.power_attorney_PanNo;
                    powerAttorney.power_attorney_Relation = powerAttorney.power_attorney_Relation;
                    powerAttorney.power_attorney_F_M_W_Name = powerAttorney.power_attorney_F_M_W_Name;
                    powerAttorney.power_attorney_Dob = powerAttorney.power_attorney_Dob;
                    powerAttorney.power_attorney_M_F = powerAttorney.power_attorney_M_F;
                    powerAttorney.power_attorney_Add1 = powerAttorney.power_attorney_Add1;
                    powerAttorney.power_attorney_Add2 = powerAttorney.power_attorney_Add2;
                    powerAttorney.power_attorney_City = powerAttorney.power_attorney_City;
                    powerAttorney.power_attorney_Pincode = powerAttorney.power_attorney_Pincode;
                    powerAttorney.power_attorney_State = powerAttorney.power_attorney_State;
                    powerAttorney.power_attorney_Country = powerAttorney.power_attorney_Country;
                    powerAttorney.power_attorney_Email = powerAttorney.power_attorney_Email;
                    powerAttorney.power_attorney_Phone = powerAttorney.power_attorney_Phone;
                }

                DB.SaveChanges();
            }

            HolderDetailResp data = new HolderDetailResp()
            {
                status = true,
                Message = "UPDATED successfully",
            };
            return data;
        }

        public HolderDetailResp DeleteHolderDetail(int ID)
        {
            HolderDetail holderDetail = DB.HolderDetail
             .Include(e => e.KYCDetail)
             .Include(e => e.NomineeDetail)
             .Include(e => e.PowerAttorney)
             .Where(e => e.id == ID)
             .SingleOrDefault();

            if (holderDetail == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.HolderDetail.Remove(holderDetail);
            if (holderDetail.KYCDetail != null)
            {
                DB.KYCDetail.RemoveRange(holderDetail.KYCDetail);
            }
            if (holderDetail.NomineeDetail != null)
            {
                DB.NomineeDetail.RemoveRange(holderDetail.NomineeDetail);
            }
            if (holderDetail.PowerAttorney != null)
            {
                DB.PowerAttorney.RemoveRange(holderDetail.PowerAttorney);
            }
            DB.SaveChanges();
            HolderDetailResp data = new HolderDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    }
}