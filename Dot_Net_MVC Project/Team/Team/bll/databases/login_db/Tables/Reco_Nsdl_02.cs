using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Reco_Nsdl_02
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

       [Column("row_file_name", Order = 10, TypeName = "varchar(1000)")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 11, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 12, TypeName = "varchar(1000)")]
       public string? row_text1 { get; set; }

       [Column("rec_type", Order = 13, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("line_no", Order = 14, TypeName = "varchar(7)")]
       public string? line_no { get; set; }

       [Column("isin_no", Order = 15, TypeName = "varchar(12)")]
       public string? isin_no { get; set; }

       [Column("isin_comp_short", Order = 16, TypeName = "varchar(140)")]
       public string? isin_comp_short { get; set; }

       [Column("isin_comp_name", Order = 17, TypeName = "varchar(140)")]
       public string? isin_comp_name { get; set; }

       [Column("flag_for_decimal_isin", Order = 18, TypeName = "varchar(18)")]
       public string? flag_for_decimal_isin { get; set; }

       [Column("nsdl_free_positions", Order = 19, TypeName = "varchar(18)")]
       public string? nsdl_free_positions { get; set; }

       [Column("nsdl_lock_positions", Order = 20, TypeName = "varchar(18)")]
       public string? nsdl_lock_positions { get; set; }

       [Column("nsdl_unlock_balance", Order = 21, TypeName = "varchar(18)")]
       public string? nsdl_unlock_balance { get; set; }

       [Column("nsdl_lock_balance", Order = 22, TypeName = "varchar(18)")]
       public string? nsdl_lock_balance { get; set; }

       [Column("pending_demat_balance", Order = 23, TypeName = "varchar(18)")]
       public string? pending_demat_balance { get; set; }

       [Column("pending_remat_free_balance", Order = 24, TypeName = "varchar(18)")]
       public string? pending_remat_free_balance { get; set; }

       [Column("pending_remat_lock_balance", Order = 25, TypeName = "varchar(18)")]
       public string? pending_remat_lock_balance { get; set; }

       [Column("nsdl_delivery_transit_balance", Order = 26, TypeName = "varchar(18)")]
       public string? nsdl_delivery_transit_balance { get; set; }

       [Column("nsdl_receipt_transit_balance", Order = 27, TypeName = "varchar(18)")]
       public string? nsdl_receipt_transit_balance { get; set; }

       [Column("filler", Order = 28, TypeName = "varchar(162)")]
       public string? filler { get; set; }

       [Column("security_type", Order = 29, TypeName = "varchar(2)")]
       public string? security_type { get; set; }

       [Column("filler2", Order = 30, TypeName = "varchar(13)")]
       public string? filler2 { get; set; }

       [Column("user_name", Order = 31, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 32, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
