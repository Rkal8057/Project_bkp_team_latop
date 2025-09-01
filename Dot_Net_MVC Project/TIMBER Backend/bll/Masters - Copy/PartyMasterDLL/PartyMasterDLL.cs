using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

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
            .Include(e => e.PartyAddressTransMaster)
            .Include(e => e.AggrementMaster)
             .ThenInclude(aggre => aggre.ItemMaster); 



            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                EF.Functions.Like(e.name, $"%{searchKey}%")||
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

        public PartyMasterResp GetPartyMasterByID(int id)
        {

            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyMasterDetailByID = DB.PartyMaster.
                  Include(e => e.PartyAddressTransMaster).
                  Include(e => e.PartyContactTransMaster) 
                  .SingleOrDefault(e => e.id == id)
            };

            return data; 
        }


        public PartyMasterResp PartyNameExistsInDatabase(PartyMasterReq samp)
        {
            PartyMasterResp data = new PartyMasterResp()
            {
                status = false,
                Message = "Party name already exists",
                PartyMasterDetailByID = DB.PartyMaster.Where(e => e.name == samp.name).FirstOrDefault()
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
                agreement_date = samp.agreement_date,
                bill_type = samp.bill_type,
                group = samp.group,
                security_amount = samp.security_amount,
                tax_type = samp.tax_type,
                percentage = samp.percentage,
                dr = samp.dr,
                gstin = samp.gstin,
                ref_by = samp.ref_by,
                party_company_name = samp.party_company_name,
                party_group_category_name  = samp.party_group_category_name,
                ref_commission = samp.ref_commission,


                GSTIN_No = samp.GSTIN_No,
                Pay_Term_Days = samp.Pay_Term_Days,
                Addhar_No = samp.Addhar_No,
                PAN_NO = samp.PAN_NO,
                Ac_Opening_Date = samp.Ac_Opening_Date,
                Op_Bal = samp.Op_Bal,
                Dr_Cr = samp.Dr_Cr
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
                existingParty.name = samp.name;
                existingParty.email = samp.email;
                existingParty.mobile_number = samp.mobile_number;
                existingParty.address = samp.address;
                existingParty.pincode = samp.pincode;
                existingParty.hire_status = samp.hire_status;
                existingParty.agreement_date = samp.agreement_date;
                existingParty.bill_type = samp. bill_type;
                existingParty.group = samp.group;
                existingParty.security_amount = samp.security_amount;
                existingParty.tax_type = samp.tax_type;
                existingParty.percentage = samp.percentage;
                existingParty.dr = samp.dr;
                existingParty.gstin = samp.gstin;
                existingParty.ref_by = samp.ref_by;

                existingParty.party_company_name = samp.party_company_name;
                existingParty.party_group_category_name = samp.party_group_category_name;


                existingParty.GSTIN_No = samp.GSTIN_No;
                existingParty.Pay_Term_Days = samp.Pay_Term_Days;
                existingParty.Addhar_No = samp.Addhar_No;
                existingParty.PAN_NO = samp.PAN_NO;
                existingParty.Ac_Opening_Date = samp.Ac_Opening_Date;
                existingParty.Op_Bal = samp.Op_Bal;
                existingParty.Dr_Cr = samp.Dr_Cr;
                existingParty.ref_commission = samp.ref_commission;


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

                DB.SaveChanges();
            }

            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }


        public PartyMasterResp DeletePartyMaster(long partyId)
        {
            PartyMaster del = DB.PartyMaster.
                Include(e=> e.PartyAddressTransMaster).
                Include(e=> e.PartyContactTransMaster).
                Include(e=> e.AggrementMaster).
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


            DB.PartyMaster.Remove(del);
            DB.SaveChanges();
             PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    

    }
}