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
    public class ModelComplaintTrxMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Complaint_Trx_Master>? Complaint_Trx_MasterData { get; set; }
        public Complaint_Trx_Master? Complaint_Trx_MasterDataByID { get; set; }
    }
}
