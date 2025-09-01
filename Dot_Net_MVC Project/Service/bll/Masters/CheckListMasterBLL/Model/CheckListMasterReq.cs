using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class CheckListMasterReq
    {
        public string? document_required_name {get; set;}
        public string? document_required_type { get; set;}
        public long? category_id { get; set;}
    }
}
