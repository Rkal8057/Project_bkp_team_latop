using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class WarrantyExtended
    {

        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_code", Order = 2, TypeName = "bigint")]
        public long? item_code { get; set; }

        [Column("party_code", Order = 3, TypeName = "bigint")]
        public long? party_code { get; set; }

        [Column("warranty_start_date", Order = 4, TypeName = "datetime")]
        public DateTime ?warranty_start_date { get; set; }

        [Column("warranty_end_date", Order = 5, TypeName = "datetime")]
        public DateTime? warranty_end_date { get; set; }

        [Column("warranty_period", Order = 6, TypeName = "text")]
        public string? warranty_period { get; set; }

        [Column("coverage_details", Order = 7, TypeName = "text")]
        public string? coverage_details { get; set; }

        [Column("warranty_cost", Order = 8, TypeName = "decimal(18,2)")]
        public decimal? warranty_cost { get; set; }

        [Column("warranty_gst_percentage", Order = 9, TypeName = "decimal(18,2)")]
        public decimal? warranty_gst_percentage { get; set; }

        [Column("warranty_gst_amount", Order = 10, TypeName = "decimal(18,2)")]
        public decimal? warranty_gst_amount { get; set; }

        [Column("warranty_final_amount", Order = 11, TypeName = "decimal(18,2)")]
        public decimal? warranty_final_amount { get; set; }

        [Column("warranty_serial_no", Order = 12, TypeName = "text")]
        public string? warranty_serial_no { get; set; }

        [Column("issue_challan_single_item_id", Order = 13, TypeName = "bigint")]
        public long? issue_challan_single_item_id { get; set; }

        [Column("warranty_visit_slot", Order = 14, TypeName = "text")]
        public string? warranty_visit_slot { get; set; }

        [Column("delete_at", Order = 15, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("created_at", Order = 49, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 50, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;
    }
}
