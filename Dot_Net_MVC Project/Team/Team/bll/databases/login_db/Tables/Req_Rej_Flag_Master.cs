using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rej_Flag_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("rr_id", Order = 2, TypeName = "double(18,3)")]
       public long? rr_id { get; set; }

       [Column("rr_flag_name", Order = 3, TypeName = "text")]
       public string? rr_flag_name { get; set; }

       [Column("rr_flag_form_name", Order = 4, TypeName = "text")]
       public string? rr_flag_form_name { get; set; }

       [Column("table_name", Order = 5, TypeName = "text")]
       public string? table_name { get; set; }

       [Column("rejection_days", Order = 6, TypeName = "float")]
       public long? rejection_days { get; set; }

       [Column("rej_days_incl_holidays", Order = 7, TypeName = "varchar(3)")]
       public string? rej_days_incl_holidays { get; set; }

       [Column("comform_days", Order = 8, TypeName = "float")]
       public long? comform_days { get; set; }

       [Column("comform_days_incl_holidays", Order = 9, TypeName = "varchar(3)")]
       public string? comform_days_incl_holidays { get; set; }

       [Column("rr_flag_form_name_short", Order = 10, TypeName = "text")]
       public string? rr_flag_form_name_short { get; set; }

       [Column("rr_trx_category", Order = 11, TypeName = "text")]
       public string? rr_trx_category { get; set; }

   }
}
