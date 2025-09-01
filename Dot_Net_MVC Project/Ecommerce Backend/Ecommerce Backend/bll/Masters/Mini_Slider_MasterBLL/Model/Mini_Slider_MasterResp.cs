using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class Mini_Slider_MasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Mini_Slider_Master>? Mini_Slider_MasterData { get; set; }
        public Mini_Slider_Master? Mini_Slider_MasterDataByID { get; set; }
    }
}
