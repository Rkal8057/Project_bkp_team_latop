using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class User_Detail
    {
        public User_Detail()
        {
            this.Forms_Trx_Masters = new HashSet<Forms_Trx_Master>();
        }
        [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]

        public long id { get; set; }

        [Column("user_code", Order = 2, TypeName = "bigint(10)"), Required]
        public long user_code { get; set; }

        [Column("user_name", Order = 3, TypeName = "varchar(100)"), Required]
        public string user_name { get; set; }

        [Column("user_profile", Order = 4, TypeName = "varchar(100)")]
        public string? user_profile { get; set; }

        [Column("user_pass", Order = 5, TypeName = "varchar(100)"), Required]
        public string user_pass { get; set; }

        [Column("save_yes_no", Order = 6, TypeName = "varchar(10)")]
        public string? save_yes_no { get; set; }

        [Column("modify_yes_no", Order = 7, TypeName = "varchar(10)")]
        public string? modify_yes_no { get; set; }

        [Column("delete_yes_no", Order = 8, TypeName = "varchar(10)")]
        public string? delete_yes_no { get; set; }

        [Column("cs_save_yes_no", Order = 9, TypeName = "varchar(10)")]
        public string? cs_save_yes_no { get; set; }

        [Column("cs_modi_del_yes_no", Order = 10, TypeName = "varchar(10)")]
        public string? cs_modi_del_yes_no { get; set; }

        [Column("print_only", Order = 11, TypeName = "varchar(10)")]
        public string? print_only { get; set; }

        [Column("user_status", Order = 12, TypeName = "varchar(100)")]
        public string? user_status { get; set; }

        [Column("user_mobile", Order = 13, TypeName = "bigint(10)")]
        public long user_mobile { get; set; }

        [Column("user_email", Order = 14, TypeName = "varchar(100)")]
        public string? user_email { get; set; }

        [Column("user_email_pass", Order = 15, TypeName = "varchar(100)")]
        public string? user_email_pass { get; set; }

        [Column("user_created_on", Order = 16, TypeName = "datetime")]
        public DateTime? user_created_on { get; set; }

        [Column("user_updated_on", Order = 17, TypeName = "datetime")]
        public DateTime? user_updated_on { get; set; }

        [Column("software_version", Order = 18, TypeName = "varchar(100)")]
        public string? software_version { get; set; }

        [Column("user_allotement_status", Order = 19, TypeName = "varchar(100)")]
        public string? user_allotement_status { get; set; }

        [Column("report_yes_no", Order = 20, TypeName = "varchar(3)")]
        public string? report_yes_no { get; set; }

        [Column("comp_id", Order = 21, TypeName = "bigint(10)")]
        public long? comp_id { get; set; }

        [Column("comp_name", Order = 22, TypeName = "varchar(100)")]
        public string? comp_name { get; set; }

        [Column("view_yes_no", Order = 23, TypeName = "varchar(10)")]
        public string? view_yes_no { get; set; }

        [ForeignKey("User_Profile_Master"), Column("user_profile_id", Order = 24, TypeName = "bigint(10)")]
        public long? user_profile_id { get; set; }

        [Column("user_pancard", Order = 25, TypeName = "varchar(10)")]
        public string? user_pancard { get; set; }


        [JsonIgnore]
        public virtual User_Profile_Master User_Profile_Masters { get; set; }

        [JsonIgnore]
        public virtual ICollection<Forms_Trx_Master> Forms_Trx_Masters { get; set; }

        [JsonIgnore]
        public virtual ICollection<User_OTP_Transaction> User_OTP_Transactions { get; set; }

        [JsonIgnore]
        public virtual ICollection<UserMultiAddDetails> UserMultiAddDetails { get; set; }
        // [JsonIgnore]
        // public virtual ICollection<Files_Master> Files_Masters { get; set; }



    }
}