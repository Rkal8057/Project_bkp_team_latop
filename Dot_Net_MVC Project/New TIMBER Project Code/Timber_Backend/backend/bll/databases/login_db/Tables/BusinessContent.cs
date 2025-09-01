using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;

namespace DB.Login.Tables
{
    public class BusinessContent
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("type", Order = 2, TypeName = "text")]
        public string? type { get; set; }

        [Column("label", Order = 3, TypeName = "text")]
        public string? label { get; set; }

        [Column("value", Order = 4, TypeName = "text")]
        public string? value { get; set; }

        [Column("label_bold", Order = 5, TypeName = "text")]
        public string? label_bold { get; set; }

        [Column("value_bold", Order = 6, TypeName = "text")]
        public string? value_bold { get; set; }

        [Column("alignment", Order = 7, TypeName = "text")]
        public string? alignment { get; set; }

        [Column("icon", Order = 8, TypeName = "text")]
        public string? icon { get; set; }

        [Column("button_alignment", Order = 9, TypeName = "text")]
        public string? button_alignment { get; set; }

        [Column("content_position", Order = 10, TypeName = "text")]
        public string? content_position { get; set; }

        [Column("delete", Order = 11, TypeName = "bigint")]
        public long? delete { get; set; }

        [Column("business_section_name", Order = 12, TypeName = "text")]
        public string? business_section_name { get; set; }

        [Column("business_section_id", Order = 13, TypeName = "bigint")]
        public long? business_section_id { get; set; }

        [Column("business_user_detail_id", Order = 14, TypeName = "bigint")]
        public long? business_user_detail_id { get; set; }

        [Column("business_content_hide", Order = 15, TypeName = "bigint")]
        public long? business_content_hide { get; set; } = 0;

        [Column("content_flag", Order = 16, TypeName = "text")]
        public string? content_flag { get; set; }

        [Column("created_at", Order = 17, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 18, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

    }
}
