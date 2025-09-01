using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class ItemTransMixDetail
    {

        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_name", Order = 2, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("item_qty", Order = 3, TypeName = "decimal(18,2)")]
        public decimal? item_qty { get; set; }

        [Column("item_rate", Order = 4, TypeName = "decimal(18,2)")]
        public decimal? item_rate { get; set; }

        [Column("delete_at", Order = 5, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [ForeignKey("ItemMaster"),Column("item_master_id", Order = 6, TypeName = "bigint")]
        public long? item_master_id { get; set; }

        [Column("created_at", Order = 7, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 8, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

        [Column("item_type", Order = 9, TypeName = "text")]
        public string? item_type { get; set; }

        public virtual ItemMaster? ItemMaster { get; set; }
    }
}
