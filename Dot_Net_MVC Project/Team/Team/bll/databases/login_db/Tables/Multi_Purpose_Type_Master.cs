using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Multi_Purpose_Type_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
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

   }
}
