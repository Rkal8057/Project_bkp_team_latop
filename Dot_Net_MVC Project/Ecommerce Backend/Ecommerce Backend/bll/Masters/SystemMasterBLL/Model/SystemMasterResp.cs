using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SystemMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<SystemMaster>? SystemMasterData { get; set; }
        public SystemMaster? SystemMasterDataByID { get; set; }
    }
}
