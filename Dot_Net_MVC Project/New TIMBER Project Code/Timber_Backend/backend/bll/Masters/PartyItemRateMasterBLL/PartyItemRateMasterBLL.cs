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
    public class PartyItemRateMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public PartyItemRateMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public PartyItemRateMasterResp InsertPartyItemRateMaster(PartyItemRateMasterReq samp)
        {

            PartyItemRateTrans SampData = new PartyItemRateTrans()
            {
                pname = samp.pname,
                pcode = samp.pcode,
                party_master_id = samp.party_master_id,
                item_short_name = samp.item_short_name,
                item_name = samp.item_name,
                agr_date = samp.agr_date != default ? samp.agr_date : DateTime.Now,
                price_sell_rate = samp.price_sell_rate,
                price_sell_discount_percentage = samp.price_sell_discount_percentage,
                price_sell_discount_amount = samp.price_sell_discount_amount,
                price_sell_amount_after_discount = samp.price_sell_amount_after_discount,
                price_sell_gst_percentage = samp.price_sell_gst_percentage,
                price_sell_gst_amount = samp.price_sell_gst_amount,
                price_sell_amount_with_gst = samp.price_sell_amount_with_gst,
                item_code   = samp.item_code,

            };

            DB.PartyItemRateTrans.Add(SampData);
            DB.SaveChanges();

            var data = new PartyItemRateMasterResp()
            {
                status = true,
                Message = "Inserted successfully",
            };

            return data;
        }


        public PartyItemRateMasterResp UpdatePartyItemRateMaster(PartyItemRateMasterReq samp)
        {
            var existingData = DB.PartyItemRateTrans.Find(samp.id);

            if (existingData != null)
            {
                existingData.pname = samp.pname;
                existingData.pcode = samp.pcode;
                existingData.party_master_id = samp.party_master_id;
                existingData.item_short_name = samp.item_short_name;
                existingData.item_name = samp.item_name;
                existingData.agr_date = samp.agr_date != default ? samp.agr_date : existingData.agr_date;
                existingData.price_sell_rate = samp.price_sell_rate;
                existingData.price_sell_discount_percentage = samp.price_sell_discount_percentage;
                existingData.price_sell_discount_amount = samp.price_sell_discount_amount;
                existingData.price_sell_amount_after_discount = samp.price_sell_amount_after_discount;
                existingData.price_sell_gst_percentage = samp.price_sell_gst_percentage;
                existingData.price_sell_gst_amount = samp.price_sell_gst_amount;
                existingData.price_sell_amount_with_gst = samp.price_sell_amount_with_gst;

            }
            DB.SaveChanges();
            var data = new PartyItemRateMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };

            return data;


        }



        public PartyItemRateMasterResp GetPartyItemRateMaster()
        {
            PartyItemRateMasterResp data = new PartyItemRateMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyItemRateTransData = DB.PartyItemRateTrans.Where(e => e.delete == 0).ToList()
            };
            return data;
        }


        public PartyItemRateMasterResp CheckPartyItemRateMasterItem(long? partyMasterId, long? itemCode)
        {
            PartyItemRateMasterResp data = new PartyItemRateMasterResp()
            {
                status = false,
                Message = "Item Already extis in a Agreement",
                PartyItemRateTransById = DB.PartyItemRateTrans.Where(e => e.party_master_id == partyMasterId
                && e.delete == 0 && e.item_code == itemCode).FirstOrDefault(),
            };
            return data;
        }


        public PartyItemRateMasterResp GetPartyItemRateMasterById(long partyMasterId)
        {
            PartyItemRateMasterResp data = new PartyItemRateMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyItemRateTransData = DB.PartyItemRateTrans.Where(e => e.party_master_id == partyMasterId
                && e.delete == 0).ToList(),
            };
            return data;
        }

        public PartyItemRateMasterResp DeletePartyItemRateMaster(long aggrementId)
        {
            PartyItemRateTrans del = DB.PartyItemRateTrans.
                Where(x => x.id == aggrementId).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }



            del.delete = 1;
            DB.SaveChanges();
            PartyItemRateMasterResp data = new PartyItemRateMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

    }
}