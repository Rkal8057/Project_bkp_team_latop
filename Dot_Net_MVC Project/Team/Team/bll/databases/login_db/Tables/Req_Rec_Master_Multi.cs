using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Req_Rec_Master_Multi
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? auto_id { get; set; }

       [Column("req_flag_name_id", Order = 3, TypeName = "float")]
       public long? req_flag_name_id { get; set; }

       [Column("req_status", Order = 4, TypeName = "text")]
       public string? req_status { get; set; }

       [Column("master_req_id", Order = 5, TypeName = "float")]
       public long? master_req_id { get; set; }

       [Column("req_flag", Order = 6, TypeName = "text")]
       public string? req_flag { get; set; }

       [Column("req_flag_name", Order = 7, TypeName = "text")]
       public string? req_flag_name { get; set; }

       [Column("trfno", Order = 8, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trfdate", Order = 9, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("vou_type", Order = 10, TypeName = "text")]
       public string? vou_type { get; set; }

   }
}
