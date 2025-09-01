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
    public class ReturnMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("order_returnable", Order = 1, TypeName = "text")]
        public string? order_returnable { get; set; }

        [Column("order_returnable_time", Order = 2, TypeName = "datetime")]
        public DateTime? order_returnable_time { get; set; }

        [Column("order_returnable_received", Order = 3, TypeName = "text")]
        public string? order_returnable_received { get; set; }

        [Column("order_returnable_received_time", Order = 4, TypeName = "datetime")]
        public DateTime? order_returnable_received_time { get; set; }

        [Column("order_refund", Order = 5, TypeName = "text")]
        public string? order_refund { get; set; }

        [Column("order_refund_time", Order = 6, TypeName = "datetime")]
        public DateTime? order_refund_time { get; set; }

        [Column("order_courier_receipt_image", Order = 7, TypeName = "text")]
        public string? order_courier_receipt_image { get; set; }

        [ForeignKey("OrderItemMaster"), Column("order_item_id", Order = 8, TypeName = "bigint")]
        public long? order_item_id { get; set; }

        [Column("created_on", Order = 9, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 10, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("order_return_status", Order = 11, TypeName = "bigint")]
        public OrderReturnStatus? order_return_status { get; set; } = OrderReturnStatus.OrderReturnable;

        [Column("order_courier_name", Order = 12, TypeName = "text")]
        public string? order_courier_name { get; set; }

        [Column("order_courier_pod_no", Order = 13, TypeName = "text")]
         public string? order_courier_pod_no { get; set; }

        [Column("product_to_be_returned_by", Order = 14, TypeName = "text")]
        public string? product_to_be_returned_by { get; set; }

        [Column("order_cancel_reason", Order = 15, TypeName = "text")]
        public string? order_cancel_reason { get; set; }

        [Column("order_cancel_option", Order = 16, TypeName = "text")]
        public string? order_cancel_option { get; set; }

        public virtual OrderItemMaster? OrderItemMaster { get; set; }
    }


    public enum OrderReturnStatus
    {
        OrderReturnable = 5,
        OrderReturnableReceived = 6,
        OrderRefundable= 7
    }
}
