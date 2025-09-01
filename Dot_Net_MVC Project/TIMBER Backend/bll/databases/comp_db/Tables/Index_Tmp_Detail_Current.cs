using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("index_tmp_detail_current")] 
       
   public class Index_Tmp_Detail_Current
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("status_as_on", Order = 3, TypeName = "varchar(50)")]
       public string? status_as_on { get; set; }

       [Column("folio_verify_by_certi_dist", Order = 4, TypeName = "varchar(50)")]
       public string? folio_verify_by_certi_dist { get; set; }

       [Column("verify_by_certi_dist", Order = 5, TypeName = "varchar(50)")]
       public string? verify_by_certi_dist { get; set; }

       [Column("verify_only_by_certi", Order = 6, TypeName = "varchar(50)")]
       public string? verify_only_by_certi { get; set; }

       [Column("verify_only_by_dist", Order = 7, TypeName = "varchar(50)")]
       public string? verify_only_by_dist { get; set; }

       [Column("record_status", Order = 8, TypeName = "varchar(50)")]
       public string? record_status { get; set; }

       [Column("record_status_current", Order = 9, TypeName = "varchar(50)")]
       public string? record_status_current { get; set; }

       [Column("certi_no_from", Order = 10, TypeName = "varchar(50)")]
       public string? certi_no_from { get; set; }

       [Column("certi_no_upto", Order = 11, TypeName = "varchar(50)")]
       public string? certi_no_upto { get; set; }

       [Column("dist_no_from", Order = 12, TypeName = "float")]
       public long? dist_no_from { get; set; }

       [Column("dist_no_upto", Order = 13, TypeName = "float")]
       public long? dist_no_upto { get; set; }

       [Column("dpid", Order = 14, TypeName = "varchar(16)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 15, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("trfno", Order = 16, TypeName = "varchar(50)")]
       public string? trfno { get; set; }

       [Column("trfdate", Order = 17, TypeName = "varchar(50)")]
       public string? trfdate { get; set; }

       [Column("vou_type", Order = 18, TypeName = "varchar(50)")]
       public string? vou_type { get; set; }

       [Column("derno_rrno", Order = 19, TypeName = "varchar(50)")]
       public string? derno_rrno { get; set; }

       [Column("derno", Order = 20, TypeName = "varchar(50)")]
       public string? derno { get; set; }

       [Column("dpidno", Order = 21, TypeName = "varchar(50)")]
       public string? dpidno { get; set; }

       [Column("clinid", Order = 22, TypeName = "varchar(50)")]
       public string? clinid { get; set; }

       [Column("fstnm", Order = 23, TypeName = "varchar(50)")]
       public string? fstnm { get; set; }

       [Column("sndnm", Order = 24, TypeName = "varchar(50)")]
       public string? sndnm { get; set; }

       [Column("thdnm", Order = 25, TypeName = "varchar(50)")]
       public string? thdnm { get; set; }

       [Column("fname", Order = 26, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 27, TypeName = "float")]
       public long? sta { get; set; }

       [Column("pan_no", Order = 28, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

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

       [Column("cate_1_code", Order = 56, TypeName = "float")]
       public long? cate_1_code { get; set; }

       [Column("cate_2_code", Order = 57, TypeName = "bigint(10)")]
       public long? cate_2_code { get; set; }

       [Column("cate_3_code", Order = 58, TypeName = "bigint(10)")]
       public long? cate_3_code { get; set; }

       [Column("category_header_detail", Order = 59, TypeName = "varchar(50)")]
       public string? category_header_detail { get; set; }

       [Column("category_header", Order = 60, TypeName = "varchar(50)")]
       public string? category_header { get; set; }

       [Column("total_count", Order = 61, TypeName = "bigint(10)")]
       public long? total_count { get; set; }

       [Column("p_pi_pn", Order = 62, TypeName = "varchar(2)")]
       public string? p_pi_pn { get; set; }

       [Column("non_promoter", Order = 63, TypeName = "varchar(12)")]
       public string? non_promoter { get; set; }

       [Column("p_c_comp_name", Order = 64, TypeName = "varchar(43)")]
       public string? p_c_comp_name { get; set; }

       [Column("p_c_comp_isno", Order = 65, TypeName = "varchar(12)")]
       public string? p_c_comp_isno { get; set; }

       [Column("c_comp_name", Order = 66, TypeName = "varchar(1)")]
       public string? c_comp_name { get; set; }

       [Column("c_address", Order = 67, TypeName = "varchar(1)")]
       public string? c_address { get; set; }

       [Column("c_register_add", Order = 68, TypeName = "varchar(1)")]
       public string? c_register_add { get; set; }

       [Column("import_date", Order = 69, TypeName = "varchar(10)")]
       public string? import_date { get; set; }

       [Column("sndnm_panno", Order = 70, TypeName = "varchar(20)")]
       public string? sndnm_panno { get; set; }

       [Column("thdnm_panno", Order = 71, TypeName = "varchar(20)")]
       public string? thdnm_panno { get; set; }

       [Column("record_auto_id", Order = 72, TypeName = "bigint(10)")]
       public long? record_auto_id { get; set; }

   }
}
