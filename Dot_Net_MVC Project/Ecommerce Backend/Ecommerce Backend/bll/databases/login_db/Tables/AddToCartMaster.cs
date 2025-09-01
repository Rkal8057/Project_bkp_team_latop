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
    public class AddToCartMaster
    {
        [Key]
        [Column("add_to_cart_id", Order = 1, TypeName = "bigint")]
        public long add_to_cart_id { get; set; }

        [Column("id", Order = 2, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("comp_id", Order = 3, TypeName = "bigint")]
        public long? comp_id { get; set; }

        [Column("comp_name", Order = 4, TypeName = "text")]
        public string? comp_name { get; set; }

        [Column("product_category_id", Order = 5, TypeName = "bigint")]
        public long? product_category_id { get; set; }

        [Column("product_category", Order = 6, TypeName = "text")]
        public string? product_category { get; set; }

        [Column("product_sub_category_id", Order = 7, TypeName = "bigint")]
        public long? product_sub_category_id { get; set; }

        [Column("product_sub_category", Order = 8, TypeName = "text")]
        public string? product_sub_category { get; set; }

        [Column("product_title", Order = 9 , TypeName = "text")]
        public string? product_title { get; set; }

        [Column("product_description", Order = 10, TypeName = "text")]
        public string? product_description { get; set; }

        [Column("product_price", Order = 11, TypeName = "decimal(18, 2)")]
        public decimal? product_price { get; set; }

        [Column("product_del_price", Order = 12, TypeName = "decimal(18, 2)")]
        public decimal? product_del_price { get; set; }

        [Column("product_status", Order = 13, TypeName = "bigint")]
        public long? product_status { get; set; }

        [Column("product_store_qty", Order = 14, TypeName = "bigint")]
        public long? product_store_qty { get; set; }

        [Column("quantity", Order = 15, TypeName = "bigint")]
        public long? quantity { get; set; }

        [Column("img_url", Order = 16, TypeName = "text")]
        public string? img_url { get; set; }

        [Column("created_on", Order = 17, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 18, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("deleted", Order = 19, TypeName = "bigint")]
        public long? deleted { get; set; }

        [Column("user_id", Order = 20, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("username", Order = 21, TypeName = "text")]
        public string? username { get; set; }

        [Column("unique_trn_id", Order = 22, TypeName = "bigint")]
        public long? unique_trn_id { get; set; }


        [Column("product_purchasing_price", Order = 23, TypeName = "bigint")]
        public long? product_purchasing_price { get; set; }

        [Column("product_commission_received_in", Order = 24, TypeName = "text")]
        public string? product_commission_received_in { get; set; }

        [Column("product_commission_percentage", Order = 25, TypeName = "decimal(18,2)")]
        public decimal? product_commission_percentage { get; set; }

        [Column("product_commission_amt", Order = 26, TypeName = "decimal(18,2)")]
        public decimal? product_commission_amt { get; set; }

        [Column("product_points_earned", Order = 27, TypeName = "decimal(18,2)")]
        public decimal? product_points_earned { get; set; }

        [Column("product_returnable", Order = 28, TypeName = "text")]
        public string? product_returnable { get; set; }

        [Column("product_to_be_returned_by", Order = 29, TypeName = "text")]
        public string? product_to_be_returned_by { get; set; }
    }
}
