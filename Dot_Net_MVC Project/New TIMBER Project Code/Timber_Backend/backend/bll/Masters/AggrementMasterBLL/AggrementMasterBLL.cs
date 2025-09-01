using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace RTA.Masters
{
    public class AggrementMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public AggrementMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public AggrementMasterResp InsertAggrementMaster(AggrementMasterReq samp)
        {



            var SampData = new AggrementMaster()
            {
                pname = samp.pname,
                pcode = samp.pcode,
                party_master_id = samp.party_master_id,
                pname_short_code = samp.pname_short_code,
                agr_code_old = samp.agr_code_old,
                agr_no_old = samp.agr_no_old,
                item_status_agr = samp.item_status_agr,
                item_code = samp.item_code,
                item_short_name = samp.item_short_name,
                item_name = samp.item_name,
                item_group_code = samp.item_group_code,
                item_group_name = samp.item_group_name,
                mix_item_yes_no = samp.mix_item_yes_no,
                item_loc = samp.item_loc,
                rent_rate = samp.rent_rate,
                broken_chg = samp.broken_chg,
                agr_qty = samp.agr_qty,
                agr_date = samp.agr_date,
                opening_qty = samp.opening_qty,
                rate_on_type = samp.rate_on_type,
                missing_rate = samp.missing_rate,
                notaxrate = samp.notaxrate,
                s_no = samp.s_no,
                rate_of_one_pcs = samp.rate_of_one_pcs,
                weight_of_one_pcs = samp.weight_of_one_pcs,
                created_on = DateTime.Now,
                updated_on = DateTime.Now,
            };

            DB.AggrementMaster.Add(SampData);
            DB.SaveChanges();

            var checkPartyMaster = DB.AggrementMaster.Where(e => e.party_master_id == samp.party_master_id
            && e.delete == 0).ToList();

            if(checkPartyMaster.Count > 0)
            {
                PartyMaster party = DB.PartyMaster.Where(E => E.id == samp.party_master_id).FirstOrDefault();
                party.agreement_yn = "yes";
                DB.SaveChanges();
            }


            var data = new AggrementMasterResp()
            {
                status = true,
                Message = "Inserted successfully",
                AggrementMasterDetailByID =  DB.AggrementMaster.Where(e=> e.id == SampData.id)
                .Include(e=> e.ItemMaster)
                //.Include(e=> e.IssueReceiptTransDetail)
                .FirstOrDefault(),
            };

            return data;
        }


        public AggrementMasterResp UpdateAggrementMaster(AggrementMasterReq samp)
        {
            var existingData = DB.AggrementMaster.Find(samp.id);

            if (existingData != null)
            {
                existingData.pname = samp.pname;
                existingData.pcode = samp.pcode;
                existingData.party_master_id = samp.party_master_id;
                existingData.pname_short_code = samp.pname_short_code;
                existingData.agr_code_old = samp.agr_code_old;
                existingData.agr_no_old = samp.agr_no_old;
                existingData.item_status_agr = samp.item_status_agr;
                existingData.item_code = samp.item_code;
                existingData.item_short_name = samp.item_short_name;
                existingData.item_name = samp.item_name;
                existingData.item_group_code = samp.item_group_code;
                existingData.item_group_name = samp.item_group_name;
                existingData.mix_item_yes_no = samp.mix_item_yes_no;
                existingData.item_loc = samp.item_loc;
                existingData.rent_rate = samp.rent_rate;
                existingData.broken_chg = samp.broken_chg;
                existingData.agr_qty = samp.agr_qty;
                existingData.agr_date = samp.agr_date;
                existingData.opening_qty = samp.opening_qty;
                existingData.rate_on_type = samp.rate_on_type;
                existingData.missing_rate = samp.missing_rate;
                existingData.notaxrate = samp.notaxrate;
                existingData.s_no = samp.s_no;
                existingData.rate_of_one_pcs = samp.rate_of_one_pcs;
                existingData.weight_of_one_pcs = samp.weight_of_one_pcs;
                existingData.updated_on = DateTime.Now;

            }
            DB.SaveChanges();
            var data = new AggrementMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };

            return data;


        }



        public AggrementMasterResp GetAggrementMaster()
        {
            AggrementMasterResp data = new AggrementMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                AggrementMasterDetailData = DB.AggrementMaster.Where(e => e.delete == 0).ToList()
            };
            return data;
        }


        public AggrementMasterResp CheckAggrementMasterItem(long? partyMasterId, long? itemCode)
        {
            AggrementMasterResp data = new AggrementMasterResp()
            {
                status = false,
                Message = "Item Already extis in a Agreement",
                AggrementMasterDetailByID = DB.AggrementMaster.Where(e => e.party_master_id == partyMasterId
                && e.delete == 0 && e.item_code == itemCode ).FirstOrDefault(),
            };
            return data;
        }


        public AggrementMasterResp GetAggrementMasterById(long partyMasterId)
        {
            AggrementMasterResp data = new AggrementMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                AggrementMasterDetailData = DB.AggrementMaster.Where(e => e.party_master_id == partyMasterId
                && e.delete == 0).ToList(),
            };
            return data;
        }

        public AggrementMasterResp DeleteAggrementMaster(long aggrementId)
        {
            AggrementMaster del = DB.AggrementMaster.
                Where(x => x.id == aggrementId).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete = 1;
            DB.SaveChanges();


            var checkPartyMaster = DB.AggrementMaster.Where(e => e.party_master_id == del.party_master_id
            && e.delete == 0).ToList();

            if (checkPartyMaster.Count == 0)
            {
                PartyMaster party = DB.PartyMaster.Where(E => E.id == del.party_master_id).FirstOrDefault();
                party.agreement_yn = "no";
                DB.SaveChanges();

            }


            AggrementMasterResp data = new AggrementMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }




    }
}