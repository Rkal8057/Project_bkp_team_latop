using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ActivityNameMasterReq
    {
        public string? activity_name { get; set; }
        public string? activity_flag { get; set; }
    }
}
