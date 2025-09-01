using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace DB.Login.Tables
{
    public class CorrespondenceRequest
    {
        [Key, Column("id", Order = 1, TypeName = "bigint auto_increment")]
        public long id { get; set; }

        [Column("company_name", Order = 2, TypeName = "text")]
        public string? company_name { get; set; }

        [Column("reply_date", Order = 3, TypeName = "date")]
        public DateTime? reply_date { get; set; }

        [Column("reject_yn", Order = 4, TypeName = "text")]
        public string? reject_yn { get; set; }

        [Column("work_category", Order = 5, TypeName = "text")]
        public string? work_category { get; set; }

        [Column("purpose", Order = 6, TypeName = "text")]
        public string? purpose { get; set; }

        [Column("sender_name", Order = 7, TypeName = "text")]
        public string? sender_name { get; set; }

        [Column("sender_email", Order = 8, TypeName = "text")]
        public string? sender_email { get; set; }

        [Column("sender_mobile", Order = 9, TypeName = "bigint")]
        public long? sender_mobile { get; set; }

        [Column("status", Order = 10, TypeName = "text")]
        public string? status { get; set; } = "Pending";

        [Column("current_date", Order = 11, TypeName = "date")]
        public DateTime? current_date { get; set; } = new DateTime().ToLocalTime();
    }
}
