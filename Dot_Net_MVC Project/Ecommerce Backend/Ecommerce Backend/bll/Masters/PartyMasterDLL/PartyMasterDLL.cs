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
            IQueryable<PartyMaster> query = DB.PartyMaster;

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                EF.Functions.Like(e.name, $"%{searchKey}%")||
                EF.Functions.Like(e.email, $"%{searchKey}%") ||
                EF.Functions.Like(e.address, $"%{searchKey}%") ||
                EF.Functions.Like(e.mobile_number.ToString(), $"%{searchKey}%")
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
                PartyMasterDetailByID = DB.PartyMaster
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
                 party_type = samp.party_type
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

        public PartyMasterResp UpdatePartyMaster(long partyId, PartyMasterReq samp)
        {

            PartyMaster SampData = new PartyMaster()
            {
                id = partyId,
                name = samp.name,
                address = samp.address,
                mobile_number = samp.mobile_number,
                email = samp.email,
                pincode = samp.pincode,
                party_type = samp.party_type
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

        public PartyMasterResp DeletePartyMaster(long partyId)
        {
            PartyMaster del = DB.PartyMaster.Where(x => x.id == partyId).SingleOrDefault(); 

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