using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;


namespace RTA.Admin.Models
{
    public class ModelUserResp
    {
        public bool status {get;set;}
        public string? Message {get;set;}
        public User_Detail? User_Detail {get;set;}
    }
}