using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class FaqMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<FaqMaster>? FaqMasterData { get; set; }
        public FaqMaster? FaqMasterDataByID { get; set; }
    }
}
