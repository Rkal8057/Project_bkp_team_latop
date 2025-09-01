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
public class Multi_Purpose_Type_Master
   {
       [Key, Column("id", Order = 1, TypeName = "bigint(10) auto_increment"), Required]
       public long id { get; set; }
       
       [Column("auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? auto_id { get; set; }

       [Column("multi_purpose_flag", Order = 3, TypeName = "varchar(60)")]
       public string? multi_purpose_flag { get; set; }

       [Column("multi_purpose_code", Order = 4, TypeName = "varchar(60)")]
       public string? multi_purpose_code { get; set; }

       [Column("multi_purpose_type", Order = 5, TypeName = "text")]
       public string? multi_purpose_type { get; set; }

       [Column("multi_purpose_remark", Order = 6, TypeName = "varchar(60)")]
       public string? multi_purpose_remark { get; set; }

       [Column("multi_purpose_delete_allow_yn", Order = 7, TypeName = "varchar(60)")]
       public string? multi_purpose_delete_allow_yn { get; set; }

       [Column("exchange_name", Order = 8, TypeName = "text")]
       public string? exchange_name { get; set; }

        [Column("user_id", Order = 9, TypeName = "bigint")]
        public long? user_id { get; set; }

        [Column("user_profile", Order = 10, TypeName = "text")]
        public string? user_profile { get; set; }

        [Column("user_mobile", Order = 11, TypeName = "bigint(10)")]
        public long? user_mobile { get; set; }

        [Column("user_name", Order = 12, TypeName = "text")]
        public string? user_name { get; set; }

        [Column("created_on", Order = 13, TypeName = "datetime")]
        public DateTime? created_on { get; set; }

        [Column("updated_on", Order = 14, TypeName = "datetime")]
        public DateTime? updated_on { get; set; }


    }
}
