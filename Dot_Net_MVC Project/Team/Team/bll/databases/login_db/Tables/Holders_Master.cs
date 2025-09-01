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
    public class Holders_Master
    {
        [Key]
        [Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("signature", Order = 2, TypeName = "nvarchar(1000)")]
        public string signature { get; set; }

        [Column("name", Order = 3, TypeName = "nvarchar(100)")]
        public string name { get; set; }

        [Column("address1", Order = 4, TypeName = "nvarchar(100)")]
        public string address1 { get; set; }

        [Column("address2", Order = 5, TypeName = "nvarchar(100)")]
        public string address2 { get; set; }

        [Column("address3", Order = 6, TypeName = "nvarchar(100)")]
        public string address3 { get; set; }

        [Column("city", Order = 7, TypeName = "nvarchar(100)")]
        public string city { get; set; }

        [Column("pin_code", Order = 8, TypeName = "nvarchar(10)")]
        public string pin_code { get; set; }

        [ForeignKey("ISR_1"), Column("master_id", Order = 9, TypeName = "bigint")]
        public long master_id { get; set; }

        [JsonIgnore]
        public virtual ISR_1 ISR_1 { get; set; }
    }
}
