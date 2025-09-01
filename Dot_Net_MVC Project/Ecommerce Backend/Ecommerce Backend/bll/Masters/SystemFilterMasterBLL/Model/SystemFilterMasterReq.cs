using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SystemFilterMasterReq
    {
        public string? filter_name { get; set; }
        public string? filter_key { get; set; }

        public List<FilterArrayData>? FilterArrayData { get; set; }
        public List<DeleteFilterArrayData>? DeleteFilterArrayData { get; set; }
    }


    public class FilterArrayData
    {
        public long? id { get; set; }
        public string? filter_data { get; set; }
    }

    public class DeleteFilterArrayData
    {
        public long? id { get; set; }
        public string? filter_data { get; set; }
    }
}
