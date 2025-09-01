using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("index_tmp_promoter_list")] 
       
   public class Index_Tmp_Promoter_List
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("share_qty_per", Order = 3, TypeName = "float")]
       public long? share_qty_per { get; set; }

       [Column("share_lockin_qty", Order = 4, TypeName = "bigint(10)")]
       public long? share_lockin_qty { get; set; }

       [Column("ben_positi", Order = 5, TypeName = "float")]
       public long? ben_positi { get; set; }

       [Column("benlock", Order = 6, TypeName = "bigint(10)")]
       public long? benlock { get; set; }

       [Column("benblk", Order = 7, TypeName = "bigint(10)")]
       public long? benblk { get; set; }

       [Column("benplg", Order = 8, TypeName = "bigint(10)")]
       public long? benplg { get; set; }

       [Column("benplglk", Order = 9, TypeName = "bigint(10)")]
       public long? benplglk { get; set; }

       [Column("benplgun", Order = 10, TypeName = "bigint(10)")]
       public long? benplgun { get; set; }

       [Column("benplgcloc", Order = 11, TypeName = "bigint(10)")]
       public long? benplgcloc { get; set; }

       [Column("benrem", Order = 12, TypeName = "bigint(10)")]
       public long? benrem { get; set; }

       [Column("benremloc", Order = 13, TypeName = "bigint(10)")]
       public long? benremloc { get; set; }

       [Column("bencmidpos", Order = 14, TypeName = "bigint(10)")]
       public long? bencmidpos { get; set; }

       [Column("cmpool", Order = 15, TypeName = "bigint(10)")]
       public long? cmpool { get; set; }

       [Column("dpid", Order = 16, TypeName = "varchar(8)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 17, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("fstnm", Order = 18, TypeName = "varchar(50)")]
       public string? fstnm { get; set; }

       [Column("sndnm", Order = 19, TypeName = "varchar(50)")]
       public string? sndnm { get; set; }

       [Column("thdnm", Order = 20, TypeName = "varchar(50)")]
       public string? thdnm { get; set; }

       [Column("fname", Order = 21, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 22, TypeName = "bigint(10)")]
       public long? sta { get; set; }

       [Column("pan_no", Order = 23, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("ad1", Order = 24, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 25, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("ad3", Order = 26, TypeName = "varchar(50)")]
       public string? ad3 { get; set; }

       [Column("city", Order = 27, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 28, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("country", Order = 29, TypeName = "varchar(50)")]
       public string? country { get; set; }

       [Column("pincode", Order = 30, TypeName = "varchar(10)")]
       public string? pincode { get; set; }

       [Column("dob", Order = 31, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("bankdet", Order = 32, TypeName = "varchar(50)")]
       public string? bankdet { get; set; }

       [Column("mobno", Order = 33, TypeName = "varchar(50)")]
       public string? mobno { get; set; }

       [Column("emailid", Order = 34, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("block", Order = 35, TypeName = "varchar(1)")]
       public string? block { get; set; }

       [Column("blockreaso", Order = 36, TypeName = "varchar(1)")]
       public string? blockreaso { get; set; }

       [Column("foliono_number", Order = 37, TypeName = "float")]
       public long? foliono_number { get; set; }

       [Column("phy_cdsl_nsdl", Order = 38, TypeName = "varchar(4)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("paid_up_capital", Order = 39, TypeName = "bigint(10)")]
       public long? paid_up_capital { get; set; }

       [Column("cate_1_code", Order = 40, TypeName = "bigint(10)")]
       public long? cate_1_code { get; set; }

       [Column("cate_2_code", Order = 41, TypeName = "bigint(10)")]
       public long? cate_2_code { get; set; }

       [Column("cate_3_code", Order = 42, TypeName = "bigint(10)")]
       public long? cate_3_code { get; set; }

       [Column("soft_uniq_types", Order = 43, TypeName = "varchar(50)")]
       public string? soft_uniq_types { get; set; }

       [Column("soft_uniq_code", Order = 44, TypeName = "bigint(10)")]
       public long? soft_uniq_code { get; set; }

       [Column("total_count", Order = 45, TypeName = "bigint(10)")]
       public long? total_count { get; set; }

       [Column("p_pi_pn", Order = 46, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("non_promoter", Order = 47, TypeName = "varchar(12)")]
       public string? non_promoter { get; set; }

       [Column("p_c_comp_name", Order = 48, TypeName = "varchar(50)")]
       public string? p_c_comp_name { get; set; }

       [Column("p_c_comp_isno", Order = 49, TypeName = "varchar(50)")]
       public string? p_c_comp_isno { get; set; }

       [Column("c_comp_name", Order = 50, TypeName = "varchar(50)")]
       public string? c_comp_name { get; set; }

       [Column("c_address", Order = 51, TypeName = "varchar(50)")]
       public string? c_address { get; set; }

       [Column("c_register_add", Order = 52, TypeName = "varchar(50)")]
       public string? c_register_add { get; set; }

       [Column("comp_sno", Order = 53, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 54, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 55, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 56, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

   }
}
