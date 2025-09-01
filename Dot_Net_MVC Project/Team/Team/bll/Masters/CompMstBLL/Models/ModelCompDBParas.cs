using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;


namespace RTA.Masters.Models
{
    public class ModelCompDBParas
    {
        public string userId {get;set;}
        public string password {get;set;}
        public string server_ip {get;set;}  

        //public virtual Comp_Selection_Master Comp_Selection_Master { get; set; }

    }
}