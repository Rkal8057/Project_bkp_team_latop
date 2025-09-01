using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class ProductMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<CategoryMaster>? CategoryMasterData { get; set; }
        public List<ProductMaster>? ProductMasterData { get; set; }
        public ProductMaster? ProductMasterDataByID { get; set; }
    }
}
