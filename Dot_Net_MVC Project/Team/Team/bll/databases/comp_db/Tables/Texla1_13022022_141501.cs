using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla1_13022022_141501")] 
       
   public class Texla1_13022022_141501
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("comp_name", Order = 2, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 3, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

       [Column("comp_sno", Order = 4, TypeName = "varchar(100)")]
       public string? comp_sno { get; set; }

       [Column("comp_isin", Order = 5, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("foliono_auto_id", Order = 6, TypeName = "bigint(10)")]
       public long? foliono_auto_id { get; set; }

       [Column("foliono_number", Order = 7, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

       [Column("foliono", Order = 8, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("folio_id", Order = 9, TypeName = "varchar(16)")]
       public string? folio_id { get; set; }

       [Column("old_folio_no_id", Order = 10, TypeName = "varchar(16)")]
       public string? old_folio_no_id { get; set; }

       [Column("foliono_share_qty", Order = 11, TypeName = "double(18,3)")]
       public long? foliono_share_qty { get; set; }

       [Column("names", Order = 12, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("middle_names", Order = 13, TypeName = "varchar(50)")]
       public string? middle_names { get; set; }

       [Column("sur_names", Order = 14, TypeName = "varchar(50)")]
       public string? sur_names { get; set; }

       [Column("panno1", Order = 15, TypeName = "varchar(20)")]
       public string? panno1 { get; set; }

       [Column("nsdl_id_1", Order = 16, TypeName = "varchar(8)")]
       public string? nsdl_id_1 { get; set; }

       [Column("nsdl_id_2", Order = 17, TypeName = "varchar(8)")]
       public string? nsdl_id_2 { get; set; }

       [Column("cl_id", Order = 18, TypeName = "varchar(8)")]
       public string? cl_id { get; set; }

       [Column("dp_id_1", Order = 19, TypeName = "varchar(8)")]
       public string? dp_id_1 { get; set; }

       [Column("names_2", Order = 20, TypeName = "varchar(50)")]
       public string? names_2 { get; set; }

       [Column("panno2", Order = 21, TypeName = "varchar(20)")]
       public string? panno2 { get; set; }

       [Column("names_3", Order = 22, TypeName = "varchar(50)")]
       public string? names_3 { get; set; }

       [Column("panno3", Order = 23, TypeName = "varchar(20)")]
       public string? panno3 { get; set; }

       [Column("dob", Order = 24, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("male_female", Order = 25, TypeName = "varchar(50)")]
       public string? male_female { get; set; }

       [Column("fname", Order = 26, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 27, TypeName = "float")]
       public long? sta { get; set; }

       [Column("dactive", Order = 28, TypeName = "varchar(30)")]
       public string? dactive { get; set; }

       [Column("taxcode", Order = 29, TypeName = "varchar(30)")]
       public string? taxcode { get; set; }

       [Column("adr", Order = 30, TypeName = "varchar(50)")]
       public string? adr { get; set; }

       [Column("ad1", Order = 31, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 32, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 33, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 34, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("stcode", Order = 35, TypeName = "varchar(50)")]
       public string? stcode { get; set; }

       [Column("pincode", Order = 36, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("country_name", Order = 37, TypeName = "varchar(50)")]
       public string? country_name { get; set; }

       [Column("rgcode", Order = 38, TypeName = "varchar(50)")]
       public string? rgcode { get; set; }

       [Column("nflcr", Order = 39, TypeName = "varchar(100)")]
       public string? nflcr { get; set; }

       [Column("emailid", Order = 40, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("phone", Order = 41, TypeName = "varchar(100)")]
       public string? phone { get; set; }

       [Column("n_name", Order = 42, TypeName = "varchar(50)")]
       public string? n_name { get; set; }

       [Column("n_pan", Order = 43, TypeName = "varchar(20)")]
       public string? n_pan { get; set; }

       [Column("n_relation", Order = 44, TypeName = "varchar(50)")]
       public string? n_relation { get; set; }

       [Column("n_f_m_w_name", Order = 45, TypeName = "varchar(50)")]
       public string? n_f_m_w_name { get; set; }

       [Column("n_m_f", Order = 46, TypeName = "varchar(50)")]
       public string? n_m_f { get; set; }

       [Column("n_nsdl_id_1", Order = 47, TypeName = "varchar(8)")]
       public string? n_nsdl_id_1 { get; set; }

       [Column("n_nsdl_id_2", Order = 48, TypeName = "varchar(8)")]
       public string? n_nsdl_id_2 { get; set; }

       [Column("n_cdsl_id_1", Order = 49, TypeName = "varchar(8)")]
       public string? n_cdsl_id_1 { get; set; }

       [Column("n_cl_id", Order = 50, TypeName = "varchar(8)")]
       public string? n_cl_id { get; set; }

       [Column("n_dob", Order = 51, TypeName = "varchar(50)")]
       public string? n_dob { get; set; }

       [Column("n_phone", Order = 52, TypeName = "varchar(50)")]
       public string? n_phone { get; set; }

       [Column("n_add2", Order = 53, TypeName = "varchar(50)")]
       public string? n_add2 { get; set; }

       [Column("n_add1", Order = 54, TypeName = "varchar(50)")]
       public string? n_add1 { get; set; }

       [Column("n_city", Order = 55, TypeName = "varchar(50)")]
       public string? n_city { get; set; }

       [Column("n_pincode", Order = 56, TypeName = "varchar(50)")]
       public string? n_pincode { get; set; }

       [Column("n_state", Order = 57, TypeName = "varchar(50)")]
       public string? n_state { get; set; }

       [Column("n_country", Order = 58, TypeName = "varchar(50)")]
       public string? n_country { get; set; }

       [Column("n_email", Order = 59, TypeName = "varchar(50)")]
       public string? n_email { get; set; }

       [Column("bank_ac_no", Order = 60, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_name", Order = 61, TypeName = "varchar(50)")]
       public string? bank_name { get; set; }

       [Column("bank_add1", Order = 62, TypeName = "varchar(50)")]
       public string? bank_add1 { get; set; }

       [Column("bank_add2", Order = 63, TypeName = "varchar(50)")]
       public string? bank_add2 { get; set; }

       [Column("bank_add3", Order = 64, TypeName = "varchar(50)")]
       public string? bank_add3 { get; set; }

       [Column("bank_ifsc_code", Order = 65, TypeName = "varchar(50)")]
       public string? bank_ifsc_code { get; set; }

       [Column("bank_micrno", Order = 66, TypeName = "varchar(50)")]
       public string? bank_micrno { get; set; }

       [Column("bank_city", Order = 67, TypeName = "varchar(50)")]
       public string? bank_city { get; set; }

       [Column("bank_pincode", Order = 68, TypeName = "varchar(50)")]
       public string? bank_pincode { get; set; }

       [Column("bank_state", Order = 69, TypeName = "varchar(50)")]
       public string? bank_state { get; set; }

       [Column("bank_country", Order = 70, TypeName = "varchar(50)")]
       public string? bank_country { get; set; }

       [Column("entey_date", Order = 71, TypeName = "datetime")]
       public DateTime? entey_date { get; set; }

       [Column("after_sebi_notice_1_yn", Order = 72, TypeName = "varchar(1)")]
       public string? after_sebi_notice_1_yn { get; set; }

       [Column("after_sebi_notice_2_yn", Order = 73, TypeName = "varchar(1)")]
       public string? after_sebi_notice_2_yn { get; set; }

       [Column("after_sebi_notice_3_yn", Order = 74, TypeName = "varchar(1)")]
       public string? after_sebi_notice_3_yn { get; set; }

       [Column("sebi_notice_1_remark", Order = 75, TypeName = "varchar(50)")]
       public string? sebi_notice_1_remark { get; set; }

       [Column("sebi_notice_2_remark", Order = 76, TypeName = "varchar(50)")]
       public string? sebi_notice_2_remark { get; set; }

       [Column("sebi_notice_3_remark", Order = 77, TypeName = "varchar(50)")]
       public string? sebi_notice_3_remark { get; set; }

       [Column("adhaar_no", Order = 78, TypeName = "varchar(250)")]
       public string? adhaar_no { get; set; }

       [Column("adhaar_no_rem", Order = 79, TypeName = "varchar(250)")]
       public string? adhaar_no_rem { get; set; }

       [Column("voter_id", Order = 80, TypeName = "varchar(250)")]
       public string? voter_id { get; set; }

       [Column("voter_id_rem", Order = 81, TypeName = "varchar(250)")]
       public string? voter_id_rem { get; set; }

       [Column("dl_no", Order = 82, TypeName = "varchar(250)")]
       public string? dl_no { get; set; }

       [Column("dl_no_rem", Order = 83, TypeName = "varchar(250)")]
       public string? dl_no_rem { get; set; }

       [Column("passport_no", Order = 84, TypeName = "varchar(250)")]
       public string? passport_no { get; set; }

       [Column("passport_no_rem", Order = 85, TypeName = "varchar(250)")]
       public string? passport_no_rem { get; set; }

       [Column("other_remark", Order = 86, TypeName = "varchar(250)")]
       public string? other_remark { get; set; }

       [Column("other_remark_rem", Order = 87, TypeName = "varchar(250)")]
       public string? other_remark_rem { get; set; }

       [Column("occupation_det", Order = 88, TypeName = "varchar(50)")]
       public string? occupation_det { get; set; }

   }
}
