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
    public class CategoryTranxMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("filter_name", Order = 1, TypeName = "text")]
        public string? filter_name { get; set; }

        [ForeignKey("CategoryMaster") ,Column("category_id", Order = 2, TypeName = "bigint")]
        public long? category_id { get; set; }

        [Column("created_on", Order = 3, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 4, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        public virtual CategoryMaster? CategoryMaster { get; set; }
    }
}
