using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class PortfolioMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("portfolio_image", Order = 2, TypeName = "text")]
        public string? portfolio_image { get; set; }

        [Column("created_at", Order = 3, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 4, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

        [Column("position", Order = 18, TypeName = "bigint")]
        public long? position { get; set; }

    }
}
