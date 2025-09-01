using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    public class Location_Master
    {

        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("location_name", Order = 2, TypeName = "text")]
        public string? location_name { get; set; }

        [Column("created_on", Order = 3, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 4, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }

        [Column("delete", Order = 5, TypeName = "bigint")]
        public long? delete { get; set; } = 0;

    }
}
