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
    public class Sms_Msg_Master
    {
        [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
        public long? id { get; set; }

        [Column("user_id", Order = 2, TypeName = "bigint(10)")]
        public long? user_id { get; set; }

        [Column("comp_name", Order = 3, TypeName = "varchar(500)")]
        public string? comp_name { get; set; }

        [Column("client_code", Order = 4, TypeName = "text")]
        public string? client_code { get; set; }

        [Column("vendor_code", Order = 5, TypeName = "text")]
        public string? vendor_code{ get; set; }

        [Column("sms_purpose", Order = 6, TypeName = "varchar(500)")]
        public string? sms_purpose { get; set; }
             
        [Column("user_email", Order = 7, TypeName = "varchar(100)")]
        public string? user_email{ get; set; }

        [Column("delete_status", Order = 8, TypeName = "bigint")]
        public int? delete_status { get; set; } = 0;

        [Column("created_on", Order = 9, TypeName = "datetime")]
        public DateTime? created_on{ get; set; }

        [Column("user_mobile", Order = 10, TypeName = "bigint(10)")]
        public long? user_mobile { get; set; }
        
        [Column("sms_msg", Order = 11, TypeName = "text")]
        public string? sms_msg{ get; set; }
        
        [Column("sms_temp_id", Order = 12, TypeName = "text")]
        public string? sms_temp_id{ get; set; }

    }
}
