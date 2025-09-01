using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla1_tmp_e_vote_cdsl")] 
       
   public class Texla1_Tmp_E_Vote_Cdsl
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

       [Column("sta", Order = 6, TypeName = "float")]
       public long? sta { get; set; }

       [Column("panno1", Order = 7, TypeName = "varchar(20)")]
       public string? panno1 { get; set; }

       [Column("ad1", Order = 8, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 9, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 10, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 11, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("country_name", Order = 12, TypeName = "varchar(50)")]
       public string? country_name { get; set; }

       [Column("pincode", Order = 13, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("dob", Order = 14, TypeName = "datetime")]
       public DateTime? dob { get; set; }

       [Column("bank_ac_no", Order = 15, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("phone", Order = 16, TypeName = "varchar(100)")]
       public string? phone { get; set; }

       [Column("emailid", Order = 17, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("foliono_number", Order = 18, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

   }
}
