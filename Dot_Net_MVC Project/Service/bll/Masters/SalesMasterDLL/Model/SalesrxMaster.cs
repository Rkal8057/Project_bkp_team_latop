using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SalesrxMaster
    {
        public string item_name { get; set; }
        public long item_qty { get; set; }
        public decimal item_rate { get; set; }
        public string item_type { get; set; }
        public decimal amount { get; set; }
    }
}
