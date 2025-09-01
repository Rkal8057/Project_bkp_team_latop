using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class WarrantyExtendedReq
    {
        public long? id { get; set; }
        public long? item_code { get; set; }
        public long? party_code { get; set; }
        public DateTime warranty_start_date { get; set; }
        public DateTime warranty_end_date { get; set; }
        public string? warranty_period { get; set; }
        public string? coverage_details { get; set; }
        public decimal? warranty_cost { get; set; }
        public decimal? warranty_gst_percentage { get; set; }
        public decimal? warranty_gst_amount { get; set; }
        public decimal? warranty_final_amount { get; set; }
        public string? warranty_serial_no { get; set; }
        public long? issue_challan_single_item_id { get; set; }
        public List<IssueReceiptTransWarrantyArrayKeys>? IssueReceiptTransWarrantyArrayKeys { get; set; }

        ////  =====  reqired key word  =======  ////
        public long? challan_id { get; set; }
        public string? irflag { get; set; }
        public string? warranty_visit_slot { get; set; }

    }
    public class IssueReceiptTransWarrantyArrayKeys
    {
        public long id { get; set; }
        public string? warranty_serial_no { get; set; }
        public string? warranty_period { get; set; }
        public string? warranty_visit_slot { get; set; }
        public string? warranty_visit_date { get; set; }
        public string? warranty_visit_charge { get; set; }
        public long? challan_master_id { get; set; }
        public string? item_name { get; set; }
        public long? item_code { get; set; }
        public string? warranty_flag { get; set; }

    }

}
