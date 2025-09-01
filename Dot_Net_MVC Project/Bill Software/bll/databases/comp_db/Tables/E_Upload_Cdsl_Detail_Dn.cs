using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_upload_cdsl_detail_dn")] 
       
   public class E_Upload_Cdsl_Detail_Dn
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("rta_ref_no", Order = 3, TypeName = "varchar(16)")]
       public string? rta_ref_no { get; set; }

       [Column("rngs_start", Order = 4, TypeName = "varchar(6)")]
       public string? rngs_start { get; set; }

       [Column("record_nos", Order = 5, TypeName = "varchar(2)")]
       public string? record_nos { get; set; }

       [Column("rngs_end", Order = 6, TypeName = "varchar(7)")]
       public string? rngs_end { get; set; }

       [Column("dnfrm_start", Order = 7, TypeName = "varchar(7)")]
       public string? dnfrm_start { get; set; }

       [Column("dn_from", Order = 8, TypeName = "varchar(18)")]
       public string? dn_from { get; set; }

       [Column("dnfrm_end", Order = 9, TypeName = "varchar(8)")]
       public string? dnfrm_end { get; set; }

       [Column("dnto_start", Order = 10, TypeName = "varchar(6)")]
       public string? dnto_start { get; set; }

       [Column("dn_upto", Order = 11, TypeName = "varchar(18)")]
       public string? dn_upto { get; set; }

       [Column("dnto_end", Order = 12, TypeName = "varchar(7)")]
       public string? dnto_end { get; set; }

   }
}
