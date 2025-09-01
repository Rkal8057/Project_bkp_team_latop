using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("holding_as_on_date_master")] 
       
   public class Holding_As_On_Date_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_id { get; set; }

       [Column("comp_sno", Order = 3, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 4, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 5, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 6, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("member_register_date", Order = 7, TypeName = "datetime")]
       public DateTime? member_register_date { get; set; }

       [Column("execution_date", Order = 8, TypeName = "datetime")]
       public DateTime? execution_date { get; set; }

       [Column("holding_as_on_date", Order = 9, TypeName = "float")]
       public long? holding_as_on_date { get; set; }

       [Column("paid_up_capital_qty_all", Order = 10, TypeName = "float")]
       public long? paid_up_capital_qty_all { get; set; }

       [Column("paid_up_capital_qty_phy", Order = 11, TypeName = "float")]
       public long? paid_up_capital_qty_phy { get; set; }

       [Column("paid_up_capital_qty_cdsl", Order = 12, TypeName = "float")]
       public long? paid_up_capital_qty_cdsl { get; set; }

       [Column("paid_up_capital_qty_ndsl", Order = 13, TypeName = "float")]
       public long? paid_up_capital_qty_ndsl { get; set; }

       [Column("paid_up_capital_qty_ndsl_cdsl", Order = 14, TypeName = "float")]
       public long? paid_up_capital_qty_ndsl_cdsl { get; set; }

       [Column("autual_phy_qtylabel", Order = 15, TypeName = "float")]
       public long? autual_phy_qtylabel { get; set; }

   }
}
