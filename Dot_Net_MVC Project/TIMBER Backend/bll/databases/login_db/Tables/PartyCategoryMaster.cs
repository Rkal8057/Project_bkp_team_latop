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
    public class PartyCategoryMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("party_category_name", Order = 2, TypeName = "text")]
        public string? party_category_name { get; set; }

        [Column("active", Order = 3, TypeName = "bigint")]
        public long? active { get; set; } = 0;

        [Column("created_at", Order = 4, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("delete_at", Order = 5, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

    }
}
