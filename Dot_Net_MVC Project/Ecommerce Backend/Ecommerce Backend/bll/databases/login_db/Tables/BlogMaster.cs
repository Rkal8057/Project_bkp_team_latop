using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DB.Login.Tables
{
    public class BlogMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("unique_trn_id", Order = 1, TypeName = "bigint")]
        public long? unique_trn_id { get; set; }

        [Column("client_purchaser_code", Order = 2, TypeName = "bigint")]
        public long? client_purchaser_code { get; set; }

        [Column("client_purchaser_name", Order = 3, TypeName = "text")]
        public string? client_purchaser_name { get; set; }

        [Column("agent_code", Order = 4, TypeName = "bigint")]
        public long? agent_code { get; set; }

        [Column("agent_name", Order = 5, TypeName = "text")]
        public string? agent_name { get; set; }

        [Column("vender_code", Order = 6, TypeName = "bigint")]
        public long? vender_code { get; set; }

        [Column("vender_name", Order = 7, TypeName = "text")]
        public string? vender_name { get; set; }

        [Column("blog_title", Order = 8, TypeName = "text")]
        public string? blog_title { get; set; }

        [Column("blog_category", Order = 9, TypeName = "text")]
        public string? blog_category { get; set; }

        [Column("blog_category_id", Order = 10, TypeName = "text")]
        public string? blog_category_id { get; set; }

        [Column("blog_description", Order = 11, TypeName = "text")]
        public string? blog_description { get; set; }

        [Column("blog_content", Order = 12, TypeName = "text")]
        public string? blog_content { get; set; }

        [Column("blog_status", Order = 13, TypeName = "bigint")]
        public long? blog_status { get; set; } = 0;

        [Column("deleted", Order = 14, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("img_url", Order = 15, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("username", Order = 16, TypeName = "text")]
        public string? username { get; set; }

        [Column("created_on", Order = 17, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 18, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }
    }

}
