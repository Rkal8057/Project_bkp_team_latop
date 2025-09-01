using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Admin.Models
{
    public class ModelUserMultiAddResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<UserMultiAddDetails>? MultiUserAddData { get; set; }
    }
}
