using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class ServiceSubCategoryMaster
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







        [Column("commission_type", Order = 6, TypeName = "text")]
        public string? commission_type { get; set; }

        [Column("commission_percentage", Order = 7, TypeName = "text")]
        public string? commission_percentage { get; set; }

        [Column("commission_amt", Order = 8, TypeName = "text")]
        public string? commission_amt { get; set; }

        [Column("cashback_amt", Order = 9, TypeName = "text")]
        public string? cashback_amt { get; set; }

        [Column("cashback_percentage", Order = 10, TypeName = "text")]
        public string? cashback_percentage { get; set; }

        [Column("cashback_type", Order = 11, TypeName = "text")]
        public string? cashback_type { get; set; }

        [Column("item_category_sub_id", Order = 12, TypeName = "bigint")]
        public long? item_category_sub_id { get; set; }

        public ICollection<CheckListMaster>? CheckListMaster { get; set; }

        [JsonIgnore]
        public virtual ServiceMaster? ServiceMaster { get; set; }
    }
}
