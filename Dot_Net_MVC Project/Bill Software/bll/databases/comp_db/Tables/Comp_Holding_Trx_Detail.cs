using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("comp_holding_trx_detail")] 
       
   public class Comp_Holding_Trx_Detail
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("comp_holding_trn_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? comp_holding_trn_auto_id { get; set; }

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

       [Column("isin_comp_name", Order = 11, TypeName = "varchar(50)")]
       public string? isin_comp_name { get; set; }

       [Column("comp_paid_up_capital_qty", Order = 12, TypeName = "float")]
       public long? comp_paid_up_capital_qty { get; set; }

       [Column("trx_holding_qty_phy", Order = 13, TypeName = "float")]
       public long? trx_holding_qty_phy { get; set; }

       [Column("trx_holding_qty_cdsl", Order = 14, TypeName = "float")]
       public long? trx_holding_qty_cdsl { get; set; }

       [Column("trx_holding_qty_nsdl", Order = 15, TypeName = "float")]
       public long? trx_holding_qty_nsdl { get; set; }

       [Column("trx_holding_share_price", Order = 16, TypeName = "float")]
       public long? trx_holding_share_price { get; set; }

       [Column("trx_holding_qty_phy_fully", Order = 17, TypeName = "float")]
       public long? trx_holding_qty_phy_fully { get; set; }

       [Column("trx_holding_qty_cdsl_fully", Order = 18, TypeName = "float")]
       public long? trx_holding_qty_cdsl_fully { get; set; }

       [Column("trx_holding_qty_nsdl_fully", Order = 19, TypeName = "float")]
       public long? trx_holding_qty_nsdl_fully { get; set; }

       [Column("trx_holding_share_price_partly", Order = 20, TypeName = "float")]
       public long? trx_holding_share_price_partly { get; set; }

       [Column("trx_holding_qty_phy_partly", Order = 21, TypeName = "float")]
       public long? trx_holding_qty_phy_partly { get; set; }

       [Column("trx_holding_qty_cdsl_partly", Order = 22, TypeName = "float")]
       public long? trx_holding_qty_cdsl_partly { get; set; }

       [Column("trx_holding_qty_nsdl_partly", Order = 23, TypeName = "float")]
       public long? trx_holding_qty_nsdl_partly { get; set; }

       [Column("value_date", Order = 24, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("user_name", Order = 25, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 26, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

   }
}
