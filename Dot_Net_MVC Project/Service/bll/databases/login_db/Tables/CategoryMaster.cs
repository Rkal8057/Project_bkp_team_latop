using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class CategoryMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("service_type", Order = 2, TypeName = "text")]
        public string? service_type { get; set; }

        [Column("approx_amount", Order = 3, TypeName = "decimal(18, 2)")]
        public decimal? approx_amount { get; set; }

        [Column("approx_days", Order = 4, TypeName = "int")]
        public int? approx_days { get; set; }

        [ForeignKey("ServiceMaster"), Column("service_id", Order = 5, TypeName = "bigint")]
        public long? service_id { get; set; }

        public ICollection<CheckListMaster>? CheckListMaster { get; set; }

        [JsonIgnore]
        public virtual ServiceMaster? ServiceMaster { get; set; }
    }
}
