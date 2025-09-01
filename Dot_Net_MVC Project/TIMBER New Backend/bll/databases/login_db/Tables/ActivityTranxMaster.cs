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
    public class ActivityTranxMaster
    {

        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("slot_start", Order = 2, TypeName = "text")]
        public string? slot_start { get; set; }

        [Column("slot_end", Order = 3, TypeName = "text")]
        public string? slot_end { get; set; }

        [Column("activity_detail", Order = 4, TypeName = "text")]
        public string? activity_detail { get; set; }

        [Column("activity_detail_id", Order = 5, TypeName = "bigint")]
        public long? activity_detail_id { get; set; }

        [Column("remark", Order = 6, TypeName = "text")]
        public string? remark { get; set; }

        [Column("duration", Order = 7, TypeName = "text")]
        public string? duration { get; set; }

        [ForeignKey("ActivityMaster"),Column("activity_master_id", Order = 8, TypeName = "bigint")]
        public long? activity_master_id { get; set; }

        [Column("activity_default_remark", Order = 9, TypeName = "text")]
        public string? activity_default_remark { get; set; }

        [Column("created_on", Order = 10, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 11, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }   

        [Column("delete", Order = 12, TypeName = "bigint")]
        public long? delete { get; set; } = 0;
        public virtual ActivityMaster ActivityMaster { get; set; }
    }
}
