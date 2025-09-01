using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class CheckListMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("document_required_name", Order = 2, TypeName = "text")]
        public string? document_required_name { get; set; }

        [Column("document_required_type", Order = 3, TypeName = "text")]
        public string? document_required_type { get; set; }

        [ForeignKey("CategoryMaster"), Column("category_id", Order = 4, TypeName = "bigint")]
        public long? category_id { get; set; }

        [JsonIgnore]
        public virtual CategoryMaster? CategoryMaster { get; set; }

    }
}
