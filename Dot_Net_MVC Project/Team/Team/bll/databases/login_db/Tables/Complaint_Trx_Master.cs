using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class Complaint_Trx_Master
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint(10) auto_increment")]
        public long? id { get; set; }

        [Column("user_id", Order = 2, TypeName = "bigint(10)")]
        public long? user_id { get; set; }

        [Column("unique_complaint_id", Order = 3, TypeName = "bigint")]
        public long? unique_complaint_id { get; set; }

        [Column("reply_to", Order = 4, TypeName = "text")]
        public string? reply_to { get; set; }

        [Column("reply_date", Order = 5, TypeName = "date")]
        public DateTime? reply_date { get; set; }

        [Column("action_taken", Order = 6, TypeName = "text")]
        public string? action_taken { get; set; }

        [Column("action_remark", Order = 7, TypeName = "text")]
        public string? action_remark { get; set; }


        [Column("attached_file", Order = 8, TypeName = "text")]
        public string? attached_file { get; set; }

        [Column("created_on", Order = 9, TypeName = "datetime")]
        public DateTime created_on { get; set; } = DateTime.UtcNow;

        [ForeignKey("Complaint_Master"), Column("master_id", Order = 10, TypeName = "bigint")]
        public long master_id { get; set; }

        [JsonIgnore]
        public virtual Complaint_Master? Complaint_Master { get; set; }
    }
}
