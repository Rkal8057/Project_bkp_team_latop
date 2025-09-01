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
    public class ActivityMasterReq
    {
        public string? activity_name { get; set; }
        public long? activity_name_id { get; set; }
        public long? user_id { get; set; }
        public DateTime? activity_date { get; set; }
        public string? activity_time { get; set; }
        public string? activity_duration { get; set; }
        public string? activity_note { get; set; }
        public string? activity_end_time { get; set; }
        public string? activity_start_time { get; set; }

        public string? activity_maintain_type { get; set; }


        public List<ActivityMasterTransReq> ActivityMasterTransReq { get; set; }

    }

    public class ActivityMasterTransReq
    {
        public long id { get; set; }
        public string? slot_start { get; set; }
        public string? slot_end { get; set; }
        public string? activity_detail { get; set; }
        public long? activity_detail_id { get; set; }
        public string? remark { get; set; }
        public string? duration { get; set; }
        public string? activity_default_remark { get; set; }

    }
}
