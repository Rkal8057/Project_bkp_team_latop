using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class DailyTask
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("user_id", Order = 2, TypeName = "bigint")]
        public long? user_id { get; set; }  // not used

        [Column("task_title", Order = 3, TypeName = "text")]
        public string? task_title { get; set; }

        [Column("task_description", Order = 4, TypeName = "text")]
        public string? task_description { get; set; }

        [Column("task_priority", Order = 5, TypeName = "text")]
        public string? task_priority { get; set; } // e.g., "low", "medium", "high"

        [Column("task_status", Order = 6, TypeName = "text")]
        public string? task_status { get; set; } // e.g., "Active", "Inactive"

        [Column("type_mode", Order = 7, TypeName = "text")]
        public string? type_mode { get; set; } // e.g., "single", "all"

        [Column("start_date", Order = 8, TypeName = "datetime")]
        public DateTime? start_date { get; set; }  // not used

        [Column("end_date", Order = 9, TypeName = "datetime")]
        public DateTime? end_date { get; set; }   // not used

        [Column("task_assigned_by", Order = 11, TypeName = "bigint")]
        public long? task_assigned_by { get; set; } 

        [Column("task_delete", Order = 12, TypeName = "bigint")]
        public long? task_delete { get; set; } = 0;

        [Column("task_schedule_type", Order = 13, TypeName = "text")]
        public string? task_schedule_type { get; set; }

        [Column("specific_days", Order = 14, TypeName = "text")]
        public string? specific_days { get; set; }

        [Column("task_schedule_time", Order = 15, TypeName = "text")]
        public string? task_schedule_time { get; set; }

        [Column("task_single_day", Order = 16, TypeName = "text")]
        public string? task_single_day { get; set; }

        [Column("created_date", Order = 17, TypeName = "datetime")]
        public DateTime? created_date { get; set; } = DateTime.UtcNow;

        [Column("updated_date", Order = 18, TypeName = "datetime")]
        public DateTime? updated_date { get; set; } = DateTime.UtcNow;

        public ICollection<DailyTaskTans> ? DailyTaskTans { get; set; }

    }
}