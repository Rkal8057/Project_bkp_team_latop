using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelComplaintMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Complaint_Master>? Complaint_MasterData { get; set; }
        public Complaint_Master? Complaint_MasterDataByID { get; set; }
        public int? TotalCount { get; set; }
        public int?  TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int?  PageSize { get; set; }
    }
}
