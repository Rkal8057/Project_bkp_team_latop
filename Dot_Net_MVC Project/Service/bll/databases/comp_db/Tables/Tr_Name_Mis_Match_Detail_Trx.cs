using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_name_mis_match_detail_trx")] 
       
   public class Tr_Name_Mis_Match_Detail_Trx
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("comp_isin", Order = 3, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("trfno", Order = 4, TypeName = "bigint(10)")]
       public long? trfno { get; set; }

       [Column("master_req_id", Order = 5, TypeName = "bigint(10)")]
       public long? master_req_id { get; set; }

       [Column("reason_table_id", Order = 6, TypeName = "bigint(10)")]
       public long? reason_table_id { get; set; }

       [Column("reason_detail", Order = 7, TypeName = "varchar(50)")]
       public string? reason_detail { get; set; }

       [Column("reason_code", Order = 8, TypeName = "varchar(60)")]
       public string? reason_code { get; set; }

       [Column("selected_yn", Order = 9, TypeName = "varchar(3)")]
       public string? selected_yn { get; set; }

   }
}
