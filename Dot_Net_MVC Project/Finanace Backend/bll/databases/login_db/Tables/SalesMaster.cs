using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class SalesMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("sales_date", Order = 2, TypeName = "datetime")]
        public DateTime? sales_date { get; set; }

        [Column("name", Order = 3, TypeName = "text")]
        public string? name { get; set; }

        [Column("email", Order = 4, TypeName = "text")] 
        public string? email { get; set; }

        [Column("address", Order = 5, TypeName = "text")] 
        public string? address { get; set; }

        [Column("mobile_number", Order = 6, TypeName = "bigint")] 
        public long? mobile_number { get; set; }

        [Column("completion_flag", Order = 7, TypeName = "text")]
        public string? completion_flag { get; set; }

        [Column("grand_total", Order = 8, TypeName = "decimal(18, 2)")]
        public decimal? grand_total { get; set; }




        [Column("discount_percentage", Order = 9, TypeName = "decimal(18, 2)")]
        public decimal? discount_percentage { get; set; }

        [Column("discount_amount", Order = 10, TypeName = "decimal(18, 2)")]
        public decimal? discount_amount { get; set; }

        [Column("grand_total_after_discount", Order = 11, TypeName = "decimal(18, 2)")]
        public decimal? grand_total_after_discount { get; set; }

        public ICollection<SalesTrxMaster> SalesTrxMaster { get; set; }
    }
}
