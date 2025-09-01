using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class EMIDetail
    {
        [Key]
        [Column("id", Order = 0, TypeName = "bigint")]
        public long Id { get; set; }

        [Column("emi_PaymentDate", Order = 1, TypeName = "date")]
        public DateTime? emi_PaymentDate { get; set; }

        [Column("emi_Monthly_Amount", Order = 2, TypeName = "text")]
        public string? emi_Monthly_Amount { get; set; }

        [Column("emi_Interest_Amount", Order = 3, TypeName = "text")]
        public string? emi_Interest_Amount { get; set; }

        [Column("emi_Monthly_Interest_Amount", Order = 4, TypeName = "text")]
        public string? emi_Monthly_Interest_Amount { get; set; }

        [Column("emi_Status", Order = 5, TypeName = "text")]
        public string? emi_Status { get; set; } = "Pending";// Completed

        [ForeignKey("CaseMaster"), Column("Case_Master_id", Order = 6, TypeName = "bigint")]
        public long? Case_Master_id { get; set; }

        [JsonIgnore]
        public virtual CaseMaster? CaseMaster { get; set; }
    }
}
