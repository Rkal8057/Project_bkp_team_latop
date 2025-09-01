using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SubCategoryMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<SubCategoryMaster>? SubCategoryMasterData { get; set; }
        public SubCategoryMaster? SubCategoryMasterDataByID { get; set; }
    }
}
