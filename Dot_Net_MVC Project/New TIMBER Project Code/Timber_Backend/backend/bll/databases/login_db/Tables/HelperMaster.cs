using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DB.Login.Tables
{
    public class HelperMaster
    {
        [Key, Column("id", Order = 0, TypeName = "bigint")]
        public long id { get; set; }

        [Column("form_name", Order = 1, TypeName = "text")]
        public string? form_name { get; set; }

        [Column("field_name", Order = 2, TypeName = "text")]
        public string? field_name { get; set; }

        [Column("field_data", Order = 3, TypeName = "text")]
        public string? field_data { get; set; }

        [Column("deleted", Order = 4, TypeName = "bigint")]
        public long? deleted { get; set; } = 0;

        [Column("created_on", Order = 5, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 6, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }
    }
}
