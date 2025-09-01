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
        public string? service_type { get; set; }
        public decimal? approx_amount { get; set; }
        public int? approx_days { get; set; }
        public ICollection<CheckListMaster>? CheckListMaster { get; set; }

    }
}
