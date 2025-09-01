using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Inter_Depository_02
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("int_dep_02_ref_no", Order = 2, TypeName = "double(18,3)")]
       public long? int_dep_02_ref_no { get; set; }

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

       [Column("line_no", Order = 11, TypeName = "varchar(7)")]
       public string? line_no { get; set; }

       [Column("batch_no", Order = 12, TypeName = "varchar(12)")]
       public string? batch_no { get; set; }

       [Column("isin_no", Order = 13, TypeName = "varchar(12)")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 14, TypeName = "text")]
       public string? isin_comp_name { get; set; }

       [Column("transfer_qty", Order = 15, TypeName = "varchar(18)")]
       public string? transfer_qty { get; set; }

       [Column("inst_rece_dt", Order = 16, TypeName = "varchar(8)")]
       public string? inst_rece_dt { get; set; }

       [Column("inst_acpt_rejt_dt", Order = 17, TypeName = "varchar(8)")]
       public string? inst_acpt_rejt_dt { get; set; }

       [Column("inst_conf_rele_dt", Order = 18, TypeName = "varchar(8)")]
       public string? inst_conf_rele_dt { get; set; }

       [Column("conf_flag", Order = 19, TypeName = "varchar(1)")]
       public string? conf_flag { get; set; }

       [Column("rej_code1", Order = 20, TypeName = "varchar(4)")]
       public string? rej_code1 { get; set; }

       [Column("rej_code2", Order = 21, TypeName = "varchar(4)")]
       public string? rej_code2 { get; set; }

       [Column("rej_code3", Order = 22, TypeName = "varchar(4)")]
       public string? rej_code3 { get; set; }

       [Column("rej_code4", Order = 23, TypeName = "varchar(4)")]
       public string? rej_code4 { get; set; }

       [Column("status_type", Order = 24, TypeName = "varchar(2)")]
       public string? status_type { get; set; }

       [Column("filler", Order = 25, TypeName = "varchar(11)")]
       public string? filler { get; set; }

       [Column("user_name", Order = 26, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 27, TypeName = "text")]
       public string? computer_id { get; set; }

       [Column("trx_no", Order = 28, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("tmp_trx_no", Order = 29, TypeName = "varchar(50)")]
       public string? tmp_trx_no { get; set; }

       [Column("trx_batch_no", Order = 30, TypeName = "text")]
       public string? trx_batch_no { get; set; }

       [Column("trx_date", Order = 31, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("idt_record_date", Order = 32, TypeName = "datetime")]
       public DateTime? idt_record_date { get; set; }

       [Column("idt_record_date_text", Order = 33, TypeName = "varchar(20)")]
       public string? idt_record_date_text { get; set; }

   }
}
