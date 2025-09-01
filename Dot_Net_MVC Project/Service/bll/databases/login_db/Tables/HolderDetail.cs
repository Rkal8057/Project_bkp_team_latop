using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class HolderDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint auto_increment")]
        public long id { get; set; }

        [Column("holder_fullname", Order = 2, TypeName = "text")]
        public string? holder_fullname { get; set; }

        [Column("holder_gender", Order = 3, TypeName = "text")]
        public string? holder_gender { get; set; }

        [Column("holder_dob", Order = 4, TypeName = "text")]
        public string? holder_dob { get; set; }

        [Column("holder_occupation", Order = 5, TypeName = "text")]
        public string? holder_occupation { get; set; }

        [Column("holder_fathername", Order = 6, TypeName = "text")]
        public string? holder_fathername { get; set; }

        [Column("holder_address1", Order = 7, TypeName = "text")]
        public string? holder_address1 { get; set; }

        [Column("holder_address2", Order = 8, TypeName = "text")]
        public string? holder_address2 { get; set; }

        [Column("holder_city", Order = 9, TypeName = "text")]
        public string? holder_city { get; set; }

        [Column("holder_state", Order = 10, TypeName = "text")]
        public string? holder_state { get; set; }

        [Column("holder_country", Order = 11, TypeName = "text")]
        public string? holder_country { get; set; }

        [Column("holder_email", Order = 12, TypeName = "text")]
        public string? holder_email { get; set; }

        [Column("holder_phone", Order = 13, TypeName = "text")]
        public string? holder_phone { get; set; }

        [Column("holder_pincode", Order = 14, TypeName = "text")]
        public string? holder_pincode { get; set; }

        [Column("holder_pincard", Order = 15, TypeName = "text")]
        public string? holder_pincard { get; set; }

        [Column("holder_kyc_updated", Order = 16, TypeName = "text")]
        public string? holder_kyc_updated { get; set; }

        [Column("holder_folio_no", Order = 17, TypeName = "text")]
        public string? holder_folio_no { get; set; }

        public ICollection<KYCDetail>? KYCDetail { get; set; }

        public ICollection<NomineeDetail>? NomineeDetail { get; set; }

        public ICollection<PowerAttorney>? PowerAttorney { get; set; }

    }
}
