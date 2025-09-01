using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class GeneralRequestedDetail
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("user_id", Order = 2, TypeName = "bigint")]
        public long? user_id { get; set; }

        [ForeignKey("ServiceMaster"), Column("service_id", Order = 3, TypeName = "bigint")]
        public long? service_id { get; set; }

        [ForeignKey("CategoryMaster"), Column("category_id", Order = 3, TypeName = "bigint")]
        public long? category_id { get; set; }

        [Column("status", Order = 6, TypeName = "text")]
        public string? status { get; set; } = "Pending";

        [Column("created_at", Order = 7, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [JsonIgnore]
        public ICollection<ProcessRequestDetail>? ProcessRequestDetail { get; set; }

        [JsonIgnore]
        public virtual  ServiceMaster ServiceMaster { get; set; }
        [JsonIgnore]
        public virtual CategoryMaster CategoryMaster { get; set; }

    }
}
