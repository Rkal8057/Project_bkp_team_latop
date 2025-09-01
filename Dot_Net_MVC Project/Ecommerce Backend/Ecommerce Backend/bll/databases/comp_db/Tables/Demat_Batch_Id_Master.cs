using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("demat_batch_id_master")] 
       
   public class Demat_Batch_Id_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_upload_date", Order = 3, TypeName = "datetime")]
       public DateTime? trx_upload_date { get; set; }

       [Column("trx_business_date", Order = 4, TypeName = "datetime")]
       public DateTime? trx_business_date { get; set; }

       [Column("batch_no", Order = 5, TypeName = "varchar(140)")]
       public string? batch_no { get; set; }

       [Column("branch_code", Order = 6, TypeName = "varchar(140)")]
       public string? branch_code { get; set; }

       [Column("rta_id_sr_bp_id", Order = 7, TypeName = "varchar(50)")]
       public string? rta_id_sr_bp_id { get; set; }

       [Column("operator_id", Order = 8, TypeName = "varchar(50)")]
       public string? operator_id { get; set; }

       [Column("total_no_of_records", Order = 9, TypeName = "varchar(50)")]
       public string? total_no_of_records { get; set; }

       [Column("enter_date_time", Order = 10, TypeName = "datetime")]
       public DateTime? enter_date_time { get; set; }

       [Column("file_exchange_name", Order = 11, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("trx_flag", Order = 12, TypeName = "varchar(100)")]
       public string? trx_flag { get; set; }

       [Column("file_extension", Order = 13, TypeName = "varchar(100)")]
       public string? file_extension { get; set; }

       [Column("user_name", Order = 14, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 15, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

   }
}
