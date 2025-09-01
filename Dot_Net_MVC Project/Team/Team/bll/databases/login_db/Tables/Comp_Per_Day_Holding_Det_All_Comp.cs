using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Comp_Per_Day_Holding_Det_All_Comp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_auto_id { get; set; }

       [Column("trx_id", Order = 3, TypeName = "float")]
       public long? trx_id { get; set; }

       [Column("lock_yn", Order = 4, TypeName = "varchar(3)")]
       public string? lock_yn { get; set; }

       [Column("mix_match_yn", Order = 5, TypeName = "varchar(3)")]
       public string? mix_match_yn { get; set; }

       [Column("import_date", Order = 6, TypeName = "datetime")]
       public DateTime? import_date { get; set; }

       [Column("import_day_name", Order = 7, TypeName = "text")]
       public string? import_day_name { get; set; }

       [Column("file_exchange_name", Order = 8, TypeName = "text")]
       public string? file_exchange_name { get; set; }

       [Column("isin_no", Order = 9, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("isin_comp_name", Order = 10, TypeName = "text")]
       public string? isin_comp_name { get; set; }

       [Column("paid_up_capital_qty_op", Order = 11, TypeName = "float")]
       public long? paid_up_capital_qty_op { get; set; }

       [Column("pre_day_holding_qty_phy", Order = 12, TypeName = "float")]
       public long? pre_day_holding_qty_phy { get; set; }

       [Column("pre_day_holding_qty_cdsl", Order = 13, TypeName = "float")]
       public long? pre_day_holding_qty_cdsl { get; set; }

       [Column("pre_day_holding_qty_nsdl", Order = 14, TypeName = "float")]
       public long? pre_day_holding_qty_nsdl { get; set; }

       [Column("cdsl_in_nsdl_out_qty", Order = 15, TypeName = "float")]
       public long? cdsl_in_nsdl_out_qty { get; set; }

       [Column("nsdl_in_cdsl_out_qty", Order = 16, TypeName = "float")]
       public long? nsdl_in_cdsl_out_qty { get; set; }

       [Column("cdsl_demat_qty", Order = 17, TypeName = "float")]
       public long? cdsl_demat_qty { get; set; }

       [Column("nsdl_demat_qty", Order = 18, TypeName = "float")]
       public long? nsdl_demat_qty { get; set; }

       [Column("cdsl_re_demat_qty", Order = 19, TypeName = "float")]
       public long? cdsl_re_demat_qty { get; set; }

       [Column("nsdl_re_demat_qty", Order = 20, TypeName = "float")]
       public long? nsdl_re_demat_qty { get; set; }

       [Column("cdsl_ca_credit_qty", Order = 21, TypeName = "float")]
       public long? cdsl_ca_credit_qty { get; set; }

       [Column("cdsl_ca_debit_qty", Order = 22, TypeName = "float")]
       public long? cdsl_ca_debit_qty { get; set; }

       [Column("nsdl_ca_credit_qty", Order = 23, TypeName = "float")]
       public long? nsdl_ca_credit_qty { get; set; }

       [Column("nsdl_ca_debit_qty", Order = 24, TypeName = "float")]
       public long? nsdl_ca_debit_qty { get; set; }

       [Column("phy_ca_credit_qty", Order = 25, TypeName = "float")]
       public long? phy_ca_credit_qty { get; set; }

       [Column("phy_ca_debit_qty", Order = 26, TypeName = "float")]
       public long? phy_ca_debit_qty { get; set; }

       [Column("cur_holding_qty_phy", Order = 27, TypeName = "float")]
       public long? cur_holding_qty_phy { get; set; }

       [Column("cur_holding_qty_cdsl", Order = 28, TypeName = "float")]
       public long? cur_holding_qty_cdsl { get; set; }

       [Column("cur_holding_qty_nsdl", Order = 29, TypeName = "float")]
       public long? cur_holding_qty_nsdl { get; set; }

       [Column("exch_closing_qty_cdsl", Order = 30, TypeName = "float")]
       public long? exch_closing_qty_cdsl { get; set; }

       [Column("exch_cls_qty_remark_cdsl", Order = 31, TypeName = "text")]
       public string? exch_cls_qty_remark_cdsl { get; set; }

       [Column("exch_closing_qty_nsdl", Order = 32, TypeName = "float")]
       public long? exch_closing_qty_nsdl { get; set; }

       [Column("exch_cls_qty_remark_nsdl", Order = 33, TypeName = "text")]
       public string? exch_cls_qty_remark_nsdl { get; set; }

       [Column("paid_up_capital_qty_cls", Order = 34, TypeName = "float")]
       public long? paid_up_capital_qty_cls { get; set; }

       [Column("paid_up_capital_qty_cls_reco_nsdl", Order = 35, TypeName = "float")]
       public long? paid_up_capital_qty_cls_reco_nsdl { get; set; }

       [Column("paid_up_capital_qty_cls_reco_cdsl", Order = 36, TypeName = "float")]
       public long? paid_up_capital_qty_cls_reco_cdsl { get; set; }

       [Column("user_name", Order = 37, TypeName = "text")]
       public string? user_name { get; set; }

       [Column("computer_id", Order = 38, TypeName = "text")]
       public string? computer_id { get; set; }

   }
}
