using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Filling_Doc_Trx_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("filling_trx_auto_id", Order = 2, TypeName = "double(18,3)")]
       public long? filling_trx_auto_id { get; set; }

       [Column("filling_master_auto_id", Order = 3, TypeName = "double(18,3)")]
       public long? filling_master_auto_id { get; set; }

       [Column("filling_date", Order = 4, TypeName = "datetime")]
       public DateTime? filling_date { get; set; }

       [Column("transfer_no", Order = 5, TypeName = "text")]
       public string? transfer_no { get; set; }

       [Column("transfer_status", Order = 6, TypeName = "varchar(100)")]
       public string? transfer_status { get; set; }

       [Column("req_form_master", Order = 7, TypeName = "text")]
       public string? req_form_master { get; set; }

       [Column("reject_yn", Order = 8, TypeName = "text")]
       public string? reject_yn { get; set; }

       [Column("reject_remark", Order = 9, TypeName = "text")]
       public string? reject_remark { get; set; }

       [Column("req_comp", Order = 10, TypeName = "text")]
       public string? req_comp { get; set; }

       [Column("inword_no", Order = 11, TypeName = "text")]
       public string? inword_no { get; set; }

       [Column("inword_status", Order = 12, TypeName = "varchar(100)")]
       public string? inword_status { get; set; }

       [Column("req_rec_no", Order = 13, TypeName = "text")]
       public string? req_rec_no { get; set; }

       [Column("req_rec_status", Order = 14, TypeName = "varchar(100)")]
       public string? req_rec_status { get; set; }

       [Column("trx_remark", Order = 15, TypeName = "text")]
       public string? trx_remark { get; set; }

       [Column("inward_rec_remark", Order = 16, TypeName = "text")]
       public string? inward_rec_remark { get; set; }

       [Column("scan_path_by_user", Order = 17, TypeName = "text")]
       public string? scan_path_by_user { get; set; }

       [Column("user_name", Order = 18, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("created_on", Order = 19, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 20, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

   }
}
