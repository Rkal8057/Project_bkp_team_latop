using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class ReviewMaster
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

        [Column("vendor_code", Order = 6, TypeName = "bigint")]
        public long? vendor_code { get; set; }

        [Column("vendor_name", Order = 7, TypeName = "text")]
        public string? vendor_name { get; set; }

        [Column("rating_stars", Order = 8, TypeName = "bigint")]
        public long? rating_stars { get; set; }

        [Column("product_review", Order = 9, TypeName = "text")]
        public string? product_review { get; set; }

        [Column("deleted", Order = 10, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [ForeignKey("ProductMaster") , Column("product_id", Order = 11, TypeName = "bigint")]
        public long? product_id { get; set; }

        [ForeignKey("User_Detail"), Column("user_id", Order = 12, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("created_on", Order = 13, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 14, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }


        [JsonIgnore]
        public virtual ProductMaster? ProductMaster { get; set; }

        [JsonIgnore]
        public virtual User_Detail? User_Detail { get; set; }
    }
}
