using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace RTA.Masters.Models
{
    public class ModelIsr3Req
    {
        public string? company_name { get; set; }
        public string? company_address { get; set; }
        public string? company_email { get; set; }
        public string? company_phone { get; set; }
        public string? descriptions1 { get; set; }
        public string? descriptions2 { get; set; }
        public string? descriptions3 { get; set; }

        public virtual ICollection<Isr_3_securities>? Isr_3_securities { get; set; }
    }
}
