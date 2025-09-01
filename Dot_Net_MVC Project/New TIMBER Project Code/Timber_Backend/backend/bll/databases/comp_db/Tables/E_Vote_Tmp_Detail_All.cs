using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("e_vote_tmp_detail_all")] 
       
   public class E_Vote_Tmp_Detail_All
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("share_qty_per", Order = 3, TypeName = "float")]
       public long? share_qty_per { get; set; }

       [Column("dpid", Order = 4, TypeName = "varchar(16)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 5, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("fstnm", Order = 6, TypeName = "varchar(50)")]
       public string? fstnm { get; set; }

       [Column("sndnm", Order = 7, TypeName = "varchar(50)")]
       public string? sndnm { get; set; }

       [Column("thdnm", Order = 8, TypeName = "varchar(50)")]
       public string? thdnm { get; set; }

       [Column("fname", Order = 9, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 10, TypeName = "float")]
       public long? sta { get; set; }

       [Column("pan_no", Order = 11, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("ad1", Order = 12, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 13, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("ad3", Order = 14, TypeName = "varchar(50)")]
       public string? ad3 { get; set; }

       [Column("city", Order = 15, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 16, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("country", Order = 17, TypeName = "varchar(50)")]
       public string? country { get; set; }

       [Column("pincode", Order = 18, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("dob", Order = 19, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("bankdet", Order = 20, TypeName = "varchar(50)")]
       public string? bankdet { get; set; }

       [Column("mobno", Order = 21, TypeName = "varchar(100)")]
       public string? mobno { get; set; }

       [Column("emailid", Order = 22, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("block", Order = 23, TypeName = "varchar(1)")]
       public string? block { get; set; }

       [Column("blockreaso", Order = 24, TypeName = "varchar(1)")]
       public string? blockreaso { get; set; }

       [Column("foliono_number", Order = 25, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

       [Column("phy_cdsl_nsdl", Order = 26, TypeName = "varchar(8)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("paid_up_capital", Order = 27, TypeName = "bigint(10)")]
       public long? paid_up_capital { get; set; }

       [Column("cate_1_code", Order = 28, TypeName = "float")]
       public long? cate_1_code { get; set; }

       [Column("cate_2_code", Order = 29, TypeName = "bigint(10)")]
       public long? cate_2_code { get; set; }

       [Column("cate_3_code", Order = 30, TypeName = "bigint(10)")]
       public long? cate_3_code { get; set; }

       [Column("soft_uniq_types", Order = 31, TypeName = "varchar(50)")]
       public string? soft_uniq_types { get; set; }

       [Column("soft_uniq_code", Order = 32, TypeName = "bigint(10)")]
       public long? soft_uniq_code { get; set; }

       [Column("total_count", Order = 33, TypeName = "bigint(10)")]
       public long? total_count { get; set; }

       [Column("p_pi_pn", Order = 34, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("p_c_comp_name", Order = 35, TypeName = "varchar(50)")]
       public string? p_c_comp_name { get; set; }

       [Column("p_c_comp_isno", Order = 36, TypeName = "varchar(12)")]
       public string? p_c_comp_isno { get; set; }

   }
}
