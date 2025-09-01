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
    public class FormMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Form_Master>? FormMasterData { get; set; }
        public Form_Master? FormMasterDataByID { get; set; }
        public List<DisplayeMenu>? DisplayeMenus { get; set; }
    }
}
