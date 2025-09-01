using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class CommonMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public bool duplicate { get; set; }

        public List <balance_sheet_master> ? BalanceSheetMasterData { get; set; }
      
    }
}
