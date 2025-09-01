using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class Bill_Rent_MasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Bill_Rent_Master> ? Bill_Rent_MasterData { get; set; }
        public Bill_Rent_Master ? Bill_Rent_MasterById { get; set; }
        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }

        public long? lastId { get; set; }


        public List<IssueReceiptMaster>? issueReceiptMasters { get; set; }
    }
}
