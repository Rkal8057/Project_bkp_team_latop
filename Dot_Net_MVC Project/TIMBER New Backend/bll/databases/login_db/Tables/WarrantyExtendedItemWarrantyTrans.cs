using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class WarrantyExtendedItemWarrantyTrans
    {

        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("warranty_serial_no", Order = 2, TypeName = "text")]
        public string? warranty_serial_no { get; set; }

        [Column("warranty_period", Order = 3, TypeName = "text")]
        public string? warranty_period { get; set; }

        [Column("warranty_visit_slot", Order = 4, TypeName = "text")]
        public string? warranty_visit_slot { get; set; }

        [Column("warranty_visit_charge", Order = 5, TypeName = "text")]
        public string? warranty_visit_charge { get; set; }

        [Column("warranty_trns_master_id", Order = 6, TypeName = "bigint")]
        public long? warranty_trns_master_id { get; set; }
        
        [Column("warranty_master_id", Order = 7, TypeName = "bigint")]
        public long? warranty_master_id { get; set; }

        [Column("item_name", Order = 8, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("item_code", Order = 9, TypeName = "bigint")]
        public long? item_code { get; set; }

        [Column("warranty_visit_start_date", Order = 10, TypeName = "text")]
        public string? warranty_visit_start_date { get; set; }

        [Column("warranty_visit_end_date", Order = 11, TypeName = "text")]
        public string? warranty_visit_end_date { get; set; }

        [Column("warranty_flag", Order = 12, TypeName = "text")]
        public string? warranty_flag { get; set; }

        [Column("delete_at", Order = 13, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("created_at", Order = 49, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 50, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;


    }
}
