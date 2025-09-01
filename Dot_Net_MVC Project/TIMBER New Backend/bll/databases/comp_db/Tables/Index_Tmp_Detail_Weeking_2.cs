using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("index_tmp_detail_weeking_2")] 
       
   public class Index_Tmp_Detail_Weeking_2
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("dpid", Order = 2, TypeName = "varchar(16)")]
       public string? dpid { get; set; }

       [Column("cl_id", Order = 3, TypeName = "varchar(16)")]
       public string? cl_id { get; set; }

       [Column("fstnm", Order = 4, TypeName = "varchar(50)")]
       public string? fstnm { get; set; }

       [Column("pan_no", Order = 5, TypeName = "varchar(20)")]
       public string? pan_no { get; set; }

       [Column("phy_cdsl_nsdl", Order = 6, TypeName = "varchar(8)")]
       public string? phy_cdsl_nsdl { get; set; }

       [Column("diff_qty", Order = 7, TypeName = "float")]
       public long? diff_qty { get; set; }

       [Column("purc_qty", Order = 8, TypeName = "float")]
       public long? purc_qty { get; set; }

       [Column("sale_qty", Order = 9, TypeName = "float")]
       public long? sale_qty { get; set; }

       [Column("date_25_11_2022_qty", Order = 10, TypeName = "float")]
       public long? date_25_11_2022_qty { get; set; }

       [Column("date_02_12_2022_qty", Order = 11, TypeName = "float")]
       public long? date_02_12_2022_qty { get; set; }

   }
}
