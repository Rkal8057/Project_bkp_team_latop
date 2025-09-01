using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RTA.Masters.Models
{
    public class ModelSh14Resp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Sh_14>? Sh_14Data { get; set; }
        public Sh_14? Sh_14DataByID { get; set; }
    }
}
