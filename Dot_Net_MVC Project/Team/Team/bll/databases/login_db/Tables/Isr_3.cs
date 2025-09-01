using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace DB.Login.Tables
{
    public class Isr_3
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("company_name", Order = 2, TypeName = "text")]
        public string company_name { get; set; }

        [Column("company_address", Order = 3, TypeName = "text")]
        public string company_address { get; set; }

        [Column("company_email", Order = 4, TypeName = "text")]
        public string company_email { get; set; }

        [Column("company_phone", Order = 5, TypeName = "text")]
        public string company_phone { get; set; }

        [Column("descriptions1", Order = 6, TypeName = "text")]
        public string descriptions1 { get; set; }

        [Column("descriptions2", Order = 7, TypeName = "text")]
        public string descriptions2 { get; set; }

        [Column("descriptions3", Order = 8, TypeName = "text")]
        public string descriptions3 { get; set; }

        [JsonIgnore]
        public virtual ICollection<Isr_3_securities> Isr_3_securities { get; set; }

    }
}
