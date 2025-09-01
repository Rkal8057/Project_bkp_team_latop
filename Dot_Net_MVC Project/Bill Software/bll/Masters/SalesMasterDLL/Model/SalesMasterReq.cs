using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SalesMasterReq
    {
        public DateTime? sales_date { get; set; }
        public string? completion_flag { get; set; }
        public decimal? grand_total { get; set; }
        public long? mobile_number { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? address { get; set; }
        //public ICollection<SalesrxMaster> SalesTrxMaster { get; set; }
    }
}
