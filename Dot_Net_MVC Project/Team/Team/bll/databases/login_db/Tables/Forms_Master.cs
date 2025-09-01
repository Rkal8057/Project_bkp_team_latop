using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    [Table("forms_master")]
    public class Forms_Master
    {
        [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
        public long id { get; set; }

        [Column("form_name", Order = 2, TypeName = "varchar(50)")]
        public string? form_name { get; set; }

        [Column("form_table", Order = 3, TypeName = "varchar(50)")]
         public string? form_table { get; set; }

        [Column("form_type", Order = 4, TypeName = "varchar(50)")]
        public string? form_type { get; set; }

        // [Column("form_created_type", Order = 5, TypeName = "varchar(50)")]
        // public string? form_created_type { get; set; }
        // [Column("form_for_id", Order = 6, TypeName = "varchar(50)")]
        // public int? form_for_id { get; set; }
        // [Column("form_for", Order = 7, TypeName = "varchar(50)")]
        // public string? form_for { get; set; }
        // [Column("form_significance", Order = 8, TypeName = "varchar(50)")]
        // public string? form_significance { get; set; }
        [Column("form_title", Order = 5, TypeName = "varchar(50)")]
        public string? form_title { get; set; }
        // [Column("form_sub_title", Order = 10, TypeName = "varchar(50)")]
        // public string? form_sub_title { get; set; }
        // [Column("form_save", Order = 11, TypeName = "varchar(50)")]
        // public string? form_save { get; set; }
        // [Column("form_head", Order = 12, TypeName = "varchar(50)")]
        // public string? form_head { get; set; }
        // [Column("c_comp_sno", Order = 13, TypeName = "varchar(50)")]
        // public string? form_groups { get; set; }
        // [Column("c_comp_sno", Order = 14, TypeName = "varchar(50)")]
        // public string? form_groups_hidden { get; set; }
        // [Column("c_comp_sno", Order = 14, TypeName = "varchar(50)")]
        // public DateTime? form_created_on { get; set; }
        // [Column("c_comp_sno", Order = 14, TypeName = "varchar(50)")]
        // public DateTime? form_updated_on { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? form_verification { get; set; }
        // public int? form_status { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? form_search_control_name { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? form_view_control_name { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? docu_form_for { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? docu_form_type { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? sub_cate { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? segm { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? gran_acce_to_prof { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? grant_access_profile { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? form_display_in_dashboard { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? form_group { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? active_section { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? stock_field_name { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? form_have_stock_item { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? stock_field_name_2 { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? stock_field_display_name { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? quick_menu_yn { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? quick_link_menu_yn { get; set; }
        // [Column("c_comp_sno", Order = 2, TypeName = "varchar(50)")]
        // public string? stock_field_name_4_min_Inventory { get; set; }

        [JsonIgnore]
       public virtual ICollection<Forms_Trx_Master> Forms_Trx_Masters { get; set; }
    }
}