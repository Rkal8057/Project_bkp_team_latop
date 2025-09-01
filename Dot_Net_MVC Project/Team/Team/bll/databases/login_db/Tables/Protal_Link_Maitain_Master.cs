using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Protal_Link_Maitain_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "double(18,3)")]
       public long? table_auto_id { get; set; }

       [Column("portal_link_detail", Order = 3, TypeName = "text")]
       public string? portal_link_detail { get; set; }

       [Column("portal_link_type", Order = 4, TypeName = "text")]
       public string? portal_link_type { get; set; }

       [Column("portal_link_remark", Order = 5, TypeName = "text")]
       public string? portal_link_remark { get; set; }

       [Column("portal_link_url", Order = 6, TypeName = "text")]
       public string? portal_link_url { get; set; }

   }
}
