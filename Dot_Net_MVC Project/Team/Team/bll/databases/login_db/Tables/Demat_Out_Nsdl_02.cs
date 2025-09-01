using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Demat_Out_Nsdl_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("req_rec_online_isin_no", Order = 3, TypeName = "text")]
       public string? req_rec_online_isin_no { get; set; }

       [Column("req_rec_online_isin_company", Order = 4, TypeName = "text")]
       public string? req_rec_online_isin_company { get; set; }

       [Column("req_rec_online_trx_no", Order = 5, TypeName = "float")]
       public long? req_rec_online_trx_no { get; set; }

       [Column("trx_no", Order = 6, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 7, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("trx_date", Order = 8, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("req_rec_record_date", Order = 9, TypeName = "datetime")]
       public DateTime? req_rec_record_date { get; set; }

       [Column("req_rec_record_date_text", Order = 10, TypeName = "varchar(20)")]
       public string? req_rec_record_date_text { get; set; }

       [Column("batch_number", Order = 11, TypeName = "varchar(20)")]
       public string? batch_number { get; set; }

       [Column("record_type", Order = 12, TypeName = "varchar(20)")]
       public string? record_type { get; set; }

       [Column("line_number", Order = 13, TypeName = "float")]
       public long? line_number { get; set; }

       [Column("transaction_type", Order = 14, TypeName = "float")]
       public long? transaction_type { get; set; }

       [Column("transaction_flag", Order = 15, TypeName = "varchar(10)")]
       public string? transaction_flag { get; set; }

       [Column("instruction_id", Order = 16, TypeName = "varchar(140)")]
       public string? instruction_id { get; set; }

       [Column("internal_reference_number", Order = 17, TypeName = "varchar(235)")]
       public string? internal_reference_number { get; set; }

       [Column("sender_reference_number_1", Order = 18, TypeName = "varchar(250)")]
       public string? sender_reference_number_1 { get; set; }

       [Column("sender_reference_number_2", Order = 19, TypeName = "varchar(250)")]
       public string? sender_reference_number_2 { get; set; }

       [Column("filler_02", Order = 20, TypeName = "varchar(20)")]
       public string? filler_02 { get; set; }

   }
}
