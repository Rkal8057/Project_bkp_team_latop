using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    [Table("forms_master")]
    public class Forms_Master
    {
        public Forms_Master()
        {
            this.Forms_Trx_Masters= new HashSet<Forms_Trx_Master>();
        }
        [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
        public long id { get; set; }

        [Column("form_name", Order = 2, TypeName = "varchar(50)")]
        public string? form_name { get; set; }

        [Column("form_table", Order = 3, TypeName = "varchar(50)")]
         public string? form_table { get; set; }

        [Column("form_type", Order = 4, TypeName = "varchar(50)")]
        public string? form_type { get; set; }
        
        [Column("form_title", Order = 5, TypeName = "varchar(50)")]
        public string? form_title { get; set; }

        [Column("form_display_status", Order = 6, TypeName = "varchar(50)")]
        public string? form_display_status { get; set; }

        [Column("form_master_id", Order = 7, TypeName = "bigint(10)")]
        public long? form_master_id { get; set; }

        [Column("form_display_color", Order = 8, TypeName = "varchar(50)")]
        public string? form_display_color { get; set; }

        [Column("form_href", Order = 9, TypeName = "text")]
        public string? form_href { get; set; }

          [Column("user_id", Order = 10, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("user_profile", Order = 11, TypeName = "text")]
        public string? user_profile { get; set; }
        
        [Column("user_mobile", Order = 12, TypeName = "text")]
        public string? user_mobile { get; set; }
        
        [Column("user_name", Order = 13, TypeName = "text")]
        public string? user_name { get; set; }
        
        [Column("user_email", Order = 14, TypeName = "text")]
        public string? user_email { get; set; }

        [Column("created_on", Order = 15, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 16, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<Forms_Trx_Master> Forms_Trx_Masters { get; set; }

    }
}