using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Maker_Checker_Ac_Log_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("maker_checker_log_id", Order = 2, TypeName = "bigint(10)")]
       public long? maker_checker_log_id { get; set; }

       [Column("maker_checker_log_id_status", Order = 3, TypeName = "text")]
       public string? maker_checker_log_id_status { get; set; }

       [Column("created_on", Order = 4, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 5, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("comp_sno", Order = 6, TypeName = "bigint(10)")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 7, TypeName = "text")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 8, TypeName = "text")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 9, TypeName = "text")]
       public string? comp_name_short { get; set; }

       [Column("bill_no", Order = 10, TypeName = "bigint(10)")]
       public long? bill_no { get; set; }

       [Column("bill_date", Order = 11, TypeName = "datetime")]
       public DateTime? bill_date { get; set; }

       [Column("vou_type", Order = 12, TypeName = "varchar(100)")]
       public string? vou_type { get; set; }

       [Column("maker_id", Order = 13, TypeName = "bigint(10)")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 14, TypeName = "varchar(100)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 15, TypeName = "text")]
       public string? maker_remark { get; set; }

       [Column("maker_status", Order = 16, TypeName = "text")]
       public string? maker_status { get; set; }

       [Column("maker_status_created_on", Order = 17, TypeName = "datetime")]
       public DateTime? maker_status_created_on { get; set; }

       [Column("checker_id", Order = 18, TypeName = "bigint(10)")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 19, TypeName = "varchar(100)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 20, TypeName = "text")]
       public string? checker_remark { get; set; }

       [Column("checker_status", Order = 21, TypeName = "text")]
       public string? checker_status { get; set; }

       [Column("checker_status_created_on", Order = 22, TypeName = "datetime")]
       public DateTime? checker_status_created_on { get; set; }

       [Column("current_status", Order = 23, TypeName = "text")]
       public string? current_status { get; set; }

   }
}
