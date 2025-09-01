using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class A1_Dn_Test
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("old_id", Order = 2, TypeName = "bigint(10)")]
       public long? old_old_id { get; set; }

       [Column("dn_from", Order = 3, TypeName = "float")]
       public long? dn_from { get; set; }

       [Column("dn_upto", Order = 4, TypeName = "float")]
       public long? dn_upto { get; set; }

       [Column("share_qty", Order = 5, TypeName = "float")]
       public long? share_qty { get; set; }

   }
}
