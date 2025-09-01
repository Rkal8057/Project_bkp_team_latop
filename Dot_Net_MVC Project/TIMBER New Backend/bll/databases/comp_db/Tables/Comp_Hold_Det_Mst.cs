using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("comp_hold_det_mst")] 
       
   public class Comp_Hold_Det_Mst
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_atuo_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_atuo_id { get; set; }

       [Column("comp_sno", Order = 3, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("opening_date", Order = 4, TypeName = "datetime")]
       public DateTime? opening_date { get; set; }

       [Column("isin_no", Order = 5, TypeName = "varchar(50)")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 6, TypeName = "varchar(50)")]
       public string? isin_comp_name { get; set; }

       [Column("comp_paid_up_capital_qty", Order = 7, TypeName = "float")]
       public long? comp_paid_up_capital_qty { get; set; }

       [Column("op_holding_qty_phy", Order = 8, TypeName = "float")]
       public long? op_holding_qty_phy { get; set; }

       [Column("op_holding_qty_cdsl", Order = 9, TypeName = "float")]
       public long? op_holding_qty_cdsl { get; set; }

       [Column("op_holding_qty_nsdl", Order = 10, TypeName = "float")]
       public long? op_holding_qty_nsdl { get; set; }

       [Column("value_date", Order = 11, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("user_name", Order = 12, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 13, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

       [Column("opening_status", Order = 14, TypeName = "varchar(100)")]
       public string? opening_status { get; set; }

       [Column("update_type", Order = 15, TypeName = "varchar(100)")]
       public string? update_type { get; set; }

       [Column("update_remark", Order = 16, TypeName = "varchar(50)")]
       public string? update_remark { get; set; }

       [Column("credit_debit", Order = 17, TypeName = "varchar(50)")]
       public string? credit_debit { get; set; }

       [Column("update_qty", Order = 18, TypeName = "double(18,3)")]
       public long? update_qty { get; set; }

       [Column("update_exchange", Order = 19, TypeName = "varchar(100)")]
       public string? update_exchange { get; set; }

       [Column("trx_type", Order = 20, TypeName = "varchar(50)")]
       public string? trx_type { get; set; }

       [Column("closing_date", Order = 21, TypeName = "datetime")]
       public DateTime? closing_date { get; set; }

   }
}
