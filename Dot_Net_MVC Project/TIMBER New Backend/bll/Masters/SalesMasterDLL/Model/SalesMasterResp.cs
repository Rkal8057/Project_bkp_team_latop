using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SalesMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<SalesMaster>? SalesMasterDetailData { get; set; }
        public SalesMaster? SalesMasterDetailByID { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
