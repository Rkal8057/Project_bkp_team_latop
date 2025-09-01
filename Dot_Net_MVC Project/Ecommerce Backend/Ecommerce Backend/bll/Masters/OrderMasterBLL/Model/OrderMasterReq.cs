using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class OrderMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public long? customer_id { get; set; }
        public double? grand_total { get; set; }
        public OrderStatus? order_status { get; set; }
        public string? img_url { get; set; }
        public string? username { get; set; }


        public string? order_processing_done { get; set; }
        public DateTime? order_shipping_time { get; set; }

        public string? order_packing_done { get; set; }
        public DateTime? order_packing_time { get; set; }

        public string? order_delivery_done { get; set; }
        public DateTime? order_delivery_time { get; set; }


        public string? order_cancel_done { get; set; }
        public DateTime? order_cancel_time { get; set; }
        public string? order_cancel_reason { get; set; }
        public string? order_cancel_option { get; set; }
        public string? order_cancel_by { get; set; }


        public string? order_user_name { get; set; }
        public string? order_user_address { get; set; }
        public string? order_user_pincode { get; set; }
        public string? order_user_address_type { get; set; }
        public string? order_user_city { get; set; }
        public string? order_user_country { get; set; }

        public List<OrderItemMasterKey> ?OrderItemMasterKey { get; set; }
    }


    public class OrderItemMasterKey
    {
        public long? id { get; set; }
        public long? unique_trn_id { get; set; } = 0;
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
       // public long? order_id { get; set; }
        public long? product_id { get; set; }
        public long? quantity { get; set; }
        public long? sub_total { get; set; }
        public long? status { get; set; } = 0;
        public long? deleted { get; set; } = 0;
        public string? img_url { get; set; }
        public string? username { get; set; }
        public long? product_price { get; set; }
        public string ? product_title { get; set; }

        public string? product_returnable { get; set; }
        public string? product_to_be_returned_by { get; set; }

    }
}
