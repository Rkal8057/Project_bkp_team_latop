using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Docs_Multi_Save_Trx_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? auto_id { get; set; }

       [Column("trx_id", Order = 3, TypeName = "double(18,3)")]
       public long? trx_id { get; set; }

       [Column("docu_type", Order = 4, TypeName = "text")]
       public string? docu_type { get; set; }

       [Column("docu_type_remark", Order = 5, TypeName = "text")]
       public string? docu_type_remark { get; set; }

       [Column("trx_name", Order = 6, TypeName = "text")]
       public string? trx_name { get; set; }

       [Column("trx_flag", Order = 7, TypeName = "text")]
       public string? trx_flag { get; set; }

       [Column("req_id", Order = 8, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("inward_id", Order = 9, TypeName = "double(18,3)")]
       public long? inward_id { get; set; }

       [Column("created_on", Order = 10, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 11, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

   }
}
