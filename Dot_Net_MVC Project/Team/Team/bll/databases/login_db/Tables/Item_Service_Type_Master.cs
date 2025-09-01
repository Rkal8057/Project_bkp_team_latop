using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Item_Service_Type_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("item_service_type_id", Order = 2, TypeName = "bigint(10)")]
       public long? item_service_type_id { get; set; }

       [Column("item_service_type_name", Order = 3, TypeName = "text")]
       public string? item_service_type_name { get; set; }

   }
}
