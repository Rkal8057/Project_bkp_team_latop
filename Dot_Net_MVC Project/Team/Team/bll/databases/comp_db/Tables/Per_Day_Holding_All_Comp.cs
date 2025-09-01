using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("per_day_holding_all_comp")] 
       
   public class Per_Day_Holding_All_Comp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_auto_id { get; set; }

       [Column("trx_id", Order = 3, TypeName = "float")]
       public long? trx_id { get; set; }

       [Column("import_date", Order = 4, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("import_day_name", Order = 5, TypeName = "varchar(50)")]
       public string? import_day_name { get; set; }

       [Column("file_exchange_name", Order = 6, TypeName = "varchar(50)")]
       public string? file_exchange_name { get; set; }

       [Column("isin_no", Order = 7, TypeName = "varchar(50)")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 8, TypeName = "varchar(50)")]
       public string? isin_comp_name { get; set; }

       [Column("paid_up_capital_qty_op", Order = 9, TypeName = "float")]
       public long? paid_up_capital_qty_op { get; set; }

       [Column("pre_day_holding_qty_phy", Order = 10, TypeName = "float")]
       public long? pre_day_holding_qty_phy { get; set; }

       [Column("pre_day_holding_qty_cdsl", Order = 11, TypeName = "float")]
       public long? pre_day_holding_qty_cdsl { get; set; }

       [Column("pre_day_holding_qty_nsdl", Order = 12, TypeName = "float")]
       public long? pre_day_holding_qty_nsdl { get; set; }

       [Column("cdsl_in_nsdl_out_qty", Order = 13, TypeName = "float")]
       public long? cdsl_in_nsdl_out_qty { get; set; }

       [Column("nsdl_in_cdsl_out_qty", Order = 14, TypeName = "float")]
       public long? nsdl_in_cdsl_out_qty { get; set; }

       [Column("cdsl_demat_qty", Order = 15, TypeName = "float")]
       public long? cdsl_demat_qty { get; set; }

       [Column("nsdl_demat_qty", Order = 16, TypeName = "float")]
       public long? nsdl_demat_qty { get; set; }

       [Column("cdsl_re_demat_qty", Order = 17, TypeName = "float")]
       public long? cdsl_re_demat_qty { get; set; }

       [Column("nsdl_re_demat_qty", Order = 18, TypeName = "float")]
       public long? nsdl_re_demat_qty { get; set; }

       [Column("cur_holding_qty_phy", Order = 19, TypeName = "float")]
       public long? cur_holding_qty_phy { get; set; }

       [Column("cur_holding_qty_cdsl", Order = 20, TypeName = "float")]
       public long? cur_holding_qty_cdsl { get; set; }

       [Column("cur_holding_qty_nsdl", Order = 21, TypeName = "float")]
       public long? cur_holding_qty_nsdl { get; set; }

       [Column("exch_closing_qty_cdsl", Order = 22, TypeName = "float")]
       public long? exch_closing_qty_cdsl { get; set; }

       [Column("exch_cls_qty_remark_cdsl", Order = 23, TypeName = "varchar(50)")]
       public string? exch_cls_qty_remark_cdsl { get; set; }

       [Column("exch_closing_qty_nsdl", Order = 24, TypeName = "float")]
       public long? exch_closing_qty_nsdl { get; set; }

       [Column("exch_cls_qty_remark_nsdl", Order = 25, TypeName = "varchar(50)")]
       public string? exch_cls_qty_remark_nsdl { get; set; }

       [Column("paid_up_capital_qty_cls", Order = 26, TypeName = "float")]
       public long? paid_up_capital_qty_cls { get; set; }

       [Column("user_name", Order = 27, TypeName = "varchar(50)")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 28, TypeName = "varchar(50)")]
       public string? computer_id { get; set; }

   }
}
