using DB.Login.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RTA.Masters.Models
{
    public class FormMasterReq
    {

        public int id { get; set; }
        public int form_id { get; set; }

        public string? form_name { get; set; }
        public string? form_table { get; set; }
        public string? form_type { get; set; }
        public string form_created_type { get; set; } = "Auto";

        public int form_for_id { get; set; } = 0;
        public string? form_for { get; set; }
        public string? form_significance { get; set; }
        public string? form_title { get; set; }
        public string? form_sub_title { get; set; }
        public string? form_save { get; set; }
        public string form_head { get; set; }

        public string? form_groups { get; set; }
        public string form_groups_hidden { get; set; }
        public DateTime form_created_on { get; set; }
        public DateTime form_updated_on { get; set; }
        public string form_verification { get; set; }

        public int form_status { get; set; } = 1;  // 1=Active, 0=Inactive

        public string form_search_control_name { get; set; } = "forms/view_list";
        public string form_view_control_name { get; set; } = "view_form";
        public string? docu_form_for { get; set; }
        public string? docu_form_type { get; set; }
        public string? sub_cate { get; set; }
        public string? segm { get; set; }
        public string? gran_acce_to_prof { get; set; }
        public string grant_access_profile { get; set; } = "Admin";
        public string form_display_in_dashboard { get; set; } = "Yes";
        public string? form_group { get; set; }
        public string? active_section { get; set; }
        public string? stock_field_name { get; set; }
        public string form_have_stock_item { get; set; } = "No";
        public string? stock_field_name_2 { get; set; }
        public string? stock_field_display_name { get; set; }
        public string quick_menu_yn { get; set; } = "No";
        public string quick_link_menu_yn { get; set; } = "No";
        public string? stock_field_name_4_min_inventory { get; set; }
        public long? user_id { get; set; }
        public string? user_profile { get; set; }
        public string? user_name { get; set; }
        public long? user_mobile { get; set; }

    }
}
