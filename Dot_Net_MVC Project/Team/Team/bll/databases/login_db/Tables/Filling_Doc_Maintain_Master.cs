using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Filling_Doc_Maintain_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("filling_master_auto_id", Order = 2, TypeName = "double(18,3)")]
       public long? filling_master_auto_id { get; set; }

       [Column("filling_sno", Order = 3, TypeName = "varchar(100)")]
       public string? filling_sno { get; set; }

       [Column("filling_date", Order = 4, TypeName = "datetime")]
       public DateTime? filling_date { get; set; }

       [Column("file_status_type", Order = 5, TypeName = "text")]
       public string? file_status_type { get; set; }

       [Column("transfer_no", Order = 6, TypeName = "float")]
       public long? transfer_no { get; set; }

       [Column("transfer_status", Order = 7, TypeName = "varchar(100)")]
       public string? transfer_status { get; set; }

       [Column("inword_no", Order = 8, TypeName = "float")]
       public long? inword_no { get; set; }

       [Column("inword_status", Order = 9, TypeName = "varchar(100)")]
       public string? inword_status { get; set; }

       [Column("req_rec_no", Order = 10, TypeName = "float")]
       public long? req_rec_no { get; set; }

       [Column("req_rec_status", Order = 11, TypeName = "varchar(100)")]
       public string? req_rec_status { get; set; }

       [Column("tran_no_from_to_text", Order = 12, TypeName = "text")]
       public string? tran_no_from_to_text { get; set; }

       [Column("tran_no_from", Order = 13, TypeName = "float")]
       public long? tran_no_from { get; set; }

       [Column("tran_no_upto", Order = 14, TypeName = "float")]
       public long? tran_no_upto { get; set; }

       [Column("transaction_type", Order = 15, TypeName = "text")]
       public string? transaction_type { get; set; }

       [Column("filling_comp_name", Order = 16, TypeName = "text")]
       public string? filling_comp_name { get; set; }

       [Column("filling_comp_isin", Order = 17, TypeName = "text")]
       public string? filling_comp_isin { get; set; }

       [Column("filling_comp_type", Order = 18, TypeName = "varchar(50)")]
       public string? filling_comp_type { get; set; }

       [Column("filebox_no", Order = 19, TypeName = "text")]
       public string? filebox_no { get; set; }

       [Column("colour_name", Order = 20, TypeName = "text")]
       public string? colour_name { get; set; }

       [Column("location_name", Order = 21, TypeName = "text")]
       public string? location_name { get; set; }

       [Column("rack_no", Order = 22, TypeName = "text")]
       public string? rack_no { get; set; }

       [Column("cell_no", Order = 23, TypeName = "text")]
       public string? cell_no { get; set; }

       [Column("file_type", Order = 24, TypeName = "text")]
       public string? file_type { get; set; }

       [Column("date_remark", Order = 25, TypeName = "text")]
       public string? date_remark { get; set; }

       [Column("remark_2", Order = 26, TypeName = "text")]
       public string? remark_2 { get; set; }

       [Column("created_on", Order = 27, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 28, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("created_through", Order = 29, TypeName = "text")]
       public string? created_through { get; set; }

       [Column("import_file_id", Order = 30, TypeName = "text")]
       public string? import_file_id { get; set; }

       [Column("user_name", Order = 31, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("verify_yn", Order = 32, TypeName = "varchar(3)")]
       public string? verify_yn { get; set; }

       [Column("verify_by_username", Order = 33, TypeName = "varchar(100)")]
       public string? verify_by_username { get; set; }

       [Column("verify_status_msg", Order = 34, TypeName = "text")]
       public string? verify_status_msg { get; set; }

       [Column("verify_remark", Order = 35, TypeName = "text")]
       public string? verify_remark { get; set; }

       [Column("verify_updated_on", Order = 36, TypeName = "datetime")]
       public DateTime? verify_updated_on { get; set; }

       [Column("maker_id", Order = 37, TypeName = "bigint(10)")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 38, TypeName = "varchar(100)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 39, TypeName = "text")]
       public string? maker_remark { get; set; }

       [Column("maker_status", Order = 40, TypeName = "text")]
       public string? maker_status { get; set; }

       [Column("maker_status_created_on", Order = 41, TypeName = "datetime")]
       public DateTime? maker_status_created_on { get; set; }

       [Column("checker_id", Order = 42, TypeName = "bigint(10)")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 43, TypeName = "varchar(100)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 44, TypeName = "text")]
       public string? checker_remark { get; set; }

       [Column("checker_status", Order = 45, TypeName = "text")]
       public string? checker_status { get; set; }

       [Column("checker_status_created_on", Order = 46, TypeName = "datetime")]
       public DateTime? checker_status_created_on { get; set; }

       [Column("current_status", Order = 47, TypeName = "text")]
       public string? current_status { get; set; }

   }
}
