using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Appointment_Master_2022
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("app_comp_name", Order = 3, TypeName = "text")]
       public string? app_comp_name { get; set; }

       [Column("isin_no", Order = 4, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 5, TypeName = "text")]
       public string? isin_comp_name { get; set; }

       [Column("app_date", Order = 6, TypeName = "datetime")]
       public DateTime? app_date { get; set; }

       [Column("app_date_name", Order = 7, TypeName = "text")]
       public string? app_date_name { get; set; }

       [Column("close_date", Order = 8, TypeName = "datetime")]
       public DateTime? close_date { get; set; }

       [Column("close_date_name", Order = 9, TypeName = "text")]
       public string? close_date_name { get; set; }

       [Column("office_date_type", Order = 10, TypeName = "text")]
       public string? office_date_type { get; set; }

       [Column("contact_name", Order = 11, TypeName = "text")]
       public string? contact_name { get; set; }

       [Column("app_category_type", Order = 12, TypeName = "text")]
       public string? app_category_type { get; set; }

       [Column("app_priority_type", Order = 13, TypeName = "text")]
       public string? app_priority_type { get; set; }

       [Column("contact_mobile", Order = 14, TypeName = "text")]
       public string? contact_mobile { get; set; }

       [Column("contact_email", Order = 15, TypeName = "text")]
       public string? contact_email { get; set; }

       [Column("app_comment", Order = 16, TypeName = "text")]
       public string? app_comment { get; set; }

       [Column("holiday_yn", Order = 17, TypeName = "varchar(3)")]
       public string? holiday_yn { get; set; }

       [Column("status_type", Order = 18, TypeName = "text")]
       public string? status_type { get; set; }

       [Column("created_on", Order = 19, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 20, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("user_id", Order = 21, TypeName = "text")]
       public string? user_id { get; set; }

       [Column("user_name", Order = 22, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 23, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
