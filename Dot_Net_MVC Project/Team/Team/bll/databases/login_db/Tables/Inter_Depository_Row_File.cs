using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Inter_Depository_Row_File
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("ref_no", Order = 2, TypeName = "double(18,3)")]
       public long? ref_no { get; set; }

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

       [Column("user_name", Order = 9, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 10, TypeName = "text")]
       public string? computer_id { get; set; }

       [Column("trx_no", Order = 11, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("tmp_trx_no", Order = 12, TypeName = "varchar(50)")]
       public string? tmp_trx_no { get; set; }

       [Column("trx_batch_no", Order = 13, TypeName = "text")]
       public string? trx_batch_no { get; set; }

       [Column("trx_date", Order = 14, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("idt_record_date", Order = 15, TypeName = "datetime")]
       public DateTime? idt_record_date { get; set; }

       [Column("idt_record_date_text", Order = 16, TypeName = "varchar(20)")]
       public string? idt_record_date_text { get; set; }

   }
}
