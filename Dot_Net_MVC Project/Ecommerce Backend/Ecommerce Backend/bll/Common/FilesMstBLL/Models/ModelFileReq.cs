using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace RTA.Common.Models
{
    public class ModelFileReq
    {
       public IFormFile Files {get; set;}
    //    public string? store_file_name { get; set; }
        public long form_id { get; set; }
        public long? trx_id { get; set; }
        //public long user_id { get; set; }
        public DateTime? trx_date { get; set; }
    //    public string? store_path { get; set; }
        public long company_id { get; set; }
    //    public string? company_isin { get; set; }
    //    public string? company_name { get; set; }
      //  public string? dp_id { get; set; }
      //  public string? cl_id { get; set; }
      //  public string? phy_cdsl_nsdl { get; set; }

        
    }

}