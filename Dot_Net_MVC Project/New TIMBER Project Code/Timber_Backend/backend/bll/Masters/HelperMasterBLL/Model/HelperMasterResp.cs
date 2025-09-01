using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class HelperMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<HelperMaster>? HelperMasterData { get; set; }
        public HelperMaster? HelperMasterByID { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }


        public List<State_Master>? State_Master { get; set; }


    }
}
