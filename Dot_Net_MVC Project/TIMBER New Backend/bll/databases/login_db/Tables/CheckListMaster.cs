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

        [Column("document_required_position", Order = 4, TypeName = "text")]
        public string? document_required_position { get; set; }

        [ForeignKey("ServiceSubCategoryMaster"), Column("subservice_id", Order = 5, TypeName = "bigint")]
        public long? subservice_id { get; set; }

        [Column("service_id", Order = 6, TypeName = "bigint")]
        public long? service_id { get; set; }

        [Column("helper_master_document_id", Order = 7, TypeName = "bigint")]
        public long? helper_master_document_id { get; set; }


        [Column("document_required_option", Order = 8, TypeName = "text")]
        public string? document_required_option { get; set; }

        [Column("document_required_col_size", Order = 9, TypeName = "text")]
        public string? document_required_col_size { get; set; }
  

        [JsonIgnore]
        public virtual ServiceSubCategoryMaster? ServiceSubCategoryMaster { get; set; }

    }
}
