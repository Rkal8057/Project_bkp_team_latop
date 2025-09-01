using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class OrderMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<OrderMaster>? OrderMasterData { get; set; }
        public List<OrderMaster>? OrderMasterPendingData { get; set; }

        public OrderMaster? OrderMasterDataByID { get; set; }
    }
}
