using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class StyleMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("background_color", Order = 2, TypeName = "text")]
        public string? background_color { get; set; }

        [Column("link_color", Order = 3, TypeName = "text")]
        public string? link_color { get; set; }

        [Column("header_top_color", Order = 4, TypeName = "text")]
        public string? header_top_color { get; set; }

        [Column("header_bottom_color", Order = 5, TypeName = "text")]
        public string? header_bottom_color { get; set; }

        [Column("text_color", Order = 6, TypeName = "text")]
        public string? text_color { get; set; }

        [Column("header_text_color", Order = 7, TypeName = "text")]
        public string? header_text_color { get; set; }

        [Column("review_hover_color", Order = 8, TypeName = "text")]
        public string? review_hover_color { get; set; }

        [Column("review_content_background_color", Order = 9, TypeName = "text")]
        public string? review_content_background_color { get; set; }

        [Column("review_style", Order = 10, TypeName = "text")]
        public string? review_style { get; set; }



        [Column("contact_background_color", Order = 11, TypeName = "text")]
        public string? contact_background_color { get; set; }

        [Column("footer_background_color", Order = 12, TypeName = "text")]
        public string? footer_background_color { get; set; }

        [Column("contact_us_style", Order = 13, TypeName = "text")]
        public string? contact_us_style { get; set; }

        [Column("footer_style", Order = 14, TypeName = "text")]
        public string? footer_style { get; set; }

        [Column("theme_color", Order = 15, TypeName = "text")]
        public string? theme_color { get; set; }

        [Column("service_style", Order = 16, TypeName = "text")]
        public string? service_style { get; set; }

        [Column("chooseus_style", Order = 17, TypeName = "text")]
        public string? chooseus_style { get; set; }

        [Column("created_at", Order = 18, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 19, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

    }
}
