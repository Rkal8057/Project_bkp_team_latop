using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Docu_Type_Mst
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("docu_type_name", Order = 2, TypeName = "text")]
       public string? docu_type_name { get; set; }

       [Column("docu_type_id", Order = 3, TypeName = "bigint(10)")]
       public long? docu_type_id { get; set; }

       [Column("docu_flag", Order = 4, TypeName = "varchar(150)")]
       public string? docu_flag { get; set; }

       [Column("docu_remark", Order = 5, TypeName = "text")]
       public string? docu_remark { get; set; }

   }
}
