using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Dp_Master_Nsdl_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("dp_import_trx_no", Order = 5, TypeName = "double(18,3)")]
       public long? dp_import_trx_no { get; set; }

       [Column("trx_date", Order = 6, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("dp_record_date", Order = 7, TypeName = "datetime")]
       public DateTime? dp_record_date { get; set; }

       [Column("dp_record_date_text", Order = 8, TypeName = "text")]
       public string? dp_record_date_text { get; set; }

       [Column("exchange_name", Order = 9, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("dp_id", Order = 10, TypeName = "varchar(16)")]
       public string? dp_id { get; set; }

       [Column("dp_first_name", Order = 11, TypeName = "text")]
       public string? dp_first_name { get; set; }

       [Column("sebi_registration_date_from", Order = 12, TypeName = "varchar(20)")]
       public string? sebi_registration_date_from { get; set; }

       [Column("sebi_registration_date_to", Order = 13, TypeName = "varchar(20)")]
       public string? sebi_registration_date_to { get; set; }

       [Column("dp_type_role", Order = 14, TypeName = "varchar(10)")]
       public string? dp_type_role { get; set; }

       [Column("dp_type_description", Order = 15, TypeName = "varchar(100)")]
       public string? dp_type_description { get; set; }

       [Column("dp_address_1", Order = 16, TypeName = "text")]
       public string? dp_address_1 { get; set; }

       [Column("dp_address_2", Order = 17, TypeName = "text")]
       public string? dp_address_2 { get; set; }

       [Column("dp_address_3", Order = 18, TypeName = "text")]
       public string? dp_address_3 { get; set; }

       [Column("dp_address_4", Order = 19, TypeName = "text")]
       public string? dp_address_4 { get; set; }

       [Column("dp_city", Order = 20, TypeName = "varchar(100)")]
       public string? dp_city { get; set; }

       [Column("dp_state", Order = 21, TypeName = "varchar(100)")]
       public string? dp_state { get; set; }

       [Column("dp_country", Order = 22, TypeName = "varchar(100)")]
       public string? dp_country { get; set; }

       [Column("dp_zip", Order = 23, TypeName = "varchar(10)")]
       public string? dp_zip { get; set; }

       [Column("dp_phone_1", Order = 24, TypeName = "varchar(30)")]
       public string? dp_phone_1 { get; set; }

       [Column("dp_phone_2", Order = 25, TypeName = "varchar(30)")]
       public string? dp_phone_2 { get; set; }

       [Column("dp_fax", Order = 26, TypeName = "varchar(30)")]
       public string? dp_fax { get; set; }

       [Column("dp_email", Order = 27, TypeName = "text")]
       public string? dp_email { get; set; }

       [Column("associated_cc_id_nsdl", Order = 28, TypeName = "varchar(16)")]
       public string? associated_cc_id_nsdl { get; set; }

       [Column("associated_dp_id_nsdl", Order = 29, TypeName = "varchar(16)")]
       public string? associated_dp_id_nsdl { get; set; }

       [Column("associated_cc_cm_id_nsdl", Order = 30, TypeName = "varchar(16)")]
       public string? associated_cc_cm_id_nsdl { get; set; }

       [Column("bp_category_nsdl", Order = 31, TypeName = "varchar(20)")]
       public string? bp_category_nsdl { get; set; }

       [Column("bp_name_nsdl", Order = 32, TypeName = "text")]
       public string? bp_name_nsdl { get; set; }

       [Column("bp_stat_nsdl", Order = 33, TypeName = "varchar(20)")]
       public string? bp_stat_nsdl { get; set; }

       [Column("dp_status", Order = 34, TypeName = "varchar(10)")]
       public string? dp_status { get; set; }

       [Column("dp_status_description", Order = 35, TypeName = "text")]
       public string? dp_status_description { get; set; }

       [Column("sebi_registration_number", Order = 36, TypeName = "varchar(50)")]
       public string? sebi_registration_number { get; set; }

       [Column("parent_dp_id", Order = 37, TypeName = "varchar(16)")]
       public string? parent_dp_id { get; set; }

       [Column("parent_dp_name", Order = 38, TypeName = "text")]
       public string? parent_dp_name { get; set; }

       [Column("bank_id", Order = 39, TypeName = "varchar(30)")]
       public string? bank_id { get; set; }

       [Column("bank_name", Order = 40, TypeName = "text")]
       public string? bank_name { get; set; }

       [Column("branch_id", Order = 41, TypeName = "varchar(30)")]
       public string? branch_id { get; set; }

       [Column("dp_account", Order = 42, TypeName = "varchar(30)")]
       public string? dp_account { get; set; }

       [Column("dp_account_currency", Order = 43, TypeName = "varchar(20)")]
       public string? dp_account_currency { get; set; }

       [Column("dp_account_currency_description", Order = 44, TypeName = "text")]
       public string? dp_account_currency_description { get; set; }

       [Column("sub_accounting_indicator", Order = 45, TypeName = "varchar(10)")]
       public string? sub_accounting_indicator { get; set; }

       [Column("ch_id", Order = 46, TypeName = "varchar(30)")]
       public string? ch_id { get; set; }

       [Column("ch_guarantee_level", Order = 47, TypeName = "varchar(30)")]
       public string? ch_guarantee_level { get; set; }

       [Column("last_billing_cycle", Order = 48, TypeName = "varchar(100)")]
       public string? last_billing_cycle { get; set; }

       [Column("billing_frequency", Order = 49, TypeName = "varchar(10)")]
       public string? billing_frequency { get; set; }

       [Column("billing_frequency_description", Order = 50, TypeName = "text")]
       public string? billing_frequency_description { get; set; }

       [Column("poa_first_name", Order = 51, TypeName = "text")]
       public string? poa_first_name { get; set; }

       [Column("poa_middle_name", Order = 52, TypeName = "varchar(100)")]
       public string? poa_middle_name { get; set; }

       [Column("poa_last_name", Order = 53, TypeName = "varchar(100)")]
       public string? poa_last_name { get; set; }

       [Column("poa_address_1", Order = 54, TypeName = "text")]
       public string? poa_address_1 { get; set; }

       [Column("poa_address_2", Order = 55, TypeName = "text")]
       public string? poa_address_2 { get; set; }

       [Column("poa_address_3", Order = 56, TypeName = "text")]
       public string? poa_address_3 { get; set; }

       [Column("poa_city", Order = 57, TypeName = "varchar(100)")]
       public string? poa_city { get; set; }

       [Column("poa_state", Order = 58, TypeName = "varchar(100)")]
       public string? poa_state { get; set; }

       [Column("poa_country", Order = 59, TypeName = "varchar(100)")]
       public string? poa_country { get; set; }

       [Column("poa_zip", Order = 60, TypeName = "varchar(20)")]
       public string? poa_zip { get; set; }

       [Column("poa_phone_1", Order = 61, TypeName = "varchar(30)")]
       public string? poa_phone_1 { get; set; }

       [Column("poa_phone_2", Order = 62, TypeName = "varchar(30)")]
       public string? poa_phone_2 { get; set; }

       [Column("poa_fax", Order = 63, TypeName = "varchar(30)")]
       public string? poa_fax { get; set; }

       [Column("poa_email", Order = 64, TypeName = "text")]
       public string? poa_email { get; set; }

       [Column("title_cdsl", Order = 65, TypeName = "varchar(100)")]
       public string? title_cdsl { get; set; }

       [Column("registered_contact_name", Order = 66, TypeName = "text")]
       public string? registered_contact_name { get; set; }

       [Column("suffix_cdsl", Order = 67, TypeName = "varchar(50)")]
       public string? suffix_cdsl { get; set; }

       [Column("operational_contact_name", Order = 68, TypeName = "text")]
       public string? operational_contact_name { get; set; }

       [Column("operational_contact_address_1", Order = 69, TypeName = "text")]
       public string? operational_contact_address_1 { get; set; }

       [Column("operational_contact_address_2", Order = 70, TypeName = "text")]
       public string? operational_contact_address_2 { get; set; }

       [Column("operational_contact_address_3", Order = 71, TypeName = "text")]
       public string? operational_contact_address_3 { get; set; }

       [Column("operational_contact_city", Order = 72, TypeName = "varchar(100)")]
       public string? operational_contact_city { get; set; }

       [Column("operational_contact_state", Order = 73, TypeName = "varchar(100)")]
       public string? operational_contact_state { get; set; }

       [Column("operational_contact_country", Order = 74, TypeName = "varchar(100)")]
       public string? operational_contact_country { get; set; }

       [Column("operational_contact_zip", Order = 75, TypeName = "varchar(20)")]
       public string? operational_contact_zip { get; set; }

       [Column("operational_contact_phone_1", Order = 76, TypeName = "varchar(30)")]
       public string? operational_contact_phone_1 { get; set; }

       [Column("operational_contact_phone_2", Order = 77, TypeName = "varchar(30)")]
       public string? operational_contact_phone_2 { get; set; }

       [Column("operational_contact_fax", Order = 78, TypeName = "varchar(30)")]
       public string? operational_contact_fax { get; set; }

       [Column("operational_contact_email", Order = 79, TypeName = "text")]
       public string? operational_contact_email { get; set; }

       [Column("dp_accounting_type", Order = 80, TypeName = "varchar(20)")]
       public string? dp_accounting_type { get; set; }

       [Column("dp_accounting_type_description", Order = 81, TypeName = "text")]
       public string? dp_accounting_type_description { get; set; }

       [Column("maximum_users", Order = 82, TypeName = "varchar(30)")]
       public string? maximum_users { get; set; }

       [Column("cds_no_of_shares", Order = 83, TypeName = "varchar(30)")]
       public string? cds_no_of_shares { get; set; }

       [Column("electronic_confirmation", Order = 84, TypeName = "varchar(10)")]
       public string? electronic_confirmation { get; set; }

       [Column("dp_net_worth", Order = 85, TypeName = "varchar(30)")]
       public string? dp_net_worth { get; set; }

       [Column("dp_net_worth_date", Order = 86, TypeName = "varchar(20)")]
       public string? dp_net_worth_date { get; set; }

       [Column("suspended_date", Order = 87, TypeName = "varchar(20)")]
       public string? suspended_date { get; set; }

       [Column("sebi_registration_number_count", Order = 88, TypeName = "varchar(30)")]
       public string? sebi_registration_number_count { get; set; }

       [Column("exchange_id", Order = 89, TypeName = "varchar(16)")]
       public string? exchange_id { get; set; }

       [Column("sebi_registration_number_2", Order = 90, TypeName = "varchar(32)")]
       public string? sebi_registration_number_2 { get; set; }

       [Column("record_status", Order = 91, TypeName = "varchar(20)")]
       public string? record_status { get; set; }

   }
}
