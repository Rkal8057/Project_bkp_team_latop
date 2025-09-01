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
    public class CompanyDetailReq
    {
        public string? company_name { get; set; }
        public string? company_address { get; set; }
        public string? company_city { get; set; }
        public string? company_pincode { get; set; }
        public string? company_country { get; set; }
        public string? company_email { get; set; }
        public string? company_phone { get; set; }
        public ICollection<HelperDetail>? HelperDetail { get; set; }

    }

}
