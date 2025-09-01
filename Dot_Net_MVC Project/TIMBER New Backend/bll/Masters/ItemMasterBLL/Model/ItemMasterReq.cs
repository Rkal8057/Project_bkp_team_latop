using DB.Login;
using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ItemMasterReq
    {
        public long? id { get; set; }
        public string? item_short_name { get; set; }
        public string? item_name { get; set; }
        public string? group { get; set; }
        public long? group_id { get; set; }

        public string? hsn_code { get; set; }
        public string? tax_per { get; set; }
        public string? convertion_of_pcs { get; set; }
        public decimal? price_purchase_rate { get; set; }
        public decimal? price_value_per_pcs { get; set; }
        public decimal? price_avg_weight_per_pcs { get; set; }
        public decimal? price_opening_stock_rate { get; set; }
        public decimal? opening_stock_shop { get; set; }
        public decimal? stock_shop { get; set; }
        public decimal? opening_stock_godown { get; set; }
        public decimal? stock_godown { get; set; }
        public decimal? total_stock { get; set; }
        public string? item_type { get; set; }
        public string? item_packing_type { get; set; }


        public double? price_purchase_discount_percentage { get; set; }
        public double? price_purchase_discount_amt { get; set; }
        public double? price_purchase_amount_after_discount { get; set; }
        public double? price_purchase_packing_cost { get; set; }
        public string? price_purchase_packing_cost_incl_yn { get; set; }
        public double? price_purchase_amount_with_packing_cost { get; set; }
        public double? price_purchase_gst_percentage { get; set; }
        public double? price_purchase_gst_amount { get; set; }
        public double? price_purchase_amount_with_gst { get; set; }
        public double? price_purchase_margin_profit_percentage { get; set; }
        public double? price_purchase_margin_profit_amount { get; set; }
        public double? price_purchase_rate_approx { get; set; }



        public double? price_sell_rate { get; set; }
        public double? price_sell_discount_percentage { get; set; }
        public double? price_sell_discount_amount { get; set; }
        public double? price_sell_amount_after_discount { get; set; }
        public double? price_sell_gst_percentage { get; set; }
        public double? price_sell_gst_amount { get; set; }
        public double? price_sell_amount_with_gst { get; set; }
        public string? purchase_unit_name { get; set; }
        public double? purchase_unit_qty { get; set; }
        public string? sale_unit_name { get; set; }

        public string? item_remark_no { get; set; }
        public string? item_barcode_no { get; set; }


        public double? item_min_qty { get; set; }
        public double? item_reorder_qty { get; set; }
        public double? item_max_qty { get; set; }



        public string? warranty_yes_no { get; set; }
        public string? warranty_period { get; set; }
        public DateTime? item_date { get; set; }



        public List<ItemTransMixDetailKey>? ItemTransMixDetailKey { get; set;}
        public List<ItemTransMixDetailDeleteKey>? ItemTransMixDetailDeleteKey { get; set; }
        public List<ItemTransStockDetailKey>? ItemTransStockDetailKey { get; set; }
        public List<ItemTransStockDetailDeleteKey>? ItemTransStockDetailDeleteKey { get; set; }


        public List<Remark_Upload_Detail_Key>? Remark_Upload_Detail_Key { get; set; }

        public List<Remove_Remark_Upload_Detail_Key>? Remove_Remark_Upload_Detail_Key { get; set; }

    }

    public class ItemTransMixDetailKey
    {
        public long? id { get; set;}
        public string? item_name { get; set; }
        public decimal? item_qty { get; set; }
        public decimal? item_rate { get; set; }
        public string? item_type { get; set; }
    }


    public class ItemTransMixDetailDeleteKey
    {
        public long? id { get; set; }
        public string? item_name { get; set; }
        public decimal? item_qty { get; set; }
        public decimal? item_rate { get; set; }
        public string? item_type { get; set; }

    }

    public class ItemTransStockDetailKey
    {
        public long? id { get; set; }
        public DateTime? item_stock_date { get; set; }
        public string? item_stock_location { get; set; }
        public double? item_stock_qty { get; set; }
        public double? item_stock_rate { get; set; }
        public double? item_stock_value { get; set; }
        public long? item_master_id { get; set; }

        public string? item_batch_no { get; set; }
        public string? item_style { get; set; }
        public string? item_brand { get; set; }
        public string? item_color { get; set; }
        public string? item_agent { get; set; }
        public string? item_dealer { get; set; }

    }


    public class ItemTransStockDetailDeleteKey
    {
        public long? id { get; set; }
        public DateTime? item_stock_date { get; set; }
        public string? item_stock_location { get; set; }
        public double? item_stock_qty { get; set; }
        public double? item_stock_rate { get; set; }
        public double? item_stock_value { get; set; }
        public long? item_master_id { get; set; }

        public string? item_batch_no { get; set; }
        public string? item_style { get; set; }
        public string? item_brand { get; set; }
        public string? item_color { get; set; }
        public string? item_agent { get; set; }
        public string? item_dealer { get; set; }

    }

    public class Remark_Upload_Detail_Key
    {
        public long id { get; set; }
        public string? upload_document_path { get; set; }
        public string? remarks { get; set; }
        public string? attended_by { get; set; }

    }
    public class Remove_Remark_Upload_Detail_Key
    {
        public long id { get; set; }
        public string? upload_document_path { get; set; }
        public string? remarks { get; set; }
        public string? attended_by { get; set; }
    }

}
