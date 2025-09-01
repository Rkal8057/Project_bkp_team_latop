using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Partytrn
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("party_cd", Order = 2, TypeName = "bigint(10)")]
       public long? party_cd { get; set; }

       [Column("party_name", Order = 3, TypeName = "text")]
       public string? party_name { get; set; }

       [Column("ac_group_code", Order = 4, TypeName = "double(18,3)")]
       public long? ac_group_code { get; set; }

       [Column("ac_group_name", Order = 5, TypeName = "text")]
       public string? ac_group_name { get; set; }

       [Column("company_and_isin", Order = 6, TypeName = "text")]
       public string? company_and_isin { get; set; }

       [Column("company_name", Order = 7, TypeName = "text")]
       public string? company_name { get; set; }

       [Column("company_isin", Order = 8, TypeName = "text")]
       public string? company_isin { get; set; }

       [Column("fin_year", Order = 9, TypeName = "varchar(9)")]
       public string? fin_year { get; set; }

       [Column("bill_date", Order = 10, TypeName = "datetime")]
       public DateTime? bill_date { get; set; }

       [Column("narr", Order = 11, TypeName = "text")]
       public string? narr { get; set; }

       [Column("debit", Order = 12, TypeName = "double(18,3)")]
       public long? debit { get; set; }

       [Column("credit", Order = 13, TypeName = "double(18,3)")]
       public long? credit { get; set; }

       [Column("inwoutno", Order = 14, TypeName = "text")]
       public string? inwoutno { get; set; }

       [Column("gross_amt_all", Order = 15, TypeName = "double(18,3)")]
       public long? gross_amt_all { get; set; }

       [Column("gst_amt_all", Order = 16, TypeName = "double(18,3)")]
       public long? gst_amt_all { get; set; }

       [Column("grand_amt_all", Order = 17, TypeName = "double(18,3)")]
       public long? grand_amt_all { get; set; }

       [Column("tax_type", Order = 18, TypeName = "text")]
       public string? tax_type { get; set; }

       [Column("tax_per", Order = 19, TypeName = "double(18,3)")]
       public long? tax_per { get; set; }

       [Column("tax_amt", Order = 20, TypeName = "double(18,3)")]
       public long? tax_amt { get; set; }

       [Column("aganist_narr", Order = 21, TypeName = "text")]
       public string? aganist_narr { get; set; }

       [Column("chequeno", Order = 22, TypeName = "text")]
       public string? chequeno { get; set; }

       [Column("folio", Order = 23, TypeName = "double(18,3)")]
       public long? folio { get; set; }

       [Column("folio_name", Order = 24, TypeName = "text")]
       public string? folio_name { get; set; }

       [Column("upd_flag", Order = 25, TypeName = "text")]
       public string? upd_flag { get; set; }

       [Column("del_flag", Order = 26, TypeName = "text")]
       public string? del_flag { get; set; }

       [Column("tot_qty", Order = 27, TypeName = "double(18,3)")]
       public long? tot_qty { get; set; }

       [Column("rate", Order = 28, TypeName = "double(18,3)")]
       public long? rate { get; set; }

       [Column("spot_ind", Order = 29, TypeName = "bigint(10)")]
       public long? spot_ind { get; set; }

       [Column("value_date", Order = 30, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("group_name", Order = 31, TypeName = "text")]
       public string? group_name { get; set; }

       [Column("groupx", Order = 32, TypeName = "text")]
       public string? groupx { get; set; }

       [Column("remark1", Order = 33, TypeName = "text")]
       public string? remark1 { get; set; }

       [Column("report_no", Order = 34, TypeName = "text")]
       public string? report_no { get; set; }

       [Column("mode_type", Order = 35, TypeName = "text")]
       public string? mode_type { get; set; }

       [Column("username", Order = 36, TypeName = "text")]
       public string? username { get; set; }

       [Column("auto_bill_nos", Order = 37, TypeName = "bigint(10)")]
       public long? auto_bill_nos { get; set; }

       [Column("s_no", Order = 38, TypeName = "double(18,3)")]
       public long? s_no { get; set; }

       [Column("ref_no_bill_no", Order = 39, TypeName = "varchar(100)")]
       public string? ref_no_bill_no { get; set; }

       [Column("ptrn_day_name", Order = 40, TypeName = "varchar(20)")]
       public string? ptrn_day_name { get; set; }

       [Column("ptrn_date", Order = 41, TypeName = "varchar(2)")]
       public string? ptrn_date { get; set; }

       [Column("ptrn_month_no", Order = 42, TypeName = "double(18,3)")]
       public long? ptrn_month_no { get; set; }

       [Column("ptrn_month_name", Order = 43, TypeName = "varchar(15)")]
       public string? ptrn_month_name { get; set; }

       [Column("ptrn_year", Order = 44, TypeName = "varchar(15)")]
       public string? ptrn_year { get; set; }

       [Column("ptrn_gst_type", Order = 45, TypeName = "varchar(15)")]
       public string? ptrn_gst_type { get; set; }

       [Column("ptrn_gross_amt", Order = 46, TypeName = "double(18,3)")]
       public long? ptrn_gross_amt { get; set; }

       [Column("ptrn_tot_gst", Order = 47, TypeName = "double(18,3)")]
       public long? ptrn_tot_gst { get; set; }

       [Column("ptrn_vou_amt", Order = 48, TypeName = "double(18,3)")]
       public long? ptrn_vou_amt { get; set; }

       [Column("ptrn_igst_per", Order = 49, TypeName = "double(18,3)")]
       public long? ptrn_igst_per { get; set; }

       [Column("ptrn_igst_amt", Order = 50, TypeName = "double(18,3)")]
       public long? ptrn_igst_amt { get; set; }

       [Column("ptrn_sgst_per", Order = 51, TypeName = "double(18,3)")]
       public long? ptrn_sgst_per { get; set; }

       [Column("ptrn_sgst_amt", Order = 52, TypeName = "double(18,3)")]
       public long? ptrn_sgst_amt { get; set; }

       [Column("ptrn_cgst_per", Order = 53, TypeName = "double(18,3)")]
       public long? ptrn_cgst_per { get; set; }

       [Column("ptrn_cgst_amt", Order = 54, TypeName = "double(18,3)")]
       public long? ptrn_cgst_amt { get; set; }

   }
}
