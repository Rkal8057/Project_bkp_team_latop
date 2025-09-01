using System;
using DB.Login;
using DB.Login.Tables;
//using RTA.Admin.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RTA.Masters.Models;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTA.Masters
{
    public class DailyTasksBLL
    {

        private loginDBContext DB;
        private string DBConnStr;
        public DailyTasksBLL(string _DBConnStr)
        {
            DBConnStr = _DBConnStr;
            DB = loginDBContextFactory.Create(DBConnStr);
        }
        public DailyTaskResp GetDailyTask()
        {
            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "data fetched successfully",
                DailyTaskData = DB.DailyTask.Where(e => e.task_delete == 0).ToList()
            };
            return data;
        }

        public DailyTaskResp GetDailyTask(string? searchKey = null)
        {
            var query = DB.DailyTask
                  .Include(e => e.DailyTaskTans)
                  .Where(e => e.task_delete == 0);

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => e.task_title.Contains(searchKey) ||
                                         e.task_status.Contains(searchKey) ||
                                         e.task_priority.Contains(searchKey) );
            }

            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "Data fetched successfully",
                DailyTaskData = query.ToList()
            };

            return data;
        }

        public DailyTaskResp GetDailyTaskByUserId(long? userId  , string? searchKey = null)
        {
            var query = DB.DailyTask
                .Include( e=> e.DailyTaskTans)
                .Where(e => e.task_delete == 0 && (e.task_assigned_by == userId || e.task_assigned_by == -1));

            if (!string.IsNullOrEmpty(searchKey))
            {
                query = query.Where(e => e.task_title.Contains(searchKey) ||
                                         e.task_status.Contains(searchKey) ||
                                         e.task_priority.Contains(searchKey));
            }

            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "Data fetched successfully",
                DailyTaskData = query.ToList()
            };

            return data;
        }

        public DailyTaskResp GetDailyTaskWithCurrentDateByUserId(long? userId)
        {
            /*var query = DB.DailyTask
                .Include(e => e.DailyTaskTans)
                .Where(e => e.task_delete == 0
                            && (e.task_assigned_by == userId || e.task_assigned_by == -1))*/


            /*var query = DB.DailyTask
        .Include(e => e.DailyTaskTans
            .Where(t => t.task_work_status == "completed" || t.created_date == DateTime.Now))
            .Where(e => e.task_delete == 0
                        && (e.task_assigned_by == userId || e.task_assigned_by == -1));*/

            var today = DateTime.Now.Date; // Start of today
            var currentDayOfWeek = today.DayOfWeek.ToString(); // Get the current day of the week as a string
            var day = today.Day.ToString();

            // Fetch relevant data from the database
            var tasks = DB.DailyTask
                .Include(e => e.DailyTaskTans
                .Where(t => t.task_work_status == "completed" && t.created_date.Value.Date == today  && t.created_by == userId))
                .Where(e => e.task_delete == 0
                            && (e.task_assigned_by == userId || e.task_assigned_by == -1))
                .ToList();

            //var queryData = DB.DailyTask
            //   .Include(e => e.DailyTaskTans
            //.Where(t => t.task_work_status == "completed" || t.created_date == DateTime.Now))
            //.Where(e => e.task_delete == 0
            //            && (e.task_assigned_by == userId || e.task_assigned_by == -1));

            // Filter the tasks in memory
            var filteredTasks = tasks
                .Where(e => e.task_schedule_type == "daily"
                            || (e.task_schedule_type == "weekly" && e.specific_days.Split(',').Contains(currentDayOfWeek))
                            || (e.task_schedule_type == "allweekly" && e.specific_days.Split(',').Contains(currentDayOfWeek))
                            || (e.task_schedule_type == "specific_days"
                                && e.task_single_day == day))
                .ToList();


            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "Data fetched successfully",
                DailyTaskData = filteredTasks
            };

            return data;
        }



        public DailyTaskResp GetDailyTaskByUserId(long dailyTaskId , long userId)
        {
           
            var today = DateTime.Now.Date; // Start of today
            var currentDayOfWeek = today.DayOfWeek.ToString(); // Get the current day of the week as a string
            var day = today.Day.ToString();

            // Fetch relevant data from the database
            var tasks = DB.DailyTask
                .Include(e => e.DailyTaskTans
                .Where(t =>  t.created_date.Value.Date == today && t.created_by == userId))
                .Where(e => e.task_delete == 0 && e.id == dailyTaskId)
                .FirstOrDefault();

            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "Data fetched successfully",
                DailyTaskDataByID = tasks
            };

            return data;
        }


        public DailyTaskResp GetDailyTaskById(long dailyTaskId)
        {

            var daily = DB.DailyTask
                .Join(
                    DB.DailyTaskTans,                               // The other entity to join with
                    dailyTask => dailyTask.id,                      // The primary key in the DailyTask table
                    dailyTaskTans => dailyTaskTans.daily_task_id,   // The foreign key in the DailyTaskTans table
                    (dailyTask, dailyTaskTans) => new               // The result selector
                    {
                        DailyTask = dailyTask,
                        DailyTaskTans = dailyTaskTans
                    }

                )
                .Join(
                    DB.User_Detail,                                           // Join the result with UserDetail
                    combined => combined.DailyTaskTans.user_assigned_id,      // Foreign key in DailyTaskTans
                    userDetail => userDetail.id,                              // Primary key in UserDetail
                    (combined, userDetail) => new                              // Final result selector
                    {
                        DailyTask = combined.DailyTask,
                        DailyTaskTans = combined.DailyTaskTans,
                        UserDetail = userDetail
                    }
                )
              .Where(x => x.DailyTask.id == dailyTaskId)
              .ToList();



            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "data fetched successfully",
                DailyTaskDataByID = DB.DailyTask
                .Include(e => e.DailyTaskTans)
                .Where(e => e.task_delete == 0 && e.id == dailyTaskId).FirstOrDefault()
             
            };
            return data;
        }

        public DailyTaskResp InsertDailyTask(DailyTaskReq samp)
        {
            DailyTask SampData = new DailyTask()
            {
                user_id = samp.user_id,
                task_title = samp.task_title,
                task_description = samp.task_description,
                task_priority = samp.task_priority, // e.g., "low", "medium", "high"
                task_status = samp.task_status, // e.g., "active", "    InActive"
                start_date = samp.start_date,
                end_date = samp.end_date,
                task_assigned_by = samp.task_assigned_by, // e.g., "single", "all"
                type_mode = samp.type_mode,
                task_schedule_type = samp.task_schedule_type,
                specific_days= samp.specific_days,
                task_single_day = samp.task_single_day,
                task_schedule_time = samp.task_schedule_time,
                created_date = DateTime.UtcNow,
                updated_date = DateTime.UtcNow
            };

            DB.DailyTask.Add(SampData);
            DB.SaveChanges();


            DailyTaskTans SampData1 = new DailyTaskTans()
            {
                daily_task_id = SampData.id,
                user_assigned_id = samp.task_assigned_by,
                task_work_status = "pending",
                task_remarks = "Daily Task  Create by admin",
                task_schedule_type = samp.task_schedule_type,
                created_by = samp.created_by,
                //samp.task_remarks,
                created_date = DateTime.Now
            };

            DB.DailyTaskTans.Add(SampData1);
            DB.SaveChanges();





            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "inserted successfully"
            };
            return data;
        }

        public DailyTaskResp UpdateDailyTask(long dailyTaskId, DailyTaskReq samp)
        {
            var existing = DB.DailyTask.Find(dailyTaskId);

            if (existing == null)
            {

                DailyTaskResp data1 = new DailyTaskResp()
                {
                    status = false,
                    Message = "Task not found"
                };

                return data1;
            }
            existing.user_id = samp.user_id;
            existing.task_title = samp.task_title;
            existing.task_description = samp.task_description;
            existing.task_priority = samp.task_priority; // e.g.; "low"; "medium"; "high"
            existing.task_status = samp.task_status; // e.g., "active", "    InActive"
            existing.start_date = samp.start_date;
            existing.end_date = samp.end_date;
            existing.task_assigned_by = samp.task_assigned_by; 
            existing.updated_date = DateTime.UtcNow;
            existing.type_mode = samp.type_mode;   // e.g.; "single"; "all"
            existing.task_schedule_type = samp.task_schedule_type;
            existing.specific_days = samp.specific_days;
            existing.task_single_day = samp.task_single_day;
            existing.task_schedule_time = samp.task_schedule_time;

            DB.SaveChanges();


            DailyTaskTans SampData1 = new DailyTaskTans()
            {
                daily_task_id = existing.id,
                user_assigned_id = samp.task_assigned_by,
                task_work_status = samp.task_work_status,
                task_remarks = samp.task_remarks,
                created_date = DateTime.Now,
                created_by = samp.created_by,
                task_schedule_type = samp.task_schedule_type,
            };

            DB.DailyTaskTans.Add(SampData1);
            DB.SaveChanges();

            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "Updated successfully"
            };
            return data;
        }



        public DailyTaskResp DeleteDailyTask(long dailyTaskId)
        {

            DailyTask del = DB.DailyTask
                .Include(e => e.DailyTaskTans)
                .SingleOrDefault(parent => parent.id == dailyTaskId);

            if (del == null)
            {
                throw new Exception("RECORD NOT FOUND");
            }

            del.task_delete = 1;

            if(del.DailyTaskTans.Count != 0)
            {
                foreach (var tans in del.DailyTaskTans)
                {
                    tans.task_trans_delete = 1;
                }
            }
            DB.SaveChanges();

            DailyTaskResp data = new DailyTaskResp()
            {
                status = true,
                Message = "deleted successfully"
            };
            return data;

        }


    }
}