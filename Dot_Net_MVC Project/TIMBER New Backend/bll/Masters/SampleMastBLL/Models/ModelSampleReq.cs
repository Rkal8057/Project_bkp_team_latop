using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelSampleReq
    {
        public string profession {get;set;}
        public string name {get;set;}
        public int phone {get;set;}
        public string email {get;set;}
        public string institute {get;set;}
        public string isActive {get;set;}
    }
}
