using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class HelperDetail
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long Id { get; set; }

        [Column("image_url", Order = 3, TypeName = "text")]
        public string? image_url { get; set; }

        [ForeignKey("CompanyDetail"),Column("company_id", Order = 2, TypeName = "bigint")]
        public long? company_id { get; set; }

        
        [JsonIgnore]
        public virtual CompanyDetail? CompanyDetail { get; set; }
    }
}
