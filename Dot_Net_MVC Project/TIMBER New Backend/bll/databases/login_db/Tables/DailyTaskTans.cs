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
    public class DailyTaskTans
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long? id { get; set; }
        
        [Column("user_assigned_id", Order = 2, TypeName = "bigint")]
        public long? user_assigned_id { get; set; }

        [Column("task_work_status", Order = 3, TypeName = "text")]
        public string? task_work_status { get; set; } // e.g., "pending", "in_progress", "completed"

        [Column("task_remarks", Order = 4, TypeName = "text")]
        public string? task_remarks { get; set; }

        [ForeignKey("DailyTask") ,Column("daily_task_id", Order = 5, TypeName = "bigint")]
        public long? daily_task_id { get; set; }

        [Column("task_trans_delete", Order = 6, TypeName = "bigint")]
        public long? task_trans_delete { get; set; } = 0;

        [Column("task_schedule_type", Order = 7, TypeName = "text")]
        public string? task_schedule_type { get; set; }

        [Column("created_date", Order = 8, TypeName = "datetime")]
        public DateTime? created_date { get; set; } = DateTime.UtcNow;

        [Column("created_by", Order = 9, TypeName = "bigint")]
        public long? created_by { get; set; }
        public virtual DailyTask? DailyTask { get; set; }
    }
}
