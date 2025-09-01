using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class IssueItemExtraDetail
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_stock_date", Order = 1, TypeName = "datetime")]
        public DateTime? item_stock_date { get; set; }

        [Column("item_stock_location", Order = 2, TypeName = "text")]
        public string? item_stock_location { get; set; }

        [Column("item_stock_qty", Order = 3, TypeName = "decimal(18, 2)")]
        public double? item_stock_qty { get; set; }

        [Column("item_stock_rate", Order = 4, TypeName = "decimal(18, 2)")]
        public double? item_stock_rate { get; set; }

        [Column("item_stock_value", Order = 5, TypeName = "decimal(18, 2)")]
        public double? item_stock_value { get; set; }

        [ForeignKey("IssueReceiptMaster"), Column("challan_master_id", Order = 6, TypeName = "bigint")]
        public long? challan_master_id { get; set; }

        [Column("item_batch_no", Order = 7, TypeName = "text")]
        public string? item_batch_no { get; set; }

        [Column("item_style", Order = 8, TypeName = "text")]
        public string? item_style { get; set; }

        [Column("item_brand", Order = 9, TypeName = "text")]
        public string? item_brand { get; set; }

        [Column("item_color", Order = 10, TypeName = "text")]
        public string? item_color { get; set; }

        [Column("item_agent", Order = 11, TypeName = "text")]
        public string? item_agent { get; set; }

        [Column("item_dealer", Order = 12, TypeName = "text")]
        public string? item_dealer { get; set; }

        [Column("item_code", Order = 13, TypeName = "bigint")]
        public long? item_code { get; set; }

        [Column("item_name", Order = 14, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("pname", Order = 15, TypeName = "text")]
        public string? pname { get; set; }

        [Column("pcode", Order = 16, TypeName = "bigint")]
        public long? pcode { get; set; }

        [Column("irflag", Order = 17, TypeName = "text")]
        public string? irflag { get; set; }

        [Column("aggrement_id", Order = 18, TypeName = "bigint")]
        public long? aggrement_id { get; set; }

        [Column("delete_at", Order = 19, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("created_at", Order = 20, TypeName = "datetime")]
        public DateTime? created_at { get; set; }

        [Column("updated_at", Order = 21, TypeName = "datetime")]
        public DateTime? updated_at { get; set; }

        [Column("old_software_code_ya_id", Order = 22, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        [Column("unique_number", Order = 23, TypeName = "text")]
        public string? unique_number { get; set; }


        public virtual IssueReceiptMaster? IssueReceiptMaster { get; set; }
    }
}
