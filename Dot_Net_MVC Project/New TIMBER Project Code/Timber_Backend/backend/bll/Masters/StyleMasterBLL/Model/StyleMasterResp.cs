using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class StyleMasterResp
    {        
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<StyleMaster>? StyleMaster { get; set; }
        public StyleMaster System_RecordsDataById { get; set; }

    }
}

