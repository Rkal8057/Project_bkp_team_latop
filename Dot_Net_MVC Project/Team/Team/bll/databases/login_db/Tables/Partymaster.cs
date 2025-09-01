using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Partymaster
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("pcode", Order = 2, TypeName = "bigint(10)")]
       public long? pcode { get; set; }

       [Column("pname", Order = 3, TypeName = "text")]
       public string? pname { get; set; }

       [Column("delete_option", Order = 4, TypeName = "text")]
       public string? delete_option { get; set; }

       [Column("group_code", Order = 5, TypeName = "bigint(10)")]
       public long? group_code { get; set; }

       [Column("group_name", Order = 6, TypeName = "text")]
       public string? group_name { get; set; }

       [Column("gmain_code", Order = 7, TypeName = "bigint(10)")]
       public long? gmain_code { get; set; }

       [Column("gmain_g_name", Order = 8, TypeName = "text")]
       public string? gmain_g_name { get; set; }

       [Column("company_name", Order = 9, TypeName = "text")]
       public string? company_name { get; set; }

       [Column("mr_mrs_ms", Order = 10, TypeName = "text")]
       public string? mr_mrs_ms { get; set; }

       [Column("marital_status", Order = 11, TypeName = "text")]
       public string? marital_status { get; set; }

       [Column("gender", Order = 12, TypeName = "text")]
       public string? gender { get; set; }

       [Column("d_o_birth", Order = 13, TypeName = "text")]
       public string? d_o_birth { get; set; }

       [Column("anni_date", Order = 14, TypeName = "text")]
       public string? anni_date { get; set; }

       [Column("lovelty", Order = 15, TypeName = "text")]
       public string? lovelty { get; set; }

       [Column("remarks", Order = 16, TypeName = "text")]
       public string? remarks { get; set; }

       [Column("landline_phno", Order = 17, TypeName = "text")]
       public string? landline_phno { get; set; }

       [Column("mobile_phno", Order = 18, TypeName = "text")]
       public string? mobile_phno { get; set; }

       [Column("email_address", Order = 19, TypeName = "text")]
       public string? email_address { get; set; }

       [Column("website_address", Order = 20, TypeName = "text")]
       public string? website_address { get; set; }

       [Column("ref_by", Order = 21, TypeName = "text")]
       public string? ref_by { get; set; }

       [Column("add1", Order = 22, TypeName = "text")]
       public string? add1 { get; set; }

       [Column("add2", Order = 23, TypeName = "text")]
       public string? add2 { get; set; }

       [Column("add3", Order = 24, TypeName = "text")]
       public string? add3 { get; set; }

       [Column("add4", Order = 25, TypeName = "text")]
       public string? add4 { get; set; }

       [Column("add5", Order = 26, TypeName = "text")]
       public string? add5 { get; set; }

       [Column("add6", Order = 27, TypeName = "text")]
       public string? add6 { get; set; }

       [Column("add7", Order = 28, TypeName = "text")]
       public string? add7 { get; set; }

       [Column("add8", Order = 29, TypeName = "text")]
       public string? add8 { get; set; }

       [Column("add9", Order = 30, TypeName = "text")]
       public string? add9 { get; set; }

       [Column("op_bal", Order = 31, TypeName = "float")]
       public long? op_bal { get; set; }

       [Column("dr_cr", Order = 32, TypeName = "text")]
       public string? dr_cr { get; set; }

       [Column("gstin_no", Order = 33, TypeName = "text")]
       public string? gstin_no { get; set; }

       [Column("cst_no", Order = 34, TypeName = "text")]
       public string? cst_no { get; set; }

       [Column("tin_no", Order = 35, TypeName = "text")]
       public string? tin_no { get; set; }

       [Column("pan_no", Order = 36, TypeName = "text")]
       public string? pan_no { get; set; }

       [Column("ac_opening_date", Order = 37, TypeName = "text")]
       public string? ac_opening_date { get; set; }

       [Column("depart_name", Order = 38, TypeName = "text")]
       public string? depart_name { get; set; }

       [Column("designation", Order = 39, TypeName = "text")]
       public string? designation { get; set; }

       [Column("entry_date_time", Order = 40, TypeName = "datetime")]
       public DateTime? entry_date_time { get; set; }

       [Column("transport_detail", Order = 41, TypeName = "text")]
       public string? transport_detail { get; set; }

       [Column("other1", Order = 42, TypeName = "text")]
       public string? other1 { get; set; }

       [Column("isin_no", Order = 43, TypeName = "text")]
       public string? isin_no { get; set; }

       [Column("other4", Order = 44, TypeName = "text")]
       public string? other4 { get; set; }

       [Column("other5", Order = 45, TypeName = "text")]
       public string? other5 { get; set; }

       [Column("other6", Order = 46, TypeName = "text")]
       public string? other6 { get; set; }

       [Column("other7", Order = 47, TypeName = "text")]
       public string? other7 { get; set; }

       [Column("other8", Order = 48, TypeName = "text")]
       public string? other8 { get; set; }

       [Column("other9", Order = 49, TypeName = "varchar(50)")]
       public string? other9 { get; set; }

       [Column("other10", Order = 50, TypeName = "text")]
       public string? other10 { get; set; }

       [Column("bill_dis_per", Order = 51, TypeName = "bigint(10)")]
       public long? bill_dis_per { get; set; }

       [Column("gst_tax_rate", Order = 52, TypeName = "bigint(10)")]
       public long? gst_tax_rate { get; set; }

       [Column("other13", Order = 53, TypeName = "bigint(10)")]
       public long? other13 { get; set; }

       [Column("other14", Order = 54, TypeName = "bigint(10)")]
       public long? other14 { get; set; }

       [Column("other15", Order = 55, TypeName = "bigint(10)")]
       public long? other15 { get; set; }

       [Column("pay_term_days", Order = 56, TypeName = "bigint(10)")]
       public long? pay_term_days { get; set; }

       [Column("bill_dis_per_2", Order = 57, TypeName = "double(18,3)")]
       public long? bill_dis_per_2 { get; set; }

       [Column("addhar_no", Order = 58, TypeName = "varchar(100)")]
       public string? addhar_no { get; set; }

       [Column("pcode_id", Order = 59, TypeName = "bigint(10)")]
       public long? pcode_id { get; set; }

       [Column("comp_id", Order = 60, TypeName = "bigint(10)")]
       public long? comp_id { get; set; }

   }
}
