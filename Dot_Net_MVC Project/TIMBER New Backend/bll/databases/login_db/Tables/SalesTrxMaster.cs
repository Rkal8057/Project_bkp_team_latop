using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class SalesTrxMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("item_name", Order = 3, TypeName = "text")]
        public string? item_name { get; set; }

        [Column("item_qty", Order = 4, TypeName = "bigint")]
        public long? item_qty { get; set; }

        [Column("item_rate", Order = 5, TypeName = "decimal(18, 2)")]
        public decimal? item_rate { get; set; }

        [Column("item_type", Order = 6, TypeName = "text")]
        public string? item_type { get; set; }

        [Column("item_amount", Order = 7, TypeName = "decimal(18, 2)")]
        public decimal? item_amount { get; set; }

        [ForeignKey("SalesMaster"),Column("sales_master_id", Order = 8, TypeName = "bigint")]
        public long? sales_master_id { get; set; }
        
        [JsonIgnore]    
        public virtual SalesMaster SalesMaster { get; set; }

    }
}
