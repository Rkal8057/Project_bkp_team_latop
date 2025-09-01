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
    public class BusinessSection
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("title", Order = 2, TypeName = "text")]
        public string? title { get; set; }

        [Column("title_alignment", Order = 3, TypeName = "text")]
        public string? title_alignment { get; set; }

        [Column("title_bold", Order = 4, TypeName = "text")]
        public string? title_bold { get; set; }

        [Column("title_font_size", Order = 5, TypeName = "text")]
        public string? title_font_size { get; set; }

        [Column("section_position", Order = 6, TypeName = "text")]
        public string? section_position { get; set; }

        [Column("delete", Order = 7, TypeName = "bigint")]
        public long? delete { get; set; }

        [Column("business_user_detail_id", Order = 8, TypeName = "bigint")]
        public long? business_user_detail_id { get; set; }

        [Column("business_section_hide", Order = 9, TypeName = "bigint")]
        public long? business_section_hide { get; set; } = 0;

        [Column("section_multiple", Order = 10, TypeName = "text")]
        public string? section_multiple { get; set; }

        [Column("section_flag", Order = 11, TypeName = "text")]
        public string? section_flag { get; set; }

        [Column("created_at", Order = 12, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 13, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

    }
}
