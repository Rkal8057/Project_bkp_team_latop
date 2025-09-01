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
    public class BusinessUserDetail
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("user_name", Order = 2, TypeName = "text")]
        public string? user_name { get; set; }

        [Column("user_title", Order = 3, TypeName = "text")]
        public string? user_title { get; set; }

        [Column("user_company", Order = 4, TypeName = "text")]
        public string? user_company { get; set; }

        [Column("user_ph", Order = 5, TypeName = "text")]
        public string? user_ph { get; set; }

        [Column("user_email", Order = 6, TypeName = "text")]
        public string? user_email { get; set; }

        [Column("user_img", Order = 7, TypeName = "text")]
        public string? user_img { get; set; }

        [Column("party_id", Order = 8, TypeName = "bigint")]
        public long? party_id { get; set; }

        [Column("party_name", Order = 9, TypeName = "text")]
        public string? party_name { get; set; }

        [Column("theme_color", Order = 10, TypeName = "text")]
        public string? theme_color { get; set; }

        [Column("delete", Order = 11, TypeName = "bigint")]
        public long? delete { get; set; }

        [Column("user_profile_id", Order = 12, TypeName = "bigint")]
        public long? user_profile_id { get; set; }

        [Column("user_flag", Order = 13, TypeName = "text")]
        public string? user_flag { get; set; }

        [Column("created_at", Order = 14, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 15, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;
    }


}
