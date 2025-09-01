using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Ca_Upload_Cdsl_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("total_number_of_records", Order = 4, TypeName = "varchar(10)")]
       public string? total_number_of_records { get; set; }

       [Column("total_current_quantity", Order = 5, TypeName = "varchar(16)")]
       public string? total_current_quantity { get; set; }

       [Column("total_freeze_quantity", Order = 6, TypeName = "varchar(16)")]
       public string? total_freeze_quantity { get; set; }

       [Column("total_lock_in_quantity", Order = 7, TypeName = "varchar(16)")]
       public string? total_lock_in_quantity { get; set; }

       [Column("total_number_of_records_in_02", Order = 8, TypeName = "varchar(10)")]
       public string? total_number_of_records_in_02 { get; set; }

       [Column("total_number_of_records_in_03", Order = 9, TypeName = "varchar(10)")]
       public string? total_number_of_records_in_03 { get; set; }

   }
}
