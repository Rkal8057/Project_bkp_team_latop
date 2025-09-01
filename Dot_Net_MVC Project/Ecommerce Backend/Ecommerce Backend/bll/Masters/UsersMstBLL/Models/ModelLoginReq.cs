using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTA.Admin.Models
{
    public class ModelLoginReq
    {
        public ModelLoginReq()
        {
            user_email="xyz@gmail.com";
            user_pass="";
            auth_type="profile_type";
        }
       public string user_email { get; set; }
       public string user_pass { get; set; }
       public string auth_type { get; set; }
       
    }
}