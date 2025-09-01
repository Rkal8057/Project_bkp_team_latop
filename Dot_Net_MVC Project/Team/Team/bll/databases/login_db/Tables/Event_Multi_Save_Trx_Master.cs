using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Event_Multi_Save_Trx_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? auto_id { get; set; }

       [Column("trx_id", Order = 3, TypeName = "double(18,3)")]
       public long? trx_id { get; set; }

       [Column("trx_name", Order = 4, TypeName = "text")]
       public string? trx_name { get; set; }

       [Column("trx_flag", Order = 5, TypeName = "text")]
       public string? trx_flag { get; set; }

       [Column("req_id", Order = 6, TypeName = "double(18,3)")]
       public long? req_id { get; set; }

       [Column("inward_id", Order = 7, TypeName = "double(18,3)")]
       public long? inward_id { get; set; }

       [Column("event_name", Order = 8, TypeName = "text")]
       public string? event_name { get; set; }

       [Column("event_date", Order = 9, TypeName = "datetime")]
       public DateTime? event_date { get; set; }

       [Column("event_sno", Order = 10, TypeName = "double(18,3)")]
       public long? event_sno { get; set; }

       [Column("event_remark", Order = 11, TypeName = "text")]
       public string? event_remark { get; set; }

       [Column("created_on", Order = 12, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 13, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

   }
}
