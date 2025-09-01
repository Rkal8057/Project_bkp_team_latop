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
    public class ActivityMasterBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public ActivityMasterBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }


        public ActivityMasterResp InsertActivityMaster(ActivityMasterReq samp)
        {

            ActivityMaster categoryObj = new ActivityMaster()
            {
                activity_name = samp.activity_name,
                activity_name_id = samp.activity_name_id,
                user_id = samp.user_id,
                activity_date = samp.activity_date,
                activity_time = samp.activity_time,
                activity_note = samp.activity_note,
                activity_duration = samp.activity_duration,
                activity_end_time = samp.activity_end_time,
                activity_start_time = samp.activity_start_time,
                activity_maintain_type = samp.activity_maintain_type,
            };

            DB.ActivityMaster.Add(categoryObj);
            DB.SaveChanges();

            foreach( var activityTrans in samp.ActivityMasterTransReq)
            {
                ActivityTranxMaster SampData = new ActivityTranxMaster()
                {
                    slot_start = activityTrans.slot_start,
                    slot_end = activityTrans.slot_end,
                    activity_detail = activityTrans.activity_detail,
                    activity_detail_id = activityTrans.activity_detail_id,
                    duration = activityTrans.duration,
                    remark = activityTrans.remark,
                    activity_master_id = categoryObj.id,
                    activity_default_remark= activityTrans.activity_default_remark
                };

                DB.ActivityTranxMaster.Add(SampData);
                DB.SaveChanges();
            }

            ActivityMasterResp data = new ActivityMasterResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }



        //public ActivityMasterResp ActivityNameExistsInDatabase(ActivityMasterReq samp)
        //{
        //    ActivityMasterResp data = new ActivityMasterResp()
        //    {
        //        status = false,
        //        Message = $"Activity name '{samp.activity_name.Trim()}' already exists.",
        //        ActivityMasterByID = DB.ActivityMaster.Where(e => e.activity_name == samp.activity_name.Trim() && e.delete == 0).FirstOrDefault()
        //    };
        //    return data;
        //}



        public ActivityMasterResp GetAllActivityMaster(int pageNo, int limit, string searchKey = null)
        {

            IQueryable<ActivityMaster> query = DB.ActivityMaster.Where(e => e.delete == 0);

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

            ActivityMasterResp data = new ActivityMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ActivityMasterData = pagedQuery,
                TotalCount = totalCount,
                TotalPages = totalPages,
                CurrentPage = pageNo,
                PageSize = limit,

            };
            return data;
        }

        public ActivityMasterResp GetActivityMasterById(long activityId)
        {
            ActivityMasterResp data = new ActivityMasterResp()
            {
                status = true,
                Message = "data fetched successfully",
                ActivityMasterByID = DB.ActivityMaster
                .Include( e=> e.ActivityTranxMaster)
                .FirstOrDefault(e => e.id == activityId && e.delete == 0)
            };
            return data;
        }

        public ActivityMasterResp UpdateActivityMaster(long activityId, ActivityMasterReq samp)
        {
            var existing = DB.ActivityMaster.Find(activityId);

            if (existing == null)
            {

                ActivityMasterResp data1 = new ActivityMasterResp()
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
                    ActivityMaster checkItemActivityName = DB.ActivityMaster.Where(e => e.activity_name == samp.activity_name.Trim()).FirstOrDefault();
                    if (checkItemActivityName != null)
                    {
                        ActivityMasterResp data1 = new ActivityMasterResp()
                        {
                            status = true,
                            Message = $"Category name '{samp.activity_name.Trim()}' already exists.",


                        };
                        return data1;

                    }

                }

            }


            existing.activity_name = samp.activity_name;
            existing.activity_name_id = samp.activity_name_id;
            existing.user_id = samp.user_id;
            existing.activity_date = samp.activity_date;
            existing.activity_time = samp.activity_time;
            existing.activity_note = samp.activity_note;
            existing.activity_duration = samp.activity_duration;


            foreach (var activityTrans in samp.ActivityMasterTransReq)
            {
                ActivityTranxMaster checkTrans = DB.ActivityTranxMaster.Where
                    (E => E.id == activityTrans.id).FirstOrDefault();

                checkTrans.activity_detail_id = activityTrans.activity_detail_id;
                checkTrans.slot_start = activityTrans.slot_start;
                checkTrans.slot_end = activityTrans.slot_end;
                checkTrans.activity_detail = activityTrans.activity_detail;
                checkTrans.duration = activityTrans.duration;
                checkTrans.remark = activityTrans.remark;
                checkTrans.activity_default_remark = activityTrans.activity_default_remark;

                DB.SaveChanges();
            }

            DB.SaveChanges();

            ActivityMasterResp data = new ActivityMasterResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;

        }


        public ActivityMasterResp DeleteActivityMaster(long activityId)
        {

            ActivityMaster del = DB.ActivityMaster
                                            .SingleOrDefault(parent => parent.id == activityId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.delete = 1;
            DB.SaveChanges();

            ActivityMasterResp data = new ActivityMasterResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;


        }

    }
}