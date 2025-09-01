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

           
        public PartyMasterResp GetPartyMaster()
        {
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyMasterDetailData = DB.PartyMaster
                .Include(e => e.SalesMaster).ToList()
            };
            return data;
        }

        public PartyMasterResp GetPartyMasterByID(int id)
        {

            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PartyMasterDetailByID = DB.PartyMaster
                .Include(e => e.SalesMaster) 
                .SingleOrDefault(e => e.id == id)
            };

            return data;
        }

        public PartyMasterResp InsertPartyMaster(PartyMasterReq samp)
        {
            PartyMaster SampData = new PartyMaster()
            {
                 name = samp.name,
                 address = samp.address,    
                 mobile_number = samp.mobile_number,    
                 email = samp.email,
                 pincode = samp.pincode,
            };

            DB.PartyMaster.Add(SampData);
            DB.SaveChanges();
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public PartyMasterResp UpdatePartyMaster(int ID, PartyMasterReq samp)
        {

            PartyMaster SampData = new PartyMaster()
            {
                id = ID,
                name = samp.name,
                address = samp.address,
                mobile_number = samp.mobile_number,
                email = samp.email,
                pincode = samp.pincode,
            };

            DB.PartyMaster.Update(SampData);
            DB.SaveChanges();
            PartyMasterResp data = new PartyMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public PartyMasterResp DeletePartyMaster(int ID)
        {
            PartyMaster del = DB.PartyMaster.Where(x => x.id == ID).SingleOrDefault(); 

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
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