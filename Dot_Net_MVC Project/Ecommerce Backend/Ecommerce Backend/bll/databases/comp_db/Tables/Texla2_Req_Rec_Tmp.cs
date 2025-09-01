using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla2_req_rec_tmp")] 
       
   public class Texla2_Req_Rec_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("certi_no", Order = 2, TypeName = "varchar(50)")]
       public string? certi_no { get; set; }

       [Column("st_dist_no", Order = 3, TypeName = "float")]
       public long? st_dist_no { get; set; }

       [Column("upto_dist", Order = 4, TypeName = "float")]
       public long? upto_dist { get; set; }

       [Column("share_qty", Order = 5, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("selected_certi", Order = 6, TypeName = "varchar(1)")]
       public string? selected_certi { get; set; }

       [Column("certi_status", Order = 7, TypeName = "varchar(100)")]
       public string? certi_status { get; set; }

       [Column("foliono", Order = 8, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("sno", Order = 9, TypeName = "bigint(10)")]
       public long? sno { get; set; }

   }
}
