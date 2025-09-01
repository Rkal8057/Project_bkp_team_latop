using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class System_Records
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("home_state_code", Order = 2, TypeName = "varchar(50)")]
       public string? home_state_code { get; set; }

       [Column("default_tax_name", Order = 3, TypeName = "varchar(50)")]
       public string? default_tax_name { get; set; }

       [Column("default_tax_per", Order = 4, TypeName = "text")]
       public string? default_tax_per { get; set; }

       [Column("default_unit", Order = 5, TypeName = "varchar(50)")]
       public string? default_unit { get; set; }

       [Column("default_hsn_code", Order = 6, TypeName = "text")]
       public string? default_hsn_code { get; set; }

       [Column("default_company_no", Order = 7, TypeName = "varchar(50)")]
       public string? default_company_no { get; set; }

       [Column("company_name", Order = 8, TypeName = "varchar(50)")]
       public string? company_name { get; set; }

       [Column("company_address", Order = 9, TypeName = "varchar(50)")]
       public string? company_address { get; set; }

       [Column("company_address_1", Order = 10, TypeName = "varchar(50)")]
       public string? company_address_1 { get; set; }

       [Column("company_phone", Order = 11, TypeName = "varchar(50)")]
       public string? company_phone { get; set; }

       [Column("sale_retrun_code", Order = 12, TypeName = "bigint(10)")]
       public long? sale_retrun_code { get; set; }

       [Column("sale_return_name_default", Order = 13, TypeName = "varchar(50)")]
       public string? sale_return_name_default { get; set; }

       [Column("sale_code", Order = 14, TypeName = "bigint(10)")]
       public long? sale_code { get; set; }

       [Column("sale_name_default", Order = 15, TypeName = "varchar(50)")]
       public string? sale_name_default { get; set; }

       [Column("bank_code", Order = 16, TypeName = "bigint(10)")]
       public long? bank_code { get; set; }

       [Column("bank_name_default", Order = 17, TypeName = "varchar(50)")]
       public string? bank_name_default { get; set; }

       [Column("cash_name_default", Order = 18, TypeName = "varchar(50)")]
       public string? cash_name_default { get; set; }

       [Column("cash_code", Order = 19, TypeName = "bigint(10)")]
       public long? cash_code { get; set; }

       [Column("year_from", Order = 20, TypeName = "datetime")]
       public DateTime? year_from { get; set; }

       [Column("year_to", Order = 21, TypeName = "datetime")]
       public DateTime? year_to { get; set; }

       [Column("display_height", Order = 22, TypeName = "varchar(50)")]
       public string? display_height { get; set; }

       [Column("saledatabaselock", Order = 23, TypeName = "varchar(50)")]
       public string? saledatabaselock { get; set; }

       [Column("database_1_path", Order = 24, TypeName = "varchar(50)")]
       public string? database_1_path { get; set; }

       [Column("database_2_path", Order = 25, TypeName = "varchar(50)")]
       public string? database_2_path { get; set; }

       [Column("auto_raw_yes_no", Order = 26, TypeName = "varchar(50)")]
       public string? auto_raw_yes_no { get; set; }

       [Column("weekly_off_day", Order = 27, TypeName = "varchar(50)")]
       public string? weekly_off_day { get; set; }

       [Column("other2", Order = 28, TypeName = "varchar(50)")]
       public string? other2 { get; set; }

       [Column("other3", Order = 29, TypeName = "varchar(50)")]
       public string? other3 { get; set; }

       [Column("other4", Order = 30, TypeName = "varchar(50)")]
       public string? other4 { get; set; }

       [Column("other5", Order = 31, TypeName = "varchar(50)")]
       public string? other5 { get; set; }

       [Column("other6", Order = 32, TypeName = "varchar(50)")]
       public string? other6 { get; set; }

       [Column("other7", Order = 33, TypeName = "varchar(50)")]
       public string? other7 { get; set; }

       [Column("other8", Order = 34, TypeName = "varchar(50)")]
       public string? other8 { get; set; }

       [Column("other9", Order = 35, TypeName = "varchar(50)")]
       public string? other9 { get; set; }

       [Column("other10", Order = 36, TypeName = "varchar(50)")]
       public string? other10 { get; set; }

       [Column("other11", Order = 37, TypeName = "varchar(50)")]
       public string? other11 { get; set; }

       [Column("other12", Order = 38, TypeName = "varchar(50)")]
       public string? other12 { get; set; }

       [Column("other13", Order = 39, TypeName = "varchar(50)")]
       public string? other13 { get; set; }

       [Column("other14", Order = 40, TypeName = "varchar(50)")]
       public string? other14 { get; set; }

       [Column("other15", Order = 41, TypeName = "varchar(50)")]
       public string? other15 { get; set; }

       [Column("other16", Order = 42, TypeName = "varchar(50)")]
       public string? other16 { get; set; }

       [Column("other17", Order = 43, TypeName = "varchar(50)")]
       public string? other17 { get; set; }

       [Column("other18", Order = 44, TypeName = "varchar(50)")]
       public string? other18 { get; set; }

       [Column("other19", Order = 45, TypeName = "varchar(50)")]
       public string? other19 { get; set; }

       [Column("other20", Order = 46, TypeName = "datetime")]
       public DateTime? other20 { get; set; }

       [Column("sale_format", Order = 47, TypeName = "varchar(250)")]
       public string? sale_format { get; set; }

       [Column("home_state", Order = 48, TypeName = "varchar(250)")]
       public string? home_state { get; set; }

       [Column("email_sender", Order = 49, TypeName = "varchar(250)")]
       public string? email_sender { get; set; }

       [Column("email_receiver", Order = 50, TypeName = "varchar(250)")]
       public string? email_receiver { get; set; }

       [Column("ch_bill_header_name", Order = 51, TypeName = "varchar(100)")]
       public string? ch_bill_header_name { get; set; }

       [Column("ss_bill_header_name", Order = 52, TypeName = "varchar(100)")]
       public string? ss_bill_header_name { get; set; }

       [Column("sr_bill_header_name", Order = 53, TypeName = "varchar(100)")]
       public string? sr_bill_header_name { get; set; }

       [Column("pp_bill_header_name", Order = 54, TypeName = "varchar(100)")]
       public string? pp_bill_header_name { get; set; }

       [Column("pr_bill_header_name", Order = 55, TypeName = "varchar(100)")]
       public string? pr_bill_header_name { get; set; }

       [Column("po_bill_header_name", Order = 56, TypeName = "varchar(100)")]
       public string? po_bill_header_name { get; set; }

       [Column("so_bill_header_name", Order = 57, TypeName = "varchar(100)")]
       public string? so_bill_header_name { get; set; }

       [Column("rc_bill_header_name", Order = 58, TypeName = "text")]
       public string? rc_bill_header_name { get; set; }

       [Column("qu_bill_header_name", Order = 59, TypeName = "varchar(100)")]
       public string? qu_bill_header_name { get; set; }

       [Column("rounded_off", Order = 60, TypeName = "varchar(15)")]
       public string? rounded_off { get; set; }

       [Column("c_rta_id", Order = 61, TypeName = "varchar(100)")]
       public string? c_rta_id { get; set; }

       [Column("c_operator_id", Order = 62, TypeName = "varchar(100)")]
       public string? c_operator_id { get; set; }

       [Column("p_register_comp_add", Order = 63, TypeName = "text")]
       public string? p_register_comp_add { get; set; }

       [Column("data_validation_check_yn", Order = 64, TypeName = "varchar(3)")]
       public string? data_validation_check_yn { get; set; }

   }
}
