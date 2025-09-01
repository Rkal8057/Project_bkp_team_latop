using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace RTA.Masters.Models
{
    public class ModelComplaintMasterReq
    {
        public long? user_id { get; set; }
        public long? user_code { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public long? phone { get; set; }
        public string? subject { get; set; }
        public string? complaint_description { get; set; }
        public IFormFile? attached_file { get; set; }
    }

    public class ModelComplaintMasterUpdateReq
    {
        public string? nature_of_complaint { get; set; }
        public string? nature_of_complaint_detail { get; set; }
        public string? nature_of_complaint_remark { get; set; }
        public string? status { get; set; }

    }


}
