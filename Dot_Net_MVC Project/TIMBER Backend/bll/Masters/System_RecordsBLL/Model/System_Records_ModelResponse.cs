using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class System_Records_ModelResponse
    {        
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<System_Records>? Data { get; set; }
        public System_Records System_RecordsDataById { get; set; }

    }
}

