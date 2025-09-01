using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class OrderMaster
    {

        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("unique_trn_id", Order = 1, TypeName = "bigint")]
        public long? unique_trn_id { get; set; } = 0;

        [Column("client_purchaser_code", Order = 2, TypeName = "bigint")]
        public long? client_purchaser_code { get; set; }

        [Column("client_purchaser_name", Order = 3, TypeName = "text")]
        public string? client_purchaser_name { get; set; }

        [Column("agent_code", Order = 4, TypeName = "bigint")]
        public long? agent_code { get; set; }

        [Column("agent_name", Order = 5, TypeName = "text")]
        public string? agent_name { get; set; }

        [Column("vender_code", Order = 6, TypeName = "bigint")]
        public long? vender_code { get; set; }

        [Column("vender_name", Order = 7, TypeName = "text")]
        public string? vender_name { get; set; }

        [Column("customer_id", Order = 8, TypeName = "bigint")]
        public long? customer_id { get; set; }

        [Column("grand_total", Order = 9, TypeName = "float(10,2)")]
        public double? grand_total { get; set; }

        [Column("order_status", Order = 10, TypeName = "bigint")]
        public OrderStatus? order_status { get; set; } = OrderStatus.Pending;

        [Column("deleted", Order = 11, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("img_url", Order = 12, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("username", Order = 13, TypeName = "text")]
        public string? username { get; set; }

        [Column("created_on", Order = 14, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 15, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("order_number", Order = 16, TypeName = "text")]
        public string? order_number { get; set; }


        [Column("order_shipping_done", Order = 17, TypeName = "text")]
        public string? order_shipping_done { get; set; }

        [Column("order_shipping_time", Order = 18, TypeName = "datetime")]
        public DateTime? order_shipping_time { get; set; }


        [Column("order_processing_done", Order = 19, TypeName = "text")]
        public string? order_processing_done { get; set; }

        [Column("order_processing_time", Order = 20, TypeName = "datetime")]
        public DateTime? order_processing_time { get; set; }


        [Column("order_delivery_done", Order = 21, TypeName = "text")]
        public string? order_delivery_done { get; set; }

        [Column("order_delivery_time", Order = 22, TypeName = "datetime")]
        public DateTime? order_delivery_time { get; set; }


        [Column("order_cancel_done", Order = 23, TypeName = "text")]
        public string? order_cancel_done { get; set; }

        [Column("order_cancel_time", Order = 24, TypeName = "datetime")]
        public DateTime? order_cancel_time { get; set; }

        [Column("order_cancel_reason", Order = 25, TypeName = "text")]
        public string? order_cancel_reason { get; set; }

        [Column("order_cancel_option", Order = 26, TypeName = "text")]
        public string? order_cancel_option { get; set; }

        [Column("order_cancel_by", Order = 27, TypeName = "text")]
        public string? order_cancel_by { get; set; }


        [Column("order_user_name", Order = 28, TypeName = "text")]
        public string? order_user_name { get; set; }

        [Column("order_user_address", Order = 29, TypeName = "text")]
        public string? order_user_address { get; set; }

        [Column("order_user_pincode", Order = 30, TypeName = "text")]
        public string? order_user_pincode { get; set; }

        [Column("order_user_address_type", Order = 31, TypeName = "text")]
        public string? order_user_address_type { get; set; }

        [Column("order_user_city", Order = 32, TypeName = "text")]
        public string? order_user_city { get; set; }

        [Column("order_user_country", Order = 33, TypeName = "text")]
        public string? order_user_country { get; set; }

        public ICollection<OrderItemMaster> OrderItemMasters { get; set; }  
    }

    public enum OrderStatus
    {
        Pending = 0,
        Processing = 1,
        Shipping = 2,
        Delivered = 3,
        Cancelled = 4
    }
   
}

