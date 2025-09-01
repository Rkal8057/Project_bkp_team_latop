using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTA.Common.Models
{
    public class ModelAuthToken
    {
        public long token_id { get; set; }
        public string token_data { get; set;}

        //public string? userRights { get; set;}
    }
}