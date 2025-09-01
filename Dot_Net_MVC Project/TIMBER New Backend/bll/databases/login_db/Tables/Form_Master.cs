using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class Form_Master
    {
        [Key, Column("id", Order = 0, TypeName = "bigint(10) auto_increment"), Required]
        public long? id { get; set; }


        [Column("form_id", Order = 1, TypeName = "int(10)")]
 
        public int form_id { get; set; }

        [Column("form_name", Order = 2, TypeName = "varchar(255)")]
        public string? form_name { get; set; }

        [Column("form_table", Order = 3, TypeName = "varchar(90)")]
        public string? form_table { get; set; }

        [Column("form_type", Order = 4, TypeName = "varchar(100)")]
        public string? form_type { get; set; }

        [Column("form_created_type", Order = 5, TypeName = "varchar(20)")]
        public string form_created_type { get; set; } = "Auto";

        [Column("form_for_id", Order = 6, TypeName = "int(10)")]
        public int form_for_id { get; set; } = 0;

        [Column("form_for", Order = 7, TypeName = "varchar(100)")]
        public string? form_for { get; set; }

        [Column("form_significance", Order = 8, TypeName = "varchar(255)")]
        public string? form_significance { get; set; }

        [Column("form_title", Order = 9, TypeName = "varchar(255)")]
        public string? form_title { get; set; }

        [Column("form_sub_title", Order = 10, TypeName = "varchar(255)")]
        public string? form_sub_title { get; set; }

        [Column("form_save", Order = 11, TypeName = "varchar(100)")]
        public string? form_save { get; set; }

        [Required]
        [Column("form_head", Order = 12, TypeName = "varchar(255)")]
        public string form_head { get; set; }

        [Column("form_groups", Order = 13, TypeName = "varchar(255)")]
        public string? form_groups { get; set; }

        [Required]
        [Column("form_groups_hidden", Order = 14, TypeName = "varchar(255)")]
        public string form_groups_hidden { get; set; }

        
        [Column("form_created_on", Order = 15, TypeName = "datetime")]
        public DateTime form_created_on { get; set; }

       
        [Column("form_updated_on", Order = 16, TypeName = "datetime")]
        public DateTime form_updated_on { get; set; }

        [Required]
        [Column("form_verification", Order = 17, TypeName = "varchar(50)")]
        public string form_verification { get; set; }

        [Column("form_status", Order = 18, TypeName = "int(2)")]
        public int form_status { get; set; } = 1;  // 1=Active, 0=Inactive

        [Column("form_search_control_name", Order = 19, TypeName = "varchar(100)")]
        public string form_search_control_name { get; set; } = "forms/view_list";

        [Column("form_view_control_name", Order = 20, TypeName = "varchar(100)")]
        public string form_view_control_name { get; set; } = "view_form";

        [Column("docu_form_for", Order = 21, TypeName = "varchar(255)")]
        public string? docu_form_for { get; set; }

        [Column("docu_form_type", Order = 22, TypeName = "varchar(255)")]
        public string? docu_form_type { get; set; }

        [Column("sub_cate", Order = 23, TypeName = "varchar(255)")]
        public string? sub_cate { get; set; }

        [Column("segm", Order = 24, TypeName = "varchar(255)")]
        public string? segm { get; set; }

        [Column("gran_acce_to_prof", Order = 25, TypeName = "text")]
        public string? gran_acce_to_prof { get; set; }

        [Column("grant_access_profile", Order = 26, TypeName = "varchar(255)")]
        public string grant_access_profile { get; set; } = "Admin";

        [Column("form_display_in_dashboard", Order = 27, TypeName = "varchar(3)")]
        public string form_display_in_dashboard { get; set; } = "Yes";

        [Column("form_group", Order = 28, TypeName = "text")]
        public string? form_group { get; set; }

        [Column("active_section", Order = 29, TypeName = "text")]
        public string? active_section { get; set; }

        [Column("stock_field_name", Order = 30, TypeName = "varchar(255)")]
        public string? stock_field_name { get; set; }

        [Column("form_have_stock_item", Order = 31, TypeName = "varchar(3)")]
        public string form_have_stock_item { get; set; } = "No";

        [Column("stock_field_name_2", Order = 32, TypeName = "varchar(255)")]
        public string? stock_field_name_2 { get; set; }

        [Column("stock_field_display_name", Order = 33, TypeName = "varchar(255)")]
        public string? stock_field_display_name { get; set; }

        [Column("quick_menu_yn", Order = 34, TypeName = "varchar(3)")]
        public string quick_menu_yn { get; set; } = "No";

        [Column("quick_link_menu_yn", Order = 35, TypeName = "varchar(3)")]
        public string quick_link_menu_yn { get; set; } = "No";

        [Column("stock_field_name_4_min_inventory", Order = 36, TypeName = "text")]
        public string? stock_field_name_4_min_inventory { get; set; }


        [Column("user_id", Order = 37, TypeName = "bigint(20)")]
        public long? user_id { get; set; }

        [Column("user_profile", Order = 38, TypeName = "varchar(100)")]
        public string? user_profile { get; set; }

        [Column("user_name", Order = 39, TypeName = "varchar(100)")]
        public string? user_name { get; set; }

        [Column("user_mobile", Order = 40, TypeName = "bigint(10)")]
        public long? user_mobile { get; set; }

    }
}
