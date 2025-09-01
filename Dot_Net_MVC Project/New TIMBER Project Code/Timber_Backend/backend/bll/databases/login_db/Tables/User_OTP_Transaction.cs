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

        [ForeignKey("User_Detail"), Column("user_id", Order = 2, TypeName = "bigint(10)")]
        public long? UserDetailId { get; set; }

        [Column("u_verification", Order = 3, TypeName = "varchar(500)")]
        public string? u_verification { get; set; }

        [Column("u_purpose", Order = 4, TypeName = "varchar(500)")]
        public string? u_purpose { get; set; }

        [Column("u_otpno", Order = 5, TypeName = "varchar(100)")]
        public string? u_otpno{ get; set; }

        
        [ForeignKey("User_Registration_History"), Column("user_register_id", Order = 6, TypeName = "bigint(10)")]
        public long? user_register_id { get; set; }

        [Column("user_email", Order = 7, TypeName = "varchar(100)")]
        public string? user_email{ get; set; }

        [Column("delete_status", Order = 8, TypeName = "bigint")]
        public int? delete_status { get; set; } = 0;

        [Column("created_on", Order = 9, TypeName = "datetime")]
        public DateTime? created_on{ get; set; }
        

        [Column("user_mobile", Order = 10, TypeName = "varchar(20)")]
        public string? user_mobile { get; set; }

         [JsonIgnore]
        public virtual User_Detail User_Detail { get; set; }
        [JsonIgnore]
        public virtual User_Registration_History User_Registration_History { get; set; }

    }
}
