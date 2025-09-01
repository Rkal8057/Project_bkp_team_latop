using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;
using RTA.Common.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RTA.Admin.Models
{
    public class ModelLoginResp
    {
        public bool status {get;set;}
        public string? Message {get;set;}
        public User_Detail? User {get;set;}
        public ModelAuthToken? AuthToken {get;set;}
    }
}