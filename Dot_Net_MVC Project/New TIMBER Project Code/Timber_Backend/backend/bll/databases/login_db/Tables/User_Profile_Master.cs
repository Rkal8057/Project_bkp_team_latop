using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    [Table("user_profile_master")]
    public class User_Profile_Master
    {
          public User_Profile_Master()
        {
            this.User_Details= new HashSet<User_Detail>();
        }
        [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
        public long? id { get; set; }

        [Column("user_profile", Order = 2, TypeName = "varchar(50)")]
        public string? user_profile { get; set; }

        [Column("save_yes_no", Order = 3, TypeName = "varchar(10)")]
        public string? save_yes_no { get; set; }

        [Column("modify_yes_no", Order = 4, TypeName = "varchar(10)")]
        public string? modify_yes_no { get; set; }

        [Column("delete_yes_no", Order = 5, TypeName = "varchar(10)")]
        public string? delete_yes_no { get; set; }

        [Column("print_only", Order = 6, TypeName = "varchar(10)")]
        public string? print_only { get; set; }

        [Column("report_yes_no", Order = 7, TypeName = "varchar(10)")]
        public string? report_yes_no { get; set; }

        [Column("view_yes_no", Order = 8, TypeName = "varchar(10)")]
        public string? view_yes_no { get; set; }



        [JsonIgnore]
        public virtual ICollection<User_Detail> User_Details { get; set; }

    }
}