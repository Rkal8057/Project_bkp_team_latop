using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTA.Admin.Models
{
    public class ModelOTPReq
    {
        public long? id { get; set; }
        public long UserRegistrationId { get; set; }
        public string? u_verification { get; set; }

        public string? u_purpose { get; set; }
        public string? u_otpno { get; set; }
    }
}
