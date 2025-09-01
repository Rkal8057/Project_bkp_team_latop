using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("iepf_detail_cdsl_ndsl")] 
       
   public class Iepf_Detail_Cdsl_Ndsl
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("c2_m_r_i", Order = 3, TypeName = "varchar(2)")]
       public string? c2_m_r_i { get; set; }

       [Column("c3_m_rec_l_no", Order = 4, TypeName = "varchar(5)")]
       public string? c3_m_rec_l_no { get; set; }

       [Column("c4_m_cr_bo_id", Order = 5, TypeName = "varchar(16)")]
       public string? c4_m_cr_bo_id { get; set; }

       [Column("c5_m_dr_dp_id", Order = 6, TypeName = "varchar(8)")]
       public string? c5_m_dr_dp_id { get; set; }

       [Column("c6_m_dr_cl_id", Order = 7, TypeName = "varchar(8)")]
       public string? c6_m_dr_cl_id { get; set; }

       [Column("c7_m_dr_qty", Order = 8, TypeName = "varchar(16)")]
       public string? c7_m_dr_qty { get; set; }

       [Column("c8_o_dr_lock_in_qty", Order = 9, TypeName = "varchar(16)")]
       public string? c8_o_dr_lock_in_qty { get; set; }

       [Column("c9_o_dr_lcok_in_code", Order = 10, TypeName = "varchar(2)")]
       public string? c9_o_dr_lcok_in_code { get; set; }

       [Column("c10_o_dr_lock_in_exp_dt", Order = 11, TypeName = "varchar(8)")]
       public string? c10_o_dr_lock_in_exp_dt { get; set; }

       [Column("c11_filler_1", Order = 12, TypeName = "varchar(16)")]
       public string? c11_filler_1 { get; set; }

       [Column("c12_m_credit_qty", Order = 13, TypeName = "varchar(16)")]
       public string? c12_m_credit_qty { get; set; }

       [Column("c13_o_credit_l_qty", Order = 14, TypeName = "varchar(16)")]
       public string? c13_o_credit_l_qty { get; set; }

       [Column("c14o_credit_lock_in_code", Order = 15, TypeName = "varchar(2)")]
       public string? c14o_credit_lock_in_code { get; set; }

       [Column("c15_o_credit_lock_in_exp_dt", Order = 16, TypeName = "varchar(8)")]
       public string? c15_o_credit_lock_in_exp_dt { get; set; }

       [Column("c16_m_1st_holder_name", Order = 17, TypeName = "varchar(250)")]
       public string? c16_m_1st_holder_name { get; set; }

       [Column("c17_o_holder_pan", Order = 18, TypeName = "varchar(30)")]
       public string? c17_o_holder_pan { get; set; }

       [Column("c18_o_2nd_holder_name", Order = 19, TypeName = "varchar(45)")]
       public string? c18_o_2nd_holder_name { get; set; }

       [Column("c19_o_2nd_holder_pan", Order = 20, TypeName = "varchar(30)")]
       public string? c19_o_2nd_holder_pan { get; set; }

       [Column("c20_o_3rd_holder_name", Order = 21, TypeName = "varchar(45)")]
       public string? c20_o_3rd_holder_name { get; set; }

       [Column("c21_o_3rd_holder_pan", Order = 22, TypeName = "varchar(30)")]
       public string? c21_o_3rd_holder_pan { get; set; }

       [Column("c21_o_4th_holder_name", Order = 23, TypeName = "varchar(45)")]
       public string? c21_o_4th_holder_name { get; set; }

       [Column("c21_o_4th_holder_pan", Order = 24, TypeName = "varchar(30)")]
       public string? c21_o_4th_holder_pan { get; set; }

       [Column("c22_o_guardian_name", Order = 25, TypeName = "varchar(45)")]
       public string? c22_o_guardian_name { get; set; }

       [Column("c22_o_guardian_pan", Order = 26, TypeName = "varchar(30)")]
       public string? c22_o_guardian_pan { get; set; }

       [Column("c23_o_filler_2", Order = 27, TypeName = "varchar(10)")]
       public string? c23_o_filler_2 { get; set; }

       [Column("c24_o_nominee_name", Order = 28, TypeName = "varchar(45)")]
       public string? c24_o_nominee_name { get; set; }

       [Column("c24_o_nominee_pan", Order = 29, TypeName = "varchar(45)")]
       public string? c24_o_nominee_pan { get; set; }

       [Column("c25_o_filler_3", Order = 30, TypeName = "varchar(10)")]
       public string? c25_o_filler_3 { get; set; }

       [Column("c26_o_fat_hus_name", Order = 31, TypeName = "varchar(45)")]
       public string? c26_o_fat_hus_name { get; set; }

       [Column("c26_1st_holder_sex", Order = 32, TypeName = "varchar(1)")]
       public string? c26_1st_holder_sex { get; set; }

       [Column("c27_o_filler_4", Order = 33, TypeName = "varchar(1)")]
       public string? c27_o_filler_4 { get; set; }

       [Column("c28_o_birth_date", Order = 34, TypeName = "varchar(8)")]
       public string? c28_o_birth_date { get; set; }

       [Column("c29_m_account_type", Order = 35, TypeName = "varchar(100)")]
       public string? c29_m_account_type { get; set; }

       [Column("c30_m_account_sub_type", Order = 36, TypeName = "varchar(100)")]
       public string? c30_m_account_sub_type { get; set; }

       [Column("c31_o_occupation", Order = 37, TypeName = "varchar(100)")]
       public string? c31_o_occupation { get; set; }

       [Column("c32_o_filler_5", Order = 38, TypeName = "varchar(25)")]
       public string? c32_o_filler_5 { get; set; }

       [Column("c32_o_nationality", Order = 39, TypeName = "varchar(25)")]
       public string? c32_o_nationality { get; set; }

       [Column("c32_o_investor_category", Order = 40, TypeName = "varchar(25)")]
       public string? c32_o_investor_category { get; set; }

       [Column("c33_o_corr_add_line_1", Order = 41, TypeName = "varchar(36)")]
       public string? c33_o_corr_add_line_1 { get; set; }

       [Column("c34_o_corr_add_line_2", Order = 42, TypeName = "varchar(36)")]
       public string? c34_o_corr_add_line_2 { get; set; }

       [Column("c35_o_corr_add_line_3", Order = 43, TypeName = "varchar(36)")]
       public string? c35_o_corr_add_line_3 { get; set; }

       [Column("c36_o_corr_add_line_4", Order = 44, TypeName = "varchar(36)")]
       public string? c36_o_corr_add_line_4 { get; set; }

       [Column("c36_o_corr_add_line_4_city", Order = 45, TypeName = "varchar(25)")]
       public string? c36_o_corr_add_line_4_city { get; set; }

       [Column("c37_o_corr_add_state", Order = 46, TypeName = "varchar(25)")]
       public string? c37_o_corr_add_state { get; set; }

       [Column("c37_o_corr_add_country", Order = 47, TypeName = "varchar(25)")]
       public string? c37_o_corr_add_country { get; set; }

       [Column("c37_o_corr_add_pin", Order = 48, TypeName = "varchar(10)")]
       public string? c37_o_corr_add_pin { get; set; }

       [Column("c38_m_perm_add_line_1", Order = 49, TypeName = "varchar(36)")]
       public string? c38_m_perm_add_line_1 { get; set; }

       [Column("c39_perm_add_line_2", Order = 50, TypeName = "varchar(36)")]
       public string? c39_perm_add_line_2 { get; set; }

       [Column("c40_perm_add_line_3", Order = 51, TypeName = "varchar(36)")]
       public string? c40_perm_add_line_3 { get; set; }

       [Column("c41_m_perm_add_line_4", Order = 52, TypeName = "varchar(36)")]
       public string? c41_m_perm_add_line_4 { get; set; }

       [Column("c41_m_perm_add_line_4_city", Order = 53, TypeName = "varchar(25)")]
       public string? c41_m_perm_add_line_4_city { get; set; }

       [Column("c41_m_perm_add_state", Order = 54, TypeName = "varchar(25)")]
       public string? c41_m_perm_add_state { get; set; }

       [Column("c41_m_perm_add_country", Order = 55, TypeName = "varchar(25)")]
       public string? c41_m_perm_add_country { get; set; }

       [Column("c42_m_perm_add_pincode", Order = 56, TypeName = "varchar(10)")]
       public string? c42_m_perm_add_pincode { get; set; }

       [Column("c43_telephone_1", Order = 57, TypeName = "varchar(24)")]
       public string? c43_telephone_1 { get; set; }

       [Column("c43_telephone_2", Order = 58, TypeName = "varchar(24)")]
       public string? c43_telephone_2 { get; set; }

       [Column("c44_filler_6", Order = 59, TypeName = "varchar(20)")]
       public string? c44_filler_6 { get; set; }

       [Column("c45_fax", Order = 60, TypeName = "varchar(24)")]
       public string? c45_fax { get; set; }

       [Column("c46_e_mail_id", Order = 61, TypeName = "varchar(50)")]
       public string? c46_e_mail_id { get; set; }

       [Column("c47_uid_of_f_holder", Order = 62, TypeName = "varchar(12)")]
       public string? c47_uid_of_f_holder { get; set; }

       [Column("c48_uid_of_s_holder", Order = 63, TypeName = "varchar(12)")]
       public string? c48_uid_of_s_holder { get; set; }

       [Column("c49_uid_of_t_holder", Order = 64, TypeName = "varchar(12)")]
       public string? c49_uid_of_t_holder { get; set; }

       [Column("c49_uid_of_f_holder", Order = 65, TypeName = "varchar(12)")]
       public string? c49_uid_of_f_holder { get; set; }

       [Column("c49_uid_of_g_holder", Order = 66, TypeName = "varchar(12)")]
       public string? c49_uid_of_g_holder { get; set; }

       [Column("c49_uid_of_n_holder", Order = 67, TypeName = "varchar(12)")]
       public string? c49_uid_of_n_holder { get; set; }

       [Column("c50_filler_7", Order = 68, TypeName = "varchar(12)")]
       public string? c50_filler_7 { get; set; }

       [Column("c51_filler_8", Order = 69, TypeName = "varchar(12)")]
       public string? c51_filler_8 { get; set; }

       [Column("c52_filler_9", Order = 70, TypeName = "varchar(100)")]
       public string? c52_filler_9 { get; set; }

   }
}
