using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class AddToCartMasterReq
    {
        public long? id { get; set; }
        public long? comp_id { get; set; }
        public string? comp_name { get; set; }
        public long? product_category_id { get; set; }
        public string? product_category { get; set; }
        public long? product_sub_category_id { get; set; }
        public string? product_sub_category { get; set; }
        public string? product_title { get; set; }
        public string? product_description { get; set; }
        public decimal product_price { get; set; }
        public decimal product_del_price { get; set; }
        public long? product_status { get; set; }
        public long? product_store_qty { get; set; }
        public long? quantity { get; set; }
        public string? img_url { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
        public long? deleted { get; set; }
        public long? user_id { get; set; }
        public string? username { get; set; }
        public long? unique_trn_id { get; set; }

        public string? product_to_be_returned_by { get; set; }
        public string? product_returnable { get; set; }
        public long? product_purchasing_price { get; set; }
        public string? product_commission_received_in { get; set; }
        public decimal? product_commission_percentage { get; set; }
        public decimal? product_commission_amt { get; set; }
        public decimal? product_points_earned { get; set; }
    }
}
