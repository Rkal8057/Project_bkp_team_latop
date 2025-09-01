using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_to_ca_master_main_01")] 
       
   public class Tr_To_Ca_Master_Main_01
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_id", Order = 2, TypeName = "bigint(10)")]
       public long? trx_id { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("trfdate", Order = 4, TypeName = "datetime")]
       public DateTime? trfdate { get; set; }

       [Column("vou_type", Order = 5, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("current_status", Order = 6, TypeName = "varchar(50)")]
       public string? current_status { get; set; }

       [Column("entry_by_maker", Order = 7, TypeName = "varchar(50)")]
       public string? entry_by_maker { get; set; }

       [Column("entry_check_by_checker", Order = 8, TypeName = "varchar(50)")]
       public string? entry_check_by_checker { get; set; }

       [Column("maker_username", Order = 9, TypeName = "varchar(50)")]
       public string? maker_username { get; set; }

       [Column("checker_username", Order = 10, TypeName = "varchar(50)")]
       public string? checker_username { get; set; }

       [Column("remarks", Order = 11, TypeName = "varchar(50)")]
       public string? remarks { get; set; }

       [Column("value_date", Order = 12, TypeName = "datetime")]
       public DateTime? value_date { get; set; }

       [Column("exchange_name", Order = 13, TypeName = "varchar(25)")]
       public string? exchange_name { get; set; }

       [Column("execution_date", Order = 14, TypeName = "datetime")]
       public DateTime? execution_date { get; set; }

       [Column("allot_date", Order = 15, TypeName = "datetime")]
       public DateTime? allot_date { get; set; }

       [Column("ca_type_flag", Order = 16, TypeName = "varchar(100)")]
       public string? ca_type_flag { get; set; }

       [Column("cr_dr_indicator", Order = 17, TypeName = "varchar(25)")]
       public string? cr_dr_indicator { get; set; }

       [Column("ca_type_desc_code_master", Order = 18, TypeName = "varchar(50)")]
       public string? ca_type_desc_code_master { get; set; }

       [Column("ca_type_desc_name_master", Order = 19, TypeName = "varchar(50)")]
       public string? ca_type_desc_name_master { get; set; }

       [Column("ca_type_desc_code_sub", Order = 20, TypeName = "varchar(50)")]
       public string? ca_type_desc_code_sub { get; set; }

       [Column("ca_type_desc_name_sub", Order = 21, TypeName = "varchar(50)")]
       public string? ca_type_desc_name_sub { get; set; }

       [Column("tot_allotment_qty", Order = 22, TypeName = "float")]
       public long? tot_allotment_qty { get; set; }

       [Column("lock_in_c_allot_qty", Order = 23, TypeName = "float")]
       public long? lock_in_c_allot_qty { get; set; }

       [Column("stamp_duty_payable", Order = 24, TypeName = "varchar(3)")]
       public string? stamp_duty_payable { get; set; }

       [Column("stamp_duty_type", Order = 25, TypeName = "varchar(100)")]
       public string? stamp_duty_type { get; set; }

       [Column("ebp_name", Order = 26, TypeName = "varchar(100)")]
       public string? ebp_name { get; set; }

       [Column("funds_collected_through", Order = 27, TypeName = "varchar(100)")]
       public string? funds_collected_through { get; set; }

       [Column("share_amt_tot", Order = 28, TypeName = "float")]
       public long? share_amt_tot { get; set; }

       [Column("tot_lines_detail_records_02", Order = 29, TypeName = "float")]
       public long? tot_lines_detail_records_02 { get; set; }

       [Column("tot_lines_dnr_records_drn_03", Order = 30, TypeName = "float")]
       public long? tot_lines_dnr_records_drn_03 { get; set; }

       [Column("tot_qty_detail_records_02", Order = 31, TypeName = "float")]
       public long? tot_qty_detail_records_02 { get; set; }

       [Column("tot_qty_dnr_records_drn_03", Order = 32, TypeName = "float")]
       public long? tot_qty_dnr_records_drn_03 { get; set; }

       [Column("issue_price_tot", Order = 33, TypeName = "float")]
       public long? issue_price_tot { get; set; }

       [Column("paidup_price_tot", Order = 34, TypeName = "float")]
       public long? paidup_price_tot { get; set; }

       [Column("issued_amount_tot", Order = 35, TypeName = "float")]
       public long? issued_amount_tot { get; set; }

       [Column("paidup_amount_tot", Order = 36, TypeName = "float")]
       public long? paidup_amount_tot { get; set; }

       [Column("tot_qty_cr_simultaneous", Order = 37, TypeName = "float")]
       public long? tot_qty_cr_simultaneous { get; set; }

       [Column("tot_qty_dr_simultaneous", Order = 38, TypeName = "float")]
       public long? tot_qty_dr_simultaneous { get; set; }

       [Column("dr_current_quantity_tot", Order = 39, TypeName = "float")]
       public long? dr_current_quantity_tot { get; set; }

       [Column("dr_frozen_quantity_tot", Order = 40, TypeName = "float")]
       public long? dr_frozen_quantity_tot { get; set; }

       [Column("dr_lock_in_quantity_tot", Order = 41, TypeName = "float")]
       public long? dr_lock_in_quantity_tot { get; set; }

       [Column("cr_current_quantity_tot", Order = 42, TypeName = "float")]
       public long? cr_current_quantity_tot { get; set; }

       [Column("cr_frozen_quantity_tot", Order = 43, TypeName = "float")]
       public long? cr_frozen_quantity_tot { get; set; }

       [Column("cr_lock_in_quantity_tot", Order = 44, TypeName = "float")]
       public long? cr_lock_in_quantity_tot { get; set; }

       [Column("comp_sno", Order = 45, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 46, TypeName = "varchar(20)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 47, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 48, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("comp_isin_cr", Order = 49, TypeName = "varchar(20)")]
       public string? comp_isin_cr { get; set; }

       [Column("comp_isin_dr", Order = 50, TypeName = "varchar(20)")]
       public string? comp_isin_dr { get; set; }

       [Column("trfno_manual", Order = 51, TypeName = "varchar(50)")]
       public string? trfno_manual { get; set; }

       [Column("dp_ref_no", Order = 52, TypeName = "varchar(50)")]
       public string? dp_ref_no { get; set; }

   }
}
