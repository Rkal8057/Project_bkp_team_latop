using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class PortfolioMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<PortfolioMaster>? PortfolioMasterDetailData { get; set; }
        public PortfolioMaster? PortfolioMasterDetailByID { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
