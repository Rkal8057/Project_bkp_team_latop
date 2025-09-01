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
    public class CompanyDetailBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public CompanyDetailBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public CompanyDetailResp GetAllCompanyDetail()
        {
            CompanyDetailResp data = new CompanyDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                CompanyDetailData = DB.CompanyDetail.Include(e => e.HelperDetail).ToList()
            };
            return data;
        }

        public CompanyDetailResp GetCompanyDetailById(long id)
        {

            CompanyDetailResp data = new CompanyDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                CompanyDetailByID = DB.CompanyDetail.Include(e => e.HelperDetail).Where(e => e.id == id).SingleOrDefault()
            };

            return data;
        }

        public CompanyDetailResp InsertCompanyDetail(CompanyDetailReq samp)
        {
            CompanyDetail SampData = new CompanyDetail()
            {
                company_name = samp.company_name,
                company_address = samp.company_address,
                company_city = samp.company_city,
                company_pincode = samp.company_pincode,
                company_country = samp.company_country,
                company_email = samp.company_email,
                company_phone = samp.company_phone
            };


            DB.CompanyDetail.Add(SampData);
            DB.SaveChanges();

            foreach (HelperDetail helpData in samp.HelperDetail)
            {
                HelperDetail SampData1 = new HelperDetail()
                {
                    company_id = SampData.id,
                    image_url = helpData.image_url,
                };

                DB.HelperDetail.Add(SampData1);
                DB.SaveChanges();
            }

            CompanyDetailResp data = new CompanyDetailResp()
            {
                status = true,
                Message = "Inserted successfully"
            };
            return data;

        }

        public CompanyDetailResp UpdateCompanyDetail(long ID, CompanyDetailReq samp)
        {
            CompanyDetail existingEntity = DB.CompanyDetail.Include(e => e.HelperDetail)
            .FirstOrDefault(e => e.id == ID);

            if (existingEntity != null)
            {
                existingEntity.company_name = samp.company_name;
                existingEntity.company_address = samp.company_address;
                existingEntity.company_city = samp.company_city;
                existingEntity.company_pincode = samp.company_pincode;
                existingEntity.company_country = samp.company_country;
                existingEntity.company_email = samp.company_email;
                existingEntity.company_phone = samp.company_phone;
            }
            if (existingEntity.HelperDetail != null)
            {

                foreach (var updatedUploadlist in samp.HelperDetail)
                {
                    var existingemilist = existingEntity.HelperDetail.FirstOrDefault(cl => cl.company_id == updatedUploadlist.Id);

                    if (existingemilist != null)
                    {
                        existingemilist.image_url = updatedUploadlist.image_url;
                    }
                    else
                    {
                       /* HelperDetail SampData = new HelperDetail
                        {
                            company_id = existingEntity.id,
                            image_url = updatedUploadlist.image_url,
                        };
                        existingEntity.HelperDetail.Add(SampData);*/
                    }
                }
            }

            DB.SaveChanges();
            CompanyDetailResp data = new CompanyDetailResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }

        public CompanyDetailResp DeleteCompanyDetail(long ID)
        {
            CompanyDetail del = DB.CompanyDetail.Include(e => e.HelperDetail)
                     .Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }


            DB.HelperDetail.RemoveRange(del.HelperDetail);
            DB.CompanyDetail.Remove(del);
            DB.SaveChanges();
            CompanyDetailResp data = new CompanyDetailResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }



        public CompanyDetailResp getLastCompanyDetail()
        {

            long MaxId = DB.CompanyDetail.Max(u => u.id);
            CompanyDetail lastCompany = DB.CompanyDetail
                .Include(e => e.HelperDetail).Where(e => e.id == MaxId).SingleOrDefault();
              //  FirstOrDefault(u => u.id == MaxId);


            CompanyDetailResp data = new CompanyDetailResp()
            {
                status = true,
                Message = "data fetched successfully",
                CompanyDetailByID = lastCompany
            };
            return data;
        }


    }
}