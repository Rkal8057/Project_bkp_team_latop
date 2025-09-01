using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Reflection;
using System.Xml.Linq;

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
        public ICollection<SalesMaster> SalesMaster { get; set; }
    }
}
