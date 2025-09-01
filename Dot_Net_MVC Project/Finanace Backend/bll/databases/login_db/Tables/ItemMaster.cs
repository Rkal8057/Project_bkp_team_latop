using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class ItemMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_name", Order = 2, TypeName = "text")]
        public string? item_name { get; set; }

        [ForeignKey("CategoryMaster"), Column("category_id", Order = 3, TypeName = "bigint")]
        public long? category_id { get; set; }

        [Column("item_type", Order = 4, TypeName = "text")]
        public string? item_type { get; set; }

        [Column("item_amount", Order = 5, TypeName = "bigint")]
        public long? item_amount { get; set; }

        [Column("active", Order = 6, TypeName = "bit")]
        public bool? active { get; set; } = true;

        [Column("created_at", Order = 7, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("delete_at", Order = 8, TypeName = "bit")]
        public bool? delete_at { get; set; } = false;
        public virtual CategoryMaster? CategoryMaster { get; set; }
    }
}
