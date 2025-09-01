using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelReq
    {
        public long req_id { get; set; }
        public string ?req_status { get; set; }  
        public string ?reject_code { get; set; }
    }
}
