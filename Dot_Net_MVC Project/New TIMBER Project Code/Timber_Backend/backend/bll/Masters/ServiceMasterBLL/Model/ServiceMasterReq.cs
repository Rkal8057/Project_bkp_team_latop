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
    public class ServiceMasterReq
    {
        public string? service_name { get; set; }
        public long? item_category_main_id { get; set; }


        public string? service_type { get; set; }
        public long? item_category_sub_id { get; set; }

        public decimal? approx_amount { get; set; }
        public int? approx_days { get; set; }
        public string? commission_type { get; set; }
        public string? commission_percentage { get; set; }
        public string? commission_amt { get; set; }


        public string? cashback_amt { get; set; }
        public string? cashback_percentage { get; set; }
        public string? cashback_type { get; set; }
        public ICollection<CheckListMaster>? CheckListMaster { get; set; }

    }
}
