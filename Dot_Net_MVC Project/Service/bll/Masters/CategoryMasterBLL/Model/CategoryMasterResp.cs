using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class CategoryMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<CategoryMaster>? CategoryMasterDetailData { get; set; }
        public CategoryMaster? CategoryMasterDetailByID { get; set; }
    }
}
