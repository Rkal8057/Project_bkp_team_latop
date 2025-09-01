using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RTA.Masters.Models
{
    public class ModelSh13Resp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Sh_13>? Sh_13Data { get; set; }
        public Sh_13? Sh_13DataByID { get; set; }
    }
}
