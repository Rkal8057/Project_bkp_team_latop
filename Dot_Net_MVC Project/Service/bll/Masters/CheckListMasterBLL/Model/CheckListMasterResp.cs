using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class CheckListMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<CheckListMaster>? CheckListMasterDetailData { get; set; }
        public CheckListMaster? CheckListMasterDetailByID { get; set; }
    }
}
