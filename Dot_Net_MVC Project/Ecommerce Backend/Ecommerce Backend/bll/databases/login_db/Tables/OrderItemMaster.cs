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
    public class OrderItemMaster
    {

        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("unique_trn_id", Order = 1, TypeName = "bigint")]
        public long? unique_trn_id { get; set; } = 0;

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

        [ ForeignKey("OrderMaster"),Column("order_id", Order = 8, TypeName = "bigint")]
        public long? order_id { get; set; }

        [Column("product_id", Order = 9, TypeName = "bigint")]
        public long? product_id { get; set; }

        [Column("quantity", Order = 10, TypeName = "bigint")]
        public long? quantity { get; set; }

        [Column("sub_total", Order = 11, TypeName = "bigint")]
        public long? sub_total { get; set; }

        [Column("status", Order = 12, TypeName = "bigint")]
        public long? status { get; set; } = 0;

        [Column("deleted", Order = 13, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("img_url", Order = 14, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("username", Order = 15, TypeName = "text")]
        public string? username { get; set; }

        [Column("product_price", Order = 16, TypeName = "bigint")]
        public long? product_price { get; set; }

        [Column("product_title", Order = 16, TypeName = "text")]
        public string? product_title { get; set; }


        [Column("product_returnable", Order = 17, TypeName = "text")]
        public string? product_returnable { get; set; }

        [Column("product_to_be_returned_by", Order = 18, TypeName = "text")]
        public string? product_to_be_returned_by { get; set; }


        [Column("created_on", Order = 19, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 20, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }


        [JsonIgnore]
        public virtual OrderMaster ? OrderMaster { get; set; }
        public ICollection<ReturnMaster>? ReturnMaster { get; set; }

    }
}
