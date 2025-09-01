using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla2_tmp")] 
       
   public class Texla2_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("foliono", Order = 2, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("tr_sno", Order = 3, TypeName = "bigint(10)")]
       public long? tr_sno { get; set; }

       [Column("certi_no", Order = 4, TypeName = "varchar(50)")]
       public string? certi_no { get; set; }

       [Column("st_dist_no", Order = 5, TypeName = "float")]
       public long? st_dist_no { get; set; }

       [Column("upto_dist", Order = 6, TypeName = "float")]
       public long? upto_dist { get; set; }

       [Column("share_qty", Order = 7, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("certi_status", Order = 8, TypeName = "varchar(50)")]
       public string? certi_status { get; set; }

       [Column("con_amount", Order = 9, TypeName = "bigint(10)")]
       public long? con_amount { get; set; }

       [Column("tr_shares", Order = 10, TypeName = "varchar(1)")]
       public string? tr_shares { get; set; }

   }
}
