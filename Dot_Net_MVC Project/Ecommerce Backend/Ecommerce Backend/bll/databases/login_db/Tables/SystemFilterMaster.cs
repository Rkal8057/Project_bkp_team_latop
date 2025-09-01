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
    public class SystemFilterMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("filter_name", Order = 1, TypeName = "text")]
        public string? filter_name { get; set; }

        [Column("filter_key", Order = 2, TypeName = "text")]
        public string? filter_key { get; set; }

        [Column("filter_status", Order = 3, TypeName = "bigint")]
        public long? filter_status { get; set; } = 0;

        [Column("delete", Order = 4, TypeName = "bigint")]
        public long? delete { get; set; } = 0;

        [Column("created_at", Order = 5, TypeName = "datetime")]
        public DateTime? CreatedAt { get; set; }

        [Column("modified_at", Order = 6, TypeName = "datetime")]
        public DateTime? ModifiedAt { get; set; }

        public ICollection<SystemFilterTranxMaster>? SystemFilterTranxMaster { get; set; }
    }
}
