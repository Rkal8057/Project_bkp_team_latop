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
        public string? item_code { get; set; }
        public string? item_name { get; set; }
        public string? group { get; set; }
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

        public List<ItemTransMixDetailKey>? ItemTransMixDetailKey { get; set;}

        public List<ItemTransMixDetailDeleteKey>? ItemTransMixDetailDeleteKey { get; set; }

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

}
