using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_detail_nsdl_phy")] 
       
   public class Iepf_Detail_Nsdl_Phy
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("c1_m_r_i", Order = 3, TypeName = "varchar(2)")]
       public string? c1_m_r_i { get; set; }

       [Column("c2_m_record_l_no", Order = 4, TypeName = "varchar(7)")]
       public string? c2_m_record_l_no { get; set; }

       [Column("c3_m_cr_dp_id", Order = 5, TypeName = "varchar(8)")]
       public string? c3_m_cr_dp_id { get; set; }

       [Column("c4_m_cr_cl_id", Order = 6, TypeName = "varchar(8)")]
       public string? c4_m_cr_cl_id { get; set; }

       [Column("c5_m_cr_ac_cate", Order = 7, TypeName = "varchar(2)")]
       public string? c5_m_cr_ac_cate { get; set; }

       [Column("c6_m_folio_no", Order = 8, TypeName = "varchar(16)")]
       public string? c6_m_folio_no { get; set; }

       [Column("c5_filler", Order = 9, TypeName = "varchar(2)")]
       public string? c5_filler { get; set; }

       [Column("c6_m_cr_qty", Order = 10, TypeName = "varchar(18)")]
       public string? c6_m_cr_qty { get; set; }

       [Column("c7_m_dr_qty", Order = 11, TypeName = "varchar(18)")]
       public string? c7_m_dr_qty { get; set; }

       [Column("c8_m_cr_lock_in_reason_code", Order = 12, TypeName = "varchar(2)")]
       public string? c8_m_cr_lock_in_reason_code { get; set; }

       [Column("c9_cm_r_lock_in_release_dt", Order = 13, TypeName = "varchar(8)")]
       public string? c9_cm_r_lock_in_release_dt { get; set; }

       [Column("c10_m_dr_lock_in_reason_code", Order = 14, TypeName = "varchar(2)")]
       public string? c10_m_dr_lock_in_reason_code { get; set; }

       [Column("c11_m_dr_lock_in_release_dt", Order = 15, TypeName = "varchar(8)")]
       public string? c11_m_dr_lock_in_release_dt { get; set; }

       [Column("c12_m_first_holder_name", Order = 16, TypeName = "varchar(164)")]
       public string? c12_m_first_holder_name { get; set; }

       [Column("c13_second_holder_name", Order = 17, TypeName = "varchar(164)")]
       public string? c13_second_holder_name { get; set; }

       [Column("c14_third_holder_name", Order = 18, TypeName = "varchar(164)")]
       public string? c14_third_holder_name { get; set; }

       [Column("c15_guardian_name", Order = 19, TypeName = "varchar(142)")]
       public string? c15_guardian_name { get; set; }

       [Column("c16_nominee_nane", Order = 20, TypeName = "varchar(142)")]
       public string? c16_nominee_nane { get; set; }

       [Column("c17_father_husband_name", Order = 21, TypeName = "varchar(50)")]
       public string? c17_father_husband_name { get; set; }

       [Column("c18_sex_of_first_holder", Order = 22, TypeName = "varchar(1)")]
       public string? c18_sex_of_first_holder { get; set; }

       [Column("c19_birth_date", Order = 23, TypeName = "varchar(11)")]
       public string? c19_birth_date { get; set; }

       [Column("c20_filler", Order = 24, TypeName = "varchar(2)")]
       public string? c20_filler { get; set; }

       [Column("c21_filler", Order = 25, TypeName = "varchar(2)")]
       public string? c21_filler { get; set; }

       [Column("c22_filler", Order = 26, TypeName = "varchar(4)")]
       public string? c22_filler { get; set; }

       [Column("c23_filler", Order = 27, TypeName = "varchar(2)")]
       public string? c23_filler { get; set; }

       [Column("c24_filler", Order = 28, TypeName = "varchar(4)")]
       public string? c24_filler { get; set; }

       [Column("c28_occupation", Order = 29, TypeName = "varchar(4)")]
       public string? c28_occupation { get; set; }

       [Column("c29_holder_pan_1st", Order = 30, TypeName = "varchar(10)")]
       public string? c29_holder_pan_1st { get; set; }

       [Column("c30_holder_pan_2n", Order = 31, TypeName = "varchar(10)")]
       public string? c30_holder_pan_2n { get; set; }

       [Column("c31_holder_pan_3rd", Order = 32, TypeName = "varchar(10)")]
       public string? c31_holder_pan_3rd { get; set; }

       [Column("c30_filler", Order = 33, TypeName = "varchar(1)")]
       public string? c30_filler { get; set; }

       [Column("c32_filler", Order = 34, TypeName = "varchar(2)")]
       public string? c32_filler { get; set; }

       [Column("c33_filler", Order = 35, TypeName = "varchar(1)")]
       public string? c33_filler { get; set; }

       [Column("c34_filler", Order = 36, TypeName = "varchar(11)")]
       public string? c34_filler { get; set; }

       [Column("c35_filler", Order = 37, TypeName = "varchar(24)")]
       public string? c35_filler { get; set; }

       [Column("c36_filler", Order = 38, TypeName = "varchar(2)")]
       public string? c36_filler { get; set; }

       [Column("c37_filler", Order = 39, TypeName = "varchar(6)")]
       public string? c37_filler { get; set; }

       [Column("c38_filler", Order = 40, TypeName = "varchar(8)")]
       public string? c38_filler { get; set; }

       [Column("c39_filler", Order = 41, TypeName = "varchar(8)")]
       public string? c39_filler { get; set; }

       [Column("c40_filler", Order = 42, TypeName = "varchar(30)")]
       public string? c40_filler { get; set; }

       [Column("c41_filler", Order = 43, TypeName = "varchar(11)")]
       public string? c41_filler { get; set; }

       [Column("c42_filler", Order = 44, TypeName = "varchar(2)")]
       public string? c42_filler { get; set; }

       [Column("c43_nationality", Order = 45, TypeName = "varchar(3)")]
       public string? c43_nationality { get; set; }

       [Column("c44_corr_add_line_1", Order = 46, TypeName = "varchar(50)")]
       public string? c44_corr_add_line_1 { get; set; }

       [Column("c45_corr_add_line_2", Order = 47, TypeName = "varchar(50)")]
       public string? c45_corr_add_line_2 { get; set; }

       [Column("c46_corr_add_line_3", Order = 48, TypeName = "varchar(50)")]
       public string? c46_corr_add_line_3 { get; set; }

       [Column("c47_corr_add_city", Order = 49, TypeName = "varchar(30)")]
       public string? c47_corr_add_city { get; set; }

       [Column("c48_corr_add_state", Order = 50, TypeName = "varchar(30)")]
       public string? c48_corr_add_state { get; set; }

       [Column("c49_corr_add_country", Order = 51, TypeName = "varchar(30)")]
       public string? c49_corr_add_country { get; set; }

       [Column("c50_corr_add_pin_code", Order = 52, TypeName = "varchar(10)")]
       public string? c50_corr_add_pin_code { get; set; }

       [Column("c38_m_bo_add_line_1", Order = 53, TypeName = "varchar(50)")]
       public string? c38_m_bo_add_line_1 { get; set; }

       [Column("c39_bo_add_line_2", Order = 54, TypeName = "varchar(50)")]
       public string? c39_bo_add_line_2 { get; set; }

       [Column("c40_bo_add_line_3", Order = 55, TypeName = "varchar(50)")]
       public string? c40_bo_add_line_3 { get; set; }

       [Column("c41_bo_add_city", Order = 56, TypeName = "varchar(30)")]
       public string? c41_bo_add_city { get; set; }

       [Column("c42_bo_add_state", Order = 57, TypeName = "varchar(30)")]
       public string? c42_bo_add_state { get; set; }

       [Column("c43_bo_add_country", Order = 58, TypeName = "varchar(30)")]
       public string? c43_bo_add_country { get; set; }

       [Column("c44_bo_add_pin_code", Order = 59, TypeName = "varchar(10)")]
       public string? c44_bo_add_pin_code { get; set; }

       [Column("c45_telephone_1", Order = 60, TypeName = "varchar(17)")]
       public string? c45_telephone_1 { get; set; }

       [Column("c46_telephone_2", Order = 61, TypeName = "varchar(17)")]
       public string? c46_telephone_2 { get; set; }

       [Column("c47_bo_fax", Order = 62, TypeName = "varchar(17)")]
       public string? c47_bo_fax { get; set; }

       [Column("c48_e_mail_id", Order = 63, TypeName = "varchar(50)")]
       public string? c48_e_mail_id { get; set; }

       [Column("c49_bo_e_mandate_flag", Order = 64, TypeName = "varchar(1)")]
       public string? c49_bo_e_mandate_flag { get; set; }

       [Column("c50_micr_no_bank", Order = 65, TypeName = "varchar(12)")]
       public string? c50_micr_no_bank { get; set; }

       [Column("c51_divinend_bank_branch", Order = 66, TypeName = "varchar(12)")]
       public string? c51_divinend_bank_branch { get; set; }

       [Column("c52_bank_name", Order = 67, TypeName = "varchar(100)")]
       public string? c52_bank_name { get; set; }

       [Column("c53_bank_add_1", Order = 68, TypeName = "varchar(40)")]
       public string? c53_bank_add_1 { get; set; }

       [Column("c54_bank_add_2", Order = 69, TypeName = "varchar(40)")]
       public string? c54_bank_add_2 { get; set; }

       [Column("c55_bank_add_3", Order = 70, TypeName = "varchar(40)")]
       public string? c55_bank_add_3 { get; set; }

       [Column("c56_bank_city", Order = 71, TypeName = "varchar(25)")]
       public string? c56_bank_city { get; set; }

       [Column("c57_bank_state", Order = 72, TypeName = "varchar(25)")]
       public string? c57_bank_state { get; set; }

       [Column("c58_bank_country", Order = 73, TypeName = "varchar(25)")]
       public string? c58_bank_country { get; set; }

       [Column("c59_bank_pin_code", Order = 74, TypeName = "varchar(10)")]
       public string? c59_bank_pin_code { get; set; }

       [Column("c60_bank_currency", Order = 75, TypeName = "varchar(6)")]
       public string? c60_bank_currency { get; set; }

       [Column("c61_bank_ac_type", Order = 76, TypeName = "varchar(5)")]
       public string? c61_bank_ac_type { get; set; }

       [Column("c62_bank_ac_integer", Order = 77, TypeName = "varchar(20)")]
       public string? c62_bank_ac_integer { get; set; }

       [Column("c63_filler", Order = 78, TypeName = "varchar(22)")]
       public string? c63_filler { get; set; }

       [Column("c64_filler", Order = 79, TypeName = "varchar(22)")]
       public string? c64_filler { get; set; }

       [Column("c65_filler", Order = 80, TypeName = "varchar(22)")]
       public string? c65_filler { get; set; }

       [Column("c66_filler", Order = 81, TypeName = "varchar(22)")]
       public string? c66_filler { get; set; }

       [Column("c67_filler", Order = 82, TypeName = "varchar(22)")]
       public string? c67_filler { get; set; }

       [Column("c68_filler", Order = 83, TypeName = "varchar(22)")]
       public string? c68_filler { get; set; }

       [Column("c69_filler", Order = 84, TypeName = "varchar(22)")]
       public string? c69_filler { get; set; }

       [Column("c70_filler", Order = 85, TypeName = "varchar(22)")]
       public string? c70_filler { get; set; }

       [Column("c71_filler", Order = 86, TypeName = "varchar(22)")]
       public string? c71_filler { get; set; }

       [Column("c72_filler", Order = 87, TypeName = "varchar(8)")]
       public string? c72_filler { get; set; }

       [Column("c73_filler", Order = 88, TypeName = "varchar(22)")]
       public string? c73_filler { get; set; }

       [Column("c74_filler", Order = 89, TypeName = "varchar(22)")]
       public string? c74_filler { get; set; }

       [Column("c75_annual_rpt_flag", Order = 90, TypeName = "varchar(1)")]
       public string? c75_annual_rpt_flag { get; set; }

       [Column("c76_uid_holder_1st", Order = 91, TypeName = "varchar(12)")]
       public string? c76_uid_holder_1st { get; set; }

       [Column("c77_uid_holder_2nd", Order = 92, TypeName = "varchar(12)")]
       public string? c77_uid_holder_2nd { get; set; }

       [Column("c78_uid_holder_3rd", Order = 93, TypeName = "varchar(12)")]
       public string? c78_uid_holder_3rd { get; set; }

       [Column("c79_guardian_pan", Order = 94, TypeName = "varchar(10)")]
       public string? c79_guardian_pan { get; set; }

       [Column("c80_uid_holder_guardian", Order = 95, TypeName = "varchar(12)")]
       public string? c80_uid_holder_guardian { get; set; }

       [Column("c81_filler", Order = 96, TypeName = "varchar(25)")]
       public string? c81_filler { get; set; }

       [Column("c82_filler", Order = 97, TypeName = "varchar(25)")]
       public string? c82_filler { get; set; }

       [Column("c83_filler", Order = 98, TypeName = "varchar(25)")]
       public string? c83_filler { get; set; }

       [Column("c84_filler", Order = 99, TypeName = "varchar(25)")]
       public string? c84_filler { get; set; }

       [Column("c85_filler", Order = 100, TypeName = "varchar(25)")]
       public string? c85_filler { get; set; }

       [Column("c86_bo_rgess_flag", Order = 101, TypeName = "varchar(1)")]
       public string? c86_bo_rgess_flag { get; set; }

       [Column("c87_filler", Order = 102, TypeName = "varchar(1)")]
       public string? c87_filler { get; set; }

       [Column("c88_filler", Order = 103, TypeName = "varchar(1)")]
       public string? c88_filler { get; set; }

       [Column("c89_filler", Order = 104, TypeName = "varchar(1)")]
       public string? c89_filler { get; set; }

       [Column("c90_filler", Order = 105, TypeName = "varchar(1)")]
       public string? c90_filler { get; set; }

       [Column("c91_filler1126", Order = 106, TypeName = "varchar(1126)")]
       public string? c91_filler1126 { get; set; }

       [Column("c92_filler1101", Order = 107, TypeName = "varchar(1101)")]
       public string? c92_filler1101 { get; set; }

   }
}
