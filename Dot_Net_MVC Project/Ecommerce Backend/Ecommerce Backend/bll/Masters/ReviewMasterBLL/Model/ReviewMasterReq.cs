using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ReviewMasterReq
    {
        public long? unique_trn_id { get; set; }
        public long? client_purchaser_code { get; set; }

        public string? client_purchaser_name { get; set; }

        public long? agent_code { get; set; }

        public string? agent_name { get; set; }

        public long? vendor_code { get; set; }

        public string? vendor_name { get; set; }

        public long? rating_stars { get; set; }

        public string? product_review { get; set; }

        public long? product_id { get; set; }
        public long? user_id { get; set; }

        public DateTime? created_on { get; set; }

        public DateTime? updated_on { get; set; }

    }
}
