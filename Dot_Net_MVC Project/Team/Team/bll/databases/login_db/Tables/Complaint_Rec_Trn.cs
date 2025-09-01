using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Complaint_Rec_Trn
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("cplt_rec_trn_id", Order = 2, TypeName = "double(18,3)")]
       public long? cplt_rec_trn_id { get; set; }

       [Column("cplt_rec_id", Order = 3, TypeName = "double(18,3)")]
       public long? cplt_rec_id { get; set; }

       [Column("cplt_rec_maker_by_user", Order = 4, TypeName = "text")]
       public string? cplt_rec_maker_by_user { get; set; }

       [Column("cplt_rec_maker_entry_datetime", Order = 5, TypeName = "datetime")]
       public DateTime? cplt_rec_maker_entry_datetime { get; set; }

       [Column("cplt_rec_checker_by_user", Order = 6, TypeName = "text")]
       public string? cplt_rec_checker_by_user { get; set; }

       [Column("cplt_rec_checker_entry_datetime", Order = 7, TypeName = "datetime")]
       public DateTime? cplt_rec_checker_entry_datetime { get; set; }

       [Column("cplt_rec_naturn_of_complaint", Order = 8, TypeName = "text")]
       public string? cplt_rec_naturn_of_complaint { get; set; }

       [Column("cplt_rec_nature_detail", Order = 9, TypeName = "text")]
       public string? cplt_rec_nature_detail { get; set; }

       [Column("cplt_rec_maker_remark", Order = 10, TypeName = "text")]
       public string? cplt_rec_maker_remark { get; set; }

       [Column("cplt_rec_verify_by_user", Order = 11, TypeName = "text")]
       public string? cplt_rec_verify_by_user { get; set; }

       [Column("cplt_rec_verify_datetime_auto", Order = 12, TypeName = "datetime")]
       public DateTime? cplt_rec_verify_datetime_auto { get; set; }

       [Column("cplt_rec_reject_yn", Order = 13, TypeName = "varchar(3)")]
       public string? cplt_rec_reject_yn { get; set; }

       [Column("cplt_rec_reject_remark", Order = 14, TypeName = "text")]
       public string? cplt_rec_reject_remark { get; set; }

       [Column("cplt_rec_reply_date", Order = 15, TypeName = "datetime")]
       public DateTime? cplt_rec_reply_date { get; set; }

       [Column("cplt_rec_action_type", Order = 16, TypeName = "text")]
       public string? cplt_rec_action_type { get; set; }

       [Column("cplt_rec_action_remark", Order = 17, TypeName = "text")]
       public string? cplt_rec_action_remark { get; set; }

   }
}
