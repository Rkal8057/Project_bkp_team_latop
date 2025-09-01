using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class ProductTransMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("product_filter_name", Order = 1, TypeName = "text")]
        public string? product_filter_name { get; set; }

        [Column("product_filter_data", Order = 2, TypeName = "text")]
        public string? product_filter_data { get; set; }

        [Column("product_item_stock", Order = 3, TypeName = "text")]
        public string? product_item_stock { get; set; }

        [ForeignKey("ProductMaster"), Column("product_id", Order = 4, TypeName = "bigint")]
        public long? product_id { get; set; }

        [Column("created_on", Order = 3, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 4, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }
        public virtual ProductMaster? ProductMaster { get; set; }
    }
}
