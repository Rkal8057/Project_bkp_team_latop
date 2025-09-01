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
    public class Location_MasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public Location_MasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public LocationMasterResp InsertLocationMaster(LocationMasterReq samp)
        {

            var SampData = new Location_Master()
            {
                location_name = samp.location_name,
                created_on = DateTime.Now,
                updated_on = DateTime.Now,
            };

            DB.Location_Master.Add(SampData);
            DB.SaveChanges();

            var data = new LocationMasterResp()
            {
                status = true,
                Message = "Inserted successfully",
            };

            return data;
        }


        public LocationMasterResp UpdateLocationMaster(LocationMasterReq samp)
        {
            var existingData = DB.Location_Master.Find(samp.id);

            if (existingData != null)
            {
                existingData.location_name = samp.location_name;
                existingData.updated_on = DateTime.Now;
            }
            DB.SaveChanges();
            var data = new LocationMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };

            return data;
        }



        public LocationMasterResp GetLocationMaster()
        {
            LocationMasterResp data = new LocationMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                LocationMasterDetailData = DB.Location_Master.Where(e => e.delete == 0).ToList()
            };
            return data;
        }


        public LocationMasterResp CheckLocationMasterNameExits(string? location_name)
        {
            LocationMasterResp data = new LocationMasterResp()
            {
                status = false,
                Message = "Item Already extis in a Agreement",
                LocationMasterDetailByID = DB.Location_Master.Where(e => e.location_name == location_name)
                .FirstOrDefault(),
            };
            return data;
        }


        public LocationMasterResp DeleteLocationMaster(long locationId)
        {
            Location_Master del = DB.Location_Master.
                Where(x => x.id == locationId).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }



            del.delete = 1;
            DB.SaveChanges();
            LocationMasterResp data = new LocationMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }




    }

}