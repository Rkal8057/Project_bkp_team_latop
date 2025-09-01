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
    public class PortfolioMasterReq
    {
        public string? portfolio_image { get; set; }
        public long? id { get; set; }
        public long? position { get; set; }



    }
}
