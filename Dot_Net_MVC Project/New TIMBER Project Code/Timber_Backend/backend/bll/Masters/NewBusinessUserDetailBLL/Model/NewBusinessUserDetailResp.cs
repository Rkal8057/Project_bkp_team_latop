using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class NewBusinessUserDetailResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<BusinessUserDetail>? BusinessUserDetailData { get; set; }
        public BusinessUserDetail? BusinessUserDetailByID { get; set; }

        public string data { get; set; }

        public Object NewBusinessSectionDataByIDType { get; set; }


    }
}
