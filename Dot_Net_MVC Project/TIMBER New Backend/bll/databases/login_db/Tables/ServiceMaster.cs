using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DB.Login.Tables
{
    public class ServiceMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("service_name", Order = 2, TypeName = "text")]
        public string? service_name { get; set; }

        [Column("item_category_main_id", Order = 3, TypeName = "bigint")]
        public long? item_category_main_id { get; set; }

        [JsonIgnore]
        public ICollection<ServiceSubCategoryMaster>? ServiceSubCategoryMaster { get; set; }

        // [JsonIgnore]
        //public ICollection<GeneralRequestedDetail> GeneralRequestedDetails { get; set; }

    }
}
