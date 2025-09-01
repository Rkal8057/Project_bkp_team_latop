using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class PaymentMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<PaymentMaster>? PaymentMasterData { get; set; }
        public PaymentMaster? PaymentMasterDataByID { get; set; }
    }
}
