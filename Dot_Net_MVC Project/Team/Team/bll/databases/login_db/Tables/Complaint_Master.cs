using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class Complaint_Master
    {
        [Key]
        [Column("id", Order = 1, TypeName = " bigint(10)")]
        public long id { get; set; }

        [Column("user_id", Order = 2, TypeName = " bigint(10)")]
        public long? user_id { get; set; }

        [Column("user_code", Order = 3, TypeName = "bigint")]
        public long? user_code { get; set; }

        [Column("unique_complaint_id", Order = 3, TypeName = "bigint")]
        public long? unique_complaint_id { get; set; }

        [Column("name", Order = 4, TypeName = "nvarchar(255)")]
        public string? name { get; set; }

        [Column("email", Order = 5, TypeName = "nvarchar(255)")]
        public string? email { get; set; }

        [Column("phone", Order = 6, TypeName = "bigint")]
        public long? phone { get; set; } 

        [Column("subject", Order = 7, TypeName = "text")]
        public string? subject { get; set; }

        [Column("complaint_description", Order = 8, TypeName = "text")]
        public string? complaint_description { get; set; }

        [Column("status", Order = 9, TypeName = "nvarchar(50)")]
        public string status { get; set; } = "pending";


        [Column("nature_of_complaint", Order = 10, TypeName = "text")]
        public string? nature_of_complaint { get; set; }

        [Column("nature_of_complaint_detail", Order = 11, TypeName = "text")]
        public string? nature_of_complaint_detail { get; set; }

        [Column("nature_of_complaint_remark", Order = 12, TypeName = "text")]
        public string? nature_of_complaint_remark { get; set; }

        [Column("created_on", Order = 13, TypeName = "datetime")]
        public DateTime created_on { get; set; } = DateTime.UtcNow;

        [Column("attached_file", Order = 14, TypeName = "text")]
        public string? attached_file { get; set; }

        [JsonIgnore]
        public virtual ICollection<Complaint_Trx_Master>? Complaint_Trx_Master { get; set; }
    }
}
