using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class ProductMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("unique_trn_id", Order = 1, TypeName = "bigint")]
        public long? unique_trn_id { get; set; }

        [Column("client_purchaser_code", Order = 2, TypeName = "bigint")]
        public long? client_purchaser_code { get; set; }

        [Column("client_purchaser_name", Order = 3, TypeName = "text")]
        public string? client_purchaser_name { get; set; }

        [Column("vender_name", Order = 4, TypeName = "text")]
        public string? vender_name { get; set; }

        [Column("vender_code", Order = 5, TypeName = "bigint")]
        public long? vender_code { get; set; }

        [Column("agent_name", Order = 6, TypeName = "text")]
        public string? agent_name { get; set; }

        [Column("agent_code", Order = 7, TypeName = "bigint")]
        public long? agent_code { get; set; } = 0;

        [Column("product_title", Order = 8, TypeName = "text")]
        public string? product_title { get; set; }

        [Column("product_price", Order = 9, TypeName = "bigint")]
        public long? product_price { get; set; }

        [Column("product_del_price", Order = 10, TypeName = "bigint")]
        public long? product_del_price { get; set; }

        [Column("product_category", Order = 11, TypeName = "text")]
        public string? product_category { get; set; }

        [ForeignKey("SubCategoryMaster"), Column("product_sub_category_id", Order = 12, TypeName = "bigint")]
        public long? product_sub_category_id { get; set; } = 0;

        [Column("product_sub_category", Order = 13, TypeName = "text")]
        public string? product_sub_category { get; set; }

        [ForeignKey("CategoryMaster"),Column("product_category_id", Order = 14, TypeName = "bigint")]
        public long? product_category_id { get; set; }

        [Column("product_description", Order = 15, TypeName = "text")]
        public string? product_description { get; set; }

        [Column("product_content", Order = 16, TypeName = "text")]
        public string? product_content { get; set; }

        [Column("product_status", Order = 17, TypeName = "bigint")]
        public long? product_status { get; set; } = 0;

        [Column("deleted", Order = 18, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("img_url", Order = 19, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("username", Order = 20, TypeName = "text")]
        public string? username { get; set; }

        [Column("user_id", Order = 21, TypeName = "varchar(45)")]
        public string? user_id { get; set; }

        [Column("comp_name", Order = 22, TypeName = "text")]
        public string? comp_name { get; set; }

        [Column("comp_id", Order = 23, TypeName = "bigint")]
        public long? comp_id { get; set; }

        [Column("created_on", Order = 24, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 25, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("product_store_qty", Order = 26, TypeName = "bigint")]
        public long? product_store_qty { get; set; }

        [Column("product_returnable", Order = 27, TypeName = "text")]
        public string? product_returnable { get; set; }

        [Column("product_to_be_returned_by", Order = 28, TypeName = "text")]
        public string? product_to_be_returned_by { get; set; }


        [Column("product_purchasing_price", Order = 29, TypeName = "bigint")]
        public long? product_purchasing_price { get; set; }

        [Column("product_commission_received_in", Order = 30, TypeName = "text")]
        public string? product_commission_received_in { get; set; }

        [Column("product_commission_percentage", Order = 31, TypeName = "decimal(18,2)")]
        public decimal? product_commission_percentage { get; set; }

        [Column("product_commission_amt", Order = 32, TypeName = "decimal(18,2)")]
        public decimal? product_commission_amt { get; set; }

        [Column("product_points_earned", Order = 33, TypeName = "decimal(18,2)")]
        public decimal? product_points_earned { get; set; }


        public virtual CategoryMaster ? CategoryMaster {  get; set; }
        public virtual SubCategoryMaster? SubCategoryMaster { get; set; }    
        public ICollection<ProductMultipleImageTransMaster>? ProductMultipleImageTransMaster { get; set; }
        public ICollection<ProductTransMaster>? ProductTransMaster { get; set; }
        public ICollection<ReviewMaster>? ReviewMaster { get; set; }

    }
}
