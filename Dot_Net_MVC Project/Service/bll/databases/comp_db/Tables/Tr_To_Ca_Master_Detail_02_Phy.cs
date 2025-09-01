using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("tr_to_ca_master_detail_02_phy")] 
       
   public class Tr_To_Ca_Master_Detail_02_Phy
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("trx_id_02", Order = 2, TypeName = "bigint(10)")]
       public long? trx_id_02 { get; set; }

       [Column("trfno", Order = 3, TypeName = "float")]
       public long? trfno { get; set; }

       [Column("detail_sno", Order = 4, TypeName = "float")]
       public long? detail_sno { get; set; }

       [Column("foliono", Order = 5, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("names", Order = 6, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("middle_names", Order = 7, TypeName = "varchar(50)")]
       public string? middle_names { get; set; }

       [Column("sur_names", Order = 8, TypeName = "varchar(50)")]
       public string? sur_names { get; set; }

       [Column("foliono_share_qty", Order = 9, TypeName = "float")]
       public long? foliono_share_qty { get; set; }

       [Column("panno1", Order = 10, TypeName = "varchar(20)")]
       public string? panno1 { get; set; }

       [Column("names_2", Order = 11, TypeName = "varchar(50)")]
       public string? names_2 { get; set; }

       [Column("panno2", Order = 12, TypeName = "varchar(20)")]
       public string? panno2 { get; set; }

       [Column("names_3", Order = 13, TypeName = "varchar(50)")]
       public string? names_3 { get; set; }

       [Column("panno3", Order = 14, TypeName = "varchar(20)")]
       public string? panno3 { get; set; }

       [Column("dob", Order = 15, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("male_female", Order = 16, TypeName = "varchar(50)")]
       public string? male_female { get; set; }

       [Column("fname", Order = 17, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 18, TypeName = "float")]
       public long? sta { get; set; }

       [Column("ad1", Order = 19, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 20, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 21, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 22, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("stcode", Order = 23, TypeName = "varchar(50)")]
       public string? stcode { get; set; }

       [Column("pincode", Order = 24, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("country_name", Order = 25, TypeName = "varchar(50)")]
       public string? country_name { get; set; }

       [Column("emailid", Order = 26, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("phone", Order = 27, TypeName = "varchar(100)")]
       public string? phone { get; set; }

       [Column("n_name", Order = 28, TypeName = "varchar(50)")]
       public string? n_name { get; set; }

       [Column("n_pan", Order = 29, TypeName = "varchar(20)")]
       public string? n_pan { get; set; }

       [Column("n_relation", Order = 30, TypeName = "varchar(50)")]
       public string? n_relation { get; set; }

       [Column("n_f_m_w_name", Order = 31, TypeName = "varchar(50)")]
       public string? n_f_m_w_name { get; set; }

       [Column("n_m_f", Order = 32, TypeName = "varchar(50)")]
       public string? n_m_f { get; set; }

       [Column("n_dob", Order = 33, TypeName = "varchar(50)")]
       public string? n_dob { get; set; }

       [Column("n_phone", Order = 34, TypeName = "varchar(50)")]
       public string? n_phone { get; set; }

       [Column("n_add2", Order = 35, TypeName = "varchar(50)")]
       public string? n_add2 { get; set; }

       [Column("n_add1", Order = 36, TypeName = "varchar(50)")]
       public string? n_add1 { get; set; }

       [Column("n_city", Order = 37, TypeName = "varchar(50)")]
       public string? n_city { get; set; }

       [Column("n_pincode", Order = 38, TypeName = "varchar(50)")]
       public string? n_pincode { get; set; }

       [Column("n_state", Order = 39, TypeName = "varchar(50)")]
       public string? n_state { get; set; }

       [Column("n_country", Order = 40, TypeName = "varchar(50)")]
       public string? n_country { get; set; }

       [Column("n_email", Order = 41, TypeName = "varchar(50)")]
       public string? n_email { get; set; }

       [Column("bank_ac_no", Order = 42, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_name", Order = 43, TypeName = "varchar(50)")]
       public string? bank_name { get; set; }

       [Column("bank_add1", Order = 44, TypeName = "varchar(50)")]
       public string? bank_add1 { get; set; }

       [Column("bank_add2", Order = 45, TypeName = "varchar(50)")]
       public string? bank_add2 { get; set; }

       [Column("bank_add3", Order = 46, TypeName = "varchar(50)")]
       public string? bank_add3 { get; set; }

       [Column("bank_ifsc_code", Order = 47, TypeName = "varchar(50)")]
       public string? bank_ifsc_code { get; set; }

       [Column("bank_micrno", Order = 48, TypeName = "varchar(50)")]
       public string? bank_micrno { get; set; }

       [Column("bank_city", Order = 49, TypeName = "varchar(50)")]
       public string? bank_city { get; set; }

       [Column("bank_pincode", Order = 50, TypeName = "varchar(50)")]
       public string? bank_pincode { get; set; }

       [Column("bank_state", Order = 51, TypeName = "varchar(50)")]
       public string? bank_state { get; set; }

       [Column("bank_country", Order = 52, TypeName = "varchar(50)")]
       public string? bank_country { get; set; }

       [Column("adhaar_no", Order = 53, TypeName = "varchar(250)")]
       public string? adhaar_no { get; set; }

       [Column("voter_id", Order = 54, TypeName = "varchar(250)")]
       public string? voter_id { get; set; }

       [Column("dl_no", Order = 55, TypeName = "varchar(250)")]
       public string? dl_no { get; set; }

       [Column("passport_no", Order = 56, TypeName = "varchar(250)")]
       public string? passport_no { get; set; }

       [Column("occupation_det", Order = 57, TypeName = "varchar(50)")]
       public string? occupation_det { get; set; }

       [Column("power_attorney_exist_yn", Order = 58, TypeName = "varchar(50)")]
       public string? power_attorney_exist_yn { get; set; }

   }
}
