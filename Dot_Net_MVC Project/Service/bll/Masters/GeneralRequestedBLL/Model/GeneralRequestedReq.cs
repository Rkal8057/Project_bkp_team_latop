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
    public class GeneralRequestedReq
    {
        public long? user_id { get; set; }
        public long? service_id { get; set; }
        public long? category_id { get; set; }
        public ICollection<ProcessRequestDetail>? ProcessRequestDetail { get; set; }
    }
}
