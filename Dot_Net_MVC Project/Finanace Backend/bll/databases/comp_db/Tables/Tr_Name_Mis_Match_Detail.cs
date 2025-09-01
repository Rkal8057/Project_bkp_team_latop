using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_name_mis_match_detail")] 
       
   public class Tr_Name_Mis_Match_Detail
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("table_trx_date", Order = 3, TypeName = "datetime")]
       public DateTime? table_trx_date { get; set; }

       [Column("created_on", Order = 4, TypeName = "datetime")]
       public DateTime? created_on { get; set; }

       [Column("updated_on", Order = 5, TypeName = "datetime")]
       public DateTime? updated_on { get; set; }

       [Column("master_req_id", Order = 6, TypeName = "float")]
       public long? master_req_id { get; set; }

       [Column("comp_sno", Order = 7, TypeName = "bigint(10)")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 8, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 9, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 10, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("selected_table", Order = 11, TypeName = "varchar(100)")]
       public string? selected_table { get; set; }

       [Column("trfno", Order = 12, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trfdate", Order = 13, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("foliono", Order = 14, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("form_name", Order = 15, TypeName = "varchar(100)")]
       public string? form_name { get; set; }

       [Column("unique_trn_id", Order = 16, TypeName = "varchar(100)")]
       public string? unique_trn_id { get; set; }

       [Column("user_id", Order = 17, TypeName = "float")]
       public long? user_id { get; set; }

       [Column("user_name", Order = 18, TypeName = "varchar(100)")]
       public string? user_name { get; set; }

       [Column("current_status", Order = 19, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("maker_id", Order = 20, TypeName = "float")]
       public long? maker_id { get; set; }

       [Column("maker_name", Order = 21, TypeName = "varchar(50)")]
       public string? maker_name { get; set; }

       [Column("maker_remark", Order = 22, TypeName = "varchar(50)")]
       public string? maker_remark { get; set; }

       [Column("checker_id", Order = 23, TypeName = "float")]
       public long? checker_id { get; set; }

       [Column("checker_name", Order = 24, TypeName = "varchar(50)")]
       public string? checker_name { get; set; }

       [Column("checker_remark", Order = 25, TypeName = "varchar(50)")]
       public string? checker_remark { get; set; }

       [Column("trx_remark", Order = 26, TypeName = "varchar(50)")]
       public string? trx_remark { get; set; }

   }
}
