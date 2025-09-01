using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class KYCDetailResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<KYCDetail>? KYCDetailData { get; set; }
        public KYCDetail? KYCDetailByID { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }

    }

  
}
