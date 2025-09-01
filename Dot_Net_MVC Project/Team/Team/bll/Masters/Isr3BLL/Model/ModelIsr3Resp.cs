using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RTA.Masters.Models
{
    public class ModelIsr3Resp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Isr_3>? Isr3Data { get; set; }
        public Isr_3? Isr3DataByID { get; set; }
    }
}
