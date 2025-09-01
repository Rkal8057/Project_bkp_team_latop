using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ReceiptMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<RecieptDetail>? RecieptDetailData { get; set; }
        public RecieptDetail? RecieptDetailByID { get; set; }
      
    }
}
