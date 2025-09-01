using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SystemFilterMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public SystemFilterMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public SystemFilterMasterResp GetSystemFilterMaster(string? searchKey)
        {
            var filterData = DB.SystemFilterMaster.Where(e => e.filter_status == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                    filterData = filterData.Include(E => E.SystemFilterTranxMaster).
                    Where(e => e.filter_name == searchKey);
            }

            var data = new SystemFilterMasterResp()
            {
                status = true,
                Message = "Data fetched successfully",
                SystemFilterMasterData = filterData.Include(E=>E.SystemFilterTranxMaster).ToList()
            };
            return data;
        }


        public SystemFilterMasterResp GetSystemFilterMasterById(long filterId)
        {
            SystemFilterMasterResp data = new SystemFilterMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SystemFilterMasterDataByID = DB.SystemFilterMaster.Where(e => e.filter_status == 0 && e.id == filterId)
                .Include(e=> e.SystemFilterTranxMaster).FirstOrDefault()
            };
            return data;
        }

        public SystemFilterMasterResp InsertSystemFilterMaster(SystemFilterMasterReq samp)
        {


            var existingFilterName = DB.SystemFilterMaster.FirstOrDefault(e =>
            e.filter_name.ToLower() == samp.filter_name.ToLower() && e.filter_status == 0);

            if (existingFilterName != null)
            {
                SystemFilterMasterResp data1 = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = "Filter name already exists"
                };
                return data1;
            }

            SystemFilterMaster SampData = new SystemFilterMaster()
            {
                filter_name = samp.filter_name.ToLower(),
            };

            DB.SystemFilterMaster.Add(SampData);
            DB.SaveChanges();


            foreach (var keyName in samp.FilterArrayData)
            {
                SystemFilterTranxMaster SampData1 = new SystemFilterTranxMaster()
                {
                    system_master_id = SampData.id,
                    filter_data = keyName.filter_data.ToLower(),
                };

                DB.SystemFilterTranxMaster.Add(SampData1);
               
            }
            DB.SaveChanges();


            SystemFilterMasterResp data = new SystemFilterMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public SystemFilterMasterResp UpdateSystemFilterMaster(long filterId, SystemFilterMasterReq samp)
        {
            var existingCategory = DB.SystemFilterMaster.Find(filterId);

            if (existingCategory == null)
            {
                SystemFilterMasterResp data1 = new SystemFilterMasterResp()
                {
                    status = false,
                    Message = "filter not found"
                };

                return data1;
            }

            existingCategory.filter_name = samp.filter_name.ToLower();

            foreach (var keyName in samp.FilterArrayData)
            {
                SystemFilterTranxMaster checkFilterData = DB.SystemFilterTranxMaster.FirstOrDefault(E => E.id == keyName.id);
                if (checkFilterData == null)
                {
                    SystemFilterTranxMaster SampData = new SystemFilterTranxMaster()
                    {
                        system_master_id = existingCategory.id,
                        filter_data = keyName.filter_data.ToLower(),
                    };

                    DB.SystemFilterTranxMaster.Add(SampData);

                }
            }
            DB.SaveChanges();


            foreach (var delete in samp.DeleteFilterArrayData)
            {
                SystemFilterTranxMaster del = DB.SystemFilterTranxMaster.Where(e => e.id == delete.id).FirstOrDefault();
                DB.SystemFilterTranxMaster.Remove(del);
                DB.SaveChanges();
            }


            SystemFilterMasterResp data = new SystemFilterMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }

        public SystemFilterMasterResp DeleteSystemFilterMaster(long filterId)
        {

            SystemFilterMaster del = DB.SystemFilterMaster.SingleOrDefault(parent => parent.id == filterId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.filter_status = 1;
            DB.SaveChanges();

            SystemFilterMasterResp data = new SystemFilterMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }

    }
}