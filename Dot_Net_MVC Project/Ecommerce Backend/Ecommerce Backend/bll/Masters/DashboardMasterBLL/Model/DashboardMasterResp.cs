using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class DashboardMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public decimal? tot_REVENUE{ get; set;}
        public long? tot_ORDER { get; set; }
        public long? tot_PRODUCT { get; set; }
        public long? tot_CUSTOMER { get; set; }
        public long? tot_VISITORS { get; set; }

        public List<PaymentMaster> PaymentMaster {  get; set; }
        public List<PaymentByMonthResponse> PaymentAmountByMonth { get; set; }
    }

    public class PaymentByMonthResponse
    {
        public int Month { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
