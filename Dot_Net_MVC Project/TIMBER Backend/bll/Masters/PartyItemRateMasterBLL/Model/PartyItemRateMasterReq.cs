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
    public class PartyItemRateMasterReq
    {

        public long id { get; set; }
        public string? pname { get; set; }
        public long? pcode { get; set; }
        public long? party_master_id { get; set; }
        public long? item_code { get; set; }
        public string? item_short_name { get; set; }
        public string? item_name { get; set; }
        public DateTime? agr_date { get; set; }
        public double? price_sell_rate { get; set; }
        public double? price_sell_discount_percentage { get; set; }
        public double? price_sell_discount_amount { get; set; }
        public double? price_sell_amount_after_discount { get; set; }
        public double? price_sell_gst_percentage { get; set; }
        public double? price_sell_gst_amount { get; set; }
        public double? price_sell_amount_with_gst { get; set; }
    }


}
