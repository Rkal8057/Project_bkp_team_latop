using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Task_Event_Master_Log
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("task_id", Order = 2, TypeName = "bigint(10)")]
       public long? task_id { get; set; }

       [Column("task_created_on", Order = 3, TypeName = "datetime")]
       public DateTime? task_created_on { get; set; }

       [Column("task_name", Order = 4, TypeName = "varchar(100)")]
       public string? task_name { get; set; }

       [Column("task_detail_remark", Order = 5, TypeName = "text")]
       public string? task_detail_remark { get; set; }

       [Column("task_assign_to_user", Order = 6, TypeName = "text")]
       public string? task_assign_to_user { get; set; }

       [Column("task_enable_yn", Order = 7, TypeName = "varchar(3)")]
       public string? task_enable_yn { get; set; }

       [Column("task_captcha", Order = 8, TypeName = "varchar(100)")]
       public string? task_captcha { get; set; }

       [Column("task_maker_name", Order = 9, TypeName = "varchar(100)")]
       public string? task_maker_name { get; set; }

       [Column("task_verify_yn", Order = 10, TypeName = "varchar(3)")]
       public string? task_verify_yn { get; set; }

       [Column("task_verify_checker_name", Order = 11, TypeName = "varchar(100)")]
       public string? task_verify_checker_name { get; set; }

       [Column("task_verify_updated_on", Order = 12, TypeName = "datetime")]
       public DateTime? task_verify_updated_on { get; set; }

       [Column("task_verify_checker_status_msg", Order = 13, TypeName = "varchar(100)")]
       public string? task_verify_checker_status_msg { get; set; }

       [Column("task_verify_checker_verify_remark", Order = 14, TypeName = "varchar(100)")]
       public string? task_verify_checker_verify_remark { get; set; }

       [Column("task_type", Order = 15, TypeName = "varchar(100)")]
       public string? task_type { get; set; }

       [Column("task_status", Order = 16, TypeName = "varchar(100)")]
       public string? task_status { get; set; }

       [Column("task_start_on", Order = 17, TypeName = "datetime")]
       public DateTime? task_start_on { get; set; }

       [Column("task_end_on", Order = 18, TypeName = "datetime")]
       public DateTime? task_end_on { get; set; }

       [Column("task_run_type", Order = 19, TypeName = "varchar(100)")]
       public string? task_run_type { get; set; }

       [Column("task_selected_weekdays", Order = 20, TypeName = "text")]
       public string? task_selected_weekdays { get; set; }

       [Column("task_selected_months", Order = 21, TypeName = "text")]
       public string? task_selected_months { get; set; }

       [Column("task_selected_days", Order = 22, TypeName = "text")]
       public string? task_selected_days { get; set; }

       [Column("task_activate_date", Order = 23, TypeName = "datetime")]
       public DateTime? task_activate_date { get; set; }

       [Column("task_completed_on", Order = 24, TypeName = "datetime")]
       public DateTime? task_completed_on { get; set; }

       [Column("task_completed_by", Order = 25, TypeName = "text")]
       public string? task_completed_by { get; set; }

       [Column("task_completed_remark", Order = 26, TypeName = "text")]
       public string? task_completed_remark { get; set; }

   }
}
