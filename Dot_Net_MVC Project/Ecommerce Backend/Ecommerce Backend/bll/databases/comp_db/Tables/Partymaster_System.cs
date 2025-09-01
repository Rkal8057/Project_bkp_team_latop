using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("partymaster_system")] 
       
   public class Partymaster_System
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("pty_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? pty_auto_id { get; set; }

       [Column("pcode", Order = 3, TypeName = "float")]
       public long? pcode { get; set; }

       [Column("pname", Order = 4, TypeName = "varchar(50)")]
       public string? pname { get; set; }

       [Column("delete_option", Order = 5, TypeName = "varchar(50)")]
       public string? delete_option { get; set; }

       [Column("group_code", Order = 6, TypeName = "float")]
       public long? group_code { get; set; }

       [Column("group_name", Order = 7, TypeName = "varchar(50)")]
       public string? group_name { get; set; }

       [Column("gmain_code", Order = 8, TypeName = "float")]
       public long? gmain_code { get; set; }

       [Column("gmain_g_name", Order = 9, TypeName = "varchar(50)")]
       public string? gmain_g_name { get; set; }

       [Column("company_name", Order = 10, TypeName = "varchar(50)")]
       public string? company_name { get; set; }

       [Column("mr_mrs_ms", Order = 11, TypeName = "varchar(50)")]
       public string? mr_mrs_ms { get; set; }

       [Column("marital_status", Order = 12, TypeName = "varchar(50)")]
       public string? marital_status { get; set; }

       [Column("gender", Order = 13, TypeName = "varchar(50)")]
       public string? gender { get; set; }

       [Column("d_o_birth", Order = 14, TypeName = "varchar(50)")]
       public string? d_o_birth { get; set; }

       [Column("anni_date", Order = 15, TypeName = "varchar(50)")]
       public string? anni_date { get; set; }

       [Column("lovelty", Order = 16, TypeName = "varchar(50)")]
       public string? lovelty { get; set; }

       [Column("remarks", Order = 17, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("landline_phno", Order = 18, TypeName = "varchar(50)")]
       public string? landline_phno { get; set; }

       [Column("mobile_phno", Order = 19, TypeName = "varchar(50)")]
       public string? mobile_phno { get; set; }

       [Column("email_address", Order = 20, TypeName = "varchar(50)")]
       public string? email_address { get; set; }

       [Column("website_address", Order = 21, TypeName = "varchar(50)")]
       public string? website_address { get; set; }

       [Column("ref_by", Order = 22, TypeName = "varchar(50)")]
       public string? ref_by { get; set; }

       [Column("add1", Order = 23, TypeName = "varchar(50)")]
       public string? add1 { get; set; }

       [Column("add2", Order = 24, TypeName = "varchar(50)")]
       public string? add2 { get; set; }

       [Column("add3", Order = 25, TypeName = "varchar(50)")]
       public string? add3 { get; set; }

       [Column("add4", Order = 26, TypeName = "varchar(50)")]
       public string? add4 { get; set; }

       [Column("add5", Order = 27, TypeName = "varchar(50)")]
       public string? add5 { get; set; }

       [Column("add6", Order = 28, TypeName = "varchar(50)")]
       public string? add6 { get; set; }

       [Column("add7", Order = 29, TypeName = "varchar(50)")]
       public string? add7 { get; set; }

       [Column("add8", Order = 30, TypeName = "varchar(50)")]
       public string? add8 { get; set; }

       [Column("add9", Order = 31, TypeName = "varchar(50)")]
       public string? add9 { get; set; }

       [Column("op_bal", Order = 32, TypeName = "float")]
       public long? op_bal { get; set; }

       [Column("dr_cr", Order = 33, TypeName = "varchar(50)")]
       public string? dr_cr { get; set; }

       [Column("gstin_no", Order = 34, TypeName = "varchar(50)")]
       public string? gstin_no { get; set; }

       [Column("cst_no", Order = 35, TypeName = "varchar(50)")]
       public string? cst_no { get; set; }

       [Column("tin_no", Order = 36, TypeName = "varchar(50)")]
       public string? tin_no { get; set; }

       [Column("pan_no", Order = 37, TypeName = "varchar(50)")]
       public string? pan_no { get; set; }

       [Column("ac_opening_date", Order = 38, TypeName = "varchar(50)")]
       public string? ac_opening_date { get; set; }

       [Column("depart_name", Order = 39, TypeName = "varchar(50)")]
       public string? depart_name { get; set; }

       [Column("designation", Order = 40, TypeName = "varchar(50)")]
       public string? designation { get; set; }

       [Column("entry_date_time", Order = 41, TypeName = "datetime")]
       public DateTime? entry_date_time { get; set; }

       [Column("transport_detail", Order = 42, TypeName = "varchar(50)")]
       public string? transport_detail { get; set; }

       [Column("other1", Order = 43, TypeName = "varchar(50)")]
       public string? other1 { get; set; }

       [Column("other3", Order = 44, TypeName = "varchar(50)")]
       public string? other3 { get; set; }

       [Column("other4", Order = 45, TypeName = "varchar(50)")]
       public string? other4 { get; set; }

       [Column("other5", Order = 46, TypeName = "varchar(50)")]
       public string? other5 { get; set; }

       [Column("other6", Order = 47, TypeName = "varchar(50)")]
       public string? other6 { get; set; }

       [Column("other7", Order = 48, TypeName = "varchar(50)")]
       public string? other7 { get; set; }

       [Column("other8", Order = 49, TypeName = "varchar(50)")]
       public string? other8 { get; set; }

       [Column("other9", Order = 50, TypeName = "varchar(50)")]
       public string? other9 { get; set; }

       [Column("other10", Order = 51, TypeName = "varchar(50)")]
       public string? other10 { get; set; }

       [Column("bill_dis_per", Order = 52, TypeName = "float")]
       public long? bill_dis_per { get; set; }

       [Column("gst_tax_rate", Order = 53, TypeName = "float")]
       public long? gst_tax_rate { get; set; }

       [Column("other13", Order = 54, TypeName = "varchar(50)")]
       public string? other13 { get; set; }

       [Column("other14", Order = 55, TypeName = "varchar(50)")]
       public string? other14 { get; set; }

       [Column("other15", Order = 56, TypeName = "varchar(50)")]
       public string? other15 { get; set; }

       [Column("pay_term_days", Order = 57, TypeName = "varchar(50)")]
       public string? pay_term_days { get; set; }

       [Column("bill_dis_per_2", Order = 58, TypeName = "float")]
       public long? bill_dis_per_2 { get; set; }

       [Column("addhar_no", Order = 59, TypeName = "varchar(50)")]
       public string? addhar_no { get; set; }

       [Column("comp_sno", Order = 60, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 61, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 62, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 63, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

   }
}
