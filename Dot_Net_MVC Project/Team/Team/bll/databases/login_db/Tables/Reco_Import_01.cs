using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reco_Import_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("reco_import_trx_no", Order = 3, TypeName = "double(18,3)")]
       public long? reco_import_trx_no { get; set; }

       [Column("ref_date", Order = 4, TypeName = "datetime")]
       public DateTime? ref_date { get; set; }

       [Column("enter_date", Order = 5, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 6, TypeName = "varchar(1000)")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 7, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 8, TypeName = "varchar(1000)")]
       public string? row_text1 { get; set; }

       [Column("rec_type", Order = 9, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("isin_indicator", Order = 10, TypeName = "varchar(1)")]
       public string? isin_indicator { get; set; }

       [Column("record_dt", Order = 11, TypeName = "varchar(8)")]
       public string? record_dt { get; set; }

       [Column("record_pre_dt", Order = 12, TypeName = "varchar(8)")]
       public string? record_pre_dt { get; set; }

       [Column("record_pre_time", Order = 13, TypeName = "varchar(6)")]
       public string? record_pre_time { get; set; }

       [Column("tot_no_of_det_rec", Order = 14, TypeName = "varchar(7)")]
       public string? tot_no_of_det_rec { get; set; }

       [Column("filler", Order = 15, TypeName = "varchar(10)")]
       public string? filler { get; set; }

       [Column("user_name", Order = 16, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 17, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
