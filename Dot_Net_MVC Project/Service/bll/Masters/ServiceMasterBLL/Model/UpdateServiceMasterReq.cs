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
    public class UpdateServiceMasterReq
    {
        public string? service_name { get; set; }
        public ICollection<CategoryMaster>? CategoryMaster { get; set; }

    }
}
