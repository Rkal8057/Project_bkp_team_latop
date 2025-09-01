using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("exch_master_03_nsdl_1718")] 
       
   public class Exch_Master_03_Nsdl_1718
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("benpos_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? benpos_auto_id { get; set; }

       [Column("import_id", Order = 3, TypeName = "float")]
       public long? import_id { get; set; }

       [Column("import_id_txt", Order = 4, TypeName = "varchar(50)")]
       public string? import_id_txt { get; set; }

       [Column("import_date", Order = 5, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("entry_date", Order = 6, TypeName = "datetime")]
       public DateTime? entry_date { get; set; }

       [Column("comp_sno", Order = 7, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 8, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 9, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 10, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("import_by_username", Order = 11, TypeName = "varchar(100)")]
       public string? import_by_username { get; set; }

       [Column("dp_id", Order = 12, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("cl_id", Order = 13, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("beneficiary_position_type", Order = 14, TypeName = "varchar(50)")]
       public string? beneficiary_position_type { get; set; }

       [Column("beneficiary_positions", Order = 15, TypeName = "varchar(50)")]
       public string? beneficiary_positions { get; set; }

       [Column("lock_in_indicator", Order = 16, TypeName = "varchar(50)")]
       public string? lock_in_indicator { get; set; }

       [Column("lock_in_reason_code", Order = 17, TypeName = "varchar(50)")]
       public string? lock_in_reason_code { get; set; }

       [Column("lock_in_release_date", Order = 18, TypeName = "varchar(50)")]
       public string? lock_in_release_date { get; set; }

       [Column("line_number", Order = 19, TypeName = "float")]
       public long? line_number { get; set; }

   }
}
