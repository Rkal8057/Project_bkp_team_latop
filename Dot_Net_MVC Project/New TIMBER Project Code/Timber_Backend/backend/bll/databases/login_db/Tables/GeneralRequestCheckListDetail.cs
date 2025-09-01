using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class GeneralRequestCheckListDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("required_info", Order = 2, TypeName = "text")]
        public string? required_info { get; set; }

        [Column("required_info_data", Order = 3, TypeName = "text")]
        public string? required_info_data { get; set; }

        [Column("required_type", Order = 4, TypeName = "text")]
        public string? required_type { get; set; }

        [Column("required_position", Order = 5, TypeName = "text")]
        public string? required_position { get; set; }

        [ ForeignKey("GeneralRequestedDetail") ,Column("general_requested_detail_id", Order = 6, TypeName = "bigint")]
        public long? general_requested_detail_id { get; set; }


        [Column("required_col_size", Order = 7, TypeName = "text")]
        public string? required_col_size { get; set; }

        [Column("required_option", Order = 8, TypeName = "text")]
        public string? required_option { get; set; }

        [Column("created_at", Order = 9, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("updated_at", Order = 10, TypeName = "datetime")]
        public DateTime? updated_at { get; set; } = DateTime.Now;

        [JsonIgnore]
        public virtual  GeneralRequestedDetail GeneralRequestedDetail { get; set; }
    }
}
