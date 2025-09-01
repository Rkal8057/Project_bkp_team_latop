using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class LocationMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Location_Master>? LocationMasterDetailData { get; set; }
        public Location_Master? LocationMasterDetailByID { get; set; }
       
    }
}
