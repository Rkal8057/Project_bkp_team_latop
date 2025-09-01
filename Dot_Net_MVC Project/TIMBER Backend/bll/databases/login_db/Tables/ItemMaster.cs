using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class ItemMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_code", Order = 2, TypeName = "text")]
        public string? item_code { get; set; }

        [Column("item_name", Order = 3, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("group", Order = 4, TypeName = "text")]
        public string? group { get; set; }

        [Column("hsn_code", Order = 5, TypeName = "text")]
        public string? hsn_code { get; set; }

        [Column("tax_per", Order = 6, TypeName = "text")]
        public string? tax_per { get; set; }

        [Column("convertion_of_pcs", Order = 7, TypeName = "text")]
        public string? convertion_of_pcs { get; set; }

        [Column("price_purchase_rate", Order = 8, TypeName = "decimal(18,2)")]
        public decimal? price_purchase_rate { get; set; }

        [Column("price_value_per_pcs", Order = 9, TypeName = "decimal(18,2)")]
        public decimal? price_value_per_pcs { get; set; }

        [Column("price_avg_weight_per_pcs", Order = 10, TypeName = "decimal(18,2)")]
        public decimal? price_avg_weight_per_pcs { get; set; }

        [Column("price_opening_stock_rate", Order = 11, TypeName = "decimal(18,2)")]
        public decimal? price_opening_stock_rate { get; set; }

        [Column("opening_stock_shop", Order = 12, TypeName = "decimal(18,2)")]
        public decimal? opening_stock_shop { get; set; }

        [Column("stock_shop", Order = 13, TypeName = "decimal(18,2)")]
        public decimal? stock_shop { get; set; }

        [Column("opening_stock_godown", Order = 14, TypeName = "decimal(18,2)")]
        public decimal? opening_stock_godown { get; set; }

        [Column("stock_godown", Order = 15, TypeName = "decimal(18,2)")]
        public decimal? stock_godown { get; set; }

        [Column("total_stock", Order = 16, TypeName = "decimal(18,2)")]
        public decimal? total_stock { get; set; }


        [Column("item_type", Order = 17, TypeName = "text")]
        public string? item_type { get; set; }

        [Column("delete_at", Order = 18, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("item_packing_type", Order = 19, TypeName = "text")]
        public string? item_packing_type { get; set; }



    

        [Column("price_purchase_discount_percentage", Order = 22, TypeName = "float")]
        public double? price_purchase_discount_percentage { get; set; }

        [Column("price_purchase_discount_amt", Order = 23, TypeName = "float")]
        public double? price_purchase_discount_amt { get; set; }

        [Column("price_purchase_amount_after_discount", Order = 24, TypeName = "float")]
        public double? price_purchase_amount_after_discount { get; set; }

        [Column("price_purchase_packing_cost", Order = 25, TypeName = "float")]
        public double? price_purchase_packing_cost { get; set; }

        [Column("price_purchase_packing_cost_incl_yn", Order = 26, TypeName ="text")]
        public string? price_purchase_packing_cost_incl_yn { get; set; }

        [Column("price_purchase_amount_with_packing_cost", Order = 27, TypeName = "float")]
        public double? price_purchase_amount_with_packing_cost { get; set; }

        [Column("price_purchase_gst_percentage", Order = 28, TypeName = "float")]
        public double? price_purchase_gst_percentage { get; set; }

        [Column("price_purchase_gst_amount", Order = 29, TypeName = "float")]
        public double? price_purchase_gst_amount { get; set; }

        [Column("price_purchase_amount_with_gst", Order = 30, TypeName = "float")]
        public double? price_purchase_amount_with_gst { get; set; }

        [Column("price_purchase_margin_profit_percentage", Order = 31, TypeName = "float")]
        public double? price_purchase_margin_profit_percentage { get; set; }

        [Column("price_purchase_margin_profit_amount", Order = 32, TypeName = "float")]
        public double? price_purchase_margin_profit_amount { get; set; }

        [Column("price_purchase_rate_approx", Order = 33, TypeName = "float")]
        public double? price_purchase_rate_approx { get; set; }







        [Column("price_sell_rate", Order = 34, TypeName = "float")]
        public double? price_sell_rate { get; set; }

        [Column("price_sell_discount_percentage", Order = 35, TypeName = "float")]
        public double? price_sell_discount_percentage { get; set; }

        [Column("price_sell_discount_amount", Order = 36, TypeName = "float")]
        public double? price_sell_discount_amount { get; set; }

        [Column("price_sell_amount_after_discount", Order = 37, TypeName = "float")]
        public double? price_sell_amount_after_discount { get; set; }

        [Column("price_sell_gst_percentage", Order = 38, TypeName = "float")]
        public double? price_sell_gst_percentage { get; set; }

        [Column("price_sell_gst_amount", Order = 39, TypeName = "float")]
        public double? price_sell_gst_amount { get; set; }

        [Column("price_sell_amount_with_gst", Order = 40, TypeName = "float")]
        public double? price_sell_amount_with_gst { get; set; }

        [Column("item_barcode_no", Order = 41, TypeName = "text")]
        public string? item_barcode_no { get; set; }

        [Column("item_remark_no", Order = 42, TypeName = "text")]
        public string? item_remark_no { get; set; }

        [Column("purchase_unit_name", Order = 43, TypeName = "text")]
        public string? purchase_unit_name { get; set; }

        [Column("purchase_unit_qty", Order = 44, TypeName = "float")]
        public double? purchase_unit_qty { get; set; }

        [Column("sale_unit_name", Order = 45, TypeName = "text")]
        public string? sale_unit_name { get; set; }





        [Column("item_min_qty", Order = 46, TypeName = "float")]
        public double? item_min_qty { get; set; }

        [Column("item_reorder_qty", Order = 47, TypeName = "float")]
        public double? item_reorder_qty { get; set; }

        [Column("item_max_qty", Order = 48, TypeName = "float")]
        public double? item_max_qty { get; set; }




        [Column("created_at", Order = 49, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 50, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;






        public ICollection<ItemTransStockDetail>? ItemTransStockDetail { get; set; }
        public ICollection<ItemTransMixDetail>? ItemTransMixDetail { get; set; }
        public ICollection <AggrementMaster>? AggrementMaster { get; set; }
        public ICollection<IssueReceiptTransDetail>? ChallanTransDetail { get; set; }

        public ICollection<Remark_Upload_Detail>? Remark_Upload_Detail { get; set; }


    }
}
