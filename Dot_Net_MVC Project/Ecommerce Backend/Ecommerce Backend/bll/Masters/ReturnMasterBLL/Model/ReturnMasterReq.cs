using DB.Login.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ReturnMasterReq
    {
        public long? order_item_id { get; set; }
        public string? order_returnable { get; set; }
        public DateTime? order_returnable_time { get; set; }
        public string? order_returnable_received { get; set; }
        public DateTime? order_returnable_received_time { get; set; }
        public string? order_refund { get; set; }
        public DateTime? order_refund_time { get; set; }
        public string? order_courier_receipt_image { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
        public OrderReturnStatus? order_return_status { get; set; }
        public string? order_courier_name { get; set; }
        public string? order_courier_pod_no { get; set; }
        public string? product_to_be_returned_by { get; set; }
        public string? order_cancel_reason { get; set; }
        public string? order_cancel_option { get; set; }
    }
}
