using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class ProcessRequestDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("required_info", Order = 2, TypeName = "text")]
        public string? required_info { get; set; }

        [Column("required_info_data", Order = 3, TypeName = "text")]
        public string? required_info_data { get; set; }

        [ ForeignKey("GeneralRequestedDetail") ,Column("general_requested_detail_id", Order = 4, TypeName = "bigint")]
        public long? general_requested_detail_id { get; set; }

        [JsonIgnore]
        public virtual  GeneralRequestedDetail GeneralRequestedDetail { get; set; }
    }
}
