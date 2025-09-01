using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Drawing;

namespace RTA.Masters
{
    public class PortfolioMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public PortfolioMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public PortfolioMasterResp InsertPortfolioMaster(PortfolioMasterReq samp)
        {

            PortfolioMaster categoryObj = new PortfolioMaster()
            {
                portfolio_image = samp.portfolio_image,
                position = samp.position,
            };

            DB.PortfolioMaster.Add(categoryObj);
            DB.SaveChanges();


            PortfolioMasterResp data = new PortfolioMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }



     

        public PortfolioMasterResp GetAllPortfolioMaster(int pageNo, int limit, string searchKey)
        {

            IQueryable<PortfolioMaster> query = DB.PortfolioMaster;

            if (!string.IsNullOrEmpty(searchKey))
            {
               // query = query.Where(e => EF.Functions.Like(e.category_name, $"%{searchKey}%"));
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

            var pagedQuery = query.Skip(skip).Take(limit).OrderBy(e=> e.position).ToList();

            PortfolioMasterResp data = new PortfolioMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PortfolioMasterDetailData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public PortfolioMasterResp GetPortfolioMasterById(long portfolioId)
        {

            PortfolioMasterResp data = new PortfolioMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                PortfolioMasterDetailByID = DB.PortfolioMaster.FirstOrDefault(e => e.id == portfolioId)
            };


            return data;
        }

        public PortfolioMasterResp UpdatePortfolioMaster(long portfolioId, PortfolioMasterReq samp)
        {
            var existing = DB.PortfolioMaster.Find(portfolioId);

            if (existing == null)
            {

                PortfolioMasterResp data1 = new PortfolioMasterResp()
                {
                    status = false,
                    Message = "Category not found"
                };

                return data1;
            }

            existing.portfolio_image = samp.portfolio_image;
            existing.position = samp.position;
         
            DB.SaveChanges();

            PortfolioMasterResp data = new PortfolioMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public PortfolioMasterResp DeletePortfolioMaster(long portfolioId)
        {

            PortfolioMaster del = DB.PortfolioMaster
                                            .SingleOrDefault(parent => parent.id == portfolioId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            DB.PortfolioMaster.Remove(del);
            DB.SaveChanges();

            PortfolioMasterResp data = new PortfolioMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;




        }

    }
}