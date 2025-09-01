using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ModelSampleResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Sample_Detail>? SampleData { get; set; }
        public Sample_Detail? SampleDataByID { get; set; }
    }
}
