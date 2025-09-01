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
    public class PartyCategoryMasterReq
    {
        public string? party_category_name { get; set; }
        public long? delete_at { get; set; }

    }
}
