using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Login.Tables;

namespace RTA.Common.Models
{
    public class ModelAuth
    {
        public User_Detail User {get; set;}
        public List<Forms_Trx_Master>? UserRights {get; set;}
        public User_Profile_Master? UserProfileRights {get; set;}
        public string auth_type {get; set;}

        public bool? status {get; set;}
        public string? message {get; set;}
    }
}