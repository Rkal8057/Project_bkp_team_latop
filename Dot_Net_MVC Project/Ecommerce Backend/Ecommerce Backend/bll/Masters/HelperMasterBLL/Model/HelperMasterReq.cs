using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class HelperMasterReq
    {
        public string? form_name { get; set; }
        public string? field_name { get; set; }
        public string? field_data { get; set; }
        public long? deleted { get; set; }
        public DateTime? created_on { get; set; }
        public DateTime? updated_on { get; set; }
    }
}
