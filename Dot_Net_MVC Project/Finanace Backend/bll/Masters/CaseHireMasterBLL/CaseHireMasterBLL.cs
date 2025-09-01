using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RTA.Masters
{
    public class CaseHireMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public CaseHireMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public CaseHireMasterResp GetAllCaseHireMaster()
        {
            CaseHireMasterResp data = new CaseHireMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CaseHireMasterData = DB.CaseHireMaster.ToList()
            };
            return data;
        }

        public CaseHireMasterResp GetCaseHireMasterById(long id)
        {

            CaseHireMasterResp data = new CaseHireMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                CaseHireMasterByID = DB.CaseHireMaster.Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public CaseHireMasterResp InsertCaseHireMaster(CaseHireMasterReq samp)
        {
            CaseHireMaster SampData = new CaseHireMaster()
            {
                Hire_Name = samp.Hire_Name,
                Hire_SWH_Name = samp.Hire_SWH_Name,
                Hire_Resi_Address = samp.Hire_Resi_Address,
                Hire_Ph_No = samp.Hire_Ph_No,
                Hire_Company_Name = samp.Hire_Company_Name,
                Hire_Off_Ph_Nos = samp.Hire_Off_Ph_Nos,
                Hire_Off_Address = samp.Hire_Off_Address,
                Hire_Ph_No2 = samp.Hire_Ph_No2,
                Hire_Post = samp.Hire_Post,
                Hire_Profession = samp.Hire_Profession,
                Hire_Area = samp.Hire_Area,
                Hire_Location = samp.Hire_Location
            };


            DB.CaseHireMaster.Add(SampData);
            DB.SaveChanges();
            CaseHireMasterResp data = new CaseHireMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public CaseHireMasterResp UpdateCaseHireMaster(long ID, CaseHireMasterReq samp)
        {
            CaseHireMaster existingEntity = DB.CaseHireMaster.FirstOrDefault(e => e.id == ID);

            if (existingEntity != null)
            {
                existingEntity.Hire_Name = samp.Hire_Name;
                existingEntity.Hire_SWH_Name = samp.Hire_SWH_Name;
                existingEntity.Hire_Resi_Address = samp.Hire_Resi_Address;
                existingEntity.Hire_Ph_No = samp.Hire_Ph_No;
                existingEntity.Hire_Company_Name = samp.Hire_Company_Name;
                existingEntity.Hire_Off_Ph_Nos = samp.Hire_Off_Ph_Nos;
                existingEntity.Hire_Off_Address = samp.Hire_Off_Address;
                existingEntity.Hire_Ph_No2 = samp.Hire_Ph_No2;
                existingEntity.Hire_Post = samp.Hire_Post;
                existingEntity.Hire_Profession = samp.Hire_Profession;
                existingEntity.Hire_Area = samp.Hire_Area;
                existingEntity.Hire_Location = samp.Hire_Location;
            }
               DB.SaveChanges();
            CaseHireMasterResp data = new CaseHireMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public CaseHireMasterResp DeleteCaseHireMaster(long ID)
        {
            CaseHireMaster del = DB.CaseHireMaster.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.CaseHireMaster.Remove(del);
            DB.SaveChanges();
            CaseHireMasterResp data = new CaseHireMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

    }
}
