using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class CorrespondenceRequestReq
    {
        public string? company_name { get; set; }
        public DateTime? reply_date { get; set; }
        public string? reject_yn { get; set; }
        public string? work_category { get; set; }
        public string? purpose { get; set; }
        public string? sender_name { get; set; }
        public string? sender_email { get; set; }
        public long? sender_mobile { get; set; }
        public string? status { get; set; }
    
    }
}
