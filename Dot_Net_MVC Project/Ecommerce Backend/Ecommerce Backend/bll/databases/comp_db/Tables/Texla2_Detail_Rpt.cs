using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla2_detail_rpt")] 
       
   public class Texla2_Detail_Rpt
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("exchange_name", Order = 3, TypeName = "varchar(1)")]
       public string? exchange_name { get; set; }

       [Column("foliono", Order = 4, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("reason", Order = 5, TypeName = "varchar(50)")]
       public string? reason { get; set; }

       [Column("stcert", Order = 6, TypeName = "varchar(50)")]
       public string? stcert { get; set; }

       [Column("stdist", Order = 7, TypeName = "float")]
       public long? stdist { get; set; }

       [Column("upto_distno", Order = 8, TypeName = "float")]
       public long? upto_distno { get; set; }

       [Column("dist_status_code", Order = 9, TypeName = "varchar(16)")]
       public string? dist_status_code { get; set; }

       [Column("dist_status_flag", Order = 10, TypeName = "varchar(16)")]
       public string? dist_status_flag { get; set; }

       [Column("allotment_date", Order = 11, TypeName = "datetime")]
       public DateTime? allotment_date { get; set; }

       [Column("cut_of_flag", Order = 12, TypeName = "varchar(1)")]
       public string? cut_of_flag { get; set; }

       [Column("issue_description", Order = 13, TypeName = "varchar(50)")]
       public string? issue_description { get; set; }

       [Column("texla2_id", Order = 14, TypeName = "bigint(10)")]
       public long? texla2_id { get; set; }

   }
}
