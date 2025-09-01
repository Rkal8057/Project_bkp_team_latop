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

       
    }
}
