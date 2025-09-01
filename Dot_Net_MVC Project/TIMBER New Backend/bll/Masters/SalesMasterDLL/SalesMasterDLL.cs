using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class SalesMasterDLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public SalesMasterDLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public SalesMasterResp GetSalesMaster(int pageNo, int limit, string searchKey)
        {
            IQueryable<SalesMaster> query = DB.SalesMaster.Include(e=>e.SalesTrxMaster);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e =>
                EF.Functions.Like(e.name, $"%{searchKey}%") ||
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
            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SalesMasterDetailData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
          
            return data;
        }

        public SalesMasterResp GetSalesMasterByID(int id)
        {

            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                SalesMasterDetailByID = DB.SalesMaster
                .Include(e => e.SalesTrxMaster) // Include the SalesTrxMaster navigation property
                .SingleOrDefault(e => e.id == id) // Filter by the specified ID
            };

            return data;
        }

        public SalesMasterResp InsertSalesMaster(SalesMasterReq samp)
        {
            SalesMaster SampData = new SalesMaster()
            {
                sales_date = samp.sales_date,
                name = samp.name,
                email = samp.email,
                address = samp.address, 
                mobile_number = samp.mobile_number,
                completion_flag = samp.completion_flag,
                grand_total = samp.grand_total,
            };

            DB.SalesMaster.Add(SampData);
            DB.SaveChanges();

            SalesMaster lastData = DB.SalesMaster.Where(x => x.id == SampData.id).SingleOrDefault();

            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "inserted successfully",
                SalesMasterDetailByID = lastData
            };
            return data;
        }


        public SalesMasterResp UpdateSalesMaster(int saleId, SalesMasterReq samp)
        {

            SalesMaster existingRecord = DB.SalesMaster.FirstOrDefault(s => s.id == saleId);
            if (existingRecord != null)
            {
                existingRecord.sales_date = samp.sales_date;
                existingRecord.name = samp.name;
                existingRecord.email = samp.email;
                existingRecord.address = samp.address;
                existingRecord.mobile_number = samp.mobile_number;

                DB.SalesMaster.Update(existingRecord);
                DB.SaveChanges();
            }

            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "UPDATED successfully"
            };
            return data;
        }

        public SalesMasterResp DeleteSalesMaster(int ID)
        {
            SalesMaster del = DB.SalesMaster.Where(x => x.id == ID).SingleOrDefault();

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.SalesMaster.Remove(del);
            DB.SaveChanges();
            SalesMasterResp data = new SalesMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;
        }

    }
}