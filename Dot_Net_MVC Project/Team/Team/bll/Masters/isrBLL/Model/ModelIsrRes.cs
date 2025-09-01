using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelIsr1Resp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<ISR_1>? Isr1Data { get; set; }
        public ISR_1? Isr1DataByID { get; set; }

    }
}
