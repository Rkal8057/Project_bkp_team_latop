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
    public class balance_sheet_master
    {
        [Key, Column("cat_code", Order = 1, TypeName = "bigint")]
        public long? CatCode { get; set; }

        [Column("cat_name", Order = 2, TypeName = "text")]
        public string? cat_name { get; set; }
        
        [Column("cat_type", Order = 3, TypeName = "text")]
        public string? cat_type { get; set; }

        [Column("cat_main", Order = 4, TypeName = "text")]
        public string? cat_main { get; set; }

        [Column("supermain", Order = 5, TypeName = "text")]
        public string? supermain { get; set; }

        [Column("drcr", Order = 6, TypeName = "nvarchar(10)")]
        public string? drcr { get; set; }

        [Column("todo", Order = 7, TypeName = "text")]
        public string? todo { get; set; }

        [Column("window", Order = 8, TypeName = "text")]
        public string? window { get; set; }

        [Column("mindex", Order = 9, TypeName = "bigint")]
        public long?  mindex { get; set; }
        
        [Column("del_yn", Order = 10, TypeName = "text")]
        public string? del_yn { get; set; }
    }
}
