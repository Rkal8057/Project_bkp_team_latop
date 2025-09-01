using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    public class Folio_Master
    {
        [Key]
        [Column("Id", Order = 1, TypeName = "bigint")]
        public long Id { get; set; }

        [Column("CompanyName", Order = 2, TypeName = "text")]
        public string CompanyName { get; set; }

        [Column("folio_no", Order = 3, TypeName = "bigint")]
        public int folio_no { get; set; }

        [Column("security_qty", Order = 4, TypeName = "bigint")]
        public int security_qty { get; set; }

        [Column("securities_facevalue", Order = 5, TypeName = "bigint")]
        public int securities_facevalue { get; set; }

        [Column("securities_distinctive_number", Order = 6, TypeName = "bigint")]
        public int securities_distinctive_number { get; set; }

        [ForeignKey("ISR_1"),
        Column("master_id", Order = 7, TypeName = "bigint")]
        public long master_id { get; set; }

        [JsonIgnore]
        public virtual ISR_1 ISR_1 { get; set; }

    }

}
