using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ProductMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public string? vender_name { get; set; }
        public long? vender_code { get; set; }
        public string? agent_name { get; set; }
        public long? agent_code { get; set; }
        public string? product_title { get; set; }
        public long? product_price { get; set; }
        public long? product_del_price { get; set; }
        public string? product_category { get; set; }
        public long? product_sub_category_id { get; set; }
        public string? product_sub_category { get; set; }
        public long? product_category_id { get; set; }
        public string? product_description { get; set; }
        public string? product_content { get; set; }
        public string? img_url { get; set; }
        public string? username { get; set; }
        public string? user_id { get; set; }
        public string? comp_name { get; set; }
        public long? comp_id { get; set; }
        public long? product_store_qty { get; set; }


        public string? product_to_be_returned_by { get; set; }
        public string? product_returnable { get; set; }
        public long? product_purchasing_price { get; set; }
        public string? product_commission_received_in { get; set; }
        public decimal? product_commission_percentage { get; set; }
        public decimal? product_commission_amt { get; set; }
        public decimal? product_points_earned { get; set; }
    
        public List<DeletedImages>? deletedImages { get; set; }
        public List<ProductMultipleImageTransKey> ? productMultipleImageTransMaster { get; set; }
        public List<ProductItemArray>? ProductItemArray { get; set; }
        public List<ProductDeleteItemArray>? ProductDeleteItemArray { get; set; }

    }

    public class  ProductMultipleImageTransKey {
        public long? id { get; set; }
        public string? img_url { get; set; }
    }

    public class DeletedImages
    {
        public long? id { get; set; }
        public long? product_id { get; set; }
        public string? img_url { get; set; }
    }


    public class ProductItemArray
    {
        public long? id { get; set; }
        public string? product_item_stock { get; set; }
        public string? product_filter_data { get; set; }
        public string? product_filter_name { get; set; }
    }


    public class ProductDeleteItemArray
    {
        public long? id { get; set; }
        public string? product_item_stock { get; set; }
        public string? product_filter_data { get; set; }
        public string? product_filter_name { get; set; }

    }
}
