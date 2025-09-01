using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class ItemTransStockDetail
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_stock_date", Order = 1, TypeName = "datetime")]
        public DateTime? item_stock_date { get; set; }

        [Column("item_stock_location", Order = 2, TypeName = "text")]
        public string? item_stock_location { get; set; }

        [Column("item_stock_qty", Order = 3, TypeName = "float")]
        public double? item_stock_qty { get; set; }
         
        [Column("item_stock_rate", Order = 4, TypeName = "float")]
        public double? item_stock_rate { get; set; }
         
        [Column("item_stock_value", Order = 5, TypeName = "float")]
        public double? item_stock_value { get; set; }

        [ForeignKey("ItemMaster"), Column("item_master_id", Order = 6, TypeName = "bigint")]
        public long? item_master_id { get; set; }



        [Column("item_batch_no", Order = 7  , TypeName = "text" )]
        public string? item_batch_no { get; set; }

        [Column("item_style", Order = 8 , TypeName = "text" )]
        public string? item_style { get; set; }

        [Column("item_brand", Order = 9 , TypeName = "text" )]
        public string? item_brand { get; set; }

        [Column("item_color", Order = 10 , TypeName = "text" )]
        public string? item_color { get; set; }

        [Column("item_agent", Order = 11, TypeName = "text" )]
        public string? item_agent { get; set; }

        [Column("item_dealer", Order = 12 , TypeName = "text" )]
        public string? item_dealer { get; set; }


        [Column("delete_at", Order = 13, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        public virtual ItemMaster? ItemMaster {  get; set; }


    }
}
