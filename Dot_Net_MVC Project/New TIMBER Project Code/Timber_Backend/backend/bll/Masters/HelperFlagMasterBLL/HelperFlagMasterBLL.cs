using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;

namespace RTA.Masters
{
    public class HelperFlagMasterBLL
    {
        private loginDBContext DB;
        private string DBConnStr;
        public HelperFlagMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public HelperFlagMasterResp InsertHelperFlagMaster(HelperFlagMasterReq samp)
        {

            HelperFlagMaster HelperFlagObj = new HelperFlagMaster()
            {
                helper_flag_name = samp.helper_flag_name,
            };

            DB.HelperFlagMaster.Add(HelperFlagObj);
            DB.SaveChanges();


            HelperFlagMasterResp data = new HelperFlagMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }



        public HelperFlagMasterResp HelperFlagNameExistsInDatabase(HelperFlagMasterReq samp)
        {
            HelperFlagMasterResp data = new HelperFlagMasterResp()
            {
                status = true,
                Message = "Helper Flag name already exists in the database.",
                HelperFlagMasterByID = DB.HelperFlagMaster.Where(e => e.helper_flag_name == samp.helper_flag_name).FirstOrDefault()
            };
            return data;
        }


        public HelperFlagMasterResp GetAllHelperFlagMaster(int pageNo, int limit, string searchKey)
        {

            IQueryable<HelperFlagMaster> query = DB.HelperFlagMaster.Where( e=> e.delete_at == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => EF.Functions.Like(e.helper_flag_name, $"%{searchKey}%"));
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

            HelperFlagMasterResp data = new HelperFlagMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                HelperFlagMasterData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public HelperFlagMasterResp GetHelperFlagMasterById(long helperFlagId)
        {

            HelperFlagMasterResp data = new HelperFlagMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                HelperFlagMasterByID = DB.HelperFlagMaster.FirstOrDefault(e => e.id == helperFlagId)
            };


            return data;
        }

        public HelperFlagMasterResp UpdateHelperFlagMaster(long helperFlagId, HelperFlagMasterReq samp)
        {
            var existingHelperFlag = DB.HelperFlagMaster.Find(helperFlagId);

            if (existingHelperFlag == null)
            {

                HelperFlagMasterResp data1 = new HelperFlagMasterResp()
                {
                    status = false,
                    Message = "HelperFlag not found"
                };

                return data1;
            }

            existingHelperFlag.helper_flag_name  = samp.helper_flag_name;

            DB.SaveChanges();

            HelperFlagMasterResp data = new HelperFlagMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public HelperFlagMasterResp DeleteHelperFlagMaster(long HelperFlagId)
        {

            HelperFlagMaster del = DB.HelperFlagMaster
                                            .SingleOrDefault(parent => parent.id == HelperFlagId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete_at = 1;
            DB.SaveChanges();

            HelperFlagMasterResp data = new HelperFlagMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;




        }

    }
}