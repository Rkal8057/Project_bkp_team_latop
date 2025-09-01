using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class DailyTaskReq
    {
        public long? user_id { get; set; }
        public string? task_title { get; set; }
        public string? task_description { get; set; }
        public string? task_priority { get; set; }
        public string? task_status { get; set; }
        public string? type_mode { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public long? task_assigned_by { get; set; }
        public long? task_delete { get; set; }
        public string? task_remarks { get; set; }
        public string? task_schedule_type { get; set; }
        public string? specific_days { get; set; }
        public long? created_by { get; set; }
        public string? task_single_day { get; set; }
        public string? task_schedule_time { get; set; }
        public string? task_work_status { get; set; }
    }
}
