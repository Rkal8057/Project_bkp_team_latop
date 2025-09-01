using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    [Table("forms_trx_master")]
    public class Forms_Trx_Master
    {
        [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
        public long? id { get; set; }

        [ForeignKey("Forms_Master"), Column("form_master_id", Order = 2, TypeName = "bigint(10)")]
        public long? form_master_id { get; set; }

        [Column("user_name", Order = 3, TypeName = "varchar(50)")]
        public string? user_name { get; set; }

        [Column("user_code", Order = 4, TypeName = "bigint(10)")]
        public long? user_code { get; set; }

        [Column("user_profile", Order = 5, TypeName = "varchar(50)")]
        public string? user_profile { get; set; }

        [Column("save_yes_no", Order = 6, TypeName = "varchar(10)")]
        public string? save_yes_no { get; set; }

        [Column("modify_yes_no", Order = 7, TypeName = "varchar(10)")]
        public string? modify_yes_no { get; set; }

        [Column("delete_yes_no", Order = 8, TypeName = "varchar(10)")]
        public string? delete_yes_no { get; set; }

        [Column("print_only", Order = 9, TypeName = "varchar(10)")]
        public string? print_only { get; set; }

        [Column("report_yes_no", Order = 10, TypeName = "varchar(10)")]
        public string? report_yes_no { get; set; }

        [Column("view_yes_no", Order = 11, TypeName = "varchar(10)")]
        public string? view_yes_no { get; set; }


        [JsonIgnore]
        public virtual Forms_Master Forms_Master { get; set; }
    }
}