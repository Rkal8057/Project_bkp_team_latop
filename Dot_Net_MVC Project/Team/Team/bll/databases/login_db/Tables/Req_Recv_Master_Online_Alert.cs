using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Recv_Master_Online_Alert
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("exchange_name", Order = 3, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("alert_code_no", Order = 4, TypeName = "float")]
       public long? alert_code_no { get; set; }

       [Column("alert_code", Order = 5, TypeName = "text")]
       public string? alert_code { get; set; }

       [Column("alert_detail", Order = 6, TypeName = "text")]
       public string? alert_detail { get; set; }

       [Column("req_status", Order = 7, TypeName = "text")]
       public string? req_status { get; set; }

   }
}
