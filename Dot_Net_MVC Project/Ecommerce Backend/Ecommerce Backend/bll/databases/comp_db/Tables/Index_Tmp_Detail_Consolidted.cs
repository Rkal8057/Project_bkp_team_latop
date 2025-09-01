using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("index_tmp_detail_consolidted")] 
       
   public class Index_Tmp_Detail_Consolidted
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("holding_rpt_date_con", Order = 2, TypeName = "varchar(10)")]
       public string? holding_rpt_date_con { get; set; }

       [Column("share_qty", Order = 3, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("share_qty_per", Order = 4, TypeName = "float")]
       public long? share_qty_per { get; set; }

       [Column("lock_in_qty", Order = 5, TypeName = "float")]
       public long? lock_in_qty { get; set; }

       [Column("pledged_qty", Order = 6, TypeName = "float")]
       public long? pledged_qty { get; set; }

       [Column("qty_nsdl", Order = 7, TypeName = "float")]
       public long? qty_nsdl { get; set; }

       [Column("qty_cdsl", Order = 8, TypeName = "float")]
       public long? qty_cdsl { get; set; }

       [Column("qty_phy", Order = 9, TypeName = "float")]
       public long? qty_phy { get; set; }

       [Column("pan_no_backup_con", Order = 10, TypeName = "varchar(20)")]
       public string? pan_no_backup_con { get; set; }

   }
}
