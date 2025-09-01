using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class PartyAddressTransMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("party_address_1", Order = 1, TypeName = "text")]
        public string? party_address_1 { get; set; }

        [Column("party_address_2", Order = 2, TypeName = "text")]
        public string? party_address_2 { get; set; }

        [Column("party_pincode", Order = 3, TypeName = "bigint")]
        public long? party_pincode { get; set; }

        [Column("party_state", Order = 4, TypeName = "text")]
        public string? party_state { get; set; }

        [Column("party_country", Order = 5, TypeName = "text")]
        public string? party_country { get; set; }

        [Column("party_address_description", Order = 6, TypeName = "text")]
        public string? party_address_description { get; set; }

        [Column("party_gst_type", Order = 7, TypeName = "text")]
        public string? party_gst_type { get; set; }

        [Column("party_gst_code", Order = 8, TypeName = "text")]
        public string? party_gst_code { get; set; }

        [Column("party_gst_address_no", Order = 9, TypeName = "text")]
        public string? party_gst_address_no { get; set; }

        [ForeignKey("PartyMaster"), Column("party_master_id", Order = 10, TypeName = "bigint")]
        public long? party_master_id { get; set; }

        [Column("party_address_location", Order = 11, TypeName = "text")]
        public string? party_address_location { get; set; }

        [Column("delete_at", Order = 12, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        public virtual PartyMaster? PartyMaster { get; set; }
    }

}
