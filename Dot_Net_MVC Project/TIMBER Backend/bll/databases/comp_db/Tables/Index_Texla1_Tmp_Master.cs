using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("index_texla1_tmp_master")] 
       
   public class Index_Texla1_Tmp_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("foliono", Order = 2, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("names", Order = 3, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("names_2", Order = 4, TypeName = "varchar(50)")]
       public string? names_2 { get; set; }

       [Column("names_3", Order = 5, TypeName = "varchar(50)")]
       public string? names_3 { get; set; }

       [Column("nomination_name", Order = 6, TypeName = "varchar(50)")]
       public string? nomination_name { get; set; }

       [Column("fname", Order = 7, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 8, TypeName = "float")]
       public long? sta { get; set; }

       [Column("panno1", Order = 9, TypeName = "varchar(20)")]
       public string? panno1 { get; set; }

       [Column("ad1", Order = 10, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 11, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 12, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 13, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("country_name", Order = 14, TypeName = "varchar(50)")]
       public string? country_name { get; set; }

       [Column("pincode", Order = 15, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("dob", Order = 16, TypeName = "varchar(50)")]
       public string? dob { get; set; }

       [Column("bank_ac_no", Order = 17, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_name", Order = 18, TypeName = "varchar(50)")]
       public string? bank_name { get; set; }

       [Column("bank_add1", Order = 19, TypeName = "varchar(50)")]
       public string? bank_add1 { get; set; }

       [Column("bank_add2", Order = 20, TypeName = "varchar(50)")]
       public string? bank_add2 { get; set; }

       [Column("bank_add3", Order = 21, TypeName = "varchar(50)")]
       public string? bank_add3 { get; set; }

       [Column("bank_ifsc_code", Order = 22, TypeName = "varchar(50)")]
       public string? bank_ifsc_code { get; set; }

       [Column("bank_micrno", Order = 23, TypeName = "varchar(50)")]
       public string? bank_micrno { get; set; }

       [Column("bank_city", Order = 24, TypeName = "varchar(50)")]
       public string? bank_city { get; set; }

       [Column("bank_pincode", Order = 25, TypeName = "varchar(50)")]
       public string? bank_pincode { get; set; }

       [Column("bank_state", Order = 26, TypeName = "varchar(50)")]
       public string? bank_state { get; set; }

       [Column("bank_country", Order = 27, TypeName = "varchar(50)")]
       public string? bank_country { get; set; }

       [Column("phone", Order = 28, TypeName = "varchar(100)")]
       public string? phone { get; set; }

       [Column("emailid", Order = 29, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("foliono_number", Order = 30, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

       [Column("male_female", Order = 31, TypeName = "varchar(50)")]
       public string? male_female { get; set; }

       [Column("panno2", Order = 32, TypeName = "varchar(20)")]
       public string? panno2 { get; set; }

       [Column("panno3", Order = 33, TypeName = "varchar(20)")]
       public string? panno3 { get; set; }

   }
}
