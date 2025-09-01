using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class StyleMasterReq
    {
        public string? background_color { get; set; }
        public string? link_color { get; set; }
        public string? header_top_color { get; set; }
        public string? header_bottom_color { get; set; }
        public string? text_color { get; set; }
        public string? header_text_color { get; set; }
        public string? review_content_background_color { get; set; }
        public string? review_hover_color { get; set; }
        public string? review_style { get; set; }



        public string? contact_us_style { get; set; }
        public string? footer_style { get; set; }
        public string? contact_background_color { get; set; }
        public string? footer_background_color { get; set; }

        public string? theme_color { get; set; }
        public string? chooseus_style { get; set; }
        public string? service_style { get; set; }

    }

}

