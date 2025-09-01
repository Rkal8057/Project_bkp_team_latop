using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("nri_tmp_detail_all")] 
       
   public class Nri_Tmp_Detail_All
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("share_qty_per", Order = 3, TypeName = "float")]
       public long? share_qty_per { get; set; }

       [Column("qty_nsdl", Order = 4, TypeName = "float")]
       public long? qty_nsdl { get; set; }

       [Column("qty_cdsl", Order = 5, TypeName = "float")]
       public long? qty_cdsl { get; set; }

       [Column("qty_phy", Order = 6, TypeName = "float")]
       public long? qty_phy { get; set; }

       [Column("other_then_free", Order = 7, TypeName = "float")]
       public long? other_then_free { get; set; }

       [Column("lock_in_qty", Order = 8, TypeName = "float")]
       public long? lock_in_qty { get; set; }

       [Column("block_qty", Order = 9, TypeName = "float")]
       public long? block_qty { get; set; }

       [Column("pledged_qty", Order = 10, TypeName = "float")]
       public long? pledged_qty { get; set; }

       [Column("pledged_with_lock_in_qty", Order = 11, TypeName = "float")]
       public long? pledged_with_lock_in_qty { get; set; }

       [Column("pledged_unconfirmed_qty", Order = 12, TypeName = "float")]
       public long? pledged_unconfirmed_qty { get; set; }

       [Column("confirmed_pledged_with_lock_in_qty", Order = 13, TypeName = "float")]
       public long? confirmed_pledged_with_lock_in_qty { get; set; }

       [Column("remat_qty", Order = 14, TypeName = "float")]
       public long? remat_qty { get; set; }

       [Column("remat_lock_in_qty", Order = 15, TypeName = "float")]
       public long? remat_lock_in_qty { get; set; }

       [Column("cm_idd_qty", Order = 16, TypeName = "float")]
       public long? cm_idd_qty { get; set; }

       [Column("cm_pool_plus_delivery_qty", Order = 17, TypeName = "float")]
       public long? cm_pool_plus_delivery_qty { get; set; }

       [Column("cc_settlement_qty", Order = 18, TypeName = "float")]
       public long? cc_settlement_qty { get; set; }

       [Column("dpid", Order = 19, TypeName = "varchar(16)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 20, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("fstnm", Order = 21, TypeName = "varchar(50)")]
       public string? fstnm { get; set; }

       [Column("sndnm", Order = 22, TypeName = "varchar(50)")]
       public string? sndnm { get; set; }

       [Column("thdnm", Order = 23, TypeName = "varchar(50)")]
       public string? thdnm { get; set; }

       [Column("nomination_name", Order = 24, TypeName = "varchar(50)")]
       public string? nomination_name { get; set; }

       [Column("fname", Order = 25, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 26, TypeName = "float")]
       public long? sta { get; set; }

       [Column("pan_no", Order = 27, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("pan_no_backup", Order = 28, TypeName = "varchar(20)")]
       public string? pan_no_backup { get; set; }

       [Column("ad1", Order = 29, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 30, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("ad3", Order = 31, TypeName = "varchar(50)")]
       public string? ad3 { get; set; }

       [Column("city", Order = 32, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 33, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("country", Order = 34, TypeName = "varchar(50)")]
       public string? country { get; set; }

       [Column("pincode", Order = 35, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("dob", Order = 36, TypeName = "varchar(50)")]
       public string? dob { get; set; }

       [Column("bankdet", Order = 37, TypeName = "varchar(50)")]
       public string? bankdet { get; set; }

       [Column("bank_ac_no", Order = 38, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_name", Order = 39, TypeName = "varchar(50)")]
       public string? bank_name { get; set; }

       [Column("bank_add1", Order = 40, TypeName = "varchar(50)")]
       public string? bank_add1 { get; set; }

       [Column("bank_add2", Order = 41, TypeName = "varchar(50)")]
       public string? bank_add2 { get; set; }

       [Column("bank_add3", Order = 42, TypeName = "varchar(50)")]
       public string? bank_add3 { get; set; }

       [Column("bank_ifsc_code", Order = 43, TypeName = "varchar(50)")]
       public string? bank_ifsc_code { get; set; }

       [Column("bank_micrno", Order = 44, TypeName = "varchar(50)")]
       public string? bank_micrno { get; set; }

       [Column("bank_city", Order = 45, TypeName = "varchar(50)")]
       public string? bank_city { get; set; }

       [Column("bank_pincode", Order = 46, TypeName = "varchar(50)")]
       public string? bank_pincode { get; set; }

       [Column("bank_state", Order = 47, TypeName = "varchar(50)")]
       public string? bank_state { get; set; }

       [Column("bank_country", Order = 48, TypeName = "varchar(50)")]
       public string? bank_country { get; set; }

       [Column("mobno", Order = 49, TypeName = "varchar(100)")]
       public string? mobno { get; set; }

       [Column("emailid", Order = 50, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("block", Order = 51, TypeName = "varchar(1)")]
       public string? block { get; set; }

       [Column("blockreaso", Order = 52, TypeName = "varchar(100)")]
       public string? blockreaso { get; set; }

       [Column("foliono_number", Order = 53, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

       [Column("phy_cdsl_nsdl", Order = 54, TypeName = "varchar(8)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("paid_up_equity", Order = 55, TypeName = "bigint(10)")]
       public long? paid_up_equity { get; set; }

       [Column("total_count", Order = 56, TypeName = "bigint(10)")]
       public long? total_count { get; set; }

       [Column("share_face_value", Order = 57, TypeName = "bigint(10)")]
       public long? share_face_value { get; set; }

       [Column("clinet_holding_amt", Order = 58, TypeName = "float")]
       public long? clinet_holding_amt { get; set; }

       [Column("p_c_comp_name", Order = 59, TypeName = "varchar(43)")]
       public string? p_c_comp_name { get; set; }

       [Column("p_c_comp_isno", Order = 60, TypeName = "varchar(12)")]
       public string? p_c_comp_isno { get; set; }

       [Column("c_comp_name", Order = 61, TypeName = "varchar(1)")]
       public string? c_comp_name { get; set; }

       [Column("c_address", Order = 62, TypeName = "varchar(1)")]
       public string? c_address { get; set; }

       [Column("c_register_add", Order = 63, TypeName = "varchar(1)")]
       public string? c_register_add { get; set; }

       [Column("import_date", Order = 64, TypeName = "varchar(10)")]
       public string? import_date { get; set; }

       [Column("sndnm_panno", Order = 65, TypeName = "varchar(20)")]
       public string? sndnm_panno { get; set; }

       [Column("thdnm_panno", Order = 66, TypeName = "varchar(20)")]
       public string? thdnm_panno { get; set; }

       [Column("non_promoter", Order = 67, TypeName = "varchar(12)")]
       public string? non_promoter { get; set; }

       [Column("cate_1_code", Order = 68, TypeName = "float")]
       public long? cate_1_code { get; set; }

       [Column("cate_2_code", Order = 69, TypeName = "bigint(10)")]
       public long? cate_2_code { get; set; }

       [Column("cate_3_code", Order = 70, TypeName = "bigint(10)")]
       public long? cate_3_code { get; set; }

       [Column("cate_1_found", Order = 71, TypeName = "varchar(12)")]
       public string? cate_1_found { get; set; }

       [Column("cate_2_found", Order = 72, TypeName = "varchar(12)")]
       public string? cate_2_found { get; set; }

       [Column("cate_3_found", Order = 73, TypeName = "varchar(12)")]
       public string? cate_3_found { get; set; }

       [Column("cate_exchange_name", Order = 74, TypeName = "varchar(8)")]
       public string? cate_exchange_name { get; set; }

       [Column("category_header_detail", Order = 75, TypeName = "varchar(50)")]
       public string? category_header_detail { get; set; }

       [Column("category_header", Order = 76, TypeName = "varchar(50)")]
       public string? category_header { get; set; }

       [Column("category_header_discreption", Order = 77, TypeName = "varchar(50)")]
       public string? category_header_discreption { get; set; }

       [Column("page_name_group", Order = 78, TypeName = "varchar(50)")]
       public string? page_name_group { get; set; }

       [Column("main_category_header_index_no", Order = 79, TypeName = "bigint(10)")]
       public long? main_category_header_index_no { get; set; }

       [Column("main_category_header_name", Order = 80, TypeName = "varchar(50)")]
       public string? main_category_header_name { get; set; }

       [Column("sub_categroy_index_no", Order = 81, TypeName = "bigint(10)")]
       public long? sub_categroy_index_no { get; set; }

       [Column("sub_categroy_index_code", Order = 82, TypeName = "varchar(50)")]
       public string? sub_categroy_index_code { get; set; }

       [Column("sub_categroy_name", Order = 83, TypeName = "varchar(50)")]
       public string? sub_categroy_name { get; set; }

       [Column("sub_categroy_index_no_2", Order = 84, TypeName = "float")]
       public long? sub_categroy_index_no_2 { get; set; }

       [Column("sub_categroy_name_2", Order = 85, TypeName = "varchar(50)")]
       public string? sub_categroy_name_2 { get; set; }

       [Column("clinet_details_under_category", Order = 86, TypeName = "varchar(50)")]
       public string? clinet_details_under_category { get; set; }

       [Column("p_pi_pn", Order = 87, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("p_pi_pn_details", Order = 88, TypeName = "varchar(50)")]
       public string? p_pi_pn_details { get; set; }

       [Column("kyc_status", Order = 89, TypeName = "varchar(3)")]
       public string? kyc_status { get; set; }

       [Column("kyc_remark", Order = 90, TypeName = "varchar(50)")]
       public string? kyc_remark { get; set; }

       [Column("holding_rpt_date", Order = 91, TypeName = "varchar(10)")]
       public string? holding_rpt_date { get; set; }

       [Column("more_then_2_lac", Order = 92, TypeName = "varchar(3)")]
       public string? more_then_2_lac { get; set; }

       [Column("more_then_1_perc", Order = 93, TypeName = "varchar(3)")]
       public string? more_then_1_perc { get; set; }

       [Column("share_qty_backup", Order = 94, TypeName = "float")]
       public long? share_qty_backup { get; set; }

       [Column("share_qty_per_backup", Order = 95, TypeName = "float")]
       public long? share_qty_per_backup { get; set; }

       [Column("qty_nsdl_backup", Order = 96, TypeName = "float")]
       public long? qty_nsdl_backup { get; set; }

       [Column("qty_cdsl_backup", Order = 97, TypeName = "float")]
       public long? qty_cdsl_backup { get; set; }

       [Column("qty_phy_backup", Order = 98, TypeName = "float")]
       public long? qty_phy_backup { get; set; }

       [Column("other_then_free_backup", Order = 99, TypeName = "float")]
       public long? other_then_free_backup { get; set; }

       [Column("lockin_qty_benlock_backup", Order = 100, TypeName = "float")]
       public long? lockin_qty_benlock_backup { get; set; }

       [Column("lockin_qty_benplg_backup", Order = 101, TypeName = "float")]
       public long? lockin_qty_benplg_backup { get; set; }

       [Column("clinet_holding_amt_backup", Order = 102, TypeName = "float")]
       public long? clinet_holding_amt_backup { get; set; }

       [Column("clinet_category_group_name", Order = 103, TypeName = "varchar(50)")]
       public string? clinet_category_group_name { get; set; }

       [Column("clinet_group_sno", Order = 104, TypeName = "float")]
       public long? clinet_group_sno { get; set; }

       [Column("rpt_auto_id", Order = 105, TypeName = "bigint(10)")]
       public long? rpt_auto_id { get; set; }

   }
}
