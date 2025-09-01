using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reco_Cdsl_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("reco_import_trx_no", Order = 5, TypeName = "double(18,3)")]
       public long? reco_import_trx_no { get; set; }

       [Column("trx_date", Order = 6, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("reco_record_date", Order = 7, TypeName = "datetime")]
       public DateTime? reco_record_date { get; set; }

       [Column("reco_record_date_text", Order = 8, TypeName = "varchar(20)")]
       public string? reco_record_date_text { get; set; }

       [Column("enter_date", Order = 9, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 10, TypeName = "text")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 11, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 12, TypeName = "text")]
       public string? row_text1 { get; set; }

       [Column("record_type", Order = 13, TypeName = "varchar(2)")]
       public string? record_type { get; set; }

       [Column("isin_indicator", Order = 14, TypeName = "varchar(1)")]
       public string? isin_indicator { get; set; }

       [Column("record_dt", Order = 15, TypeName = "varchar(8)")]
       public string? record_dt { get; set; }

       [Column("record_pre_dt", Order = 16, TypeName = "varchar(8)")]
       public string? record_pre_dt { get; set; }

       [Column("record_pre_time", Order = 17, TypeName = "varchar(6)")]
       public string? record_pre_time { get; set; }

       [Column("tot_no_of_det_rec", Order = 18, TypeName = "varchar(7)")]
       public string? tot_no_of_det_rec { get; set; }

       [Column("filler", Order = 19, TypeName = "varchar(10)")]
       public string? filler { get; set; }

       [Column("user_name", Order = 20, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 21, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
