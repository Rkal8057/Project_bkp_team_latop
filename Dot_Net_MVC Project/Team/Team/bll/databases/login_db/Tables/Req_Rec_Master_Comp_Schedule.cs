using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Master_Comp_Schedule
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? auto_id { get; set; }

       [Column("req_id", Order = 3, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("schedule_name", Order = 4, TypeName = "text")]
       public string? schedule_name { get; set; }

       [Column("schedule_date", Order = 5, TypeName = "datetime")]
       public DateTime? schedule_date { get; set; }

       [Column("schedule_sno", Order = 6, TypeName = "double(18,3)")]
       public long? schedule_sno { get; set; }

       [Column("schedule_remark", Order = 7, TypeName = "text")]
       public string? schedule_remark { get; set; }

       [Column("created_on", Order = 8, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 9, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

   }
}
