using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class BusinessSectionResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<BusinessSection>? BusinessSectionData { get; set; }
        public BusinessSection? BusinessSectionDataByID { get; set; }

        public List<BusinessContent>? BusinessContentData { get; set; }

        public Object BusinessSectionDataByIDType { get; set; }

    }


    public class BusinessSectionDataByIDType
    {
        public BusinessSection Section { get; set; }
        public List<BusinessContent> Contents { get; set; }
    }
}
