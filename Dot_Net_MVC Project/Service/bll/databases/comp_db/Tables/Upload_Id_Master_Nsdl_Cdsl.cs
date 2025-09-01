using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("upload_id_master_nsdl_cdsl")] 
       
   public class Upload_Id_Master_Nsdl_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("create_id", Order = 2, TypeName = "bigint(10)")]
       public long? create_id { get; set; }

       [Column("record_identification", Order = 3, TypeName = "varchar(2)")]
       public string? record_identification { get; set; }

       [Column("year_no", Order = 4, TypeName = "varchar(4)")]
       public string? year_no { get; set; }

       [Column("month_no", Order = 5, TypeName = "varchar(2)")]
       public string? month_no { get; set; }

       [Column("exchange_name", Order = 6, TypeName = "varchar(10)")]
       public string? exchange_name { get; set; }

       [Column("batch_sno", Order = 7, TypeName = "float")]
       public long? batch_sno { get; set; }

       [Column("batch_id_number", Order = 8, TypeName = "varchar(8)")]
       public string? batch_id_number { get; set; }

       [Column("batch_date", Order = 9, TypeName = "datetime")]
       public DateTime? batch_date { get; set; }

       [Column("shr_id", Order = 10, TypeName = "varchar(10)")]
       public string? shr_id { get; set; }

       [Column("batch_id", Order = 11, TypeName = "varchar(8)")]
       public string? batch_id { get; set; }

       [Column("rta_id", Order = 12, TypeName = "varchar(8)")]
       public string? rta_id { get; set; }

       [Column("depository_id", Order = 13, TypeName = "varchar(8)")]
       public string? depository_id { get; set; }

       [Column("isin_of_company", Order = 14, TypeName = "varchar(12)")]
       public string? isin_of_company { get; set; }

       [Column("isin_detail", Order = 15, TypeName = "varchar(100)")]
       public string? isin_detail { get; set; }

       [Column("cut_off_date", Order = 16, TypeName = "varchar(8)")]
       public string? cut_off_date { get; set; }

       [Column("number_of_shares", Order = 17, TypeName = "float")]
       public long? number_of_shares { get; set; }

       [Column("number_of_records", Order = 18, TypeName = "float")]
       public long? number_of_records { get; set; }

       [Column("even_no", Order = 19, TypeName = "varchar(12)")]
       public string? even_no { get; set; }

       [Column("user_name", Order = 20, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("entry_date_time", Order = 21, TypeName = "datetime")]
       public DateTime? entry_date_time { get; set; }

   }
}
