using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Letter_Alert_4_Phy_Trx
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("master_trx_table_id", Order = 2, TypeName = "bigint(10)")]
       public long? master_trx_table_id { get; set; }

       [Column("master_table_id", Order = 3, TypeName = "float")]
       public long? master_table_id { get; set; }

       [Column("exchange_name", Order = 4, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("letter_status", Order = 5, TypeName = "text")]
       public string? letter_status { get; set; }

       [Column("trx_no_master", Order = 6, TypeName = "float")]
       public long? trx_no_master { get; set; }

       [Column("req_id_master", Order = 7, TypeName = "float")]
       public long? req_id_master { get; set; }

       [Column("in_ward_id_master", Order = 8, TypeName = "float")]
       public long? in_ward_id_master { get; set; }

       [Column("out_ward_id_master", Order = 9, TypeName = "float")]
       public long? out_ward_id_master { get; set; }

       [Column("trfdate", Order = 10, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("trfolio", Order = 11, TypeName = "text")]
       public string? trfolio { get; set; }

       [Column("certno", Order = 12, TypeName = "text")]
       public string? certno { get; set; }

       [Column("certno_old", Order = 13, TypeName = "text")]
       public string? certno_old { get; set; }

       [Column("distno", Order = 14, TypeName = "float")]
       public long? distno { get; set; }

       [Column("distno_upto", Order = 15, TypeName = "float")]
       public long? distno_upto { get; set; }

       [Column("old_distno", Order = 16, TypeName = "float")]
       public long? old_distno { get; set; }

       [Column("shares", Order = 17, TypeName = "float")]
       public long? shares { get; set; }

       [Column("letter_no", Order = 18, TypeName = "text")]
       public string? letter_no { get; set; }

       [Column("letter_date_issue", Order = 19, TypeName = "datetime")]
       public DateTime? letter_date_issue { get; set; }

       [Column("letter_date_close", Order = 20, TypeName = "datetime")]
       public DateTime? letter_date_close { get; set; }

       [Column("letter_date_next", Order = 21, TypeName = "datetime")]
       public DateTime? letter_date_next { get; set; }

       [Column("next_remi_after_days_no", Order = 22, TypeName = "float")]
       public long? next_remi_after_days_no { get; set; }

       [Column("next_remi_after_days", Order = 23, TypeName = "text")]
       public string? next_remi_after_days { get; set; }

       [Column("remark_detail", Order = 24, TypeName = "text")]
       public string? remark_detail { get; set; }

       [Column("user_name", Order = 25, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("created_on", Order = 26, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 27, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

   }
}
