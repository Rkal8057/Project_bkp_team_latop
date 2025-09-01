using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    [Table("comp_db")]
    public class Comp_DB
    {
        [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
        public long id { get; set; }
        [ForeignKey("Comp_Selection_Master"), Column("CompMstId", Order = 2, TypeName = "bigint(10)"), Required]
        public long CompMstId { get; set; }

        [Column("server", Order = 3, TypeName = "varchar(50)"), Required]
        public string server { get; set; }

        [Column("db_name", Order = 4, TypeName = "varchar(50)"), Required]
        public string db_name { get; set; }
        [Column("db_user", Order = 5, TypeName = "varchar(50)"), Required]
        public string db_user { get; set; }

        [Column("db_pass", Order = 6, TypeName = "varchar(50)"), Required]
        public string db_pass { get; set; }
        [JsonIgnore]
        public virtual Comp_Selection_Master Comp_Selection_Master { get; set; }

    }
}