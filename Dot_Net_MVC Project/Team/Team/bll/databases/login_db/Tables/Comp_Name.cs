using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.Login.Tables
{
public class Comp_Name
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("compno", Order = 2, TypeName = "float")]
       public long? compno { get; set; }

       [Column("compaddress", Order = 3, TypeName = "text")]
       public string? compaddress { get; set; }

       [Column("compname", Order = 4, TypeName = "text")]
       public string? compname { get; set; }

       [Column("c_email", Order = 5, TypeName = "text")]
       public string? c_email { get; set; }

       [Column("c_website", Order = 6, TypeName = "text")]
       public string? c_website { get; set; }

       [Column("c_phones", Order = 7, TypeName = "text")]
       public string? c_phones { get; set; }

       [Column("c_contact_person", Order = 8, TypeName = "text")]
       public string? c_contact_person { get; set; }

       [Column("c_owner_name", Order = 9, TypeName = "text")]
       public string? c_owner_name { get; set; }

       [Column("gstin", Order = 10, TypeName = "varchar(50)")]
       public string? gstin { get; set; }

       [Column("bank_name", Order = 11, TypeName = "varchar(50)")]
       public string? bank_name { get; set; }

       [Column("bank_ac_no", Order = 12, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_ifsc", Order = 13, TypeName = "varchar(50)")]
       public string? bank_ifsc { get; set; }

       [Column("comp_address_2", Order = 14, TypeName = "varchar(100)")]
       public string? comp_address_2 { get; set; }

       [Column("comp_address_3", Order = 15, TypeName = "varchar(100)")]
       public string? comp_address_3 { get; set; }

       [Column("comp_address_4", Order = 16, TypeName = "varchar(100)")]
       public string? comp_address_4 { get; set; }

       [Column("comp_state_code", Order = 17, TypeName = "varchar(100)")]
       public string? comp_state_code { get; set; }

       [Column("comp_state_name", Order = 18, TypeName = "varchar(100)")]
       public string? comp_state_name { get; set; }

       [Column("rta_company_pcode", Order = 19, TypeName = "float")]
       public long? rta_company_pcode { get; set; }

       [Column("rta_company_name", Order = 20, TypeName = "text")]
       public string? rta_company_name { get; set; }

       [Column("rta_company_short", Order = 21, TypeName = "text")]
       public string? rta_company_short { get; set; }

       [Column("rta_isin", Order = 22, TypeName = "text")]
       public string? rta_isin { get; set; }

       [Column("rta_upload_id", Order = 23, TypeName = "text")]
       public string? rta_upload_id { get; set; }

       [Column("rta_operator_id", Order = 24, TypeName = "text")]
       public string? rta_operator_id { get; set; }

       [Column("rta_type_of_security", Order = 25, TypeName = "text")]
       public string? rta_type_of_security { get; set; }

       [Column("rta_amt_per_share", Order = 26, TypeName = "float")]
       public long? rta_amt_per_share { get; set; }

       [Column("p_register_comp_add", Order = 27, TypeName = "text")]
       public string? p_register_comp_add { get; set; }

   }
}
