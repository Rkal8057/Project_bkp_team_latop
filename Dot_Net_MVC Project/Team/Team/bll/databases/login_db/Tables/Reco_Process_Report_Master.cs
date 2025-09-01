using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reco_Process_Report_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("reco_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? reco_auto_id { get; set; }

       [Column("isin_no", Order = 3, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 4, TypeName = "text")]
       public string? isin_comp_name { get; set; }

       [Column("procces_started_yn", Order = 5, TypeName = "varchar(3)")]
       public string? procces_started_yn { get; set; }

       [Column("procces_remark", Order = 6, TypeName = "text")]
       public string? procces_remark { get; set; }

       [Column("day_procesed", Order = 7, TypeName = "float")]
       public long? day_procesed { get; set; }

       [Column("mix_match_yn", Order = 8, TypeName = "varchar(3)")]
       public string? mix_match_yn { get; set; }

       [Column("mis_match_days", Order = 9, TypeName = "float")]
       public long? mis_match_days { get; set; }

       [Column("start_date", Order = 10, TypeName = "datetime")]
       public DateTime? start_date { get; set; }

       [Column("end_date", Order = 11, TypeName = "datetime")]
       public DateTime? end_date { get; set; }

       [Column("created_on", Order = 12, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("paid_up_capital_qty_op", Order = 13, TypeName = "float")]
       public long? paid_up_capital_qty_op { get; set; }

       [Column("paid_up_capital_qty_cls", Order = 14, TypeName = "float")]
       public long? paid_up_capital_qty_cls { get; set; }

       [Column("diff_in_capital_qty", Order = 15, TypeName = "float")]
       public long? diff_in_capital_qty { get; set; }

       [Column("user_name", Order = 16, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 17, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
