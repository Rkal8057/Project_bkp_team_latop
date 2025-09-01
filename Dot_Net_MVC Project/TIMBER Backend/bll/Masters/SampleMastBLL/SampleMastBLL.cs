/*using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SampleMastBLL
    {


        private loginDBContext DB;
        private string DBConnStr;
        public SampleMastBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public ModelSampleResp GetSampleData()
        {
            ModelSampleResp data = new ModelSampleResp()
            {
                status = true,
                Message = "data fetched successfully",
                SampleData = DB.Sample_Detail.ToList()
            };
            return data;
        }

        public ModelSampleResp GetSampleDataByID(int id)
        {

            ModelSampleResp data = new ModelSampleResp()
            {
                status = true,
                Message = "data fetched successfully",
                SampleDataByID = DB.Sample_Detail.Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public ModelSampleResp InsertSample(ModelSampleReq samp)
        {
            Sample_Detail SampData = new Sample_Detail()
            {
                profession = samp.profession,
                name = samp.name,
                phone = samp.phone,
                email = samp.email,
                institute = samp.institute,
                isActive = samp.isActive
            };

            DB.Sample_Detail.Add(SampData);
            DB.SaveChanges();
            ModelSampleResp data = new ModelSampleResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public ModelSampleResp UpdateSample(int ID, ModelSampleReq samp)
        {

            Sample_Detail SampData = new Sample_Detail()
            {
                id = ID,
                profession = samp.profession,
                name = samp.name,
                phone = samp.phone,
                email = samp.email,
                institute = samp.institute,
                isActive = samp.isActive
            };

            DB.Sample_Detail.Update(SampData);
            DB.SaveChanges();
            ModelSampleResp data = new ModelSampleResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public ModelSampleResp DeleteSample(int ID)
        {
            Sample_Detail del = DB.Sample_Detail.Where(x => x.id == ID).SingleOrDefault(); 

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.Sample_Detail.Remove(del);
            DB.SaveChanges();
             ModelSampleResp data = new ModelSampleResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }


    }

}
*/