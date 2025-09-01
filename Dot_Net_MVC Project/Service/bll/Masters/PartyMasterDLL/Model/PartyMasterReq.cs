using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class PartyMasterReq
    {
        public string? name { get; set; }
        public string? address { get; set; }
        public long? mobile_number { get; set; }
        public string? email { get; set; }
        public long? pincode { get; set; }
    }
}
