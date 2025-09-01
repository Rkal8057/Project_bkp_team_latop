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
    public class ItemMasterReq
    {
        public string? item_name { get; set; }
        public long? category_id { get; set; }
        public string? item_type { get; set; }
        public long? item_amount { get; set; }
    }
}
