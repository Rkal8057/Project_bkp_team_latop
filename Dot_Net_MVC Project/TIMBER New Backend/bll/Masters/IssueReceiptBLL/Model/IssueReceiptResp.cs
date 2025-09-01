using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class IssueReceiptResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<IssueReceiptMaster>? IssueReceiptMasterDetailData { get; set; }
        public IssueReceiptMaster? IssueReceiptMasterDetailByID { get; set; }
            
        public long? lastId { get; set; }


        public List<IssueReceiptBreakageTransDetail>? IssueReceiptBreakageTransDetail { get; set; }


    }
}
