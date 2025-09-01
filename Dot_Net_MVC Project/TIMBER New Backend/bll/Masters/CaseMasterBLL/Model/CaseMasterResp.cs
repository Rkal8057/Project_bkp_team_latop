using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class CaseMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<CaseMaster>? CaseMasterData { get; set; }
        public CaseMaster? CaseMasterByID { get; set; }

        public long? CaseNo { get; set; }
        public List<EMIDetail>? checkEMICompleted { get; set; }


    }
}
