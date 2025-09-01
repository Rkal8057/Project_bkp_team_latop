using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class BusinessUserDetailResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<BusinessUserDetail>? BusinessUserDetailData { get; set; }
        public BusinessUserDetail? BusinessUserDetailByID { get; set; }

        public string dataa { get; set; }

        public Object BusinessSectionDataByIDType { get; set; }


    }
}
