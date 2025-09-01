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
    public class PartyCategoryMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("category_name", Order = 2, TypeName = "text")]
        public string? category_name { get; set; }

        [Column("balance_sheet_id", Order = 3, TypeName = "bigint")]
        public long? balance_sheet_id { get; set; }

        [Column("balance_sheet_cate_name", Order = 4, TypeName = "text")]
        public string? balance_sheet_cate_name { get; set; }

        [Column("cate_type", Order = 5, TypeName = "text")]
        public string? cate_type { get; set; }

        [Column("cate_id_if_sub_Selected", Order = 6, TypeName = "bigint")]
        public long? cate_id_if_sub_Selected { get; set; }

        [Column("cate_name_if_sub_Selected", Order = 7, TypeName = "text")]
        public string? cate_name_if_sub_Selected { get; set; }


        [Column("super_cate_id", Order = 8, TypeName = "bigint")]
        public long? super_cate_id { get; set; }

        [Column("delete_option", Order = 9, TypeName = "text")]
        public string? delete_option { get; set; }

        [Column("table_flag", Order = 10, TypeName = "text")]
        public string? table_flag { get; set; }

        [Column("active", Order = 11, TypeName = "bigint")]
        public long? active { get; set; } = 0;

        [Column("created_at", Order = 12, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("delete_at", Order = 13, TypeName = "bigint")]
        public long? delete_at { get; set; } = 0;

        [Column("old_software_code_ya_id", Order = 14, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

    }
}
