using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ItemMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<ItemMaster>? ItemMasterDetailData { get; set; }
        public ItemMaster? ItemMasterDetailByID { get; set; }


        public AggrementMaster ? AggrementMaster { get; set; }
        public PartyItemRateTrans? PartyItemRateTrans { get; set; }

        public List<IssueReceiptMaster>? IssueReceiptTransDetail { get; set; }
        public List<IssueReceiptMaster>? IssueReceiptMaster { get; set; }
        public List<PartyMaster>? PartyMaster { get; set; }





        public int? TotalCount { get; set; }
        public int? TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
