using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Inter_Depository_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("int_dep_01_ref_no", Order = 2, TypeName = "double(18,3)")]
       public long? int_dep_01_ref_no { get; set; }

       [Column("ref_date", Order = 3, TypeName = "datetime")]
       public DateTime? ref_date { get; set; }

       [Column("enter_date", Order = 4, TypeName = "datetime")]
       public DateTime? enter_date { get; set; }

       [Column("row_file_name", Order = 5, TypeName = "varchar(1000)")]
       public string? row_file_name { get; set; }

       [Column("file_exchange_name", Order = 6, TypeName = "varchar(100)")]
       public string? file_exchange_name { get; set; }

       [Column("row_text1", Order = 7, TypeName = "text")]
       public string? row_text1 { get; set; }

       [Column("row_header_type", Order = 8, TypeName = "varchar(2)")]
       public string? row_header_type { get; set; }

       [Column("int_dep_id", Order = 9, TypeName = "double(18,3)")]
       public long? int_dep_id { get; set; }

       [Column("rec_type", Order = 10, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("isin_indicator", Order = 11, TypeName = "varchar(1)")]
       public string? isin_indicator { get; set; }

       [Column("deli_dp_id", Order = 12, TypeName = "varchar(8)")]
       public string? deli_dp_id { get; set; }

       [Column("reci_dp_id", Order = 13, TypeName = "varchar(8)")]
       public string? reci_dp_id { get; set; }

       [Column("tot_trans_qty", Order = 14, TypeName = "varchar(18)")]
       public string? tot_trans_qty { get; set; }

       [Column("state_dt", Order = 15, TypeName = "varchar(8)")]
       public string? state_dt { get; set; }

       [Column("state_pre_dt", Order = 16, TypeName = "varchar(8)")]
       public string? state_pre_dt { get; set; }

       [Column("state_pre_time", Order = 17, TypeName = "varchar(6)")]
       public string? state_pre_time { get; set; }

       [Column("tot_no_of_det_rec", Order = 18, TypeName = "varchar(7)")]
       public string? tot_no_of_det_rec { get; set; }

       [Column("filler", Order = 19, TypeName = "varchar(9)")]
       public string? filler { get; set; }

       [Column("user_name", Order = 20, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 21, TypeName = "text")]
       public string? computer_id { get; set; }

       [Column("trx_no", Order = 22, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("tmp_trx_no", Order = 23, TypeName = "varchar(50)")]
       public string? tmp_trx_no { get; set; }

       [Column("trx_batch_no", Order = 24, TypeName = "text")]
       public string? trx_batch_no { get; set; }

       [Column("trx_date", Order = 25, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("idt_record_date", Order = 26, TypeName = "datetime")]
       public DateTime? idt_record_date { get; set; }

       [Column("idt_record_date_text", Order = 27, TypeName = "varchar(20)")]
       public string? idt_record_date_text { get; set; }

   }
}
