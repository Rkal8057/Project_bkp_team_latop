using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ServiceMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<ServiceMaster>? ServiceMasterDetailData { get; set; }
        public ServiceMaster? ServiceMasterDetailByID { get; set; }
        public List<ServiceMasterDTO>? ServiceMasterDTO { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }

    }

    public class ServiceMasterDTO
    {
        public ServiceMaster? ServiceMaster { get; set; }
        public CategoryMaster? CategoryMaster { get; set; }
        public CheckListMaster[] ? CheckListMaster { get; set; }
    }
}
