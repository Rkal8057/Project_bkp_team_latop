using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("texla1_tmp_master")] 
       
   public class Texla1_Tmp_Master
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("foliono", Order = 2, TypeName = "varchar(16)")]
       public string? foliono { get; set; }

       [Column("names", Order = 3, TypeName = "varchar(50)")]
       public string? names { get; set; }

       [Column("fname", Order = 4, TypeName = "varchar(100)")]
       public string? fname { get; set; }

       [Column("sta", Order = 5, TypeName = "float")]
       public long? sta { get; set; }

       [Column("panno1", Order = 6, TypeName = "varchar(20)")]
       public string? panno1 { get; set; }

       [Column("ad1", Order = 7, TypeName = "varchar(50)")]
       public string? ad1 { get; set; }

       [Column("ad2", Order = 8, TypeName = "varchar(50)")]
       public string? ad2 { get; set; }

       [Column("city", Order = 9, TypeName = "varchar(50)")]
       public string? city { get; set; }

       [Column("state", Order = 10, TypeName = "varchar(50)")]
       public string? state { get; set; }

       [Column("pincode", Order = 11, TypeName = "varchar(50)")]
       public string? pincode { get; set; }

       [Column("foliono_number", Order = 12, TypeName = "double(18,3)")]
       public long? foliono_number { get; set; }

   }
}
