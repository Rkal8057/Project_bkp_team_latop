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
    public class State_Master
    {

        [Key, Column("State_Id", Order = 1, TypeName = "bigint")]
        public long? State_Id { get; set; }

        [Column("State_Name", Order = 2, TypeName = "text")]
        public string? State_Name { get; set; }

        [Column("State_Code", Order = 3, TypeName = "text")]
        public string? State_Code { get; set; }

        [Column("State_Short_Name", Order = 4, TypeName = "text")]
        public string? State_Short_Name { get; set; }
    }
}
