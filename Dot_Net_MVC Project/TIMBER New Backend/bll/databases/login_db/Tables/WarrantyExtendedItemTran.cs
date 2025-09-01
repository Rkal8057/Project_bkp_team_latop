using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class WarrantyExtendedItemTran
    {

        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("item_code", Order = 2, TypeName = "bigint")]
        public long? item_code { get; set; }

        [Column("warranty_serial_no", Order = 3, TypeName = "text")]
        public string? warranty_serial_no { get; set; }

        [Column("warranty_qty", Order = 4, TypeName = "bigint")]
        public long? warranty_qty { get; set; }

        [Column("warranty_period", Order = 5, TypeName = "text")]
        public string? warranty_period { get; set; }

        [Column("warranty_visit_type", Order = 6, TypeName = "text")]
        public string? warranty_visit_type { get; set; } // online/offline

        [Column("warranty_start_date", Order = 7, TypeName = "date")]
        public DateTime? warranty_start_date { get; set; }

        [Column("warranty_end_date", Order = 8, TypeName = "date")]
        public DateTime? warranty_end_date { get; set; }

        [Column("warranty_visit_date", Order = 9, TypeName = "date")]
        public DateTime? warranty_visit_date { get; set; }

        [Column("warranty_charge_after_amc_expire", Order = 10, TypeName = "decimal(18, 2)")]
        public decimal? warranty_charge_after_amc_expire { get; set; }

        [Column("warranty_charge", Order = 11, TypeName = "decimal(18, 2)")]
        public decimal? warranty_charge { get; set; }

        [Column("warranty_gst_percentage", Order = 12, TypeName = "decimal(5, 2)")]
        public decimal? warranty_gst_percentage { get; set; }

        [Column("warranty_gst_amount", Order = 13, TypeName = "decimal(18, 2)")]
        public decimal? warranty_gst_amount { get; set; }

        [Column("warranty_final_amount", Order = 14, TypeName = "decimal(18, 2)")]
        public decimal? warranty_final_amount { get; set; }

        [ForeignKey("WarrantyExtended"),Column("warranty_master_id", Order = 15, TypeName = "bigint")]
        public long? warranty_master_id { get; set; }


        [Column("warranty_visit_slot", Order = 16, TypeName = "text")]
        public string? warranty_visit_slot { get; set; }

        [Column("warranty_visit_gap", Order = 17, TypeName = "text")]
        public string? warranty_visit_gap { get; set; }

        [Column("warranty_visit_charge", Order = 18, TypeName = "text")]
        public string? warranty_visit_charge { get; set; }


        [Column("created_at", Order = 49, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 50, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

        public virtual WarrantyExtended ? WarrantyExtended { get; set;  }
    }
}
