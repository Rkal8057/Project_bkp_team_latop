using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ActivityNameMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<ActivityNameMaster>? ActivityNameMasterData { get; set; }
        public ActivityNameMaster? ActivityNameMasterByID { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
