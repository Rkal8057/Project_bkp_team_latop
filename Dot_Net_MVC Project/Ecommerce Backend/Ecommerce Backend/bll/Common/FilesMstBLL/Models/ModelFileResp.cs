using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.RTAComp.Tables;

namespace RTA.Common.Models
{
    public class ModelFileResp
    {
        public bool status { get; set; }
        public string Message { get; set; }
        public List<Files_Master>? fileList { get; set; }
        public Files_Master fileData { get; set; }
        public List<ModelBenposReader>? benposData { get; set; }
    }


}