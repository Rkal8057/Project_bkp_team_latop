using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelReqResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Req_Rec_Master>? ReqData { get; set; }
        public Req_Rec_Master? ReqDatabyId { get; set; }
    }
}
