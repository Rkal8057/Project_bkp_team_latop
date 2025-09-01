using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class VoucherMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<vou_list_master>? vou_list_masterData { get; set; }
        public List<vou_master>? vou_masterData { get; set; }
        public vou_master? vou_masterByID { get; set; }
    }
}
