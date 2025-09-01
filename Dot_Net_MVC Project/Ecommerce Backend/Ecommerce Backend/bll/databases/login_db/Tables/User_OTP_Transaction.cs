using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DB.Login.Tables
{
    [Table("user_otp_transaction")]
    public class User_OTP_Transaction
    {
        [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
        public long? id { get; set; }

        [ForeignKey("User_Detail"), Column("UserDetailId", Order = 2, TypeName = "bigint(10)"), Required]
        public long UserDetailId { get; set; }

        [Column("u_verification", Order = 3, TypeName = "varchar(500)")]
        public string? u_verification { get; set; }

        [Column("u_purpose", Order = 4, TypeName = "varchar(500)")]
        public string? u_purpose { get; set; }

        [Column("u_otpno", Order = 5, TypeName = "varchar(100)")]
        public string? u_otpno{ get; set; }

         [JsonIgnore]
        public virtual User_Detail User_Detail { get; set; }

    }
}
