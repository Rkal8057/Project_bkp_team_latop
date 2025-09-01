using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DB.Login.Tables
{
    [Table("UserMultiAddDetails")]
    public class UserMultiAddDetails
    {
        [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
        public long id { get; set; }

        [ForeignKey("User_Detail"), Column("userId", Order = 2, TypeName = "bigint(10)"), Required]
        public long userId { get; set; }

        [Column("m_form_name", Order = 3, TypeName = "varchar(100)")]
        public string? m_form_name { get; set; }

        [Column("m_address", Order = 4, TypeName = "varchar(100)")]
        public string? m_address { get; set; }

        [Column("m_city", Order = 5, TypeName = "varchar(100)")]
        public string? m_city { get; set; }

        [Column("m_pin_code", Order = 6, TypeName = "varchar(10)")]
        public string? m_pin_code { get; set; }

        [Column("m_country", Order = 7, TypeName = "varchar(100)")]
        public string? m_country { get; set; }

        [Column("m_address_type", Order = 8, TypeName = "varchar(50)")]
        public string? m_address_type { get; set; }

        [JsonIgnore]
        public virtual User_Detail User_Detail { get; set; }

       

    }
}