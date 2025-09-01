using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DB.RTAComp.Tables
{
   [Table ("dnr_upload_1")] 
       
   public class Dnr_Upload_1
   {
       [Key, Column("id", Order = 1, TypeName = " bigint(10) auto_increment"), Required]
       public long? id { get; set; }
       
       [Column("sno_num", Order = 2, TypeName = "float")]
       public long? sno_num { get; set; }

       [Column("bathc_id", Order = 3, TypeName = "varchar(8)")]
       public string? bathc_id { get; set; }

       [Column("dep_id", Order = 4, TypeName = "varchar(8)")]
       public string? dep_id { get; set; }

       [Column("rec_type", Order = 5, TypeName = "varchar(2)")]
       public string? rec_type { get; set; }

       [Column("bp_id", Order = 6, TypeName = "varchar(8)")]
       public string? bp_id { get; set; }

       [Column("bprole", Order = 7, TypeName = "varchar(1)")]
       public string? bprole { get; set; }

       [Column("tnisin", Order = 8, TypeName = "varchar(6)")]
       public string? tnisin { get; set; }

       [Column("totalac", Order = 9, TypeName = "varchar(18)")]
       public string? totalac { get; set; }

       [Column("sumisin", Order = 10, TypeName = "varchar(18)")]
       public string? sumisin { get; set; }

       [Column("filereco", Order = 11, TypeName = "varchar(6)")]
       public string? filereco { get; set; }

       [Column("spetdate", Order = 12, TypeName = "varchar(8)")]
       public string? spetdate { get; set; }

       [Column("creationda", Order = 13, TypeName = "varchar(14)")]
       public string? creationda { get; set; }

   }
}
