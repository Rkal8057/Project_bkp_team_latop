using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace DB.Login.Tables
{
    public class CategoryMaster
    {
        [Key, Column("id", Order = 1, TypeName = "bigint")]
        public long id { get; set; }

        [Column("category_name", Order = 2, TypeName = "text")]
        public string? category_name { get; set; }

        [Column("active", Order = 3, TypeName = "bit")]
        public bool? active { get; set; } = true;

        [Column("created_at", Order = 4, TypeName = "datetime")]
        public DateTime? created_at { get; set; } = DateTime.Now;

        [Column("delete_at", Order = 5, TypeName = "bit")]
        public bool? delete_at { get; set; } = false;

        [Column("old_software_code_ya_id", Order = 6, TypeName = "bigint")]
        public long? old_software_code_ya_id { get; set; }

        [Column("category_content", Order = 7, TypeName = "text")]
        public string? category_content { get; set; }

        [Column("category_image", Order = 8, TypeName = "text")]
        public string? category_image { get; set; }

        [Column("online_yn", Order = 9, TypeName = "text")]
        public string? online_yn { get; set; }



        [Column("balance_sheet_id", Order = 10,TypeName = "bigint")]
        public long? balance_sheet_id { get; set; }

        [Column("balance_sheet_cate_name", Order =11, TypeName = "text")]
        public string? balance_sheet_cate_name { get; set; }

        [Column("cate_type", Order =12, TypeName = "text")]
        public string? cate_type { get; set; }

        [Column("cate_id_if_sub_Selected", Order =13, TypeName = "bigint")]
        public long? cate_id_if_sub_Selected { get; set; }

        [Column("cate_name_if_sub_Selected", Order =14, TypeName = "text")]
        public string? cate_name_if_sub_Selected { get; set; }


        [Column("super_cate_id", Order =15, TypeName = "bigint")]
        public long? super_cate_id { get; set; }

        [Column("table_flag", Order = 16, TypeName = "text")]
        public string? table_flag { get; set; }

      

      





    }
}
