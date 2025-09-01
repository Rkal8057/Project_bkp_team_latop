using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_detail_cdsl_phy")] 
       
   public class Iepf_Detail_Cdsl_Phy
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("c1_r_i", Order = 3, TypeName = "varchar(2)")]
       public string? c1_r_i { get; set; }

       [Column("c2_record_l_no", Order = 4, TypeName = "varchar(5)")]
       public string? c2_record_l_no { get; set; }

       [Column("c3_cr_bo_id", Order = 5, TypeName = "varchar(16)")]
       public string? c3_cr_bo_id { get; set; }

       [Column("c4_folio_no", Order = 6, TypeName = "varchar(16)")]
       public string? c4_folio_no { get; set; }

       [Column("c5_dr_qty", Order = 7, TypeName = "varchar(16)")]
       public string? c5_dr_qty { get; set; }

       [Column("c6_dr_l_qty", Order = 8, TypeName = "varchar(16)")]
       public string? c6_dr_l_qty { get; set; }

       [Column("c7_dr_l_in_reason_code", Order = 9, TypeName = "varchar(2)")]
       public string? c7_dr_l_in_reason_code { get; set; }

       [Column("c8_dr_lock_in_exp_dt", Order = 10, TypeName = "varchar(8)")]
       public string? c8_dr_lock_in_exp_dt { get; set; }

       [Column("c9_cr_qty", Order = 11, TypeName = "varchar(16)")]
       public string? c9_cr_qty { get; set; }

       [Column("c10_cr_l_qty", Order = 12, TypeName = "varchar(16)")]
       public string? c10_cr_l_qty { get; set; }

       [Column("c11_cr_lock_in_reason_code", Order = 13, TypeName = "varchar(2)")]
       public string? c11_cr_lock_in_reason_code { get; set; }

       [Column("c12_cr_lock_in_exp_dt", Order = 14, TypeName = "varchar(8)")]
       public string? c12_cr_lock_in_exp_dt { get; set; }

       [Column("c13_first_holder_name", Order = 15, TypeName = "varchar(164)")]
       public string? c13_first_holder_name { get; set; }

       [Column("c14_holder_pan", Order = 16, TypeName = "varchar(10)")]
       public string? c14_holder_pan { get; set; }

       [Column("c15_second_holder_name", Order = 17, TypeName = "varchar(164)")]
       public string? c15_second_holder_name { get; set; }

       [Column("c16_second_holder_pan", Order = 18, TypeName = "varchar(10)")]
       public string? c16_second_holder_pan { get; set; }

       [Column("c17_third_holder_name", Order = 19, TypeName = "varchar(164)")]
       public string? c17_third_holder_name { get; set; }

       [Column("c18_third_holder_pan", Order = 20, TypeName = "varchar(10)")]
       public string? c18_third_holder_pan { get; set; }

       [Column("c19_fourth_holder_name", Order = 21, TypeName = "varchar(164)")]
       public string? c19_fourth_holder_name { get; set; }

       [Column("c20_fourth_holder_pan", Order = 22, TypeName = "varchar(10)")]
       public string? c20_fourth_holder_pan { get; set; }

       [Column("c21_guardian_name", Order = 23, TypeName = "varchar(164)")]
       public string? c21_guardian_name { get; set; }

       [Column("c22_guardian_pan", Order = 24, TypeName = "varchar(10)")]
       public string? c22_guardian_pan { get; set; }

       [Column("c23_nominee_nane", Order = 25, TypeName = "varchar(164)")]
       public string? c23_nominee_nane { get; set; }

       [Column("c24_nominee_pan", Order = 26, TypeName = "varchar(10)")]
       public string? c24_nominee_pan { get; set; }

       [Column("c25_father_husband_name", Order = 27, TypeName = "varchar(50)")]
       public string? c25_father_husband_name { get; set; }

       [Column("c26_sex_of_first_holder", Order = 28, TypeName = "varchar(1)")]
       public string? c26_sex_of_first_holder { get; set; }

       [Column("c27_birth_date", Order = 29, TypeName = "varchar(8)")]
       public string? c27_birth_date { get; set; }

       [Column("c28_occupation", Order = 30, TypeName = "varchar(4)")]
       public string? c28_occupation { get; set; }

       [Column("c29_nationality", Order = 31, TypeName = "varchar(25)")]
       public string? c29_nationality { get; set; }

       [Column("c30_investor_category", Order = 32, TypeName = "varchar(30)")]
       public string? c30_investor_category { get; set; }

       [Column("c31_corr_add_line_1", Order = 33, TypeName = "varchar(50)")]
       public string? c31_corr_add_line_1 { get; set; }

       [Column("c32_corr_add_line_2", Order = 34, TypeName = "varchar(50)")]
       public string? c32_corr_add_line_2 { get; set; }

       [Column("c33_corr_add_line_3", Order = 35, TypeName = "varchar(50)")]
       public string? c33_corr_add_line_3 { get; set; }

       [Column("c34_corr_add_city", Order = 36, TypeName = "varchar(25)")]
       public string? c34_corr_add_city { get; set; }

       [Column("c35_corr_add_state", Order = 37, TypeName = "varchar(25)")]
       public string? c35_corr_add_state { get; set; }

       [Column("c36_corr_add_country", Order = 38, TypeName = "varchar(25)")]
       public string? c36_corr_add_country { get; set; }

       [Column("c37_corr_add_pin_code", Order = 39, TypeName = "varchar(10)")]
       public string? c37_corr_add_pin_code { get; set; }

       [Column("c38_per_add_line_1", Order = 40, TypeName = "varchar(50)")]
       public string? c38_per_add_line_1 { get; set; }

       [Column("c39_per_add_line_2", Order = 41, TypeName = "varchar(50)")]
       public string? c39_per_add_line_2 { get; set; }

       [Column("c40_per_add_line_3", Order = 42, TypeName = "varchar(50)")]
       public string? c40_per_add_line_3 { get; set; }

       [Column("c41_per_add_city", Order = 43, TypeName = "varchar(25)")]
       public string? c41_per_add_city { get; set; }

       [Column("c42_per_add_state", Order = 44, TypeName = "varchar(25)")]
       public string? c42_per_add_state { get; set; }

       [Column("c43_per_add_country", Order = 45, TypeName = "varchar(25)")]
       public string? c43_per_add_country { get; set; }

       [Column("c44_per_add_pin_code", Order = 46, TypeName = "varchar(10)")]
       public string? c44_per_add_pin_code { get; set; }

       [Column("c45_telephone_1", Order = 47, TypeName = "varchar(17)")]
       public string? c45_telephone_1 { get; set; }

       [Column("c46_telephone_2", Order = 48, TypeName = "varchar(17)")]
       public string? c46_telephone_2 { get; set; }

       [Column("c47_bo_fax", Order = 49, TypeName = "varchar(17)")]
       public string? c47_bo_fax { get; set; }

       [Column("c48_e_mail_id", Order = 50, TypeName = "varchar(50)")]
       public string? c48_e_mail_id { get; set; }

       [Column("c49_uid_of_first_holder", Order = 51, TypeName = "varchar(12)")]
       public string? c49_uid_of_first_holder { get; set; }

       [Column("c50_uid_of_second_holder", Order = 52, TypeName = "varchar(12)")]
       public string? c50_uid_of_second_holder { get; set; }

       [Column("c51_uid_of_third_holder", Order = 53, TypeName = "varchar(12)")]
       public string? c51_uid_of_third_holder { get; set; }

       [Column("c52_uid_of_fourth_holder", Order = 54, TypeName = "varchar(12)")]
       public string? c52_uid_of_fourth_holder { get; set; }

       [Column("c53_uid_of_guardian", Order = 55, TypeName = "varchar(12)")]
       public string? c53_uid_of_guardian { get; set; }

       [Column("c54_uid_of_nominee", Order = 56, TypeName = "varchar(12)")]
       public string? c54_uid_of_nominee { get; set; }

       [Column("c55_filler", Order = 57, TypeName = "varchar(100)")]
       public string? c55_filler { get; set; }

   }
}
