using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("comp_name")] 
       
   public class Comp_Name
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("comp_name_auto_id", Order = 2, TypeName = "bigint(10)")]
       public long? comp_name_auto_id { get; set; }

       [Column("compno", Order = 3, TypeName = "float")]
       public long? compno { get; set; }

       [Column("compaddress", Order = 4, TypeName = "varchar(50)")]
       public string? compaddress { get; set; }

       [Column("compname", Order = 5, TypeName = "varchar(50)")]
       public string? compname { get; set; }

       [Column("c_email", Order = 6, TypeName = "varchar(50)")]
       public string? c_email { get; set; }

       [Column("c_website", Order = 7, TypeName = "varchar(50)")]
       public string? c_website { get; set; }

       [Column("c_phones", Order = 8, TypeName = "varchar(50)")]
       public string? c_phones { get; set; }

       [Column("c_contact_person", Order = 9, TypeName = "varchar(50)")]
       public string? c_contact_person { get; set; }

       [Column("c_owner_name", Order = 10, TypeName = "varchar(50)")]
       public string? c_owner_name { get; set; }

       [Column("gstin", Order = 11, TypeName = "varchar(50)")]
       public string? gstin { get; set; }

       [Column("bank_name", Order = 12, TypeName = "varchar(50)")]
       public string? bank_name { get; set; }

       [Column("bank_ac_no", Order = 13, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_ifsc", Order = 14, TypeName = "varchar(50)")]
       public string? bank_ifsc { get; set; }

       [Column("comp_address_2", Order = 15, TypeName = "varchar(100)")]
       public string? comp_address_2 { get; set; }

       [Column("comp_address_3", Order = 16, TypeName = "varchar(100)")]
       public string? comp_address_3 { get; set; }

       [Column("comp_address_4", Order = 17, TypeName = "varchar(100)")]
       public string? comp_address_4 { get; set; }

       [Column("comp_state_code", Order = 18, TypeName = "varchar(100)")]
       public string? comp_state_code { get; set; }

       [Column("comp_state_name", Order = 19, TypeName = "varchar(100)")]
       public string? comp_state_name { get; set; }

       [Column("rta_company_name", Order = 20, TypeName = "varchar(100)")]
       public string? rta_company_name { get; set; }

       [Column("rta_company_short", Order = 21, TypeName = "varchar(100)")]
       public string? rta_company_short { get; set; }

       [Column("type_of_security", Order = 22, TypeName = "varchar(250)")]
       public string? type_of_security { get; set; }

       [Column("amt_per_share", Order = 23, TypeName = "varchar(250)")]
       public string? amt_per_share { get; set; }

       [Column("comp_sno", Order = 24, TypeName = "float")]
       public long? comp_sno { get; set; }

       [Column("comp_isin", Order = 25, TypeName = "varchar(50)")]
       public string? comp_isin { get; set; }

       [Column("comp_name", Order = 26, TypeName = "varchar(50)")]
       public string? comp_name { get; set; }

       [Column("comp_name_short", Order = 27, TypeName = "varchar(50)")]
       public string? comp_name_short { get; set; }

   }
}
