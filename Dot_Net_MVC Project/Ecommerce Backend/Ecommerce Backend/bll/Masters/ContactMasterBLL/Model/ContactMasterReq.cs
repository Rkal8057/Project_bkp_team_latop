using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ContactMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }
        public string? client_purchaser_name { get; set; }
        public long? agent_code { get; set; }
        public string? agent_name { get; set; }
        public long? vender_code { get; set; }
        public string? vender_name { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? email { get; set; }
        public string? phn_no { get; set; }
        public string? subject { get; set; }
        public string? message { get; set; }
        public string? seen_status { get; set; }
        public DateTime? sent_on { get; set; }
    }
}
