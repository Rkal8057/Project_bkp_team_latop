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
    public class Sh_13_securities
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("nature_securities", Order = 2, TypeName = "text")]
        public string nature_securities { get; set; }

        [Column("folio_no", Order = 3, TypeName = "int")]
        public int folio_no { get; set; }

        [Column("no_of_securities", Order = 4, TypeName = "int")]
        public int no_of_securities { get; set; }

        [Column("certificate_no", Order = 5, TypeName = "int")]
        public int certificate_no { get; set; }

        [Column("distinctive_no", Order = 6, TypeName = "int")]
        public int distinctive_no { get; set; }

        [ForeignKey("Sh_13"), Column("master_id", Order = 7, TypeName = "bigint")]
        public long master_id { get; set; }

        [JsonIgnore]
        public virtual Sh_13 Sh_13 { get; set; }
    }
}
