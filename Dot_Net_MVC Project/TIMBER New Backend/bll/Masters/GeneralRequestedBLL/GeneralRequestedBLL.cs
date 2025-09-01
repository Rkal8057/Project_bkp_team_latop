using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace RTA.Masters
{
    public class GeneralRequestedBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public GeneralRequestedBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public GeneralRequestedResp InsertGeneralRequested(GeneralRequestedReq samp)
        {


            User_Detail checkUserDetail = DB.User_Detail.Where(e => e.user_mobile == long.Parse(samp.userDetail.mobile_no)).FirstOrDefault();
            User_Detail new_user = null;

            if ( checkUserDetail == null)
            {
                User_Profile_Master userProfile = DB.User_Profile_Master.Where(x => x.id == samp.userDetail.user_profile_id).FirstOrDefault();

                 new_user = new User_Detail()
                {
                    user_code = long.Parse(samp.userDetail.mobile_no),
                    user_name = samp.userDetail.user_name,
                    user_pass = samp.userDetail.mobile_no,
                    user_email = samp.userDetail.email,
                    user_email_pass = samp.userDetail.email,
                    //user_pancard = samp.user_pancard,
                    user_mobile = long.Parse(samp.userDetail.mobile_no),
                    user_status = "ACTIVE",
                    //software_version = samp.software_version,
                    //user_allotement_status = samp.user_allotement_status,
                    user_profile_id = samp.userDetail.user_profile_id,
                    user_profile = userProfile.user_profile,
                    save_yes_no = userProfile.save_yes_no,
                    delete_yes_no = userProfile.delete_yes_no,
                    modify_yes_no = userProfile.modify_yes_no,
                    report_yes_no = userProfile.report_yes_no,
                    print_only = userProfile.print_only,
                    view_yes_no = userProfile.view_yes_no,
                    user_created_on = DateTime.Now,

                };

                DB.User_Detail.Add(new_user);
                DB.SaveChanges();

            }

            PartyMaster PartyData = DB.PartyMaster
                 .Include(e => e.PartyAddressTransMaster)
                 .Include(e => e.PartyContactTransMaster)
                 .Where(e => e.PartyContactTransMaster.Any(c => (c.party_contact_mobile == samp.userDetail.mobile_no)))
                 .FirstOrDefault();


            PartyMaster SampData2 = null; 

            if (PartyData == null) 
            {
                 SampData2 = new PartyMaster()
                 { 
                    party_agr_code = samp.userDetail.user_agr_code,
                    party_company_name = samp.userDetail.user_name,
                    name = samp.userDetail.user_name,
                    group = samp.userDetail.group,
                    //mobile_number = long.Parse(samp.userDetail.mobile_no),
                    //email= samp.userDetail.email
                };

                DB.PartyMaster.Add(SampData2);
                DB.SaveChanges();

                PartyContactTransMaster SampData3 = new PartyContactTransMaster()
                {
                    party_contact_name = samp.userDetail.user_name,
                    party_contact_description = "primary",
                    party_master_id = SampData2.id,
                    party_contact_mobile = samp.userDetail.mobile_no,
                    party_contact_email = samp.userDetail.email,
               };
                DB.PartyContactTransMaster.Add(SampData3);
                DB.SaveChanges();

            }


            /// general request fucntion 

            GeneralRequestedDetail SampData = new GeneralRequestedDetail()
            {
                //user_id = PartyData?.id ?? SampData2?.id,
                user_id = checkUserDetail?.id ?? new_user?.id,
                party_id = PartyData?.id ?? SampData2?.id,
                service_id = samp.service_id,
                subservice_id = samp.subservice_id,
                gen_approx_amount= samp.gen_approx_amount,
                gen_approx_days = samp.gen_approx_days,
                service_name= samp.service_name,
                subservice_name = samp.subservice_name,

                general_req_disc_type = samp.general_req_disc_type,         // Discount type (e.g., "percentage" or "amount")
                general_req_disc_per = samp.general_req_disc_per,          
                general_req_disc_amt = samp.general_req_disc_amt,           
                general_req_after_disc_amt = samp.general_req_after_disc_amt, 
                general_req_receive_amt = samp.general_req_receive_amt,    
                general_req_pending_amt = samp.general_req_pending_amt,     
                general_req_final_amt = samp.general_req_final_amt,


                // New properties for commission and key amount

                general_req_commission_amt = samp.general_req_commission_amt,
                general_req_commission_type = samp.general_req_commission_type,
                general_req_commission_percentage = samp.general_req_commission_percentage,
                general_req_key_amt = samp.general_req_key_amt,
                general_req_key_remark = samp.general_req_key_remark,


                sender_name = samp.sender_name,
                sender_mobile = samp.sender_mobile,
                receiver_name = samp.receiver_name,
                receiver_mobile = samp.receiver_mobile,
                general_req_document_img_option = samp.general_req_document_img_option,

                general_req_payment_mode= samp.general_req_payment_mode,
                general_req_payment_status = samp.general_req_payment_status,
                general_req_transaction_id = samp.general_req_transaction_id,
                general_req_transaction_image = samp.general_req_transaction_image

                //GeneralRequestCheckListDetail = samp.GeneralRequestCheckListDetail,
            };

            DB.GeneralRequestedDetail.Add(SampData);
            DB.SaveChanges();

            // general request checklist  

            if (samp.GeneralRequestCheckListDetail.Count != 0)
            {

                foreach (var checkListData in samp.GeneralRequestCheckListDetail)
                {

                    CheckListMaster document_type = DB.CheckListMaster.Where(E => E.subservice_id == samp.subservice_id
                    &&  E.document_required_name == checkListData.required_info).FirstOrDefault();

                    GeneralRequestCheckListDetail SampData1 = new GeneralRequestCheckListDetail()
                    {
                        required_info = checkListData.required_info,
                        required_info_data = checkListData.required_info_data,
                        general_requested_detail_id = SampData.id,
                        required_type = document_type.document_required_type,
                        required_position = document_type.document_required_position,
                        required_option = document_type.document_required_option,
                        required_col_size = document_type.document_required_col_size
                    };

                    DB.GeneralRequestCheckListDetail.Add(SampData1);
                    DB.SaveChanges();
                }
            }


            // general request remark 

            if (samp.GeneralRequestRemark.Count != 0)
            {

                foreach (var remark in samp.GeneralRequestRemark)
                {
                    GeneralRequestRemark SampData7 = new GeneralRequestRemark()
                    {
                        general_request_id = SampData.id,
                        general_req_key_remark = remark.general_req_key_remark
                    };

                    DB.GeneralRequestRemark.Add(SampData7);
                    DB.SaveChanges();
                }
            }


             GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public GeneralRequestedResp GetGeneralRequested(long? id, int pageNo, int limit, string filter = null, string searchKey = null,
            DateTime? startDate = null , DateTime? endDate = null )
        {
            IQueryable<GeneralRequestedDetail> query;
            int totalCount;

            // If id is not provided, get all data; otherwise, get data for the specific id
            if (id.HasValue && id.Value > 0)
            {
                totalCount = DB.GeneralRequestedDetail.Count(e => e.user_id == id.Value);
                query = DB.GeneralRequestedDetail
                    .Include(r => r.GeneralRequestCheckListDetail)
                    .Where(r => r.user_id == id.Value);
            }
            else
            {
                totalCount = DB.GeneralRequestedDetail.Count();
                query = DB.GeneralRequestedDetail
                    .Include(r => r.GeneralRequestCheckListDetail);
            }

            // Add the status filter conditionally
            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(r => r.status == filter.Trim());
            }

            if (startDate != null && endDate != null)
            {
                // Ensure startDate and endDate are DateTime objects
                DateTime startOfDay = startDate.Value;
                DateTime endOfDay = endDate.Value.AddDays(1).AddTicks(-1);

                query = query.Where(r => r.created_at >= startOfDay && r.created_at <= endOfDay);
            }


            // Add the search conditionally
            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                       EF.Functions.Like(e.service_name, $"%{searchKey}%") ||
                       EF.Functions.Like(e.subservice_name, $"%{searchKey}%"));
            }

            int totalPages = (int)Math.Ceiling((double)totalCount / limit);

            int skip = (pageNo - 1) * limit;


            var partyIds = query.Select(r => r.party_id).Distinct().ToList();
            var parties = DB.PartyMaster
                .Include( e=> e.PartyContactTransMaster)
                .Where(e => partyIds.Contains(e.id))
                .ToDictionary(e => e.id);

            List<GeneralRequestedDetail> list = query
                .Skip(skip)
                .Take(limit)               
                .Select(r => new GeneralRequestedDetail
                {
                    id = r.id,
                    status = r.status,
                    user_id = r.user_id,
                    party_id = r.party_id,
                    service_name = r.service_name,
                    subservice_name= r.subservice_name,
                    service_id = r.service_id,
                    subservice_id = r.subservice_id,
                    created_at = r.created_at,

                    GeneralRequestCheckListDetail = r.GeneralRequestCheckListDetail.Select(prd => new GeneralRequestCheckListDetail
                    {
                        required_info = prd.required_info,
                        required_info_data = prd.required_info_data,
                        required_type = prd.required_type,
                        // Add other GeneralRequestCheckListDetail properties as needed
                    }).ToList(),

                    Party = parties.ContainsKey((long)r.party_id) ? parties[(long)r.party_id] : null

                })
                .ToList();



            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "Data fetched successfully",
                GeneralRequestedDetailData = list,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,
            };

            return data;
        }

        public GeneralRequestedResp DeleteGeneralRequested(long id)
        {

            GeneralRequestedDetail del = DB.GeneralRequestedDetail
                .Include(r => r.GeneralRequestCheckListDetail)
                .Include(r=> r.GeneralRequestCommunicationDetail)
                .SingleOrDefault(parent => parent.id == id);
            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.status = "Discard";
            DB.SaveChanges();

            //if(del.GeneralRequestCheckListDetail.Count != 0 )
            //{
            //    DB.GeneralRequestCheckListDetail.RemoveRange(del.GeneralRequestCheckListDetail);
            //}

            //if (del.GeneralRequestCommunicationDetail.Count != 0)
            //{
            //    DB.GeneralRequestCommunicationDetail.RemoveRange(del.GeneralRequestCommunicationDetail);
            //}

            DB.SaveChanges();
            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

        public GeneralRequestedResp UpdateGeneralRequested(int id, GeneralRequestedReq samp)
        {

            GeneralRequestedDetail parentEntity = DB.GeneralRequestedDetail
            .Include(p => p.GeneralRequestCheckListDetail)
            .SingleOrDefault(p => p.id == id);


            if (parentEntity != null)
            {
                //parentEntity.service_id = samp.service_id;
                /* parentEntity.service_id = samp.service_id;
                 parentEntity.subservice_id = samp.subservice_id;
                 parentEntity.service_name = samp.service_name;
                 parentEntity.subservice_name = samp.subservice_name;
                 parentEntity.gen_approx_amount = samp.gen_approx_amount;
                 parentEntity.gen_approx_days = samp.gen_approx_days;*/

                parentEntity.gen_approx_amount = samp.gen_approx_amount;
                parentEntity.general_req_disc_type = samp.general_req_disc_type;         // Discount type (e.g.; "percentage" or "amount")
                parentEntity.general_req_disc_per = samp.general_req_disc_per;          
                parentEntity.general_req_disc_amt = samp.general_req_disc_amt;
                parentEntity.general_req_after_disc_amt = samp.general_req_after_disc_amt;
                parentEntity.general_req_receive_amt = samp.general_req_receive_amt;    
                parentEntity.general_req_pending_amt = samp.general_req_pending_amt;     
                parentEntity.general_req_final_amt = samp.general_req_final_amt;


                // New properties for commission and key amount

                parentEntity.general_req_commission_amt = samp.general_req_commission_amt;
                parentEntity.general_req_commission_type = samp.general_req_commission_type;
                parentEntity.general_req_commission_percentage = samp.general_req_commission_percentage;
                parentEntity.general_req_key_amt = samp.general_req_key_amt;
                parentEntity.general_req_key_remark = samp.general_req_key_remark;



                parentEntity.sender_name = samp.sender_name;
                parentEntity.sender_mobile = samp.sender_mobile;
                parentEntity.receiver_name = samp.receiver_name;
                parentEntity.receiver_mobile = samp.receiver_mobile;
                parentEntity.general_req_payment_mode = samp.general_req_payment_mode;
                parentEntity.general_req_payment_status = samp.general_req_payment_status;
                parentEntity.status = samp.status;

                foreach (GeneralRequestCheckListDetail updatedProcessDetail in samp.GeneralRequestCheckListDetail)
                {
                    GeneralRequestCheckListDetail existingCategory = parentEntity.GeneralRequestCheckListDetail.FirstOrDefault(c => c.id == updatedProcessDetail.id);

                    if (existingCategory != null)
                    {
                        existingCategory.required_info = updatedProcessDetail.required_info;
                        existingCategory.required_info_data = updatedProcessDetail.required_info_data;
                        existingCategory.required_type = updatedProcessDetail.required_type;
                        existingCategory.required_option = updatedProcessDetail.required_option;
                        existingCategory.required_col_size = updatedProcessDetail.required_col_size;
                    }
                }

                DB.SaveChanges();

                if (samp.GeneralRequestRemark.Count != 0)
                {

                    foreach (var remark in samp.GeneralRequestRemark)
                    {

                        var checkRemark = DB.GeneralRequestRemark.FirstOrDefault(e => e.id == remark.id);
                        if (checkRemark != null)
                        {
                            checkRemark.general_req_key_remark = remark.general_req_key_remark;
                            DB.SaveChanges();
                        }
                        else
                        {
                            GeneralRequestRemark SampData7 = new GeneralRequestRemark()
                            {
                                general_request_id = parentEntity.id,
                                general_req_key_remark = remark.general_req_key_remark
                            };

                            DB.GeneralRequestRemark.Add(SampData7);
                            DB.SaveChanges();
                        }
                       
                    }
                }
                
            }

            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public GeneralRequestedResp GetGeneralRequestedById(long id)
        {

            GeneralRequestedDetail detail = DB.GeneralRequestedDetail
            .Include(r => r.GeneralRequestCheckListDetail)
            .Include( r => r.GeneralRequestCommunicationDetail)
            .Include( r=> r.GeneralRequestRemark)
            //.Include(.GeneralRequestRemark
            //.Include(r => r.CategoryMaster)
            .FirstOrDefault(r => r.id == id);

            PartyMaster partyDetail = DB.PartyMaster
                .Include( e=> e.PartyContactTransMaster)
                .Where(E=> E.id == detail.party_id).FirstOrDefault();

            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "data fetched successfully",
                GeneralRequestedDetailByID = detail,
                PartyMasterData = partyDetail
            };
            return data;
        }

        public GeneralRequestedResp UpdateGeneralRequestedStatus(long id, string status)
        {

            GeneralRequestedDetail parentEntity = DB.GeneralRequestedDetail
          .SingleOrDefault(p => p.id == id);

            if (parentEntity != null)
            {
                parentEntity.status = status;
                DB.SaveChanges();
            }

            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "updated successfully",
            };
            return data;
        }

        public GeneralRequestedResp GetLastGeneralRequestedMasterMasterId()
        {
            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "data fetched successfully",
                lastId = (long)(DB.GeneralRequestedDetail.Max(u => (long?)u.id) ?? 0)
            };
            return data;
        }



        public  GeneralRequestedResp CreateGeneralRequestCommunicationMaster(GeneralRequestCommunicationDetailReq samp)
        {
            GeneralRequestCommunicationDetail SampData = new GeneralRequestCommunicationDetail()
            {
                user_id = samp.user_id,
                general_request_id = samp.general_request_id,
                general_request_remark = samp.general_request_remark,
            };

            DB.GeneralRequestCommunicationDetail.Add(SampData);
            DB.SaveChanges();

            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "inserted successfully",
            };
            return data;


        }


        public GeneralRequestedResp GetGeneralRequestCommunicationMaster(long generalReqId)
        {
            
            GeneralRequestedResp data = new GeneralRequestedResp()
            {
                status = true,
                Message = "fetch successfully",
                GeneralRequestCommunicationDetail = DB.GeneralRequestCommunicationDetail.Where( e=> e.general_request_id == generalReqId).ToList(),
            };
            return data;


        }
    }
}