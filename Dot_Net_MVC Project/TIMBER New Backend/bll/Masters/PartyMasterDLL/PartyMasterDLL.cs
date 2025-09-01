using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Reflection;
using System.IO;

namespace RTA.Masters
{
    public class PartyMasterDLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public PartyMasterDLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public PartyMasterResp GetPartyMaster(int pageNo, int limit, string searchKey)
        {
            //IQueryable<PartyMaster> query = DB.PartyMaster.Include(e => e.PartyAddressTransMaster)
            //                      .Include(es => es.AggrementMaster)

            ;
            IQueryable<PartyMaster> query = DB.PartyMaster
                .Include(party => party.PartyAddressTransMaster)
                .Include(ag => ag.AggrementMaster.Where(aggre => aggre.delete == 0))
                    .ThenInclude(aggre => aggre.ItemMaster)
                .Include(ag => ag.AggrementMaster.Where(aggre => aggre.delete == 0))
                    //.ThenInclude(aggre => aggre.IssueReceiptTransDetail)
                    .Where(party => party.delete_at == 0);


            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                EF.Functions.Like(e.name, $"%{searchKey}%") ||
                EF.Functions.Like(e.party_company_name, $"%{searchKey}%") ||
                EF.Functions.Like(e.party_group_category_name, $"%{searchKey}%") ||
                EF.Functions.Like(e.mobile_number.ToString(), $"%{searchKey}%"));

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
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyMasterDetailData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }



        public PartyMasterResp GetAllPartyMaster(int pageNo, int limit, string searchKey)
        {

            IQueryable<PartyMaster> query = DB.PartyMaster
            .Where(party => party.delete_at == 0
                     && (party.party_group_category_name == "Creditors"
                         || party.party_group_category_name == "Debtors"));

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                EF.Functions.Like(e.name, $"%{searchKey}%") ||
                EF.Functions.Like(e.email, $"%{searchKey}%") ||
                EF.Functions.Like(e.address, $"%{searchKey}%") ||
                EF.Functions.Like(e.mobile_number.ToString(), $"%{searchKey}%"));

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
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyMasterDetailData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }


        public PartyMasterResp GetAllPartyMasterFilterData(string? filter, string? search)
        {
            IQueryable<PartyMaster> query;

            if (filter == "cash")
            {
                query = DB.PartyMaster
                    .Where(party => party.delete_at == 0
                        && (party.party_group_category_name == "BANK IN HAND"
                            || party.party_group_category_name == "CASH IN HAND"));
            }
            else
            {
                query = DB.PartyMaster
                    .Where(party => party.delete_at == 0
                        && party.party_group_category_name != "BANK IN HAND"
                        && party.party_group_category_name != "CASH IN HAND");
            }


            // Apply search filter
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(party =>
                    EF.Functions.Like(party.name, $"%{search}%")
                // EF.Functions.Like(party.party_group_category_name, $"%{search}%") ||
                // EF.Functions.Like(party.party_address, $"%{search}%") // Add other fields as necessary
                );
            }


            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                PartyMasterDetailData = query.ToList()
            };

            return data;
        }


        public PartyMasterResp GetPartyMasterByID(int id)
        {

            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyMasterDetailByID = DB.PartyMaster.
                  Include(e => e.PartyAddressTransMaster).
                  Include(e => e.PartyContactTransMaster)
                  .Include(e => e.Remark_Upload_Detail.Where(p => p.delete_at == 0))
                   //.Include(e => e.Remark_Upload_Detail.Where(p => e.delete_at == 0))
                   .Where(e => e.id == id && e.delete_at == 0)
                    .FirstOrDefault()
                //.SingleOrDefault(e => e.id == id)
            };

            return data;
        }


        public PartyMasterResp GetLastPartyMasterMasterId()
        {
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                lastId = (long)(DB.PartyMaster.Max(u => (long?)u.id) ?? 0)


            };
            return data;
        }

        public PartyMasterResp PartyNameExistsInDatabase(PartyMasterReq samp)
        {
            PartyMasterResp data = new PartyMasterResp()
            {
                status = false,
                Message = $"Party name '{samp.name.Trim()}' already exists.",
                PartyMasterDetailByID = DB.PartyMaster.Where(e => e.name == samp.name.Trim()).FirstOrDefault()
            };
            return data;
        }


        public PartyMasterResp InsertPartyMaster(PartyMasterReq samp)
        {
            PartyMaster SampData = new PartyMaster()
            {
                name = samp.name,
                email = samp.email,
                mobile_number = samp.mobile_number,
                address = samp.address,
                pincode = samp.pincode,
                hire_status = samp.hire_status,
                agreement_start_date = samp.agreement_start_date,
                agreement_end_date = samp.agreement_end_date,
                type_of_service = samp.type_of_service,
                bill_type = samp.bill_type,
                group = samp.group,
                security_amount = samp.security_amount,
                tax_type = samp.tax_type,
                percentage = samp.percentage,
                dr = samp.dr,
                gstin = samp.gstin,
                ref_by = samp.ref_by,
                party_company_name = samp.party_company_name,
                party_group_category_name = samp.party_group_category_name,
                ref_commission = samp.ref_commission,
                party_agr_code = samp.party_agr_code,


                GSTIN_No = samp.GSTIN_No,
                Pay_Term_Days = samp.Pay_Term_Days,
                Addhar_No = samp.Addhar_No,
                PAN_NO = samp.PAN_NO,
                Ac_Opening_Date = samp.Ac_Opening_Date,
                Op_Bal = samp.Op_Bal,
                Dr_Cr = samp.Dr_Cr,

                DL_NO = samp.DL_NO,
                martital_status = samp.martital_status,
                gender = samp.gender,
                dob = samp.dob,
                anniversary = samp.anniversary,
                loyalty = samp.loyalty,
                important = samp.important,
                swh_Name = samp.swh_Name,
                relation_type = samp.relation_type,

                party_group_category_id = samp.party_group_category_id
            };

            DB.PartyMaster.Add(SampData);
            DB.SaveChanges();


            foreach (var item in samp.partyAddressTranskey)
            {
                PartyAddressTransMaster SampData1 = new PartyAddressTransMaster()
                {
                    party_master_id = SampData.id,
                    party_address_1 = item.party_address_1,
                    party_address_2 = item.party_address_2,
                    party_pincode = item.party_pincode,
                    party_state = item.party_state,
                    party_country = item.party_country,
                    party_address_description = item.party_address_description,

                    party_gst_type = item.party_gst_type,
                    party_gst_code = item.party_gst_code,
                    party_gst_address_no = item.party_gst_address_no,
                    party_address_location = item.party_address_location,


                };
                DB.PartyAddressTransMaster.Add(SampData1);
                DB.SaveChanges();
            }

            foreach (var item in samp.partyConactTranskey)
            {
                PartyContactTransMaster SampData2 = new PartyContactTransMaster()
                {
                    party_master_id = SampData.id,
                    party_contact_name = item.party_contact_name,
                    party_contact_mobile = item.party_contact_mobile,
                    party_contact_whatsapp_mobile = item.party_contact_whatsapp_mobile,
                    party_contact_email = item.party_contact_email,
                    party_contact_description = item.party_contact_description,

                    party_contact_department = item.party_contact_department,
                    party_contact_designation = item.party_contact_designation,
                    party_contact_website = item.party_contact_website,
                    party_contact_twitter_id = item.party_contact_twitter_id,
                    party_contact_fb_id = item.party_contact_fb_id,
                    party_contact_youtube_id = item.party_contact_youtube_id,
                    party_landline_no = item.party_landline_no,
                    party_contact_instagram_id = item.party_contact_instagram_id
                };
                DB.PartyContactTransMaster.Add(SampData2);
                DB.SaveChanges();
            }


            foreach (var key in samp.PM_Remark_Upload_Detail_Key)
            {
                Remark_Upload_Detail SampData3 = new Remark_Upload_Detail
                {
                    upload_document_path = key.upload_document_path,
                    attended_by = key.attended_by,
                    remarks = key.remarks,
                    party_master_id = SampData.id,
                    flag_master = "party"
                };

                DB.Remark_Upload_Detail.Add(SampData3);
            }

            DB.SaveChanges();


            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "inserted successfully",
            };
            return data;
        }

        public PartyMasterResp UpdatePartyMaster(long partyId, PartyMasterReq samp)
        {
            var existingParty = DB.PartyMaster.FirstOrDefault(p => p.id == partyId);

            if (existingParty != null)
            {
                if (existingParty.name != samp.name)
                {
                    PartyMaster CheckName = DB.PartyMaster.Where(E => E.name == samp.name.Trim()).FirstOrDefault();
                    if (CheckName != null)
                    {
                        PartyMasterResp data1 = new PartyMasterResp()
                        {
                            status = true,
                            Message = $"Party name '{samp.name.Trim()}' already exists.",

                        };
                        return data1;
                    }
                }


                existingParty.name = samp.name;
                existingParty.email = samp.email;
                existingParty.mobile_number = samp.mobile_number;
                existingParty.address = samp.address;
                existingParty.pincode = samp.pincode;
                existingParty.hire_status = samp.hire_status;
                existingParty.agreement_start_date = samp.agreement_start_date;
                existingParty.agreement_end_date = samp.agreement_end_date;
                existingParty.type_of_service = samp.type_of_service;
                existingParty.bill_type = samp.bill_type;
                existingParty.group = samp.group;
                existingParty.security_amount = samp.security_amount;
                existingParty.tax_type = samp.tax_type;
                existingParty.percentage = samp.percentage;
                existingParty.dr = samp.dr;
                existingParty.gstin = samp.gstin;
                existingParty.ref_by = samp.ref_by;

                existingParty.party_company_name = samp.party_company_name;
                existingParty.party_group_category_name = samp.party_group_category_name;
                existingParty.party_agr_code = samp.party_agr_code;


                existingParty.GSTIN_No = samp.GSTIN_No;
                existingParty.Pay_Term_Days = samp.Pay_Term_Days;
                existingParty.Addhar_No = samp.Addhar_No;
                existingParty.PAN_NO = samp.PAN_NO;
                existingParty.Ac_Opening_Date = samp.Ac_Opening_Date;
                existingParty.Op_Bal = samp.Op_Bal;
                existingParty.Dr_Cr = samp.Dr_Cr;
                existingParty.ref_commission = samp.ref_commission;
                existingParty.party_group_category_id = samp.party_group_category_id;



                existingParty.DL_NO = samp.DL_NO;
                existingParty.martital_status = samp.martital_status;
                existingParty.gender = samp.gender;
                existingParty.dob = samp.dob;
                existingParty.anniversary = samp.anniversary;
                existingParty.loyalty = samp.loyalty;
                existingParty.important = samp.important;


                existingParty.swh_Name = samp.swh_Name;
                existingParty.relation_type = samp.relation_type;

                foreach (var item in samp.partyAddressTranskey)
                {
                    var existingAddress = DB.PartyAddressTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingAddress == null)
                    {
                        PartyAddressTransMaster SampData1 = new PartyAddressTransMaster()
                        {
                            party_master_id = existingParty.id,
                            party_address_1 = item.party_address_1,
                            party_address_2 = item.party_address_2,
                            party_pincode = item.party_pincode,
                            party_state = item.party_state,
                            party_country = item.party_country,
                            party_address_description = item.party_address_description,
                            party_gst_type = item.party_gst_type,
                            party_gst_code = item.party_gst_code,
                            party_gst_address_no = item.party_gst_address_no,
                            party_address_location = item.party_address_location,

                        };
                        DB.PartyAddressTransMaster.Add(SampData1);
                    }
                    else
                    {
                        existingAddress.party_address_1 = item.party_address_1;
                        existingAddress.party_address_2 = item.party_address_2;
                        existingAddress.party_pincode = item.party_pincode;
                        existingAddress.party_state = item.party_state;
                        existingAddress.party_country = item.party_country;
                        existingAddress.party_address_description = item.party_address_description;
                        existingAddress.party_gst_type = item.party_gst_type;
                        existingAddress.party_gst_code = item.party_gst_code;
                        existingAddress.party_gst_address_no = item.party_gst_address_no;
                        existingAddress.party_address_location = item.party_address_location;


                    }
                }

                foreach (var item in samp.partyConactTranskey)
                {
                    var existingContact = DB.PartyContactTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingContact == null)
                    {
                        PartyContactTransMaster SampData2 = new PartyContactTransMaster()
                        {
                            party_master_id = existingParty.id,
                            party_contact_name = item.party_contact_name,
                            party_contact_mobile = item.party_contact_mobile,
                            party_contact_whatsapp_mobile = item.party_contact_whatsapp_mobile,
                            party_contact_email = item.party_contact_email,
                            party_contact_description = item.party_contact_description,
                            party_contact_department = item.party_contact_department,
                            party_contact_designation = item.party_contact_designation,
                            party_contact_website = item.party_contact_website,
                            party_contact_twitter_id = item.party_contact_twitter_id,
                            party_contact_fb_id = item.party_contact_fb_id,
                            party_contact_youtube_id = item.party_contact_youtube_id,
                            party_landline_no = item.party_landline_no,
                            party_contact_instagram_id = item.party_contact_instagram_id

                        };
                        DB.PartyContactTransMaster.Add(SampData2);
                    }
                    else
                    {
                        existingContact.party_contact_name = item.party_contact_name;
                        existingContact.party_contact_mobile = item.party_contact_mobile;
                        existingContact.party_contact_whatsapp_mobile = item.party_contact_whatsapp_mobile;
                        existingContact.party_contact_email = item.party_contact_email;
                        existingContact.party_contact_description = item.party_contact_description;
                        existingContact.party_contact_department = item.party_contact_department;
                        existingContact.party_contact_designation = item.party_contact_designation;
                        existingContact.party_contact_website = item.party_contact_website;
                        existingContact.party_contact_twitter_id = item.party_contact_twitter_id;
                        existingContact.party_contact_fb_id = item.party_contact_fb_id;
                        existingContact.party_contact_youtube_id = item.party_contact_youtube_id;
                        existingContact.party_landline_no = item.party_landline_no;
                        existingContact.party_contact_instagram_id = item.party_contact_instagram_id;

                    }
                }


                foreach (var key in samp.PM_Remark_Upload_Detail_Key)
                {
                    Remark_Upload_Detail exitingdata = DB.Remark_Upload_Detail.Where(e => e.id == key.id && e.delete_at == 0).FirstOrDefault();

                    if (exitingdata != null)
                    {
                        exitingdata.upload_document_path = key.upload_document_path;
                        exitingdata.attended_by = key.attended_by;
                        exitingdata.remarks = key.remarks;

                    }
                    else
                    {
                        Remark_Upload_Detail SampData3 = new Remark_Upload_Detail
                        {
                            upload_document_path = key.upload_document_path,
                            attended_by = key.attended_by,
                            remarks = key.remarks,
                            party_master_id = existingParty.id,
                            flag_master = "party"
                        };
                        DB.Remark_Upload_Detail.Add(SampData3);
                    }
                    DB.SaveChanges();

                }

                foreach (var item in samp.partyDeleteAddressTranskey)
                {
                    var existingAddress = DB.PartyAddressTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingAddress != null)
                    {
                        DB.PartyAddressTransMaster.Remove(existingAddress);
                    }
                }

                foreach (var item in samp.partyDeleteContactTranskey)
                {
                    var existingContact = DB.PartyContactTransMaster.FirstOrDefault(p => p.id == item.id);
                    if (existingContact != null)
                    {
                        DB.PartyContactTransMaster.Remove(existingContact);
                    }
                }


                foreach (var key in samp.PM_Remove_Remark_Upload_Detail_Key)
                {
                    Remark_Upload_Detail existingDeleteData = DB.Remark_Upload_Detail.Where(e => e.id == key.id).FirstOrDefault();
                    if (existingDeleteData != null)
                    {
                        existingDeleteData.delete_at = 1;
                        DB.SaveChanges();
                    }
                }

                DB.SaveChanges();
            }

            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }


        public PartyMasterResp CheckDeletePartyMasterIfExistsInMaster(long partyId)
        {
            var challan = DB.IssueReceiptMaster
           .Where(e => e.pcode == partyId && e.delete_at == 0)
           .ToList();

            if (challan.Count != null)
            {
                PartyMasterResp data1 = new PartyMasterResp()
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


            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "Party cannot exist in another data",
                IssueReceiptMaster = challan
            };
            return data;


            //PartyMaster del = DB.PartyMaster.
            //    Include(e => e.PartyAddressTransMaster).
            //    Include(e => e.PartyContactTransMaster).
            //    Include(e => e.AggrementMaster).
            //    Include(e=> e.PartyItemRateTrans).
            //    Where(x => x.id == partyId).SingleOrDefault();

            //if (del == null)
            //{
            //    throw new Exception("RECORD NOT FOUND");
            //}


            //if (del.PartyAddressTransMaster != null)
            //{
            //    DB.PartyAddressTransMaster.RemoveRange(del.PartyAddressTransMaster);
            //}

            //if (del.PartyContactTransMaster != null)
            //{
            //    DB.PartyContactTransMaster.RemoveRange(del.PartyContactTransMaster);
            //}

            //if (del.AggrementMaster != null)
            //{
            //    DB.AggrementMaster.RemoveRange(del.AggrementMaster);
            //}

            //if (del.PartyItemRateTrans != null)
            //{
            //    DB.PartyItemRateTrans.RemoveRange(del.PartyItemRateTrans);
            //}


            //DB.PartyMaster.Remove(del);
            //DB.SaveChanges();
            //PartyMasterResp data = new PartyMasterResp()
            //{
            //    status = true,
            //    Message = "deleted successfully"
            //};
            //return data;
        }

        public PartyMasterResp DeletePartyMaster(long partyId)
        {

            PartyMaster del = DB.PartyMaster.
                Include(e => e.PartyAddressTransMaster).
                Include(e => e.PartyContactTransMaster).
                Include(e => e.AggrementMaster).
                Include(e => e.PartyItemRateTrans).
                Where(x => x.id == partyId).SingleOrDefault();

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


            DB.PartyMaster.Remove(del);
            DB.SaveChanges();
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

       public PartyMasterResp GetPartyMasterDataByMobileNo(string? mobileNo = null)
        {
            List<PartyMaster> PartyData;

            if (string.IsNullOrWhiteSpace(mobileNo))
            {
                // If mobileNo is null or empty, fetch all records or handle as required
                PartyData = new List<PartyMaster>();

            }
            else
            {
                // If mobileNo is provided, perform the "like" search
                PartyData = DB.PartyMaster
                    .Include(e => e.PartyAddressTransMaster)
                    .Include(e => e.PartyContactTransMaster)
                    .Where(e => e.PartyContactTransMaster.Any(c => EF.Functions.Like(c.party_contact_mobile, $"%{mobileNo}%")))
                    .ToList();
            }

            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "fetch successfully",
                PartyMasterDetailData = PartyData
            };

            return data;
       }








    }
}