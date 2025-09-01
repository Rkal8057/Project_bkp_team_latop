using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;

namespace RTA.Common
{
    public class ModelCompDbData
    {
        public bool status { get; set; }
        public string? ErrorMessage { get; set; }
        public Comp_DB? comp_DB{ get; set; }
        
    }
}