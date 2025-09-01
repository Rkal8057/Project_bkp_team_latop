using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ContactMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<ContactMaster>? ContactMasterData { get; set; }
        public ContactMaster? ContactMasterDataByID { get; set; }
    }
}
