using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{

    public class HelperMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public HelperMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public HelperMasterResp GetHelperMaster(string fromName)
        {

            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                HelperMasterData = DB.HelperMaster.Where(e => e.form_name == fromName).ToList()
            };
            return data;
        }

        public HelperMasterResp GetAllHelperMaster()
        {

            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                HelperMasterData = DB.HelperMaster.ToList()
            };
            return data;
        }



        public HelperMasterResp GetHelperMasterById(long helperId)
        {

            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                HelperMasterByID = DB.HelperMaster.Where(e => e.id == helperId).FirstOrDefault()
            };
            return data;
        }

        public HelperMasterResp InsertHelperMaster(HelperMasterReq samp)
        {
            HelperMaster SampData = new HelperMaster()
            {
                form_name = samp.form_name,
                field_name = samp.field_name,
                field_data = samp.field_data,
                deleted = samp.deleted,
                created_on = samp.created_on,
                updated_on = samp.updated_on
            };

            DB.HelperMaster.Add(SampData);
            DB.SaveChanges();

            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public HelperMasterResp UpdateHelperMaster(long helperId, HelperMasterReq samp)
        {

            var existingData = DB.HelperMaster.Where(e => e.id == helperId).FirstOrDefault();

            if (existingData == null)
            {

                HelperMasterResp data1 = new HelperMasterResp()
                {
                    status = false,
                    Message = "helper data not found"
                };

                return data1;
            }

            existingData.form_name = samp.form_name;
            existingData.field_name = samp.field_name;
            existingData.field_data = samp.field_data;
            existingData.deleted = samp.deleted;
            existingData.updated_on = DateTime.Now;
         
            DB.SaveChanges();

            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "update successfully"
            };
            return data;
        }

        public HelperMasterResp DeleteHelperMaster(long helperId)
        {
            var del = DB.HelperMaster.Where(e => e.id == helperId).FirstOrDefault();

            if (del == null)
            {

                HelperMasterResp data1 = new HelperMasterResp()
                {
                    status = false,
                    Message = "helper data not found"
                };

                return data1;
            }

            DB.Remove(del);
            DB.SaveChanges();
            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "delete successfully"
            };
            return data;
        }


        /// =============================== State Master ========================================== ///

        public HelperMasterResp GetStateMaster()
        {

            HelperMasterResp data = new HelperMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                State_Master = DB.State_Master.ToList()
            };
            return data;
        }

    }
}