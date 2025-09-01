using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("partytrn")] 
       
   public class Partytrn
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("partytrn_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? partytrn_auto_id { get; set; }

       [Column("party_cd", Order = 3, TypeName = "bigint(10)")]
       public long? party_cd { get; set; }

       [Column("party_name", Order = 4, TypeName = "varchar(50)")]
       public string? party_name { get; set; }

       [Column("bill_date", Order = 5, TypeName = "datetime")]
       public DateTime? bill_date { get; set; }

       [Column("narr", Order = 6, TypeName = "varchar(50)")]
       public string? narr { get; set; }

       [Column("debit", Order = 7, TypeName = "double(18,3)")]
       public long? debit { get; set; }

       [Column("credit", Order = 8, TypeName = "double(18,3)")]
       public long? credit { get; set; }

       [Column("inwoutno", Order = 9, TypeName = "varchar(50)")]
       public string? inwoutno { get; set; }

       [Column("fr_renewal", Order = 10, TypeName = "varchar(50)")]
       public string? fr_renewal { get; set; }

       [Column("short_amt", Order = 11, TypeName = "double(18,3)")]
       public long? short_amt { get; set; }

       [Column("cash_rec_also_amt", Order = 12, TypeName = "double(18,3)")]
       public long? cash_rec_also_amt { get; set; }

       [Column("comm_on_amt", Order = 13, TypeName = "double(18,3)")]
       public long? comm_on_amt { get; set; }

       [Column("gross_amt", Order = 14, TypeName = "double(18,3)")]
       public long? gross_amt { get; set; }

       [Column("tax_type", Order = 15, TypeName = "varchar(50)")]
       public string? tax_type { get; set; }

       [Column("tax_per", Order = 16, TypeName = "double(18,3)")]
       public long? tax_per { get; set; }

       [Column("tax_amt", Order = 17, TypeName = "double(18,3)")]
       public long? tax_amt { get; set; }

       [Column("aganist_narr", Order = 18, TypeName = "varchar(50)")]
       public string? aganist_narr { get; set; }

       [Column("cover_note_no", Order = 19, TypeName = "varchar(50)")]
       public string? cover_note_no { get; set; }

       [Column("cust_name", Order = 20, TypeName = "varchar(50)")]
       public string? cust_name { get; set; }

       [Column("policy_no", Order = 21, TypeName = "varchar(50)")]
       public string? policy_no { get; set; }

       [Column("veh_no", Order = 22, TypeName = "varchar(50)")]
       public string? veh_no { get; set; }

       [Column("veh_no_last_4", Order = 23, TypeName = "bigint(10)")]
       public long? veh_no_last_4 { get; set; }

       [Column("chequeno", Order = 24, TypeName = "varchar(50)")]
       public string? chequeno { get; set; }

       [Column("folio", Order = 25, TypeName = "varchar(50)")]
       public string? folio { get; set; }

       [Column("upd_flag", Order = 26, TypeName = "varchar(50)")]
       public string? upd_flag { get; set; }

       [Column("del_flag", Order = 27, TypeName = "varchar(50)")]
       public string? del_flag { get; set; }

       [Column("tot_qty", Order = 28, TypeName = "double(18,3)")]
       public long? tot_qty { get; set; }

       [Column("rate", Order = 29, TypeName = "double(18,3)")]
       public long? rate { get; set; }

       [Column("spot_ind", Order = 30, TypeName = "bigint(10)")]
       public long? spot_ind { get; set; }

       [Column("value_date", Order = 31, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("group_name", Order = 32, TypeName = "varchar(50)")]
       public string? group_name { get; set; }

       [Column("groupx", Order = 33, TypeName = "varchar(50)")]
       public string? groupx { get; set; }

       [Column("remark1", Order = 34, TypeName = "varchar(50)")]
       public string? remark1 { get; set; }

       [Column("report_no", Order = 35, TypeName = "varchar(50)")]
       public string? report_no { get; set; }

       [Column("mode_type", Order = 36, TypeName = "varchar(50)")]
       public string? mode_type { get; set; }

       [Column("username", Order = 37, TypeName = "varchar(50)")]
       public string? username { get; set; }

       [Column("agent_emp_code", Order = 38, TypeName = "bigint(10)")]
       public long? agent_emp_code { get; set; }

       [Column("agent_emp_name", Order = 39, TypeName = "varchar(50)")]
       public string? agent_emp_name { get; set; }

       [Column("auto_bill_nos", Order = 40, TypeName = "bigint(10)")]
       public long? auto_bill_nos { get; set; }

       [Column("s_no", Order = 41, TypeName = "double(18,3)")]
       public long? s_no { get; set; }

       [Column("ref_no_bill_no", Order = 42, TypeName = "varchar(100)")]
       public string? ref_no_bill_no { get; set; }

       [Column("ptrn_day_name", Order = 43, TypeName = "varchar(20)")]
       public string? ptrn_day_name { get; set; }

       [Column("ptrn_date", Order = 44, TypeName = "varchar(2)")]
       public string? ptrn_date { get; set; }

       [Column("ptrn_month_no", Order = 45, TypeName = "double(18,3)")]
       public long? ptrn_month_no { get; set; }

       [Column("ptrn_month_name", Order = 46, TypeName = "varchar(15)")]
       public string? ptrn_month_name { get; set; }

       [Column("ptrn_year", Order = 47, TypeName = "varchar(15)")]
       public string? ptrn_year { get; set; }

       [Column("ptrn_gst_type", Order = 48, TypeName = "varchar(15)")]
       public string? ptrn_gst_type { get; set; }

       [Column("ptrn_gross_amt", Order = 49, TypeName = "double(18,3)")]
       public long? ptrn_gross_amt { get; set; }

       [Column("ptrn_tot_gst", Order = 50, TypeName = "double(18,3)")]
       public long? ptrn_tot_gst { get; set; }

       [Column("ptrn_vou_amt", Order = 51, TypeName = "double(18,3)")]
       public long? ptrn_vou_amt { get; set; }

       [Column("ptrn_igst_per", Order = 52, TypeName = "double(18,3)")]
       public long? ptrn_igst_per { get; set; }

       [Column("ptrn_igst_amt", Order = 53, TypeName = "double(18,3)")]
       public long? ptrn_igst_amt { get; set; }

       [Column("ptrn_sgst_per", Order = 54, TypeName = "double(18,3)")]
       public long? ptrn_sgst_per { get; set; }

       [Column("ptrn_sgst_amt", Order = 55, TypeName = "double(18,3)")]
       public long? ptrn_sgst_amt { get; set; }

       [Column("ptrn_cgst_per", Order = 56, TypeName = "double(18,3)")]
       public long? ptrn_cgst_per { get; set; }

       [Column("ptrn_cgst_amt", Order = 57, TypeName = "double(18,3)")]
       public long? ptrn_cgst_amt { get; set; }

       [Column("comp_sno", Order = 58, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 59, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 60, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 61, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

   }
}
