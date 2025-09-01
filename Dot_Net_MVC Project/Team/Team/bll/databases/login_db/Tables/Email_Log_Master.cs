using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Email_Log_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("email_log_id", Order = 2, TypeName = "bigint(10)")]
       public long? email_log_id { get; set; }

       [Column("email_sent_on_date", Order = 3, TypeName = "datetime")]
       public DateTime? email_sent_on_date { get; set; }

       [Column("email_sent_type", Order = 4, TypeName = "text")]
       public string? email_sent_type { get; set; }

       [Column("email_sent_address", Order = 5, TypeName = "text")]
       public string? email_sent_address { get; set; }

       [Column("email_sent_bb_address", Order = 6, TypeName = "text")]
       public string? email_sent_bb_address { get; set; }

       [Column("email_sent_cc_address", Order = 7, TypeName = "text")]
       public string? email_sent_cc_address { get; set; }

       [Column("email_sender_address", Order = 8, TypeName = "text")]
       public string? email_sender_address { get; set; }

       [Column("email_subject", Order = 9, TypeName = "text")]
       public string? email_subject { get; set; }

       [Column("email_body_detail", Order = 10, TypeName = "text")]
       public string? email_body_detail { get; set; }

       [Column("email_attach_detail", Order = 11, TypeName = "text")]
       public string? email_attach_detail { get; set; }

       [Column("email_attach_file_name", Order = 12, TypeName = "text")]
       public string? email_attach_file_name { get; set; }

       [Column("email_attach_path", Order = 13, TypeName = "text")]
       public string? email_attach_path { get; set; }

       [Column("email_sent_status", Order = 14, TypeName = "text")]
       public string? email_sent_status { get; set; }

       [Column("email_log_created_by", Order = 15, TypeName = "text")]
       public string? email_log_created_by { get; set; }

       [Column("email_log_created_on", Order = 16, TypeName = "datetime")]
       public DateTime? email_log_created_on { get; set; }

   }
}
