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
    public class PaymentMasterReq
    {
        public string? name { get; set; }
        public string? mobile_no { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public decimal? amount { get; set; }
        public string? payment_status { get; set; }
        public string? transaction_id { get; set; }
        public string? unique_ref_no { get; set; }
        public string? push_url { get; set; }
        public string? response_url { get; set; }
        public long? created_by { get; set; }
        public long? modify_by { get; set; }
        public DateTime? modified_date { get; set; }
        public DateTime? created_date { get; set; }
        public string? payment_mode { get; set; }
        public long? user_id { get; set; }
        public long? order_id { get; set; }

    }
}
