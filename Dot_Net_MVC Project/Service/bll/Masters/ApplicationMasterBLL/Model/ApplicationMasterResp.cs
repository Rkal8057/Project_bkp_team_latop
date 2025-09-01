
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
    public class ApplicationMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<ApplicationMaster>? ApplicationMasterDetailData { get; set; }
        public ApplicationMaster? ApplicationMasterDetailByID { get; set; }
        public string? DocsFile { get; set; }
    }
}


