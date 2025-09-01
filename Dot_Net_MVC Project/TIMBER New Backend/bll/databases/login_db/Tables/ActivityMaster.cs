using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class ActivityMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("activity_name_id", Order = 2, TypeName = "bigint")]
        public long? activity_name_id { get; set; }

        [Column("activity_name", Order = 3, TypeName = "text")]
        public string? activity_name { get; set; }

        [Column("activity_date", Order = 4, TypeName = "date")]
        public DateTime? activity_date { get; set; }

        [Column("activity_time", Order = 5, TypeName = "text")]
        public string? activity_time { get; set; }

        [Column("activity_duration", Order = 6, TypeName = "text")]
        public string? activity_duration { get; set; }

        [Column("activity_note", Order = 7, TypeName = "text")]
        public string? activity_note { get; set; }

        [Column("user_id", Order = 8, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("activity_start_time", Order = 9, TypeName = "text")]
        public string? activity_start_time { get; set; }

        [Column("activity_end_time", Order = 10, TypeName = "text")]
        public string? activity_end_time { get; set; }

        [Column("activity_maintain_type", Order = 11, TypeName = "text")]
        public string? activity_maintain_type { get; set; }

        [Column("created_on", Order = 12, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 13, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("delete", Order = 14, TypeName = "bigint")]
        public long? delete { get; set; } = 0;
        public ICollection<ActivityTranxMaster> ActivityTranxMaster { get; set ;}
    }
}
