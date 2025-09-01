using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class Challan_Single_Item_Master
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_name", Order = 1, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("item_purchase_one_pc", Order = 2, TypeName = "float")]
        public double? item_purchase_one_pc { get; set; }

        [Column("item_rate_one_pc", Order = 3, TypeName = "float")]
        public double? item_rate_one_pc { get; set; }

        [Column("item_profit_one_pc", Order = 4, TypeName = "float")]
        public double? item_profit_one_pc { get; set; }

        [Column("item_qty", Order = 5, TypeName = "bigint")]
        public long? item_qty { get; set; }

        [Column("item_discount_percentage_one_pc", Order = 6, TypeName = "float")]
        public double? item_discount_percentage_one_pc { get; set; }

        [Column("item_discount_amount_one_pc", Order = 7, TypeName = "float")]
        public double? item_discount_amount_one_pc { get; set; }

        [Column("item_discount_rate_one_pc", Order = 8, TypeName = "float")]
        public double? item_discount_rate_one_pc { get; set; }

        [Column("item_gross_amount_one_pc", Order = 9, TypeName = "float")]
        public double? item_gross_amount_one_pc { get; set; }

        [Column("item_gst_percenatge_one_pc", Order = 10, TypeName = "float")]
        public double? item_gst_percenatge_one_pc { get; set; }

        [Column("item_gst_amt_one_pc", Order = 11, TypeName = "float")]
        public double? item_gst_amt_one_pc { get; set; }

        [Column("item_gst_rate_one_pc", Order = 12, TypeName = "float")]
        public double? item_gst_rate_one_pc { get; set; }

        [Column("item_rate_after_gst_one_pc", Order = 13, TypeName = "float")]
        public double? item_rate_after_gst_one_pc { get; set; }

        [Column("total_amount_with_gst_one_pc", Order = 14, TypeName = "float")]
        public double? total_amount_with_gst_one_pc { get; set; }

        [Column("profit_amount_one_pc", Order = 15, TypeName = "float")]
        public double? profit_amount_one_pc { get; set; }

        [Column("item_hsn_code_one_pc", Order = 16, TypeName = "text")]
        public string? item_hsn_code_one_pc { get; set; }

        [Column("item_packing_type_one_pc", Order = 17, TypeName = "text")]
        public string? item_packing_type_one_pc { get; set; }

        [Column("item_remarks_one_pc", Order = 18, TypeName = "text")]
        public string? item_remarks_one_pc { get; set; }

        [Column("item_weight_one_pc", Order = 19, TypeName = "float")]
        public double? item_weight_one_pc { get; set; }

        [ForeignKey("IssueReceiptMaster"), Column("issue_master_id", Order = 20, TypeName = "bigint")]
        public long? issue_master_id { get; set; }

        [Column("delete_at", Order = 21, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 22, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        [Column("unique_number", Order = 23, TypeName = "text")]
        public string? unique_number { get; set; }
        public virtual IssueReceiptMaster? IssueReceiptMaster { get; set;  } 
    }
}
