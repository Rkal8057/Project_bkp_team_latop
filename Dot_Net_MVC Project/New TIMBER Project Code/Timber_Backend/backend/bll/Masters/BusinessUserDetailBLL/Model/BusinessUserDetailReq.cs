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
    public class BusinessUserDetailReq
    {
        public long? id { get; set; }
        public string? user_name { get; set; }
        public string? user_title { get; set; }
        public string? user_company { get; set; }
        public string? user_ph { get; set; }
        public string? user_email { get; set; }
        public string? user_img { get; set; }
        public long? party_id { get; set; }
        public string? party_name { get; set; }
        public string? theme_color { get; set; }

        public List<BusinessSectionDataByIDType> BusinessSectionDataByIDType { get; set; }

    }

    public class BusinessSectionDataByIDType
    {
        public BussinessUserSectionDetail Section { get; set; }
        public List<BussinessUserContentDetail> Contents { get; set; }

    }

}
