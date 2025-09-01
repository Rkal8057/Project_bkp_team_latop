using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class PartyContactTransMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("party_contact_name", Order = 1, TypeName = "text")]
        public string? party_contact_name { get; set; }

        [Column("party_contact_mobile", Order = 2, TypeName = "text")]
        public string? party_contact_mobile { get; set; }

        [Column("party_contact_whatsapp_mobile", Order = 3, TypeName = "text")]
        public string? party_contact_whatsapp_mobile { get; set; }

        [Column("party_contact_email", Order = 4, TypeName = "text")]
        public string? party_contact_email { get; set; }

        [Column("party_contact_description", Order = 5, TypeName = "text")]
        public string? party_contact_description { get; set; }



        [Column("party_landline_no", Order = 6, TypeName = "text")]
        public string? party_landline_no { get; set; }



        [Column("party_contact_department", Order = 7, TypeName = "text")]
        public string? party_contact_department { get; set; }

        [Column("party_contact_designation", Order = 8, TypeName = "text")]
        public string? party_contact_designation { get; set; }

        [Column("party_contact_website", Order = 9, TypeName = "text")]
        public string? party_contact_website { get; set; }

        [Column("party_contact_twitter_id", Order = 10, TypeName = "text")]
        public string? party_contact_twitter_id { get; set; }

        [Column("party_contact_fb_id", Order = 11, TypeName = "text")]
        public string? party_contact_fb_id { get; set; }

        [Column("party_contact_youtube_id", Order = 12, TypeName = "text")]
        public string? party_contact_youtube_id { get; set; }

        [Column("party_contact_instagram_id", Order = 13, TypeName = "text")]
        public string? party_contact_instagram_id { get; set; }

        [ForeignKey("PartyMaster"),  Column("party_master_id", Order = 14, TypeName = "bigint")]
        public long? party_master_id { get; set; }

        [ForeignKey("CaseMaster"), Column("case_master_id", Order = 15, TypeName = "bigint")]
        public long? case_master_id { get; set; }

        [Column("delete_at", Order = 16, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 17, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        public virtual PartyMaster? PartyMaster { get; set; }
        public virtual CaseMaster? CaseMaster { get; set; }

    }
}
