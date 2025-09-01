using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class SliderMasterResp
    {
        public bool status { get; set; }
        public string? Message { get; set; }
        public List<Slider_Master>? Slider_MasterData { get; set; }
        public Slider_Master? Slider_MasterDataByID { get; set; }
    }
}
