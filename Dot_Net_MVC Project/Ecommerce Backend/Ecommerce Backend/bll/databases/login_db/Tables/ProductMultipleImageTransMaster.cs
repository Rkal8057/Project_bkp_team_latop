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
    public class ProductMultipleImageTransMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("img_url", Order = 1, TypeName = "text")]
        public string? img_url { get; set; }

        [ForeignKey("ProductMaster"), Column("product_id", Order = 2, TypeName = "bigint")]
        public long? product_id { get; set; }

        public virtual ProductMaster? ProductMaster { get; set; }

    }
}
