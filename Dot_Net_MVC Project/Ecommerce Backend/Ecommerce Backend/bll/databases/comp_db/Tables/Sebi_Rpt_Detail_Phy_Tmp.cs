using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("sebi_rpt_detail_phy_tmp")] 
       
   public class Sebi_Rpt_Detail_Phy_Tmp
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("foliono", Order = 2, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("names", Order = 3, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("sur_names", Order = 4, TypeName = "varchar(50)")]
       public string? sur_names { get; set; }

       [Column("pan_no", Order = 5, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("phone", Order = 6, TypeName = "varchar(100)")]
       public string? phone { get; set; }

       [Column("emailid", Order = 7, TypeName = "varchar(50)")]
       public string? emailid { get; set; }

       [Column("bank_ac_no", Order = 8, TypeName = "varchar(50)")]
       public string? bank_ac_no { get; set; }

       [Column("bank_ifsc_code", Order = 9, TypeName = "varchar(50)")]
       public string? bank_ifsc_code { get; set; }

       [Column("fname", Order = 10, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 11, TypeName = "float")]
       public long? sta { get; set; }

       [Column("ad1", Order = 12, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 13, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 14, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 15, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("pincode", Order = 16, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("share_qty", Order = 17, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("share_qty_pct", Order = 18, TypeName = "float")]
       public long? share_qty_pct { get; set; }

       [Column("company_name123", Order = 19, TypeName = "varchar(20)")]
       public string? company_name123 { get; set; }

   }
}
