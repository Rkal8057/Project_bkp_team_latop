using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Admin.Models
{ 
    public class ModelUserMultiAddReq
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string? m_form_name { get; set; }
        public string? m_address { get; set; }
        public string? m_city { get; set; }
        public string? m_pin_code { get; set; }
        public string? m_country { get; set; }
        public string? m_address_type { get; set; }
    }
}
