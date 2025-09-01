using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModalIsr2Resp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Isr_2>? Isr2Data { get; set; }
        public Isr_2? Isr2DataByID { get; set; }
    }
}
