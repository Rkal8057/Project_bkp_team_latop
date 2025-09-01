using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class WarrantyExtendedResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }

        public List<WarrantyExtended>? WarrantyExtendedData { get; set; }
        public WarrantyExtended? WarrantyExtendedDataByID { get; set; }



        public IssueReceiptMaster ? IssueReceiptMasterData { get; set; }
        public List<IssueReceiptTransDetail>? IssueReceiptTransData { get; set; }
        public List<IssueReceiptTransWarrantyDetail>? IssueReceiptExtendedWarrantyTrans { get; set; }


        public IssueReceiptTransDetail? IssueReceiptTransById { get; set; }
        public List<IssueReceiptTransWarrantyDetail>? IssueReceiptTransWarrantyDetail { get; set; }


        public List<WarrantyExtendedItemWarrantyTrans>? WarrantyExtendedItemWarrantyTrans { get; set; }

        public long? lastId { get; set; }


    }
}
