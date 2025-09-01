using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;

namespace RTA.Masters.Models
{
    public class ModelCompData
    {
        public bool status {get;set;}
        public string? Message {get;set;}
        public List<Comp_Selection_Master>? CompMasters {get;set;}
    }
}