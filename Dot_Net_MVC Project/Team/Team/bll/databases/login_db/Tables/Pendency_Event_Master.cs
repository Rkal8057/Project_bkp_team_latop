using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Pendency_Event_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("pendency_id", Order = 2, TypeName = "bigint(10)")]
       public long? pendency_id { get; set; }

       [Column("pendency_created_on", Order = 3, TypeName = "datetime")]
       public DateTime? pendency_created_on { get; set; }

       [Column("pendency_name", Order = 4, TypeName = "varchar(100)")]
       public string? pendency_name { get; set; }

       [Column("pendency_detail_remark", Order = 5, TypeName = "text")]
       public string? pendency_detail_remark { get; set; }

       [Column("pendency_assign_to", Order = 6, TypeName = "text")]
       public string? pendency_assign_to { get; set; }

       [Column("pendency_enable_yn", Order = 7, TypeName = "varchar(3)")]
       public string? pendency_enable_yn { get; set; }

       [Column("pendency_captcha", Order = 8, TypeName = "varchar(100)")]
       public string? pendency_captcha { get; set; }

       [Column("pendency_maker_name", Order = 9, TypeName = "varchar(100)")]
       public string? pendency_maker_name { get; set; }

       [Column("pendency_verify_yn", Order = 10, TypeName = "varchar(3)")]
       public string? pendency_verify_yn { get; set; }

       [Column("pendency_verify_checker_name", Order = 11, TypeName = "varchar(100)")]
       public string? pendency_verify_checker_name { get; set; }

       [Column("pendency_verify_updated_on", Order = 12, TypeName = "datetime")]
       public DateTime? pendency_verify_updated_on { get; set; }

       [Column("pendency_verify_checker_status_msg", Order = 13, TypeName = "varchar(100)")]
       public string? pendency_verify_checker_status_msg { get; set; }

       [Column("pendency_verify_checker_verify_remark", Order = 14, TypeName = "varchar(100)")]
       public string? pendency_verify_checker_verify_remark { get; set; }

       [Column("pendency_type", Order = 15, TypeName = "varchar(100)")]
       public string? pendency_type { get; set; }

       [Column("pendency_status", Order = 16, TypeName = "varchar(100)")]
       public string? pendency_status { get; set; }

       [Column("pendency_start_on", Order = 17, TypeName = "datetime")]
       public DateTime? pendency_start_on { get; set; }

       [Column("pendency_end_on", Order = 18, TypeName = "datetime")]
       public DateTime? pendency_end_on { get; set; }

       [Column("pendency_run_type", Order = 19, TypeName = "varchar(100)")]
       public string? pendency_run_type { get; set; }

       [Column("pendency_selected_weekdays", Order = 20, TypeName = "text")]
       public string? pendency_selected_weekdays { get; set; }

       [Column("pendency_selected_months", Order = 21, TypeName = "text")]
       public string? pendency_selected_months { get; set; }

       [Column("pendency_selected_days", Order = 22, TypeName = "text")]
       public string? pendency_selected_days { get; set; }

       [Column("pendency_activate_date", Order = 23, TypeName = "datetime")]
       public DateTime? pendency_activate_date { get; set; }

       [Column("pendency_completed_on", Order = 24, TypeName = "datetime")]
       public DateTime? pendency_completed_on { get; set; }

       [Column("pendency_completed_by", Order = 25, TypeName = "text")]
       public string? pendency_completed_by { get; set; }

       [Column("pendency_completed_remark", Order = 26, TypeName = "text")]
       public string? pendency_completed_remark { get; set; }

   }
}
