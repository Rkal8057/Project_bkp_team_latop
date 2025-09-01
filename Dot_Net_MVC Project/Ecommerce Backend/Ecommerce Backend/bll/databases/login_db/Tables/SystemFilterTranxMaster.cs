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
    public class SystemFilterTranxMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("filter_data", Order = 1, TypeName = "text")]
        public string? filter_data { get; set; }

        [Column("filter_trns_status", Order = 2, TypeName = "bigint")]
        public long? filter_trns_status { get; set; } = 0;

        [Column("delete", Order = 3, TypeName = "bigint")]
        public long? delete { get; set; } = 0;

        [Column("created_at", Order = 4, TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }

        [Column("modified_at", Order = 5, TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }

        [ForeignKey("SystemFilterMaster"),Column("system_master_id", Order = 6, TypeName = "bigint")]
        public long? system_master_id { get; set; }
        public virtual SystemFilterMaster ? SystemFilterMaster { get; set; }
    }
}
