using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Isin_Status_Master_Nsdl_Cdsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("table_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? table_auto_id { get; set; }

       [Column("trx_no", Order = 3, TypeName = "float")]
       public long? trx_no { get; set; }

       [Column("trx_no_text", Order = 4, TypeName = "text")]
       public string? trx_no_text { get; set; }

       [Column("isin_status_import_trx_no", Order = 5, TypeName = "double(18,3)")]
       public long? isin_status_import_trx_no { get; set; }

       [Column("trx_date", Order = 6, TypeName = "datetime")]
       public DateTime? trx_date { get; set; }

       [Column("isin_status_record_date", Order = 7, TypeName = "datetime")]
       public DateTime? isin_status_record_date { get; set; }

       [Column("isin_status_record_date_text", Order = 8, TypeName = "text")]
       public string? isin_status_record_date_text { get; set; }

       [Column("exchange_name", Order = 9, TypeName = "text")]
       public string? exchange_name { get; set; }

       [Column("national_security_code_nsdl", Order = 10, TypeName = "varchar(20)")]
       public string? national_security_code_nsdl { get; set; }

       [Column("booking_basis_nsdl", Order = 11, TypeName = "varchar(20)")]
       public string? booking_basis_nsdl { get; set; }

       [Column("company_code_nsdl", Order = 12, TypeName = "varchar(20)")]
       public string? company_code_nsdl { get; set; }

       [Column("company_name_nsdl", Order = 13, TypeName = "text")]
       public string? company_name_nsdl { get; set; }

       [Column("found_on_company_master_nsdl", Order = 14, TypeName = "varchar(1)")]
       public string? found_on_company_master_nsdl { get; set; }

       [Column("found_on_company_master_cdsl", Order = 15, TypeName = "varchar(1)")]
       public string? found_on_company_master_cdsl { get; set; }

       [Column("isin_numeric_code_1", Order = 16, TypeName = "varchar(25)")]
       public string? isin_numeric_code_1 { get; set; }

       [Column("isin_alpha_code_2", Order = 17, TypeName = "varchar(12)")]
       public string? isin_alpha_code_2 { get; set; }

       [Column("isin_short_name_3", Order = 18, TypeName = "text")]
       public string? isin_short_name_3 { get; set; }

       [Column("isin_description_4", Order = 19, TypeName = "text")]
       public string? isin_description_4 { get; set; }

       [Column("issuer_id_5", Order = 20, TypeName = "varchar(25)")]
       public string? issuer_id_5 { get; set; }

       [Column("issuer_name_6", Order = 21, TypeName = "varchar(100)")]
       public string? issuer_name_6 { get; set; }

       [Column("issuer_address_1_7", Order = 22, TypeName = "varchar(130)")]
       public string? issuer_address_1_7 { get; set; }

       [Column("issuer_address_2_8", Order = 23, TypeName = "varchar(130)")]
       public string? issuer_address_2_8 { get; set; }

       [Column("issuer_address_3_9", Order = 24, TypeName = "varchar(130)")]
       public string? issuer_address_3_9 { get; set; }

       [Column("issuer_city_10", Order = 25, TypeName = "varchar(25)")]
       public string? issuer_city_10 { get; set; }

       [Column("issuer_state_11", Order = 26, TypeName = "varchar(25)")]
       public string? issuer_state_11 { get; set; }

       [Column("issuer_country_12", Order = 27, TypeName = "varchar(25)")]
       public string? issuer_country_12 { get; set; }

       [Column("issuer_zip_code_13", Order = 28, TypeName = "varchar(10)")]
       public string? issuer_zip_code_13 { get; set; }

       [Column("issuer_phone_1_14", Order = 29, TypeName = "varchar(30)")]
       public string? issuer_phone_1_14 { get; set; }

       [Column("issuer_phone_2_15", Order = 30, TypeName = "varchar(30)")]
       public string? issuer_phone_2_15 { get; set; }

       [Column("issuer_fax_16", Order = 31, TypeName = "varchar(30)")]
       public string? issuer_fax_16 { get; set; }

       [Column("issuer_email_17", Order = 32, TypeName = "varchar(180)")]
       public string? issuer_email_17 { get; set; }

       [Column("issuer_contact_person_name_18", Order = 33, TypeName = "varchar(100)")]
       public string? issuer_contact_person_name_18 { get; set; }

       [Column("contact_person_designation_19", Order = 34, TypeName = "varchar(40)")]
       public string? contact_person_designation_19 { get; set; }

       [Column("contact_person_address_1_20", Order = 35, TypeName = "varchar(130)")]
       public string? contact_person_address_1_20 { get; set; }

       [Column("contact_person_address_2_21", Order = 36, TypeName = "varchar(130)")]
       public string? contact_person_address_2_21 { get; set; }

       [Column("contact_person_address_3_22", Order = 37, TypeName = "varchar(130)")]
       public string? contact_person_address_3_22 { get; set; }

       [Column("contact_person_city_23", Order = 38, TypeName = "varchar(25)")]
       public string? contact_person_city_23 { get; set; }

       [Column("contact_person_state_24", Order = 39, TypeName = "varchar(25)")]
       public string? contact_person_state_24 { get; set; }

       [Column("contact_person_country_25", Order = 40, TypeName = "varchar(25)")]
       public string? contact_person_country_25 { get; set; }

       [Column("contact_person_zip_code_26", Order = 41, TypeName = "varchar(10)")]
       public string? contact_person_zip_code_26 { get; set; }

       [Column("contact_person_phone_1_27", Order = 42, TypeName = "varchar(30)")]
       public string? contact_person_phone_1_27 { get; set; }

       [Column("contact_person_phone_2_28", Order = 43, TypeName = "varchar(30)")]
       public string? contact_person_phone_2_28 { get; set; }

       [Column("contact_person_fax_29", Order = 44, TypeName = "varchar(30)")]
       public string? contact_person_fax_29 { get; set; }

       [Column("contact_person_email_30", Order = 45, TypeName = "varchar(180)")]
       public string? contact_person_email_30 { get; set; }

       [Column("rta_id_31_nsdl", Order = 46, TypeName = "varchar(20)")]
       public string? rta_id_31_nsdl { get; set; }

       [Column("rta_name_32_nsdl", Order = 47, TypeName = "varchar(100)")]
       public string? rta_name_32_nsdl { get; set; }

       [Column("sebi_registration_date_from_33_nsdl", Order = 48, TypeName = "varchar(20)")]
       public string? sebi_registration_date_from_33_nsdl { get; set; }

       [Column("sebi_registration_date_to_34_nsdl", Order = 49, TypeName = "varchar(20)")]
       public string? sebi_registration_date_to_34_nsdl { get; set; }

       [Column("rta_address_1_35", Order = 50, TypeName = "varchar(130)")]
       public string? rta_address_1_35 { get; set; }

       [Column("rta_address_2_36", Order = 51, TypeName = "varchar(130)")]
       public string? rta_address_2_36 { get; set; }

       [Column("rta_address_3_37", Order = 52, TypeName = "varchar(130)")]
       public string? rta_address_3_37 { get; set; }

       [Column("rta_city_38", Order = 53, TypeName = "varchar(25)")]
       public string? rta_city_38 { get; set; }

       [Column("rta_state_39", Order = 54, TypeName = "varchar(25)")]
       public string? rta_state_39 { get; set; }

       [Column("rta_country_40", Order = 55, TypeName = "varchar(25)")]
       public string? rta_country_40 { get; set; }

       [Column("rta_zip_code_41", Order = 56, TypeName = "varchar(10)")]
       public string? rta_zip_code_41 { get; set; }

       [Column("rta_phone_1_42", Order = 57, TypeName = "varchar(30)")]
       public string? rta_phone_1_42 { get; set; }

       [Column("rta_phone_2_43", Order = 58, TypeName = "varchar(30)")]
       public string? rta_phone_2_43 { get; set; }

       [Column("rta_fax_44", Order = 59, TypeName = "varchar(30)")]
       public string? rta_fax_44 { get; set; }

       [Column("rta_email_45", Order = 60, TypeName = "varchar(180)")]
       public string? rta_email_45 { get; set; }

       [Column("isin_share_name_46", Order = 61, TypeName = "varchar(100)")]
       public string? isin_share_name_46 { get; set; }

       [Column("isin_second_name_47", Order = 62, TypeName = "varchar(20)")]
       public string? isin_second_name_47 { get; set; }

       [Column("isin_last_name_48", Order = 63, TypeName = "varchar(120)")]
       public string? isin_last_name_48 { get; set; }

       [Column("isin_address_1_49", Order = 64, TypeName = "varchar(130)")]
       public string? isin_address_1_49 { get; set; }

       [Column("isin_address_2_50", Order = 65, TypeName = "varchar(130)")]
       public string? isin_address_2_50 { get; set; }

       [Column("isin_address_3_51", Order = 66, TypeName = "varchar(130)")]
       public string? isin_address_3_51 { get; set; }

       [Column("isin_city_52", Order = 67, TypeName = "varchar(25)")]
       public string? isin_city_52 { get; set; }

       [Column("isin_state_53", Order = 68, TypeName = "varchar(25)")]
       public string? isin_state_53 { get; set; }

       [Column("isin_country_54", Order = 69, TypeName = "varchar(25)")]
       public string? isin_country_54 { get; set; }

       [Column("isin_zip_code_55", Order = 70, TypeName = "varchar(10)")]
       public string? isin_zip_code_55 { get; set; }

       [Column("isin_phone_1_56", Order = 71, TypeName = "varchar(30)")]
       public string? isin_phone_1_56 { get; set; }

       [Column("isin_phone_2_57", Order = 72, TypeName = "varchar(30)")]
       public string? isin_phone_2_57 { get; set; }

       [Column("isin_fax_58", Order = 73, TypeName = "varchar(30)")]
       public string? isin_fax_58 { get; set; }

       [Column("isin_email_59", Order = 74, TypeName = "varchar(180)")]
       public string? isin_email_59 { get; set; }

       [Column("security_type_60", Order = 75, TypeName = "varchar(25)")]
       public string? security_type_60 { get; set; }

       [Column("security_type_description_61", Order = 76, TypeName = "varchar(100)")]
       public string? security_type_description_61 { get; set; }

       [Column("market_type_62", Order = 77, TypeName = "varchar(25)")]
       public string? market_type_62 { get; set; }

       [Column("market_type_description_63", Order = 78, TypeName = "varchar(100)")]
       public string? market_type_description_63 { get; set; }

       [Column("isin_status_64_nsdl", Order = 79, TypeName = "varchar(10)")]
       public string? isin_status_64_nsdl { get; set; }

       [Column("isin_status_description_65_nsdl", Order = 80, TypeName = "text")]
       public string? isin_status_description_65_nsdl { get; set; }

       [Column("hold_demat_flag_66", Order = 81, TypeName = "varchar(1)")]
       public string? hold_demat_flag_66 { get; set; }

       [Column("hold_remat_flag_67", Order = 82, TypeName = "varchar(1)")]
       public string? hold_remat_flag_67 { get; set; }

       [Column("expiry_date_68_nsdl", Order = 83, TypeName = "varchar(20)")]
       public string? expiry_date_68_nsdl { get; set; }

       [Column("market_lot_69", Order = 84, TypeName = "float")]
       public long? market_lot_69 { get; set; }

       [Column("cfi_code_70", Order = 85, TypeName = "varchar(25)")]
       public string? cfi_code_70 { get; set; }

       [Column("par_value_71_nsdl", Order = 86, TypeName = "float")]
       public long? par_value_71_nsdl { get; set; }

       [Column("paidup_value_72_nsdl", Order = 87, TypeName = "float")]
       public long? paidup_value_72_nsdl { get; set; }

       [Column("redemption_price_73", Order = 88, TypeName = "float")]
       public long? redemption_price_73 { get; set; }

       [Column("redemption_date_74", Order = 89, TypeName = "varchar(20)")]
       public string? redemption_date_74 { get; set; }

       [Column("close_price_75", Order = 90, TypeName = "float")]
       public long? close_price_75 { get; set; }

       [Column("close_date_76", Order = 91, TypeName = "varchar(20)")]
       public string? close_date_76 { get; set; }

       [Column("issue_date_77_nsdl", Order = 92, TypeName = "varchar(20)")]
       public string? issue_date_77_nsdl { get; set; }

       [Column("on_going_conversion_78", Order = 93, TypeName = "varchar(10)")]
       public string? on_going_conversion_78 { get; set; }

       [Column("conversion_date_79_nsdl", Order = 94, TypeName = "varchar(20)")]
       public string? conversion_date_79_nsdl { get; set; }

       [Column("distinct_range_exists_80", Order = 95, TypeName = "varchar(1)")]
       public string? distinct_range_exists_80 { get; set; }

       [Column("isin_decimal_code_81_nsdl", Order = 96, TypeName = "varchar(25)")]
       public string? isin_decimal_code_81_nsdl { get; set; }

       [Column("isin_decimal_code_description_82", Order = 97, TypeName = "varchar(100)")]
       public string? isin_decimal_code_description_82 { get; set; }

       [Column("isin_suspended_83", Order = 98, TypeName = "varchar(25)")]
       public string? isin_suspended_83 { get; set; }

       [Column("isin_suspended_description_84", Order = 99, TypeName = "varchar(100)")]
       public string? isin_suspended_description_84 { get; set; }

       [Column("money_due_date_85", Order = 100, TypeName = "varchar(20)")]
       public string? money_due_date_85 { get; set; }

       [Column("isin_complete_86", Order = 101, TypeName = "varchar(10)")]
       public string? isin_complete_86 { get; set; }

       [Column("remarks_87", Order = 102, TypeName = "varchar(180)")]
       public string? remarks_87 { get; set; }

       [Column("record_status", Order = 103, TypeName = "varchar(20)")]
       public string? record_status { get; set; }

   }
}
