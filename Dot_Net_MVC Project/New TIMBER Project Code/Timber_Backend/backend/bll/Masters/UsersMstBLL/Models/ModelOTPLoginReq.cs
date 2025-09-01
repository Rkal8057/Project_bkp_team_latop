using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTA.Admin.Models
{
    public class ModelOTPLoginReq
    {
        public string Identifier { get; set; } // Email or phone number
        public string? Password { get; set; }
        public string? RecOtpOn { get; set; }
       
    }
}