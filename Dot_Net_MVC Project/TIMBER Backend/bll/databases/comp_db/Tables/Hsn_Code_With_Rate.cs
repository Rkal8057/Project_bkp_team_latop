using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("hsn_code_with_rate")] 
       
   public class Hsn_Code_With_Rate
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("s_no", Order = 2, TypeName = "varchar(50)")]
       public string? s_no { get; set; }

       [Column("hsn_code", Order = 3, TypeName = "varchar(50)")]
       public string? hsn_code { get; set; }

       [Column("hsn_description", Order = 4, TypeName = "varchar(50)")]
       public string? hsn_description { get; set; }

       [Column("chapter_no", Order = 5, TypeName = "varchar(50)")]
       public string? chapter_no { get; set; }

       [Column("sch_no", Order = 6, TypeName = "varchar(50)")]
       public string? sch_no { get; set; }

       [Column("gst_rate", Order = 7, TypeName = "varchar(50)")]
       public string? gst_rate { get; set; }

   }
}
