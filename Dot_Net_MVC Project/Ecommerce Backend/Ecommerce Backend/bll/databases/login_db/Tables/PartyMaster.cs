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
    public class PartyMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("name", Order = 2, TypeName = "text")]
        public string? name { get; set; }

        [Column("address", Order = 3, TypeName = "text")]
        public string?address { get; set; }

        [Column("mobile_number", Order = 4, TypeName = "bigint")]
        public long? mobile_number { get; set; }

        [Column("email", Order = 5, TypeName = "text")]
        public string? email { get; set; }

        [Column("pincode", Order = 6, TypeName = "bigint")]
        public long? pincode { get; set; }

        [Column("party_type", Order = 7, TypeName = "text")]
        public string? party_type { get; set; }
        
        [Column("created_on", Order = 7, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 8, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }
    }
}
