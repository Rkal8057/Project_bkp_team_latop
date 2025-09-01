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
    public class DisplayeMenu
    {
        public string? subMenuName { get; set; }
        public string? icon { get; set; }
        public string? href { get; set; }
        public List<MenuItem>?  subMenuItems { get; set; }

    }
    public class MenuItem
    {
        public string? title { get; set; }
        public string? href { get; set; }
        public string? icon { get; set; }
    }
}
