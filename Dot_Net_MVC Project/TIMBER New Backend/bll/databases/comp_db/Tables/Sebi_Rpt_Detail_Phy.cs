using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("sebi_rpt_detail_phy")] 
       
   public class Sebi_Rpt_Detail_Phy
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("dpid", Order = 3, TypeName = "varchar(1)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 4, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("names", Order = 5, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("sur_names", Order = 6, TypeName = "varchar(50)")]
       public string? sur_names { get; set; }

       [Column("pan_no", Order = 7, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("bank_ac_no", Order = 8, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_ifsc_code", Order = 9, TypeName = "varchar(50)")]
       public string? bank_ifsc_code { get; set; }

       [Column("phone", Order = 10, TypeName = "varchar(100)")]
       public string? phone { get; set; }

       [Column("emailid", Order = 11, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("fname", Order = 12, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 13, TypeName = "float")]
       public long? sta { get; set; }

       [Column("ad1", Order = 14, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 15, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 16, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 17, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("pincode", Order = 18, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("foliono_number", Order = 19, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

       [Column("phy_cdsl_nsdl", Order = 20, TypeName = "varchar(8)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("paid_up_capital", Order = 21, TypeName = "bigint(10)")]
       public long? paid_up_capital { get; set; }

       [Column("company_name123", Order = 22, TypeName = "varchar(20)")]
       public string? company_name123 { get; set; }

   }
}
