using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Reflection.Emit;

namespace RTA.Masters
{
    public class ActivityNameMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public ActivityNameMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }

        public ActivityNameMasterResp InsertActivityNameMaster(ActivityNameMasterReq samp)
        {

            ActivityNameMaster categoryObj = new ActivityNameMaster()
            {
               activity_name = samp.activity_name,
               activity_flag = samp.activity_flag
            };

            DB.ActivityNameMaster.Add(categoryObj);
            DB.SaveChanges();


            ActivityNameMasterResp data = new ActivityNameMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }



        public ActivityNameMasterResp ActivityNameExistsInDatabase(ActivityNameMasterReq samp)
        {
            ActivityNameMasterResp data = new ActivityNameMasterResp()
            {
                status = false,
                Message = $"Activity name '{samp.activity_name.Trim()}' already exists.",
                ActivityNameMasterByID = DB.ActivityNameMaster.Where(e => e.activity_name == samp.activity_name.Trim() && e.delete == 0 
                 && e.activity_flag == samp.activity_flag).FirstOrDefault()
            };
            return data;
        }


        public ActivityNameMasterResp GetAllActivityNameMaster(int pageNo, int limit, string searchKey = null ,
            string active_flag = null )
        {

            IQueryable<ActivityNameMaster> query = DB.ActivityNameMaster.Where(e => e.delete == 0 && 
             e.activity_flag == active_flag);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => EF.Functions.Like(e.activity_name, $"%{searchKey}%"));
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

            ActivityNameMasterResp data = new ActivityNameMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ActivityNameMasterData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public ActivityNameMasterResp GetActivityNameMasterById(long activityId)
        {

            ActivityNameMasterResp data = new ActivityNameMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ActivityNameMasterByID = DB.ActivityNameMaster.FirstOrDefault(e => e.id == activityId && e.delete == 0)
            };


            return data;
        }

        public ActivityNameMasterResp UpdateActivityNameMaster(long activityId, ActivityNameMasterReq samp)
        {
            var existing = DB.ActivityNameMaster.Find(activityId);

            if (existing == null)
            {

                ActivityNameMasterResp data1 = new ActivityNameMasterResp()
                {
                    status = false,
                    Message = "Activity not found"
                };

                return data1;
            }

            if (existing != null)
            {
                if (existing.activity_name != samp.activity_name)
                {
                    ActivityNameMaster checkItemActivityName = DB.ActivityNameMaster.Where(e => e.activity_name == samp.activity_name.Trim()).FirstOrDefault();
                    if (checkItemActivityName != null)
                    {
                        ActivityNameMasterResp data1 = new ActivityNameMasterResp()
                        {
                            status = true,
                            Message = $"Category name '{samp.activity_name.Trim()}' already exists.",


                        };
                        return data1;

                    }

                }

            }


            existing.activity_name = samp.activity_name;
            existing.activity_flag = samp.activity_flag;

            DB.SaveChanges();

            ActivityNameMasterResp data = new ActivityNameMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public ActivityNameMasterResp DeleteActivityNameMaster(long activityId)
        {

            ActivityNameMaster del = DB.ActivityNameMaster
                                            .SingleOrDefault(parent => parent.id == activityId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete = 1;
            DB.SaveChanges();

            ActivityNameMasterResp data = new ActivityNameMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;


        }
    }

}