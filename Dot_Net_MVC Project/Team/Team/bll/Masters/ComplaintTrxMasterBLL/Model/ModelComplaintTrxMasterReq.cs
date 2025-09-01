using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RTA.Masters.Models
{
    public class ModelComplaintTrxMasterReq
    {
        public long? user_id { get; set; }
        public long? unique_complaint_id { get; set; }
        public string? reply_to { get; set; }
        public DateTime? reply_date { get; set; }
        public string? action_taken { get; set; }
        public string? action_remark { get; set; }
        public long? master_id { get; set; }
        public IFormFile? attached_file { get; set; }

    }
}
