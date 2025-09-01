using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("company_ca_history_detail_08072022_t_111401")] 
       
   public class Company_Ca_History_Detail_08072022_T_111401
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "varchar(50)")]
       public string? trx_no { get; set; }

       [Column("trx_date", Order = 4, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("trx_type", Order = 5, TypeName = "varchar(50)")]
       public string? trx_type { get; set; }

       [Column("trx_remark", Order = 6, TypeName = "varchar(50)")]
       public string? trx_remark { get; set; }

       [Column("opening_date", Order = 7, TypeName = "datetime")]
       public DateTime? opening_date { get; set; }

       [Column("closing_date", Order = 8, TypeName = "datetime")]
       public DateTime? closing_date { get; set; }

       [Column("comp_sno", Order = 9, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("isin_no", Order = 10, TypeName = "varchar(50)")]
       public string? isin_no { get; set; }

       [Column("comp_name", Order = 11, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 12, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("paid_up_capital_qty", Order = 13, TypeName = "float")]
       public long? paid_up_capital_qty { get; set; }

       [Column("paid_up_capital_amt", Order = 14, TypeName = "float")]
       public long? paid_up_capital_amt { get; set; }

       [Column("qty_phy", Order = 15, TypeName = "float")]
       public long? qty_phy { get; set; }

       [Column("qty_cdsl", Order = 16, TypeName = "float")]
       public long? qty_cdsl { get; set; }

       [Column("qty_nsdl", Order = 17, TypeName = "float")]
       public long? qty_nsdl { get; set; }

       [Column("share_price", Order = 18, TypeName = "float")]
       public long? share_price { get; set; }

       [Column("qty_phy_fully", Order = 19, TypeName = "float")]
       public long? qty_phy_fully { get; set; }

       [Column("qty_cdsl_fully", Order = 20, TypeName = "float")]
       public long? qty_cdsl_fully { get; set; }

       [Column("qty_nsdl_fully", Order = 21, TypeName = "float")]
       public long? qty_nsdl_fully { get; set; }

       [Column("share_price_fully", Order = 22, TypeName = "float")]
       public long? share_price_fully { get; set; }

       [Column("qty_phy_partly", Order = 23, TypeName = "float")]
       public long? qty_phy_partly { get; set; }

       [Column("qty_cdsl_partly", Order = 24, TypeName = "float")]
       public long? qty_cdsl_partly { get; set; }

       [Column("qty_nsdl_partly", Order = 25, TypeName = "float")]
       public long? qty_nsdl_partly { get; set; }

       [Column("share_price_partly", Order = 26, TypeName = "float")]
       public long? share_price_partly { get; set; }

       [Column("value_date", Order = 27, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("user_name", Order = 28, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("maker_user_name", Order = 29, TypeName = "varchar(50)")]
       public string? maker_user_name { get; set; }

       [Column("checker_user_name", Order = 30, TypeName = "varchar(50)")]
       public string? checker_user_name { get; set; }

       [Column("current_status", Order = 31, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("record_status", Order = 32, TypeName = "varchar(50)")]
       public string? record_status { get; set; }

       [Column("computer_id", Order = 33, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

   }
}
