using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DB.Login.Tables
{
    public class PaymentMaster
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long? id { get; set; }

        [Column("name", Order = 2, TypeName = "text")]
        public string? name { get; set; }

        [Column("mobile_no", Order = 3, TypeName = "text")]
        public string? mobile_no { get; set; }

        [Column("address", Order = 4, TypeName = "text")]
        public string? address { get; set; }

        [Column("email", Order = 5, TypeName = "text")]
        public string? email { get; set; }

        [Column("amount", Order = 6, TypeName = "decimal(18,2)")]
        public decimal? amount { get; set; }

        [Column("payment_status", Order = 7, TypeName = "text")]
        public string? payment_status { get; set; }

        [Column("transaction_id", Order = 8, TypeName = "text")]
        public string? transaction_id { get; set; }

        [Column("unique_ref_no", Order = 9, TypeName = "text")]
        public string? unique_ref_no { get; set; }

        [Column("push_url", Order = 10, TypeName = "text")]
        public string? push_url { get; set; }

        [Column("response_url", Order = 11, TypeName = "text")]
        public string? response_url { get; set; }

        [Column("created_by", Order = 12, TypeName = "bigint")]
        public long? created_by { get; set; }

        [Column("modify_by", Order = 13, TypeName = "bigint")]
        public long? modify_by { get; set; }

        [Column("modified_date", Order = 14, TypeName = "datetime")]
        public DateTime? modified_date { get; set; }

        [Column("created_date", Order = 15, TypeName = "datetime")]
        public DateTime? created_date { get; set; }

        [Column("payment_mode", Order = 16, TypeName = "text")]
        public string? payment_mode { get; set; }

        [Column("user_id", Order = 17, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("order_id", Order = 18, TypeName = "bigint")]
        public long? order_id { get; set ; }

    }
}
