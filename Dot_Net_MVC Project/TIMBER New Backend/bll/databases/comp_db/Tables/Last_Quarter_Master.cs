using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("last_quarter_master")] 
       
   public class Last_Quarter_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("share_qty", Order = 2, TypeName = "float")]
       public long? share_qty { get; set; }

       [Column("dpid", Order = 3, TypeName = "varchar(16)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 4, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("names", Order = 5, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("fname", Order = 6, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 7, TypeName = "float")]
       public long? sta { get; set; }

       [Column("pan_no", Order = 8, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("ad1", Order = 9, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 10, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("ad3", Order = 11, TypeName = "varchar(50)")]
       public string? ad3 { get; set; }

       [Column("city", Order = 12, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 13, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("pincode", Order = 14, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("foliono_number", Order = 15, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

       [Column("phy_cdsl_nsdl", Order = 16, TypeName = "varchar(8)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("paid_up_capital", Order = 17, TypeName = "bigint(10)")]
       public long? paid_up_capital { get; set; }

       [Column("cate_1_code", Order = 18, TypeName = "float")]
       public long? cate_1_code { get; set; }

       [Column("cate_2_code", Order = 19, TypeName = "bigint(10)")]
       public long? cate_2_code { get; set; }

       [Column("cate_3_code", Order = 20, TypeName = "bigint(10)")]
       public long? cate_3_code { get; set; }

       [Column("soft_uniq_types", Order = 21, TypeName = "varchar(49)")]
       public string? soft_uniq_types { get; set; }

       [Column("soft_uniq_code", Order = 22, TypeName = "bigint(10)")]
       public long? soft_uniq_code { get; set; }

       [Column("total_count", Order = 23, TypeName = "bigint(10)")]
       public long? total_count { get; set; }

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
