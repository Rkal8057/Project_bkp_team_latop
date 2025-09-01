using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class PowerAttorney
    {
        [Key, Column("id", Order = 1, TypeName = "bigint auto_increment")]
        public long id { get; set; }

        [Column("foliono_auto_id", Order = 0, TypeName = "bigint")]
        public long? foliono_auto_id { get; set; }

        [Column("foliono_number", Order = 1, TypeName = "decimal(18, 0)")]
        public decimal? foliono_number { get; set; }

        [Column("foliono", Order = 2, TypeName = "text")]
        public string? foliono { get; set; }

        [Column("folio_id", Order = 3, TypeName = "text")]
        public string? folio_id { get; set; }

        [Column("old_folio_no_id", Order = 4, TypeName = "text")]
        public string? old_folio_no_id { get; set; }

        [Column("power_attorney_exist_YN", Order = 5, TypeName = "text")]
        public string? power_attorney_exist_YN { get; set; }

        [Column("power_attorney_TrfNo", Order = 6, TypeName = "text")]
        public string? power_attorney_TrfNo { get; set; }

        [Column("power_attorney_Date", Order = 7, TypeName = "date")]
        public DateTime? power_attorney_Date { get; set; }

        [Column("power_attorney_Name", Order = 8, TypeName = "text")]
        public string? power_attorney_Name { get; set; }

        [Column("power_attorney_Type", Order = 9, TypeName = "text")]
        public string? power_attorney_Type { get; set; }

        [Column("power_attorney_PanNo", Order = 10, TypeName = "text")]
        public string? power_attorney_PanNo { get; set; }

        [Column("power_attorney_Relation", Order = 11, TypeName = "text")]
        public string? power_attorney_Relation { get; set; }

        [Column("power_attorney_F_M_W_Name", Order = 12, TypeName = "text")]
        public string? power_attorney_F_M_W_Name { get; set; }

        [Column("power_attorney_Dob", Order = 13, TypeName = "date")]
        public DateTime? power_attorney_Dob { get; set; }

        [Column("power_attorney_M_F", Order = 14, TypeName = "text")]
        public string? power_attorney_M_F { get; set; }

        [Column("power_attorney_Add1", Order = 15, TypeName = "text")]
        public string? power_attorney_Add1 { get; set; }

        [Column("power_attorney_Add2", Order = 16, TypeName = "text")]
        public string? power_attorney_Add2 { get; set; }

        [Column("power_attorney_City", Order = 17, TypeName = "text")]
        public string? power_attorney_City { get; set; }

        [Column("power_attorney_Pincode", Order = 18, TypeName = "text")]
        public string? power_attorney_Pincode { get; set; }

        [Column("power_attorney_State", Order = 19, TypeName = "text")]
        public string? power_attorney_State { get; set; }

        [Column("power_attorney_Country", Order = 20, TypeName = "text")]
        public string? power_attorney_Country { get; set; }

        [Column("power_attorney_Email", Order = 21, TypeName = "text")]
        public string? power_attorney_Email { get; set; }

        [Column("power_attorney_Phone", Order = 22, TypeName = "text")]
        public string? power_attorney_Phone { get; set; }

        [ForeignKey("HolderDetail"), Column("holder_detail_id", Order = 56, TypeName = "bigint")]
        public long? holder_detail_id { get; set; }

        [JsonIgnore]
        public virtual HolderDetail? HolderDetail { get; set; }
    }
}