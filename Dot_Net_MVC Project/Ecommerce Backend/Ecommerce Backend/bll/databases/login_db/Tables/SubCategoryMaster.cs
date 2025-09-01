using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class SubCategoryMaster
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

        [Column("sub_category_name", Order = 8, TypeName = "text")]
        public string? sub_category_name { get; set; }

        [ForeignKey("CategoryMaster"),Column("parent_category_id", Order = 9, TypeName = "bigint")]
        public long? parent_category_id { get; set; }

        [Column("parent_category_name", Order = 10, TypeName = "text")]
        public string? parent_category_name { get; set; }

        [Column("sub_heading", Order = 11, TypeName = "text")]
        public string? sub_heading { get; set; }

        [Column("sub_category_status", Order = 12, TypeName = "bigint")]
        public long? sub_category_status { get; set; } = 0;

        [Column("deleted", Order = 13, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("username", Order = 14, TypeName = "text")]
        public string? username { get; set; }

        [Column("created_on", Order = 15, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 16, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }



        [JsonIgnore]
        public virtual CategoryMaster ? CategoryMaster { get; set; }

        public ICollection<ProductMaster> ProductMaster { get; set; }
    }


}
