using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Check_List_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "double(18,3)")]
       public long? table_auto_id { get; set; }

       [Column("created_on", Order = 3, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("check_list_master_name", Order = 4, TypeName = "text")]
       public string? check_list_master_name { get; set; }

       [Column("req_flag", Order = 5, TypeName = "text")]
       public string? req_flag { get; set; }

       [Column("req_flag_name", Order = 6, TypeName = "text")]
       public string? req_flag_name { get; set; }

       [Column("checking_flag", Order = 7, TypeName = "text")]
       public string? checking_flag { get; set; }

       [Column("cl_vou_no", Order = 8, TypeName = "double(18,3)")]
       public long? cl_vou_no { get; set; }

       [Column("check_list_detail_name", Order = 9, TypeName = "text")]
       public string? check_list_detail_name { get; set; }

       [Column("check_list_for", Order = 10, TypeName = "text")]
       public string? check_list_for { get; set; }

       [Column("check_list_type_mo", Order = 11, TypeName = "text")]
       public string? check_list_type_mo { get; set; }

       [Column("verify_yn", Order = 12, TypeName = "varchar(3)")]
       public string? verify_yn { get; set; }

       [Column("verify_by_username", Order = 13, TypeName = "varchar(100)")]
       public string? verify_by_username { get; set; }

       [Column("verify_status_msg", Order = 14, TypeName = "text")]
       public string? verify_status_msg { get; set; }

       [Column("verify_remark", Order = 15, TypeName = "text")]
       public string? verify_remark { get; set; }

       [Column("verify_updated_on", Order = 16, TypeName = "datetime")]
       public DateTime? verify_updated_on { get; set; }

       [Column("maker_id", Order = 17, TypeName = "bigint(10)")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 18, TypeName = "varchar(100)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 19, TypeName = "text")]
       public string? maker_remark { get; set; }

       [Column("maker_status", Order = 20, TypeName = "text")]
       public string? maker_status { get; set; }

       [Column("maker_status_created_on", Order = 21, TypeName = "datetime")]
       public DateTime? maker_status_created_on { get; set; }

       [Column("checker_id", Order = 22, TypeName = "bigint(10)")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 23, TypeName = "varchar(100)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 24, TypeName = "text")]
       public string? checker_remark { get; set; }

       [Column("checker_status", Order = 25, TypeName = "text")]
       public string? checker_status { get; set; }

       [Column("checker_status_created_on", Order = 26, TypeName = "datetime")]
       public DateTime? checker_status_created_on { get; set; }

       [Column("current_status_code", Order = 27, TypeName = "bigint(10)")]
       public long? current_status_code { get; set; }

       [Column("current_status", Order = 28, TypeName = "text")]
       public string? current_status { get; set; }

   }
}
