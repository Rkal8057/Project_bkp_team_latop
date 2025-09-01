using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class CategoryMaster
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

        [Column("category_name", Order = 8, TypeName = "text")]
        public string? category_name { get; set; }

        [Column("category_status", Order = 9, TypeName = "bigint")]
        public long? category_status { get; set; } = 0;

        [Column("img_url", Order = 10, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("deleted", Order = 11, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("username", Order = 12, TypeName = "text")]
        public string? username { get; set; }

        [Column("created_on", Order = 13, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 14, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        public ICollection<SubCategoryMaster> subCategoryMasters { get; set; }

        public ICollection<CategoryTranxMaster> CategoryTranxMaster { get; set; }


    }
}
